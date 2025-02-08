using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace LayeredArchitecture
{
    public partial class Architecture : Form
    {
        public Architecture()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> perList = LogicPersonel.Lists();
            dataGridView1.DataSource = perList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EntityPersonel ent =new EntityPersonel();
            ent.Id = int .Parse(textBox1.Text);
            ent.Name = textBox2.Text;
            ent.LastName = textBox3.Text;
            ent.Task = textBox4.Text;
            ent.City = textBox5.Text;
            ent.Salary= int.Parse(textBox6.Text);
            LogicPersonel.ListPersonelAdd(ent); 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();  
            ent.Id =Convert.ToInt32(textBox1.Text);
            LogicPersonel.RemoveProcess(ent.Id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = int.Parse(textBox1.Text);
            ent.Name = textBox2.Text;
            ent.LastName = textBox3.Text;
            ent.Task = textBox4.Text;
            ent.City = textBox5.Text;
            ent.Salary = int.Parse(textBox6.Text);
            LogicPersonel.UpPersonel(ent);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
