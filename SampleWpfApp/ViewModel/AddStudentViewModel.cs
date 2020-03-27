using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace SampleWpfApp.ViewModel
{
	public class AddStudentViewModel : ViewModelBase
	{
		#region field
		private string name;
		#endregion

		#region Property

		public string Name
		{
			get => this.name;

			set
			{
				this.name = value;
				this.RaisePropertyChanged();
			}
		}

		#endregion

		#region Events

		public event EventHandler CloseWindow;

		#endregion

		#region Command

		public RelayCommand SaveStudentCommand { get; set; }
		#endregion

		#region Constructor


		public AddStudentViewModel()
		{
			this.SaveStudentCommand = new RelayCommand(this.ExecuteSaveCommand, this.CanExecuteSaveCommand);
		}

		#endregion

		#region private method

		private void ExecuteSaveCommand()
		{
			if(this.CloseWindow != null)
			{
				this.CloseWindow?.Invoke(this, new EventArgs());
			}
		}

		private bool CanExecuteSaveCommand()
		{
			return !string.IsNullOrEmpty(this.Name);
		}

		#endregion
	}
}
