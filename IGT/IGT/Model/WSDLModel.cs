using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IGT.Model
{
    /*
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */

    namespace WSDL
    {
        [XmlRoot(ElementName = "part", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
        public class Part
        {
            [XmlAttribute(AttributeName = "name")]
            public string Name { get; set; }

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }
        }

        [XmlRoot(ElementName = "message", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
        public class Message
        {
            [XmlElement(ElementName = "part", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
            public Part Part { get; set; }

            [XmlAttribute(AttributeName = "name")]
            public string Name { get; set; }
        }

        [XmlRoot(ElementName = "input", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
        public class Input
        {
            [XmlAttribute(AttributeName = "message")]
            public string Message { get; set; }

            [XmlElement(ElementName = "body", Namespace = "http://schemas.xmlsoap.org/wsdl/soap/")]
            public Body Body { get; set; }
        }

        [XmlRoot(ElementName = "output", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
        public class Output
        {
            [XmlAttribute(AttributeName = "message")]
            public string Message { get; set; }

            [XmlElement(ElementName = "body", Namespace = "http://schemas.xmlsoap.org/wsdl/soap/")]
            public Body Body { get; set; }
        }

        [XmlRoot(ElementName = "operation", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
        public class Operation
        {
            [XmlElement(ElementName = "input", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
            public Input Input { get; set; }

            [XmlElement(ElementName = "output", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
            public Output Output { get; set; }

            [XmlAttribute(AttributeName = "name")]
            public string Name { get; set; }

            [XmlElement(ElementName = "operation", Namespace = "http://schemas.xmlsoap.org/wsdl/soap/")]
            public Operation2 Operation2 { get; set; }
        }

        [XmlRoot(ElementName = "portType", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
        public class PortType
        {
            [XmlElement(ElementName = "operation", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
            public Operation Operation { get; set; }

            [XmlAttribute(AttributeName = "name")]
            public string Name { get; set; }
        }

        [XmlRoot(ElementName = "binding", Namespace = "http://schemas.xmlsoap.org/wsdl/soap/")]
        public class Binding
        {
            [XmlAttribute(AttributeName = "style")]
            public string Style { get; set; }

            [XmlAttribute(AttributeName = "transport")]
            public string Transport { get; set; }
        }

        [XmlRoot(ElementName = "operation", Namespace = "http://schemas.xmlsoap.org/wsdl/soap/")]
        public class Operation2
        {
            [XmlAttribute(AttributeName = "soapAction")]
            public string SoapAction { get; set; }
        }

        [XmlRoot(ElementName = "body", Namespace = "http://schemas.xmlsoap.org/wsdl/soap/")]
        public class Body
        {
            [XmlAttribute(AttributeName = "encodingStyle")]
            public string EncodingStyle { get; set; }

            [XmlAttribute(AttributeName = "namespace")]
            public string Namespace { get; set; }

            [XmlAttribute(AttributeName = "use")]
            public string Use { get; set; }
        }

        [XmlRoot(ElementName = "binding", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
        public class Binding2
        {
            [XmlElement(ElementName = "binding", Namespace = "http://schemas.xmlsoap.org/wsdl/soap/")]
            public Binding Binding { get; set; }

            [XmlElement(ElementName = "operation", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
            public Operation Operation { get; set; }

            [XmlAttribute(AttributeName = "name")]
            public string Name { get; set; }

            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }
        }

        [XmlRoot(ElementName = "address", Namespace = "http://schemas.xmlsoap.org/wsdl/soap/")]
        public class Address
        {
            [XmlAttribute(AttributeName = "location")]
            public string Location { get; set; }
        }

        [XmlRoot(ElementName = "port", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
        public class Port
        {
            [XmlElement(ElementName = "address", Namespace = "http://schemas.xmlsoap.org/wsdl/soap/")]
            public Address Address { get; set; }

            [XmlAttribute(AttributeName = "binding")]
            public string Binding { get; set; }

            [XmlAttribute(AttributeName = "name")]
            public string Name { get; set; }
        }

        [XmlRoot(ElementName = "service", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
        public class Service
        {
            [XmlElement(ElementName = "documentation", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
            public string Documentation { get; set; }

            [XmlElement(ElementName = "port", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
            public Port Port { get; set; }

            [XmlAttribute(AttributeName = "name")]
            public string Name { get; set; }
        }

        [XmlRoot(ElementName = "definitions", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
        public class Definitions
        {
            [XmlElement(ElementName = "message", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
            public List<Message> Message { get; set; }

            [XmlElement(ElementName = "portType", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
            public PortType PortType { get; set; }

            [XmlElement(ElementName = "binding", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
            public Binding2 Binding2 { get; set; }

            [XmlElement(ElementName = "service", Namespace = "http://schemas.xmlsoap.org/wsdl/")]
            public Service Service { get; set; }

            [XmlAttribute(AttributeName = "name")]
            public string Name { get; set; }

            [XmlAttribute(AttributeName = "targetNamespace")]
            public string TargetNamespace { get; set; }

            [XmlAttribute(AttributeName = "xmlns")]
            public string Xmlns { get; set; }

            [XmlAttribute(AttributeName = "soap", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Soap { get; set; }

            [XmlAttribute(AttributeName = "tns", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Tns { get; set; }

            [XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Xsd { get; set; }
        }
    }
}