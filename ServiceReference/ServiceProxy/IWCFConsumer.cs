using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleDataContract.DataContract;

namespace ServiceReference.ServiceProxy
{
	public interface IWCFConsumer
	{
		IEnumerable<Student> GetStudentsData();

		IEnumerable<Order> GetOrderDetails();
	}
}
