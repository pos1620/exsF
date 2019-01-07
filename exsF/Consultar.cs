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
		public Consultar(Valores v1)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			MessageBox.Show("welcome "+v1.Nome);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public Consultar()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ConsultarLoad(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			nomeLABEL.Text="Nome="+new Valores().Engineer;
		}
	}
}
