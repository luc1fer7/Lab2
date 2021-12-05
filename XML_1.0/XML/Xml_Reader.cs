using System.Collections.Generic;

namespace XML
{
    public class Xml_Reader
    {
        public string confa = null;
        public string place = null;
        public string theme = null;
        public string person = null;
        public string date = null;
        public string period = null;
        public string cost = null;
        public Xml_Reader() { }
        public Xml_Reader(string[] data)
        {
            confa = data[0];
            place = data[1];
            theme = data[2];
            person = data[3];
            date = data[4];
            period = data[5];
            cost = data[6];
        }
        #region Comparison
        public bool Compare(Xml_Reader obj)
        {
            if ((this.confa == obj.confa)
                && (this.place == obj.place)
                && (this.theme == obj.theme)
                && (this.person == obj.person)
                && (this.date == obj.date)
                && (this.period == obj.period)
                && (this.cost == obj.cost))
            {
                return true;
            }
            else
                return false;
        }
        #endregion Comparison
    }
}
