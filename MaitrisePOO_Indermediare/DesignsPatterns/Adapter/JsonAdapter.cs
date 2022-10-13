using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.Adapter
{
    internal class JsonAdapter : IJsonAdapter
    {
        private IContactRepository xmlRepository;

        public JsonAdapter(IContactRepository xmlRepository)
        {
            this.xmlRepository = xmlRepository;
        }

        public string RecupContactsJson(string path)
        {
            string xml = xmlRepository.RecupContactsXML(path);
            
            //Transformation en JSON
            List<Contact> contacts = xmlRepository.ConvertToXML(xml);

            string resJson = string.Empty;

            var s = new DataContractJsonSerializer(contacts.GetType());

            using (var memStream = new MemoryStream())
            {
                s.WriteObject(memStream, contacts);
                resJson = Encoding.UTF8.GetString(memStream.ToArray());
            }

            return resJson;
        }

    }
}
