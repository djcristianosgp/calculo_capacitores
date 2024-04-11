namespace tabela_capacitor.View
{
	partial class FrmListaCapacitores
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaCapacitores));
			tvFrequencisa = new TreeView();
			imageListTree = new ImageList(components);
			groupBox1 = new GroupBox();
			groupBoxdados = new GroupBox();
			groupBox2 = new GroupBox();
			btnCalculo = new Button();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// tvFrequencisa
			// 
			tvFrequencisa.ImageIndex = 0;
			tvFrequencisa.ImageList = imageListTree;
			tvFrequencisa.Location = new Point(25, 35);
			tvFrequencisa.Name = "tvFrequencisa";
			tvFrequencisa.SelectedImageIndex = 0;
			tvFrequencisa.Size = new Size(121, 294);
			tvFrequencisa.TabIndex = 0;
			tvFrequencisa.AfterSelect += tvFrequencisa_AfterSelect;
			// 
			// imageListTree
			// 
			imageListTree.ColorDepth = ColorDepth.Depth32Bit;
			imageListTree.ImageStream = (ImageListStreamer)resources.GetObject("imageListTree.ImageStream");
			imageListTree.TransparentColor = Color.Transparent;
			imageListTree.Images.SetKeyName(0, "2.png");
			imageListTree.Images.SetKeyName(1, "1.png");
			imageListTree.Images.SetKeyName(2, "3.png");
			imageListTree.Images.SetKeyName(3, "4.png");
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(tvFrequencisa);
			groupBox1.Dock = DockStyle.Fill;
			groupBox1.ForeColor = Color.White;
			groupBox1.Location = new Point(0, 0);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(580, 335);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Frequencias:";
			// 
			// groupBoxdados
			// 
			groupBoxdados.Dock = DockStyle.Bottom;
			groupBoxdados.ForeColor = Color.White;
			groupBoxdados.Location = new Point(0, 335);
			groupBoxdados.Name = "groupBoxdados";
			groupBoxdados.Size = new Size(690, 115);
			groupBoxdados.TabIndex = 2;
			groupBoxdados.TabStop = false;
			groupBoxdados.Text = "Gráfico:";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(btnCalculo);
			groupBox2.Dock = DockStyle.Right;
			groupBox2.ForeColor = Color.White;
			groupBox2.Location = new Point(580, 0);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(110, 335);
			groupBox2.TabIndex = 3;
			groupBox2.TabStop = false;
			groupBox2.Text = "Ações:";
			groupBox2.Visible = false;
			// 
			// btnCalculo
			// 
			btnCalculo.BackColor = SystemColors.ControlDarkDark;
			btnCalculo.Dock = DockStyle.Top;
			btnCalculo.FlatAppearance.BorderSize = 0;
			btnCalculo.FlatStyle = FlatStyle.Flat;
			btnCalculo.Image = (Image)resources.GetObject("btnCalculo.Image");
			btnCalculo.Location = new Point(3, 19);
			btnCalculo.Name = "btnCalculo";
			btnCalculo.Size = new Size(104, 55);
			btnCalculo.TabIndex = 1;
			btnCalculo.Text = "Calculadora";
			btnCalculo.TextImageRelation = TextImageRelation.ImageAboveText;
			btnCalculo.UseVisualStyleBackColor = false;
			// 
			// FrmListaCapacitores
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDark;
			ClientSize = new Size(690, 450);
			Controls.Add(groupBox1);
			Controls.Add(groupBox2);
			Controls.Add(groupBoxdados);
			ForeColor = Color.White;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "FrmListaCapacitores";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Calculo de Capacitores - Lista";
			Load += FrmListaCapacitores_Load;
			groupBox1.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TreeView tvFrequencisa;
		private GroupBox groupBox1;
		private GroupBox groupBoxdados;
		private ImageList imageListTree;
		private GroupBox groupBox2;
		private Button btnCalculo;
	}
}