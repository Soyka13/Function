using System.IO;
using System.Text;
using System.Xml;

namespace Function
{
    public class XmlUtils
    {
        public static string PrintXML(XmlDocument document)
        {
            string result = "";

            MemoryStream mStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(mStream, Encoding.Unicode);
            
            try
            {
                writer.Formatting = Formatting.Indented;

                document.WriteContentTo(writer);
                writer.Flush();
                mStream.Flush();
                
                mStream.Position = 0;
                
                StreamReader sReader = new StreamReader(mStream);
                
                string formattedXml = sReader.ReadToEnd();

                result = formattedXml;
            }
            catch (XmlException) {}

            mStream.Close();
            writer.Close();

            return result;
        }
    }
}