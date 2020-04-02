using System.Xml;

namespace Function
{
    public class Const : Function
    {
        private double value = 0.0;

        public Const(double value)
        {
            this.value = value;

            expression = (x) => value;
        }

        public override string ToString()
        {
            return value.ToString();
        }

        public override Function Diff()
        { 
            return new Const(0);
        }

        public override void ToXML(XmlDocument doc, XmlNode previousNode)
        {
            XmlElement currentNode = doc.CreateElement(this.GetType().Name);
            currentNode.SetAttribute("x", value.ToString());
           
            previousNode.AppendChild(currentNode);
        }
    }
}