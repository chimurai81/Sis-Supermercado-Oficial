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
    public partial class FrmMenuProductos : Form
    {
        public FrmMenuProductos()
        {
            InitializeComponent();
        }
        //obtener todos los productos
        public void GetAll(string condicion)
        {
            string sql;
            MySqlDataAdapter consulta;
            DataSet resultado;
            sql = "select  a.CodigoProducto,a.Descripcion, a.Stock, a.PrecioDeCompra, a.PrecioDeVenta, a.FechaDeVencimiento, b.Descripcion as 'Categoria', c.Descripcion as 'Marca', d.Nombre 'Proveedor', a.CodigoDeBarra,  a.ImagenDelProducto from db_productos a join db_categoria b ON a.Id_Categoria=b.id join db_marca c On a.Id_Marca=c.id join db_proveedores d On a.Id_Proveedor=d.id" + condicion;

            try
            {
                modulo.AbrirConexion();
                consulta = new MySqlDataAdapter(sql, modulo.conexion);
                resultado = new DataSet();
                consulta.Fill(resultado, "rsresultado");
                DataGridView1.DataSource = resultado.Tables["rsresultado"];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            GetAll("");
        }
    }
}
