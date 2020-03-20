using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Usuarios.Formularios;

namespace MenuPrincipal
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            
        }

        // inicio
        //esto funciona para poder mover a todos los lados el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //fin


        private void ptbSideBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (SidebarWrapper.Width == 202)
            {
                SidebarWrapper.Visible = false;
                SidebarWrapper.Width = 58;
                bunifuTransition1.Show(SidebarWrapper);
            }
            else
            {
                SidebarWrapper.Visible = false;
                SidebarWrapper.Width = 202;
                bunifuTransition2.Show(SidebarWrapper);
            }
        }



        private void ptbRestore_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            ptbRestore.Visible = false;
            ptbmaxi.Visible = true;
        }



        private void SidebarWrapper_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
        }

        private void SidebarWrapper_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = PanelContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PanelContenedor.Controls.Add(formulario);
                PanelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            
        }

        private void ptbSideBar_Click(object sender, EventArgs e)
        {

        }

        private void PtbMinimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ptbmaxi_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            ptbmaxi.Visible = false;
            ptbRestore.Visible = true;
        }

        private void ptbRestore_Click_2(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PanelContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmUsuarios>();
        }
    }
}
