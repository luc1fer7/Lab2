using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Xsl;

namespace XML
{
    public partial class Conferences : Form
    {
        public static readonly List<ComboBox> comboBoxes = new List<ComboBox>();
        public static readonly List<CheckBox> checkBoxes = new List<CheckBox>();

        public static string path = @"DataBase.xml";
        private readonly string pathXsl = @"XSL.xsl";
        private readonly string pathHtml = @"HTML.html";

        readonly Fasade fasade = new Fasade();
        readonly Builder builder = new Builder();

        public Conferences()
        {
            InitializeComponent();

            comboBoxes.Add(ConferenceComboBox);
            comboBoxes.Add(PlaceComboBox);
            comboBoxes.Add(ThemeComboBox);
            comboBoxes.Add(PersonComboBox);
            comboBoxes.Add(DateComboBox);
            comboBoxes.Add(PeriodComboBox);
            comboBoxes.Add(CostComboBox);

            checkBoxes.Add(ConferenceCheckBox);
            checkBoxes.Add(PlaceCheckBox);
            checkBoxes.Add(ThemeCheckBox);
            checkBoxes.Add(PersonCheckBox);
            checkBoxes.Add(DateCheckBox);
            checkBoxes.Add(PeriodCheckBox);
            checkBoxes.Add(CostCheckBox);

            builder.BuildBox();
        }
        

        private void IsCheckBoxChecked(object sender)
        {
            CheckBox temp = sender as CheckBox;
            if (path != "")
            {
                switch (temp.Text)
                {
                    case "Title":
                        ConferenceComboBox.Text = "";
                        if (temp.CheckState == CheckState.Checked)
                        {
                            ConferenceComboBox.Enabled = true;
                        }
                        else
                        {
                            ConferenceComboBox.Enabled = false;
                        }
                        break;
                    case "Place":
                        PlaceComboBox.Text = "";
                        if (temp.CheckState == CheckState.Checked)
                        {
                            PlaceComboBox.Enabled = true;
                        }
                        else
                        {
                            PlaceComboBox.Enabled = false;
                        }
                        break;
                    case "Theme":
                        ThemeComboBox.Text = "";
                        if (temp.CheckState == CheckState.Checked)
                        {
                            ThemeComboBox.Enabled = true;
                        }
                        else
                        {
                            ThemeComboBox.Enabled = false;
                        }
                        break;
                    case "Person":
                        PersonComboBox.Text = "";
                        if (temp.CheckState == CheckState.Checked)
                        {
                            PersonComboBox.Enabled = true;
                        }
                        else
                        {
                            PersonComboBox.Enabled = false;
                        }
                        break;
                    case "Date":
                        DateComboBox.Text = "";
                        if (temp.CheckState == CheckState.Checked)
                        {
                            DateComboBox.Enabled = true;
                        }
                        else
                        {
                            DateComboBox.Enabled = false;
                        }
                        break;
                    case "Period":
                        PeriodComboBox.Text = "";
                        if (temp.CheckState == CheckState.Checked)
                        {
                            PeriodComboBox.Enabled = true;
                        }
                        else
                        {
                            PeriodComboBox.Enabled = false;
                        }
                        break;
                    case "Cost":
                        CostComboBox.Text = "";
                        if (temp.CheckState == CheckState.Checked)
                        {
                            CostComboBox.Enabled = true;
                        }
                        else
                        {
                            CostComboBox.Enabled = false;
                        }
                        break;
                }
            }
        }

        private void SearchFunc()
        {
            if (SAXRadioButton.Checked)
            {
                fasade.GetSAX(wind);
            }
            if (DOMRadioButton.Checked)
            {
                fasade.GetDOM(wind);
            }
            if (LINQRadioButton.Checked)
            {
                fasade.GetLINQ(wind);
            }
        }        

        private void ToHTML()
        {
            XslCompiledTransform xlst = new XslCompiledTransform();
            xlst.Load(pathXsl);
            xlst.Transform(path, pathHtml);
            MessageBox.Show("Done!");
            System.Diagnostics.Process.Start(pathHtml);
        }

        private void OpenNewFile()
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog
            {
                InitialDirectory = "D:",
                Filter = "xml files(*.xml)|*.xml",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                wind.Clear();
                path = OpenFileDialog.FileName;
                builder.BuildBox();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (!SAXRadioButton.Checked && !DOMRadioButton.Checked && !LINQRadioButton.Checked)
            {
                MessageBox.Show("Choose a method!");
            }
            SearchFunc();
        }

        private void ToHtmlButton_Click(object sender, EventArgs e)
        {
            ToHTML();
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            ConferenceCheckBox.Checked = false;
            PlaceCheckBox.Checked = false;
            ThemeCheckBox.Checked = false;
            PersonCheckBox.Checked = false;
            DateCheckBox.Checked = false;
            PeriodCheckBox.Checked = false;
            CostCheckBox.Checked = false;

            ConferenceComboBox.Text = null;
            PlaceComboBox.Text = null;
            ThemeComboBox.Text = null;
            PersonComboBox.Text = null;
            DateComboBox.Text = null;
            PeriodComboBox.Text = null;
            CostComboBox.Text = null;

            SAXRadioButton.Checked = false;
            DOMRadioButton.Checked = false;
            LINQRadioButton.Checked = false;

            wind.Clear();
            wind.Text = "";
        }

        private void Curriculum_Load(object sender, EventArgs e)
        {
            foreach (var box in comboBoxes)
            {
                box.Enabled = false;
            }

            wind.Clear();
        }

        private void Curriculum_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Attention!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void ConferenceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IsCheckBoxChecked(ConferenceCheckBox);
        }

        private void PlaceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IsCheckBoxChecked(PlaceCheckBox);
        }

        private void ThemeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IsCheckBoxChecked(ThemeCheckBox);
        }

        private void PersonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IsCheckBoxChecked(PersonCheckBox);
        }

        private void DateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IsCheckBoxChecked(DateCheckBox);
        }

        private void PeriodCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IsCheckBoxChecked(PeriodCheckBox);
        }

        private void CostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IsCheckBoxChecked(CostCheckBox);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewFile();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Оберіть файл, з яким бажаєте працювати \n" +
               "2. Оберіть метод\n" +
               "3. Натисніть на кнопку \"Search\" для здійснення пошуку за всіма категоріями\n" +
               "4. Якщо бажаєте здійснити пошук за якоюсь категорією, або за декількома -" +
               " оберіть їх та їх значення і натисніть на \"Search\" \n" +
               "5. Якщо ви бажаєте сконвертувати файл в HTML формат, натисніть кнопку \"Convert\"\n" +
               "6. Натисніть кнопку \"Clear\", щоб очистити вікно \n" +
               "7. Натисніть кнопку \"Help!\" для виклику допомоги.", "Help!", MessageBoxButtons.OK);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Лабораторну роботу виконав \n" +
                "Кириченко Максим К-24 \n" +
                "Варіант №20 \n", "Help!", MessageBoxButtons.OK);
        }
    }
}