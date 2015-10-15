namespace mustacheTemplates
{
	public class SimpleTemplate : ITemplate
	{
		public string Template
		{
			get { return @"
{{Value1}}
{{Value2}}
"; }
		}
	}
}