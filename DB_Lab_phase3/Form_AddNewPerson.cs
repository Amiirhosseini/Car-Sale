using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Lab_phase3
{
    public partial class Form_AddNewPerson : Form
    {
        public Form_AddNewPerson()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dblab_phase2_aftercreateEntities db = new dblab_phase2_aftercreateEntities();
            int flag=db.AddNewPerson(textBox1.Text.ToString(), Convert.ToInt32(textBox2.Text.ToString()),
                textBox3.Text.ToString(),
                textBox4.Text.ToString(), textBox5.Text.ToString(), textBox6.Text.ToString(),
                textBox7.Text.ToString(), textBox8.Text.ToString(), textBox9.Text.ToString());

            if (flag == 1)
            {
                MessageBox.Show("person added!");
            }
            else
            {
                MessageBox.Show("error in inputs or connection");
            }

        }

        private void Form_AddNewPerson_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(
                this.ClientSize.Width / 2 - panel1.Size.Width / 2,
                this.ClientSize.Height / 2 - panel1.Size.Height / 2);
        }
    }
}
