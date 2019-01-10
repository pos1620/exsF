/*
 * Created by SharpDevelop.
 * User: home
 * Date: 07/01/2019
 * Time: 08:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using exsF.classes;

namespace exsF
{
	/// <summary>
	/// Description of Conaultar.
	/// </summary>
	public partial class Consultar : Form
	{
		vendedor v3 = new vendedor();
		produto prod3 = new produto();
		public Consultar()
		{
			InitializeComponent();
		}
		public void preencher(vendedor v,produto prod){
			nomeLABEL.Text="Nome="+v.Nome;
			phoneLABEL.Text="Telefone="+v.Phone;
			produtoLABEL.Text="Produto="+prod.TipoProduto;
			emailLABEL.Text="Email="+v.Email;
			precoLABEL.Text="Preco="+v.Preco.ToString("f2");
			urlLABEL.Text="Url="+v.Url;
		}
		public Consultar(vendedor v,produto prod)
		{
			InitializeComponent();
			v3=v;
			prod3=prod;
			preencher(v,prod);
		}
		void ConsultarLoad(object sender, EventArgs e)
		{
		//	ProdutoCombobox.DataSource=v3.engineer;
			dataGridViewDb.DataSource=v3.Engineer;
		
		}
		void Button1Click(object sender, EventArgs e)
		{
			nomeLABEL.Text="Nome="+new Valores().Engineer;
			//new TratamentoErro().OperationWindow(new MainForm(),"retomar");
		
		}
		void ConsultarFormClosing(object sender, FormClosingEventArgs e)
		{
		//	this.Close();
		
			MainForm m = new MainForm();
//			m.OperationWinwdow(m,"retomar");
		}
		void ConsultarFormClosed(object sender, FormClosedEventArgs e)
		{
			
		//	MainForm m = new MainForm();
		//	m.OperationWinwdow(m,"retomar");
		
		}
		void ProdutoComboboxSelectedIndexChanged(object sender, EventArgs e)
		{
			MessageBox.Show(v3.TipoProduto);
		}
	}
}//
