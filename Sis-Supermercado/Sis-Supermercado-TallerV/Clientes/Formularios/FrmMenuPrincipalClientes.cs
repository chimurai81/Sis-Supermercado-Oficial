using Clientes.Formularios;
using MySql.Data.MySqlClient;
using Sis_Supermercado_TallerV.RegistroUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clientes
{
    public partial class FrmRegistroCliente : Form
    {

        public FrmRegistroCliente()
        {
            InitializeComponent();
        }
        


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //obtener todos los clientes
        public void GetAll(string condicion)
        {
            string sql;
            MySqlDataAdapter consulta;
            DataSet resultado;
            sql = "select * from db_clientes " + condicion;

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
        private void FrmRegistroCliente_Load(object sender, EventArgs e)
        {

            GetAll("");

        }

        //INSERTAR NUEVO CLIENTE
       
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FrmNuevoRegistroCliente form = new FrmNuevoRegistroCliente();
            form.ShowDialog();
            GetAll("");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
