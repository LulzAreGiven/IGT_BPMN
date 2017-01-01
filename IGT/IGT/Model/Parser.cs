﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace IGT.Model
{
    public class Parser : IParse
    {
        private readonly string _pathBpmn = Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Signavio_A1.bpmn");

        private readonly string[] _wsdlFileStrings =
            Directory.GetFiles(Path.Combine(Environment.CurrentDirectory, @"..\..\Data\"), "*.wsdl");

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
                }
            }
            return tmpList;
        }

        public double GetPrecision()
        {
            return 0.0;
        }

        public double GetRecall()
        {
            return 0.0;
        }

        public double GetFMeasure()
        {
            return 0.0;
        }
    }
}