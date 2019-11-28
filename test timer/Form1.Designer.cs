namespace test_timer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarAlInicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitarDelInicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.posicion0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bordeOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bordeOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrarAplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitarDelInicioToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.bordeOnToolStripMenuItem,
            this.bordeOffToolStripMenuItem,
            this.toolStripSeparator3,
            this.posicion0ToolStripMenuItem,
            this.agregarAlInicioToolStripMenuItem,
            this.cerrarAplicacionToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(233, 176);
            this.contextMenuStrip1.Text = "MENU";
            // 
            // agregarAlInicioToolStripMenuItem
            // 
            this.agregarAlInicioToolStripMenuItem.Name = "agregarAlInicioToolStripMenuItem";
            this.agregarAlInicioToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.agregarAlInicioToolStripMenuItem.Text = "Agregar Al Inicio";
            this.agregarAlInicioToolStripMenuItem.Click += new System.EventHandler(this.agregarAlInicioToolStripMenuItem_Click);
            // 
            // quitarDelInicioToolStripMenuItem
            // 
            this.quitarDelInicioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.quitarDelInicioToolStripMenuItem.Name = "quitarDelInicioToolStripMenuItem";
            this.quitarDelInicioToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.quitarDelInicioToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.quitarDelInicioToolStripMenuItem.Text = "Quitar Del Inicio Y Cerrar";
            this.quitarDelInicioToolStripMenuItem.Click += new System.EventHandler(this.quitarDelInicioToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(229, 6);
            // 
            // posicion0ToolStripMenuItem
            // 
            this.posicion0ToolStripMenuItem.Name = "posicion0ToolStripMenuItem";
            this.posicion0ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.posicion0ToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.posicion0ToolStripMenuItem.Text = "Posicion 0";
            this.posicion0ToolStripMenuItem.Click += new System.EventHandler(this.posicion0ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(229, 6);
            // 
            // bordeOnToolStripMenuItem
            // 
            this.bordeOnToolStripMenuItem.Name = "bordeOnToolStripMenuItem";
            this.bordeOnToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.bordeOnToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.bordeOnToolStripMenuItem.Text = "Borde On";
            this.bordeOnToolStripMenuItem.Click += new System.EventHandler(this.bordeOnToolStripMenuItem_Click);
            // 
            // bordeOffToolStripMenuItem
            // 
            this.bordeOffToolStripMenuItem.Name = "bordeOffToolStripMenuItem";
            this.bordeOffToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.bordeOffToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.bordeOffToolStripMenuItem.Text = "Borde Off";
            this.bordeOffToolStripMenuItem.Click += new System.EventHandler(this.bordeOffToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(229, 6);
            // 
            // cerrarAplicacionToolStripMenuItem
            // 
            this.cerrarAplicacionToolStripMenuItem.Name = "cerrarAplicacionToolStripMenuItem";
            this.cerrarAplicacionToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.cerrarAplicacionToolStripMenuItem.Text = "Cerrar Aplicacion";
            this.cerrarAplicacionToolStripMenuItem.Click += new System.EventHandler(this.cerrarAplicacionToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 244);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(200, 700);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Prosegur Informa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem agregarAlInicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitarDelInicioToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem posicion0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarAplicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bordeOnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bordeOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

