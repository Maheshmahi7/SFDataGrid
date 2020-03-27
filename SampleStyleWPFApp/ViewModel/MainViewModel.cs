using System.Collections.ObjectModel;
using System.Linq;
using GalaSoft.MvvmLight;
using SampleDataContract.DataContract;
using ServiceReference.ServiceProxy;

namespace SampleStyleWPFApp.ViewModel
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
		private ObservableCollection<Student> studentList;

		#endregion

		#region Properties

		public ObservableCollection<Student> StudentList
		{
			get => this.studentList;

			set
			{
				this.studentList = value;
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
			this.PopulateStudentData();
		}

		#endregion

		#region Private methods

		private void PopulateStudentData()
		{
			this.StudentList = new ObservableCollection<Student>();
			var studentDetails = this.wcfConsumer.GetStudentsData().ToList();
			foreach (var data in studentDetails)
			{
				this.StudentList.Add(data);
			}
		}

		#endregion
	}
}