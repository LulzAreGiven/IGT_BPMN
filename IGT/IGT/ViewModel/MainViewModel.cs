using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using IGT.Model;
using IGT.Model.BPMN;
using IGT.Model.WSDL;
using Microsoft.Win32;
using System.Collections.Generic;
using Definitions = IGT.Model.WSDL.Definitions;

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
            set { Set(ref _tasks, value); }
        }

        private List<Definitions> _services = new List<Definitions>();

        public List<Definitions> Services
        {
            get { return _services; }
            set { Set(ref _services, value); }
        }

        public double Precision { get; set; } = 30;

        public double Recall { get; set; } = 60;

        public double FMeasure { get; set; } = 23;

        public RelayCommand OpenFileDialogCommand { get; private set; }
        public RelayCommand ComputePrecisionAndRecallOnSelectionChangedCommand { get; private set; }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IParse parser)
        {
            Parser = parser;
            OpenFileDialogCommand = new RelayCommand(OpenDialog);
            ComputePrecisionAndRecallOnSelectionChangedCommand = new RelayCommand(GetPrecisionAndRecall);
            Services = Parser.ParseWsdlFiles();
        }

        private void GetPrecisionAndRecall()
        {
        }

        private void OpenDialog()
        {
            var dialog = new OpenFileDialog { Filter = "BPMN Files| *.bpmn" };
            if (dialog.ShowDialog() == true)
            {
                Tasks = Parser.GetTasks(dialog.FileName);
            }
        }
    }
}