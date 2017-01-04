using IGT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IGT.Model.BPMN;

namespace IGT.Model
{
    public interface IParse
    {
        BPMN.Definitions ParseBpmnFile(string path);

        List<BPMN.Task> GetTasks(string path);

        List<WSDL.Definitions> ParseWsdlFiles();

        List<double> GetPrecisionRecallFMeasure(Task task);

        List<string> GetBestService();
    }
}