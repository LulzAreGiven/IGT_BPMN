using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

/*
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */

namespace IGT.Model
{
    [XmlRoot(ElementName = "signavioDiagramMetaData", Namespace = "http://www.signavio.com")]
    public class SignavioDiagramMetaData
    {
        [XmlAttribute(AttributeName = "metaKey")]
        public string MetaKey { get; set; }

        [XmlAttribute(AttributeName = "metaValue")]
        public string MetaValue { get; set; }
    }

    [XmlRoot(ElementName = "extensionElements", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
    public class ExtensionElements
    {
        [XmlElement(ElementName = "signavioDiagramMetaData", Namespace = "http://www.signavio.com")]
        public SignavioDiagramMetaData SignavioDiagramMetaData { get; set; }

        [XmlElement(ElementName = "signavioMetaData", Namespace = "http://www.signavio.com")]
        public List<SignavioMetaData> SignavioMetaData { get; set; }

        [XmlElement(ElementName = "signavioLabel", Namespace = "http://www.signavio.com")]
        public SignavioLabel SignavioLabel { get; set; }
    }

    [XmlRoot(ElementName = "signavioMetaData", Namespace = "http://www.signavio.com")]
    public class SignavioMetaData
    {
        [XmlAttribute(AttributeName = "metaKey")]
        public string MetaKey { get; set; }

        [XmlAttribute(AttributeName = "metaValue")]
        public string MetaValue { get; set; }
    }

    [XmlRoot(ElementName = "startEvent", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
    public class StartEvent
    {
        [XmlElement(ElementName = "extensionElements", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
        public ExtensionElements ExtensionElements { get; set; }

        [XmlElement(ElementName = "outgoing", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
        public string Outgoing { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "task", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
    public class Task
    {
        [XmlElement(ElementName = "extensionElements", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
        public ExtensionElements ExtensionElements { get; set; }

        [XmlElement(ElementName = "incoming", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
        public string Incoming { get; set; }

        [XmlElement(ElementName = "outgoing", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
        public string Outgoing { get; set; }

        [XmlAttribute(AttributeName = "completionQuantity")]
        public string CompletionQuantity { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "isForCompensation")]
        public string IsForCompensation { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "startQuantity")]
        public string StartQuantity { get; set; }
    }

    [XmlRoot(ElementName = "exclusiveGateway", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
    public class ExclusiveGateway
    {
        [XmlElement(ElementName = "extensionElements", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
        public ExtensionElements ExtensionElements { get; set; }

        [XmlElement(ElementName = "incoming", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
        public string Incoming { get; set; }

        [XmlElement(ElementName = "outgoing", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
        public List<string> Outgoing { get; set; }

        [XmlAttribute(AttributeName = "gatewayDirection")]
        public string GatewayDirection { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "endEvent", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
    public class EndEvent
    {
        [XmlElement(ElementName = "extensionElements", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
        public ExtensionElements ExtensionElements { get; set; }

        [XmlElement(ElementName = "incoming", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
        public List<string> Incoming { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "sequenceFlow", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
    public class SequenceFlow
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "sourceRef")]
        public string SourceRef { get; set; }

        [XmlAttribute(AttributeName = "targetRef")]
        public string TargetRef { get; set; }

        [XmlElement(ElementName = "extensionElements", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
        public ExtensionElements ExtensionElements { get; set; }
    }

    [XmlRoot(ElementName = "signavioLabel", Namespace = "http://www.signavio.com")]
    public class SignavioLabel
    {
        [XmlAttribute(AttributeName = "align")]
        public string Align { get; set; }

        [XmlAttribute(AttributeName = "distance")]
        public string Distance { get; set; }

        [XmlAttribute(AttributeName = "from")]
        public string From { get; set; }

        [XmlAttribute(AttributeName = "ref")]
        public string Ref { get; set; }

        [XmlAttribute(AttributeName = "to")]
        public string To { get; set; }

        [XmlAttribute(AttributeName = "valign")]
        public string Valign { get; set; }

        [XmlAttribute(AttributeName = "x")]
        public string X { get; set; }

        [XmlAttribute(AttributeName = "y")]
        public string Y { get; set; }
    }

    [XmlRoot(ElementName = "process", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
    public class Process
    {
        [XmlElement(ElementName = "extensionElements", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
        public ExtensionElements ExtensionElements { get; set; }

        [XmlElement(ElementName = "startEvent", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
        public StartEvent StartEvent { get; set; }

        [XmlElement(ElementName = "task", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
        public List<Task> Task { get; set; }

        [XmlElement(ElementName = "exclusiveGateway", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
        public List<ExclusiveGateway> ExclusiveGateway { get; set; }

        [XmlElement(ElementName = "endEvent", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
        public List<EndEvent> EndEvent { get; set; }

        [XmlElement(ElementName = "sequenceFlow", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
        public List<SequenceFlow> SequenceFlow { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "isClosed")]
        public string IsClosed { get; set; }

        [XmlAttribute(AttributeName = "isExecutable")]
        public string IsExecutable { get; set; }

        [XmlAttribute(AttributeName = "processType")]
        public string ProcessType { get; set; }
    }

    [XmlRoot(ElementName = "Bounds", Namespace = "http://www.omg.org/spec/DD/20100524/DC")]
    public class Bounds
    {
        [XmlAttribute(AttributeName = "height")]
        public string Height { get; set; }

        [XmlAttribute(AttributeName = "width")]
        public string Width { get; set; }

        [XmlAttribute(AttributeName = "x")]
        public string X { get; set; }

        [XmlAttribute(AttributeName = "y")]
        public string Y { get; set; }
    }

    [XmlRoot(ElementName = "BPMNLabel", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
    public class BPMNLabel
    {
        [XmlElement(ElementName = "Bounds", Namespace = "http://www.omg.org/spec/DD/20100524/DC")]
        public Bounds Bounds { get; set; }

        [XmlAttribute(AttributeName = "labelStyle")]
        public string LabelStyle { get; set; }
    }

    [XmlRoot(ElementName = "BPMNShape", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
    public class BPMNShape
    {
        [XmlElement(ElementName = "Bounds", Namespace = "http://www.omg.org/spec/DD/20100524/DC")]
        public Bounds Bounds { get; set; }

        [XmlElement(ElementName = "BPMNLabel", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
        public BPMNLabel BPMNLabel { get; set; }

        [XmlAttribute(AttributeName = "bpmnElement")]
        public string BpmnElement { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "isMarkerVisible")]
        public string IsMarkerVisible { get; set; }
    }

    [XmlRoot(ElementName = "waypoint", Namespace = "http://www.omg.org/spec/DD/20100524/DI")]
    public class Waypoint
    {
        [XmlAttribute(AttributeName = "x")]
        public string X { get; set; }

        [XmlAttribute(AttributeName = "y")]
        public string Y { get; set; }
    }

    [XmlRoot(ElementName = "BPMNEdge", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
    public class BPMNEdge
    {
        [XmlElement(ElementName = "waypoint", Namespace = "http://www.omg.org/spec/DD/20100524/DI")]
        public List<Waypoint> Waypoint { get; set; }

        [XmlAttribute(AttributeName = "bpmnElement")]
        public string BpmnElement { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlElement(ElementName = "BPMNLabel", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
        public BPMNLabel BPMNLabel { get; set; }
    }

    [XmlRoot(ElementName = "BPMNPlane", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
    public class BPMNPlane
    {
        [XmlElement(ElementName = "BPMNShape", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
        public List<BPMNShape> BPMNShape { get; set; }

        [XmlElement(ElementName = "BPMNEdge", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
        public List<BPMNEdge> BPMNEdge { get; set; }

        [XmlAttribute(AttributeName = "bpmnElement")]
        public string BpmnElement { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "Font", Namespace = "http://www.omg.org/spec/DD/20100524/DC")]
    public class Font
    {
        [XmlAttribute(AttributeName = "isBold")]
        public string IsBold { get; set; }

        [XmlAttribute(AttributeName = "isItalic")]
        public string IsItalic { get; set; }

        [XmlAttribute(AttributeName = "isStrikeThrough")]
        public string IsStrikeThrough { get; set; }

        [XmlAttribute(AttributeName = "isUnderline")]
        public string IsUnderline { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "size")]
        public string Size { get; set; }
    }

    [XmlRoot(ElementName = "BPMNLabelStyle", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
    public class BPMNLabelStyle
    {
        [XmlElement(ElementName = "Font", Namespace = "http://www.omg.org/spec/DD/20100524/DC")]
        public Font Font { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "BPMNDiagram", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
    public class BPMNDiagram
    {
        [XmlElement(ElementName = "BPMNPlane", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
        public BPMNPlane BPMNPlane { get; set; }

        [XmlElement(ElementName = "BPMNLabelStyle", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
        public List<BPMNLabelStyle> BPMNLabelStyle { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "definitions", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
    public class Definitions
    {
        [XmlElement(ElementName = "process", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
        public Process Process { get; set; }

        [XmlElement(ElementName = "BPMNDiagram", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
        public BPMNDiagram BPMNDiagram { get; set; }

        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }

        [XmlAttribute(AttributeName = "bpmndi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Bpmndi { get; set; }

        [XmlAttribute(AttributeName = "omgdc", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Omgdc { get; set; }

        [XmlAttribute(AttributeName = "omgdi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Omgdi { get; set; }

        [XmlAttribute(AttributeName = "signavio", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Signavio { get; set; }

        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }

        [XmlAttribute(AttributeName = "exporter")]
        public string Exporter { get; set; }

        [XmlAttribute(AttributeName = "exporterVersion")]
        public string ExporterVersion { get; set; }

        [XmlAttribute(AttributeName = "expressionLanguage")]
        public string ExpressionLanguage { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "targetNamespace")]
        public string TargetNamespace { get; set; }

        [XmlAttribute(AttributeName = "typeLanguage")]
        public string TypeLanguage { get; set; }

        [XmlAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string SchemaLocation { get; set; }
    }
}