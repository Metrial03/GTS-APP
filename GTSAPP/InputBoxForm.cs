using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSAPP
{
    public partial class InputBoxForm : Form
    {
        public string OldInstituteName { get; private set; }
        public string NewInstituteName { get; private set; }

        public InputBoxForm()
        {
            InitializeComponent();
        }

        private void updateinst_Click(object sender, EventArgs e)
        {
            OldInstituteName = oldInstituteTextBox.Text;
            NewInstituteName = newInstituteTextBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InitializeComponent()
        {
            oldInstituteTextBox = new TextBox();
            newInstituteTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            updateinst = new Button();
            updatecinst = new Button();
            SuspendLayout();
            // 
            // oldInstituteTextBox
            // 
            oldInstituteTextBox.Location = new Point(163, 64);
            oldInstituteTextBox.Name = "oldInstituteTextBox";
            oldInstituteTextBox.Size = new Size(139, 23);
            oldInstituteTextBox.TabIndex = 0;
            // 
            // newInstituteTextBox
            // 
            newInstituteTextBox.Location = new Point(163, 111);
            newInstituteTextBox.Name = "newInstituteTextBox";
            newInstituteTextBox.Size = new Size(139, 23);
            newInstituteTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold);
            label1.Location = new Point(-1, 113);
            label1.Name = "label1";
            label1.Size = new Size(162, 19);
            label1.TabIndex = 2;
            label1.Text = "New Institute Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 66);
            label2.Name = "label2";
            label2.Size = new Size(155, 19);
            label2.TabIndex = 3;
            label2.Text = "Old Institute Name :";
            // 
            // updateinst
            // 
            updateinst.BackColor = Color.FromArgb(64, 64, 64);
            updateinst.FlatStyle = FlatStyle.Popup;
            updateinst.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            updateinst.ForeColor = Color.White;
            updateinst.Location = new Point(65, 181);
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
            updatecinst.Location = new Point(163, 181);
            updatecinst.Name = "updatecinst";
            updatecinst.Size = new Size(83, 33);
            updatecinst.TabIndex = 15;
            updatecinst.Text = "CANCEL";
            updatecinst.UseVisualStyleBackColor = false;
            updatecinst.Click += updatecinst_Click;
            // 
            // InputBoxForm
            // 
            AcceptButton = updateinst;
            BackColor = Color.Honeydew;
            BackgroundImageLayout = ImageLayout.None;
            CancelButton = updatecinst;
            ClientSize = new Size(314, 226);
            Controls.Add(updatecinst);
            Controls.Add(updateinst);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(newInstituteTextBox);
            Controls.Add(oldInstituteTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "InputBoxForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        private void updatecinst_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private TextBox oldInstituteTextBox;
        private Label label1;
        private Label label2;
        private Button updateinst;
        private Button updatecinst;
        private TextBox newInstituteTextBox;
    }
}
