namespace A3DIcons.FontEnumGenerator
{
    partial class FrmEnumGenerator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.RdbGenrateFromSvg = new System.Windows.Forms.RadioButton();
            this.RdbGenrateFromCss = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnClose = new A3DFontAwesome.IconButton();
            this.BtnGenrate = new A3DFontAwesome.IconButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtCssFileName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnOpenCssFile = new A3DFontAwesome.IconButton();
            this.TxtFileNameSpace = new System.Windows.Forms.TextBox();
            this.TxtMatchingPattern = new System.Windows.Forms.TextBox();
            this.TxtSelectCssClass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIconCodeMatching = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnOpenSvgFileSource = new A3DFontAwesome.IconButton();
            this.TxtSvgFileNameSpace = new System.Windows.Forms.TextBox();
            this.TxtIconNameMatching = new System.Windows.Forms.TextBox();
            this.TxtSelectSvgSourceFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtIconTableName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtIconClassName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.LblMessage = new System.Windows.Forms.Label();
            this.TxtFileName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RdbGenrateFromSvg);
            this.panel1.Controls.Add(this.RdbGenrateFromCss);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 49);
            this.panel1.TabIndex = 0;
            // 
            // RdbGenrateFromSvg
            // 
            this.RdbGenrateFromSvg.AutoSize = true;
            this.RdbGenrateFromSvg.Location = new System.Drawing.Point(413, 26);
            this.RdbGenrateFromSvg.Name = "RdbGenrateFromSvg";
            this.RdbGenrateFromSvg.Size = new System.Drawing.Size(114, 17);
            this.RdbGenrateFromSvg.TabIndex = 1;
            this.RdbGenrateFromSvg.Text = " Genrate From Svg";
            this.RdbGenrateFromSvg.UseVisualStyleBackColor = true;
            this.RdbGenrateFromSvg.CheckedChanged += new System.EventHandler(this.RdbGenrateFromCss_CheckedChanged);
            // 
            // RdbGenrateFromCss
            // 
            this.RdbGenrateFromCss.AutoSize = true;
            this.RdbGenrateFromCss.Location = new System.Drawing.Point(96, 26);
            this.RdbGenrateFromCss.Name = "RdbGenrateFromCss";
            this.RdbGenrateFromCss.Size = new System.Drawing.Size(132, 17);
            this.RdbGenrateFromCss.TabIndex = 0;
            this.RdbGenrateFromCss.Text = "Genrate From CSS File";
            this.RdbGenrateFromCss.UseVisualStyleBackColor = true;
            this.RdbGenrateFromCss.CheckedChanged += new System.EventHandler(this.RdbGenrateFromCss_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LblMessage);
            this.panel2.Controls.Add(this.BtnClose);
            this.panel2.Controls.Add(this.BtnGenrate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 354);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 36);
            this.panel2.TabIndex = 1;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(63)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.IconChar = A3DFontAwesome.IconChar.SignOutAlt;
            this.BtnClose.IconColor = System.Drawing.Color.White;
            this.BtnClose.IconFont = A3DFontAwesome.IconFont.Auto;
            this.BtnClose.IconSize = 24;
            this.BtnClose.Location = new System.Drawing.Point(756, 2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(88, 32);
            this.BtnClose.TabIndex = 8;
            this.BtnClose.Text = "Close";
            this.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnGenrate
            // 
            this.BtnGenrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGenrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(42)))), ((int)(((byte)(165)))));
            this.BtnGenrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenrate.ForeColor = System.Drawing.Color.White;
            this.BtnGenrate.IconChar = A3DFontAwesome.IconChar.Cog;
            this.BtnGenrate.IconColor = System.Drawing.Color.White;
            this.BtnGenrate.IconFont = A3DFontAwesome.IconFont.Auto;
            this.BtnGenrate.IconSize = 24;
            this.BtnGenrate.Location = new System.Drawing.Point(664, 2);
            this.BtnGenrate.Name = "BtnGenrate";
            this.BtnGenrate.Size = new System.Drawing.Size(88, 32);
            this.BtnGenrate.TabIndex = 7;
            this.BtnGenrate.Text = "Generat";
            this.BtnGenrate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGenrate.UseVisualStyleBackColor = false;
            this.BtnGenrate.Click += new System.EventHandler(this.BtnGenrate_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.TxtCssFileName);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.BtnOpenCssFile);
            this.splitContainer1.Panel1.Controls.Add(this.TxtFileNameSpace);
            this.splitContainer1.Panel1.Controls.Add(this.TxtMatchingPattern);
            this.splitContainer1.Panel1.Controls.Add(this.TxtSelectCssClass);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TxtFileName);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.TxtIconClassName);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.TxtIconTableName);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.TxtIconCodeMatching);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.BtnOpenSvgFileSource);
            this.splitContainer1.Panel2.Controls.Add(this.TxtSvgFileNameSpace);
            this.splitContainer1.Panel2.Controls.Add(this.TxtIconNameMatching);
            this.splitContainer1.Panel2.Controls.Add(this.TxtSelectSvgSourceFile);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Size = new System.Drawing.Size(847, 305);
            this.splitContainer1.SplitterDistance = 411;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Matching Pattern Suggenstion";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(163, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "\\.fa.(.+):before";
            // 
            // TxtCssFileName
            // 
            this.TxtCssFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCssFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCssFileName.Location = new System.Drawing.Point(163, 141);
            this.TxtCssFileName.Name = "TxtCssFileName";
            this.TxtCssFileName.Size = new System.Drawing.Size(120, 20);
            this.TxtCssFileName.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "File Name";
            // 
            // BtnOpenCssFile
            // 
            this.BtnOpenCssFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOpenCssFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpenCssFile.IconChar = A3DFontAwesome.IconChar.FolderOpen;
            this.BtnOpenCssFile.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(81)))), ((int)(((byte)(97)))));
            this.BtnOpenCssFile.IconFont = A3DFontAwesome.IconFont.Auto;
            this.BtnOpenCssFile.IconSize = 24;
            this.BtnOpenCssFile.Location = new System.Drawing.Point(287, 35);
            this.BtnOpenCssFile.Name = "BtnOpenCssFile";
            this.BtnOpenCssFile.Size = new System.Drawing.Size(40, 23);
            this.BtnOpenCssFile.TabIndex = 6;
            this.BtnOpenCssFile.UseVisualStyleBackColor = true;
            this.BtnOpenCssFile.Click += new System.EventHandler(this.BtnOpenCssFile_Click);
            // 
            // TxtFileNameSpace
            // 
            this.TxtFileNameSpace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFileNameSpace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFileNameSpace.Location = new System.Drawing.Point(163, 115);
            this.TxtFileNameSpace.Name = "TxtFileNameSpace";
            this.TxtFileNameSpace.Size = new System.Drawing.Size(120, 20);
            this.TxtFileNameSpace.TabIndex = 5;
            // 
            // TxtMatchingPattern
            // 
            this.TxtMatchingPattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMatchingPattern.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMatchingPattern.Location = new System.Drawing.Point(163, 63);
            this.TxtMatchingPattern.Name = "TxtMatchingPattern";
            this.TxtMatchingPattern.Size = new System.Drawing.Size(120, 20);
            this.TxtMatchingPattern.TabIndex = 4;
            // 
            // TxtSelectCssClass
            // 
            this.TxtSelectCssClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSelectCssClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSelectCssClass.Location = new System.Drawing.Point(163, 35);
            this.TxtSelectCssClass.Name = "TxtSelectCssClass";
            this.TxtSelectCssClass.Size = new System.Drawing.Size(120, 20);
            this.TxtSelectCssClass.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "File NameSpace";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matching Pattern";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select CSS File";
            // 
            // TxtIconCodeMatching
            // 
            this.TxtIconCodeMatching.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtIconCodeMatching.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtIconCodeMatching.Location = new System.Drawing.Point(150, 119);
            this.TxtIconCodeMatching.Name = "TxtIconCodeMatching";
            this.TxtIconCodeMatching.Size = new System.Drawing.Size(188, 20);
            this.TxtIconCodeMatching.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Icon Code Column Name";
            // 
            // BtnOpenSvgFileSource
            // 
            this.BtnOpenSvgFileSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOpenSvgFileSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpenSvgFileSource.IconChar = A3DFontAwesome.IconChar.FolderOpen;
            this.BtnOpenSvgFileSource.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(81)))), ((int)(((byte)(97)))));
            this.BtnOpenSvgFileSource.IconFont = A3DFontAwesome.IconFont.Auto;
            this.BtnOpenSvgFileSource.IconSize = 24;
            this.BtnOpenSvgFileSource.Location = new System.Drawing.Point(343, 34);
            this.BtnOpenSvgFileSource.Name = "BtnOpenSvgFileSource";
            this.BtnOpenSvgFileSource.Size = new System.Drawing.Size(40, 23);
            this.BtnOpenSvgFileSource.TabIndex = 13;
            this.BtnOpenSvgFileSource.UseVisualStyleBackColor = true;
            this.BtnOpenSvgFileSource.Click += new System.EventHandler(this.BtnOpenSvgFileSource_Click);
            // 
            // TxtSvgFileNameSpace
            // 
            this.TxtSvgFileNameSpace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSvgFileNameSpace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSvgFileNameSpace.Location = new System.Drawing.Point(150, 171);
            this.TxtSvgFileNameSpace.Name = "TxtSvgFileNameSpace";
            this.TxtSvgFileNameSpace.Size = new System.Drawing.Size(188, 20);
            this.TxtSvgFileNameSpace.TabIndex = 12;
            // 
            // TxtIconNameMatching
            // 
            this.TxtIconNameMatching.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtIconNameMatching.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtIconNameMatching.Location = new System.Drawing.Point(150, 62);
            this.TxtIconNameMatching.Name = "TxtIconNameMatching";
            this.TxtIconNameMatching.Size = new System.Drawing.Size(188, 20);
            this.TxtIconNameMatching.TabIndex = 11;
            // 
            // TxtSelectSvgSourceFile
            // 
            this.TxtSelectSvgSourceFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSelectSvgSourceFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSelectSvgSourceFile.Location = new System.Drawing.Point(150, 34);
            this.TxtSelectSvgSourceFile.Name = "TxtSelectSvgSourceFile";
            this.TxtSelectSvgSourceFile.Size = new System.Drawing.Size(188, 20);
            this.TxtSelectSvgSourceFile.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "File NameSpace";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Icon Name Matching";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Select Svg Xml File";
            // 
            // TxtIconTableName
            // 
            this.TxtIconTableName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtIconTableName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtIconTableName.Location = new System.Drawing.Point(150, 88);
            this.TxtIconTableName.Name = "TxtIconTableName";
            this.TxtIconTableName.Size = new System.Drawing.Size(188, 20);
            this.TxtIconTableName.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Table Name";
            // 
            // TxtIconClassName
            // 
            this.TxtIconClassName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtIconClassName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtIconClassName.Location = new System.Drawing.Point(150, 145);
            this.TxtIconClassName.Name = "TxtIconClassName";
            this.TxtIconClassName.Size = new System.Drawing.Size(188, 20);
            this.TxtIconClassName.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Icon Class Column Name";
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.ForeColor = System.Drawing.Color.Red;
            this.LblMessage.Location = new System.Drawing.Point(12, 9);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(15, 16);
            this.LblMessage.TabIndex = 9;
            this.LblMessage.Text = "..";
            // 
            // TxtFileName
            // 
            this.TxtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFileName.Location = new System.Drawing.Point(150, 197);
            this.TxtFileName.Name = "TxtFileName";
            this.TxtFileName.Size = new System.Drawing.Size(188, 20);
            this.TxtFileName.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "File Name";
            // 
            // FrmEnumGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(847, 390);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmEnumGenerator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmEnumGenerator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private SplitContainer splitContainer1;
        private TextBox TxtFileNameSpace;
        private TextBox TxtMatchingPattern;
        private TextBox TxtSelectCssClass;
        private Label label3;
        private Label label2;
        private Label label1;
        private A3DFontAwesome.IconButton BtnOpenCssFile;
        private TextBox TxtIconCodeMatching;
        private Label label7;
        private A3DFontAwesome.IconButton BtnOpenSvgFileSource;
        private TextBox TxtSvgFileNameSpace;
        private TextBox TxtIconNameMatching;
        private TextBox TxtSelectSvgSourceFile;
        private Label label4;
        private Label label5;
        private Label label6;
        private A3DFontAwesome.IconButton BtnClose;
        private A3DFontAwesome.IconButton BtnGenrate;
        private TextBox TxtCssFileName;
        private Label label8;
        private RadioButton RdbGenrateFromSvg;
        private RadioButton RdbGenrateFromCss;
        private Label label9;
        private TextBox textBox1;
        private TextBox TxtIconTableName;
        private Label label10;
        private TextBox TxtIconClassName;
        private Label label11;
        private Label LblMessage;
        private TextBox TxtFileName;
        private Label label12;
    }
}