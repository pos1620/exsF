/*
 * Created by SharpDevelop.
 * User: home
 * Date: 06/01/2019
 * Time: 19:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace exsF
{
	partial class Cadastro
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public  System.Windows.Forms.Label resLABEL;
		private System.Windows.Forms.Label valorLABEL;
		private System.Windows.Forms.TextBox phoneTXT;
		private System.Windows.Forms.TextBox emailTXT;
		private System.Windows.Forms.TextBox nomeTXT;
		private System.Windows.Forms.Button buttonGRAVAR;
		private System.Windows.Forms.Label phoneLABEL;
		private System.Windows.Forms.Label emailLABEL;
		private System.Windows.Forms.Label nomeLABEL;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label urlLABEL;
		private System.Windows.Forms.TextBox urlTXT;
		private System.Windows.Forms.Label tipoLABEL;
		private System.Windows.Forms.TextBox tipoTXT;
		private System.Windows.Forms.Label precoLABEL;
		public  System.Windows.Forms.TextBox precoTXT;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
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
			this.urlLABEL = new System.Windows.Forms.Label();
			this.urlTXT = new System.Windows.Forms.TextBox();
			this.tipoLABEL = new System.Windows.Forms.Label();
			this.tipoTXT = new System.Windows.Forms.TextBox();
			this.precoLABEL = new System.Windows.Forms.Label();
			this.precoTXT = new System.Windows.Forms.TextBox();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// resLABEL
			// 
			this.resLABEL.Location = new System.Drawing.Point(12, 242);
			this.resLABEL.Name = "resLABEL";
			this.resLABEL.Size = new System.Drawing.Size(204, 22);
			this.resLABEL.TabIndex = 19;
			this.resLABEL.Text = "Engenheiro de Sist.";
			// 
			// valorLABEL
			// 
			this.valorLABEL.Location = new System.Drawing.Point(111, 178);
			this.valorLABEL.Name = "valorLABEL";
			this.valorLABEL.Size = new System.Drawing.Size(135, 23);
			this.valorLABEL.TabIndex = 18;
			this.valorLABEL.Text = "valor=0";
			// 
			// phoneTXT
			// 
			this.phoneTXT.Location = new System.Drawing.Point(405, 109);
			this.phoneTXT.Name = "phoneTXT";
			this.phoneTXT.Size = new System.Drawing.Size(100, 20);
			this.phoneTXT.TabIndex = 17;
			this.phoneTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox3KeyPress);
			// 
			// emailTXT
			// 
			this.emailTXT.Location = new System.Drawing.Point(246, 109);
			this.emailTXT.Name = "emailTXT";
			this.emailTXT.Size = new System.Drawing.Size(100, 20);
			this.emailTXT.TabIndex = 16;
			// 
			// nomeTXT
			// 
			this.nomeTXT.Location = new System.Drawing.Point(76, 109);
			this.nomeTXT.Name = "nomeTXT";
			this.nomeTXT.Size = new System.Drawing.Size(124, 20);
			this.nomeTXT.TabIndex = 15;
			// 
			// buttonGRAVAR
			// 
			this.buttonGRAVAR.Location = new System.Drawing.Point(292, 219);
			this.buttonGRAVAR.Name = "buttonGRAVAR";
			this.buttonGRAVAR.Size = new System.Drawing.Size(242, 23);
			this.buttonGRAVAR.TabIndex = 14;
			this.buttonGRAVAR.Text = "Gravar Dados";
			this.buttonGRAVAR.UseVisualStyleBackColor = true;
			this.buttonGRAVAR.Click += new System.EventHandler(this.Button1Click);
			// 
			// phoneLABEL
			// 
			this.phoneLABEL.Location = new System.Drawing.Point(352, 112);
			this.phoneLABEL.Name = "phoneLABEL";
			this.phoneLABEL.Size = new System.Drawing.Size(100, 23);
			this.phoneLABEL.TabIndex = 13;
			this.phoneLABEL.Text = "Telefone";
			// 
			// emailLABEL
			// 
			this.emailLABEL.Location = new System.Drawing.Point(206, 112);
			this.emailLABEL.Name = "emailLABEL";
			this.emailLABEL.Size = new System.Drawing.Size(100, 17);
			this.emailLABEL.TabIndex = 12;
			this.emailLABEL.Text = "Email";
			// 
			// nomeLABEL
			// 
			this.nomeLABEL.Location = new System.Drawing.Point(36, 112);
			this.nomeLABEL.Name = "nomeLABEL";
			this.nomeLABEL.Size = new System.Drawing.Size(100, 17);
			this.nomeLABEL.TabIndex = 11;
			this.nomeLABEL.Text = "Nome";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(100, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 23);
			this.label1.TabIndex = 10;
			this.label1.Text = "exs";
			// 
			// urlLABEL
			// 
			this.urlLABEL.Location = new System.Drawing.Point(36, 138);
			this.urlLABEL.Name = "urlLABEL";
			this.urlLABEL.Size = new System.Drawing.Size(100, 23);
			this.urlLABEL.TabIndex = 20;
			this.urlLABEL.Text = "Url";
			// 
			// urlTXT
			// 
			this.urlTXT.Location = new System.Drawing.Point(76, 135);
			this.urlTXT.Name = "urlTXT";
			this.urlTXT.Size = new System.Drawing.Size(124, 20);
			this.urlTXT.TabIndex = 21;
			// 
			// tipoLABEL
			// 
			this.tipoLABEL.Location = new System.Drawing.Point(206, 135);
			this.tipoLABEL.Name = "tipoLABEL";
			this.tipoLABEL.Size = new System.Drawing.Size(100, 23);
			this.tipoLABEL.TabIndex = 22;
			this.tipoLABEL.Text = "Tipo";
			// 
			// tipoTXT
			// 
			this.tipoTXT.Location = new System.Drawing.Point(246, 138);
			this.tipoTXT.Name = "tipoTXT";
			this.tipoTXT.Size = new System.Drawing.Size(100, 20);
			this.tipoTXT.TabIndex = 23;
			// 
			// precoLABEL
			// 
			this.precoLABEL.Location = new System.Drawing.Point(352, 135);
			this.precoLABEL.Name = "precoLABEL";
			this.precoLABEL.Size = new System.Drawing.Size(100, 23);
			this.precoLABEL.TabIndex = 24;
			this.precoLABEL.Text = "Preço";
			// 
			// precoTXT
			// 
			this.precoTXT.Location = new System.Drawing.Point(405, 138);
			this.precoTXT.Name = "precoTXT";
			this.precoTXT.Size = new System.Drawing.Size(100, 20);
			this.precoTXT.TabIndex = 25;
			this.precoTXT.Click += new System.EventHandler(this.PrecoTXTClick);
			this.precoTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecoTXTKeyPress);
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(405, 83);
			this.maskedTextBox1.Mask = "+00(00)00000-0000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
			this.maskedTextBox1.TabIndex = 26;
			// 
			// Cadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 273);
			this.Controls.Add(this.maskedTextBox1);
			this.Controls.Add(this.precoTXT);
			this.Controls.Add(this.precoLABEL);
			this.Controls.Add(this.tipoTXT);
			this.Controls.Add(this.tipoLABEL);
			this.Controls.Add(this.urlTXT);
			this.Controls.Add(this.urlLABEL);
			this.Controls.Add(this.resLABEL);
			this.Controls.Add(this.valorLABEL);
			this.Controls.Add(this.phoneTXT);
			this.Controls.Add(this.emailTXT);
			this.Controls.Add(this.nomeTXT);
			this.Controls.Add(this.buttonGRAVAR);
			this.Controls.Add(this.phoneLABEL);
			this.Controls.Add(this.emailLABEL);
			this.Controls.Add(this.nomeLABEL);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Cadastro";
			this.Text = "Cadastro";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroFormClosed);
			this.Load += new System.EventHandler(this.CadastroLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		}//fim classe
	}//fim namespace

