namespace FormArregloUnidimensionalG3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbTotalElementos = new System.Windows.Forms.TextBox();
            this.txtbElemento = new System.Windows.Forms.TextBox();
            this.btnDefinirTamaño = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMatriz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total de elementos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Introduce elemento";
            // 
            // txtbTotalElementos
            // 
            this.txtbTotalElementos.Location = new System.Drawing.Point(68, 106);
            this.txtbTotalElementos.Name = "txtbTotalElementos";
            this.txtbTotalElementos.Size = new System.Drawing.Size(100, 26);
            this.txtbTotalElementos.TabIndex = 1;
            // 
            // txtbElemento
            // 
            this.txtbElemento.Location = new System.Drawing.Point(349, 106);
            this.txtbElemento.Name = "txtbElemento";
            this.txtbElemento.Size = new System.Drawing.Size(100, 26);
            this.txtbElemento.TabIndex = 1;
            // 
            // btnDefinirTamaño
            // 
            this.btnDefinirTamaño.Location = new System.Drawing.Point(68, 181);
            this.btnDefinirTamaño.Name = "btnDefinirTamaño";
            this.btnDefinirTamaño.Size = new System.Drawing.Size(100, 65);
            this.btnDefinirTamaño.TabIndex = 2;
            this.btnDefinirTamaño.Text = "Definir tamaño";
            this.btnDefinirTamaño.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(349, 181);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 65);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Matriz";
            // 
            // lbMatriz
            // 
            this.lbMatriz.AutoSize = true;
            this.lbMatriz.Location = new System.Drawing.Point(590, 109);
            this.lbMatriz.Name = "lbMatriz";
            this.lbMatriz.Size = new System.Drawing.Size(74, 20);
            this.lbMatriz.TabIndex = 0;
            this.lbMatriz.Text = "10, 8 , 12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 334);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnDefinirTamaño);
            this.Controls.Add(this.txtbElemento);
            this.Controls.Add(this.txtbTotalElementos);
            this.Controls.Add(this.lbMatriz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbTotalElementos;
        private System.Windows.Forms.TextBox txtbElemento;
        private System.Windows.Forms.Button btnDefinirTamaño;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMatriz;
    }
}

