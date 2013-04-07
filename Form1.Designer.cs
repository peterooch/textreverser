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
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // openFile
            // 
            resources.ApplyResources(this.openFile, "openFile");
            this.openFile.Name = "openFile";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFile
            // 
            resources.ApplyResources(this.saveFile, "saveFile");
            this.saveFile.Name = "saveFile";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.savefile);
            // 
            // inputText
            // 
            resources.ApplyResources(this.inputText, "inputText");
            this.inputText.Name = "inputText";
            // 
            // rev
            // 
            resources.ApplyResources(this.rev, "rev");
            this.rev.Name = "rev";
            this.rev.UseVisualStyleBackColor = true;
            this.rev.Click += new System.EventHandler(this.revfile);
            // 
            // outputText
            // 
            resources.ApplyResources(this.outputText, "outputText");
            this.outputText.Name = "outputText";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Click += new System.EventHandler(this.opensite);
            // 
            // reseter
            // 
            resources.ApplyResources(this.reseter, "reseter");
            this.reseter.Name = "reseter";
            this.reseter.UseVisualStyleBackColor = true;
            this.reseter.Click += new System.EventHandler(this.reset);
            // 
            // paster
            // 
            resources.ApplyResources(this.paster, "paster");
            this.paster.Name = "paster";
            this.paster.UseVisualStyleBackColor = true;
            this.paster.Click += new System.EventHandler(this.paste);
            // 
            // copier
            // 
            resources.ApplyResources(this.copier, "copier");
            this.copier.Name = "copier";
            this.copier.UseVisualStyleBackColor = true;
            this.copier.Click += new System.EventHandler(this.copy);
            // 
            // rtlfalse
            // 
            resources.ApplyResources(this.rtlfalse, "rtlfalse");
            this.rtlfalse.Name = "rtlfalse";
            this.rtlfalse.TabStop = true;
            this.rtlfalse.UseVisualStyleBackColor = true;
            this.rtlfalse.CheckedChanged += new System.EventHandler(this.chlay);
            // 
            // rtltrue
            // 
            resources.ApplyResources(this.rtltrue, "rtltrue");
            this.rtltrue.Name = "rtltrue";
            this.rtltrue.TabStop = true;
            this.rtltrue.UseVisualStyleBackColor = true;
            this.rtltrue.CheckedChanged += new System.EventHandler(this.chlay);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.quickie);
            // 
            // linkLabel2
            // 
            resources.ApplyResources(this.linkLabel2, "linkLabel2");
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Click += new System.EventHandler(this.quickexp);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.button1);
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
            this.Name = "Form1";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

