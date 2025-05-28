using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoEx.Model;

namespace DemoEx
{
    public partial class PartnerUserContorl : UserControl
    {
        private Partner thisPartner;
        private Form1 parent;
        public PartnerUserContorl(Partner partner, Form1 form)
        {
            InitializeComponent();
            thisPartner = partner;
            parent = form;
            label1.Text = partner.Type + " | " + partner.NameCompany;
            label2.Text = partner.Director;
            label3.Text = partner.Phone;
            label4.Text = "Рейтинг:" + partner.Reiting;
            label5.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Вы хотите удалить элемент {parent.CompanyName}", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (MasterFloreDubininContext db = new MasterFloreDubininContext())
                {
                    db.Partners.Remove(thisPartner);
                    db.SaveChanges();
                    parent.UpdateForm();
                }
            }
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            AddEditLos edit = new AddEditLos(thisPartner);
            if (edit.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
