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
			MessageBox.Show("Cadastrado!");
			Valores v1 	= new Valores();
			//v1.Preco=Convert.ToSingle(label6.Text);
			v1.Preco=float.Parse(label6.Text);
			//label6.Text=v1.CalcularPreco().ToString("N3", new CultureInfo("pt-BR"));
			label6.Text=v1.CalcularPrecoServico().ToString("f2");
	//		v1.HorasT=4;
	//		v1.salarioHora=111;
	//MessageBox.Show("salario de:"+v1.CalcularSalario().ToString("c2"));
		//MessageBox.Show("salário de: "+string.Format("{0:n}",v1.CalcularSalario(999,4)));
		//MessageBox.Show("salário de: "+string.Format("%2f",v1.CalcularSalario(999,4)));
		//System.Diagnostics.Debug.WriteLine("salário de: "+String.Format("%.2f",v1.CalcularSalario(999,4)));
		}
		void TextBox3KeyPress(object sender, KeyPressEventArgs e)
		{
		MessageBox.Show("Cadastrado!");
			Valores v1 	= new Valores();
			//v1.Preco=Convert.ToSingle(label6.Text);
			v1.Preco=float.Parse(label6.Text);
			//label6.Text=v1.CalcularPreco().ToString("N3", new CultureInfo("pt-BR"));
			label6.Text=v1.CalcularPrecoServico().ToString("f2");
	//		v1.HorasT=4;
		}
		
		
		}//fim classe
	}//fim namespace
