using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace mustacheTemplates
{
	public class MustacheTemplateConverter
	{
		private const string startDingConditional = "[?";
		private const string endDingConditional = "?]";
		private const string tmpStartDingConditional = "[[";
		private const string tmpEndDingConditional = "]]";
		private const string startMustacheConditional = "{{{{#if {0}}}}}";
		private const string endMustacheConditional = "{{/if}}";
		private const string mustacheSuffix = "Mustache";
		private const string startToken = "{{";
		private const string endToken = "}}";

		private List<string> conditionalTokens = new List<string>();

		public string ConvertDingConditionalToMustache(string template)
		{
			List<string> allConditionals = GetConditionalTokens(template);

			foreach (string token in allConditionals)
			{
				var expressionToEvaluate = ExpressionToEvaluate(token);
				do
				{
					template = ReplaceDingConditionalWithMustacheOne(template, token, expressionToEvaluate);
				} while (template.Contains(token));
			}

			template = RestoreInitialTokens(template);

			return template;
		}

		private string ExpressionToEvaluate(string token)
		{
			switch (token)
			{
				case "{{PromotionalDiscount}}" :
					return "PromoCode";
				default :
					return TokenWithoutBrakets(token);
			}

		}

		private List<string> GetConditionalTokens(string template)
		{

			conditionalTokens = GetAllTokens(template);

			return conditionalTokens;
		}

		private string ReplaceDingConditionalWithMustacheOne(string template, string token, string expressionToEvaluate)
		{
			if (template == null || token == null) return template;

			var tokenWithoutBrackets = TokenWithoutBrakets(token);

			var indexOfToken = template.IndexOf(token, StringComparison.InvariantCultureIgnoreCase);
			if (indexOfToken <= 0) return template;

			var indexOfStartDingSeparator = template.LastIndexOf(startDingConditional, indexOfToken, StringComparison.InvariantCultureIgnoreCase);
			if (indexOfStartDingSeparator < 0)
			{
				template = ReplaceToken(template, token, tokenWithoutBrackets);
				return template;
			}

			var indexOfEndDingSeparator = template.IndexOf(endDingConditional, indexOfToken, StringComparison.InvariantCultureIgnoreCase) + endDingConditional.Length;
			if (indexOfEndDingSeparator < indexOfStartDingSeparator)
			{
				template = ReplaceToken(template, token, tokenWithoutBrackets);
				return template;
			}

			var originalDingSnippet = template.Substring(indexOfStartDingSeparator, indexOfEndDingSeparator - indexOfStartDingSeparator);

			var lastNestedEndOfDingSeparator = CalculateLastNestedEndOfDingSeparator(template, originalDingSnippet, indexOfToken);

			string alteredDingSnippet;
			if (indexOfEndDingSeparator != lastNestedEndOfDingSeparator && lastNestedEndOfDingSeparator > indexOfEndDingSeparator)
			{
				var nestedAlteredDingSnippet = template.Substring(indexOfStartDingSeparator, lastNestedEndOfDingSeparator - indexOfStartDingSeparator);
				nestedAlteredDingSnippet = ReplaceNestedDingConditionals(nestedAlteredDingSnippet);
				alteredDingSnippet = ReplaceFirstOccurence(nestedAlteredDingSnippet, tokenWithoutBrackets, tokenWithoutBrackets + mustacheSuffix);

				originalDingSnippet = template.Substring(indexOfStartDingSeparator, lastNestedEndOfDingSeparator - indexOfStartDingSeparator);
			}
			else
			{
				alteredDingSnippet = ReplaceToken(originalDingSnippet, token, tokenWithoutBrackets);
			}

			var mustacheSnippet = BuildMustacheConditional(alteredDingSnippet, expressionToEvaluate);
			mustacheSnippet = RestoreDingConditionals(mustacheSnippet);

			StringBuilder sb = new StringBuilder(template);
			sb = sb.Replace(originalDingSnippet, mustacheSnippet);

			return sb.ToString();
		}

		private string RestoreDingConditionals(string mustacheSnippet)
		{
			var sb = new StringBuilder(mustacheSnippet);
			sb = sb
				.Replace(tmpStartDingConditional, startDingConditional)
				.Replace(tmpEndDingConditional, endDingConditional);

			return sb.ToString();
		}

		private string ReplaceNestedDingConditionals(string originalDingSnippet)
		{
			var sb = originalDingSnippet.Substring(startDingConditional.Length, originalDingSnippet.Length - startDingConditional.Length - endDingConditional.Length);
			sb = sb
				.Replace(startDingConditional, tmpStartDingConditional)
				.Replace(endDingConditional, tmpEndDingConditional);

			return string.Format("{0} {1} {2}", startDingConditional, sb, endDingConditional);
		}

		private int CalculateLastNestedEndOfDingSeparator(string template, string originalDingSnippet, int indexOfToken)
		{
			var numberOfNested = new Regex(Regex.Escape(startDingConditional)).Matches(originalDingSnippet).Count;

			var indexOfEndDingSeparator = NthIndexOf(template, endDingConditional, numberOfNested) + endDingConditional.Length;

			return indexOfEndDingSeparator;
		}

		private static int NthIndexOf(string target, string value, int n)
		{
			Match m = Regex.Match(target, "((" + Regex.Escape(value) + ").*?){" + n + "}");

			if (m.Success)
				return m.Groups[2].Captures[n - 1].Index;
			else
				return -1;
		}

		private string ReplaceFirstOccurence(string source, string oldValue, string newValue)
		{
			var regex = new Regex(Regex.Escape(oldValue));
			var newText = regex.Replace(source, newValue, 1);

			return newText;
		}

		private string BuildMustacheConditional(string dingSnippet, string expressionToEvaluate)
		{
			StringBuilder sb = new StringBuilder(dingSnippet);

			sb = sb.Replace(startDingConditional, string.Format(startMustacheConditional, expressionToEvaluate));
			sb = sb.Replace(endDingConditional, endMustacheConditional);
			
			return sb.ToString();
		}

		private string TokenWithoutBrakets(string token)
		{
			return token.Replace("{{", "").Replace("}}","");
		}

		private string RestoreInitialTokens(string template)
		{
			StringBuilder sb = new StringBuilder(template);

			foreach (string token in conditionalTokens)
			{
				var tokenWithoutbrakets = TokenWithoutBrakets(token);
				sb.Replace(tokenWithoutbrakets + mustacheSuffix, tokenWithoutbrakets);
			}

			return sb.ToString();
		}

		private List<string> ExtractFromString(string text, string startString, string endString)
		{
			List<string> matched = new List<string>();
			int indexStart = 0, indexEnd = 0;
			bool exit = false;

			while (!exit)
			{
				indexStart = text.IndexOf(startString);
				indexEnd = text.IndexOf(endString);
				if (indexStart != -1 && indexEnd != -1)
				{
					matched.Add(text.Substring(indexStart + startString.Length,
						indexEnd - indexStart - startString.Length));
					text = text.Substring(indexEnd + endString.Length);
				}
				else
					exit = true;
			}
			return matched;
		}

		private string ReplaceToken(string source, string token, string tokenWithoutBrackets)
		{
			return source.Replace(token, string.Format("{{{{{0}{1}}}}}", tokenWithoutBrackets, mustacheSuffix));
		}

		private List<string> GetAllTokens(string source)
		{
			Regex regex = new Regex("{{(.*?)}}");
			var matches = regex.Matches(source);

			List<string> list = new List<string>();
			foreach (object match in matches.Cast<object>().Where(match => !list.Contains(match.ToString())))
			{
				list.Add(match.ToString());
			}
			return list;
		}
	}
}