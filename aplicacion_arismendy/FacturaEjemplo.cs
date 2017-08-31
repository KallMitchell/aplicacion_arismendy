using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacion_arismendy
{
    public partial class FacturaEjemplo : Form
    {
        private int no = 0;
        public FacturaEjemplo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerarCrista.generarCrystalReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.no++;
            this.dataGridView1.Rows.Add(this.no.ToString(),this.textBox1.Text, this.textBox2.Text, this.textBox3.Text, this.textBox4.Text);
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            /*if (textBox2.Text == "")
            {
                //MessageBox.Show("Cantidad no puede esta vacía");
            }
            else if (textBox3.Text == "")
            {
                //MessageBox.Show("Cantidad no puede esta vacía");
            }
            else {
                double total = (Double.Parse(textBox2.Text) * Double.Parse(textBox3.Text));
                textBox4.Text = total.ToString();
                     
            }*/
            this.MontoTotalProducto();
        }
        public void MontoTotalProducto() {
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                double total = (Double.Parse(textBox2.Text) * Double.Parse(textBox3.Text));
                textBox4.Text = total.ToString();
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            this.MontoTotalProducto();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
