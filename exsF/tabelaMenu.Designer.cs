/*
 * Created by SharpDevelop.
 * User: home
 * Date: 18/01/2019
 * Time: 12:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace exsF
{
	partial class tabelaMenu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		public System.Windows.Forms.TextBox precoTXT;
		private System.Windows.Forms.Label precoLABEL;
		private System.Windows.Forms.TextBox tipoTXT;
		private System.Windows.Forms.Label tipoLABEL;
		private System.Windows.Forms.TextBox urlTXT;
		private System.Windows.Forms.Label urlLABEL;
		public System.Windows.Forms.Label resLABEL;
		private System.Windows.Forms.Label valorLABEL;
		private System.Windows.Forms.TextBox phoneTXT;
		private System.Windows.Forms.TextBox emailTXT;
		private System.Windows.Forms.TextBox nomeTXT;
		private System.Windows.Forms.Button buttonGRAVAR;
		private System.Windows.Forms.Label phoneLABEL;
		private System.Windows.Forms.Label emailLABEL;
		private System.Windows.Forms.Label nomeLABEL;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridViewDb;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label produtoLABEL;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.ComboBox ProdutoCombobox;
		private System.Windows.Forms.Button button1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabelaMenu));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.precoTXT = new System.Windows.Forms.TextBox();
			this.precoLABEL = new System.Windows.Forms.Label();
			this.tipoTXT = new System.Windows.Forms.TextBox();
			this.tipoLABEL = new System.Windows.Forms.Label();
			this.urlTXT = new System.Windows.Forms.TextBox();
			this.urlLABEL = new System.Windows.Forms.Label();
			this.resLABEL = new System.Windows.Forms.Label();
			this.valorLABEL = new System.Windows.Forms.Label();
			this.phoneTXT = new System.Windows.Forms.TextBox();
			this.emailTXT = new System.Windows.Forms.TextBox();
			this.nomeTXT = new System.Windows.Forms.TextBox();
			this.buttonGRAVAR = new System.Windows.Forms.Button();
			this.phoneLABEL = new System.Windows.Forms.Label();
			this.emailLABEL = new System.Windows.Forms.Label();
			this.nomeLABEL = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridViewDb = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.produtoLABEL = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.ProdutoCombobox = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDb)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 21);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(638, 287);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.maskedTextBox1);
			this.tabPage1.Controls.Add(this.precoTXT);
			this.tabPage1.Controls.Add(this.precoLABEL);
			this.tabPage1.Controls.Add(this.tipoTXT);
			this.tabPage1.Controls.Add(this.tipoLABEL);
			this.tabPage1.Controls.Add(this.urlTXT);
			this.tabPage1.Controls.Add(this.urlLABEL);
			this.tabPage1.Controls.Add(this.resLABEL);
			this.tabPage1.Controls.Add(this.valorLABEL);
			this.tabPage1.Controls.Add(this.phoneTXT);
			this.tabPage1.Controls.Add(this.emailTXT);
			this.tabPage1.Controls.Add(this.nomeTXT);
			this.tabPage1.Controls.Add(this.buttonGRAVAR);
			this.tabPage1.Controls.Add(this.phoneLABEL);
			this.tabPage1.Controls.Add(this.emailLABEL);
			this.tabPage1.Controls.Add(this.nomeLABEL);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(630, 261);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Cadastro";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.dataGridViewDb);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.produtoLABEL);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.ProdutoCombobox);
			this.tabPage2.Controls.Add(this.button1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(630, 261);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Consultar";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(447, 66);
			this.maskedTextBox1.Mask = "+00(00)00000-0000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
			this.maskedTextBox1.TabIndex = 43;
			// 
			// precoTXT
			// 
			this.precoTXT.Location = new System.Drawing.Point(447, 121);
			this.precoTXT.Name = "precoTXT";
			this.precoTXT.Size = new System.Drawing.Size(100, 20);
			this.precoTXT.TabIndex = 42;
			// 
			// precoLABEL
			// 
			this.precoLABEL.Location = new System.Drawing.Point(394, 118);
			this.precoLABEL.Name = "precoLABEL";
			this.precoLABEL.Size = new System.Drawing.Size(100, 23);
			this.precoLABEL.TabIndex = 41;
			this.precoLABEL.Text = "Preço";
			// 
			// tipoTXT
			// 
			this.tipoTXT.Location = new System.Drawing.Point(288, 121);
			this.tipoTXT.Name = "tipoTXT";
			this.tipoTXT.Size = new System.Drawing.Size(100, 20);
			this.tipoTXT.TabIndex = 40;
			// 
			// tipoLABEL
			// 
			this.tipoLABEL.Location = new System.Drawing.Point(248, 118);
			this.tipoLABEL.Name = "tipoLABEL";
			this.tipoLABEL.Size = new System.Drawing.Size(100, 23);
			this.tipoLABEL.TabIndex = 39;
			this.tipoLABEL.Text = "Tipo";
			// 
			// urlTXT
			// 
			this.urlTXT.Location = new System.Drawing.Point(118, 118);
			this.urlTXT.Name = "urlTXT";
			this.urlTXT.Size = new System.Drawing.Size(124, 20);
			this.urlTXT.TabIndex = 38;
			// 
			// urlLABEL
			// 
			this.urlLABEL.Location = new System.Drawing.Point(78, 121);
			this.urlLABEL.Name = "urlLABEL";
			this.urlLABEL.Size = new System.Drawing.Size(100, 23);
			this.urlLABEL.TabIndex = 37;
			this.urlLABEL.Text = "Url";
			// 
			// resLABEL
			// 
			this.resLABEL.Location = new System.Drawing.Point(54, 225);
			this.resLABEL.Name = "resLABEL";
			this.resLABEL.Size = new System.Drawing.Size(204, 22);
			this.resLABEL.TabIndex = 36;
			this.resLABEL.Text = "Engenheiro de Sist.";
			// 
			// valorLABEL
			// 
			this.valorLABEL.Location = new System.Drawing.Point(153, 161);
			this.valorLABEL.Name = "valorLABEL";
			this.valorLABEL.Size = new System.Drawing.Size(135, 23);
			this.valorLABEL.TabIndex = 35;
			this.valorLABEL.Text = "valor=0";
			// 
			// phoneTXT
			// 
			this.phoneTXT.Location = new System.Drawing.Point(447, 92);
			this.phoneTXT.Name = "phoneTXT";
			this.phoneTXT.Size = new System.Drawing.Size(100, 20);
			this.phoneTXT.TabIndex = 34;
			// 
			// emailTXT
			// 
			this.emailTXT.Location = new System.Drawing.Point(288, 92);
			this.emailTXT.Name = "emailTXT";
			this.emailTXT.Size = new System.Drawing.Size(100, 20);
			this.emailTXT.TabIndex = 33;
			// 
			// nomeTXT
			// 
			this.nomeTXT.Location = new System.Drawing.Point(118, 92);
			this.nomeTXT.Name = "nomeTXT";
			this.nomeTXT.Size = new System.Drawing.Size(124, 20);
			this.nomeTXT.TabIndex = 32;
			// 
			// buttonGRAVAR
			// 
			this.buttonGRAVAR.Location = new System.Drawing.Point(334, 202);
			this.buttonGRAVAR.Name = "buttonGRAVAR";
			this.buttonGRAVAR.Size = new System.Drawing.Size(242, 23);
			this.buttonGRAVAR.TabIndex = 31;
			this.buttonGRAVAR.Text = "Gravar Dados";
			this.buttonGRAVAR.UseVisualStyleBackColor = true;
			// 
			// phoneLABEL
			// 
			this.phoneLABEL.Location = new System.Drawing.Point(394, 95);
			this.phoneLABEL.Name = "phoneLABEL";
			this.phoneLABEL.Size = new System.Drawing.Size(100, 23);
			this.phoneLABEL.TabIndex = 30;
			this.phoneLABEL.Text = "Telefone";
			// 
			// emailLABEL
			// 
			this.emailLABEL.Location = new System.Drawing.Point(248, 95);
			this.emailLABEL.Name = "emailLABEL";
			this.emailLABEL.Size = new System.Drawing.Size(100, 17);
			this.emailLABEL.TabIndex = 29;
			this.emailLABEL.Text = "Email";
			// 
			// nomeLABEL
			// 
			this.nomeLABEL.Location = new System.Drawing.Point(78, 95);
			this.nomeLABEL.Name = "nomeLABEL";
			this.nomeLABEL.Size = new System.Drawing.Size(100, 17);
			this.nomeLABEL.TabIndex = 28;
			this.nomeLABEL.Text = "Nome";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(142, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 23);
			this.label1.TabIndex = 27;
			this.label1.Text = "exs";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(14, 151);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 17;
			this.label2.Text = "Url";
			// 
			// dataGridViewDb
			// 
			this.dataGridViewDb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDb.Location = new System.Drawing.Point(423, 28);
			this.dataGridViewDb.Name = "dataGridViewDb";
			this.dataGridViewDb.Size = new System.Drawing.Size(193, 150);
			this.dataGridViewDb.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(14, 197);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 15;
			this.label3.Text = "Preço";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(14, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 14;
			this.label4.Text = "Email";
			// 
			// produtoLABEL
			// 
			this.produtoLABEL.Location = new System.Drawing.Point(14, 174);
			this.produtoLABEL.Name = "produtoLABEL";
			this.produtoLABEL.Size = new System.Drawing.Size(100, 23);
			this.produtoLABEL.TabIndex = 13;
			this.produtoLABEL.Text = "Produto";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(14, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "Telefone";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(14, 82);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(182, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Nome";
			// 
			// ProdutoCombobox
			// 
			this.ProdutoCombobox.FormattingEnabled = true;
			this.ProdutoCombobox.Items.AddRange(new object[] {
			"BA",
			"SP",
			"RJ",
			"PI"});
			this.ProdutoCombobox.Location = new System.Drawing.Point(90, 28);
			this.ProdutoCombobox.Name = "ProdutoCombobox";
			this.ProdutoCombobox.Size = new System.Drawing.Size(121, 21);
			this.ProdutoCombobox.TabIndex = 10;
			this.ProdutoCombobox.Text = "Produto";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(388, 210);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(118, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "Acessar Site";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// tabelaMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(662, 320);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "tabelaMenu";
			this.Text = "tabelaMenu";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDb)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
