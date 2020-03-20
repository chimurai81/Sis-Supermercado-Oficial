using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sis_Supermercado_TallerV.RegistroUsers
{
    public partial class FrmRegistroUsuarios : Form
    {
        public FrmRegistroUsuarios()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin login = new FrmLogin();
            login.Show();
        }
       
        private void FrmRegistroUsuarios_Load(object sender, EventArgs e)
        {
           
        }

        


        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
