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
    public partial class Form_person : Form
    {
        public Form_person()
        {
            InitializeComponent();
        }

        private void Form_person_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dblab_phase2_aftercreateDataSet2.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.dblab_phase2_aftercreateDataSet2.Person);

            panel1.Location = new Point(
                this.ClientSize.Width / 2 - panel1.Size.Width / 2,
                this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;

        }
    }
}
