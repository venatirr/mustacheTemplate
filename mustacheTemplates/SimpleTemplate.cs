namespace mustacheTemplates
{
	public class SimpleTemplate : ITemplate
	{
		public string Template
		{
			get { return @"


[? {{test1}} valid conditional [? {{test2}} conditional inside another conditional [? {{test3}} conditional inside another conditional ?] ?]  ?]



"; }
		}
	}
}