using GalaSoft.MvvmLight;
using IGT.Model;
using IGT.Model.BPMN;
using System.Collections.Generic;
using GalaSoft.MvvmLight.Command;
using Microsoft.Win32;

namespace IGT.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private IParse Parser { get; set; }
        private List<Task> _tasks = new List<Task>();

        public List<Task> Tasks
        {
            get { return _tasks; }
            set
            {
                if (value != null)
                {
                    _tasks = value;
                    RaisePropertyChanged();
                }
            }
        }

        public double Precision { get; set; } = 30;

        public double Recall { get; set; } = 60;

        public double FMeasure { get; set; } = 23;

        public RelayCommand OpenFileDialogCommand { get; private set; }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IParse parser)
        {
            Parser = parser;
            OpenFileDialogCommand = new RelayCommand(OpenDialog);
            Parser.ParseWsdlFiles();
        }

        private void OpenDialog()
        {
            var dialog = new OpenFileDialog {Filter = "BPMN Files| *.bpmn"};
            if (dialog.ShowDialog() == true)
            {
                var test = dialog.FileName;
                Tasks = Parser.GetTasks(test);
            }

        }
    }
}