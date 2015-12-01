using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemPrestamos.Reportes
{
    public partial class PrestamosReportes : Form
    {
        public PrestamosReportes()
        {
            InitializeComponent();
        }

        private void Cobradoresbutton_Click(object sender, EventArgs e)
        {
            VisorCobradoresReporte vcr = new VisorCobradoresReporte();
            CobradoresReport cr = new CobradoresReport();
            vcr.VisorCobradorescrystalReportViewer.ReportSource = cr;
            vcr.ShowDialog();
        }

        private void Clientesbutton_Click(object sender, EventArgs e)
        {
            VisorClientesReporte vcrp = new VisorClientesReporte();
            ClientesReport crp = new ClientesReport();
            vcrp.VisorClientescrystalReportViewer.ReportSource = crp;
            vcrp.ShowDialog();
        }

        private void Rutasbutton_Click(object sender, EventArgs e)
        {
            VisorRutasReporte vrp = new VisorRutasReporte();
            RutasReport rp = new RutasReport();
            vrp.VisorRutascrystalReportViewer.ReportSource = rp;
            vrp.ShowDialog();
        }

        private void Prestamosbutton_Click(object sender, EventArgs e)
        {
            VisorPrestamosReporte vpr = new VisorPrestamosReporte();
            PrestamosReport pr = new PrestamosReport();
            vpr.VisorPrestamoscrystalReportViewer.ReportSource = pr;
            vpr.ShowDialog();
        }

        private void Atrasosbutton_Click(object sender, EventArgs e)
        {
            VisorAtrasosReporte var = new VisorAtrasosReporte();
            AtrasosReport ar = new AtrasosReport();
            var.VisorAtrasoscrystalReportViewer.ReportSource = ar;
            var.ShowDialog();
        }

        private void Usuariosbutton_Click(object sender, EventArgs e)
        {
            VisorUsuariosReporte vur = new VisorUsuariosReporte();
            UsuariosReport ur = new UsuariosReport();
            vur.VisorUsuarioscrystalReportViewer.ReportSource = ur;
            vur.ShowDialog();
        }
    }
}
