using GalaSoft.MvvmLight;
using IGT.Model;
using IGT.Model.BPMN;
using System.Collections.Generic;

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
        private List<Task> _tasks = new List<Task>();

        public List<Task> Tasks
        {
            get { return _tasks; }
            set
            {
                if (value != null)
                {
                    _tasks = value;
                }
            }
        }

        public double Precision { get; set; } = 30;

        public double Recall { get; set; } = 60;

        public double FMeasure { get; set; } = 23;

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IParse parser)
        {
            Tasks = parser.GetTasks();
            parser.ParseWsdlFiles();
        }
    }
}