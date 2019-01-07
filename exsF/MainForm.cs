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
using exsF.mthds;
namespace exsF
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
			
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
		}
		void TextBox3KeyPress(object sender, KeyPressEventArgs e)
		{
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void ToolTip1Popup(object sender, PopupEventArgs e)
		{
	
		}
		void CadastrarToolStripMenuItemClick(object sender, EventArgs e)
		{
	
	var cad=new Cadastro();
	cad.resLABEL.Text="Desenvolvido por "+new Valores().Engineer;
	cad.precoTXT.Text="0";
	this.Hide();
	cad.Show();
							
		}
		void SobreToolStripMenuItemClick(object sender, EventArgs e)
		{
		new Sobre().Show();
		
		}

			Valores v2= new Valores();
		public Valores QuemSou(Valores ob){
				v2 =ob;
			return v2;
}

public Valores QuemSou3(){
			return v2;
}		
		
		
		void ConsultarToolStripMenuItemClick(object sender, EventArgs e)
		{
		//new Consultar(QuemSou(v2)).Show();
		new Consultar(QuemSou3()).Show();
		this.Hide();
		}
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
		
		
		}//fim classe
	}//fim namespace
