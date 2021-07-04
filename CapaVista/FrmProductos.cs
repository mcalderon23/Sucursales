using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace CapaVista
{
    public partial class FrmProductos : Form
    {
        private string idProducto;
        private bool Editarse = false;

        E_producto objEntidad = new E_producto();
        N_Producto objNegocio = new N_Producto();
        E_producto2 objEntidad2 = new E_producto2();
        N_Producto2 objNegocio2 = new N_Producto2();
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, EventArgs e)
        {
        }

        public void MostrarBuscarTabla(string buscar)
        {
            N_Producto objProducto = new N_Producto();
            TablaProductos.DataSource = objProducto.ListandoProducto(buscar);
        }

        public void MostrarBuscarTabla2(string buscar)
        {
            N_Producto2 objProducto2 = new N_Producto2();
            TablaProductos2.DataSource = objProducto2.ListandoProducto(buscar);
        }

        /*public void ListarMisProductos2(string buscar)
        {
            N_Producto2 objProducto = new N_Producto2();
            TablaProductos.DataSource = objProducto.ListarProductos2(buscar);
        }*/

        private void FrmProducto_Load_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            MostrarBuscarTabla("");
            MostrarBuscarTabla2("");

            TablaProductos.ClearSelection();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCajas();

        }

        private void LimpiarCajas()
        {
            TbxProducto.Text = "";
            TbxCodigo.Text = "";
            TbxExistencias.Text = "";
            TbxPrecio.Text = "";
            TbxProducto.Focus();
            Editarse = false;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (TabBase.SelectedTab == TabSucA)
            {
                if (TablaProductos.SelectedRows.Count > 0)
                {
                    Editarse = true;
                    idProducto = TablaProductos.CurrentRow.Cells[0].Value.ToString();
                    TbxProducto.Text = TablaProductos.CurrentRow.Cells[1].Value.ToString();
                    TbxCodigo.Text = TablaProductos.CurrentRow.Cells[2].Value.ToString();
                    TbxExistencias.Text = TablaProductos.CurrentRow.Cells[3].Value.ToString();
                    TbxPrecio.Text = TablaProductos.CurrentRow.Cells[4].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Seleccione un producto a editar");
                }
            }
            if (TabBase.SelectedTab == TabSucB)
            {
                if (TablaProductos2.SelectedRows.Count > 0)
                {
                    Editarse = true;
                    idProducto = TablaProductos2.CurrentRow.Cells[0].Value.ToString();
                    TbxProducto.Text = TablaProductos2.CurrentRow.Cells[1].Value.ToString();
                    TbxCodigo.Text = TablaProductos2.CurrentRow.Cells[2].Value.ToString();
                    TbxExistencias.Text = TablaProductos2.CurrentRow.Cells[3].Value.ToString();
                    TbxPrecio.Text = TablaProductos2.CurrentRow.Cells[4].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Seleccione un producto a editar");
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TabBase.SelectedTab == TabSucA)
            {
                if (Editarse == false)
                {
                    if (TbxProducto.Text == "" || TbxCodigo.Text == "" || TbxExistencias.Text == "" || TbxPrecio.Text == "")
                    {
                        MessageBox.Show("Porfavor rellena todos los campos");
                    }
                        
                    else
                    {
                    try
                    {
                        objEntidad.NombreProducto1 = TbxProducto.Text.ToString();
                        objEntidad.CodigoBarras1 = int.Parse(TbxCodigo.Text);

                        objEntidad.CantidadProducto1 = int.Parse(TbxExistencias.Text);
                        objEntidad.PrecioProducto1 = decimal.Parse(TbxPrecio.Text);


                        objEntidad2.NombreProducto1 = TbxProducto.Text.ToString();
                        objEntidad2.CodigoBarras1 = int.Parse(TbxCodigo.Text);
                            objEntidad2.CantidadProducto1 = 0;
                        objEntidad2.PrecioProducto1 = decimal.Parse(TbxPrecio.Text);

                        objNegocio.InsertandoProducto(objEntidad);
                        objNegocio2.InsertandoProducto(objEntidad2);

                        MessageBox.Show("Se guardo el registro");
                        MostrarBuscarTabla("");
                        MostrarBuscarTabla2("");
                        LimpiarCajas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo guardar el registro" + ex);
                    }
                }
                }
                if (Editarse == true)
                {
                    try
                    {
                        objEntidad.IdProducto = Convert.ToInt32(idProducto);
                        objEntidad.NombreProducto1 = TbxProducto.Text.ToString();
                        objEntidad.CodigoBarras1 = int.Parse(TbxCodigo.Text);
                        objEntidad.CantidadProducto1 = int.Parse(TbxExistencias.Text);
                        objEntidad.PrecioProducto1 = decimal.Parse(TbxPrecio.Text);
                        objEntidad2.IdProducto = Convert.ToInt32(idProducto);
                        objEntidad2.NombreProducto1 = TbxProducto.Text.ToString();
                        objEntidad2.CodigoBarras1 = int.Parse(TbxCodigo.Text);
                        objEntidad2.PrecioProducto1 = decimal.Parse(TbxPrecio.Text);

                        objNegocio.EditandoProducto(objEntidad);
                        objNegocio2.EditandoProducto(objEntidad2);

                        MessageBox.Show("Se edito el registro");
                        MostrarBuscarTabla("");
                        MostrarBuscarTabla2("");
                        Editarse = false;
                        LimpiarCajas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo editar el registro" + ex);
                    }
                }
            }
            if (TabBase.SelectedTab == TabSucB)
            {
                if (Editarse == false)
                {
                    if (TbxProducto.Text == "" || TbxCodigo.Text == "" || TbxExistencias.Text == "" || TbxPrecio.Text == "")
                    {
                        MessageBox.Show("Porfavor rellena todos los campos");
                    }

                    else
                    {
                        try
                        {
                            objEntidad2.NombreProducto1 = TbxProducto.Text.ToString();
                            objEntidad2.CodigoBarras1 = int.Parse(TbxCodigo.Text);
                            objEntidad2.CantidadProducto1 = int.Parse(TbxExistencias.Text);
                            objEntidad2.PrecioProducto1 = decimal.Parse(TbxPrecio.Text);
                            objEntidad.NombreProducto1 = TbxProducto.Text.ToString();
                            objEntidad.CodigoBarras1 = int.Parse(TbxCodigo.Text);
                            objEntidad.CantidadProducto1 = 0;
                            objEntidad.PrecioProducto1 = decimal.Parse(TbxPrecio.Text);



                            objNegocio2.InsertandoProducto(objEntidad2);
                            objNegocio.InsertandoProducto(objEntidad);

                            MessageBox.Show("Se guardo el registro");
                            MostrarBuscarTabla2("");
                            MostrarBuscarTabla("");
                            LimpiarCajas();
                        }


                        catch (Exception ex)
                        {
                            MessageBox.Show("No se pudo guardar el registro" + ex);
                        }
                    }
                }
                if (Editarse == true)
                {
                    try
                    {
                        objEntidad2.IdProducto = Convert.ToInt32(idProducto);
                        objEntidad2.NombreProducto1 = TbxProducto.Text.ToString();
                        objEntidad2.CodigoBarras1 = int.Parse(TbxCodigo.Text);
                        objEntidad2.CantidadProducto1 = int.Parse(TbxExistencias.Text);
                        objEntidad2.PrecioProducto1 = decimal.Parse(TbxPrecio.Text);
                        objEntidad.IdProducto = Convert.ToInt32(idProducto);
                        objEntidad.NombreProducto1 = TbxProducto.Text.ToString();
                        objEntidad.CodigoBarras1 = int.Parse(TbxCodigo.Text);
                        objEntidad.PrecioProducto1 = decimal.Parse(TbxPrecio.Text);

                        objNegocio2.EditandoProducto(objEntidad2);
                        objNegocio.EditandoProducto(objEntidad);

                        MessageBox.Show("Se edito el registro");
                        MostrarBuscarTabla2("");
                        MostrarBuscarTabla("");
                        Editarse = false;
                        LimpiarCajas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo editar el registro" + ex);
                    }
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if(TabBase.SelectedTab == TabSucA)
            {
                if(TablaProductos.SelectedRows.Count > 0)
                {
                    objEntidad.IdProducto = Convert.ToInt32(TablaProductos.CurrentRow.Cells[0].Value.ToString());
                    objNegocio.EliminarProducto(objEntidad);

                    MessageBox.Show("Se elimino correctamente");
                    MostrarBuscarTabla("");

                    objEntidad2.IdProducto = Convert.ToInt32(TablaProductos2.CurrentRow.Cells[0].Value.ToString());
                    objNegocio2.EliminarProducto(objEntidad2);
                    MostrarBuscarTabla2("");

                }
                else
                {
                    MessageBox.Show("Seleccione una fila a eliminar");
                }
            }
            if (TabBase.SelectedTab == TabSucB)
            {
                if (TablaProductos2.SelectedRows.Count > 0)
                {
                    objEntidad2.IdProducto = Convert.ToInt32(TablaProductos2.CurrentRow.Cells[0].Value.ToString());
                    objNegocio2.EliminarProducto(objEntidad2);

                    MessageBox.Show("Se elimino correctamente");
                    MostrarBuscarTabla2("");
                    objEntidad.IdProducto = Convert.ToInt32(TablaProductos.CurrentRow.Cells[0].Value.ToString());
                    objNegocio.EliminarProducto(objEntidad);
                    MostrarBuscarTabla("");
                }
                else
                {
                    MessageBox.Show("Seleccione una fila a eliminar");
                }
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TabBase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DropVenta_onItemSelected(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
