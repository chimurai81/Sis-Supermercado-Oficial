using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prod_Provee_Marc_Categ.Formularios_De_Productos
{
    public partial class FrmNuevoProductos : Form
    {
        public FrmNuevoProductos()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox7_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmNuevoProducto_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnElegirImagenProducto_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpFechaNac_MouseHover(object sender, EventArgs e)
        {
           
            toolTip1.SetToolTip(dtpFechaNac, "Fecha de Vencimiento");
        }

        private void dtpFechaNac_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Visible = false;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnElegirCategoria_Click(object sender, EventArgs e)
        {
            FrmBusqueda_Interna_Categoria show = new FrmBusqueda_Interna_Categoria();
            show.ShowDialog();
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog AbriImagen = new OpenFileDialog();
            AbriImagen.InitialDirectory = @"C:\Users\Mauricio\Pictures";
            AbriImagen.Filter = "Archivos de Imagen(*.jpg, *.jpeg, *.jpe, *.png, *.jfif) | *.jpg; *.jpeg; *.jpe; *.png; *.jfif";
            AbriImagen.ShowDialog();

            if (AbriImagen.FileName != "")
            {
                ptbImagenProducto.Image = Image.FromFile(AbriImagen.FileName);
            }
            else
            {
                ptbImagenProducto.Image = null;

            }
        }


        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            ptbImagenProducto.Image = null;
        }

        private void txtProducto_Enter(object sender, EventArgs e)
        {
            if(txtCodigoProducto.Text == "Codigo")
            {
                txtCodigoProducto.Text = "";
            }
        }

        private void txtCodigoProducto_Leave(object sender, EventArgs e)
        {
            if (txtCodigoProducto.Text == "")
            {
                txtCodigoProducto.Text = "Codigo";
            }
        }

        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "Descripcion")
            {
                txtDescripcion.Text = "";
            }
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                txtDescripcion.Text = "Descripcion";
            }
        }

        private void txtCategoria_Enter(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "Categoria")
            {
                txtCategoria.Text = "";
            }
        }

        private void txtCategoria_Leave(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "")
            {
                txtCategoria.Text = "Categoria";
            }
        }

        private void bunifuMaterialTextbox9_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox9.Text == "Codigo De Barra")
            {
                bunifuMaterialTextbox9.Text = "";
            }
            
        }

        private void bunifuMaterialTextbox9_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox9.Text == "")
            {
                bunifuMaterialTextbox9.Text = "Codigo De Barra";
            }
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "Stock")
            {
                bunifuMaterialTextbox1.Text = "";
            }
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "")
            {
                bunifuMaterialTextbox1.Text = "Stock";
            }
        }

        private void txtCosto_Enter(object sender, EventArgs e)
        {
            if (txtCosto.Text == "Costo")
            {
                txtCosto.Text = "";
            }
        }

        private void txtCosto_Leave(object sender, EventArgs e)
        {
            if (txtCosto.Text == "")
            {
                txtCosto.Text = "Costo";
            }
        }

        private void txtCostoMedio_Enter(object sender, EventArgs e)
        {
            if (txtCostoMedio.Text == "Costo Medio")
            {
                txtCostoMedio.Text = "";
            }
        }

        private void txtCostoMedio_Leave(object sender, EventArgs e)
        {
            if (txtCostoMedio.Text == "")
            {
                txtCostoMedio.Text = "Costo Medio";
            }
        }

        private void txtPrecioUnitario_Enter(object sender, EventArgs e)
        {
            if (txtPrecioUnitario.Text == "Precio Unitario")
            {
                txtPrecioUnitario.Text = "";
            }
            
        }

        private void txtPrecioUnitario_Leave(object sender, EventArgs e)
        {
            if (txtPrecioUnitario.Text == "")
            {
                txtPrecioUnitario.Text = "Precio Unitario";
            }
        }

        private void txtPrecioMayorista_Enter(object sender, EventArgs e)
        {
            if (txtPrecioMayorista.Text == "Precio Mayorista")
            {
                txtPrecioMayorista.Text = "";
            }
        }

        private void txtPrecioMayorista_Leave(object sender, EventArgs e)
        {
            if (txtPrecioMayorista.Text == "")
            {
                txtPrecioMayorista.Text = "Precio Mayorista";
            }
        }

        private void txtIva_Enter(object sender, EventArgs e)
        {
            if (txtIva.Text == "IVA")
            {
                txtIva.Text = "";
            }
        }

        private void txtIva_Leave(object sender, EventArgs e)
        {
            if (txtIva.Text == "")
            {
                txtIva.Text = "IVA";
            }
        }

        private void txtTipo_Enter(object sender, EventArgs e)
        {
            if (txtTipo.Text == "Tipo")
            {
                txtTipo.Text = "";
            }
        }

        private void txtTipo_Leave(object sender, EventArgs e)
        {
            if (txtTipo.Text == "")
            {
                txtTipo.Text = "Tipo";
            }
        }

        private void btnElegirMarca_Click(object sender, EventArgs e)
        {
            FrmBusqueda_Interna_Marca frm = new FrmBusqueda_Interna_Marca();
            frm.ShowDialog();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            FrmBusqueda_Interna_Proveedores frm = new FrmBusqueda_Interna_Proveedores();
            frm.ShowDialog();
        }
    }
}
