using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTSAPP
{
    public partial class InputBoxForm : Form
    {
        public string OldInstituteName { get; set; }
        public string NewInstituteName { get; set; }
        public string OldUniversityName { get; set; }
        public string NewUniversityName { get; set; }
        public string UpdateType { get; set; } 

        public InputBoxForm()
        {
            InitializeComponent();
        }

        private void updateinst_Click(object sender, EventArgs e)
        {
            OldInstituteName = oldInstituteTextBox.Text;
            NewInstituteName = newInstituteTextBox.Text;
            UpdateType = "Institute"; 
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void updateuniv_Click(object sender, EventArgs e)
        {
            OldUniversityName = oldUniversityTextBox.Text;
            NewUniversityName = newUniversityTextBox.Text;
            UpdateType = "University";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void updatecinst_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void updatecuniv_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void InitializeComponent()
        {
            oldInstituteTextBox = new TextBox();
            newInstituteTextBox = new TextBox();
            label1 = new Label();
            updateinst = new Button();
            updatecinst = new Button();
            tabControl1 = new TabControl();
            Institute = new TabPage();
            label2 = new Label();
            tabPage2 = new TabPage();
            this.updatecuniv = new Button();
            this.updateuniv = new Button();
            this.label3 = new Label();
            this.label4 = new Label();
            this.oldUniversityTextBox = new TextBox();
            this.newUniversityTextBox = new TextBox();
            tabControl1.SuspendLayout();
            Institute.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // oldInstituteTextBox
            // 
            oldInstituteTextBox.Location = new Point(148, 54);
            oldInstituteTextBox.Name = "oldInstituteTextBox";
            oldInstituteTextBox.Size = new Size(139, 23);
            oldInstituteTextBox.TabIndex = 0;
            // 
            // newInstituteTextBox
            // 
            newInstituteTextBox.Location = new Point(148, 100);
            newInstituteTextBox.Name = "newInstituteTextBox";
            newInstituteTextBox.Size = new Size(139, 23);
            newInstituteTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold);
            label1.Location = new Point(16, 85);
            label1.Name = "label1";
            label1.Size = new Size(125, 38);
            label1.TabIndex = 2;
            label1.Text = "New \r\nInstitute Name :";
            // 
            // updateinst
            // 
            updateinst.BackColor = Color.FromArgb(64, 64, 64);
            updateinst.FlatStyle = FlatStyle.Popup;
            updateinst.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            updateinst.ForeColor = Color.White;
            updateinst.Location = new Point(61, 157);
            updateinst.Name = "updateinst";
            updateinst.Size = new Size(83, 33);
            updateinst.TabIndex = 14;
            updateinst.Text = "CHANGE";
            updateinst.UseVisualStyleBackColor = false;
            updateinst.Click += updateinst_Click;
            // 
            // updatecinst
            // 
            updatecinst.BackColor = Color.FromArgb(64, 64, 64);
            updatecinst.FlatStyle = FlatStyle.Popup;
            updatecinst.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            updatecinst.ForeColor = Color.White;
            updatecinst.Location = new Point(159, 157);
            updatecinst.Name = "updatecinst";
            updatecinst.Size = new Size(83, 33);
            updatecinst.TabIndex = 15;
            updatecinst.Text = "CANCEL";
            updatecinst.UseVisualStyleBackColor = false;
            updatecinst.Click += updatecinst_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Institute);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(314, 226);
            tabControl1.TabIndex = 16;
            // 
            // Institute
            // 
            Institute.BackColor = Color.Honeydew;
            Institute.Controls.Add(updatecinst);
            Institute.Controls.Add(updateinst);
            Institute.Controls.Add(label1);
            Institute.Controls.Add(label2);
            Institute.Controls.Add(oldInstituteTextBox);
            Institute.Controls.Add(newInstituteTextBox);
            Institute.Location = new Point(4, 24);
            Institute.Name = "Institute";
            Institute.Padding = new Padding(3);
            Institute.Size = new Size(306, 198);
            Institute.TabIndex = 0;
            Institute.Text = "Institute";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 37);
            label2.Name = "label2";
            label2.Size = new Size(125, 38);
            label2.TabIndex = 3;
            label2.Text = "Old \r\nInstitute Name :";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Honeydew;
            tabPage2.Controls.Add(updatecuniv);
            tabPage2.Controls.Add(updateuniv);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(oldUniversityTextBox);
            tabPage2.Controls.Add(newUniversityTextBox);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(306, 198);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "University";
            // 
            // updatecuniv
            // 
            updatecuniv.BackColor = Color.FromArgb(64, 64, 64);
            updatecuniv.FlatStyle = FlatStyle.Popup;
            updatecuniv.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            updatecuniv.ForeColor = Color.White;
            updatecuniv.Location = new Point(159, 157);
            updatecuniv.Name = "updatecuniv";
            updatecuniv.Size = new Size(83, 33);
            updatecuniv.TabIndex = 21;
            updatecuniv.Text = "CANCEL";
            updatecuniv.UseVisualStyleBackColor = false;
            updatecuniv.Click += updatecuniv_Click;
            // 
            // updateuniv
            // 
            updateuniv.BackColor = Color.FromArgb(64, 64, 64);
            updateuniv.FlatStyle = FlatStyle.Popup;
            updateuniv.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            updateuniv.ForeColor = Color.White;
            updateuniv.Location = new Point(61, 157);
            updateuniv.Name = "updateuniv";
            updateuniv.Size = new Size(83, 33);
            updateuniv.TabIndex = 20;
            updateuniv.Text = "CHANGE";
            updateuniv.UseVisualStyleBackColor = false;
            updateuniv.Click += updateuniv_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold);
            label3.Location = new Point(8, 85);
            label3.Name = "label3";
            label3.Size = new Size(136, 38);
            label3.TabIndex = 18;
            label3.Text = "New \r\nUniversity Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 37);
            label4.Name = "label4";
            label4.Size = new Size(136, 38);
            label4.TabIndex = 19;
            label4.Text = "Old \r\nUniversity Name :";
            // 
            // oldUniversityTextBox
            // 
            oldUniversityTextBox.Location = new Point(148, 54);
            oldUniversityTextBox.Name = "oldUniversityTextBox";
            oldUniversityTextBox.Size = new Size(139, 23);
            oldUniversityTextBox.TabIndex = 16;
            // 
            // newUniversityTextBox
            // 
            newUniversityTextBox.Location = new Point(148, 100);
            newUniversityTextBox.Name = "newUniversityTextBox";
            newUniversityTextBox.Size = new Size(139, 23);
            newUniversityTextBox.TabIndex = 17;
            // 
            // InputBoxForm
            // 
            AcceptButton = updateuniv;
            BackColor = Color.Honeydew;
            BackgroundImageLayout = ImageLayout.None;
            CancelButton = updatecuniv;
            ClientSize = new Size(314, 226);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "InputBoxForm";
            StartPosition = FormStartPosition.CenterScreen;
            tabControl1.ResumeLayout(false);
            Institute.ResumeLayout(false);
            Institute.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        private TextBox oldInstituteTextBox;
        private Label label1;
        private Button updateinst;
        private Button updatecinst;
        private TabControl tabControl1;
        private TabPage Institute;
        private TabPage tabPage2;
        private Label label2;
        private TextBox newInstituteTextBox;
        private Button updatecuniv;
        private Button updateuniv;
        private Label label3;
        private Label label4;
        private TextBox oldUniversityTextBox;
        private TextBox newUniversityTextBox;
    }
}