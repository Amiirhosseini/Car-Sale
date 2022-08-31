using System;
using System.Drawing;
using System.Windows.Forms;

namespace DB_Lab_phase3
{
    public partial class Form_start : Form
    {
        public Form_start()
        {
            InitializeComponent();
        }

        private void button_city_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formCity = new Form_city();
            formCity.Closed += (s, args) => this.Show();
            formCity.Show();
        }

        private void button_vehicle_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formCity = new Form_vehicle();
            formCity.Closed += (s, args) => this.Show();
            formCity.Show();
        }

        private void button_person_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formCity = new Form_person();
            formCity.Closed += (s, args) => this.Show();
            formCity.Show();
        }

        private void button_Made_Cars_Function_Click(object sender, EventArgs e)
        {

            this.Hide();
            var formCity = new Form1_Made_Cars_Function();
            formCity.Closed += (s, args) => this.Show();
            formCity.Show();
        }

        private void button_SalesDetail_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formCity = new Form_SalesDetail();
            formCity.Closed += (s, args) => this.Show();
            formCity.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formCity = new Form_AddNewPerson();
            formCity.Closed += (s, args) => this.Show();
            formCity.Show();
        }

        private void button_city_query_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formCity = new Form_city_query();
            formCity.Closed += (s, args) => this.Show();
            formCity.Show();
        }

        private void button_vehicle_query_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formCity = new Form_vehicle_query();
            formCity.Closed += (s, args) => this.Show();
            formCity.Show();
        }

        private void button_person_query_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formCity = new Form_person_query();
            formCity.Closed += (s, args) => this.Show();
            formCity.Show();
        }

        private void Form_start_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(
                this.ClientSize.Width / 2 - panel1.Size.Width / 2,
                this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
        }
    }
}
