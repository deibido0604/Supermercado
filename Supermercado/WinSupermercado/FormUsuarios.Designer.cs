namespace WinSupermercado
{
    partial class FormUsuarios
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label puedeAccederClientesLabel;
            System.Windows.Forms.Label puedeAccederFacturasLabel;
            System.Windows.Forms.Label puedeAccederProductosLabel;
            System.Windows.Forms.Label puedeAccederReportesLabel;
            System.Windows.Forms.Label contrasenaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            this.listaUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaUsuariosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.listaUsuariosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listaUsuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.puedeAccederClientesCheckBox = new System.Windows.Forms.CheckBox();
            this.puedeAccederFacturasCheckBox = new System.Windows.Forms.CheckBox();
            this.puedeAccederProductosCheckBox = new System.Windows.Forms.CheckBox();
            this.puedeAccederReportesCheckBox = new System.Windows.Forms.CheckBox();
            this.contrasenaTextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            puedeAccederClientesLabel = new System.Windows.Forms.Label();
            puedeAccederFacturasLabel = new System.Windows.Forms.Label();
            puedeAccederProductosLabel = new System.Windows.Forms.Label();
            puedeAccederReportesLabel = new System.Windows.Forms.Label();
            contrasenaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosBindingNavigator)).BeginInit();
            this.listaUsuariosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosBindingSource1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(264, 95);
            idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 5;
            idLabel.Text = "Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(264, 152);
            nombreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 7;
            nombreLabel.Text = "Nombre:";
            // 
            // puedeAccederClientesLabel
            // 
            puedeAccederClientesLabel.AutoSize = true;
            puedeAccederClientesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            puedeAccederClientesLabel.Location = new System.Drawing.Point(22, 22);
            puedeAccederClientesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            puedeAccederClientesLabel.Name = "puedeAccederClientesLabel";
            puedeAccederClientesLabel.Size = new System.Drawing.Size(179, 16);
            puedeAccederClientesLabel.TabIndex = 14;
            puedeAccederClientesLabel.Text = "Puede Acceder Clientes:";
            // 
            // puedeAccederFacturasLabel
            // 
            puedeAccederFacturasLabel.AutoSize = true;
            puedeAccederFacturasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            puedeAccederFacturasLabel.Location = new System.Drawing.Point(22, 48);
            puedeAccederFacturasLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            puedeAccederFacturasLabel.Name = "puedeAccederFacturasLabel";
            puedeAccederFacturasLabel.Size = new System.Drawing.Size(183, 16);
            puedeAccederFacturasLabel.TabIndex = 15;
            puedeAccederFacturasLabel.Text = "Puede Acceder Facturas:";
            // 
            // puedeAccederProductosLabel
            // 
            puedeAccederProductosLabel.AutoSize = true;
            puedeAccederProductosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            puedeAccederProductosLabel.Location = new System.Drawing.Point(22, 70);
            puedeAccederProductosLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            puedeAccederProductosLabel.Name = "puedeAccederProductosLabel";
            puedeAccederProductosLabel.Size = new System.Drawing.Size(193, 16);
            puedeAccederProductosLabel.TabIndex = 16;
            puedeAccederProductosLabel.Text = "Puede Acceder Productos:";
            // 
            // puedeAccederReportesLabel
            // 
            puedeAccederReportesLabel.AutoSize = true;
            puedeAccederReportesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            puedeAccederReportesLabel.Location = new System.Drawing.Point(22, 94);
            puedeAccederReportesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            puedeAccederReportesLabel.Name = "puedeAccederReportesLabel";
            puedeAccederReportesLabel.Size = new System.Drawing.Size(187, 16);
            puedeAccederReportesLabel.TabIndex = 17;
            puedeAccederReportesLabel.Text = "Puede Acceder Reportes:";
            // 
            // contrasenaLabel
            // 
            contrasenaLabel.AutoSize = true;
            contrasenaLabel.Location = new System.Drawing.Point(264, 211);
            contrasenaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            contrasenaLabel.Name = "contrasenaLabel";
            contrasenaLabel.Size = new System.Drawing.Size(64, 13);
            contrasenaLabel.TabIndex = 18;
            contrasenaLabel.Text = "Contrasena:";
            // 
            // listaUsuariosBindingNavigator
            // 
            this.listaUsuariosBindingNavigator.AddNewItem = null;
            this.listaUsuariosBindingNavigator.BindingSource = this.listaUsuariosBindingSource;
            this.listaUsuariosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaUsuariosBindingNavigator.DeleteItem = null;
            this.listaUsuariosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listaUsuariosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaUsuariosBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaUsuariosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaUsuariosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaUsuariosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaUsuariosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaUsuariosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaUsuariosBindingNavigator.Name = "listaUsuariosBindingNavigator";
            this.listaUsuariosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaUsuariosBindingNavigator.Size = new System.Drawing.Size(1005, 27);
            this.listaUsuariosBindingNavigator.TabIndex = 0;
            this.listaUsuariosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
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
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click_1);
            // 
            // listaUsuariosBindingNavigatorSaveItem
            // 
            this.listaUsuariosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaUsuariosBindingNavigatorSaveItem.Name = "listaUsuariosBindingNavigatorSaveItem";
            this.listaUsuariosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.listaUsuariosBindingNavigatorSaveItem.Text = "Save Data";
            this.listaUsuariosBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaUsuariosBindingNavigatorSaveItem_Click_1);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 24);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click_1);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaUsuariosBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(254, 110);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.Multiline = true;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(354, 31);
            this.idTextBox.TabIndex = 6;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaUsuariosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(254, 167);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nombreTextBox.Multiline = true;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(354, 31);
            this.nombreTextBox.TabIndex = 8;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.listaUsuariosBindingSource, "Foto", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.fotoPictureBox.Location = new System.Drawing.Point(709, 110);
            this.fotoPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(198, 221);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 12;
            this.fotoPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(709, 344);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "AgregarFoto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(811, 344);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 31);
            this.button2.TabIndex = 14;
            this.button2.Text = "Remover Foto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "jpg, png | *.jpg; *.png";
            // 
            // listaUsuariosBindingSource1
            // 
            this.listaUsuariosBindingSource1.DataSource = typeof(BL.Supermercado.SeguridadBL.Usuario);
            // 
            // puedeAccederClientesCheckBox
            // 
            this.puedeAccederClientesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaUsuariosBindingSource1, "PuedeAccederClientes", true));
            this.puedeAccederClientesCheckBox.Location = new System.Drawing.Point(216, 22);
            this.puedeAccederClientesCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.puedeAccederClientesCheckBox.Name = "puedeAccederClientesCheckBox";
            this.puedeAccederClientesCheckBox.Size = new System.Drawing.Size(78, 20);
            this.puedeAccederClientesCheckBox.TabIndex = 15;
            this.puedeAccederClientesCheckBox.UseVisualStyleBackColor = true;
            // 
            // puedeAccederFacturasCheckBox
            // 
            this.puedeAccederFacturasCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaUsuariosBindingSource1, "PuedeAccederFacturas", true));
            this.puedeAccederFacturasCheckBox.Location = new System.Drawing.Point(216, 48);
            this.puedeAccederFacturasCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.puedeAccederFacturasCheckBox.Name = "puedeAccederFacturasCheckBox";
            this.puedeAccederFacturasCheckBox.Size = new System.Drawing.Size(78, 20);
            this.puedeAccederFacturasCheckBox.TabIndex = 16;
            this.puedeAccederFacturasCheckBox.UseVisualStyleBackColor = true;
            // 
            // puedeAccederProductosCheckBox
            // 
            this.puedeAccederProductosCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaUsuariosBindingSource1, "PuedeAccederProductos", true));
            this.puedeAccederProductosCheckBox.Location = new System.Drawing.Point(216, 70);
            this.puedeAccederProductosCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.puedeAccederProductosCheckBox.Name = "puedeAccederProductosCheckBox";
            this.puedeAccederProductosCheckBox.Size = new System.Drawing.Size(78, 20);
            this.puedeAccederProductosCheckBox.TabIndex = 17;
            this.puedeAccederProductosCheckBox.UseVisualStyleBackColor = true;
            // 
            // puedeAccederReportesCheckBox
            // 
            this.puedeAccederReportesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaUsuariosBindingSource1, "PuedeAccederReportes", true));
            this.puedeAccederReportesCheckBox.Location = new System.Drawing.Point(216, 94);
            this.puedeAccederReportesCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.puedeAccederReportesCheckBox.Name = "puedeAccederReportesCheckBox";
            this.puedeAccederReportesCheckBox.Size = new System.Drawing.Size(78, 20);
            this.puedeAccederReportesCheckBox.TabIndex = 18;
            this.puedeAccederReportesCheckBox.UseVisualStyleBackColor = true;
            // 
            // contrasenaTextBox
            // 
            this.contrasenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaUsuariosBindingSource1, "Contrasena", true));
            this.contrasenaTextBox.Location = new System.Drawing.Point(254, 226);
            this.contrasenaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.contrasenaTextBox.Multiline = true;
            this.contrasenaTextBox.Name = "contrasenaTextBox";
            this.contrasenaTextBox.PasswordChar = '*';
            this.contrasenaTextBox.Size = new System.Drawing.Size(354, 31);
            this.contrasenaTextBox.TabIndex = 19;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(254, 261);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Ver Contraseña";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(106)))), ((int)(((byte)(127)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(218, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(36, 31);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(106)))), ((int)(((byte)(127)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(218, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(36, 31);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(106)))), ((int)(((byte)(127)))));
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(218, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(36, 31);
            this.panel3.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(106)))), ((int)(((byte)(127)))));
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(218, 226);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(36, 31);
            this.panel4.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel5.Controls.Add(puedeAccederClientesLabel);
            this.panel5.Controls.Add(this.puedeAccederClientesCheckBox);
            this.panel5.Controls.Add(this.puedeAccederFacturasCheckBox);
            this.panel5.Controls.Add(puedeAccederFacturasLabel);
            this.panel5.Controls.Add(this.puedeAccederProductosCheckBox);
            this.panel5.Controls.Add(puedeAccederProductosLabel);
            this.panel5.Controls.Add(this.puedeAccederReportesCheckBox);
            this.panel5.Controls.Add(puedeAccederReportesLabel);
            this.panel5.Location = new System.Drawing.Point(218, 309);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(390, 133);
            this.panel5.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "Usuarios";
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(contrasenaLabel);
            this.Controls.Add(this.contrasenaTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.listaUsuariosBindingNavigator);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormUsuarios";
            this.Text = "FormReporteUsuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosBindingNavigator)).EndInit();
            this.listaUsuariosBindingNavigator.ResumeLayout(false);
            this.listaUsuariosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosBindingSource1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaUsuariosBindingSource;
        private System.Windows.Forms.BindingNavigator listaUsuariosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listaUsuariosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource listaUsuariosBindingSource1;
        private System.Windows.Forms.CheckBox puedeAccederClientesCheckBox;
        private System.Windows.Forms.CheckBox puedeAccederFacturasCheckBox;
        private System.Windows.Forms.CheckBox puedeAccederProductosCheckBox;
        private System.Windows.Forms.CheckBox puedeAccederReportesCheckBox;
        private System.Windows.Forms.TextBox contrasenaTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
    }
}