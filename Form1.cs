using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextReverser2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StringBuilder input = new StringBuilder();
        StringBuilder output = new StringBuilder();
        bool ready;
        string Qexp = "";
        
        public void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opentext = new OpenFileDialog();
            //opentext.InitialDirectory = %UserProfile%;
            opentext.Filter = "Text Files (*.txt)|*.txt|All files(*.*)|*.*";
            opentext.FilterIndex = 1;
            bool open = (opentext.ShowDialog() == DialogResult.OK);
            string path = opentext.FileName;
            if (open)
            {
                using (StreamReader inputstream = new StreamReader(path))
                {

                    string temp = inputstream.ReadToEnd();
                    input.Append(temp);
                    inputText.Text = temp;
                    ready = true;
                }
            }
        }

        public void quickexp(object sender, System.EventArgs e)
        {
            MessageBox.Show(Qexp);
        }
        public void quickie(object sender, System.EventArgs e)
        {
            input.Clear();
            output.Clear();
            IDataObject txt = Clipboard.GetDataObject();
            if (txt.GetDataPresent(DataFormats.Text))
                input.Append((string)txt.GetData(DataFormats.Text));
            reverse();
            Clipboard.SetDataObject(output.ToString());
            input.Clear();
            output.Clear();
        }
        public void savefile(object sender, System.EventArgs e)
        {
            SaveFileDialog savetext = new SaveFileDialog();
            savetext.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            savetext.FilterIndex = 1;
            savetext.RestoreDirectory = true;
            bool open = (savetext.ShowDialog() == DialogResult.OK);
            string path = savetext.FileName;
            if (open)
            {
                using (StreamWriter outputstream = new StreamWriter(path))
                {
                    outputstream.WriteLine(output.ToString());
                }
            }
        }
        public void reverse()
        {


            outputText.Clear();
            output.Clear();
            int leng = input.Length;
            int counter = 0;
            int anticounter = leng - 1;
            bool ok = true;
            while (ok)
            {
                output.Append(input[anticounter]);
                counter++;
                anticounter--;
                if (counter >= leng)
                {
                    ok = false;
                   
                }
            }
        }
        public void revfile(object sender, System.EventArgs e)
        {


            
            if (ready && inputText.TextLength != 0)
            {
                reverse();
                outputText.Text = output.ToString();
            }
            else if (inputText.TextLength != 0)
            {
                input.Clear();
                input.Append(inputText.Text);
                reverse();
                outputText.Text = output.ToString();
            }

        }
        public void reset(object sender, System.EventArgs e)
        {
            output.Clear();
            input.Clear();
            outputText.Clear();
            inputText.Clear();
            ready = false;
            if (inputText.TextLength != 0)
                ready = true;
        }
        public void copy(object sender, System.EventArgs e)
        {
            outputText.SelectAll();
            outputText.Copy();
        }
        public void paste(object sender, System.EventArgs e)
        {
            inputText.SelectAll();
            inputText.Paste();
        }

        public void opensite(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }
        public void chlay(object sender, EventArgs e)
        {
            
            
            if (rtlfalse.Checked == false && rtltrue.Checked == true)
            {
                inputText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                outputText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            }
            else if (rtlfalse.Checked == true && rtltrue.Checked == false)
            {
                inputText.RightToLeft = System.Windows.Forms.RightToLeft.No;
                outputText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            }
        }
       
    }
}
