namespace tabela_capacitor.View
{
	partial class FrmPainel
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPainel));
			btnCalculo = new Button();
			btnListagem = new Button();
			statusStrip1 = new StatusStrip();
			lblVersao = new ToolStripStatusLabel();
			toolStripStatusLabel1 = new ToolStripStatusLabel();
			statusStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// btnCalculo
			// 
			btnCalculo.BackColor = SystemColors.ControlDarkDark;
			btnCalculo.FlatAppearance.BorderSize = 0;
			btnCalculo.FlatStyle = FlatStyle.Flat;
			btnCalculo.Image = (Image)resources.GetObject("btnCalculo.Image");
			btnCalculo.Location = new Point(12, 12);
			btnCalculo.Name = "btnCalculo";
			btnCalculo.Size = new Size(180, 100);
			btnCalculo.TabIndex = 0;
			btnCalculo.Text = "Calculadora";
			btnCalculo.TextImageRelation = TextImageRelation.ImageAboveText;
			btnCalculo.UseVisualStyleBackColor = false;
			btnCalculo.Click += btnCalculo_Click;
			// 
			// btnListagem
			// 
			btnListagem.BackColor = SystemColors.ControlDarkDark;
			btnListagem.FlatAppearance.BorderSize = 0;
			btnListagem.FlatStyle = FlatStyle.Flat;
			btnListagem.Image = (Image)resources.GetObject("btnListagem.Image");
			btnListagem.Location = new Point(204, 12);
			btnListagem.Name = "btnListagem";
			btnListagem.Size = new Size(180, 100);
			btnListagem.TabIndex = 1;
			btnListagem.Text = "Listagem";
			btnListagem.TextImageRelation = TextImageRelation.ImageAboveText;
			btnListagem.UseVisualStyleBackColor = false;
			btnListagem.Click += btnListagem_Click;
			// 
			// statusStrip1
			// 
			statusStrip1.Items.AddRange(new ToolStripItem[] { lblVersao, toolStripStatusLabel1 });
			statusStrip1.Location = new Point(0, 120);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(395, 22);
			statusStrip1.TabIndex = 2;
			statusStrip1.Text = "statusStrip1";
			// 
			// lblVersao
			// 
			lblVersao.BackColor = Color.Transparent;
			lblVersao.ForeColor = Color.Black;
			lblVersao.Name = "lblVersao";
			lblVersao.Size = new Size(118, 17);
			lblVersao.Text = "toolStripStatusLabel1";
			// 
			// toolStripStatusLabel1
			// 
			toolStripStatusLabel1.BackColor = Color.Transparent;
			toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			toolStripStatusLabel1.Size = new Size(213, 17);
			toolStripStatusLabel1.Text = " | Desenvolvido por: Cristiano Grobério ";
			toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
			// 
			// FrmPainel
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDark;
			ClientSize = new Size(395, 142);
			Controls.Add(btnListagem);
			Controls.Add(btnCalculo);
			Controls.Add(statusStrip1);
			ForeColor = Color.Black;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "FrmPainel";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Calculo de Capacitores - Painel";
			Load += FrmPainel_Load;
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnCalculo;
		private Button btnListagem;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel lblVersao;
		private ToolStripStatusLabel toolStripStatusLabel1;
	}
}