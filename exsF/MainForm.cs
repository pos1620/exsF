/*
 * Created by SharpDevelop.
 * User: home
 * Date: 06/01/2019
 * Time: 10:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using exsF.classes;
using System.Diagnostics;
using System.Threading;
namespace exsF
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
			vendedor v= new vendedor();
			produto prod= new produto();
			//Consultar cons2 = new Consultar();
		public MainForm()
		{
			InitializeComponent();
			
		}
		public MainForm(vendedor v2)
		{
			InitializeComponent();
			v=v2;
		
		}
		void Button1Click(object sender, EventArgs e)
		{
		//	MessageBox.Show("tipo:"+saindo);
		//	new TratamentoErro().OperationWindowList(new Cadastro());
		}
		void TextBox3KeyPress(object sender, KeyPressEventArgs e)
		{
		}
		
		public void saindo(object sender, EventArgs e){
			Application.Exit();
		}
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
			var ctx= new ContextMenu();
ctx.MenuItems.Add(new MenuItem("sair",saindo));
notifyIcon1.ContextMenu=ctx;
		}
		void ToolTip1Popup(object sender, PopupEventArgs e)
		{
	
		}
		void CadastrarToolStripMenuItemClick(object sender, EventArgs e)
		{

	var cad=new Cadastro(v,prod);
	cad.resLABEL.Text="Desenvolvido por "+v.Engineer;
	cad.precoTXT.Text="0";
	cad.Show();	
//	this.Hide();
//	this.Close();

		}
		
		void SobreToolStripMenuItemClick(object sender, EventArgs e)
		{
		new Sobre().ShowDialog();
			
		}



		void ConsultarToolStripMenuItemClick(object sender, EventArgs e)
		{
	
			Consultar cons = new Consultar(v,prod);
			cons.ProdutoCombobox.Items.Add(v);
			cons.Show();
		
		//cons2.Show();
		//this.Hide();
		//this.Close();
		}
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
		//	Application.Exit();
		this.Close();
		
		}
		
		
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
		
		public string IrAOsIte(string site="https://github.com/pos1620/exsF"){
		      		//site="select site from exs";
		      		 	return site;
		}
	
		void ÃToolStripMenuItemClick(object sender, EventArgs e)
		{
	
			Process.Start(IrAOsIte());
		}
		void ProgressoToolStripMenuItemClick(object sender, EventArgs e)
		{
			new Progresso().Show();
		}
		void GeralToolStripMenuItemClick(object sender, EventArgs e)
		{
			new tabelaMenu().Show();
		}
		
		
		}//fim classe
	}//fim namespace
