
namespace Kemberly01.VISTA
{
    partial class FrmAcercaDe
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
            this.Capa1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Capa1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(121, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SOMOS UNA EMPRESA  DE DESARROLLO DE APLICACIONES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Capa1
            // 
            this.Capa1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Capa1.BackgroundImage = global::Kemberly01.Properties.Resources.FondoLineas;
            this.Capa1.Controls.Add(this.button2);
            this.Capa1.Controls.Add(this.button1);
            this.Capa1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Capa1.Location = new System.Drawing.Point(156, 191);
            this.Capa1.Name = "Capa1";
            this.Capa1.Size = new System.Drawing.Size(416, 207);
            this.Capa1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Kemberly01.Properties.Resources.FondoAzul;
            this.button2.Location = new System.Drawing.Point(169, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Kemberly01.Properties.Resources.FondoAzul;
            this.button1.Location = new System.Drawing.Point(169, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Capa1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmAcercaDe";
            this.Text = "FrmAcercaDe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAcercaDe_Load);
            this.Capa1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Capa1;
        private System.Windows.Forms.Button button2;
    }
}