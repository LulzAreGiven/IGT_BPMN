using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using IGT.Model.BPMN;

namespace IGT.Model
{
    public class Parser : IParse
    {
        private readonly string _pathBpmn = Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Signavio_A1.bpmn");

        private readonly string[] _wsdlFileStrings =
            Directory.GetFiles(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\"), "*.wsdl");

        public List<string> WsdlNameList { get; set; } = new List<string>();

        private List<string> RelevantServices { get; } = new List<string>();

        public BPMN.Definitions ParseBpmnFile(string path)
        {
            var serializer = new XmlSerializer(typeof(BPMN.Definitions));
            using (var fileStream = new FileStream(path, FileMode.Open))
            {
                var result = (BPMN.Definitions)serializer.Deserialize(fileStream);
                return result;
            }
        }

        public List<BPMN.Task> GetTasks(string path)
        {
            var definition = ParseBpmnFile(path);
            var tasks = definition.Process.Task;
            return tasks;
        }

        public List<WSDL.Definitions> ParseWsdlFiles()
        {
            var tmpList = new List<WSDL.Definitions>();
            foreach (var wsdlFileString in _wsdlFileStrings)
            {
                var serializer = new XmlSerializer(typeof(WSDL.Definitions));
                using (var fileStream = new FileStream(wsdlFileString, FileMode.Open))
                {
                    var result = (WSDL.Definitions)serializer.Deserialize(fileStream);
                    tmpList.Add(result);
                    WsdlNameList.Add(result.Name.ToLower());
                }
            }
            return tmpList;
        }

        private double GetPrecision(Task task)
        {
            return (CountRelevantServices(task.Name.ToLower().Split(' ').ToList())) /
                            _wsdlFileStrings.Length;
        }

        private double GetRecall(Task task)
        {
            var relevantDocumentsCount = CountRelevantServices(task.Name.ToLower().Split(' ').ToList());
            return (relevantDocumentsCount)/relevantDocumentsCount; //gehen davon aus, dass wir immer alle relevanten Services gefunden haben -> 1
        }

        private double CountRelevantServices(List<string> chunkList)
        {
            RelevantServices.Clear();

            foreach (var service in WsdlNameList)
            {
                foreach (var chunk in chunkList)
                {
                    if (service.Contains(chunk))
                    {
                        RelevantServices.Add(service);
                    }
                }
            }
            var count = RelevantServices.Count;
            return count;
        }

        public List<double> GetPrecisionRecallFMeasure(Task task)
        {
            var precision = GetPrecision(task);
            var recall = GetRecall(task);
            var fMeasure = 2 * (precision * recall / (precision + recall));
            return new List<double> { precision, recall, fMeasure };
        }

        public List<string> GetBestService()
        {
            var service = from s in RelevantServices
                          group s by s into g
                          orderby g.Count() descending
                          select g.Key;
            return service.ToList();
        }
    }
}