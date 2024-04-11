using System.Diagnostics;
using System.Reflection;

namespace tabela_capacitor.View
{
	public partial class FrmPainel : Form
	{
		public FrmPainel()
		{
			InitializeComponent();
		}

		private void btnCalculo_Click(object sender, EventArgs e)
		{
			FrmCalculoImpedancia frmCalculoImpedancia = new FrmCalculoImpedancia();
			frmCalculoImpedancia.Show();
		}

		private void btnListagem_Click(object sender, EventArgs e)
		{
			FrmListaCapacitores frmListaCapacitores = new FrmListaCapacitores();
			frmListaCapacitores.Show();
		}

		private void FrmPainel_Load(object sender, EventArgs e)
		{
			lblVersao.Text = "Versão: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
		}

		private void toolStripStatusLabel1_Click(object sender, EventArgs e)
		{
			try
			{
				ProcessStartInfo info = new ProcessStartInfo("https://www.instagram.com/djcristianosgp");
				info.UseShellExecute = true;
				Process.Start(info);
			}
			catch (Exception ex)
			{
			}
		}
	}
}
