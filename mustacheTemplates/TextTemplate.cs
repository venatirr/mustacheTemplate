namespace mustacheTemplates
{
	public class TextTemplate : ITemplate
	{
		public string Template
		{
			get { return @"

You just put someone’s phone back in action
{{#newline}}{{#newline}}
We’ve copied your latest top-up details below in case you need them.
{{#newline}}{{#newline}}
Keep creating smiles, one ding* at a time.
{{#newline}}{{#newline}}
We'd love to hear your feedback: https://www.surveymonkey.com/s/5KFFGK6
{{#newline}}{{#newline}}
{{#newline}}
Transaction ID{{#newline}}
{{Name}}
{{#newline}}{{#newline}}
Date & Time{{#newline}}
{{Address.Name}}
{{#newline}}
{{#newline}}{{#newline}}
We do everything we can to deliver your top-up instantly. However, now and then the process can take a little longer so please be patient. If you have any questions, please visit our FAQ section https://www.ding.com/support/faqs/top-up
{{#newline}}{{#newline}}
Download our ding* app for Android and iOS here: http://m.onelink.me/e09fc59f
{{#newline}}{{#newline}}
This is your confirmation that you have agreed and authorised ezetop/ding to send top-up to the recipient and that the relevant operator shall be solely liable to the recipient of top -up for the provision of mobile services related to the top-up.
{{#newline}}{{#newline}}
www.ding.com is operated by ezetop. Ezetop t/a ding is registered in Ireland, with registration number 422514, and its registered address is Brooklawn House, Shelbourne Road, Dublin 4, Ireland.

"; }
		}
	}
}