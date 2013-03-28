namespace TextReverser2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFile = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.TextBox();
            this.rev = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.reseter = new System.Windows.Forms.Button();
            this.paster = new System.Windows.Forms.Button();
            this.copier = new System.Windows.Forms.Button();
            this.rtlfalse = new System.Windows.Forms.RadioButton();
            this.rtltrue = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(389, 12);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(75, 23);
            this.openFile.TabIndex = 0;
            this.openFile.Text = "&Open File";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(389, 77);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(75, 23);
            this.saveFile.TabIndex = 1;
            this.saveFile.Text = "&Save File";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.savefile);
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(12, 25);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(371, 20);
            this.inputText.TabIndex = 2;
            // 
            // rev
            // 
            this.rev.Location = new System.Drawing.Point(106, 51);
            this.rev.Name = "rev";
            this.rev.Size = new System.Drawing.Size(75, 23);
            this.rev.TabIndex = 3;
            this.rev.Text = "&Reverse";
            this.rev.UseVisualStyleBackColor = true;
            this.rev.Click += new System.EventHandler(this.revfile);
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(15, 93);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(371, 20);
            this.outputText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "© Peterooch Projector";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Input text that you wish to reverse:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Reversed output text:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(131, 116);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(119, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://peterooch.zzl.org";
            this.linkLabel1.Click += new System.EventHandler(this.opensite);
            // 
            // reseter
            // 
            this.reseter.Location = new System.Drawing.Point(187, 51);
            this.reseter.Name = "reseter";
            this.reseter.Size = new System.Drawing.Size(75, 23);
            this.reseter.TabIndex = 10;
            this.reseter.Text = "R&eset";
            this.reseter.UseVisualStyleBackColor = true;
            this.reseter.Click += new System.EventHandler(this.reset);
            // 
            // paster
            // 
            this.paster.Location = new System.Drawing.Point(389, 41);
            this.paster.Name = "paster";
            this.paster.Size = new System.Drawing.Size(75, 23);
            this.paster.TabIndex = 11;
            this.paster.Text = "&Paste";
            this.paster.UseVisualStyleBackColor = true;
            this.paster.Click += new System.EventHandler(this.paste);
            // 
            // copier
            // 
            this.copier.Location = new System.Drawing.Point(389, 106);
            this.copier.Name = "copier";
            this.copier.Size = new System.Drawing.Size(75, 23);
            this.copier.TabIndex = 12;
            this.copier.Text = "&Copy";
            this.copier.UseVisualStyleBackColor = true;
            this.copier.Click += new System.EventHandler(this.copy);
            // 
            // rtlfalse
            // 
            this.rtlfalse.AutoSize = true;
            this.rtlfalse.Location = new System.Drawing.Point(187, 7);
            this.rtlfalse.Name = "rtlfalse";
            this.rtlfalse.Size = new System.Drawing.Size(78, 17);
            this.rtlfalse.TabIndex = 13;
            this.rtlfalse.TabStop = true;
            this.rtlfalse.Text = "Left to right";
            this.rtlfalse.UseVisualStyleBackColor = true;
            this.rtlfalse.CheckedChanged += new System.EventHandler(this.chlay);
            // 
            // rtltrue
            // 
            this.rtltrue.AutoSize = true;
            this.rtltrue.Location = new System.Drawing.Point(271, 7);
            this.rtltrue.Name = "rtltrue";
            this.rtltrue.Size = new System.Drawing.Size(79, 17);
            this.rtltrue.TabIndex = 14;
            this.rtltrue.TabStop = true;
            this.rtltrue.Text = "Right to left";
            this.rtltrue.UseVisualStyleBackColor = true;
            this.rtltrue.CheckedChanged += new System.EventHandler(this.chlay);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 133);
            this.Controls.Add(this.rtltrue);
            this.Controls.Add(this.rtlfalse);
            this.Controls.Add(this.copier);
            this.Controls.Add(this.paster);
            this.Controls.Add(this.reseter);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.rev);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.openFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Text Reverser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Button rev;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button reseter;
        private System.Windows.Forms.Button paster;
        private System.Windows.Forms.Button copier;
        private System.Windows.Forms.RadioButton rtlfalse;
        private System.Windows.Forms.RadioButton rtltrue;
    }
}

