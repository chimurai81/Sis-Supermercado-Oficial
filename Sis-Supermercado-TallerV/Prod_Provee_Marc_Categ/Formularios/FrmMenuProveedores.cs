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

namespace Prod_Provee_Marc_Categ.Formularios
{
    public partial class FrmMenuProveedores : Form
    {
        public FrmMenuProveedores()
        {
            InitializeComponent();
        }

        public void GetAll(string condicion)
        {
            string sql;
            MySqlDataAdapter consulta;
            DataSet resultado;
            sql = "select * from db_proveedores " + condicion;

            try
            {
                modulo.AbrirConexion();
                consulta = new MySqlDataAdapter(sql, modulo.conexion);
                resultado = new DataSet();
                consulta.Fill(resultado, "rsresultado");
                dataGridView1.DataSource = resultado.Tables["rsresultado"];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            GetAll("");
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FrmAgregarNuevoProveedor frm = new FrmAgregarNuevoProveedor();
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
