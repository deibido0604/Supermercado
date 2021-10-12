namespace WinSupermercado
{
    partial class FormProductos
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
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label existenciaLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label precioUnidadLabel;
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label productoExtranjeroLabel;
            System.Windows.Forms.Label productoNacionalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            this.productoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.listaProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.seguridadBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.existenciaTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.precioUnidadTextBox = new System.Windows.Forms.TextBox();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.productoExtranjeroCheckBox = new System.Windows.Forms.CheckBox();
            this.productoNacionalCheckBox = new System.Windows.Forms.CheckBox();
            descripcionLabel = new System.Windows.Forms.Label();
            existenciaLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            precioUnidadLabel = new System.Windows.Forms.Label();
            activoLabel = new System.Windows.Forms.Label();
            productoExtranjeroLabel = new System.Windows.Forms.Label();
            productoNacionalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingNavigator)).BeginInit();
            this.productoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguridadBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(287, 71);
            descripcionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(83, 16);
            descripcionLabel.TabIndex = 6;
            descripcionLabel.Text = "Descripcion:";
            // 
            // existenciaLabel
            // 
            existenciaLabel.AutoSize = true;
            existenciaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            existenciaLabel.Location = new System.Drawing.Point(297, 105);
            existenciaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            existenciaLabel.Name = "existenciaLabel";
            existenciaLabel.Size = new System.Drawing.Size(72, 16);
            existenciaLabel.TabIndex = 7;
            existenciaLabel.Text = "Existencia:";
            existenciaLabel.Click += new System.EventHandler(this.existenciaLabel_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(108, 71);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(22, 16);
            idLabel.TabIndex = 8;
            idLabel.Text = "id:";
            // 
            // precioUnidadLabel
            // 
            precioUnidadLabel.AutoSize = true;
            precioUnidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioUnidadLabel.Location = new System.Drawing.Point(29, 110);
            precioUnidadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            precioUnidadLabel.Name = "precioUnidadLabel";
            precioUnidadLabel.Size = new System.Drawing.Size(97, 16);
            precioUnidadLabel.TabIndex = 9;
            precioUnidadLabel.Text = "Precio Unidad:";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            activoLabel.Location = new System.Drawing.Point(817, 47);
            activoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(48, 16);
            activoLabel.TabIndex = 10;
            activoLabel.Text = "Activo:";
            activoLabel.Click += new System.EventHandler(this.activoLabel_Click_1);
            // 
            // productoExtranjeroLabel
            // 
            productoExtranjeroLabel.AutoSize = true;
            productoExtranjeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productoExtranjeroLabel.Location = new System.Drawing.Point(737, 101);
            productoExtranjeroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            productoExtranjeroLabel.Name = "productoExtranjeroLabel";
            productoExtranjeroLabel.Size = new System.Drawing.Size(128, 16);
            productoExtranjeroLabel.TabIndex = 12;
            productoExtranjeroLabel.Text = "Producto Extranjero:";
            productoExtranjeroLabel.Click += new System.EventHandler(this.productoExtranjeroLabel_Click);
            // 
            // productoNacionalLabel
            // 
            productoNacionalLabel.AutoSize = true;
            productoNacionalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productoNacionalLabel.Location = new System.Drawing.Point(743, 74);
            productoNacionalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            productoNacionalLabel.Name = "productoNacionalLabel";
            productoNacionalLabel.Size = new System.Drawing.Size(122, 16);
            productoNacionalLabel.TabIndex = 14;
            productoNacionalLabel.Text = "Producto Nacional:";
            productoNacionalLabel.Click += new System.EventHandler(this.productoNacionalLabel_Click);
            // 
            // productoBindingNavigator
            // 
            this.productoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productoBindingNavigator.BindingSource = this.productoBindingSource;
            this.productoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.productoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productoBindingNavigatorSaveItem});
            this.productoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productoBindingNavigator.Name = "productoBindingNavigator";
            this.productoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productoBindingNavigator.Size = new System.Drawing.Size(1267, 27);
            this.productoBindingNavigator.TabIndex = 6;
            this.productoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(BL.Supermercado.Producto);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(49, 23);
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
            // productoBindingNavigatorSaveItem
            // 
            this.productoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productoBindingNavigatorSaveItem.Enabled = false;
            this.productoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productoBindingNavigatorSaveItem.Image")));
            this.productoBindingNavigatorSaveItem.Name = "productoBindingNavigatorSaveItem";
            this.productoBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.productoBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // listaProductosBindingSource
            // 
            this.listaProductosBindingSource.DataMember = "ListaProductos";
            this.listaProductosBindingSource.DataSource = this.productosBLBindingSource;
            // 
            // productosBLBindingSource
            // 
            this.productosBLBindingSource.DataSource = typeof(BL.Supermercado.ProductosBL);
            // 
            // listaProductosDataGridView
            // 
            this.listaProductosDataGridView.AllowUserToAddRows = false;
            this.listaProductosDataGridView.AutoGenerateColumns = false;
            this.listaProductosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaProductosDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.listaProductosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3});
            this.listaProductosDataGridView.DataSource = this.listaProductosBindingSource;
            this.listaProductosDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listaProductosDataGridView.Location = new System.Drawing.Point(0, 128);
            this.listaProductosDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listaProductosDataGridView.Name = "listaProductosDataGridView";
            this.listaProductosDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listaProductosDataGridView.RowTemplate.Height = 24;
            this.listaProductosDataGridView.Size = new System.Drawing.Size(1267, 571);
            this.listaProductosDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PrecioUnidad";
            this.dataGridViewTextBoxColumn3.HeaderText = "PrecioUnidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Existencia";
            this.dataGridViewTextBoxColumn4.HeaderText = "Existencia";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Activo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Activo";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "ProductoNacional";
            this.dataGridViewCheckBoxColumn2.HeaderText = "ProductoNacional";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "ProductoExtranjero";
            this.dataGridViewCheckBoxColumn3.HeaderText = "ProductoExtranjero";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // seguridadBLBindingSource
            // 
            this.seguridadBLBindingSource.DataSource = typeof(BL.Supermercado.SeguridadBL);
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductosBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(383, 63);
            this.descripcionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(316, 22);
            this.descripcionTextBox.TabIndex = 7;
            // 
            // existenciaTextBox
            // 
            this.existenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductosBindingSource, "Existencia", true));
            this.existenciaTextBox.Location = new System.Drawing.Point(383, 101);
            this.existenciaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.existenciaTextBox.Name = "existenciaTextBox";
            this.existenciaTextBox.Size = new System.Drawing.Size(132, 22);
            this.existenciaTextBox.TabIndex = 8;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductosBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(140, 63);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(132, 22);
            this.idTextBox.TabIndex = 9;
            // 
            // precioUnidadTextBox
            // 
            this.precioUnidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductosBindingSource, "PrecioUnidad", true));
            this.precioUnidadTextBox.Location = new System.Drawing.Point(140, 106);
            this.precioUnidadTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.precioUnidadTextBox.Name = "precioUnidadTextBox";
            this.precioUnidadTextBox.Size = new System.Drawing.Size(132, 22);
            this.precioUnidadTextBox.TabIndex = 10;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaProductosBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(881, 41);
            this.activoCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(139, 30);
            this.activoCheckBox.TabIndex = 11;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // productoExtranjeroCheckBox
            // 
            this.productoExtranjeroCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaProductosBindingSource, "ProductoExtranjero", true));
            this.productoExtranjeroCheckBox.Location = new System.Drawing.Point(881, 95);
            this.productoExtranjeroCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productoExtranjeroCheckBox.Name = "productoExtranjeroCheckBox";
            this.productoExtranjeroCheckBox.Size = new System.Drawing.Size(139, 30);
            this.productoExtranjeroCheckBox.TabIndex = 13;
            this.productoExtranjeroCheckBox.UseVisualStyleBackColor = true;
            this.productoExtranjeroCheckBox.CheckedChanged += new System.EventHandler(this.productoExtranjeroCheckBox_CheckedChanged);
            // 
            // productoNacionalCheckBox
            // 
            this.productoNacionalCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaProductosBindingSource, "ProductoNacional", true));
            this.productoNacionalCheckBox.Location = new System.Drawing.Point(881, 67);
            this.productoNacionalCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productoNacionalCheckBox.Name = "productoNacionalCheckBox";
            this.productoNacionalCheckBox.Size = new System.Drawing.Size(139, 30);
            this.productoNacionalCheckBox.TabIndex = 15;
            this.productoNacionalCheckBox.UseVisualStyleBackColor = true;
            this.productoNacionalCheckBox.CheckedChanged += new System.EventHandler(this.productoNacionalCheckBox_CheckedChanged);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1284, 665);
            this.Controls.Add(productoNacionalLabel);
            this.Controls.Add(this.productoNacionalCheckBox);
            this.Controls.Add(productoExtranjeroLabel);
            this.Controls.Add(this.productoExtranjeroCheckBox);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(precioUnidadLabel);
            this.Controls.Add(this.precioUnidadTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(existenciaLabel);
            this.Controls.Add(this.existenciaTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.listaProductosDataGridView);
            this.Controls.Add(this.productoBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormProductos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingNavigator)).EndInit();
            this.productoBindingNavigator.ResumeLayout(false);
            this.productoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguridadBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.BindingSource productosBLBindingSource;
        private System.Windows.Forms.BindingSource seguridadBLBindingSource;
        private System.Windows.Forms.BindingNavigator productoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton productoBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource listaProductosBindingSource;
        private System.Windows.Forms.DataGridView listaProductosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox existenciaTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox precioUnidadTextBox;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.CheckBox productoExtranjeroCheckBox;
        private System.Windows.Forms.CheckBox productoNacionalCheckBox;
    }
}