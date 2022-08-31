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
    public partial class Form1_Made_Cars_Function : Form
    {
        public Form1_Made_Cars_Function()
        {
            InitializeComponent();
        }

        private void Form1_Made_Cars_Function_Load(object sender, EventArgs e)
        {
            //panel1.Location = new Point(
            //    this.ClientSize.Width / 2 - panel1.Size.Width / 2,
            //    this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            //panel1.Anchor = AnchorStyles.None;

            //panel2.Location = new Point(
            //    this.ClientSize.Width / 2 - panel1.Size.Width / 2,
            //    this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            //panel2.Anchor = AnchorStyles.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(numericUpDown1.Value.ToString());
            int max = Convert.ToInt32(numericUpDown2.Value.ToString());
            dblab_phase2_aftercreateEntities db = new dblab_phase2_aftercreateEntities();
            dataGridView1.DataSource = db.MilageFilter(min, max);
        }
    }
}
