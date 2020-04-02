using System.Xml;

namespace Function
{
    public abstract class UnaryFunction : Function
    {
        protected Function arg;

        protected UnaryFunction(Function arg)
        {
            this.arg = arg;
        }
        public override string ToString()
        {
            return this.GetType().Name + "(" + this.arg.ToString() + ")";
        }

        public override void ToXML(XmlDocument doc, XmlNode previousNode)
        {
            XmlNode currentNode = doc.CreateElement(this.GetType().Name);
            previousNode.AppendChild(currentNode);
            arg.ToXML(doc,currentNode);
        }
    }
}