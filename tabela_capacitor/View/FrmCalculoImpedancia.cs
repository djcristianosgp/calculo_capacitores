using tabela_capacitor.Classes;
using tabela_capacitor.ViewModel;

namespace tabela_capacitor.View
{
	public partial class FrmCalculoImpedancia : Form
	{
		public FrmCalculoImpedancia()
		{
			InitializeComponent();
		}

		private void FrmCalculoImpedancia_Load(object sender, EventArgs e)
		{
			cbxImpedancia.Items.Clear();
			foreach (var item in ListagensItens.iImpedancia)
				cbxImpedancia.Items.Add(item);
			cbxImpedancia.SelectedIndex = cbxImpedancia.Items.Count > 0 ? 0 : -1;

			cbxCorte.Items.Clear();
			foreach (var item in ListagensItens.iCorte)
				cbxCorte.Items.Add(item);
			cbxCorte.SelectedIndex = cbxCorte.Items.Count > 0 ? 0 : -1;
		}

		private void btnCalcular_Click(object sender, EventArgs e)
		{
			CalcularCapacitor();
		}

		private void cbxImpedancia_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnCalcular.Enabled = Valida();
		}

		private void cbxCorte_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnCalcular.Enabled = Valida();
		}

		private bool Valida()
		{
			if (cbxCorte.SelectedIndex < 0)
				return false;
			if (cbxImpedancia.SelectedIndex < 0)
				return false;

			return true;

		}

		private async void CalcularCapacitor()
		{
			int iImpedancia = Convert.ToInt32(cbxImpedancia.SelectedItem.ToString());
			int iCorteInicial = Convert.ToInt32(cbxCorte.SelectedItem.ToString());

			var calculo01 = (iImpedancia * iCorteInicial);
			var calculo02 = (0.16 / calculo01);
			var calculo03 = (calculo02 * 1000000);

			lblResultado.Text = $"Capacitor aproximado: {String.Format("{0:#.#,##}", calculo03)} uF";
			gbGrafico = await AjusteGroupBox.MontaGrafico(iCorteInicial,gbGrafico);
			//=(0,16/(K2*K1)*1000000)
		}

		
	}
}
