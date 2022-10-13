using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.Adapter
{
    internal class ContactRepository : IContactRepository
    {
        public List<Contact> ConvertToXML(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            XmlNodeList noeuds = doc.DocumentElement.SelectNodes("/contacts/contact");
            List<Contact> contacts = new List<Contact>();

            foreach (XmlNode node in noeuds)
            {
                var c = new Contact();
                c.Id = Convert.ToInt32(node.Attributes["id"].Value);
                c.Nom = node.ChildNodes[0].InnerText;
                contacts.Add(c);
            }
            
            return contacts;
        }

        public string RecupContactsXML(string path)
        {
            string res = null;
            
            using (var st = new StreamReader(path))
            {
                res = st.ReadToEnd();
                return res;
            }
            
        }
    }
}
