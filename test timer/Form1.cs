using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace test_timer
{
    public partial class Form1 : Form
    {
        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            BringToFront();
            TopMost = true;
            timer1.Start();
            rkApp.SetValue("Cartel Deuda Prosegur", Application.ExecutablePath);

            string screenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();
            string screenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();

            if (screenWidth == "1080")
            {
                //MessageBox.Show("1366");
                this.StartPosition = FormStartPosition.Manual;
                this.Left = 150;
                this.Top = 1600;
            }

            if (screenWidth == "768")
            {
                //MessageBox.Show("1366");
                this.StartPosition = FormStartPosition.Manual;
                this.Left = 0;
                this.Top = 1050;
                // el toten de 768 es 172.21.10.162
            }

            if (screenWidth == "1920")
            {
                //MessageBox.Show("1366");
                this.StartPosition = FormStartPosition.Manual;
                this.Left = 150;
                this.Top = 1600;
            }
            else
            {
                //MessageBox.Show("1366");
                this.StartPosition = FormStartPosition.Manual;
                this.Left = 0;
                this.Top = 0;
            }
            this.Location = Cartel_Deuda.Properties.Settings.Default.F1Location;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BringToFront();
            TopMost = true;
            //MessageBox.Show("hola");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            rkApp.SetValue("Cartel Deuda prosegur", Application.ExecutablePath);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            Cartel_Deuda.Properties.Settings.Default.F1State = this.WindowState;
            if (this.WindowState == FormWindowState.Normal)
            {
                // save location and size if the state is normal
                Cartel_Deuda.Properties.Settings.Default.F1Location = this.Location;
                Cartel_Deuda.Properties.Settings.Default.F1Size = this.Size;
            }
            else
            {
                // save the RestoreBounds if the form is minimized or maximized!
                Cartel_Deuda.Properties.Settings.Default.F1Location = this.RestoreBounds.Location;
                Cartel_Deuda.Properties.Settings.Default.F1Size = this.RestoreBounds.Size;
            }

            // don't forget to save the settings
            Cartel_Deuda.Properties.Settings.Default.Save();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try   { rkApp.DeleteValue("Cartel Deuda Prosegur"); }
            catch { MessageBox.Show("Ya lo quitaste del inicio Gerar/Ariel"); }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try   { rkApp.SetValue("Cartel Deuda Prosegur", Application.ExecutablePath);
                MessageBox.Show("Agregado al inicio");
            }
            catch { MessageBox.Show("No se pudo escribir el registro"); }
        }

        private void agregarAlInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                rkApp.SetValue("Cartel Deuda Prosegur", Application.ExecutablePath);
                MessageBox.Show("Agregado al inicio", "Agregado al inicio",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch { MessageBox.Show("No se pudo escribir el registro", "No se pudo escribir el registro",MessageBoxButtons.OK,MessageBoxIcon.Error); }
        }

        private void quitarDelInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { rkApp.DeleteValue("Cartel Deuda Prosegur");
                timer1.Stop();
                this.Dispose();
                this.Close();
                //MessageBox.Show("Quitado Del Inicio","Quitado Del Inicio", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch { MessageBox.Show("YA lo quitaste del inicio Gerar/Ariel", "YA lo quitaste del inicio Gerar/Ariel" , MessageBoxButtons.OK , MessageBoxIcon.Error); }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void posicion0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Left = 0;
            this.Top = 0;
        }

        private void cerrarAplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            timer1.Stop();
            this.Close();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
                    }

        private void bordeOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void bordeOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
