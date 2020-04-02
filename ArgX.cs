using System.Xml;

namespace Function
{
    public class ArgX : Function
    {
        public ArgX()
        {
            expression = (x) => x;
        }
        
        public override string ToString()
        {
            return "x";
        }

        public override Function Diff()
        {
            return new Const(1);
        }

        public override void ToXML(XmlDocument doc, XmlNode previousNode)
        {
            XmlNode currentNode = doc.CreateElement(this.GetType().Name);
            previousNode.AppendChild(currentNode);
        }
    }
}