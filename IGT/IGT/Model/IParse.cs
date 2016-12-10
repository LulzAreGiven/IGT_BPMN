using IGT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IGT.Model
{
    public interface IParse
    {
        BPMN.Definitions ParseBpmnFile();

        List<BPMN.Task> GetTasks();

        List<WSDL.Definitions> ParseWsdlFiles();
    }
}