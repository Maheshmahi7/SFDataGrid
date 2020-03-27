using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleDataContract.DataContract;

namespace SampleData.Data
{
	public class DataPopulator
	{
		public DataPopulator()
		{
		}

		public IEnumerable<Student> PopulateStudentData()
		{
			return new List<Student>
			{
				new Student{Id =1,  Name="Mahesh",    Country="India",      Grade = 8, },
				new Student{Id =2,  Name="Logesh",    Country="Singapore",  Grade = 6, },
				new Student{Id =3,  Name="Balaji",    Country="USA",        Grade = 7, },
				new Student{Id =4,  Name="Rathish",   Country="USA",        Grade = 5, },
				new Student{Id =5,  Name="Monica",    Country="Singapore",  Grade = 7, },
				new Student{Id =6,  Name="Sindhu",    Country="India",      Grade = 9, },
				new Student{Id =7,  Name="Anu",       Country="Singapore",  Grade = 6, },
				new Student{Id =8,  Name="Suriya",    Country="India",      Grade = 3, },
				new Student{Id =9,  Name="Aravinth",  Country="Singapore",  Grade = 4, },
				new Student{Id =10, Name="Lalith",    Country="USA",        Grade = 6, },
				new Student{Id =11, Name="Vijay",     Country="Singapore",  Grade = 7, },
				new Student{Id =12, Name="Arun",      Country="USA",        Grade = 4, },
				new Student{Id =13, Name="Guru",      Country="Singapore",  Grade = 4, },
			};
		}

		public IEnumerable<Order> PopulateOrderData()
		{
			return new List<Order>
			{
				new Order{Id = 1, ProductName = "Apple",			OrderDateTime = Convert.ToDateTime("03/12/2020", CultureInfo.InvariantCulture), ProductQuantity = 3, ProductRate = 3.00, },
				new Order{Id = 1, ProductName = "Pineapple",	OrderDateTime = Convert.ToDateTime("03/12/2020", CultureInfo.InvariantCulture), ProductQuantity = 2, ProductRate = 5.00, },
				new Order{Id = 1, ProductName = "Orange",			OrderDateTime = Convert.ToDateTime("03/12/2020", CultureInfo.InvariantCulture), ProductQuantity = 4, ProductRate = 2.00, },
				new Order{Id = 2, ProductName = "Grapes",			OrderDateTime = Convert.ToDateTime("03/13/2020", CultureInfo.InvariantCulture), ProductQuantity = 7, ProductRate = 4.00, },
				new Order{Id = 2, ProductName = "Custard",		OrderDateTime = Convert.ToDateTime("03/13/2020", CultureInfo.InvariantCulture), ProductQuantity = 5, ProductRate = 8.00, },
				new Order{Id = 2, ProductName = "Mango",			OrderDateTime = Convert.ToDateTime("03/13/2020", CultureInfo.InvariantCulture), ProductQuantity = 4, ProductRate = 6.00, },
				new Order{Id = 3, ProductName = "Apple",			OrderDateTime = Convert.ToDateTime("02/22/2020", CultureInfo.InvariantCulture), ProductQuantity = 6, ProductRate = 3.00, },
				new Order{Id = 3, ProductName = "Mango",			OrderDateTime = Convert.ToDateTime("02/22/2020", CultureInfo.InvariantCulture), ProductQuantity = 8, ProductRate = 6.00, },
				new Order{Id = 3, ProductName = "Grapes",			OrderDateTime = Convert.ToDateTime("02/22/2020", CultureInfo.InvariantCulture), ProductQuantity = 2, ProductRate = 4.00, },
				new Order{Id = 4, ProductName = "Pineapple",	OrderDateTime = Convert.ToDateTime("02/20/2020", CultureInfo.InvariantCulture), ProductQuantity = 1, ProductRate = 5.00, },
				new Order{Id = 4, ProductName = "Mango",			OrderDateTime = Convert.ToDateTime("02/20/2020", CultureInfo.InvariantCulture), ProductQuantity = 8, ProductRate = 6.00, },
				new Order{Id = 4, ProductName = "Orange",			OrderDateTime = Convert.ToDateTime("02/20/2020", CultureInfo.InvariantCulture), ProductQuantity = 7, ProductRate = 2.00, },
				new Order{Id = 5, ProductName = "Apple",			OrderDateTime = Convert.ToDateTime("02/23/2020", CultureInfo.InvariantCulture), ProductQuantity = 5, ProductRate = 3.00, },
				new Order{Id = 5, ProductName = "Orange",			OrderDateTime = Convert.ToDateTime("02/23/2020", CultureInfo.InvariantCulture), ProductQuantity = 5, ProductRate = 2.00, },
				new Order{Id = 5, ProductName = "Custard",		OrderDateTime = Convert.ToDateTime("02/23/2020", CultureInfo.InvariantCulture), ProductQuantity = 2, ProductRate = 8.00, },
				new Order{Id = 6, ProductName = "Apple",			OrderDateTime = Convert.ToDateTime("02/26/2020", CultureInfo.InvariantCulture), ProductQuantity = 7, ProductRate = 3.00, },
				new Order{Id = 6, ProductName = "Pineapple",	OrderDateTime = Convert.ToDateTime("02/26/2020", CultureInfo.InvariantCulture), ProductQuantity = 8, ProductRate = 5.00, },
				new Order{Id = 6, ProductName = "Mango",			OrderDateTime = Convert.ToDateTime("02/26/2020", CultureInfo.InvariantCulture), ProductQuantity = 9, ProductRate = 6.00, },
			};
		}
	}
}
