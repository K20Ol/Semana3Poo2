using Publicaciones.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Publicaciones
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmDescuentos desc = new frmDescuentos();
            desc.ShowDialog();
        }

        private void btnTitulos_Click(object sender, EventArgs e)
        {
            frmTitulos titulos = new frmTitulos();
            titulos.ShowDialog();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            frmAutores autores = new frmAutores();
            autores.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleados emp = new frmEmpleados();
            emp.ShowDialog();

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVentas ventas = new frmVentas();
            ventas.ShowDialog();
        }

        private void btnTiendas_Click(object sender, EventArgs e)
        {
            frmTiendas frmTiendas = new frmTiendas();
            frmTiendas.ShowDialog();

        }

        private void btnEditoriales_Click(object sender, EventArgs e)
        {
            frmEditoriales ventas = new frmEditoriales();
            ventas.ShowDialog();
        }

        private void btnProgramacionRegalias_Click(object sender, EventArgs e)
        {
            frmProgramacionRegalias regalias = new frmProgramacionRegalias();
            regalias.ShowDialog();
        }

        private void btnPuestosTrabajo_Click(object sender, EventArgs e)
        {
            frmPuestoTrabajo trabajo = new frmPuestoTrabajo();
            trabajo.ShowDialog();
        }

        private void btnInformacionEditorial_Click(object sender, EventArgs e)
        {
            frmInfoEditorial editorial  = new frmInfoEditorial();
            editorial.ShowDialog();
        }

        private void btnAutoresTitulos_Click(object sender, EventArgs e)
        {
            frmAutoresTitulos autoresTitulos = new frmAutoresTitulos();
            autoresTitulos.ShowDialog();
        }
    }
}
