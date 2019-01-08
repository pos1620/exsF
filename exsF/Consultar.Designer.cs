/*
 * Created by SharpDevelop.
 * User: home
 * Date: 07/01/2019
 * Time: 08:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace exsF
{
	partial class Consultar
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.ComboBox ProdutoCombobox;
		private System.Windows.Forms.Label nomeLABEL;
		private System.Windows.Forms.Label phoneLABEL;
		private System.Windows.Forms.Label produtoLABEL;
		private System.Windows.Forms.Label emailLABEL;
		private System.Windows.Forms.Label precoLABEL;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.ProdutoCombobox = new System.Windows.Forms.ComboBox();
			this.nomeLABEL = new System.Windows.Forms.Label();
			this.phoneLABEL = new System.Windows.Forms.Label();
			this.produtoLABEL = new System.Windows.Forms.Label();
			this.emailLABEL = new System.Windows.Forms.Label();
			this.precoLABEL = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(396, 238);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(118, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Acessar Site";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// ProdutoCombobox
			// 
			this.ProdutoCombobox.FormattingEnabled = true;
			this.ProdutoCombobox.Items.AddRange(new object[] {
			"BA",
			"SP",
			"RJ",
			"PI"});
			this.ProdutoCombobox.Location = new System.Drawing.Point(98, 56);
			this.ProdutoCombobox.Name = "ProdutoCombobox";
			this.ProdutoCombobox.Size = new System.Drawing.Size(121, 21);
			this.ProdutoCombobox.TabIndex = 1;
			this.ProdutoCombobox.Text = "Produto";
			this.ProdutoCombobox.SelectedIndexChanged += new System.EventHandler(this.ProdutoComboboxSelectedIndexChanged);
			// 
			// nomeLABEL
			// 
			this.nomeLABEL.Location = new System.Drawing.Point(22, 110);
			this.nomeLABEL.Name = "nomeLABEL";
			this.nomeLABEL.Size = new System.Drawing.Size(182, 23);
			this.nomeLABEL.TabIndex = 2;
			this.nomeLABEL.Text = "Nome";
			// 
			// phoneLABEL
			// 
			this.phoneLABEL.Location = new System.Drawing.Point(22, 133);
			this.phoneLABEL.Name = "phoneLABEL";
			this.phoneLABEL.Size = new System.Drawing.Size(100, 23);
			this.phoneLABEL.TabIndex = 3;
			this.phoneLABEL.Text = "Telefone";
			// 
			// produtoLABEL
			// 
			this.produtoLABEL.Location = new System.Drawing.Point(22, 156);
			this.produtoLABEL.Name = "produtoLABEL";
			this.produtoLABEL.Size = new System.Drawing.Size(100, 23);
			this.produtoLABEL.TabIndex = 4;
			this.produtoLABEL.Text = "Produto";
			// 
			// emailLABEL
			// 
			this.emailLABEL.Location = new System.Drawing.Point(22, 179);
			this.emailLABEL.Name = "emailLABEL";
			this.emailLABEL.Size = new System.Drawing.Size(100, 23);
			this.emailLABEL.TabIndex = 5;
			this.emailLABEL.Text = "Email";
			// 
			// precoLABEL
			// 
			this.precoLABEL.Location = new System.Drawing.Point(22, 202);
			this.precoLABEL.Name = "precoLABEL";
			this.precoLABEL.Size = new System.Drawing.Size(100, 23);
			this.precoLABEL.TabIndex = 6;
			this.precoLABEL.Text = "Preço";
			// 
			// Consultar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(636, 273);
			this.Controls.Add(this.precoLABEL);
			this.Controls.Add(this.emailLABEL);
			this.Controls.Add(this.produtoLABEL);
			this.Controls.Add(this.phoneLABEL);
			this.Controls.Add(this.nomeLABEL);
			this.Controls.Add(this.ProdutoCombobox);
			this.Controls.Add(this.button1);
			this.Name = "Consultar";
			this.Text = "Consultar";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsultarFormClosed);
			this.Load += new System.EventHandler(this.ConsultarLoad);
			this.ResumeLayout(false);

		}
		}//fim classe
}//fim namespace
