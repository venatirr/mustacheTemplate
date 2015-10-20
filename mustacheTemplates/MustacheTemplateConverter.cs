using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mustacheTemplates
{
	public class MustacheTemplateConverter
	{
		private const string startDingConditional = "[?";
		private const string endDingConditional = "?]";
		private const string startMustacheConditional = "{{{{#if {0}}}}}";
		private const string endMustacheConditional = "{{/if}}";
		private const string mustacheSuffix = "Mustache";
		private const string startToken = "{{";
		private const string endToken = "}}";

		readonly List<string> conditionalTokens = new List<string>();

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
			conditionalTokens.Clear();

			List<string> allConditionals = ExtractFromString(template, startDingConditional, endDingConditional);

			foreach (var conditional in allConditionals)
			{
				var tokens = ExtractFromString(conditional, startToken, endToken);
				foreach (var token in tokens.Where(token => !conditionalTokens.Contains(token)))
				{
					conditionalTokens.Add(token);
				}
			}

			return conditionalTokens
				.Select(token => ("{{" + token + "}}"))
				.ToList();
		}

		private string ReplaceDingConditionalWithMustacheOne(string template, string token, string expressionToEvaluate)
		{
			if (template == null || token == null) return template;

			var tokenWithoutbrakets = TokenWithoutBrakets(token);

			var indexOfToken = template.IndexOf(token, StringComparison.InvariantCultureIgnoreCase);
			if (indexOfToken <= 0) return template;

			var indexOfStartDingSeparator = template.LastIndexOf(startDingConditional, indexOfToken, StringComparison.InvariantCultureIgnoreCase);
			if (indexOfStartDingSeparator < 0)
			{
				template = template.Replace(tokenWithoutbrakets, tokenWithoutbrakets + mustacheSuffix);
				return template;
			}

			var indexOfEndDingSeparator = template.IndexOf(endDingConditional, indexOfToken, StringComparison.InvariantCultureIgnoreCase) + endDingConditional.Length;
			if (indexOfEndDingSeparator < indexOfStartDingSeparator)
			{
				template = template.Replace(tokenWithoutbrakets, tokenWithoutbrakets + mustacheSuffix);
				return template;
			}

			var originalDingSnippet = template.Substring(indexOfStartDingSeparator, indexOfEndDingSeparator - indexOfStartDingSeparator);
		
			var alteredDingSnippet = originalDingSnippet.Replace(tokenWithoutbrakets, tokenWithoutbrakets + mustacheSuffix);
			var mustacheSnippet = BuildMustacheConditional(alteredDingSnippet, expressionToEvaluate);

			StringBuilder sb = new StringBuilder(template);
			sb = sb.Replace(originalDingSnippet, mustacheSnippet);

			return sb.ToString();
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

		private static List<string> ExtractFromString(string text, string startString, string endString)
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
	}
}