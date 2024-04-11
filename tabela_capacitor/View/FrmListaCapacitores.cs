using Newtonsoft.Json;
using tabela_capacitor.Classes;
using tabela_capacitor.ViewModel;

namespace tabela_capacitor.View
{
	public partial class FrmListaCapacitores : Form
	{
		public FrmListaCapacitores()
		{
			InitializeComponent();
		}

		string ultimaFreq = string.Empty;

		//private void button1_Click(object sender, EventArgs e)
		//{
		//	var lista = new List<ListaFrequenciasViewModel>();
		//	var item = new ListaFrequenciasViewModel();
		//	var imp = new ListaImpedanciasViewModel();
		//	var dados = new DadosImpedanciaViewModel();
		//	item.frequencia = textBox1.Text;
		//	imp.impedancia = textBox2.Text;
		//	dados.capacitor = textBox3.Text;
		//	dados.indutor = textBox4.Text;

		//	imp.dados = dados;
		//	item.impedancias.Add(imp);
		//	lista.Add(item);

		//	var ste = JsonSerializer.Serialize(lista);

		//	MessageBox.Show(ste);

		//}

		private void FrmListaCapacitores_Load(object sender, EventArgs e)
		{
			Inicializa();
		}

		public void Inicializa()
		{
			try
			{
				tvFrequencisa.Dock = DockStyle.Fill;
				var dadosJson = ReturnStringForFile.StringForFile("ListaCapacitores.json");

				if (dadosJson != null)
				{
					var dadosView = JsonConvert.DeserializeObject<List<ListaFrequenciasViewModel>>(dadosJson);
					tvFrequencisa.Nodes.Clear();
					foreach (var freq in dadosView)
					{
						var treFreq = new TreeNode();
						var retCort = Convert.ToInt32(freq.frequencia) < 1000 ? $"{freq.frequencia} Hz" : $"{Convert.ToDouble(freq.frequencia) / 1000} KHz";
						treFreq.Text = $"Frequência: {retCort}";
						treFreq.Tag = freq.frequencia;
						treFreq.ImageIndex = 0;
						treFreq.SelectedImageIndex = 0;
						foreach (var imp in freq.impedancias)
						{
							var treImp = new TreeNode();
							treImp.ImageIndex = 1;
							treImp.SelectedImageIndex = 1;
							treImp.Tag = freq.frequencia;
							treImp.Text = $"Impedância: {imp.impedancia} Ohms";
							var treCap = new TreeNode();
							treCap.ImageIndex = 2;
							treCap.SelectedImageIndex = 2;
							treCap.Tag = freq.frequencia;
							treCap.Text = $"Capacitor: {imp.dados.capacitor} uF";
							var treInd = new TreeNode();
							treInd.ImageIndex = 3;
							treInd.SelectedImageIndex = 3;
							treInd.Tag = freq.frequencia;
							treInd.Text = $"Indutor: {imp.dados.indutor} mH";

							treImp.Nodes.Add(treCap);
							treImp.Nodes.Add(treInd);

							treFreq.Nodes.Add(treImp);
						}
						tvFrequencisa.Nodes.Add(treFreq);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void tvFrequencisa_AfterSelect(object sender, TreeViewEventArgs e)
		{
			var tre = tvFrequencisa.SelectedNode;
			if (tre != null)
				if (tre.Tag != ultimaFreq)
				{
					groupBoxdados = AjusteGroupBox.MontaGrafico(Convert.ToInt32(tre.Tag), groupBoxdados).Result;
					ultimaFreq = tre.Tag.ToString();
				}
		}
	}
}
