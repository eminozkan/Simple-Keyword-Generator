using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Two_Factor_Authentication
{
    public partial class KeywordGeneratorForm : Form
    {
        public KeywordGeneratorForm()
        {
            InitializeComponent();
            this.Text = "Key Generator";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 7)
            {
                progressBar1.Value++;
            }
            else
            {
                progressBar1.Value = 0;
                KeyGenerator.GenerateKey();
                label1.Text = KeyGenerator.GetKey();
            }
        }

        private void Authenticator_Load(object sender, EventArgs e)
        {
            KeyGenerator.GenerateKey();
            label1.Text = KeyGenerator.GetKey();
        }
    }
}
