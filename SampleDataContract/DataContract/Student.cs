using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataContract.DataContract
{
	[DataContract]
	public class Student : INotifyPropertyChanged
	{
		#region fields

		private int id;
		private string name;
		private string country;
		private int grade;

		#endregion

		#region Property

		[DataMember]
		public int Id
		{
			get => this.id;

			set
			{
				this.id = value;
				this.OnPropertyChanged();
			}
		}

		[DataMember]
		public string Name
		{
			get => this.name;

			set
			{
				this.name = value;
				this.OnPropertyChanged();
			}
		}

		[DataMember]
		public string Country
		{
			get => this.country;

			set
			{
				this.country = value;
				this.OnPropertyChanged();
			}
		}

		[DataMember]
		public int Grade
		{
			get => this.grade;

			set
			{
				this.grade = value;
				this.OnPropertyChanged();
			}
		}

		#endregion

		#region PropertyChanged

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged([CallerMemberName]string propertyName = null)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

	}
}
