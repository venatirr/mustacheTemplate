using System;
using System.Collections.Generic;
using System.Dynamic;
using Mustache;

namespace mustacheTemplates
{
	class Program
	{
		static void Main(string[] args)
		{
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
														Amount = new Money{Value = 10.4, Currency = "USD"}
													},
													new OrderItem
													{
														ProductTypeName = "ILDTopup",
														Detail1 = "ILD Detail 1",
														Detail2 = "ILD Detail 2"
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


			ITemplate template = new SimpleTemplate();

			FormatCompiler compiler = new FormatCompiler();
			Generator generator = compiler.Compile(template.Template);
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
}
