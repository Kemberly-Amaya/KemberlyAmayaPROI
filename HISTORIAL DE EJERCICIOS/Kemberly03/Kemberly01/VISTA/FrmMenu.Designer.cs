
namespace Kemberly01.VISTA
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clickAquiParaMasInformaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accederAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.matemáticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.accederAToolStripMenuItem,
            this.matemáticasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(694, 39);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clickAquiParaMasInformaciónToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acercaDeToolStripMenuItem.Image = global::Kemberly01.Properties.Resources.Flecha;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(159, 31);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // clickAquiParaMasInformaciónToolStripMenuItem
            // 
            this.clickAquiParaMasInformaciónToolStripMenuItem.Image = global::Kemberly01.Properties.Resources.Click;
            this.clickAquiParaMasInformaciónToolStripMenuItem.Name = "clickAquiParaMasInformaciónToolStripMenuItem";
            this.clickAquiParaMasInformaciónToolStripMenuItem.Size = new System.Drawing.Size(457, 36);
            this.clickAquiParaMasInformaciónToolStripMenuItem.Text = "Click aqui para mas información";
            this.clickAquiParaMasInformaciónToolStripMenuItem.Click += new System.EventHandler(this.clickAquiParaMasInformaciónToolStripMenuItem_Click);
            // 
            // accederAToolStripMenuItem
            // 
            this.accederAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaToolStripMenuItem});
            this.accederAToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accederAToolStripMenuItem.Image = global::Kemberly01.Properties.Resources.Flecha;
            this.accederAToolStripMenuItem.Name = "accederAToolStripMenuItem";
            this.accederAToolStripMenuItem.Size = new System.Drawing.Size(146, 31);
            this.accederAToolStripMenuItem.Text = "Acceder ";
            this.accederAToolStripMenuItem.Click += new System.EventHandler(this.accederAToolStripMenuItem_Click);
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Image = global::Kemberly01.Properties.Resources.Click;
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(278, 36);
            this.listaToolStripMenuItem.Text = "Acceder a Lista";
            this.listaToolStripMenuItem.Click += new System.EventHandler(this.listaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(522, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // matemáticasToolStripMenuItem
            // 
            this.matemáticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaToolStripMenuItem,
            this.restaToolStripMenuItem});
            this.matemáticasToolStripMenuItem.Name = "matemáticasToolStripMenuItem";
            this.matemáticasToolStripMenuItem.Size = new System.Drawing.Size(128, 31);
            this.matemáticasToolStripMenuItem.Text = "Matemáticas";
            // 
            // sumaToolStripMenuItem
            // 
            this.sumaToolStripMenuItem.Name = "sumaToolStripMenuItem";
            this.sumaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.sumaToolStripMenuItem.Text = "Suma";
            this.sumaToolStripMenuItem.Click += new System.EventHandler(this.sumaToolStripMenuItem_Click);
            // 
            // restaToolStripMenuItem
            // 
            this.restaToolStripMenuItem.Name = "restaToolStripMenuItem";
            this.restaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.restaToolStripMenuItem.Text = "Resta";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(694, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmMenu";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clickAquiParaMasInformaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accederAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem matemáticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaToolStripMenuItem;
    }
}