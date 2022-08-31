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
    public partial class Form_SalesDetail : Form
    {
        public Form_SalesDetail()
        {
            InitializeComponent();
        }

        private void Form_SalesDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dblab_phase2_aftercreateDataSet3.SalesDetail' table. You can move, or remove it, as needed.
            this.salesDetailTableAdapter.Fill(this.dblab_phase2_aftercreateDataSet3.SalesDetail);
            panel1.Location = new Point(
                this.ClientSize.Width / 2 - panel1.Size.Width / 2,
                this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;

            dblab_phase2_aftercreateEntities db = new dblab_phase2_aftercreateEntities();
           // dataGridView1.DataSource = db.CarsDetails;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
