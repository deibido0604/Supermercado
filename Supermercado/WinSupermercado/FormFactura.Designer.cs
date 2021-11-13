namespace WinSupermercado
{
    partial class FromFactura
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
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label clienteIdLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label impuestoLabel;
            System.Windows.Forms.Label subtotalLabel;
            System.Windows.Forms.Label totalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromFactura));
            this.listaFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaFacturasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaFacturasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.impuestoTextBox = new System.Windows.Forms.TextBox();
            this.subtotalTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.listaClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteIdComboBox = new System.Windows.Forms.ComboBox();
            this.facturaDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.facturaDetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            activoLabel = new System.Windows.Forms.Label();
            clienteIdLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            impuestoLabel = new System.Windows.Forms.Label();
            subtotalLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFacturasBindingNavigator)).BeginInit();
            this.listaFacturasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDetalleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(335, 43);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(50, 17);
            activoLabel.TabIndex = 1;
            activoLabel.Text = "Activo:";
            // 
            // clienteIdLabel
            // 
            clienteIdLabel.AutoSize = true;
            clienteIdLabel.Location = new System.Drawing.Point(25, 80);
            clienteIdLabel.Name = "clienteIdLabel";
            clienteIdLabel.Size = new System.Drawing.Size(51, 17);
            clienteIdLabel.TabIndex = 3;
            clienteIdLabel.Text = "Cliente";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(25, 135);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(51, 17);
            fechaLabel.TabIndex = 5;
            fechaLabel.Text = "Fecha:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(25, 43);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 7;
            idLabel.Text = "Id:";
            // 
            // impuestoLabel
            // 
            impuestoLabel.AutoSize = true;
            impuestoLabel.Location = new System.Drawing.Point(951, 479);
            impuestoLabel.Name = "impuestoLabel";
            impuestoLabel.Size = new System.Drawing.Size(69, 17);
            impuestoLabel.TabIndex = 9;
            impuestoLabel.Text = "Impuesto:";
            // 
            // subtotalLabel
            // 
            subtotalLabel.AutoSize = true;
            subtotalLabel.Location = new System.Drawing.Point(951, 507);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new System.Drawing.Size(64, 17);
            subtotalLabel.TabIndex = 11;
            subtotalLabel.Text = "Subtotal:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(951, 535);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(44, 17);
            totalLabel.TabIndex = 13;
            totalLabel.Text = "Total:";
            // 
            // listaFacturasBindingSource
            // 
            this.listaFacturasBindingSource.DataSource = typeof(BL.Supermercado.Factura);
            this.listaFacturasBindingSource.CurrentChanged += new System.EventHandler(this.listaFacturasBindingSource_CurrentChanged_1);
            // 
            // listaFacturasBindingNavigator
            // 
            this.listaFacturasBindingNavigator.AddNewItem = null;
            this.listaFacturasBindingNavigator.BindingSource = this.listaFacturasBindingSource;
            this.listaFacturasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaFacturasBindingNavigator.DeleteItem = null;
            this.listaFacturasBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listaFacturasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaFacturasBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaFacturasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaFacturasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaFacturasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaFacturasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaFacturasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaFacturasBindingNavigator.Name = "listaFacturasBindingNavigator";
            this.listaFacturasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaFacturasBindingNavigator.Size = new System.Drawing.Size(1280, 27);
            this.listaFacturasBindingNavigator.TabIndex = 0;
            this.listaFacturasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click_1);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Anular";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click_1);
            // 
            // listaFacturasBindingNavigatorSaveItem
            // 
            this.listaFacturasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaFacturasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaFacturasBindingNavigatorSaveItem.Image")));
            this.listaFacturasBindingNavigatorSaveItem.Name = "listaFacturasBindingNavigatorSaveItem";
            this.listaFacturasBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.listaFacturasBindingNavigatorSaveItem.Text = "Save Data";
            this.listaFacturasBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaFacturasBindingNavigatorSaveItem_Click_1);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(70, 24);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaFacturasBindingSource, "Activo", true));
            this.activoCheckBox.Enabled = false;
            this.activoCheckBox.Location = new System.Drawing.Point(411, 38);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(200, 24);
            this.activoCheckBox.TabIndex = 2;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listaFacturasBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(101, 131);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fechaDateTimePicker.TabIndex = 6;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaFacturasBindingSource, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "00000"));
            this.idTextBox.Location = new System.Drawing.Point(101, 40);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(200, 22);
            this.idTextBox.TabIndex = 8;
            // 
            // impuestoTextBox
            // 
            this.impuestoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaFacturasBindingSource, "Impuesto", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.impuestoTextBox.Location = new System.Drawing.Point(1027, 476);
            this.impuestoTextBox.Name = "impuestoTextBox";
            this.impuestoTextBox.ReadOnly = true;
            this.impuestoTextBox.Size = new System.Drawing.Size(200, 22);
            this.impuestoTextBox.TabIndex = 10;
            this.impuestoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // subtotalTextBox
            // 
            this.subtotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaFacturasBindingSource, "Subtotal", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.subtotalTextBox.Location = new System.Drawing.Point(1027, 504);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.ReadOnly = true;
            this.subtotalTextBox.Size = new System.Drawing.Size(200, 22);
            this.subtotalTextBox.TabIndex = 12;
            this.subtotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaFacturasBindingSource, "Total", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.totalTextBox.Location = new System.Drawing.Point(1027, 532);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(200, 22);
            this.totalTextBox.TabIndex = 14;
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listaClientesBindingSource
            // 
            this.listaClientesBindingSource.DataSource = typeof(BL.Supermercado.Cliente);
            // 
            // listaProductosBindingSource
            // 
            this.listaProductosBindingSource.DataSource = typeof(BL.Supermercado.Producto);
            // 
            // clienteIdComboBox
            // 
            this.clienteIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaFacturasBindingSource, "ClienteId", true));
            this.clienteIdComboBox.DataSource = this.listaClientesBindingSource;
            this.clienteIdComboBox.DisplayMember = "Nombre";
            this.clienteIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clienteIdComboBox.FormattingEnabled = true;
            this.clienteIdComboBox.Location = new System.Drawing.Point(101, 77);
            this.clienteIdComboBox.Name = "clienteIdComboBox";
            this.clienteIdComboBox.Size = new System.Drawing.Size(200, 24);
            this.clienteIdComboBox.TabIndex = 15;
            this.clienteIdComboBox.ValueMember = "Id";
            // 
            // facturaDetalleBindingSource
            // 
            this.facturaDetalleBindingSource.AllowNew = false;
            this.facturaDetalleBindingSource.DataMember = "FacturaDetalle";
            this.facturaDetalleBindingSource.DataSource = this.listaFacturasBindingSource;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1027, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 16;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1139, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 50);
            this.button2.TabIndex = 17;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(757, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "ANULADO";
            this.label1.Visible = false;
            // 
            // facturaDetalleDataGridView
            // 
            this.facturaDetalleDataGridView.AutoGenerateColumns = false;
            this.facturaDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturaDetalleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.facturaDetalleDataGridView.DataSource = this.facturaDetalleBindingSource;
            this.facturaDetalleDataGridView.Location = new System.Drawing.Point(28, 219);
            this.facturaDetalleDataGridView.Name = "facturaDetalleDataGridView";
            this.facturaDetalleDataGridView.RowTemplate.Height = 24;
            this.facturaDetalleDataGridView.Size = new System.Drawing.Size(677, 220);
            this.facturaDetalleDataGridView.TabIndex = 18;
            this.facturaDetalleDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.facturaDetalleDataGridView_CellEndEdit);
            this.facturaDetalleDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.facturaDetalleDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProductoId";
            this.dataGridViewTextBoxColumn3.DataSource = this.listaProductosBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "id";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn6.HeaderText = "Total";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // FromFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 582);
            this.Controls.Add(this.facturaDetalleDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clienteIdComboBox);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(clienteIdLabel);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(impuestoLabel);
            this.Controls.Add(this.impuestoTextBox);
            this.Controls.Add(subtotalLabel);
            this.Controls.Add(this.subtotalTextBox);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.listaFacturasBindingNavigator);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FromFactura";
            this.Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)(this.listaFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFacturasBindingNavigator)).EndInit();
            this.listaFacturasBindingNavigator.ResumeLayout(false);
            this.listaFacturasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDetalleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaFacturasBindingSource;
        private System.Windows.Forms.BindingNavigator listaFacturasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listaFacturasBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox impuestoTextBox;
        private System.Windows.Forms.TextBox subtotalTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.BindingSource listaClientesBindingSource;
        private System.Windows.Forms.BindingSource listaProductosBindingSource;
        private System.Windows.Forms.ComboBox clienteIdComboBox;
        private System.Windows.Forms.BindingSource facturaDetalleBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView facturaDetalleDataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}