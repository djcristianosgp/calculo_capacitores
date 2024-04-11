namespace tabela_capacitor.View
{
	partial class FrmCalculoImpedancia
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculoImpedancia));
			label1 = new Label();
			cbxImpedancia = new ComboBox();
			cbxCorte = new ComboBox();
			label2 = new Label();
			panel1 = new Panel();
			btnCalcular = new Button();
			groupBox1 = new GroupBox();
			lblResultado = new Label();
			gbGrafico = new GroupBox();
			panel3 = new Panel();
			label4 = new Label();
			panel2 = new Panel();
			label3 = new Label();
			panel1.SuspendLayout();
			groupBox1.SuspendLayout();
			gbGrafico.SuspendLayout();
			panel3.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 18);
			label1.Name = "label1";
			label1.Size = new Size(162, 15);
			label1.TabIndex = 0;
			label1.Text = "Impedância do Drive (Ohms):";
			// 
			// cbxImpedancia
			// 
			cbxImpedancia.BackColor = SystemColors.ControlDark;
			cbxImpedancia.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxImpedancia.FormattingEnabled = true;
			cbxImpedancia.Location = new Point(12, 36);
			cbxImpedancia.Name = "cbxImpedancia";
			cbxImpedancia.Size = new Size(162, 23);
			cbxImpedancia.TabIndex = 1;
			cbxImpedancia.SelectedIndexChanged += cbxImpedancia_SelectedIndexChanged;
			// 
			// cbxCorte
			// 
			cbxCorte.BackColor = SystemColors.ControlDark;
			cbxCorte.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxCorte.FormattingEnabled = true;
			cbxCorte.Location = new Point(180, 36);
			cbxCorte.Name = "cbxCorte";
			cbxCorte.Size = new Size(162, 23);
			cbxCorte.TabIndex = 4;
			cbxCorte.SelectedIndexChanged += cbxCorte_SelectedIndexChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(180, 18);
			label2.Name = "label2";
			label2.Size = new Size(149, 15);
			label2.TabIndex = 3;
			label2.Text = "Corte Inicial Desejado (Hz):";
			// 
			// panel1
			// 
			panel1.Controls.Add(btnCalcular);
			panel1.Controls.Add(cbxImpedancia);
			panel1.Controls.Add(cbxCorte);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(label2);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(520, 80);
			panel1.TabIndex = 5;
			// 
			// btnCalcular
			// 
			btnCalcular.Dock = DockStyle.Right;
			btnCalcular.Enabled = false;
			btnCalcular.FlatAppearance.BorderSize = 0;
			btnCalcular.FlatStyle = FlatStyle.Flat;
			btnCalcular.Image = (Image)resources.GetObject("btnCalcular.Image");
			btnCalcular.Location = new Point(412, 0);
			btnCalcular.Name = "btnCalcular";
			btnCalcular.Size = new Size(108, 80);
			btnCalcular.TabIndex = 5;
			btnCalcular.Text = "Calcular";
			btnCalcular.TextImageRelation = TextImageRelation.ImageAboveText;
			btnCalcular.UseVisualStyleBackColor = true;
			btnCalcular.Click += btnCalcular_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(lblResultado);
			groupBox1.Dock = DockStyle.Top;
			groupBox1.ForeColor = Color.White;
			groupBox1.Location = new Point(0, 80);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(520, 100);
			groupBox1.TabIndex = 7;
			groupBox1.TabStop = false;
			groupBox1.Text = "Capacitor";
			// 
			// lblResultado
			// 
			lblResultado.Dock = DockStyle.Fill;
			lblResultado.Font = new Font("Segoe UI", 14F);
			lblResultado.Location = new Point(3, 19);
			lblResultado.Name = "lblResultado";
			lblResultado.Size = new Size(514, 78);
			lblResultado.TabIndex = 2;
			lblResultado.Text = "...";
			lblResultado.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// gbGrafico
			// 
			gbGrafico.Controls.Add(panel3);
			gbGrafico.Controls.Add(panel2);
			gbGrafico.Dock = DockStyle.Top;
			gbGrafico.ForeColor = Color.White;
			gbGrafico.Location = new Point(0, 180);
			gbGrafico.Name = "gbGrafico";
			gbGrafico.Size = new Size(520, 100);
			gbGrafico.TabIndex = 8;
			gbGrafico.TabStop = false;
			gbGrafico.Text = "Gráfico";
			// 
			// panel3
			// 
			panel3.BackColor = Color.IndianRed;
			panel3.Controls.Add(label4);
			panel3.Location = new Point(38, 66);
			panel3.Name = "panel3";
			panel3.Size = new Size(34, 28);
			panel3.TabIndex = 1;
			panel3.Visible = false;
			// 
			// label4
			// 
			label4.Dock = DockStyle.Top;
			label4.FlatStyle = FlatStyle.Flat;
			label4.Font = new Font("Segoe UI", 8F);
			label4.Location = new Point(0, 0);
			label4.Name = "label4";
			label4.Size = new Size(34, 15);
			label4.TabIndex = 0;
			label4.Text = "label4";
			// 
			// panel2
			// 
			panel2.BackColor = Color.IndianRed;
			panel2.Controls.Add(label3);
			panel2.Location = new Point(3, 80);
			panel2.Name = "panel2";
			panel2.Size = new Size(34, 14);
			panel2.TabIndex = 0;
			panel2.Visible = false;
			// 
			// label3
			// 
			label3.Dock = DockStyle.Top;
			label3.Font = new Font("Segoe UI", 8F);
			label3.Location = new Point(0, 0);
			label3.Name = "label3";
			label3.Size = new Size(34, 15);
			label3.TabIndex = 0;
			label3.Text = "label3";
			// 
			// FrmCalculoImpedancia
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDarkDark;
			ClientSize = new Size(520, 285);
			Controls.Add(gbGrafico);
			Controls.Add(groupBox1);
			Controls.Add(panel1);
			ForeColor = Color.White;
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "FrmCalculoImpedancia";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Calculo do capacitor";
			Load += FrmCalculoImpedancia_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			groupBox1.ResumeLayout(false);
			gbGrafico.ResumeLayout(false);
			panel3.ResumeLayout(false);
			panel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private ComboBox cbxImpedancia;
		private ComboBox cbxCorte;
		private Label label2;
		private Panel panel1;
		private Button btnCalcular;
		private GroupBox groupBox1;
		private Label lblResultado;
		private GroupBox gbGrafico;
		private Panel panel2;
		private Label label3;
		private Panel panel3;
		private Label label4;
	}
}