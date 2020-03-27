using System.Collections.ObjectModel;
using System.Linq;
using GalaSoft.MvvmLight;
using SampleDataContract.DataContract;
using ServiceReference.ServiceProxy;

namespace SampleOrderDetails.ViewModel
{
	/// <summary>
	/// This class contains properties that the main View can data bind to.
	/// <para>
	/// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
	/// </para>
	/// <para>
	/// You can also use Blend to data bind with the tool's support.
	/// </para>
	/// <para>
	/// See http://www.galasoft.ch/mvvm
	/// </para>
	/// </summary>
	public class MainViewModel : ViewModelBase
	{
		#region Fields

		private IWCFConsumer wcfConsumer;
		private ObservableCollection<Order> orderDetails;

		#endregion

		#region Properties

		public ObservableCollection<Order> OrderDetails
		{
			get => this.orderDetails;

			set
			{
				this.orderDetails = value;
				this.RaisePropertyChanged();
			}
		}

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the MainViewModel class.
		/// </summary>
		public MainViewModel()
		{
			this.wcfConsumer = new WCFConsumer();
			this.PopulateOrderData();
		}

		#endregion

		#region Private methods

		private void PopulateOrderData()
		{
			this.OrderDetails = new ObservableCollection<Order>();
			var orderData = this.wcfConsumer.GetOrderDetails().ToList();
			foreach (var data in orderData)
			{
				this.OrderDetails.Add(data);
			}
		}

		#endregion
	}
}