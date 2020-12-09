namespace Warehouse
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnInsertOrUpdateDocument = new System.Windows.Forms.Button();
            this.tbNameDocument = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateDocument = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteDocument = new System.Windows.Forms.Button();
            this.dgvDocuments = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grosspriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouse_dbDataSet1 = new Warehouse.warehouse_dbDataSet();
            this.nudClientNumberDocument = new System.Windows.Forms.NumericUpDown();
            this.btnClearFormDocument = new System.Windows.Forms.Button();
            this.gbDocuments = new System.Windows.Forms.GroupBox();
            this.gbPositions = new System.Windows.Forms.GroupBox();
            this.nudQuantityPosition = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClearFormPosition = new System.Windows.Forms.Button();
            this.btnDeletePosition = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudGrossPricePosition = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.nudNetPricePosition = new System.Windows.Forms.NumericUpDown();
            this.tbNamePosition = new System.Windows.Forms.TextBox();
            this.btnInsertOrUpdatePosition = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvPositions = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netpriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grosspriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouse_dbDataSet = new Warehouse.warehouse_dbDataSet();
            this.documentsTableAdapter1 = new Warehouse.warehouse_dbDataSetTableAdapters.documentsTableAdapter();
            this.positionsTableAdapter1 = new Warehouse.warehouse_dbDataSetTableAdapters.positionsTableAdapter();
            this.lGitHubInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClientNumberDocument)).BeginInit();
            this.gbDocuments.SuspendLayout();
            this.gbPositions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrossPricePosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNetPricePosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertOrUpdateDocument
            // 
            this.btnInsertOrUpdateDocument.Location = new System.Drawing.Point(179, 433);
            this.btnInsertOrUpdateDocument.Name = "btnInsertOrUpdateDocument";
            this.btnInsertOrUpdateDocument.Size = new System.Drawing.Size(108, 27);
            this.btnInsertOrUpdateDocument.TabIndex = 26;
            this.btnInsertOrUpdateDocument.Text = "Dodaj nowy";
            this.btnInsertOrUpdateDocument.UseVisualStyleBackColor = true;
            this.btnInsertOrUpdateDocument.Click += new System.EventHandler(this.btnAddDocument_Click);
            // 
            // tbNameDocument
            // 
            this.tbNameDocument.Location = new System.Drawing.Point(114, 402);
            this.tbNameDocument.Name = "tbNameDocument";
            this.tbNameDocument.Size = new System.Drawing.Size(115, 22);
            this.tbNameDocument.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nazwa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Numer klienta:";
            // 
            // dtpDateDocument
            // 
            this.dtpDateDocument.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDocument.Location = new System.Drawing.Point(114, 346);
            this.dtpDateDocument.Name = "dtpDateDocument";
            this.dtpDateDocument.Size = new System.Drawing.Size(115, 22);
            this.dtpDateDocument.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Data:";
            // 
            // btnDeleteDocument
            // 
            this.btnDeleteDocument.Location = new System.Drawing.Point(293, 433);
            this.btnDeleteDocument.Name = "btnDeleteDocument";
            this.btnDeleteDocument.Size = new System.Drawing.Size(92, 27);
            this.btnDeleteDocument.TabIndex = 17;
            this.btnDeleteDocument.Text = "Usuń";
            this.btnDeleteDocument.UseVisualStyleBackColor = true;
            this.btnDeleteDocument.Click += new System.EventHandler(this.btnDeleteDocument_Click);
            // 
            // dgvDocuments
            // 
            this.dgvDocuments.AllowUserToAddRows = false;
            this.dgvDocuments.AllowUserToDeleteRows = false;
            this.dgvDocuments.AllowUserToResizeRows = false;
            this.dgvDocuments.AutoGenerateColumns = false;
            this.dgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.clientnumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.netpriceDataGridViewTextBoxColumn,
            this.grosspriceDataGridViewTextBoxColumn});
            this.dgvDocuments.DataSource = this.documentsBindingSource;
            this.dgvDocuments.Location = new System.Drawing.Point(6, 21);
            this.dgvDocuments.MultiSelect = false;
            this.dgvDocuments.Name = "dgvDocuments";
            this.dgvDocuments.ReadOnly = true;
            this.dgvDocuments.RowHeadersVisible = false;
            this.dgvDocuments.RowHeadersWidth = 51;
            this.dgvDocuments.RowTemplate.Height = 24;
            this.dgvDocuments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocuments.Size = new System.Drawing.Size(541, 290);
            this.dgvDocuments.TabIndex = 16;
            this.dgvDocuments.Click += new System.EventHandler(this.dgvDocuments_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 67;
            // 
            // clientnumberDataGridViewTextBoxColumn
            // 
            this.clientnumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clientnumberDataGridViewTextBoxColumn.DataPropertyName = "client_number";
            this.clientnumberDataGridViewTextBoxColumn.HeaderText = "Numer klienta";
            this.clientnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientnumberDataGridViewTextBoxColumn.Name = "clientnumberDataGridViewTextBoxColumn";
            this.clientnumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientnumberDataGridViewTextBoxColumn.Width = 124;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 79;
            // 
            // netpriceDataGridViewTextBoxColumn
            // 
            this.netpriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.netpriceDataGridViewTextBoxColumn.DataPropertyName = "net_price";
            this.netpriceDataGridViewTextBoxColumn.HeaderText = "Cena Netto";
            this.netpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.netpriceDataGridViewTextBoxColumn.Name = "netpriceDataGridViewTextBoxColumn";
            this.netpriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.netpriceDataGridViewTextBoxColumn.Width = 108;
            // 
            // grosspriceDataGridViewTextBoxColumn
            // 
            this.grosspriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grosspriceDataGridViewTextBoxColumn.DataPropertyName = "gross_price";
            this.grosspriceDataGridViewTextBoxColumn.HeaderText = "Cena brutto";
            this.grosspriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.grosspriceDataGridViewTextBoxColumn.Name = "grosspriceDataGridViewTextBoxColumn";
            this.grosspriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.grosspriceDataGridViewTextBoxColumn.Width = 111;
            // 
            // documentsBindingSource
            // 
            this.documentsBindingSource.DataMember = "documents";
            this.documentsBindingSource.DataSource = this.warehouse_dbDataSet1;
            // 
            // warehouse_dbDataSet1
            // 
            this.warehouse_dbDataSet1.DataSetName = "warehouse_dbDataSet";
            this.warehouse_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.warehouse_dbDataSet1.Initialized += new System.EventHandler(this.warehouse_dbDataSet1_Initialized);
            // 
            // nudClientNumberDocument
            // 
            this.nudClientNumberDocument.Location = new System.Drawing.Point(114, 375);
            this.nudClientNumberDocument.Name = "nudClientNumberDocument";
            this.nudClientNumberDocument.Size = new System.Drawing.Size(115, 22);
            this.nudClientNumberDocument.TabIndex = 31;
            // 
            // btnClearFormDocument
            // 
            this.btnClearFormDocument.Location = new System.Drawing.Point(12, 433);
            this.btnClearFormDocument.Name = "btnClearFormDocument";
            this.btnClearFormDocument.Size = new System.Drawing.Size(161, 27);
            this.btnClearFormDocument.TabIndex = 32;
            this.btnClearFormDocument.Text = "Wyczyść formularz";
            this.btnClearFormDocument.UseVisualStyleBackColor = true;
            this.btnClearFormDocument.Click += new System.EventHandler(this.btnClearFormDocument_Click);
            // 
            // gbDocuments
            // 
            this.gbDocuments.Controls.Add(this.dgvDocuments);
            this.gbDocuments.Controls.Add(this.btnClearFormDocument);
            this.gbDocuments.Controls.Add(this.btnDeleteDocument);
            this.gbDocuments.Controls.Add(this.nudClientNumberDocument);
            this.gbDocuments.Controls.Add(this.label1);
            this.gbDocuments.Controls.Add(this.dtpDateDocument);
            this.gbDocuments.Controls.Add(this.label2);
            this.gbDocuments.Controls.Add(this.label3);
            this.gbDocuments.Controls.Add(this.tbNameDocument);
            this.gbDocuments.Controls.Add(this.btnInsertOrUpdateDocument);
            this.gbDocuments.Location = new System.Drawing.Point(12, 12);
            this.gbDocuments.Name = "gbDocuments";
            this.gbDocuments.Size = new System.Drawing.Size(556, 471);
            this.gbDocuments.TabIndex = 33;
            this.gbDocuments.TabStop = false;
            this.gbDocuments.Text = "Dokumenty";
            // 
            // gbPositions
            // 
            this.gbPositions.Controls.Add(this.nudQuantityPosition);
            this.gbPositions.Controls.Add(this.label8);
            this.gbPositions.Controls.Add(this.btnClearFormPosition);
            this.gbPositions.Controls.Add(this.btnDeletePosition);
            this.gbPositions.Controls.Add(this.label9);
            this.gbPositions.Controls.Add(this.label10);
            this.gbPositions.Controls.Add(this.nudGrossPricePosition);
            this.gbPositions.Controls.Add(this.label12);
            this.gbPositions.Controls.Add(this.nudNetPricePosition);
            this.gbPositions.Controls.Add(this.tbNamePosition);
            this.gbPositions.Controls.Add(this.btnInsertOrUpdatePosition);
            this.gbPositions.Controls.Add(this.label13);
            this.gbPositions.Controls.Add(this.label14);
            this.gbPositions.Controls.Add(this.dgvPositions);
            this.gbPositions.Location = new System.Drawing.Point(574, 12);
            this.gbPositions.Name = "gbPositions";
            this.gbPositions.Size = new System.Drawing.Size(393, 471);
            this.gbPositions.TabIndex = 34;
            this.gbPositions.TabStop = false;
            this.gbPositions.Text = "Pozycje Dokumentu";
            // 
            // nudQuantityPosition
            // 
            this.nudQuantityPosition.Location = new System.Drawing.Point(108, 349);
            this.nudQuantityPosition.Name = "nudQuantityPosition";
            this.nudQuantityPosition.Size = new System.Drawing.Size(115, 22);
            this.nudQuantityPosition.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 48;
            this.label8.Text = "Ilość:";
            // 
            // btnClearFormPosition
            // 
            this.btnClearFormPosition.Location = new System.Drawing.Point(6, 433);
            this.btnClearFormPosition.Name = "btnClearFormPosition";
            this.btnClearFormPosition.Size = new System.Drawing.Size(161, 27);
            this.btnClearFormPosition.TabIndex = 47;
            this.btnClearFormPosition.Text = "Wyczyść formularz";
            this.btnClearFormPosition.UseVisualStyleBackColor = true;
            this.btnClearFormPosition.Click += new System.EventHandler(this.btnClearFormPosition_Click);
            // 
            // btnDeletePosition
            // 
            this.btnDeletePosition.Location = new System.Drawing.Point(287, 433);
            this.btnDeletePosition.Name = "btnDeletePosition";
            this.btnDeletePosition.Size = new System.Drawing.Size(92, 27);
            this.btnDeletePosition.TabIndex = 33;
            this.btnDeletePosition.Text = "Usuń";
            this.btnDeletePosition.UseVisualStyleBackColor = true;
            this.btnDeletePosition.Click += new System.EventHandler(this.btnDeletePosition_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 45;
            this.label9.Text = "PLN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(229, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 44;
            this.label10.Text = "PLN";
            // 
            // nudGrossPricePosition
            // 
            this.nudGrossPricePosition.DecimalPlaces = 2;
            this.nudGrossPricePosition.Location = new System.Drawing.Point(108, 405);
            this.nudGrossPricePosition.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nudGrossPricePosition.Name = "nudGrossPricePosition";
            this.nudGrossPricePosition.Size = new System.Drawing.Size(115, 22);
            this.nudGrossPricePosition.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 324);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 37;
            this.label12.Text = "Nazwa:";
            // 
            // nudNetPricePosition
            // 
            this.nudNetPricePosition.DecimalPlaces = 2;
            this.nudNetPricePosition.Location = new System.Drawing.Point(108, 377);
            this.nudNetPricePosition.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nudNetPricePosition.Name = "nudNetPricePosition";
            this.nudNetPricePosition.Size = new System.Drawing.Size(115, 22);
            this.nudNetPricePosition.TabIndex = 42;
            // 
            // tbNamePosition
            // 
            this.tbNamePosition.Location = new System.Drawing.Point(108, 321);
            this.tbNamePosition.Name = "tbNamePosition";
            this.tbNamePosition.Size = new System.Drawing.Size(115, 22);
            this.tbNamePosition.TabIndex = 38;
            // 
            // btnInsertOrUpdatePosition
            // 
            this.btnInsertOrUpdatePosition.Location = new System.Drawing.Point(173, 433);
            this.btnInsertOrUpdatePosition.Name = "btnInsertOrUpdatePosition";
            this.btnInsertOrUpdatePosition.Size = new System.Drawing.Size(108, 27);
            this.btnInsertOrUpdatePosition.TabIndex = 41;
            this.btnInsertOrUpdatePosition.Text = "Dodaj nowy";
            this.btnInsertOrUpdatePosition.UseVisualStyleBackColor = true;
            this.btnInsertOrUpdatePosition.Click += new System.EventHandler(this.btnInsertOrUpdatePosition_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 379);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 17);
            this.label13.TabIndex = 39;
            this.label13.Text = "Cena Netto:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 407);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 17);
            this.label14.TabIndex = 40;
            this.label14.Text = "Cena Brutto:";
            // 
            // dgvPositions
            // 
            this.dgvPositions.AllowUserToAddRows = false;
            this.dgvPositions.AllowUserToDeleteRows = false;
            this.dgvPositions.AllowUserToResizeRows = false;
            this.dgvPositions.AutoGenerateColumns = false;
            this.dgvPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.documentidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn,
            this.netpriceDataGridViewTextBoxColumn1,
            this.grosspriceDataGridViewTextBoxColumn1});
            this.dgvPositions.DataSource = this.positionsBindingSource;
            this.dgvPositions.Location = new System.Drawing.Point(6, 21);
            this.dgvPositions.MultiSelect = false;
            this.dgvPositions.Name = "dgvPositions";
            this.dgvPositions.ReadOnly = true;
            this.dgvPositions.RowHeadersVisible = false;
            this.dgvPositions.RowHeadersWidth = 51;
            this.dgvPositions.RowTemplate.Height = 24;
            this.dgvPositions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPositions.Size = new System.Drawing.Size(377, 290);
            this.dgvPositions.TabIndex = 17;
            this.dgvPositions.Click += new System.EventHandler(this.dgvPositions_Click);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // documentidDataGridViewTextBoxColumn
            // 
            this.documentidDataGridViewTextBoxColumn.DataPropertyName = "document_id";
            this.documentidDataGridViewTextBoxColumn.HeaderText = "document_id";
            this.documentidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentidDataGridViewTextBoxColumn.Name = "documentidDataGridViewTextBoxColumn";
            this.documentidDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentidDataGridViewTextBoxColumn.Visible = false;
            this.documentidDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Nazwa";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 79;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Ilość";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 65;
            // 
            // netpriceDataGridViewTextBoxColumn1
            // 
            this.netpriceDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.netpriceDataGridViewTextBoxColumn1.DataPropertyName = "net_price";
            this.netpriceDataGridViewTextBoxColumn1.HeaderText = "Cena Netto";
            this.netpriceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.netpriceDataGridViewTextBoxColumn1.Name = "netpriceDataGridViewTextBoxColumn1";
            this.netpriceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.netpriceDataGridViewTextBoxColumn1.Width = 108;
            // 
            // grosspriceDataGridViewTextBoxColumn1
            // 
            this.grosspriceDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grosspriceDataGridViewTextBoxColumn1.DataPropertyName = "gross_price";
            this.grosspriceDataGridViewTextBoxColumn1.HeaderText = "Cena Brutto";
            this.grosspriceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.grosspriceDataGridViewTextBoxColumn1.Name = "grosspriceDataGridViewTextBoxColumn1";
            this.grosspriceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.grosspriceDataGridViewTextBoxColumn1.Width = 112;
            // 
            // positionsBindingSource
            // 
            this.positionsBindingSource.DataMember = "positions";
            this.positionsBindingSource.DataSource = this.warehouse_dbDataSet;
            // 
            // warehouse_dbDataSet
            // 
            this.warehouse_dbDataSet.DataSetName = "warehouse_dbDataSet";
            this.warehouse_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentsTableAdapter1
            // 
            this.documentsTableAdapter1.ClearBeforeFill = true;
            // 
            // positionsTableAdapter1
            // 
            this.positionsTableAdapter1.ClearBeforeFill = true;
            // 
            // lGitHubInfo
            // 
            this.lGitHubInfo.AutoSize = true;
            this.lGitHubInfo.Location = new System.Drawing.Point(12, 492);
            this.lGitHubInfo.Name = "lGitHubInfo";
            this.lGitHubInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lGitHubInfo.Size = new System.Drawing.Size(79, 17);
            this.lGitHubInfo.TabIndex = 35;
            this.lGitHubInfo.Text = "GitHub info";
            this.lGitHubInfo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 518);
            this.Controls.Add(this.lGitHubInfo);
            this.Controls.Add(this.gbPositions);
            this.Controls.Add(this.gbDocuments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Magazyn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClientNumberDocument)).EndInit();
            this.gbDocuments.ResumeLayout(false);
            this.gbDocuments.PerformLayout();
            this.gbPositions.ResumeLayout(false);
            this.gbPositions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrossPricePosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNetPricePosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private warehouse_dbDataSetTableAdapters.documentsTableAdapter documentsTableAdapter1;
        private warehouse_dbDataSetTableAdapters.positionsTableAdapter positionsTableAdapter1;
        private warehouse_dbDataSet warehouse_dbDataSet1;
        private System.Windows.Forms.Button btnInsertOrUpdateDocument;
        private System.Windows.Forms.TextBox tbNameDocument;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateDocument;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteDocument;
        private System.Windows.Forms.DataGridView dgvDocuments;
        private System.Windows.Forms.BindingSource documentsBindingSource;
        private System.Windows.Forms.NumericUpDown nudClientNumberDocument;
        private System.Windows.Forms.Button btnClearFormDocument;
        private System.Windows.Forms.GroupBox gbDocuments;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grosspriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gbPositions;
        private System.Windows.Forms.DataGridView dgvPositions;
        private warehouse_dbDataSet warehouse_dbDataSet;
        private System.Windows.Forms.BindingSource positionsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netpriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn grosspriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.NumericUpDown nudQuantityPosition;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClearFormPosition;
        private System.Windows.Forms.Button btnDeletePosition;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudGrossPricePosition;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudNetPricePosition;
        private System.Windows.Forms.TextBox tbNamePosition;
        private System.Windows.Forms.Button btnInsertOrUpdatePosition;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lGitHubInfo;
    }
}

