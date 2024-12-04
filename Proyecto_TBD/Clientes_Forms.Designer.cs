namespace Proyecto_TBD
{
    partial class Clientes_Forms
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
            this.label1 = new System.Windows.Forms.Label();
            this.clave_cliente_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nombre_Tbx = new System.Windows.Forms.TextBox();
            this.claveCliente_Tbx = new System.Windows.Forms.TextBox();
            this.telefono_Tbx = new System.Windows.Forms.TextBox();
            this.direccion_Tbx = new System.Windows.Forms.TextBox();
            this.agregar_Btn = new System.Windows.Forms.Button();
            this.actualizar_Btn = new System.Windows.Forms.Button();
            this.eliminar_Btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.salir_Btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cliente_DGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cliente_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // clave_cliente_lbl
            // 
            this.clave_cliente_lbl.AutoSize = true;
            this.clave_cliente_lbl.Location = new System.Drawing.Point(43, 85);
            this.clave_cliente_lbl.Name = "clave_cliente_lbl";
            this.clave_cliente_lbl.Size = new System.Drawing.Size(84, 16);
            this.clave_cliente_lbl.TabIndex = 1;
            this.clave_cliente_lbl.Text = "Clave cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direccion:";
            // 
            // nombre_Tbx
            // 
            this.nombre_Tbx.Location = new System.Drawing.Point(159, 124);
            this.nombre_Tbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombre_Tbx.Name = "nombre_Tbx";
            this.nombre_Tbx.Size = new System.Drawing.Size(174, 22);
            this.nombre_Tbx.TabIndex = 4;
            // 
            // claveCliente_Tbx
            // 
            this.claveCliente_Tbx.Location = new System.Drawing.Point(159, 85);
            this.claveCliente_Tbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.claveCliente_Tbx.Name = "claveCliente_Tbx";
            this.claveCliente_Tbx.Size = new System.Drawing.Size(126, 22);
            this.claveCliente_Tbx.TabIndex = 5;
            // 
            // telefono_Tbx
            // 
            this.telefono_Tbx.Location = new System.Drawing.Point(159, 164);
            this.telefono_Tbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telefono_Tbx.Name = "telefono_Tbx";
            this.telefono_Tbx.Size = new System.Drawing.Size(126, 22);
            this.telefono_Tbx.TabIndex = 6;
            // 
            // direccion_Tbx
            // 
            this.direccion_Tbx.Location = new System.Drawing.Point(159, 202);
            this.direccion_Tbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.direccion_Tbx.Name = "direccion_Tbx";
            this.direccion_Tbx.Size = new System.Drawing.Size(174, 22);
            this.direccion_Tbx.TabIndex = 7;
            // 
            // agregar_Btn
            // 
            this.agregar_Btn.Location = new System.Drawing.Point(80, 273);
            this.agregar_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agregar_Btn.Name = "agregar_Btn";
            this.agregar_Btn.Size = new System.Drawing.Size(96, 29);
            this.agregar_Btn.TabIndex = 8;
            this.agregar_Btn.Text = "AGREGAR";
            this.agregar_Btn.UseVisualStyleBackColor = true;
            this.agregar_Btn.Click += new System.EventHandler(this.agregar_Btn_Click);
            // 
            // actualizar_Btn
            // 
            this.actualizar_Btn.BackColor = System.Drawing.Color.White;
            this.actualizar_Btn.Location = new System.Drawing.Point(192, 273);
            this.actualizar_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.actualizar_Btn.Name = "actualizar_Btn";
            this.actualizar_Btn.Size = new System.Drawing.Size(129, 29);
            this.actualizar_Btn.TabIndex = 10;
            this.actualizar_Btn.Text = "ACTUALIZAR";
            this.actualizar_Btn.UseVisualStyleBackColor = false;
            this.actualizar_Btn.Click += new System.EventHandler(this.actualizar_Btn_Click);
            // 
            // eliminar_Btn
            // 
            this.eliminar_Btn.Location = new System.Drawing.Point(346, 273);
            this.eliminar_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eliminar_Btn.Name = "eliminar_Btn";
            this.eliminar_Btn.Size = new System.Drawing.Size(84, 29);
            this.eliminar_Btn.TabIndex = 11;
            this.eliminar_Btn.Text = "ELIMINAR";
            this.eliminar_Btn.UseVisualStyleBackColor = true;
            this.eliminar_Btn.Click += new System.EventHandler(this.eliminar_Btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pardini Felix Bruno Alan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Orosco Bustamamante Andres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Soto Belmonte Cesar Alejandro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tarazón Alvarado Marcos";
            // 
            // salir_Btn
            // 
            this.salir_Btn.Location = new System.Drawing.Point(455, 273);
            this.salir_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salir_Btn.Name = "salir_Btn";
            this.salir_Btn.Size = new System.Drawing.Size(84, 29);
            this.salir_Btn.TabIndex = 16;
            this.salir_Btn.Text = "SALIR";
            this.salir_Btn.UseVisualStyleBackColor = true;
            this.salir_Btn.Click += new System.EventHandler(this.salir_Btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.cliente_DGV);
            this.panel1.Location = new System.Drawing.Point(12, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 240);
            this.panel1.TabIndex = 17;
            // 
            // cliente_DGV
            // 
            this.cliente_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cliente_DGV.Location = new System.Drawing.Point(3, 0);
            this.cliente_DGV.Name = "cliente_DGV";
            this.cliente_DGV.RowHeadersWidth = 51;
            this.cliente_DGV.RowTemplate.Height = 24;
            this.cliente_DGV.Size = new System.Drawing.Size(684, 243);
            this.cliente_DGV.TabIndex = 0;
            // 
            // Clientes_Forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 587);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.salir_Btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.eliminar_Btn);
            this.Controls.Add(this.actualizar_Btn);
            this.Controls.Add(this.agregar_Btn);
            this.Controls.Add(this.direccion_Tbx);
            this.Controls.Add(this.telefono_Tbx);
            this.Controls.Add(this.claveCliente_Tbx);
            this.Controls.Add(this.nombre_Tbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clave_cliente_lbl);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Clientes_Forms";
            this.Text = "Clientes_Forms";
            this.Load += new System.EventHandler(this.Clientes_Forms_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cliente_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label clave_cliente_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombre_Tbx;
        private System.Windows.Forms.TextBox claveCliente_Tbx;
        private System.Windows.Forms.TextBox telefono_Tbx;
        private System.Windows.Forms.TextBox direccion_Tbx;
        private System.Windows.Forms.Button agregar_Btn;
        private System.Windows.Forms.Button actualizar_Btn;
        private System.Windows.Forms.Button eliminar_Btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button salir_Btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView cliente_DGV;
    }
}