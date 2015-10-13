using System;
using Mustache;

namespace mustacheTemplates
{
	class Program
	{
		static void Main(string[] args)
		{
			var templateModel = new TemplateModel()
								{
									Name = "Bob",
									Address = new Address
											{
												Name = "Bucharest"
											}
								};

			ITemplate template = new TextTemplate();
			

			FormatCompiler compiler = new FormatCompiler();
			Generator generator = compiler.Compile(template.Template);
			string result = generator.Render(templateModel);

			Console.Out.WriteLine(result);
		}
	}

	public class TemplateModel
	{
		public string Name { get; set; }
		public Address Address { get; set; }
	}

	public class Address
	{
		public string Name { get; set; }
	}
}
