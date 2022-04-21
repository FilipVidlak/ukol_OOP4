using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol_OOP4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Produkt produkt;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                produkt = new Produkt(textBox1.Text, int.Parse(textBox2.Text), dateTimePicker1.Value, int.Parse(textBox3.Text), checkBox1.Checked);
                if (checkBox1.Checked == false)
                {
                    MessageBox.Show("Nelze zlevnit produkt");
                }
                else
                {
                    MessageBox.Show("Lze zlevnit produkt i přes to, že nemusí být prošlý", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                MessageBox.Show("Produkt byl úspěšně vytvořen!", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button2.Enabled = true;
            } catch
            {
                MessageBox.Show("Zadal jsi špatnou nebo žádnou hodnotu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = produkt.ToString();
        }
    }
}
