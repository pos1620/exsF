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
using exsF.mthds;

namespace exsF
{
	/// <summary>
	/// Description of Conaultar.
	/// </summary>
	public partial class Consultar : Form
	{
		Valores v3 = new Valores();
			
		public Consultar()
		{
			InitializeComponent();
		}
		public Consultar(Valores v2)
		{
			InitializeComponent();
			v3=v2;
		}
		void ConsultarLoad(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			nomeLABEL.Text="Nome="+new Valores().Engineer;
			MessageBox.Show("welcome "+v3.Nome);
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
