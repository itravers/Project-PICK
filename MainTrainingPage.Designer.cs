﻿namespace PICKTrainingInc
{
    partial class MainTrainingPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTrainingPage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.currentUser = new System.Windows.Forms.Label();
            this.allUsers = new System.Windows.Forms.Label();
            this.totalAnswered = new System.Windows.Forms.Label();
            this.totalCorrect = new System.Windows.Forms.Label();
            this.totalWrong = new System.Windows.Forms.Label();
            this.currentUserCorrect = new System.Windows.Forms.Label();
            this.currentUserWrong = new System.Windows.Forms.Label();
            this.currentUserTotal = new System.Windows.Forms.Label();
            this.allUserCorrect = new System.Windows.Forms.Label();
            this.allUserWrong = new System.Windows.Forms.Label();
            this.allUserTotal = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PICKTrainingInc.DataSet1();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pb_question = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_question)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.userOptionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // userOptionsToolStripMenuItem
            // 
            this.userOptionsToolStripMenuItem.Name = "userOptionsToolStripMenuItem";
            this.userOptionsToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.userOptionsToolStripMenuItem.Text = "User Options";
            // 
            // Logo
            // 
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo.InitialImage")));
            this.Logo.Location = new System.Drawing.Point(12, 27);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(93, 85);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(523, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 409);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Your Answer";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(290, 369);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(195, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Alfred Sisley";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(99, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Claude Monet";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(3, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Andy Warhol";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(110, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 75);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Question Statistics";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel2.Controls.Add(this.currentUser, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.allUsers, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.totalAnswered, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.totalCorrect, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.totalWrong, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.currentUserCorrect, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.currentUserWrong, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.currentUserTotal, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.allUserCorrect, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.allUserWrong, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.allUserTotal, 2, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 18);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(374, 52);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // currentUser
            // 
            this.currentUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentUser.AutoSize = true;
            this.currentUser.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUser.Location = new System.Drawing.Point(153, 0);
            this.currentUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentUser.Name = "currentUser";
            this.currentUser.Size = new System.Drawing.Size(77, 13);
            this.currentUser.TabIndex = 3;
            this.currentUser.Text = "Current User";
            // 
            // allUsers
            // 
            this.allUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allUsers.AutoSize = true;
            this.allUsers.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allUsers.Location = new System.Drawing.Point(287, 0);
            this.allUsers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.allUsers.Name = "allUsers";
            this.allUsers.Size = new System.Drawing.Size(56, 13);
            this.allUsers.TabIndex = 2;
            this.allUsers.Text = "All Users";
            // 
            // totalAnswered
            // 
            this.totalAnswered.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.totalAnswered.AutoSize = true;
            this.totalAnswered.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAnswered.Location = new System.Drawing.Point(41, 39);
            this.totalAnswered.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalAnswered.Name = "totalAnswered";
            this.totalAnswered.Size = new System.Drawing.Size(85, 13);
            this.totalAnswered.TabIndex = 1;
            this.totalAnswered.Text = "Total Answered";
            // 
            // totalCorrect
            // 
            this.totalCorrect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.totalCorrect.AutoSize = true;
            this.totalCorrect.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCorrect.Location = new System.Drawing.Point(53, 13);
            this.totalCorrect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalCorrect.Name = "totalCorrect";
            this.totalCorrect.Size = new System.Drawing.Size(73, 13);
            this.totalCorrect.TabIndex = 5;
            this.totalCorrect.Text = "Total Correct";
            // 
            // totalWrong
            // 
            this.totalWrong.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.totalWrong.AutoSize = true;
            this.totalWrong.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalWrong.Location = new System.Drawing.Point(57, 26);
            this.totalWrong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalWrong.Name = "totalWrong";
            this.totalWrong.Size = new System.Drawing.Size(69, 13);
            this.totalWrong.TabIndex = 4;
            this.totalWrong.Text = "Total Wrong";
            // 
            // currentUserCorrect
            // 
            this.currentUserCorrect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentUserCorrect.AutoSize = true;
            this.currentUserCorrect.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserCorrect.Location = new System.Drawing.Point(182, 13);
            this.currentUserCorrect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentUserCorrect.Name = "currentUserCorrect";
            this.currentUserCorrect.Size = new System.Drawing.Size(19, 13);
            this.currentUserCorrect.TabIndex = 6;
            this.currentUserCorrect.Text = "50";
            // 
            // currentUserWrong
            // 
            this.currentUserWrong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentUserWrong.AutoSize = true;
            this.currentUserWrong.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserWrong.Location = new System.Drawing.Point(182, 26);
            this.currentUserWrong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentUserWrong.Name = "currentUserWrong";
            this.currentUserWrong.Size = new System.Drawing.Size(19, 13);
            this.currentUserWrong.TabIndex = 7;
            this.currentUserWrong.Text = "10";
            // 
            // currentUserTotal
            // 
            this.currentUserTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentUserTotal.AutoSize = true;
            this.currentUserTotal.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserTotal.Location = new System.Drawing.Point(182, 39);
            this.currentUserTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentUserTotal.Name = "currentUserTotal";
            this.currentUserTotal.Size = new System.Drawing.Size(19, 13);
            this.currentUserTotal.TabIndex = 8;
            this.currentUserTotal.Text = "60";
            // 
            // allUserCorrect
            // 
            this.allUserCorrect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allUserCorrect.AutoSize = true;
            this.allUserCorrect.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allUserCorrect.Location = new System.Drawing.Point(302, 13);
            this.allUserCorrect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.allUserCorrect.Name = "allUserCorrect";
            this.allUserCorrect.Size = new System.Drawing.Size(25, 13);
            this.allUserCorrect.TabIndex = 9;
            this.allUserCorrect.Text = "100";
            // 
            // allUserWrong
            // 
            this.allUserWrong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allUserWrong.AutoSize = true;
            this.allUserWrong.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allUserWrong.Location = new System.Drawing.Point(305, 26);
            this.allUserWrong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.allUserWrong.Name = "allUserWrong";
            this.allUserWrong.Size = new System.Drawing.Size(19, 13);
            this.allUserWrong.TabIndex = 10;
            this.allUserWrong.Text = "45";
            // 
            // allUserTotal
            // 
            this.allUserTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allUserTotal.AutoSize = true;
            this.allUserTotal.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allUserTotal.Location = new System.Drawing.Point(302, 39);
            this.allUserTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.allUserTotal.Name = "allUserTotal";
            this.allUserTotal.Size = new System.Drawing.Size(25, 13);
            this.allUserTotal.TabIndex = 11;
            this.allUserTotal.Text = "145";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pb_question);
            this.groupBox3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 328);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Question";
            // 
            // pb_question
            // 
            this.pb_question.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_question.Image = ((System.Drawing.Image)(resources.GetObject("pb_question.Image")));
            this.pb_question.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_question.InitialImage")));
            this.pb_question.Location = new System.Drawing.Point(15, 25);
            this.pb_question.Name = "pb_question";
            this.pb_question.Size = new System.Drawing.Size(474, 297);
            this.pb_question.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_question.TabIndex = 4;
            this.pb_question.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 434);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(856, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(143, 17);
            this.toolStripStatusLabel1.Text = "Welcome to Your Training";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_welcome.Location = new System.Drawing.Point(150, 13);
            this.lbl_welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(328, 23);
            this.lbl_welcome.TabIndex = 8;
            this.lbl_welcome.Text = "Test Class Training For Test User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(929, 482);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Project PICK";
            // 
            // MainTrainingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainTrainingPage";
            this.Text = "MainTrainingPage";
            this.Load += new System.EventHandler(this.MainTrainingPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_question)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userOptionsToolStripMenuItem;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pb_question;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label totalWrong;
        private System.Windows.Forms.Label totalAnswered;
        private System.Windows.Forms.Label currentUser;
        private System.Windows.Forms.Label allUsers;
        private System.Windows.Forms.Label totalCorrect;
        private System.Windows.Forms.Label currentUserCorrect;
        private System.Windows.Forms.Label currentUserWrong;
        private System.Windows.Forms.Label currentUserTotal;
        private System.Windows.Forms.Label allUserCorrect;
        private System.Windows.Forms.Label allUserWrong;
        private System.Windows.Forms.Label allUserTotal;
    }
}