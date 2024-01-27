using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kayıtAlma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label12.Text = txtAdSoyad.Text;
            label10.Text = txtTelefonNo.Text;
            label11.Text = txtAdres.Text;
            label9.Text = comboBoxSemt.Text;
            label15.Text = comboBoxSehir.Text;
        }
    }
}
