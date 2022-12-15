using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol9Zamestanec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Zamestnanec pracant;
        Vedouci vedoucipracant;

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                pracant = new Zamestnanec(textBox1.Text, textBox2.Text, dateTimePicker1.Value, (int)numericUpDown1.Value);
                pracant.OdpracujHodiny((int)numericUpDown2.Value);
            }
            if (radioButton2.Checked)
            {
                vedoucipracant = new Vedouci(textBox1.Text, textBox2.Text, dateTimePicker1.Value, (int)numericUpDown1.Value,100,"Mudr.");
                vedoucipracant.OdpracujHodiny((int)numericUpDown2.Value);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show(pracant.Vypis());
            }
            if (radioButton2.Checked)
            {
                MessageBox.Show(vedoucipracant.Vypis());
            }
        }
    }
}
