using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataContract.DataContract
{
	public class Order : INotifyPropertyChanged
	{
		private int id;
		private int productQuantity;
		private DateTime orderDateTime;
		private string productName;
		private double productRate;

		public int Id
		{
			get => this.id;

			set
			{
				this.id = value;
				this.OnPropertyChanged();
			}
		}

		public string ProductName
		{
			get => this.productName;

			set
			{
				this.productName = value;
				this.OnPropertyChanged();
			}
		}

		public double ProductRate
		{
			get => this.productRate;

			set
			{
				this.productRate = value;
				this.OnPropertyChanged();
			}
		}

		public int ProductQuantity
		{
			get => this.productQuantity;

			set
			{
				this.productQuantity = value;
				this.OnPropertyChanged();
			}
		}

		public DateTime OrderDateTime
		{
			get => this.orderDateTime;

			set
			{
				this.orderDateTime = value;
				this.OnPropertyChanged();
			}
		}

		public double Amount
		{
			get => this.ProductRate * this.ProductQuantity;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged([CallerMemberName]string propertyName = null)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
