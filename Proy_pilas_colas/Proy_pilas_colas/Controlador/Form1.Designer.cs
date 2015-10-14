namespace Proy_pilas_colas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbPila = new System.Windows.Forms.ListBox();
            this.lbCola = new System.Windows.Forms.ListBox();
            this.lbTurnoPila = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbTurnoCola = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPila
            // 
            this.lbPila.FormattingEnabled = true;
            this.lbPila.Location = new System.Drawing.Point(33, 79);
            this.lbPila.Name = "lbPila";
            this.lbPila.Size = new System.Drawing.Size(120, 147);
            this.lbPila.TabIndex = 0;
            // 
            // lbCola
            // 
            this.lbCola.FormattingEnabled = true;
            this.lbCola.Location = new System.Drawing.Point(159, 79);
            this.lbCola.Name = "lbCola";
            this.lbCola.Size = new System.Drawing.Size(120, 147);
            this.lbCola.TabIndex = 1;
            // 
            // lbTurnoPila
            // 
            this.lbTurnoPila.AutoSize = true;
            this.lbTurnoPila.Location = new System.Drawing.Point(50, 265);
            this.lbTurnoPila.Name = "lbTurnoPila";
            this.lbTurnoPila.Size = new System.Drawing.Size(38, 13);
            this.lbTurnoPila.TabIndex = 2;
            this.lbTurnoPila.Text = "Turno:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(475, 90);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbTurnoCola
            // 
            this.lbTurnoCola.AutoSize = true;
            this.lbTurnoCola.Location = new System.Drawing.Point(188, 265);
            this.lbTurnoCola.Name = "lbTurnoCola";
            this.lbTurnoCola.Size = new System.Drawing.Size(38, 13);
            this.lbTurnoCola.TabIndex = 4;
            this.lbTurnoCola.Text = "Turno:";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(285, 92);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(184, 20);
            this.txtItem.TabIndex = 5;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(33, 344);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(246, 23);
            this.btnQuitar.TabIndex = 6;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pila";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cola";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(301, 160);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(49, 13);
            this.lbCantidad.TabIndex = 9;
            this.lbCantidad.Text = "Cantidad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 412);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.lbTurnoCola);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbTurnoPila);
            this.Controls.Add(this.lbCola);
            this.Controls.Add(this.lbPila);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPila;
        private System.Windows.Forms.ListBox lbCola;
        private System.Windows.Forms.Label lbTurnoPila;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lbTurnoCola;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCantidad;
    }
}

