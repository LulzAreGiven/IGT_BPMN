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

        private Task _selectedTask;

        public Task SelectedTask
        {
            get { return _selectedTask; }
            set
            {
                Set(ref _selectedTask, value);
                GetPrecisionAndRecall();
            }
        }

        private double _precision;
        public double Precision { get { return _precision; } set { Set(ref _precision, value); } }
        private double _recall;
        public double Recall { get { return _recall; } set { Set(ref _recall, value); } }
        private double _fMeasure;
        public double FMeasure { get { return _fMeasure; } set { Set(ref _fMeasure, value); } }
        private List<string> _service;
        public List<string> Service { get { return _service; } set { Set(ref _service, value); } }

        public RelayCommand OpenFileDialogCommand { get; private set; }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IParse parser)
        {
            Parser = parser;
            OpenFileDialogCommand = new RelayCommand(OpenDialog);
            Services = Parser.ParseWsdlFiles();
        }

        private void GetPrecisionAndRecall()
        {
            var tempList = Parser.GetPrecisionRecallFMeasure(SelectedTask);
            Precision = tempList[0];
            Recall = tempList[1];
            FMeasure = tempList[2];
            Service = Parser.GetBestService();
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