using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace XML
{
    class Fasade
    {
        private string _path;

        public string Path { set { _path = value; } }

        public void GetLINQ(RichTextBox wind)
        {
            IStrategy parser = new LINQ();
            GetSearch(parser, wind);
        }

        public void GetSAX(RichTextBox wind)
        {
            IStrategy parser = new SAX();
            GetSearch(parser, wind);
        }

        public void GetDOM(RichTextBox wind)
        {
            IStrategy parser = new DOM();
            GetSearch(parser, wind);
        }

        private void GetSearch(IStrategy parser, RichTextBox wind)
        {
            Xml_Reader myTemplate = OurSearch();
            List<Xml_Reader> res;
            res = parser.FindInFile(myTemplate, _path);
            Output(res, wind);
        }

        private Xml_Reader OurSearch()
        {
            string[] info = new string[7];
            if (Conferences.checkBoxes[0].Checked) info[0] = Convert.ToString(Conferences.comboBoxes[0].Text);
            if (Conferences.checkBoxes[1].Checked) info[1] = Convert.ToString(Conferences.comboBoxes[1].Text);
            if (Conferences.checkBoxes[2].Checked) info[2] = Convert.ToString(Conferences.comboBoxes[2].Text);
            if (Conferences.checkBoxes[3].Checked) info[3] = Convert.ToString(Conferences.comboBoxes[3].Text);
            if (Conferences.checkBoxes[4].Checked) info[4] = Convert.ToString(Conferences.comboBoxes[4].Text);
            if (Conferences.checkBoxes[5].Checked) info[5] = Convert.ToString(Conferences.comboBoxes[5].Text);
            if (Conferences.checkBoxes[6].Checked) info[6] = Convert.ToString(Conferences.comboBoxes[6].Text);
            Xml_Reader IdealSearch = new Xml_Reader(info);
            return IdealSearch;
        }

        private void Output(List<Xml_Reader> res, RichTextBox wind)
        {
            wind.Clear();
            foreach (Xml_Reader n in res)
            {
                wind.AppendText("Conference Name: " + n.confa + " \n");
                wind.AppendText("Place: " + n.place + " \n");
                wind.AppendText("Theme: " + n.theme + " \n");
                wind.AppendText("Person: " + n.person + " \n");
                wind.AppendText("Date: " + n.date + " \n");
                wind.AppendText("Period: " + n.period + " \n");
                wind.AppendText("Cost: " + n.cost + " \n");
                wind.AppendText("\n\n\n");
            }
        }
    }
}
