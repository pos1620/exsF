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
		Valores v2 = new Valores();
			
		public Consultar()
		{
			InitializeComponent();
		}
		public Consultar(Valores v1)
		{
			InitializeComponent();
			v2=v1;
		}
		void ConsultarLoad(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			nomeLABEL.Text="Nome="+new Valores().Engineer;
			MessageBox.Show("welcome "+v2.Nome);
		}
	}
}//
