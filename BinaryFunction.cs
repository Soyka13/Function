using System;
using System.Xml;

namespace Function
{
    public abstract class BinaryFunction : Function
    {
        protected Function firstOperand;
        protected Function secondOperand;
        
        protected BinaryFunction(Function firstOperand, Function secondOperand)
        {
            this.firstOperand = firstOperand;
            this.secondOperand = secondOperand;
        }

        public override string ToString()
        {
            return firstOperand.ToString() + " " + getBinaryExpressionSign() + " " + secondOperand.ToString();
        }

        public override void ToXML(XmlDocument doc, XmlNode previousNode)
        {
            XmlNode currentNode = doc.CreateElement(this.GetType().Name);
            previousNode.AppendChild(currentNode);
            firstOperand.ToXML(doc,currentNode);
            secondOperand.ToXML(doc,currentNode);
        }

        protected abstract string getBinaryExpressionSign();
    }
}