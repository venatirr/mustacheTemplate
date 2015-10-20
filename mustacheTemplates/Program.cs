using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Dynamic;
using System.IO;
using System.Text.RegularExpressions;
using Mustache;

namespace mustacheTemplates
{
	class Program
	{
		static void Main()
		{
			TestExistingTemplates.Test();


			var orderModel = new Order()
								{
									Name = "Bob's order",
									TransactionID = "10000",
									OrderItems = new List<OrderItem>()
												{
													new OrderItem
													{
														ProductTypeName = "MobileRecharge",
														Detail1 = "Mobile Detail 1",
														Detail2 = "Mobile Detail 2",
														Amount = new Money{Value = 10.4, Currency = "USD"},
														PromotionalDiscount = "100 USD"
													},
													new OrderItem
													{
														ProductTypeName = "ILDTopup",
														Detail1 = "ILD Detail 1",
														Detail2 = "ILD Detail 2",
													},
													new OrderItem
													{
														ProductTypeName = "Nauta",
														Detail1 = "Nauta Detail 1",
														Detail2 = "Nauta Detail 2"
													}
												}
								};

			var dict = new Dictionary<string, object>
						{
							{"Value1", "Value1"}
						};


			ITemplate template = new TextTemplate();

			FormatCompiler compiler = new FormatCompiler();

			var templateParser = new MustacheTemplateConverter();

			Generator generator = compiler.Compile(templateParser.ConvertDingConditionalToMustache(template.Template));
			generator.KeyNotFound += (obj, args) =>
									{
										args.Substitute = string.Empty;
										args.Handled = true;
									};

			string result = generator.Render(MyConvert.DictionaryToDynamic(dict));

			Console.ReadKey();
		}
	}

	public static class MyConvert
	{
		public static ExpandoObject DictionaryToDynamic(Dictionary<string, object> source)
		{
			var eo = new ExpandoObject();
			var eoColl = (ICollection<KeyValuePair<string, object>>)eo;

			foreach (var kvp in source)
			{
				eoColl.Add(kvp);
			}

			return eo;
		}

		public static dynamic ToDynamicObject()
		{
			dynamic model = new MyDynamic();
			model.Value1 = "Test";
			model.Value2 = "Test";

			return model;
		}
	}

	public class Order
	{
		public string Name { get; set; }
		public string TransactionID { get; set; }

		public List<OrderItem> OrderItems { get; set; }
	}

	public class OrderItem
	{
		public string ProductTypeName { get; set; }
		public string Detail1 { get; set; }
		public string Detail2 { get; set; }
		public string PromotionalDiscount { get; set; }
		public Money Amount { get; set; }

		public bool IsMobileRecharge { get { return ProductTypeName == "MobileRecharge"; } }
		public bool IsIld { get { return ProductTypeName == "ILDTopup"; } }
		public bool IsNauta { get { return ProductTypeName == "Nauta"; } }
	}

	public class Money
	{
		public double Value { get; set; }
		public string Currency { get; set; }

		public override string ToString()
		{
			return string.Format("{0} {1}", Value, Currency);
		}
	}

	public class MyDynamic : DynamicObject
	{
		private readonly StringDictionary properties;

		public MyDynamic()
		{
			properties = new StringDictionary();
		}

		public override bool TrySetMember(SetMemberBinder binder, object value)
		{
			var propertyName = binder.Name;

			if (properties.ContainsKey(propertyName))
				properties[propertyName] = value.ToString();
			else
				properties.Add(propertyName, value.ToString());

			return true;
		}

		public override bool TryGetMember(GetMemberBinder binder, out object result)
		{
			var propertyName = binder.Name;

			result = properties.ContainsKey(propertyName)
				? properties[propertyName]
				: string.Empty;

			return true;
		}

	}


	public class TestExistingTemplates
	{
		public static void Test()
		{
			return;

			var files = Directory.GetFiles("ToTest");
			var templateParser = new MustacheTemplateConverter();

			Console.WriteLine("Number of files {0}", files.Length);



			var i = 0;
			foreach (var file in files)
			{

				Console.WriteLine("Testing {0}", file);

				var content = File.ReadAllText(file);

				var xx = new Regex(Regex.Escape("[?")).Matches(content).Count;

				var temp = templateParser.ConvertDingConditionalToMustache(content);

				if (temp.Contains("[?") || temp.Contains("?]"))
					throw new Exception("Conversion failed");

				Console.WriteLine("Tested {0} files", i++);


			}

			Console.WriteLine("Tested all files");

		}
	}

}
