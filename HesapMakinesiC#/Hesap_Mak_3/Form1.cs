namespace Hesap_Mak_3
{
    public partial class Form1 : Form
    {
        double x, y;
        string sonuc;
        public Form1()
        {
            InitializeComponent();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }

                
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            sonuc = "-";
            label1.Text = textBox1.Text + "-";
            textBox1.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            sonuc = "*";
            label1.Text = textBox1.Text + "*";
            textBox1.Text = "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            sonuc = "/";
            label1.Text = textBox1.Text + "/";
            textBox1.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            sonuc = "%";
            label1.Text = textBox1.Text + "%";
            textBox1.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double karekok =Convert.ToDouble(textBox1.Text);
            karekok = Math.Sqrt(karekok);
            textBox1.Text = Convert.ToString(karekok);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(-1 * Convert.ToDouble(textBox1.Text));
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                toplam += Convert.ToDouble(listBox1.Items[i]);
            }

            textBox1.Text = Convert.ToString(toplam);
            listBox1.Items.Clear();

        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(",") <1)
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(textBox1.Text);

            if (sonuc=="+")
            {
                label1.Text += textBox1.Text;
                textBox1.Text = Convert.ToString(x + y);
                label1.Text += "=" + textBox1.Text; 
            }
            if (sonuc == "-")
            {
                label1.Text += textBox1.Text;
                textBox1.Text = Convert.ToString(x - y);
                label1.Text += "=" + textBox1.Text;
            }
            if (sonuc == "*")
            {
                label1.Text += textBox1.Text;
                textBox1.Text = Convert.ToString(x * y);
                label1.Text += "=" + textBox1.Text;
            }
            if (sonuc == "/")
            {
                label1.Text += textBox1.Text;
                textBox1.Text = Convert.ToString(x / y);
                label1.Text += "=" + textBox1.Text;
            }
            if (sonuc == "%")
            {
                label1.Text += textBox1.Text;
                textBox1.Text = Convert.ToString((x * y) /100);
                label1.Text += "=" + textBox1.Text;
            }



        }

        private void button20_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            sonuc = "+";
            label1.Text = textBox1.Text + "+";
            textBox1.Text = "0";
        }
    }
}