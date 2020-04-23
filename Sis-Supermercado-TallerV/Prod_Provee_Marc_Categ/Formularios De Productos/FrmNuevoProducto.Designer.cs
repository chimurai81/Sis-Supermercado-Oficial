namespace Prod_Provee_Marc_Categ.Formularios_De_Productos
{
    partial class FrmNuevoProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoProductos));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dtpFechaNac = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtProducto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDescripcion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtStock = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPrecioDeCompra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPrecioDeVenta = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCategoria = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMarca = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtProveedor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox9 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ptbImagenProducto = new System.Windows.Forms.PictureBox();
            this.btnElegirImagenProducto = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnElegirCategoria = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnElegirMarca = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnProveedor = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagenProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnElegirCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnElegirMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtpFechaNac.BackgroundImage = global::Prod_Provee_Marc_Categ.Properties.Resources.a68832c79725180370fa5e147b19b8c5;
            this.dtpFechaNac.BorderRadius = 0;
            this.dtpFechaNac.ForeColor = System.Drawing.Color.Black;
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.FormatCustom = "Fecha De Vencimiento";
            this.dtpFechaNac.Location = new System.Drawing.Point(13, 421);
            this.dtpFechaNac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(511, 55);
            this.dtpFechaNac.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dtpFechaNac, "Fecha De Vencimiento");
            this.toolTip2.SetToolTip(this.dtpFechaNac, "Fecha De Vencimiento");
            this.dtpFechaNac.Value = new System.DateTime(2020, 4, 16, 19, 6, 52, 585);
            this.dtpFechaNac.Click += new System.EventHandler(this.dtpFechaNac_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProducto.HintForeColor = System.Drawing.Color.Empty;
            this.txtProducto.HintText = "";
            this.txtProducto.isPassword = false;
            this.txtProducto.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtProducto.LineIdleColor = System.Drawing.Color.Gray;
            this.txtProducto.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtProducto.LineThickness = 3;
            this.txtProducto.Location = new System.Drawing.Point(13, 126);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(511, 55);
            this.txtProducto.TabIndex = 1;
            this.txtProducto.Text = "Codigo";
            this.txtProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescripcion.HintForeColor = System.Drawing.Color.Empty;
            this.txtDescripcion.HintText = "";
            this.txtDescripcion.isPassword = false;
            this.txtDescripcion.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDescripcion.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDescripcion.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDescripcion.LineThickness = 3;
            this.txtDescripcion.Location = new System.Drawing.Point(13, 185);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(511, 55);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.Text = "Descripcion";
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStock.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStock.HintForeColor = System.Drawing.Color.Empty;
            this.txtStock.HintText = "";
            this.txtStock.isPassword = false;
            this.txtStock.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtStock.LineIdleColor = System.Drawing.Color.Gray;
            this.txtStock.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtStock.LineThickness = 3;
            this.txtStock.Location = new System.Drawing.Point(13, 244);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(511, 55);
            this.txtStock.TabIndex = 3;
            this.txtStock.Text = "Stock";
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPrecioDeCompra
            // 
            this.txtPrecioDeCompra.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPrecioDeCompra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioDeCompra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrecioDeCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecioDeCompra.HintForeColor = System.Drawing.Color.Empty;
            this.txtPrecioDeCompra.HintText = "";
            this.txtPrecioDeCompra.isPassword = false;
            this.txtPrecioDeCompra.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPrecioDeCompra.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPrecioDeCompra.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPrecioDeCompra.LineThickness = 3;
            this.txtPrecioDeCompra.Location = new System.Drawing.Point(13, 303);
            this.txtPrecioDeCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioDeCompra.Name = "txtPrecioDeCompra";
            this.txtPrecioDeCompra.Size = new System.Drawing.Size(511, 55);
            this.txtPrecioDeCompra.TabIndex = 4;
            this.txtPrecioDeCompra.Text = "Precio De Compra";
            this.txtPrecioDeCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPrecioDeVenta
            // 
            this.txtPrecioDeVenta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPrecioDeVenta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioDeVenta.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrecioDeVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecioDeVenta.HintForeColor = System.Drawing.Color.Empty;
            this.txtPrecioDeVenta.HintText = "";
            this.txtPrecioDeVenta.isPassword = false;
            this.txtPrecioDeVenta.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPrecioDeVenta.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPrecioDeVenta.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPrecioDeVenta.LineThickness = 3;
            this.txtPrecioDeVenta.Location = new System.Drawing.Point(13, 362);
            this.txtPrecioDeVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioDeVenta.Name = "txtPrecioDeVenta";
            this.txtPrecioDeVenta.Size = new System.Drawing.Size(511, 55);
            this.txtPrecioDeVenta.TabIndex = 5;
            this.txtPrecioDeVenta.Text = "Precio De Venta";
            this.txtPrecioDeVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCategoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCategoria.HintForeColor = System.Drawing.Color.Empty;
            this.txtCategoria.HintText = "";
            this.txtCategoria.isPassword = false;
            this.txtCategoria.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCategoria.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCategoria.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCategoria.LineThickness = 3;
            this.txtCategoria.Location = new System.Drawing.Point(13, 480);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(511, 55);
            this.txtCategoria.TabIndex = 6;
            this.txtCategoria.Text = "Categoria";
            this.txtCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarca.Enabled = false;
            this.txtMarca.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMarca.HintForeColor = System.Drawing.Color.Empty;
            this.txtMarca.HintText = "";
            this.txtMarca.isPassword = false;
            this.txtMarca.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMarca.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMarca.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMarca.LineThickness = 3;
            this.txtMarca.Location = new System.Drawing.Point(13, 539);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(511, 55);
            this.txtMarca.TabIndex = 7;
            this.txtMarca.Text = "Marca";
            this.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMarca.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox7_OnValueChanged);
            // 
            // txtProveedor
            // 
            this.txtProveedor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProveedor.HintForeColor = System.Drawing.Color.Empty;
            this.txtProveedor.HintText = "";
            this.txtProveedor.isPassword = false;
            this.txtProveedor.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtProveedor.LineIdleColor = System.Drawing.Color.Gray;
            this.txtProveedor.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtProveedor.LineThickness = 3;
            this.txtProveedor.Location = new System.Drawing.Point(13, 598);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(511, 55);
            this.txtProveedor.TabIndex = 8;
            this.txtProveedor.Text = "Proveedor";
            this.txtProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox9
            // 
            this.bunifuMaterialTextbox9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuMaterialTextbox9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox9.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox9.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox9.HintText = "";
            this.bunifuMaterialTextbox9.isPassword = false;
            this.bunifuMaterialTextbox9.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox9.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox9.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox9.LineThickness = 3;
            this.bunifuMaterialTextbox9.Location = new System.Drawing.Point(13, 657);
            this.bunifuMaterialTextbox9.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox9.Name = "bunifuMaterialTextbox9";
            this.bunifuMaterialTextbox9.Size = new System.Drawing.Size(511, 55);
            this.bunifuMaterialTextbox9.TabIndex = 9;
            this.bunifuMaterialTextbox9.Text = "Codigo De Barra";
            this.bunifuMaterialTextbox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ptbImagenProducto
            // 
            this.ptbImagenProducto.Location = new System.Drawing.Point(679, 124);
            this.ptbImagenProducto.Name = "ptbImagenProducto";
            this.ptbImagenProducto.Size = new System.Drawing.Size(443, 289);
            this.ptbImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagenProducto.TabIndex = 10;
            this.ptbImagenProducto.TabStop = false;
            // 
            // btnElegirImagenProducto
            // 
            this.btnElegirImagenProducto.ActiveBorderThickness = 1;
            this.btnElegirImagenProducto.ActiveCornerRadius = 15;
            this.btnElegirImagenProducto.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnElegirImagenProducto.ActiveForecolor = System.Drawing.Color.White;
            this.btnElegirImagenProducto.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnElegirImagenProducto.BackColor = System.Drawing.SystemColors.Control;
            this.btnElegirImagenProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnElegirImagenProducto.BackgroundImage")));
            this.btnElegirImagenProducto.ButtonText = "Seleccionar Imagen";
            this.btnElegirImagenProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElegirImagenProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElegirImagenProducto.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnElegirImagenProducto.IdleBorderThickness = 1;
            this.btnElegirImagenProducto.IdleCornerRadius = 15;
            this.btnElegirImagenProducto.IdleFillColor = System.Drawing.Color.White;
            this.btnElegirImagenProducto.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnElegirImagenProducto.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnElegirImagenProducto.Location = new System.Drawing.Point(707, 421);
            this.btnElegirImagenProducto.Margin = new System.Windows.Forms.Padding(5);
            this.btnElegirImagenProducto.Name = "btnElegirImagenProducto";
            this.btnElegirImagenProducto.Size = new System.Drawing.Size(181, 41);
            this.btnElegirImagenProducto.TabIndex = 13;
            this.btnElegirImagenProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnElegirImagenProducto.Click += new System.EventHandler(this.btnElegirImagenProducto_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 15;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Eliminar Imagen";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 15;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(898, 421);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton22.TabIndex = 14;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnElegirCategoria
            // 
            this.btnElegirCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btnElegirCategoria.Image = global::Prod_Provee_Marc_Categ.Properties.Resources.category;
            this.btnElegirCategoria.ImageActive = null;
            this.btnElegirCategoria.Location = new System.Drawing.Point(531, 478);
            this.btnElegirCategoria.Name = "btnElegirCategoria";
            this.btnElegirCategoria.Size = new System.Drawing.Size(59, 55);
            this.btnElegirCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnElegirCategoria.TabIndex = 17;
            this.btnElegirCategoria.TabStop = false;
            this.toolTip1.SetToolTip(this.btnElegirCategoria, "Agregar Categoria Existentes");
            this.btnElegirCategoria.Zoom = 10;
            this.btnElegirCategoria.Click += new System.EventHandler(this.btnElegirCategoria_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Prod_Provee_Marc_Categ.Properties.Resources.close__2_;
            this.pictureBox2.Location = new System.Drawing.Point(1135, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnElegirMarca
            // 
            this.btnElegirMarca.BackColor = System.Drawing.Color.Transparent;
            this.btnElegirMarca.Image = global::Prod_Provee_Marc_Categ.Properties.Resources._12533601;
            this.btnElegirMarca.ImageActive = null;
            this.btnElegirMarca.Location = new System.Drawing.Point(531, 538);
            this.btnElegirMarca.Name = "btnElegirMarca";
            this.btnElegirMarca.Size = new System.Drawing.Size(59, 55);
            this.btnElegirMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnElegirMarca.TabIndex = 27;
            this.btnElegirMarca.TabStop = false;
            this.toolTip1.SetToolTip(this.btnElegirMarca, "Agregar Marca Existentes");
            this.btnElegirMarca.Zoom = 10;
            // 
            // btnProveedor
            // 
            this.btnProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btnProveedor.Image = global::Prod_Provee_Marc_Categ.Properties.Resources.icono_proveedor_png_51;
            this.btnProveedor.ImageActive = null;
            this.btnProveedor.Location = new System.Drawing.Point(531, 598);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(59, 55);
            this.btnProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnProveedor.TabIndex = 28;
            this.btnProveedor.TabStop = false;
            this.toolTip1.SetToolTip(this.btnProveedor, "Agregar Proveedor Existente");
            this.btnProveedor.Zoom = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::Prod_Provee_Marc_Categ.Properties.Resources.barcode;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(531, 657);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(59, 55);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 29;
            this.bunifuImageButton1.TabStop = false;
            this.toolTip1.SetToolTip(this.bunifuImageButton1, "Escanear Codigo");
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(188)))), ((int)(((byte)(67)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = global::Prod_Provee_Marc_Categ.Properties.Resources.a68832c79725180370fa5e147b19b8c5;
            this.bunifuImageButton2.Location = new System.Drawing.Point(658, 598);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(235, 141);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 35;
            this.bunifuImageButton2.TabStop = false;
            this.toolTip2.SetToolTip(this.bunifuImageButton2, "Guardar");
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(2)))), ((int)(((byte)(57)))));
            this.bunifuImageButton3.Image = global::Prod_Provee_Marc_Categ.Properties.Resources.close_white_25x25px;
            this.bunifuImageButton3.ImageActive = global::Prod_Provee_Marc_Categ.Properties.Resources.gif_icons_menu_transition_animations_animated_3_dotted;
            this.bunifuImageButton3.Location = new System.Drawing.Point(898, 598);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(235, 141);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bunifuImageButton3.TabIndex = 36;
            this.bunifuImageButton3.TabStop = false;
            this.toolTip2.SetToolTip(this.bunifuImageButton3, "Salir");
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // toolTip2
            // 
            this.toolTip2.AutoPopDelay = 2000;
            this.toolTip2.InitialDelay = 500;
            this.toolTip2.ReshowDelay = 100;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.ptbImagenProducto;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 21);
            this.label1.TabIndex = 37;
            this.label1.Text = "Fecha De Vencimiento";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // FrmNuevoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prod_Provee_Marc_Categ.Properties.Resources.FondoAggProducto3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1172, 780);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btnProveedor);
            this.Controls.Add(this.btnElegirMarca);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnElegirCategoria);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.btnElegirImagenProducto);
            this.Controls.Add(this.bunifuMaterialTextbox9);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtPrecioDeVenta);
            this.Controls.Add(this.txtPrecioDeCompra);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.ptbImagenProducto);
            this.Controls.Add(this.dtpFechaNac);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevoProductos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmNuevoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagenProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnElegirCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnElegirMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProducto;
        private Bunifu.Framework.UI.BunifuDatepicker dtpFechaNac;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProveedor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMarca;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCategoria;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrecioDeVenta;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrecioDeCompra;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtStock;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDescripcion;
        private System.Windows.Forms.PictureBox ptbImagenProducto;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 btnElegirImagenProducto;
        private Bunifu.Framework.UI.BunifuImageButton btnElegirCategoria;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuImageButton btnElegirMarca;
        private Bunifu.Framework.UI.BunifuImageButton btnProveedor;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label label1;
    }
}