namespace Agencia
{
    partial class Main
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
            this.gestionarFlotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarLavaderoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operarLavaderoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarFlotasToolStripMenuItem,
            this.gestionarLavaderoToolStripMenuItem,
            this.gestionarUsuariosToolStripMenuItem,
            this.generarReportesToolStripMenuItem,
            this.operarLavaderoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionarFlotasToolStripMenuItem
            // 
            this.gestionarFlotasToolStripMenuItem.Name = "gestionarFlotasToolStripMenuItem";
            this.gestionarFlotasToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.gestionarFlotasToolStripMenuItem.Text = "Gestionar Flotas";
            // 
            // gestionarLavaderoToolStripMenuItem
            // 
            this.gestionarLavaderoToolStripMenuItem.Name = "gestionarLavaderoToolStripMenuItem";
            this.gestionarLavaderoToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.gestionarLavaderoToolStripMenuItem.Text = "Gestionar Lavadero";
            // 
            // gestionarUsuariosToolStripMenuItem
            // 
            this.gestionarUsuariosToolStripMenuItem.Name = "gestionarUsuariosToolStripMenuItem";
            this.gestionarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.gestionarUsuariosToolStripMenuItem.Text = "Gestionar Usuarios";
            // 
            // generarReportesToolStripMenuItem
            // 
            this.generarReportesToolStripMenuItem.Name = "generarReportesToolStripMenuItem";
            this.generarReportesToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.generarReportesToolStripMenuItem.Text = "Generar Reportes";
            // 
            // operarLavaderoToolStripMenuItem
            // 
            this.operarLavaderoToolStripMenuItem.Name = "operarLavaderoToolStripMenuItem";
            this.operarLavaderoToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.operarLavaderoToolStripMenuItem.Text = "Operar Lavadero";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionarFlotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarLavaderoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operarLavaderoToolStripMenuItem;
    }
}