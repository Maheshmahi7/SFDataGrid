using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SampleData.Data;
using SampleDataContract.DataContract;

namespace SampleService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
	public class SampleService1 : ISampleService1
	{
		private DataPopulator dataPopulator;

		public SampleService1()
		{
			this.dataPopulator = new DataPopulator();
		}

		public string GetData()
		{
			return "Hello";
		}

		public IEnumerable<Student> GetStudents()
		{
			return this.dataPopulator.PopulateStudentData();
		}
	}
}
