using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace XML
{
    class LINQ : IStrategy
    {
        private List<Xml_Reader> find = null;
        XDocument doc = new XDocument();

        public List<Xml_Reader> FindInFile(Xml_Reader _reader, string path)
        {
            path = Conferences.path;
            doc = XDocument.Load(@path);
            find = new List<Xml_Reader>();
            List<XElement> matches = (from val in doc.Descendants("INFO")
                                      where
                                      ((_reader.confa == null || _reader.confa == val.Parent.Parent.Attribute("ConfName").Value) &&
                                      (_reader.place == null || _reader.place == val.Parent.Attribute("Place").Value) &&
                                      (_reader.theme == null || _reader.theme == val.Attribute("Theme").Value) &&
                                      (_reader.person == null || _reader.person == val.Attribute("Person").Value) &&
                                      (_reader.date == null || _reader.date == val.Attribute("Date").Value) &&
                                      (_reader.period == null || _reader.period == val.Attribute("Period").Value) &&
                                      (_reader.cost == null || _reader.cost == val.Attribute("Cost").Value))
                                      select val).ToList();
            foreach (XElement match in matches)
            {
                Xml_Reader res = new Xml_Reader
                {
                    confa = match.Parent.Parent.Attribute("ConfName").Value,
                    place = match.Parent.Attribute("Place").Value,
                    theme = match.Attribute("Theme").Value,
                    person = match.Attribute("Person").Value,
                    date = match.Attribute("Date").Value,
                    period = match.Attribute("Period").Value,
                    cost = match.Attribute("Cost").Value,
                };
                find.Add(res);
            }
            return find;
        }
    }
}
