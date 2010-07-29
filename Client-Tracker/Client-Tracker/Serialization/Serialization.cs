using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace Serialization
{
    public static class Serializer
    {
        /// <summary>
        /// Deserializes an xml document back into an object
        /// </summary>
        /// <param name="xml">The xml data to deserialize</param>
        /// <param name="type">The type of the object being deserialized</param>
        /// <returns>A deserialized object</returns>
        public static object Deserialize(XmlDocument xml, Type type)
        {
            XmlSerializer s = new XmlSerializer(type);
            string xmlString = xml.OuterXml.ToString();
            byte[] buffer = ASCIIEncoding.UTF8.GetBytes(xmlString);
            MemoryStream ms = new MemoryStream(buffer);
            XmlReader reader = new XmlTextReader(ms);

            try
            {
                object o = s.Deserialize(reader);
                return o;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                reader.Close();
            }
        }

        /// <summary>
        /// Serializes an object into an Xml Document
        /// </summary>
        /// <param name="o">The object to serialize</param>
        /// <returns>An Xml Document consisting of said object's data</returns>
        public static XmlDocument Serialize(object o)
        {
            XmlSerializer s = new XmlSerializer(o.GetType());
            MemoryStream ms = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(ms, new UTF8Encoding());

            try
            {
                s.Serialize(writer, o);
                XmlDocument xml = new XmlDocument();
                string xmlString = ASCIIEncoding.UTF8.GetString(ms.ToArray());
                xml.LoadXml(xmlString);
                return xml;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                writer.Close();
                ms.Close();
            }
        }

        /// <summary>
        /// Serializes an object into a string
        /// </summary>
        /// <param name="o">The object to serialize</param>
        /// <returns>string of serialized XML</returns>
        public static string SerializeToString(object o, bool prettyFormat)
        {
            XmlDocument xDoc = Serialize(o);
            TextWriter sw = new StringWriter();
            XmlTextWriter xtw = new XmlTextWriter(sw);
            xtw.Formatting = Formatting.Indented;
            xtw.Indentation = 1;
            xtw.IndentChar = '\x09';
            xDoc.Save(xtw);
            string xml = xDoc.InnerXml;
            return xDoc.InnerXml;
        }
    }
}
