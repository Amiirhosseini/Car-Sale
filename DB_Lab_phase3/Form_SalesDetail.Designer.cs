
namespace DB_Lab_phase3
{
    partial class Form_SalesDetail
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
            this.customerFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chassisTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfProductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfTransactionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dblab_phase2_aftercreateDataSet3 = new DB_Lab_phase3.dblab_phase2_aftercreateDataSet3();
            this.salesDetailTableAdapter = new DB_Lab_phase3.dblab_phase2_aftercreateDataSet3TableAdapters.SalesDetailTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblab_phase2_aftercreateDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1384, 536);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerFullNameDataGridViewTextBoxColumn,
            this.nationalCodeDataGridViewTextBoxColumn,
            this.personTypeDataGridViewTextBoxColumn,
            this.transactionTypeDataGridViewTextBoxColumn,
            this.vINDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.chassisTypeDataGridViewTextBoxColumn,
            this.yearOfProductionDataGridViewTextBoxColumn,
            this.milageDataGridViewTextBoxColumn,
            this.fuelTypeDataGridViewTextBoxColumn,
            this.dateOfTransactionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.currencyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salesDetailBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1378, 524);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // customerFullNameDataGridViewTextBoxColumn
            // 
            this.customerFullNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerFullName";
            this.customerFullNameDataGridViewTextBoxColumn.HeaderText = "CustomerFullName";
            this.customerFullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerFullNameDataGridViewTextBoxColumn.Name = "customerFullNameDataGridViewTextBoxColumn";
            this.customerFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerFullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // nationalCodeDataGridViewTextBoxColumn
            // 
            this.nationalCodeDataGridViewTextBoxColumn.DataPropertyName = "NationalCode";
            this.nationalCodeDataGridViewTextBoxColumn.HeaderText = "NationalCode";
            this.nationalCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nationalCodeDataGridViewTextBoxColumn.Name = "nationalCodeDataGridViewTextBoxColumn";
            this.nationalCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // personTypeDataGridViewTextBoxColumn
            // 
            this.personTypeDataGridViewTextBoxColumn.DataPropertyName = "PersonType";
            this.personTypeDataGridViewTextBoxColumn.HeaderText = "PersonType";
            this.personTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personTypeDataGridViewTextBoxColumn.Name = "personTypeDataGridViewTextBoxColumn";
            this.personTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // transactionTypeDataGridViewTextBoxColumn
            // 
            this.transactionTypeDataGridViewTextBoxColumn.DataPropertyName = "TransactionType";
            this.transactionTypeDataGridViewTextBoxColumn.HeaderText = "TransactionType";
            this.transactionTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transactionTypeDataGridViewTextBoxColumn.Name = "transactionTypeDataGridViewTextBoxColumn";
            this.transactionTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // vINDataGridViewTextBoxColumn
            // 
            this.vINDataGridViewTextBoxColumn.DataPropertyName = "VIN";
            this.vINDataGridViewTextBoxColumn.HeaderText = "VIN";
            this.vINDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vINDataGridViewTextBoxColumn.Name = "vINDataGridViewTextBoxColumn";
            this.vINDataGridViewTextBoxColumn.Width = 125;
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
            // dateOfTransactionDataGridViewTextBoxColumn
            // 
            this.dateOfTransactionDataGridViewTextBoxColumn.DataPropertyName = "DateOfTransaction";
            this.dateOfTransactionDataGridViewTextBoxColumn.HeaderText = "DateOfTransaction";
            this.dateOfTransactionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfTransactionDataGridViewTextBoxColumn.Name = "dateOfTransactionDataGridViewTextBoxColumn";
            this.dateOfTransactionDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // currencyDataGridViewTextBoxColumn
            // 
            this.currencyDataGridViewTextBoxColumn.DataPropertyName = "Currency";
            this.currencyDataGridViewTextBoxColumn.HeaderText = "Currency";
            this.currencyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currencyDataGridViewTextBoxColumn.Name = "currencyDataGridViewTextBoxColumn";
            this.currencyDataGridViewTextBoxColumn.Width = 125;
            // 
            // salesDetailBindingSource
            // 
            this.salesDetailBindingSource.DataMember = "SalesDetail";
            this.salesDetailBindingSource.DataSource = this.dblab_phase2_aftercreateDataSet3;
            // 
            // dblab_phase2_aftercreateDataSet3
            // 
            this.dblab_phase2_aftercreateDataSet3.DataSetName = "dblab_phase2_aftercreateDataSet3";
            this.dblab_phase2_aftercreateDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesDetailTableAdapter
            // 
            this.salesDetailTableAdapter.ClearBeforeFill = true;
            // 
            // Form_SalesDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 551);
            this.Controls.Add(this.panel1);
            this.Name = "Form_SalesDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_SalesDetail";
            this.Load += new System.EventHandler(this.Form_SalesDetail_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblab_phase2_aftercreateDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dblab_phase2_aftercreateDataSet3 dblab_phase2_aftercreateDataSet3;
        private System.Windows.Forms.BindingSource salesDetailBindingSource;
        private dblab_phase2_aftercreateDataSet3TableAdapters.SalesDetailTableAdapter salesDetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chassisTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfProductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn milageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfTransactionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
    }
}