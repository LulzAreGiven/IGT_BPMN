using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace IGT.Model
{
    public class Parser : IParse
    {
        private readonly string _path = Path.Combine(Environment.CurrentDirectory, @"..\..\Data\Signavio_A1.bpmn");

        public Definitions ParseBpmnFile()
        {
            var serializer = new XmlSerializer(typeof(Definitions));
            using (var fileStream = new FileStream(_path, FileMode.Open))
            {
                var result = (Definitions)serializer.Deserialize(fileStream);
                return result;
            }
        }

        public List<Task> GetTasks()
        {
            return new List<Task>();
        }
    }
}