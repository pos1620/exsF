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
			Valores v2= new Valores();
			
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
		public MainForm(Valores v1)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			v2=v1;
		
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
	
	var cad=new Cadastro(v2);
	cad.resLABEL.Text="Desenvolvido por "+new Valores().Engineer;
	cad.precoTXT.Text="0";
	cad.Show();
	//cad.ShowDialog();
	//this.Hide();
 //if(this.IsDisposed)
        //cad.Close();							
		}
		void SobreToolStripMenuItemClick(object sender, EventArgs e)
		{
		new Sobre().ShowDialog();
		
		}

		public Valores QuemSou(Valores ob){
				v2 =ob;
			return v2;
}

public Valores QuemSou3(){
			return v2;
}		
	
	
		void ConsultarToolStripMenuItemClick(object sender, EventArgs e)
		{
	
		new Consultar(QuemSou3()).Show();;
		//this.Hide();
		//this.Close();
		}
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
		//	Application.Exit();
		this.Close();
		
		}
		
		
				
		
		public void OperationWinwdow(Object ob,string op){
			if(Application.OpenForms.Count==0){
				Application.Exit();
			}
			else{
				foreach(Form formA in Application.OpenForms)
					if(formA is Object && op.Equals("retomar")){
						formA.Show();
						//formA.Hide();
						//new MainForm(ob2).Show();
						//formA.Close();
				break;
				}
				else if(formA is Object && op.Equals("fechar")){
						formA.Close();
				break;
				
				}
				
			}
		}
		
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
		
		
		}//fim classe
	}//fim namespace
