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
    public partial class Form_city_query : Form
    {
        public Form_city_query()
        {
            InitializeComponent();
        }

        private void Form_city_query_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dblab_phase2_aftercreateEntities db = new dblab_phase2_aftercreateEntities();
            string query = Convert.ToString(richTextBox1.Text);
            var result = db.Cities.SqlQuery(query).ToList<City>(); //LINQ
            dataGridView1.DataSource = result;
        }
    }
}
