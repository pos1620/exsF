﻿/*
 * Created by SharpDevelop.
 * User: home
 * Date: 06/01/2019
 * Time: 19:08
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
	/// Description of Cadastro.
	/// </summary>
	public partial class Cadastro : Form
	{
		public Cadastro()
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
		sms();
		}
		void TextBox3KeyPress(object sender, KeyPressEventArgs e)
		{
		 if (e.KeyChar == (char)13)
       {
		
		}
		
		}
	
//function
public void sms(){
		MessageBox.Show("Cadastrado!");
			Valores v1 	= new Valores();
			//v1.Preco=Convert.ToSingle(label6.Text);
			v1.Nome=nomeTXT.Text;
			v1.Email=emailTXT.Text;
			v1.Phone=phoneTXT.Text;
			v1.Url=urlTXT.Text;
			v1.TipoProduto=tipoTXT.Text;
			v1.Preco=float.Parse(precoTXT.Text);
			
			
			//resLABEL.Text=v1.CalcularPrecoServico().ToString("f2");
			valorLABEL.Text="valor="+v1.CalcularPrecoServico().ToString("f2");


//		v1.HorasT=4;
	//		v1.salarioHora=111;
	//MessageBox.Show("salario de:"+v1.CalcularSalario().ToString("c2"));
		//MessageBox.Show("salário de: "+string.Format("{0:n}",v1.CalcularSalario(999,4)));
		//MessageBox.Show("salário de: "+string.Format("%2f",v1.CalcularSalario(999,4)));
		//System.Diagnostics.Debug.WriteLine("salário de: "+String.Format("%.2f",v1.CalcularSalario(999,4)));
		
		
		MainForm f1 = new MainForm();
		//f1.setNome(v1);
		f1.QuemSou(v1);
		MessageBox.Show(v1.Nome);
		this.Hide();
				f1.Show();

}
//end function
		void PrecoTXTKeyPress(object sender, KeyPressEventArgs e)
		{
		 if (e.KeyChar == (char)13)
       {
		sms();
		}
		}
		void PrecoTXTClick(object sender, EventArgs e)
		{
			
			precoTXT.Clear();
}
		void CadastroLoad(object sender, EventArgs e)
		{
			
	
		}
		void CadastroFormClosing(object sender, FormClosingEventArgs e)
		{
		//this.Close();
			new MainForm().Show();
		
		}
	}//fim classe
}//fim namesspace
