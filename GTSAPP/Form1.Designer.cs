using System.Windows.Forms;

namespace GTSAPP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            updateinst = new Button();
            updatep = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            listuni = new Button();
            dataGridView1 = new DataGridView();
            linkinst = new Button();
            listp = new Button();
            listinst = new Button();
            addp = new Button();
            pictureBox2 = new PictureBox();
            deletep = new Button();
            deleteinst = new Button();
            personLName = new TextBox();
            instName = new TextBox();
            personFName = new TextBox();
            deleteuni = new Button();
            userId = new TextBox();
            dataGridView2 = new DataGridView();
            adduni = new Button();
            uniName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            label5 = new Label();
            label2 = new Label();
            tabPage2 = new TabPage();
            updateThesis = new Button();
            subjectL = new CheckedListBox();
            panel5 = new Panel();
            panel4 = new Panel();
            label19 = new Label();
            label9 = new Label();
            keyword = new TextBox();
            addkeyw = new Button();
            addThesis = new Button();
            label18 = new Label();
            label17 = new Label();
            label21 = new Label();
            selectLang = new ComboBox();
            label15 = new Label();
            label13 = new Label();
            label12 = new Label();
            subdatepick = new DateTimePicker();
            label16 = new Label();
            deleteThesis = new Button();
            label14 = new Label();
            rad4 = new RadioButton();
            rad3 = new RadioButton();
            rad2 = new RadioButton();
            rad1 = new RadioButton();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            pages = new TextBox();
            instNameT = new TextBox();
            uniNameT = new TextBox();
            label20 = new Label();
            supId = new TextBox();
            year = new TextBox();
            authorId = new TextBox();
            abstrac = new TextBox();
            title = new TextBox();
            thesisNo = new TextBox();
            deleteKeyw = new Button();
            cosupId = new TextBox();
            tabPage3 = new TabPage();
            AuthorIdS = new TextBox();
            thesisNoS = new TextBox();
            dataGridView3 = new DataGridView();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label22 = new Label();
            thesisSearch = new Button();
            label23 = new Label();
            errorProvider1 = new ErrorProvider(components);
            saveFileDialog1 = new SaveFileDialog();
            pageSetupDialog1 = new PageSetupDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1014, 701);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FloralWhite;
            tabPage1.BackgroundImageLayout = ImageLayout.Center;
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(updateinst);
            tabPage1.Controls.Add(updatep);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(pictureBox3);
            tabPage1.Controls.Add(listuni);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(linkinst);
            tabPage1.Controls.Add(listp);
            tabPage1.Controls.Add(listinst);
            tabPage1.Controls.Add(addp);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(deletep);
            tabPage1.Controls.Add(deleteinst);
            tabPage1.Controls.Add(personLName);
            tabPage1.Controls.Add(instName);
            tabPage1.Controls.Add(personFName);
            tabPage1.Controls.Add(deleteuni);
            tabPage1.Controls.Add(userId);
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Controls.Add(adduni);
            tabPage1.Controls.Add(uniName);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1006, 673);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "General";
            // 
            // updateinst
            // 
            updateinst.BackColor = Color.FromArgb(64, 64, 64);
            updateinst.FlatStyle = FlatStyle.Popup;
            updateinst.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            updateinst.ForeColor = Color.White;
            updateinst.Location = new Point(609, 422);
            updateinst.Name = "updateinst";
            updateinst.Size = new Size(66, 23);
            updateinst.TabIndex = 23;
            updateinst.Text = "UPDATE";
            updateinst.UseVisualStyleBackColor = false;
            updateinst.Click += updateinst_Click;
            // 
            // updatep
            // 
            updatep.BackColor = Color.FromArgb(64, 64, 64);
            updatep.FlatStyle = FlatStyle.Popup;
            updatep.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            updatep.ForeColor = Color.White;
            updatep.Location = new Point(609, 94);
            updatep.Name = "updatep";
            updatep.Size = new Size(66, 23);
            updatep.TabIndex = 22;
            updatep.Text = "UPDATE";
            updatep.UseVisualStyleBackColor = false;
            updatep.Click += updatep_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(880, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(121, 665);
            panel3.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(121, 665);
            panel2.TabIndex = 20;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = Properties.Resources.university;
            pictureBox3.Location = new Point(192, 339);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(101, 92);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // listuni
            // 
            listuni.BackColor = Color.FromArgb(64, 64, 64);
            listuni.FlatStyle = FlatStyle.Popup;
            listuni.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            listuni.ForeColor = Color.White;
            listuni.Location = new Point(681, 370);
            listuni.Name = "listuni";
            listuni.Size = new Size(66, 23);
            listuni.TabIndex = 19;
            listuni.Text = "LIST";
            listuni.UseVisualStyleBackColor = false;
            listuni.Click += listuniv_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.MistyRose;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Azure;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(174, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(657, 174);
            dataGridView1.TabIndex = 7;
            // 
            // linkinst
            // 
            linkinst.BackColor = Color.FromArgb(64, 64, 64);
            linkinst.FlatStyle = FlatStyle.Popup;
            linkinst.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            linkinst.ForeColor = Color.White;
            linkinst.Location = new Point(609, 396);
            linkinst.Name = "linkinst";
            linkinst.Size = new Size(66, 23);
            linkinst.TabIndex = 18;
            linkinst.Text = "LINK";
            linkinst.UseVisualStyleBackColor = false;
            linkinst.Click += linkinst_Click;
            // 
            // listp
            // 
            listp.BackColor = Color.FromArgb(64, 64, 64);
            listp.FlatStyle = FlatStyle.Popup;
            listp.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            listp.ForeColor = Color.White;
            listp.Location = new Point(681, 66);
            listp.Name = "listp";
            listp.Size = new Size(66, 24);
            listp.TabIndex = 6;
            listp.Text = "LIST";
            listp.UseVisualStyleBackColor = false;
            listp.Click += listp_Click;
            // 
            // listinst
            // 
            listinst.BackColor = Color.FromArgb(64, 64, 64);
            listinst.FlatStyle = FlatStyle.Popup;
            listinst.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            listinst.ForeColor = Color.White;
            listinst.Location = new Point(681, 396);
            listinst.Name = "listinst";
            listinst.Size = new Size(66, 23);
            listinst.TabIndex = 17;
            listinst.Text = "LIST";
            listinst.UseVisualStyleBackColor = false;
            listinst.Click += listinst_Click;
            // 
            // addp
            // 
            addp.BackColor = Color.FromArgb(64, 64, 64);
            addp.FlatStyle = FlatStyle.Popup;
            addp.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            addp.ForeColor = Color.White;
            addp.Location = new Point(609, 66);
            addp.Name = "addp";
            addp.Size = new Size(66, 23);
            addp.TabIndex = 5;
            addp.Text = "ADD";
            addp.UseVisualStyleBackColor = false;
            addp.Click += addp_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = Properties.Resources.person;
            pictureBox2.Location = new Point(206, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(92, 92);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // deletep
            // 
            deletep.BackColor = Color.FromArgb(64, 64, 64);
            deletep.FlatStyle = FlatStyle.Popup;
            deletep.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            deletep.ForeColor = Color.White;
            deletep.Location = new Point(753, 66);
            deletep.Name = "deletep";
            deletep.Size = new Size(66, 23);
            deletep.TabIndex = 8;
            deletep.Text = "DELETE";
            deletep.UseVisualStyleBackColor = false;
            deletep.Click += deletep_Click;
            // 
            // deleteinst
            // 
            deleteinst.BackColor = Color.FromArgb(64, 64, 64);
            deleteinst.FlatStyle = FlatStyle.Popup;
            deleteinst.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            deleteinst.ForeColor = Color.White;
            deleteinst.Location = new Point(753, 396);
            deleteinst.Name = "deleteinst";
            deleteinst.Size = new Size(66, 23);
            deleteinst.TabIndex = 15;
            deleteinst.Text = "DELETE";
            deleteinst.UseVisualStyleBackColor = false;
            deleteinst.Click += deleteinst_Click;
            // 
            // personLName
            // 
            personLName.Location = new Point(437, 94);
            personLName.Name = "personLName";
            personLName.Size = new Size(166, 21);
            personLName.TabIndex = 4;
            // 
            // instName
            // 
            instName.Location = new Point(437, 397);
            instName.Name = "instName";
            instName.Size = new Size(156, 21);
            instName.TabIndex = 10;
            // 
            // personFName
            // 
            personFName.Location = new Point(437, 67);
            personFName.Name = "personFName";
            personFName.Size = new Size(166, 21);
            personFName.TabIndex = 3;
            // 
            // deleteuni
            // 
            deleteuni.BackColor = Color.FromArgb(64, 64, 64);
            deleteuni.FlatStyle = FlatStyle.Popup;
            deleteuni.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            deleteuni.ForeColor = Color.White;
            deleteuni.Location = new Point(753, 370);
            deleteuni.Name = "deleteuni";
            deleteuni.Size = new Size(66, 23);
            deleteuni.TabIndex = 14;
            deleteuni.Text = "DELETE";
            deleteuni.UseVisualStyleBackColor = false;
            deleteuni.Click += deleteuni_Click;
            // 
            // userId
            // 
            userId.Location = new Point(437, 40);
            userId.Name = "userId";
            userId.Size = new Size(166, 21);
            userId.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = Color.MistyRose;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.Azure;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(174, 453);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(657, 186);
            dataGridView2.TabIndex = 16;
            // 
            // adduni
            // 
            adduni.BackColor = Color.FromArgb(64, 64, 64);
            adduni.FlatStyle = FlatStyle.Popup;
            adduni.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            adduni.ForeColor = Color.White;
            adduni.Location = new Point(609, 370);
            adduni.Name = "adduni";
            adduni.Size = new Size(66, 23);
            adduni.TabIndex = 13;
            adduni.Text = "ADD";
            adduni.UseVisualStyleBackColor = false;
            adduni.Click += adduniv_Click;
            // 
            // uniName
            // 
            uniName.Location = new Point(437, 372);
            uniName.Name = "uniName";
            uniName.Size = new Size(156, 21);
            uniName.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(314, 92);
            label3.Name = "label3";
            label3.Size = new Size(118, 24);
            label3.TabIndex = 2;
            label3.Text = "SURNAME :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(296, 369);
            label4.Name = "label4";
            label4.Size = new Size(133, 24);
            label4.TabIndex = 11;
            label4.Text = "UNIVERSITY :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(352, 65);
            label1.Name = "label1";
            label1.Size = new Size(80, 24);
            label1.TabIndex = 0;
            label1.Text = "NAME :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(312, 394);
            label5.Name = "label5";
            label5.Size = new Size(117, 24);
            label5.TabIndex = 12;
            label5.Text = "INSTITUTE :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(307, 39);
            label2.Name = "label2";
            label2.Size = new Size(125, 24);
            label2.TabIndex = 1;
            label2.Text = "PERSON ID :";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FloralWhite;
            tabPage2.BackgroundImageLayout = ImageLayout.Center;
            tabPage2.BorderStyle = BorderStyle.FixedSingle;
            tabPage2.Controls.Add(updateThesis);
            tabPage2.Controls.Add(subjectL);
            tabPage2.Controls.Add(panel5);
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(label19);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(keyword);
            tabPage2.Controls.Add(addkeyw);
            tabPage2.Controls.Add(addThesis);
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(label21);
            tabPage2.Controls.Add(selectLang);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(subdatepick);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(deleteThesis);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(rad4);
            tabPage2.Controls.Add(rad3);
            tabPage2.Controls.Add(rad2);
            tabPage2.Controls.Add(rad1);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(pages);
            tabPage2.Controls.Add(instNameT);
            tabPage2.Controls.Add(uniNameT);
            tabPage2.Controls.Add(label20);
            tabPage2.Controls.Add(supId);
            tabPage2.Controls.Add(year);
            tabPage2.Controls.Add(authorId);
            tabPage2.Controls.Add(abstrac);
            tabPage2.Controls.Add(title);
            tabPage2.Controls.Add(thesisNo);
            tabPage2.Controls.Add(deleteKeyw);
            tabPage2.Controls.Add(cosupId);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1006, 673);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thesis";
            // 
            // updateThesis
            // 
            updateThesis.BackColor = Color.FromArgb(64, 64, 64);
            updateThesis.FlatStyle = FlatStyle.Popup;
            updateThesis.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            updateThesis.ForeColor = Color.White;
            updateThesis.Location = new Point(635, 588);
            updateThesis.Name = "updateThesis";
            updateThesis.Size = new Size(101, 44);
            updateThesis.TabIndex = 84;
            updateThesis.Text = "UPDATE";
            updateThesis.UseVisualStyleBackColor = false;
            updateThesis.Click += updateThesis_Click;
            // 
            // subjectL
            // 
            subjectL.BackColor = SystemColors.Window;
            subjectL.CheckOnClick = true;
            subjectL.FormattingEnabled = true;
            subjectL.Location = new Point(364, 212);
            subjectL.Name = "subjectL";
            subjectL.Size = new Size(233, 84);
            subjectL.TabIndex = 83;
            // 
            // panel5
            // 
            panel5.BackColor = Color.CadetBlue;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(880, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(121, 665);
            panel5.TabIndex = 80;
            // 
            // panel4
            // 
            panel4.BackColor = Color.CadetBlue;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(121, 665);
            panel4.TabIndex = 79;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold);
            label19.Location = new Point(214, 310);
            label19.Name = "label19";
            label19.Size = new Size(144, 24);
            label19.TabIndex = 69;
            label19.Text = "KEYWORD(S) :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold);
            label9.Location = new Point(229, 352);
            label9.Name = "label9";
            label9.Size = new Size(129, 24);
            label9.TabIndex = 55;
            label9.Text = "AUTHOR ID :";
            // 
            // keyword
            // 
            keyword.Location = new Point(364, 313);
            keyword.Name = "keyword";
            keyword.Size = new Size(143, 21);
            keyword.TabIndex = 72;
            // 
            // addkeyw
            // 
            addkeyw.BackColor = Color.FromArgb(64, 64, 64);
            addkeyw.FlatStyle = FlatStyle.Popup;
            addkeyw.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            addkeyw.ForeColor = Color.White;
            addkeyw.Location = new Point(513, 311);
            addkeyw.Name = "addkeyw";
            addkeyw.Size = new Size(75, 23);
            addkeyw.TabIndex = 71;
            addkeyw.Text = "ADD";
            addkeyw.UseVisualStyleBackColor = false;
            addkeyw.Click += addkeyw_Click;
            // 
            // addThesis
            // 
            addThesis.BackColor = Color.FromArgb(64, 64, 64);
            addThesis.FlatStyle = FlatStyle.Popup;
            addThesis.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            addThesis.ForeColor = Color.White;
            addThesis.Location = new Point(528, 588);
            addThesis.Name = "addThesis";
            addThesis.Size = new Size(101, 44);
            addThesis.TabIndex = 76;
            addThesis.Text = "ADD THESIS";
            addThesis.UseVisualStyleBackColor = false;
            addThesis.Click += addThesis_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold);
            label18.Location = new Point(210, 209);
            label18.Name = "label18";
            label18.Size = new Size(148, 24);
            label18.TabIndex = 68;
            label18.Text = "THESIS TOPIC :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold);
            label17.Location = new Point(514, 380);
            label17.Name = "label17";
            label17.Size = new Size(195, 24);
            label17.TabIndex = 67;
            label17.Text = "COSUPERVISOR ID :";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold);
            label21.Location = new Point(160, 553);
            label21.Name = "label21";
            label21.Size = new Size(198, 24);
            label21.TabIndex = 75;
            label21.Text = "SUBMISSION DATE :";
            // 
            // selectLang
            // 
            selectLang.AccessibleName = "";
            selectLang.BackColor = SystemColors.Window;
            selectLang.DropDownStyle = ComboBoxStyle.DropDownList;
            selectLang.FormattingEnabled = true;
            selectLang.Location = new Point(715, 525);
            selectLang.Name = "selectLang";
            selectLang.Size = new Size(133, 23);
            selectLang.TabIndex = 70;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold);
            label15.Location = new Point(582, 525);
            label15.Name = "label15";
            label15.Size = new Size(127, 24);
            label15.TabIndex = 65;
            label15.Text = "LANGUAGE :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold);
            label13.Location = new Point(176, 525);
            label13.Name = "label13";
            label13.Size = new Size(182, 24);
            label13.TabIndex = 63;
            label13.Text = "INSTITUTE NAME :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold);
            label12.Location = new Point(160, 497);
            label12.Name = "label12";
            label12.Size = new Size(198, 24);
            label12.TabIndex = 62;
            label12.Text = "UNIVERSITY NAME :";
            // 
            // subdatepick
            // 
            subdatepick.Location = new Point(364, 555);
            subdatepick.Name = "subdatepick";
            subdatepick.Size = new Size(207, 21);
            subdatepick.TabIndex = 51;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold);
            label16.Location = new Point(543, 352);
            label16.Name = "label16";
            label16.Size = new Size(166, 24);
            label16.TabIndex = 66;
            label16.Text = "SUPERVISOR ID :";
            // 
            // deleteThesis
            // 
            deleteThesis.BackColor = Color.FromArgb(64, 64, 64);
            deleteThesis.FlatStyle = FlatStyle.Popup;
            deleteThesis.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            deleteThesis.ForeColor = Color.White;
            deleteThesis.Location = new Point(742, 588);
            deleteThesis.Name = "deleteThesis";
            deleteThesis.Size = new Size(106, 44);
            deleteThesis.TabIndex = 78;
            deleteThesis.Text = "DELETE THESIS";
            deleteThesis.UseVisualStyleBackColor = false;
            deleteThesis.Click += deleteThesis_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold);
            label14.Location = new Point(627, 497);
            label14.Name = "label14";
            label14.Size = new Size(82, 24);
            label14.TabIndex = 64;
            label14.Text = "PAGES :";
            // 
            // rad4
            // 
            rad4.AutoSize = true;
            rad4.BackColor = Color.Transparent;
            rad4.Location = new Point(470, 453);
            rad4.Name = "rad4";
            rad4.Size = new Size(113, 19);
            rad4.TabIndex = 61;
            rad4.TabStop = true;
            rad4.Text = "Proficiency in Art";
            rad4.UseVisualStyleBackColor = false;
            // 
            // rad3
            // 
            rad3.AutoSize = true;
            rad3.BackColor = Color.Transparent;
            rad3.Location = new Point(470, 428);
            rad3.Name = "rad3";
            rad3.Size = new Size(166, 19);
            rad3.TabIndex = 60;
            rad3.TabStop = true;
            rad3.Text = "Specialization in Medicine";
            rad3.UseVisualStyleBackColor = false;
            // 
            // rad2
            // 
            rad2.AutoSize = true;
            rad2.BackColor = Color.Transparent;
            rad2.Location = new Point(364, 453);
            rad2.Name = "rad2";
            rad2.Size = new Size(78, 19);
            rad2.TabIndex = 59;
            rad2.TabStop = true;
            rad2.Text = "Doctorate";
            rad2.UseVisualStyleBackColor = false;
            // 
            // rad1
            // 
            rad1.AutoSize = true;
            rad1.BackColor = Color.Transparent;
            rad1.Location = new Point(364, 428);
            rad1.Name = "rad1";
            rad1.Size = new Size(62, 19);
            rad1.TabIndex = 58;
            rad1.TabStop = true;
            rad1.Text = "Master";
            rad1.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold);
            label11.Location = new Point(292, 424);
            label11.Name = "label11";
            label11.Size = new Size(66, 24);
            label11.TabIndex = 57;
            label11.Text = "TYPE :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold);
            label10.Location = new Point(288, 380);
            label10.Name = "label10";
            label10.Size = new Size(70, 24);
            label10.TabIndex = 56;
            label10.Text = "YEAR :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold);
            label8.Location = new Point(238, 87);
            label8.Name = "label8";
            label8.Size = new Size(119, 24);
            label8.TabIndex = 54;
            label8.Text = "ABSTRACT :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold);
            label7.Location = new Point(288, 58);
            label7.Name = "label7";
            label7.Size = new Size(69, 24);
            label7.TabIndex = 53;
            label7.Text = "TITLE :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold);
            label6.Location = new Point(235, 29);
            label6.Name = "label6";
            label6.Size = new Size(122, 24);
            label6.TabIndex = 52;
            label6.Text = "THESIS NO :";
            // 
            // pages
            // 
            pages.Location = new Point(715, 498);
            pages.Name = "pages";
            pages.Size = new Size(81, 21);
            pages.TabIndex = 50;
            // 
            // instNameT
            // 
            instNameT.Location = new Point(364, 528);
            instNameT.Name = "instNameT";
            instNameT.Size = new Size(207, 21);
            instNameT.TabIndex = 49;
            // 
            // uniNameT
            // 
            uniNameT.Location = new Point(364, 499);
            uniNameT.Name = "uniNameT";
            uniNameT.Size = new Size(207, 21);
            uniNameT.TabIndex = 48;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Location = new Point(680, 308);
            label20.Name = "label20";
            label20.Size = new Size(106, 30);
            label20.TabIndex = 73;
            label20.Text = "(Press ADD \r\nfor each keyword.)";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // supId
            // 
            supId.Location = new Point(715, 355);
            supId.Name = "supId";
            supId.Size = new Size(100, 21);
            supId.TabIndex = 46;
            // 
            // year
            // 
            year.Location = new Point(364, 381);
            year.Name = "year";
            year.Size = new Size(100, 21);
            year.TabIndex = 45;
            // 
            // authorId
            // 
            authorId.Location = new Point(364, 354);
            authorId.Name = "authorId";
            authorId.Size = new Size(100, 21);
            authorId.TabIndex = 44;
            // 
            // abstrac
            // 
            abstrac.Location = new Point(363, 91);
            abstrac.Multiline = true;
            abstrac.Name = "abstrac";
            abstrac.Size = new Size(345, 110);
            abstrac.TabIndex = 43;
            // 
            // title
            // 
            title.Location = new Point(363, 62);
            title.Name = "title";
            title.Size = new Size(246, 21);
            title.TabIndex = 42;
            // 
            // thesisNo
            // 
            thesisNo.Location = new Point(363, 33);
            thesisNo.Name = "thesisNo";
            thesisNo.Size = new Size(118, 21);
            thesisNo.TabIndex = 41;
            // 
            // deleteKeyw
            // 
            deleteKeyw.BackColor = Color.FromArgb(64, 64, 64);
            deleteKeyw.FlatStyle = FlatStyle.Popup;
            deleteKeyw.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            deleteKeyw.ForeColor = Color.White;
            deleteKeyw.Location = new Point(593, 311);
            deleteKeyw.Name = "deleteKeyw";
            deleteKeyw.Size = new Size(75, 23);
            deleteKeyw.TabIndex = 77;
            deleteKeyw.Text = "DELETE";
            deleteKeyw.UseVisualStyleBackColor = false;
            deleteKeyw.Click += deleteKeyword_Click;
            // 
            // cosupId
            // 
            cosupId.Location = new Point(715, 382);
            cosupId.Name = "cosupId";
            cosupId.Size = new Size(100, 21);
            cosupId.TabIndex = 47;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.SlateGray;
            tabPage3.BackgroundImageLayout = ImageLayout.Center;
            tabPage3.BorderStyle = BorderStyle.FixedSingle;
            tabPage3.Controls.Add(AuthorIdS);
            tabPage3.Controls.Add(thesisNoS);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Controls.Add(panel1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1006, 673);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Thesis Search";
            // 
            // AuthorIdS
            // 
            AuthorIdS.Location = new Point(265, 93);
            AuthorIdS.Name = "AuthorIdS";
            AuthorIdS.Size = new Size(157, 21);
            AuthorIdS.TabIndex = 2;
            // 
            // thesisNoS
            // 
            thesisNoS.Location = new Point(265, 58);
            thesisNoS.Name = "thesisNoS";
            thesisNoS.Size = new Size(157, 21);
            thesisNoS.TabIndex = 1;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = Color.MistyRose;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BackgroundColor = Color.Azure;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(8, 160);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.Size = new Size(989, 504);
            dataGridView3.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FloralWhite;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label22);
            panel1.Controls.Add(thesisSearch);
            panel1.Controls.Add(label23);
            panel1.Location = new Point(8, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(555, 112);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(16, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.Black;
            label22.Location = new Point(128, 27);
            label22.Name = "label22";
            label22.Size = new Size(122, 24);
            label22.TabIndex = 3;
            label22.Text = "THESIS NO :";
            // 
            // thesisSearch
            // 
            thesisSearch.BackColor = Color.FromArgb(64, 64, 64);
            thesisSearch.FlatStyle = FlatStyle.Popup;
            thesisSearch.Font = new Font("Arial Narrow", 14F, FontStyle.Bold);
            thesisSearch.ForeColor = Color.White;
            thesisSearch.Location = new Point(431, 27);
            thesisSearch.Name = "thesisSearch";
            thesisSearch.Size = new Size(103, 58);
            thesisSearch.TabIndex = 5;
            thesisSearch.Text = "SEARCH";
            thesisSearch.UseVisualStyleBackColor = false;
            thesisSearch.Click += thesisSearch_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold);
            label23.ForeColor = Color.Black;
            label23.Location = new Point(121, 61);
            label23.Name = "label23";
            label23.Size = new Size(129, 24);
            label23.TabIndex = 4;
            label23.Text = "AUTHOR ID :";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1014, 701);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Graduate Thesis App";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ErrorProvider errorProvider1;
        private SaveFileDialog saveFileDialog1;
        private PageSetupDialog pageSetupDialog1;
        private Label label23;
        private Label label22;
        private TextBox AuthorIdS;
        private TextBox thesisNoS;
        private DataGridView dataGridView3;
        private Button thesisSearch;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label19;
        private Label label9;
        private TextBox keyword;
        private Button addkeyw;
        private Button addThesis;
        private Label label18;
        private Label label17;
        private Label label21;
        private ComboBox selectLang;
        private Label label15;
        private Label label13;
        private Label label12;
        private DateTimePicker subdatepick;
        private Label label16;
        private Button deleteThesis;
        private Label label14;
        private RadioButton rad4;
        private RadioButton rad3;
        private RadioButton rad2;
        private RadioButton rad1;
        private Label label11;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox pages;
        private TextBox instNameT;
        private TextBox uniNameT;
        private Label label20;
        private TextBox supId;
        private TextBox year;
        private TextBox authorId;
        private TextBox abstrac;
        private TextBox title;
        private TextBox thesisNo;
        private Button deleteKeyw;
        private TextBox cosupId;
        private PictureBox pictureBox3;
        private Button listuni;
        private DataGridView dataGridView1;
        private Button linkinst;
        private Button listp;
        private Button listinst;
        private Button addp;
        private PictureBox pictureBox2;
        private Button deletep;
        private Button deleteinst;
        private TextBox personLName;
        private TextBox instName;
        private TextBox personFName;
        private Button deleteuni;
        private TextBox userId;
        private DataGridView dataGridView2;
        private Button adduni;
        private TextBox uniName;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label label5;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private CheckedListBox subjectL;
        private Button updatep;
        private Button updateinst;
        private Button updateThesis;
    }
}
