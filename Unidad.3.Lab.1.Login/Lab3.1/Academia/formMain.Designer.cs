
namespace Academia
{
    partial class formMain
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
            this.components = new System.ComponentModel.Container();
            this.mnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMnuSalir = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsPrincipal.SuspendLayout();
            this.contextMnuSalir.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo});
            this.mnsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsPrincipal.Name = "mnsPrincipal";
            this.mnsPrincipal.Size = new System.Drawing.Size(800, 28);
            this.mnsPrincipal.TabIndex = 0;
            this.mnsPrincipal.Text = "mnsPrincipal";
            // 
            // mnuArchivo
            // 
            this.mnuArchivo.DropDown = this.contextMnuSalir;
            this.mnuArchivo.Name = "mnuArchivo";
            this.mnuArchivo.Size = new System.Drawing.Size(73, 24);
            this.mnuArchivo.Text = "Archivo";
            // 
            // contextMnuSalir
            // 
            this.contextMnuSalir.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMnuSalir.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir});
            this.contextMnuSalir.Name = "cMnuSalir";
            this.contextMnuSalir.OwnerItem = this.mnuArchivo;
            this.contextMnuSalir.Size = new System.Drawing.Size(108, 28);
            this.contextMnuSalir.Text = "Salir2";
            this.contextMnuSalir.Click += new System.EventHandler(this.contextMnuSalir_Click);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(107, 24);
            this.mnuSalir.Text = "Salir";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnsPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsPrincipal;
            this.Name = "formMain";
            this.Text = "Academia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.formMain_Shown);
            this.mnsPrincipal.ResumeLayout(false);
            this.mnsPrincipal.PerformLayout();
            this.contextMnuSalir.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ContextMenuStrip contextMnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
    }
}