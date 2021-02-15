namespace Ejercicio_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.combo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(555, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "CALCULANDO SALARIOS:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(138, 150);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(120, 22);
            this.txtnombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Salario:";
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(477, 149);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(128, 22);
            this.txtsalario.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // combo
            // 
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(259, 261);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(179, 24);
            this.combo.TabIndex = 13;
            this.combo.SelectedIndexChanged += new System.EventHandler(this.combo_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(688, 539);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox combo;
    }
}

