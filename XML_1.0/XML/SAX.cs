using System.Collections.Generic;
using System.Xml;

namespace XML
{
    class SAX : IStrategy
    {
        public List<Xml_Reader> FindInFile(Xml_Reader _reader, string path)
        {
            List<Xml_Reader> infoList = new List<Xml_Reader>();

            path = Conferences.path;
            XmlReader Reader = XmlReader.Create(path);
            infoList.Clear();

            List<Xml_Reader> resultList = new List<Xml_Reader>();
            Xml_Reader newReader;
            string _conference = null;
            string _place = null;

            while (Reader.Read())
            {
                switch (Reader.Name)
                {
                    case "CONFERENCE":
                        while (Reader.MoveToNextAttribute())
                        {
                            if (Reader.Name == "ConfName")
                            {
                                _conference = Reader.Value;
                            }
                        }
                        break;
                    case "PLACE":
                        while (Reader.MoveToNextAttribute())
                        {
                            if (Reader.Name == "Place")
                            {
                                _place = Reader.Value;
                            }
                        }
                        break;
                    case "INFO":
                        if (Reader.HasAttributes)
                        {
                            newReader = new Xml_Reader
                            {
                                confa = _conference,
                                place = _place
                            };

                            while (Reader.MoveToNextAttribute())
                            {
                                switch (Reader.Name)
                                {
                                    case "Theme":
                                        newReader.theme = Reader.Value;
                                        break;
                                    case "Person":
                                        newReader.person = Reader.Value;
                                        break;
                                    case "Date":
                                        newReader.date = Reader.Value;
                                        break;
                                    case "Period":
                                        newReader.period = Reader.Value;
                                        break;
                                    case "Cost":
                                        newReader.cost = Reader.Value;
                                        break;
                                    default:
                                        break;
                                }
                            }
                            resultList.Add(newReader);
                        }
                        break;
                    default:
                        break;
                }
            }
            infoList = Filter(resultList, _reader);
            return infoList;
        }

        private List<Xml_Reader> Filter(List<Xml_Reader> allRes, Xml_Reader tmp)
        {
            List<Xml_Reader> newResult = new List<Xml_Reader>();

            if (allRes != null)
            {
                foreach (Xml_Reader i in allRes)
                {
                    try
                    {
                        if ((i.place == tmp.place || tmp.place == null) &&
                            (i.confa == tmp.confa || tmp.confa == null) &&
                            (i.theme == tmp.theme || tmp.theme == null) &&
                            (i.person == tmp.person || tmp.person == null) &&
                            (i.date == tmp.date || tmp.date == null) &&
                            (i.period == tmp.period || tmp.period == null) &&
                            (i.cost == tmp.cost || tmp.cost == null)
                            )
                        {
                            newResult.Add(i);
                        }
                    }
                    catch { }
                }
            }
            return newResult;
        }
    }
}
