using DemoEx.Model;

namespace DemoEx
{
    public partial class Form1 : Form
    {
        private MasterFloreDubininContext db;
        private List<Partner> list;
        public Form1()
        {
            InitializeComponent();
            db = new MasterFloreDubininContext();
            UpdateForm();
        }
        public void UpdateForm()
        {
            panel1.Controls.Clear();
            list = db.Partners.ToList();
            int y = 0;
            for (int i = 0; i < list.Count; i++)
            {
                PartnerUserContorl pc = new PartnerUserContorl(list[i],this);
                pc.Top = y;
                panel1.Controls.Add(pc);
                y += pc.Height;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEditLos windowLos = new AddEditLos();
            if (windowLos.ShowDialog() == DialogResult.OK)
            {
                Partner partner = new Partner();
                partner.NameCompany = windowLos.textBox1.Text;
                partner.Type = windowLos.comboBox1.SelectedItem!.ToString()!;
                partner.Reiting = (int)windowLos.numericUpDown1.Value;
                partner.UrAddress = windowLos.textBox2.Text;
                partner.Director = windowLos.textBox3.Text;
                partner.Phone = windowLos.textBox4.Text;
                partner.Email = windowLos.textBox5.Text;
                partner.Inn = windowLos.textBox6.Text;
                db.Partners.Add(partner);
                db.SaveChanges();
                UpdateForm();
            }
        }
    }
}