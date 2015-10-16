using System;
using System.Collections.Generic;
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

		private  readonly Dictionary<string, string> tokens = new Dictionary<string, string>
														{
															{"{{TaxName}}", null},
															{"{{ReceivedTopUpAmountExTaxToDestinationCountry}}", null},
															{"{{PromotionalDiscount}}", "PromoCode"},
															{"{{HasReferralCampaign}}", null},
															{"{{EmailSnippet}}",null}
														};


		public string ConvertDingConditionalToMustache(string template)
		{
			foreach (string token in tokens.Keys)
			{
				var expressionToEvaluate = string.IsNullOrWhiteSpace(tokens[token]) ? TokenWithoutBrakets(token) : tokens[token];
				do
				{
					template = ReplaceDingConditionalWithMustacheOne(template, token, expressionToEvaluate);
				} while (template.Contains(token));
			}

			template = RestoreInitialTokens(template);

			return template;
		}

		private string ReplaceDingConditionalWithMustacheOne(string template, string token, string expressionToEvaluate)
		{
			if (template == null || token == null) return template;

			var indexOfToken = template.IndexOf(token, StringComparison.InvariantCultureIgnoreCase);
			if (indexOfToken <= 0) return template;


			var indexOfStartDingSeparator = template.LastIndexOf(startDingConditional, indexOfToken, StringComparison.InvariantCultureIgnoreCase);
			var indexOfEndDingSeparator = template.IndexOf(endDingConditional, indexOfToken, StringComparison.InvariantCultureIgnoreCase) + endDingConditional.Length;
			var originalDingSnippet = template.Substring(indexOfStartDingSeparator, indexOfEndDingSeparator - indexOfStartDingSeparator);

			var tokenWithoutbrakets = TokenWithoutBrakets(token);
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

			foreach (string token in tokens.Keys)
			{
				var tokenWithoutbrakets = TokenWithoutBrakets(token);
				sb.Replace(tokenWithoutbrakets + mustacheSuffix, tokenWithoutbrakets);
			}

			return sb.ToString();
		}
	}
}