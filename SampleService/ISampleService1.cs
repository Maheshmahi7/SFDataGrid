﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SampleDataContract.DataContract;

namespace SampleService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
	[ServiceContract]
	public interface ISampleService1
	{
		[OperationContract]
		string GetData();

		[OperationContract]
		IEnumerable<Student> GetStudents();
	}
}
