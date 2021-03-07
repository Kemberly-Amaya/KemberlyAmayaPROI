
namespace Kemberly01.VISTA
{
    partial class FrmOperaciones
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
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.txtDato1 = new System.Windows.Forms.TextBox();
            this.txtDato2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSuma.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSuma.Location = new System.Drawing.Point(631, 250);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(116, 54);
            this.btnSuma.TabIndex = 0;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnResta.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(631, 328);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(116, 54);
            this.btnResta.TabIndex = 1;
            this.btnResta.Text = "Resta";
            this.btnResta.UseVisualStyleBackColor = false;
            // 
            // txtDato1
            // 
            this.txtDato1.Location = new System.Drawing.Point(98, 104);
            this.txtDato1.Name = "txtDato1";
            this.txtDato1.Size = new System.Drawing.Size(459, 26);
            this.txtDato1.TabIndex = 2;
            // 
            // txtDato2
            // 
            this.txtDato2.Location = new System.Drawing.Point(98, 222);
            this.txtDato2.Name = "txtDato2";
            this.txtDato2.Size = new System.Drawing.Size(459, 26);
            this.txtDato2.TabIndex = 3;
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(102, 356);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(459, 26);
            this.txtResultado.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingresa un dato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingresa un segundo dato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultado";
            // 
            // FrmOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(801, 539);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtDato2);
            this.Controls.Add(this.txtDato1);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Name = "FrmOperaciones";
            this.Text = "FrmOperaciones";
            this.Load += new System.EventHandler(this.FrmOperaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDato1;
        private System.Windows.Forms.TextBox txtDato2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnResta;
        public System.Windows.Forms.Button btnSuma;
    }
}