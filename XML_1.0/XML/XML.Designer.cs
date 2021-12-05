
namespace XML
{
    partial class Conferences
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.PersonCheckBox = new System.Windows.Forms.CheckBox();
            this.ThemeCheckBox = new System.Windows.Forms.CheckBox();
            this.PlaceComboBox = new System.Windows.Forms.ComboBox();
            this.PersonComboBox = new System.Windows.Forms.ComboBox();
            this.CostComboBox = new System.Windows.Forms.ComboBox();
            this.PeriodComboBox = new System.Windows.Forms.ComboBox();
            this.DateComboBox = new System.Windows.Forms.ComboBox();
            this.ThemeComboBox = new System.Windows.Forms.ComboBox();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConferenceComboBox = new System.Windows.Forms.ComboBox();
            this.CostCheckBox = new System.Windows.Forms.CheckBox();
            this.PeriodCheckBox = new System.Windows.Forms.CheckBox();
            this.DateCheckBox = new System.Windows.Forms.CheckBox();
            this.PlaceCheckBox = new System.Windows.Forms.CheckBox();
            this.CleanButton = new System.Windows.Forms.Button();
            this.ToHtmlButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.LINQRadioButton = new System.Windows.Forms.RadioButton();
            this.DOMRadioButton = new System.Windows.Forms.RadioButton();
            this.SAXRadioButton = new System.Windows.Forms.RadioButton();
            this.wind = new System.Windows.Forms.RichTextBox();
            this.ConferenceCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // PersonCheckBox
            // 
            this.PersonCheckBox.AutoSize = true;
            this.PersonCheckBox.ForeColor = System.Drawing.Color.Black;
            this.PersonCheckBox.Location = new System.Drawing.Point(552, 31);
            this.PersonCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PersonCheckBox.Name = "PersonCheckBox";
            this.PersonCheckBox.Size = new System.Drawing.Size(75, 21);
            this.PersonCheckBox.TabIndex = 47;
            this.PersonCheckBox.Text = "Person";
            this.PersonCheckBox.UseVisualStyleBackColor = true;
            this.PersonCheckBox.CheckedChanged += new System.EventHandler(this.PersonCheckBox_CheckedChanged);
            // 
            // ThemeCheckBox
            // 
            this.ThemeCheckBox.AutoSize = true;
            this.ThemeCheckBox.ForeColor = System.Drawing.Color.Black;
            this.ThemeCheckBox.Location = new System.Drawing.Point(377, 31);
            this.ThemeCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ThemeCheckBox.Name = "ThemeCheckBox";
            this.ThemeCheckBox.Size = new System.Drawing.Size(74, 21);
            this.ThemeCheckBox.TabIndex = 46;
            this.ThemeCheckBox.Text = "Theme";
            this.ThemeCheckBox.UseVisualStyleBackColor = true;
            this.ThemeCheckBox.CheckedChanged += new System.EventHandler(this.ThemeCheckBox_CheckedChanged);
            // 
            // PlaceComboBox
            // 
            this.PlaceComboBox.BackColor = System.Drawing.Color.White;
            this.PlaceComboBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PlaceComboBox.FormattingEnabled = true;
            this.PlaceComboBox.Location = new System.Drawing.Point(169, 59);
            this.PlaceComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlaceComboBox.Name = "PlaceComboBox";
            this.PlaceComboBox.Size = new System.Drawing.Size(160, 24);
            this.PlaceComboBox.TabIndex = 45;
            // 
            // PersonComboBox
            // 
            this.PersonComboBox.BackColor = System.Drawing.Color.White;
            this.PersonComboBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PersonComboBox.FormattingEnabled = true;
            this.PersonComboBox.Location = new System.Drawing.Point(508, 59);
            this.PersonComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PersonComboBox.Name = "PersonComboBox";
            this.PersonComboBox.Size = new System.Drawing.Size(160, 24);
            this.PersonComboBox.TabIndex = 44;
            // 
            // CostComboBox
            // 
            this.CostComboBox.BackColor = System.Drawing.Color.White;
            this.CostComboBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CostComboBox.FormattingEnabled = true;
            this.CostComboBox.Location = new System.Drawing.Point(1016, 59);
            this.CostComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CostComboBox.Name = "CostComboBox";
            this.CostComboBox.Size = new System.Drawing.Size(160, 24);
            this.CostComboBox.TabIndex = 43;
            // 
            // PeriodComboBox
            // 
            this.PeriodComboBox.BackColor = System.Drawing.Color.White;
            this.PeriodComboBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PeriodComboBox.FormattingEnabled = true;
            this.PeriodComboBox.Location = new System.Drawing.Point(847, 59);
            this.PeriodComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PeriodComboBox.Name = "PeriodComboBox";
            this.PeriodComboBox.Size = new System.Drawing.Size(160, 24);
            this.PeriodComboBox.TabIndex = 42;
            // 
            // DateComboBox
            // 
            this.DateComboBox.BackColor = System.Drawing.Color.White;
            this.DateComboBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.DateComboBox.FormattingEnabled = true;
            this.DateComboBox.Location = new System.Drawing.Point(677, 59);
            this.DateComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateComboBox.Name = "DateComboBox";
            this.DateComboBox.Size = new System.Drawing.Size(160, 24);
            this.DateComboBox.TabIndex = 41;
            // 
            // ThemeComboBox
            // 
            this.ThemeComboBox.BackColor = System.Drawing.Color.White;
            this.ThemeComboBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ThemeComboBox.FormattingEnabled = true;
            this.ThemeComboBox.Location = new System.Drawing.Point(339, 59);
            this.ThemeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ThemeComboBox.Name = "ThemeComboBox";
            this.ThemeComboBox.Size = new System.Drawing.Size(160, 24);
            this.ThemeComboBox.TabIndex = 40;
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.HelpToolStripMenuItem.Text = "Help!";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // ConferenceComboBox
            // 
            this.ConferenceComboBox.BackColor = System.Drawing.Color.White;
            this.ConferenceComboBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ConferenceComboBox.FormattingEnabled = true;
            this.ConferenceComboBox.Location = new System.Drawing.Point(0, 59);
            this.ConferenceComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConferenceComboBox.Name = "ConferenceComboBox";
            this.ConferenceComboBox.Size = new System.Drawing.Size(160, 24);
            this.ConferenceComboBox.TabIndex = 39;
            // 
            // CostCheckBox
            // 
            this.CostCheckBox.AutoSize = true;
            this.CostCheckBox.ForeColor = System.Drawing.Color.Black;
            this.CostCheckBox.Location = new System.Drawing.Point(1067, 31);
            this.CostCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CostCheckBox.Name = "CostCheckBox";
            this.CostCheckBox.Size = new System.Drawing.Size(58, 21);
            this.CostCheckBox.TabIndex = 38;
            this.CostCheckBox.Text = "Cost";
            this.CostCheckBox.UseVisualStyleBackColor = true;
            this.CostCheckBox.CheckedChanged += new System.EventHandler(this.CostCheckBox_CheckedChanged);
            // 
            // PeriodCheckBox
            // 
            this.PeriodCheckBox.AutoSize = true;
            this.PeriodCheckBox.ForeColor = System.Drawing.Color.Black;
            this.PeriodCheckBox.Location = new System.Drawing.Point(889, 31);
            this.PeriodCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PeriodCheckBox.Name = "PeriodCheckBox";
            this.PeriodCheckBox.Size = new System.Drawing.Size(71, 21);
            this.PeriodCheckBox.TabIndex = 37;
            this.PeriodCheckBox.Text = "Period";
            this.PeriodCheckBox.UseVisualStyleBackColor = true;
            this.PeriodCheckBox.CheckedChanged += new System.EventHandler(this.PeriodCheckBox_CheckedChanged);
            // 
            // DateCheckBox
            // 
            this.DateCheckBox.AutoSize = true;
            this.DateCheckBox.ForeColor = System.Drawing.Color.Black;
            this.DateCheckBox.Location = new System.Drawing.Point(728, 31);
            this.DateCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateCheckBox.Name = "DateCheckBox";
            this.DateCheckBox.Size = new System.Drawing.Size(60, 21);
            this.DateCheckBox.TabIndex = 36;
            this.DateCheckBox.Text = "Date";
            this.DateCheckBox.UseVisualStyleBackColor = true;
            this.DateCheckBox.CheckedChanged += new System.EventHandler(this.DateCheckBox_CheckedChanged);
            // 
            // PlaceCheckBox
            // 
            this.PlaceCheckBox.AutoSize = true;
            this.PlaceCheckBox.ForeColor = System.Drawing.Color.Black;
            this.PlaceCheckBox.Location = new System.Drawing.Point(216, 31);
            this.PlaceCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlaceCheckBox.Name = "PlaceCheckBox";
            this.PlaceCheckBox.Size = new System.Drawing.Size(65, 21);
            this.PlaceCheckBox.TabIndex = 35;
            this.PlaceCheckBox.Text = "Place";
            this.PlaceCheckBox.UseVisualStyleBackColor = true;
            this.PlaceCheckBox.CheckedChanged += new System.EventHandler(this.PlaceCheckBox_CheckedChanged);
            // 
            // CleanButton
            // 
            this.CleanButton.BackColor = System.Drawing.Color.Red;
            this.CleanButton.Location = new System.Drawing.Point(1016, 92);
            this.CleanButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(161, 111);
            this.CleanButton.TabIndex = 33;
            this.CleanButton.Text = "Clean";
            this.CleanButton.UseVisualStyleBackColor = false;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // ToHtmlButton
            // 
            this.ToHtmlButton.BackColor = System.Drawing.Color.Red;
            this.ToHtmlButton.Location = new System.Drawing.Point(677, 92);
            this.ToHtmlButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ToHtmlButton.Name = "ToHtmlButton";
            this.ToHtmlButton.Size = new System.Drawing.Size(331, 111);
            this.ToHtmlButton.TabIndex = 32;
            this.ToHtmlButton.Text = "Convert";
            this.ToHtmlButton.UseVisualStyleBackColor = false;
            this.ToHtmlButton.Click += new System.EventHandler(this.ToHtmlButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Red;
            this.SearchButton.ForeColor = System.Drawing.Color.Black;
            this.SearchButton.Location = new System.Drawing.Point(308, 92);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(361, 111);
            this.SearchButton.TabIndex = 31;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // LINQRadioButton
            // 
            this.LINQRadioButton.AutoSize = true;
            this.LINQRadioButton.ForeColor = System.Drawing.Color.Black;
            this.LINQRadioButton.Location = new System.Drawing.Point(120, 138);
            this.LINQRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LINQRadioButton.Name = "LINQRadioButton";
            this.LINQRadioButton.Size = new System.Drawing.Size(61, 21);
            this.LINQRadioButton.TabIndex = 30;
            this.LINQRadioButton.TabStop = true;
            this.LINQRadioButton.Text = "LINQ";
            this.LINQRadioButton.UseVisualStyleBackColor = true;
            // 
            // DOMRadioButton
            // 
            this.DOMRadioButton.AutoSize = true;
            this.DOMRadioButton.ForeColor = System.Drawing.Color.Black;
            this.DOMRadioButton.Location = new System.Drawing.Point(24, 138);
            this.DOMRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DOMRadioButton.Name = "DOMRadioButton";
            this.DOMRadioButton.Size = new System.Drawing.Size(61, 21);
            this.DOMRadioButton.TabIndex = 29;
            this.DOMRadioButton.TabStop = true;
            this.DOMRadioButton.Text = "DOM";
            this.DOMRadioButton.UseVisualStyleBackColor = true;
            // 
            // SAXRadioButton
            // 
            this.SAXRadioButton.AutoSize = true;
            this.SAXRadioButton.ForeColor = System.Drawing.Color.Black;
            this.SAXRadioButton.Location = new System.Drawing.Point(225, 138);
            this.SAXRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SAXRadioButton.Name = "SAXRadioButton";
            this.SAXRadioButton.Size = new System.Drawing.Size(56, 21);
            this.SAXRadioButton.TabIndex = 28;
            this.SAXRadioButton.TabStop = true;
            this.SAXRadioButton.Text = "SAX";
            this.SAXRadioButton.UseVisualStyleBackColor = true;
            // 
            // wind
            // 
            this.wind.BackColor = System.Drawing.Color.White;
            this.wind.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wind.ForeColor = System.Drawing.Color.Black;
            this.wind.Location = new System.Drawing.Point(0, 210);
            this.wind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wind.Name = "wind";
            this.wind.Size = new System.Drawing.Size(1176, 345);
            this.wind.TabIndex = 27;
            this.wind.Text = "";
            // 
            // ConferenceCheckBox
            // 
            this.ConferenceCheckBox.AutoSize = true;
            this.ConferenceCheckBox.ForeColor = System.Drawing.Color.Black;
            this.ConferenceCheckBox.Location = new System.Drawing.Point(47, 31);
            this.ConferenceCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConferenceCheckBox.Name = "ConferenceCheckBox";
            this.ConferenceCheckBox.Size = new System.Drawing.Size(57, 21);
            this.ConferenceCheckBox.TabIndex = 26;
            this.ConferenceCheckBox.Text = "Title";
            this.ConferenceCheckBox.UseVisualStyleBackColor = true;
            this.ConferenceCheckBox.CheckedChanged += new System.EventHandler(this.ConferenceCheckBox_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.HelpToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1180, 28);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Conferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 554);
            this.Controls.Add(this.PersonCheckBox);
            this.Controls.Add(this.ThemeCheckBox);
            this.Controls.Add(this.PlaceComboBox);
            this.Controls.Add(this.PersonComboBox);
            this.Controls.Add(this.CostComboBox);
            this.Controls.Add(this.PeriodComboBox);
            this.Controls.Add(this.DateComboBox);
            this.Controls.Add(this.ThemeComboBox);
            this.Controls.Add(this.ConferenceComboBox);
            this.Controls.Add(this.CostCheckBox);
            this.Controls.Add(this.PeriodCheckBox);
            this.Controls.Add(this.DateCheckBox);
            this.Controls.Add(this.PlaceCheckBox);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.ToHtmlButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.LINQRadioButton);
            this.Controls.Add(this.DOMRadioButton);
            this.Controls.Add(this.SAXRadioButton);
            this.Controls.Add(this.wind);
            this.Controls.Add(this.ConferenceCheckBox);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Conferences";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Curriculum_FormClosing);
            this.Load += new System.EventHandler(this.Curriculum_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.CheckBox PersonCheckBox;
        private System.Windows.Forms.CheckBox ThemeCheckBox;
        private System.Windows.Forms.ComboBox PlaceComboBox;
        private System.Windows.Forms.ComboBox PersonComboBox;
        private System.Windows.Forms.ComboBox CostComboBox;
        private System.Windows.Forms.ComboBox PeriodComboBox;
        private System.Windows.Forms.ComboBox DateComboBox;
        private System.Windows.Forms.ComboBox ThemeComboBox;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ComboBox ConferenceComboBox;
        private System.Windows.Forms.CheckBox CostCheckBox;
        private System.Windows.Forms.CheckBox PeriodCheckBox;
        private System.Windows.Forms.CheckBox DateCheckBox;
        private System.Windows.Forms.CheckBox PlaceCheckBox;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.Button ToHtmlButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.RadioButton LINQRadioButton;
        private System.Windows.Forms.RadioButton DOMRadioButton;
        private System.Windows.Forms.RadioButton SAXRadioButton;
        private System.Windows.Forms.RichTextBox wind;
        private System.Windows.Forms.CheckBox ConferenceCheckBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

