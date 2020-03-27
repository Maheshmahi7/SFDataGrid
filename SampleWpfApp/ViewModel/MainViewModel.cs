using System.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;
using SampleDataContract.DataContract;
using SampleWpfApp.View;
using ServiceReference.ServiceProxy;

namespace SampleWpfApp.ViewModel
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
		private string displayData;
		private ObservableCollection<Student> studentList;

		#endregion

		#region Properties

		public string DisplayData
		{
			get => this.displayData;

			set
			{
				this.displayData = value;
				this.RaisePropertyChanged();
			}
		}

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

		#region Commands

		public RelayCommand ButtonClickCommand { get; set; }

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the MainViewModel class.
		/// </summary>
		public MainViewModel()
		{
			this.wcfConsumer = new WCFConsumer();
			this.ButtonClickCommand = new RelayCommand(this.ExecuteButtonCommand);
			this.PopulateStudentData();
		}

		#endregion

		#region Private methods

		private void ExecuteButtonCommand()
		{
			AddStudent addStudent = new AddStudent();
			var dataContext = new AddStudentViewModel();
			dataContext.CloseWindow += (sender, e) => { addStudent.Close(); };
			addStudent.DataContext = dataContext;
			addStudent.ShowDialog();
			if (!string.IsNullOrWhiteSpace(dataContext.Name))
			{
				this.StudentList.Add(new Student { Id = this.StudentList.Count + 1, Name = dataContext.Name });
			}
		}

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