using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleData.Data;
using SampleDataContract.DataContract;

namespace ServiceReference.ServiceProxy
{
	public class WCFConsumer : IWCFConsumer
	{
		private ServiceReference.ServiceReference1.SampleService1Client serviceReference;
		private DataPopulator dataPopulator;

		public WCFConsumer()
		{
			this.serviceReference = new ServiceReference.ServiceReference1.SampleService1Client();
			this.dataPopulator = new DataPopulator();
		}

		public IEnumerable<Student> GetStudentsData()
		{
			return this.serviceReference.GetStudents();
		}

		public IEnumerable<Order> GetOrderDetails()
		{
			return this.dataPopulator.PopulateOrderData();
		}
	}
}
