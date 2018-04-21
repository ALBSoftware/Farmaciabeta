namespace Farmaciabeta
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.lblCargo = new System.Windows.Forms.LinkLabel();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.ImgUsuario = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnReportes = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lbMantenimientoProductos = new System.Windows.Forms.Label();
            this.IconoMinimizar = new System.Windows.Forms.PictureBox();
            this.IconoRestaurar = new System.Windows.Forms.PictureBox();
            this.IconoMazimizar = new System.Windows.Forms.PictureBox();
            this.IconoCerrar = new System.Windows.Forms.PictureBox();
            this.btnSlider = new System.Windows.Forms.PictureBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgUsuario)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMazimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MenuVertical.Controls.Add(this.btnUsuarios);
            this.MenuVertical.Controls.Add(this.lblCargo);
            this.MenuVertical.Controls.Add(this.lbApellido);
            this.MenuVertical.Controls.Add(this.lbNombre);
            this.MenuVertical.Controls.Add(this.btnEmpleados);
            this.MenuVertical.Controls.Add(this.btnProveedores);
            this.MenuVertical.Controls.Add(this.ImgUsuario);
            this.MenuVertical.Controls.Add(this.lblFecha);
            this.MenuVertical.Controls.Add(this.btnReportes);
            this.MenuVertical.Controls.Add(this.lblHora);
            this.MenuVertical.Controls.Add(this.button2);
            this.MenuVertical.Controls.Add(this.button1);
            this.MenuVertical.Controls.Add(this.btnProducto);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 650);
            this.MenuVertical.TabIndex = 3;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(-3, 386);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(250, 40);
            this.btnUsuarios.TabIndex = 14;
            this.btnUsuarios.Text = "      &Usuarios          (F7)";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            this.btnUsuarios.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnUsuarios_KeyDown);
            // 
            // lblCargo
            // 
            this.lblCargo.ActiveLinkColor = System.Drawing.Color.White;
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.White;
            this.lblCargo.LinkColor = System.Drawing.Color.White;
            this.lblCargo.Location = new System.Drawing.Point(82, 19);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(76, 25);
            this.lblCargo.TabIndex = 13;
            this.lblCargo.TabStop = true;
            this.lblCargo.Text = "Cargo";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.ForeColor = System.Drawing.Color.White;
            this.lbApellido.Location = new System.Drawing.Point(84, 71);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(65, 19);
            this.lbApellido.TabIndex = 11;
            this.lbApellido.Text = "Apellido";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.White;
            this.lbNombre.Location = new System.Drawing.Point(83, 50);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(81, 21);
            this.lbNombre.TabIndex = 10;
            this.lbNombre.Text = "Nombre";
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 248);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(250, 40);
            this.btnEmpleados.TabIndex = 9;
            this.btnEmpleados.Text = "     &Empleados     (F4)";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            // 
            // btnProveedores
            // 
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Image")));
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(-3, 294);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(250, 40);
            this.btnProveedores.TabIndex = 8;
            this.btnProveedores.Text = "       &Suplidores      (F5)";
            this.btnProveedores.UseVisualStyleBackColor = true;
            // 
            // ImgUsuario
            // 
            this.ImgUsuario.Image = ((System.Drawing.Image)(resources.GetObject("ImgUsuario.Image")));
            this.ImgUsuario.Location = new System.Drawing.Point(0, 0);
            this.ImgUsuario.Name = "ImgUsuario";
            this.ImgUsuario.Size = new System.Drawing.Size(77, 94);
            this.ImgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgUsuario.TabIndex = 7;
            this.ImgUsuario.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(22, 558);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(59, 21);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha";
            // 
            // btnReportes
            // 
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(-3, 340);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(250, 40);
            this.btnReportes.TabIndex = 6;
            this.btnReportes.Text = "      &Reportes         (F6)";
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(3, 484);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(202, 74);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "HORA";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "     &Clientes           (F3)";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "      &Ventas             (F2)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnProducto
            // 
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.ForeColor = System.Drawing.Color.White;
            this.btnProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnProducto.Image")));
            this.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.Location = new System.Drawing.Point(0, 110);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(250, 40);
            this.btnProducto.TabIndex = 1;
            this.btnProducto.Text = "      &Productos        (F1)";
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            this.btnProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnProducto_KeyDown);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BarraTitulo.Controls.Add(this.lblUsuario);
            this.BarraTitulo.Controls.Add(this.lbMantenimientoProductos);
            this.BarraTitulo.Controls.Add(this.IconoMinimizar);
            this.BarraTitulo.Controls.Add(this.IconoRestaurar);
            this.BarraTitulo.Controls.Add(this.IconoMazimizar);
            this.BarraTitulo.Controls.Add(this.IconoCerrar);
            this.BarraTitulo.Controls.Add(this.btnSlider);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(250, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1050, 50);
            this.BarraTitulo.TabIndex = 4;
            this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTitulo_Paint);
            this.BarraTitulo.DoubleClick += new System.EventHandler(this.BarraTitulo_DoubleClick);
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblUsuario.Location = new System.Drawing.Point(362, 14);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(300, 30);
            this.lblUsuario.TabIndex = 20;
            this.lblUsuario.Text = "Mantenimiento Usuarios";
            this.lblUsuario.Visible = false;
            // 
            // lbMantenimientoProductos
            // 
            this.lbMantenimientoProductos.AutoSize = true;
            this.lbMantenimientoProductos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMantenimientoProductos.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lbMantenimientoProductos.Location = new System.Drawing.Point(362, 14);
            this.lbMantenimientoProductos.Name = "lbMantenimientoProductos";
            this.lbMantenimientoProductos.Size = new System.Drawing.Size(322, 30);
            this.lbMantenimientoProductos.TabIndex = 19;
            this.lbMantenimientoProductos.Text = "Mantenimiento Productos";
            this.lbMantenimientoProductos.Visible = false;
            // 
            // IconoMinimizar
            // 
            this.IconoMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconoMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconoMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("IconoMinimizar.Image")));
            this.IconoMinimizar.Location = new System.Drawing.Point(970, 3);
            this.IconoMinimizar.Name = "IconoMinimizar";
            this.IconoMinimizar.Size = new System.Drawing.Size(20, 20);
            this.IconoMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoMinimizar.TabIndex = 2;
            this.IconoMinimizar.TabStop = false;
            this.IconoMinimizar.Click += new System.EventHandler(this.IconoMinimizar_Click);
            // 
            // IconoRestaurar
            // 
            this.IconoRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconoRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconoRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("IconoRestaurar.Image")));
            this.IconoRestaurar.Location = new System.Drawing.Point(996, 3);
            this.IconoRestaurar.Name = "IconoRestaurar";
            this.IconoRestaurar.Size = new System.Drawing.Size(20, 20);
            this.IconoRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoRestaurar.TabIndex = 3;
            this.IconoRestaurar.TabStop = false;
            this.IconoRestaurar.Visible = false;
            this.IconoRestaurar.Click += new System.EventHandler(this.IconoRestaurar_Click);
            // 
            // IconoMazimizar
            // 
            this.IconoMazimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconoMazimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconoMazimizar.Image = ((System.Drawing.Image)(resources.GetObject("IconoMazimizar.Image")));
            this.IconoMazimizar.Location = new System.Drawing.Point(996, 3);
            this.IconoMazimizar.Name = "IconoMazimizar";
            this.IconoMazimizar.Size = new System.Drawing.Size(20, 20);
            this.IconoMazimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoMazimizar.TabIndex = 2;
            this.IconoMazimizar.TabStop = false;
            this.IconoMazimizar.Click += new System.EventHandler(this.IconoMazimizar_Click);
            // 
            // IconoCerrar
            // 
            this.IconoCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconoCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconoCerrar.Image = ((System.Drawing.Image)(resources.GetObject("IconoCerrar.Image")));
            this.IconoCerrar.Location = new System.Drawing.Point(1022, 3);
            this.IconoCerrar.Name = "IconoCerrar";
            this.IconoCerrar.Size = new System.Drawing.Size(20, 20);
            this.IconoCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoCerrar.TabIndex = 1;
            this.IconoCerrar.TabStop = false;
            this.IconoCerrar.Click += new System.EventHandler(this.IconoCerrar_Click);
            // 
            // btnSlider
            // 
            this.btnSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlider.Image = ((System.Drawing.Image)(resources.GetObject("btnSlider.Image")));
            this.btnSlider.Location = new System.Drawing.Point(6, 9);
            this.btnSlider.Name = "btnSlider";
            this.btnSlider.Size = new System.Drawing.Size(35, 35);
            this.btnSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlider.TabIndex = 0;
            this.btnSlider.TabStop = false;
            this.btnSlider.Click += new System.EventHandler(this.btnSlider_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(250, 50);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1050, 600);
            this.PanelContenedor.TabIndex = 5;
            this.PanelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenedor_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgUsuario)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMazimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnSlider;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox IconoMinimizar;
        private System.Windows.Forms.PictureBox IconoRestaurar;
        private System.Windows.Forms.PictureBox IconoMazimizar;
        private System.Windows.Forms.PictureBox IconoCerrar;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ImgUsuario;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbMantenimientoProductos;
        private System.Windows.Forms.LinkLabel lblCargo;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Label lblUsuario;
    }
}

