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
	//		new Cadastro().Show();
	var x=new Cadastro();
	x.resLABEL.Text="Desenvolvido por alxsy mostovik";
	x.Show();
						
		}
		void SobreToolStripMenuItemClick(object sender, EventArgs e)
		{
		new Sobre().Show();
		
		}
		
		
		}//fim classe
	}//fim namespace
