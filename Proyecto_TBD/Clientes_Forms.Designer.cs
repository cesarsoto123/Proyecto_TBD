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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nombre_cliente_txt = new System.Windows.Forms.TextBox();
            this.clave_cliente_txt = new System.Windows.Forms.TextBox();
            this.telefono_txt = new System.Windows.Forms.TextBox();
            this.direccion_txt = new System.Windows.Forms.TextBox();
            this.agregar_btn = new System.Windows.Forms.Button();
            this.mostrar_btn = new System.Windows.Forms.Button();
            this.actualizar_btn = new System.Windows.Forms.Button();
            this.eliminar_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direccion:";
            // 
            // nombre_cliente_txt
            // 
            this.nombre_cliente_txt.Location = new System.Drawing.Point(143, 35);
            this.nombre_cliente_txt.Name = "nombre_cliente_txt";
            this.nombre_cliente_txt.Size = new System.Drawing.Size(195, 26);
            this.nombre_cliente_txt.TabIndex = 4;
            // 
            // clave_cliente_txt
            // 
            this.clave_cliente_txt.Location = new System.Drawing.Point(143, 79);
            this.clave_cliente_txt.Name = "clave_cliente_txt";
            this.clave_cliente_txt.Size = new System.Drawing.Size(141, 26);
            this.clave_cliente_txt.TabIndex = 5;
            // 
            // telefono_txt
            // 
            this.telefono_txt.Location = new System.Drawing.Point(143, 129);
            this.telefono_txt.Name = "telefono_txt";
            this.telefono_txt.Size = new System.Drawing.Size(141, 26);
            this.telefono_txt.TabIndex = 6;
            // 
            // direccion_txt
            // 
            this.direccion_txt.Location = new System.Drawing.Point(143, 177);
            this.direccion_txt.Name = "direccion_txt";
            this.direccion_txt.Size = new System.Drawing.Size(195, 26);
            this.direccion_txt.TabIndex = 7;
            // 
            // agregar_btn
            // 
            this.agregar_btn.Location = new System.Drawing.Point(16, 306);
            this.agregar_btn.Name = "agregar_btn";
            this.agregar_btn.Size = new System.Drawing.Size(94, 33);
            this.agregar_btn.TabIndex = 8;
            this.agregar_btn.Text = "Agregar";
            this.agregar_btn.UseVisualStyleBackColor = true;
            // 
            // mostrar_btn
            // 
            this.mostrar_btn.Location = new System.Drawing.Point(160, 306);
            this.mostrar_btn.Name = "mostrar_btn";
            this.mostrar_btn.Size = new System.Drawing.Size(94, 33);
            this.mostrar_btn.TabIndex = 9;
            this.mostrar_btn.Text = "Mostrar";
            this.mostrar_btn.UseVisualStyleBackColor = true;
            // 
            // actualizar_btn
            // 
            this.actualizar_btn.Location = new System.Drawing.Point(307, 306);
            this.actualizar_btn.Name = "actualizar_btn";
            this.actualizar_btn.Size = new System.Drawing.Size(94, 33);
            this.actualizar_btn.TabIndex = 10;
            this.actualizar_btn.Text = "Actualizar";
            this.actualizar_btn.UseVisualStyleBackColor = true;
            // 
            // eliminar_btn
            // 
            this.eliminar_btn.Location = new System.Drawing.Point(463, 306);
            this.eliminar_btn.Name = "eliminar_btn";
            this.eliminar_btn.Size = new System.Drawing.Size(94, 33);
            this.eliminar_btn.TabIndex = 11;
            this.eliminar_btn.Text = "Eliminar";
            this.eliminar_btn.UseVisualStyleBackColor = true;
            // 
            // Clientes_Forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 729);
            this.Controls.Add(this.eliminar_btn);
            this.Controls.Add(this.actualizar_btn);
            this.Controls.Add(this.mostrar_btn);
            this.Controls.Add(this.agregar_btn);
            this.Controls.Add(this.direccion_txt);
            this.Controls.Add(this.telefono_txt);
            this.Controls.Add(this.clave_cliente_txt);
            this.Controls.Add(this.nombre_cliente_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Clientes_Forms";
            this.Text = "Clientes_Forms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombre_cliente_txt;
        private System.Windows.Forms.TextBox clave_cliente_txt;
        private System.Windows.Forms.TextBox telefono_txt;
        private System.Windows.Forms.TextBox direccion_txt;
        private System.Windows.Forms.Button agregar_btn;
        private System.Windows.Forms.Button mostrar_btn;
        private System.Windows.Forms.Button actualizar_btn;
        private System.Windows.Forms.Button eliminar_btn;
    }
}