
namespace CapaVista
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TablaProductos = new System.Windows.Forms.DataGridView();
            this.TbxCodigo = new System.Windows.Forms.TextBox();
            this.TbxProducto = new System.Windows.Forms.TextBox();
            this.TbxExistencias = new System.Windows.Forms.TextBox();
            this.TbxPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnNuevo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TabBase = new System.Windows.Forms.TabControl();
            this.TabSucA = new System.Windows.Forms.TabPage();
            this.TabSucB = new System.Windows.Forms.TabPage();
            this.TablaProductos2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaProductos)).BeginInit();
            this.TabBase.SuspendLayout();
            this.TabSucA.SuspendLayout();
            this.TabSucB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaProductos2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 64);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(653, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Creado por Miguel Angel Calderon Cornejo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Active = false;
            this.BtnGuardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuardar.BorderRadius = 0;
            this.BtnGuardar.ButtonText = "Guardar";
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnGuardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Iconimage")));
            this.BtnGuardar.Iconimage_right = null;
            this.BtnGuardar.Iconimage_right_Selected = null;
            this.BtnGuardar.Iconimage_Selected = null;
            this.BtnGuardar.IconMarginLeft = 0;
            this.BtnGuardar.IconMarginRight = 0;
            this.BtnGuardar.IconRightVisible = true;
            this.BtnGuardar.IconRightZoom = 0D;
            this.BtnGuardar.IconVisible = true;
            this.BtnGuardar.IconZoom = 90D;
            this.BtnGuardar.IsTab = false;
            this.BtnGuardar.Location = new System.Drawing.Point(720, 82);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnGuardar.selected = false;
            this.BtnGuardar.Size = new System.Drawing.Size(141, 35);
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Textcolor = System.Drawing.Color.White;
            this.BtnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Active = false;
            this.BtnEditar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(109)))), ((int)(((byte)(187)))));
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditar.BorderRadius = 0;
            this.BtnEditar.ButtonText = "Editar";
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEditar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnEditar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Iconimage")));
            this.BtnEditar.Iconimage_right = null;
            this.BtnEditar.Iconimage_right_Selected = null;
            this.BtnEditar.Iconimage_Selected = null;
            this.BtnEditar.IconMarginLeft = 0;
            this.BtnEditar.IconMarginRight = 0;
            this.BtnEditar.IconRightVisible = true;
            this.BtnEditar.IconRightZoom = 0D;
            this.BtnEditar.IconVisible = true;
            this.BtnEditar.IconZoom = 90D;
            this.BtnEditar.IsTab = false;
            this.BtnEditar.Location = new System.Drawing.Point(720, 133);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(109)))), ((int)(((byte)(187)))));
            this.BtnEditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.BtnEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEditar.selected = false;
            this.BtnEditar.Size = new System.Drawing.Size(141, 35);
            this.BtnEditar.TabIndex = 3;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Textcolor = System.Drawing.Color.White;
            this.BtnEditar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Active = false;
            this.BtnEliminar.Activecolor = System.Drawing.Color.Maroon;
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminar.BorderRadius = 0;
            this.BtnEliminar.ButtonText = "Eliminar";
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnEliminar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Iconimage")));
            this.BtnEliminar.Iconimage_right = null;
            this.BtnEliminar.Iconimage_right_Selected = null;
            this.BtnEliminar.Iconimage_Selected = null;
            this.BtnEliminar.IconMarginLeft = 0;
            this.BtnEliminar.IconMarginRight = 0;
            this.BtnEliminar.IconRightVisible = true;
            this.BtnEliminar.IconRightZoom = 0D;
            this.BtnEliminar.IconVisible = true;
            this.BtnEliminar.IconZoom = 90D;
            this.BtnEliminar.IsTab = false;
            this.BtnEliminar.Location = new System.Drawing.Point(911, 130);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnEliminar.OnHovercolor = System.Drawing.Color.Maroon;
            this.BtnEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEliminar.selected = false;
            this.BtnEliminar.Size = new System.Drawing.Size(141, 35);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Textcolor = System.Drawing.Color.White;
            this.BtnEliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // TablaProductos
            // 
            this.TablaProductos.AllowUserToAddRows = false;
            this.TablaProductos.AllowUserToDeleteRows = false;
            this.TablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaProductos.ColumnHeadersVisible = false;
            this.TablaProductos.Location = new System.Drawing.Point(3, 3);
            this.TablaProductos.Name = "TablaProductos";
            this.TablaProductos.ReadOnly = true;
            this.TablaProductos.RowHeadersVisible = false;
            this.TablaProductos.RowHeadersWidth = 62;
            this.TablaProductos.RowTemplate.Height = 28;
            this.TablaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaProductos.Size = new System.Drawing.Size(633, 290);
            this.TablaProductos.TabIndex = 5;
            this.TablaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FrmProducto_Load_CellContentClick);
            // 
            // TbxCodigo
            // 
            this.TbxCodigo.Location = new System.Drawing.Point(106, 142);
            this.TbxCodigo.Name = "TbxCodigo";
            this.TbxCodigo.Size = new System.Drawing.Size(203, 26);
            this.TbxCodigo.TabIndex = 6;
            // 
            // TbxProducto
            // 
            this.TbxProducto.Location = new System.Drawing.Point(106, 87);
            this.TbxProducto.Name = "TbxProducto";
            this.TbxProducto.Size = new System.Drawing.Size(204, 26);
            this.TbxProducto.TabIndex = 7;
            // 
            // TbxExistencias
            // 
            this.TbxExistencias.Location = new System.Drawing.Point(442, 87);
            this.TbxExistencias.Name = "TbxExistencias";
            this.TbxExistencias.Size = new System.Drawing.Size(203, 26);
            this.TbxExistencias.TabIndex = 8;
            // 
            // TbxPrecio
            // 
            this.TbxPrecio.Location = new System.Drawing.Point(442, 142);
            this.TbxPrecio.Name = "TbxPrecio";
            this.TbxPrecio.Size = new System.Drawing.Size(203, 26);
            this.TbxPrecio.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Existencias";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Precio";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.ActiveBorderThickness = 1;
            this.BtnNuevo.ActiveCornerRadius = 20;
            this.BtnNuevo.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnNuevo.ActiveForecolor = System.Drawing.Color.White;
            this.BtnNuevo.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.BtnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.BackgroundImage")));
            this.BtnNuevo.ButtonText = "Limpiar";
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnNuevo.IdleBorderThickness = 1;
            this.BtnNuevo.IdleCornerRadius = 20;
            this.BtnNuevo.IdleFillColor = System.Drawing.Color.White;
            this.BtnNuevo.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BtnNuevo.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnNuevo.Location = new System.Drawing.Point(911, 72);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(5);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(141, 45);
            this.BtnNuevo.TabIndex = 14;
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // TabBase
            // 
            this.TabBase.AccessibleName = "";
            this.TabBase.Controls.Add(this.TabSucA);
            this.TabBase.Controls.Add(this.TabSucB);
            this.TabBase.Location = new System.Drawing.Point(26, 187);
            this.TabBase.Name = "TabBase";
            this.TabBase.SelectedIndex = 0;
            this.TabBase.Size = new System.Drawing.Size(647, 328);
            this.TabBase.TabIndex = 16;
            this.TabBase.SelectedIndexChanged += new System.EventHandler(this.TabBase_SelectedIndexChanged);
            // 
            // TabSucA
            // 
            this.TabSucA.Controls.Add(this.TablaProductos);
            this.TabSucA.Location = new System.Drawing.Point(4, 29);
            this.TabSucA.Name = "TabSucA";
            this.TabSucA.Padding = new System.Windows.Forms.Padding(3);
            this.TabSucA.Size = new System.Drawing.Size(639, 295);
            this.TabSucA.TabIndex = 0;
            this.TabSucA.Text = "Sucursal A";
            this.TabSucA.UseVisualStyleBackColor = true;
            // 
            // TabSucB
            // 
            this.TabSucB.Controls.Add(this.TablaProductos2);
            this.TabSucB.Location = new System.Drawing.Point(4, 29);
            this.TabSucB.Name = "TabSucB";
            this.TabSucB.Padding = new System.Windows.Forms.Padding(3);
            this.TabSucB.Size = new System.Drawing.Size(637, 295);
            this.TabSucB.TabIndex = 1;
            this.TabSucB.Text = "Sucursal B";
            this.TabSucB.UseVisualStyleBackColor = true;
            // 
            // TablaProductos2
            // 
            this.TablaProductos2.AllowUserToAddRows = false;
            this.TablaProductos2.AllowUserToDeleteRows = false;
            this.TablaProductos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaProductos2.ColumnHeadersVisible = false;
            this.TablaProductos2.Location = new System.Drawing.Point(0, 3);
            this.TablaProductos2.Name = "TablaProductos2";
            this.TablaProductos2.ReadOnly = true;
            this.TablaProductos2.RowHeadersVisible = false;
            this.TablaProductos2.RowHeadersWidth = 62;
            this.TablaProductos2.RowTemplate.Height = 28;
            this.TablaProductos2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaProductos2.Size = new System.Drawing.Size(634, 289);
            this.TablaProductos2.TabIndex = 0;
            this.TablaProductos2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 545);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TabBase);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxPrecio);
            this.Controls.Add(this.TbxExistencias);
            this.Controls.Add(this.TbxProducto);
            this.Controls.Add(this.TbxCodigo);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaProductos)).EndInit();
            this.TabBase.ResumeLayout(false);
            this.TabSucA.ResumeLayout(false);
            this.TabSucB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaProductos2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnGuardar;
        private Bunifu.Framework.UI.BunifuFlatButton BtnEditar;
        private Bunifu.Framework.UI.BunifuFlatButton BtnEliminar;
        private System.Windows.Forms.DataGridView TablaProductos;
        private System.Windows.Forms.TextBox TbxCodigo;
        private System.Windows.Forms.TextBox TbxProducto;
        private System.Windows.Forms.TextBox TbxExistencias;
        private System.Windows.Forms.TextBox TbxPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnNuevo;
        private System.Windows.Forms.TabControl TabBase;
        private System.Windows.Forms.TabPage TabSucA;
        private System.Windows.Forms.TabPage TabSucB;
        private System.Windows.Forms.DataGridView TablaProductos2;
    }
}