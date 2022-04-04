using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wordCount {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e) {
            
        }

        private void txtBox_TextChanged(object sender, EventArgs e) {
            int wordCount = 0, index = 0;
            string text = txtBox.Text;

            // skip whitespace until first word
            while (index < text.Length && char.IsWhiteSpace(text[index]))
                index++;

            while (index < text.Length) {
                // check if current char is part of a word
                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                    index++;

                wordCount++;

                // skip whitespace until next word
                while (index < text.Length && char.IsWhiteSpace(text[index]))
                    index++;
            }


            rWord.Text = wordCount.ToString();
            rChar.Text = text.Length.ToString();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
