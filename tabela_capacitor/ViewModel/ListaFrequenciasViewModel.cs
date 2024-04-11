using System.Text.Json;

namespace tabela_capacitor.ViewModel
{
	public class ListaFrequenciasViewModel
	{
		public string frequencia { get; set; }
		public List<ListaImpedanciasViewModel> impedancias { get; set; } = new List<ListaImpedanciasViewModel>();
	}

	public class ListaImpedanciasViewModel
	{
		public string impedancia { get; set; }
		public DadosImpedanciaViewModel dados { get; set; } = new DadosImpedanciaViewModel();
	}

	public class DadosImpedanciaViewModel
	{
		public string capacitor { get; set; }
		public string indutor { get; set; }
	}

	//public class NovaLista
	//{
	//	//List<ListaFrequenciasViewModel> lista = new List<ListaFrequenciasViewModel>();
	//	//var item = new List<ListaFrequenciasViewModel>();
	//	//var imp = new ListaImpedanciasViewModel();
	//	//var dados = new DadosImpedanciaViewModel();
	//	//item.frequencia = textBox1.Text;
	//	//	imp.impedancia = textBox2.Text;
	//	//	dados.capacitor = textBox3.Text;
	//	//	dados.indutor = textBox4.Text;

	//	//	imp.dados = dados;
	//	//	item.impedancias.Add(imp);
	//	//	lista.Add(item);

	//	//	var ste = JsonSerializer.Serialize(lista);
	//}
}
