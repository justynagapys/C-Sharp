using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiczbaPierwsza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                int liczba = int.Parse(textBox1.Text);
                if (liczba == 2)
                {
                    label1.Text = "Liczba " + liczba + " jest liczbą pierwszą";
                }
                else if (liczba % 2 == 0)
                {
                    label1.Text = "Liczba " + liczba + " nie jest liczbą pierwszą";
                }
                else
                {
                    bool lpierwsza = true;

                    for (int i = 3; i < Math.Sqrt(liczba) + 1; i += 2)
                    {
                        if (liczba % i == 0)
                        {
                            lpierwsza = false;
                            label1.Text = "Liczba " + liczba + " nie jest liczbą pierwszą";
                            break;
                        }
                    }
                    if (lpierwsza)
                    {
                        label1.Text = "Liczba " + liczba + " jest liczbą pierwszą";
                    }

                }
        }
    }
}
