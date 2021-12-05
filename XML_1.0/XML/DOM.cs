using System.Collections.Generic;
using System.Xml;

namespace XML
{
    class DOM : IStrategy
    {
        readonly XmlDocument doc = new XmlDocument();

        public List<Xml_Reader> FindInFile(Xml_Reader _reader, string path)
        {
            path = Conferences.path;
            doc.Load(path);
            List<List<Xml_Reader>> info = new List<List<Xml_Reader>>();

            if (_reader.place == null &&
                _reader.confa == null &&
                _reader.theme == null &&
                _reader.person == null &&
                _reader.date == null &&
                _reader.period == null &&
                _reader.cost == null
                )
            {
                return AllSearch(doc);
            }

            if (_reader.confa != null) info.Add(SearchByAttribute("CONFERENCE", "ConfName", _reader.confa, doc, 0));
            if (_reader.place != null) info.Add(SearchByAttribute("PLACE", "Place", _reader.place, doc, 1));
            if (_reader.theme != null) info.Add(SearchByAttribute("INFO", "Theme", _reader.theme, doc, 2));
            if (_reader.person != null) info.Add(SearchByAttribute("INFO", "Person", _reader.person, doc, 2));
            if (_reader.date != null) info.Add(SearchByAttribute("INFO", "Date", _reader.date, doc, 2));
            if (_reader.period != null) info.Add(SearchByAttribute("INFO", "Period", _reader.period, doc, 2));
            if (_reader.cost != null) info.Add(SearchByAttribute("INFO", "Cost", _reader.cost, doc, 2));

            return Cross(info);
        }

        public static List<Xml_Reader> SearchByAttribute(string nodeName, string attribute, string myTemplate, XmlDocument doc, int n)
        {
            List<Xml_Reader> find = new List<Xml_Reader>();

            if (myTemplate != null || myTemplate != string.Empty)
            {
                switch (n)
                {
                    case 0:
                        {
                            XmlNodeList lst = doc.SelectNodes("//" + nodeName + "[@" + attribute + "=\"" + myTemplate + "\"]");
                            try
                            {
                                foreach (XmlNode e in lst)
                                {
                                    XmlNodeList list1 = e.ChildNodes;
                                    foreach (XmlNode el in list1)
                                    {
                                        XmlNodeList list2 = el.ChildNodes;
                                        foreach (XmlNode ell in list2)
                                        {
                                            find.Add(Info(ell));
                                        }
                                    }
                                }
                            }
                            catch { }
                            break;
                        }
                    case 1:
                        {
                            XmlNodeList lst = doc.SelectNodes("//" + nodeName + "[@" + attribute + "=\"" + myTemplate + "\"]");
                            try
                            {
                                foreach (XmlNode e in lst)
                                {
                                    XmlNodeList list1 = e.ChildNodes;
                                    foreach (XmlNode el in list1)
                                    {
                                        find.Add(Info(el));
                                    }
                                }
                            }
                            catch { }
                            break;
                        }
                    case 2:
                        {
                            XmlNodeList lst = doc.SelectNodes("//" + nodeName + "[@" + attribute + "=\"" + myTemplate + "\"]");
                            try
                            {
                                foreach (XmlNode e in lst)
                                {
                                    find.Add(Info(e));
                                }
                            }
                            catch { }
                            break;
                        }
                    default:
                        break;
                }
                return find;
            }
            return AllSearch(doc);
        }

        public static Xml_Reader Info(XmlNode node)
        {
            Xml_Reader search = new Xml_Reader
            {
                confa = node.ParentNode.ParentNode.Attributes.GetNamedItem("ConfName").Value,
                place = node.ParentNode.Attributes.GetNamedItem("Place").Value,
                theme = node.Attributes.GetNamedItem("Theme").Value,
                person = node.Attributes.GetNamedItem("Person").Value,
                date = node.Attributes.GetNamedItem("Date").Value,
                period = node.Attributes.GetNamedItem("Period").Value,
                cost = node.Attributes.GetNamedItem("Cost").Value,
            };
            return search;
        }

        public static List<Xml_Reader> Cross(List<List<Xml_Reader>> list)
        {
            List<Xml_Reader> result = new List<Xml_Reader>();

            try
            {
                if (list != null)
                {
                    Xml_Reader[] newSearch = list[0].ToArray();
                    if (newSearch != null)
                    {
                        foreach (Xml_Reader elem in newSearch)
                        {
                            bool IsIn = true;
                            foreach (List<Xml_Reader> tmpList in list)
                            {
                                if (tmpList.Count <= 0) return new List<Xml_Reader>();

                                foreach (Xml_Reader element in tmpList)
                                {
                                    IsIn = false;
                                    if (elem.Compare(element))
                                    {
                                        IsIn = true;
                                        break;
                                    }
                                }
                                if (!IsIn) break;
                            }
                            if (IsIn)
                            {
                                result.Add(elem);
                            }
                        }
                    }
                }
            }
            catch { }
            return result;
        }

        public static List<Xml_Reader> AllSearch(XmlDocument doc)
        {
            List<Xml_Reader> findAll = new List<Xml_Reader>();
            XmlNodeList elem = doc.SelectNodes("//INFO");
            try
            {
                foreach (XmlNode el in elem)
                {
                    findAll.Add(Info(el));
                }
            }
            catch { }
            return findAll;
        }
    }
}
