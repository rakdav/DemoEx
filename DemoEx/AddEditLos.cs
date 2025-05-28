using DemoEx.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEx
{
    public partial class AddEditLos : Form
    {
        public AddEditLos()
        {
            InitializeComponent();
        }
        public AddEditLos(Partner partner)
        {
            InitializeComponent();
            textBox1.Text = partner.NameCompany;
            comboBox1.Text = partner.Type;
            numericUpDown1.Value = partner.Reiting;
            textBox2.Text = partner.UrAddress;
            textBox3.Text = partner.Director;
            textBox4.Text = partner.Phone;
            textBox5.Text = partner.Email;
            textBox6.Text = partner.Inn;
        }
    }
}
