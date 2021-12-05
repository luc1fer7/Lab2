using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XML
{
    class Builder
    {
        List<ComboBox> list = Conferences.comboBoxes;
        private string _path = Conferences.path;

        public void BuildBox()
        {
            BoxCleaner();
            List<List<string>> doubleList = ListManager();

            Sort(doubleList);
            Ranger(list, doubleList);
        }

        private void BoxCleaner()
        {
            list[0].Items.Clear();
            list[1].Items.Clear();
            list[2].Items.Clear();
            list[3].Items.Clear();
            list[4].Items.Clear();
            list[5].Items.Clear();
            list[6].Items.Clear();
        }

        private List<List<string>> ListManager()
        {
            IStrategy p = new LINQ();
            List<Xml_Reader> res = p.FindInFile(new Xml_Reader(), _path);
            List<List<string>> doubleList = new List<List<string>>();

            List<string> Conference = new List<string>();
            List<string> Place = new List<string>();
            List<string> Theme = new List<string>();
            List<string> Person = new List<string>();
            List<string> Date = new List<string>();
            List<string> Period = new List<string>();
            List<string> Cost = new List<string>();

            foreach (Xml_Reader elem in res)
            {
                if (!Place.Contains(elem.place))
                {
                    Place.Add(elem.place);
                }
                if (!Conference.Contains(elem.confa))
                {
                    Conference.Add(elem.confa);
                }
                if (!Theme.Contains(elem.theme))
                {
                    Theme.Add(elem.theme);
                }
                if (!Person.Contains(elem.person))
                {
                    Person.Add(elem.person);
                }
                if (!Date.Contains(elem.date))
                {
                    Date.Add(elem.date);
                }
                if (!Period.Contains(elem.period))
                {
                    Period.Add(elem.period);
                }
                if (!Cost.Contains(elem.cost))
                {
                    Cost.Add(elem.cost);
                }
            }

            doubleList.Add(Conference);
            doubleList.Add(Place);
            doubleList.Add(Theme);
            doubleList.Add(Person);
            doubleList.Add(Date);
            doubleList.Add(Period);
            doubleList.Add(Cost);

            return doubleList;
        }

        private void Sort(List<List<string>> doubleList)
        {
            doubleList[0] = doubleList[0].OrderBy(x => x).ToList();
            doubleList[1] = doubleList[1].OrderBy(x => x).ToList();
            doubleList[2] = doubleList[2].OrderBy(x => x).ToList();
            doubleList[3] = doubleList[3].OrderBy(x => x).ToList();
            doubleList[4] = doubleList[4].OrderBy(x => x).ToList();
            doubleList[5] = doubleList[5].OrderBy(x => x).ToList();
            doubleList[6] = doubleList[6].OrderBy(x => x).ToList();
        }

        private void Ranger(List<ComboBox> comboList, List<List<string>> doubleList)
        {
            comboList[0].Items.AddRange(doubleList[0].ToArray());
            comboList[1].Items.AddRange(doubleList[1].ToArray());
            comboList[2].Items.AddRange(doubleList[2].ToArray());
            comboList[3].Items.AddRange(doubleList[3].ToArray());
            comboList[4].Items.AddRange(doubleList[4].ToArray());
            comboList[5].Items.AddRange(doubleList[5].ToArray());
            comboList[6].Items.AddRange(doubleList[6].ToArray());
        }
    }
}
