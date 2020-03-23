using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NWD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ulong m, n, roznica;
            m = Convert.ToUInt64(textBox1.Text);
            n = Convert.ToUInt64(textBox2.Text);

            do
            {
                roznica = m > n ? m - n : n - m;
                if (n > m)
                    n = roznica;
                else
                    m = roznica;

            }
            while (roznica != 0);

            label3.Text = "NWD dla liczb " + textBox1.Text + " i " + textBox2.Text + " wynosi " + n.ToString();
        }
    }
}
