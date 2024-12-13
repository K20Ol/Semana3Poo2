namespace Publicaciones
{
    partial class Principal
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
            this.pndPrincipal = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTitulos = new System.Windows.Forms.Button();
            this.btnAutores = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnDescuentos = new System.Windows.Forms.Button();
            this.btnProgramacionRegalias = new System.Windows.Forms.Button();
            this.btnEditoriales = new System.Windows.Forms.Button();
            this.btnTiendas = new System.Windows.Forms.Button();
            this.btnPuestosTrabajo = new System.Windows.Forms.Button();
            this.btnAutoresTitulos = new System.Windows.Forms.Button();
            this.btnInformacionEditorial = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pndPrincipal.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pndPrincipal
            // 
            this.pndPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pndPrincipal.Controls.Add(this.lblTitulo);
            this.pndPrincipal.Dock = System.Windows.Forms.DockStyle.Right;
            this.pndPrincipal.Location = new System.Drawing.Point(228, 0);
            this.pndPrincipal.Name = "pndPrincipal";
            this.pndPrincipal.Size = new System.Drawing.Size(572, 450);
            this.pndPrincipal.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAutoresTitulos);
            this.panel2.Controls.Add(this.btnInformacionEditorial);
            this.panel2.Controls.Add(this.btnPuestosTrabajo);
            this.panel2.Controls.Add(this.btnProgramacionRegalias);
            this.panel2.Controls.Add(this.btnEditoriales);
            this.panel2.Controls.Add(this.btnTiendas);
            this.panel2.Controls.Add(this.btnDescuentos);
            this.panel2.Controls.Add(this.btnVentas);
            this.panel2.Controls.Add(this.btnEmpleados);
            this.panel2.Controls.Add(this.btnAutores);
            this.panel2.Controls.Add(this.btnTitulos);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 450);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 73);
            this.panel3.TabIndex = 0;
            // 
            // btnTitulos
            // 
            this.btnTitulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTitulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitulos.Location = new System.Drawing.Point(0, 73);
            this.btnTitulos.Name = "btnTitulos";
            this.btnTitulos.Size = new System.Drawing.Size(228, 35);
            this.btnTitulos.TabIndex = 2;
            this.btnTitulos.Text = "Titulos";
            this.btnTitulos.UseVisualStyleBackColor = true;
            this.btnTitulos.Click += new System.EventHandler(this.btnTitulos_Click);
            // 
            // btnAutores
            // 
            this.btnAutores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutores.Location = new System.Drawing.Point(0, 108);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(228, 37);
            this.btnAutores.TabIndex = 3;
            this.btnAutores.Text = "Autores";
            this.btnAutores.UseVisualStyleBackColor = true;
            this.btnAutores.Click += new System.EventHandler(this.btnAutores_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Principal";
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Location = new System.Drawing.Point(0, 145);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(228, 33);
            this.btnEmpleados.TabIndex = 4;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Location = new System.Drawing.Point(0, 178);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(228, 33);
            this.btnVentas.TabIndex = 5;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnDescuentos
            // 
            this.btnDescuentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDescuentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescuentos.Location = new System.Drawing.Point(0, 211);
            this.btnDescuentos.Name = "btnDescuentos";
            this.btnDescuentos.Size = new System.Drawing.Size(228, 33);
            this.btnDescuentos.TabIndex = 6;
            this.btnDescuentos.Text = "Descuentos";
            this.btnDescuentos.UseVisualStyleBackColor = true;
            this.btnDescuentos.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnProgramacionRegalias
            // 
            this.btnProgramacionRegalias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProgramacionRegalias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgramacionRegalias.Location = new System.Drawing.Point(0, 310);
            this.btnProgramacionRegalias.Name = "btnProgramacionRegalias";
            this.btnProgramacionRegalias.Size = new System.Drawing.Size(228, 33);
            this.btnProgramacionRegalias.TabIndex = 9;
            this.btnProgramacionRegalias.Text = "Regalías";
            this.btnProgramacionRegalias.UseVisualStyleBackColor = true;
            this.btnProgramacionRegalias.Click += new System.EventHandler(this.btnProgramacionRegalias_Click);
            // 
            // btnEditoriales
            // 
            this.btnEditoriales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditoriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditoriales.Location = new System.Drawing.Point(0, 277);
            this.btnEditoriales.Name = "btnEditoriales";
            this.btnEditoriales.Size = new System.Drawing.Size(228, 33);
            this.btnEditoriales.TabIndex = 8;
            this.btnEditoriales.Text = "Editoriales";
            this.btnEditoriales.UseVisualStyleBackColor = true;
            this.btnEditoriales.Click += new System.EventHandler(this.btnEditoriales_Click);
            // 
            // btnTiendas
            // 
            this.btnTiendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTiendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiendas.Location = new System.Drawing.Point(0, 244);
            this.btnTiendas.Name = "btnTiendas";
            this.btnTiendas.Size = new System.Drawing.Size(228, 33);
            this.btnTiendas.TabIndex = 7;
            this.btnTiendas.Text = "Tiendas";
            this.btnTiendas.UseVisualStyleBackColor = true;
            this.btnTiendas.Click += new System.EventHandler(this.btnTiendas_Click);
            // 
            // btnPuestosTrabajo
            // 
            this.btnPuestosTrabajo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPuestosTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuestosTrabajo.Location = new System.Drawing.Point(0, 343);
            this.btnPuestosTrabajo.Name = "btnPuestosTrabajo";
            this.btnPuestosTrabajo.Size = new System.Drawing.Size(228, 33);
            this.btnPuestosTrabajo.TabIndex = 10;
            this.btnPuestosTrabajo.Text = "Puestos de trabajo";
            this.btnPuestosTrabajo.UseVisualStyleBackColor = true;
            this.btnPuestosTrabajo.Click += new System.EventHandler(this.btnPuestosTrabajo_Click);
            // 
            // btnAutoresTitulos
            // 
            this.btnAutoresTitulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAutoresTitulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoresTitulos.Location = new System.Drawing.Point(0, 409);
            this.btnAutoresTitulos.Name = "btnAutoresTitulos";
            this.btnAutoresTitulos.Size = new System.Drawing.Size(228, 33);
            this.btnAutoresTitulos.TabIndex = 12;
            this.btnAutoresTitulos.Text = "Autores por Título";
            this.btnAutoresTitulos.UseVisualStyleBackColor = true;
            this.btnAutoresTitulos.Click += new System.EventHandler(this.btnAutoresTitulos_Click);
            // 
            // btnInformacionEditorial
            // 
            this.btnInformacionEditorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformacionEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacionEditorial.Location = new System.Drawing.Point(0, 376);
            this.btnInformacionEditorial.Name = "btnInformacionEditorial";
            this.btnInformacionEditorial.Size = new System.Drawing.Size(228, 33);
            this.btnInformacionEditorial.TabIndex = 11;
            this.btnInformacionEditorial.Text = "Información Editorial";
            this.btnInformacionEditorial.UseVisualStyleBackColor = true;
            this.btnInformacionEditorial.Click += new System.EventHandler(this.btnInformacionEditorial_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(32, 155);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitulo.Size = new System.Drawing.Size(505, 130);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "BIENVENIDO AL MENU PRINCIPAL DE LA BIBLIOTECA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pndPrincipal);
            this.Name = "Principal";
            this.Text = "Principal";
            this.pndPrincipal.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pndPrincipal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAutores;
        private System.Windows.Forms.Button btnTitulos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDescuentos;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnPuestosTrabajo;
        private System.Windows.Forms.Button btnProgramacionRegalias;
        private System.Windows.Forms.Button btnEditoriales;
        private System.Windows.Forms.Button btnTiendas;
        private System.Windows.Forms.Button btnAutoresTitulos;
        private System.Windows.Forms.Button btnInformacionEditorial;
        private System.Windows.Forms.Label lblTitulo;
    }
}

