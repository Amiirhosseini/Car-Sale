
namespace DB_Lab_phase3
{
    partial class Form_vehicle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chassisTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryOfProductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfProductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dblab_phase2_aftercreateDataSet1 = new DB_Lab_phase3.dblab_phase2_aftercreateDataSet1();
            this.carsDetailTableAdapter = new DB_Lab_phase3.dblab_phase2_aftercreateDataSet1TableAdapters.CarsDetailTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblab_phase2_aftercreateDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1375, 426);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manufacturerDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.chassisTypeDataGridViewTextBoxColumn,
            this.countryOfProductionDataGridViewTextBoxColumn,
            this.yearOfProductionDataGridViewTextBoxColumn,
            this.milageDataGridViewTextBoxColumn,
            this.fuelTypeDataGridViewTextBoxColumn,
            this.colorNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carsDetailBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1355, 422);
            this.dataGridView1.TabIndex = 0;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // chassisTypeDataGridViewTextBoxColumn
            // 
            this.chassisTypeDataGridViewTextBoxColumn.DataPropertyName = "ChassisType";
            this.chassisTypeDataGridViewTextBoxColumn.HeaderText = "ChassisType";
            this.chassisTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chassisTypeDataGridViewTextBoxColumn.Name = "chassisTypeDataGridViewTextBoxColumn";
            this.chassisTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // countryOfProductionDataGridViewTextBoxColumn
            // 
            this.countryOfProductionDataGridViewTextBoxColumn.DataPropertyName = "CountryOfProduction";
            this.countryOfProductionDataGridViewTextBoxColumn.HeaderText = "CountryOfProduction";
            this.countryOfProductionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countryOfProductionDataGridViewTextBoxColumn.Name = "countryOfProductionDataGridViewTextBoxColumn";
            this.countryOfProductionDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearOfProductionDataGridViewTextBoxColumn
            // 
            this.yearOfProductionDataGridViewTextBoxColumn.DataPropertyName = "YearOfProduction";
            this.yearOfProductionDataGridViewTextBoxColumn.HeaderText = "YearOfProduction";
            this.yearOfProductionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearOfProductionDataGridViewTextBoxColumn.Name = "yearOfProductionDataGridViewTextBoxColumn";
            this.yearOfProductionDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearOfProductionDataGridViewTextBoxColumn.Width = 125;
            // 
            // milageDataGridViewTextBoxColumn
            // 
            this.milageDataGridViewTextBoxColumn.DataPropertyName = "Milage";
            this.milageDataGridViewTextBoxColumn.HeaderText = "Milage";
            this.milageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.milageDataGridViewTextBoxColumn.Name = "milageDataGridViewTextBoxColumn";
            this.milageDataGridViewTextBoxColumn.Width = 125;
            // 
            // fuelTypeDataGridViewTextBoxColumn
            // 
            this.fuelTypeDataGridViewTextBoxColumn.DataPropertyName = "FuelType";
            this.fuelTypeDataGridViewTextBoxColumn.HeaderText = "FuelType";
            this.fuelTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fuelTypeDataGridViewTextBoxColumn.Name = "fuelTypeDataGridViewTextBoxColumn";
            this.fuelTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // colorNameDataGridViewTextBoxColumn
            // 
            this.colorNameDataGridViewTextBoxColumn.DataPropertyName = "ColorName";
            this.colorNameDataGridViewTextBoxColumn.HeaderText = "ColorName";
            this.colorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.colorNameDataGridViewTextBoxColumn.Name = "colorNameDataGridViewTextBoxColumn";
            this.colorNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // carsDetailBindingSource
            // 
            this.carsDetailBindingSource.DataMember = "CarsDetail";
            this.carsDetailBindingSource.DataSource = this.dblab_phase2_aftercreateDataSet1;
            // 
            // dblab_phase2_aftercreateDataSet1
            // 
            this.dblab_phase2_aftercreateDataSet1.DataSetName = "dblab_phase2_aftercreateDataSet1";
            this.dblab_phase2_aftercreateDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsDetailTableAdapter
            // 
            this.carsDetailTableAdapter.ClearBeforeFill = true;
            // 
            // Form_vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form_vehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_vehicle";
            this.Load += new System.EventHandler(this.Form_vehicle_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblab_phase2_aftercreateDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dblab_phase2_aftercreateDataSet1 dblab_phase2_aftercreateDataSet1;
        private System.Windows.Forms.BindingSource carsDetailBindingSource;
        private dblab_phase2_aftercreateDataSet1TableAdapters.CarsDetailTableAdapter carsDetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chassisTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryOfProductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfProductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn milageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorNameDataGridViewTextBoxColumn;
    }
}