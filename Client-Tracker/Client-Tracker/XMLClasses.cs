using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace Client_Tracker
{
    public static class XMLClasses
    {
        public static class Serialization
        {
            /// <summary>
            /// serializes a List of clients(It's actually serializing the helper function ClientData
            /// </summary>
            /// <param name="Clients">Clients to serialize</param>
            /// <returns>XML string of serialized clients</returns>
            public static string SerializeClients(List<Client> Clients)
            {
                List<ClientData> clientData = new List<ClientData>();
                // turn list of Client into list of ClientData
                foreach (Client C in Clients)
                {
                    clientData.Add(new ClientData(C.FirstName, C.LastName, C.GetNotes(), C.AllWorkDone));
                }

                StringWriter sw = new StringWriter();
                XmlSerializer xs = new XmlSerializer(typeof(ClientData));

                xs.Serialize(sw, clientData);

                return sw.ToString();
            }
        }


        static class Deserialization
        {
            /// <summary>
            /// Deserializes an xml string into a List of Client
            /// </summary>
            /// <param name="str">XML string of ClientData</param>
            /// <returns></returns>
            public static List<Client> DeserializeClients(string xml)
            {
                //XmlSerializer ser;
                //ser = new XmlSerializer(ObjType);
                //StringReader sr = new StringReader(Xml);
                
                //ser.Deserialize(st
                //XmlTextReader xmlReader;
                //xmlReader = new XmlTextReader(stringReader);
                //object obj;
                //obj = ser.Deserialize(xmlReader);
                //xmlReader.Close();
                //stringReader.Close();
                //return obj;
                return new List<Client>();
            }
        }
    }
}
