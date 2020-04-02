using System;
using System.Xml;

namespace Function
{
    public delegate double Operation(double x);

    public abstract class Function
    {
        protected Operation expression;
        
        public double Calc(double x)
        {
            return expression(x);
        }
        public abstract Function Diff();
        public abstract void ToXML(XmlDocument doc, XmlNode previousNode);

        public XmlDocument createXMLDoc(String rootElementName)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode docElement = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docElement);

            XmlNode rootElement = doc.CreateElement(rootElementName);
            doc.AppendChild(rootElement);

            this.ToXML(doc, rootElement);

            //doc.Save(Console.Out);
            return doc;
        }
    }
}