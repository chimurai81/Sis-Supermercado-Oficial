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
    }
}
