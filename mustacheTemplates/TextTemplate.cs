namespace mustacheTemplates
{
	public class TextTemplate : ITemplate
	{
		public string Template
		{
			get { return @"

Your top-up has been sent.

You just put someone’s phone back in action.

We’ve copied your latest top-up details below in case you need them.

We'd love to hear your feedback: https://www.surveymonkey.com/s/5KFFGK6


Transaction ID
{{OrderId}}

Date & Time
{{OrderDateEst}}

Amount Sent
{{SelectedTopUpAmountToDestinationCountry}}

Top-Up Received
{{ReceivedTopUpAmountIncTaxToDestinationCountry}} [? inc. {{TaxName}}?][?{{ReceivedTopUpAmountExTaxToDestinationCountry}} (Mobile TopUp)?]

[?Promotional Discount 
{{PromotionalDiscount}}?]

Amount Paid
{{PaymentAmountToDestinationCountry}}

Phone Number
{{RechargePhoneNumber}}

Country of Recipient
{{OperatorCountry}}


[?{{HasReferralCampaign}}Invite friends to ding* and earn free top-ups! https://www.ding.com/vouchers?]

[?{{HasReferralCampaign}}Get two hours free Nauta with this promo code https://www.ding.com/countries/caribbean/cuba/nauta?]

We do everything we can to deliver your top-up instantly. However, now and then the process can take a little longer so please be patient. If you have any questions, please visit our FAQ section https://www.ding.com/support/faqs/top-up

Download our ding* app for Android and iOS here: http://m.onelink.me/e09fc59f

This is your confirmation that you have agreed and authorised ezetop/ding to send top-up to the recipient and that the relevant operator shall be solely liable to the recipient of top -up for the provision of mobile services related to the top-up.

www.ding.com is operated by ezetop. Ezetop t/a ding is registered in Ireland, with registration number 422514, and its registered address is Brooklawn House, Shelbourne Road, Dublin 4, Ireland.


"; }
		}
	}
}