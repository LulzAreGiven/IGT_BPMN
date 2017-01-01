using IGT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IGT.Model
{
    public interface IParse
    {
        BPMN.Definitions ParseBpmnFile(string path);

        List<BPMN.Task> GetTasks(string path);

        List<WSDL.Definitions> ParseWsdlFiles();
    }
}