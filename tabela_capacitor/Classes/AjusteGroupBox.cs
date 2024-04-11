using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabela_capacitor.ViewModel;

namespace tabela_capacitor.Classes
{
	public class AjusteGroupBox
	{
		public static async Task<GroupBox> MontaGrafico(int corteInicial, GroupBox groupBox)
		{
			int ilargura = (groupBox.Width / ListagensItens.iCorte.Count());
			int ialtura = 14;
			int iposicaoinicialx = 2;
			int iposicaoinicialy = groupBox.Height - 3;
			groupBox.Controls.Clear();
			for (int icontador = 0; icontador < ListagensItens.iCorte.Count(); icontador++)
			{
				var label = new Label();
				var retCort = ListagensItens.iCorte[icontador] < 1000 ? $"{ListagensItens.iCorte[icontador]}Hz" : $"{Convert.ToDouble(ListagensItens.iCorte[icontador]) / 1000}KHz";
				label.Text = retCort;
				label.Dock = DockStyle.Top;
				label.Font = new Font("Segoe UI", 6F);
				label.AutoSize = false;
				label.TextAlign = ContentAlignment.TopCenter;
				label.Name = $"Label{icontador}";

				ialtura = ListagensItens.iCorte[icontador] >= corteInicial ? groupBox.Height - 20 : ialtura;

				var panel = new Panel();
				panel.Size = new Size(ilargura, ialtura);
				panel.Location = new Point(iposicaoinicialx, iposicaoinicialy - ialtura);
				panel.BackColor = ListagensItens.iCorte[icontador] >= corteInicial ? Color.DarkGreen : Color.IndianRed;
				panel.Name = $"Panel{icontador}";
				iposicaoinicialx = iposicaoinicialx + ilargura;
				ialtura = ialtura + ((groupBox.Height - 20) / ListagensItens.iCorte.Count());

				panel.Controls.Add(label);
				groupBox.Controls.Add(panel);
			}
			return groupBox;


		}
	}
}
