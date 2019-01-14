/*
 * Created by SharpDevelop.
 * User: home
 * Date: 14/01/2019
 * Time: 10:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace exsF
{
	/// <summary>
	/// Description of Progresso.
	/// </summary>
	public partial class Progresso : Form
	{
		public string[] linhas;
		public Progresso()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ProgressoLoad(object sender, EventArgs e)
		{
			string filename=@"c:\db.txt";
			using (var streamReader = File.OpenText(filename)){
linhas=streamReader.ReadToEnd().Split("\r\n".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
progressBar1.Minimum=0;
progressBar1.Maximum=linhas.Length;

			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			/*
			for(var i=0;i<linhas.Length;i++){
				var linha = linhas[i];
				progressBar1.Value=(i+1);
		
			}
			*/
			
			for(var i=0;i<2;i++){
				var linha = linhas[i];
				progressBar1.Value=(i+1);
				ImportedNames.Text=linha+"\n\r"+":Importado\r\n";
		
}
			
		}
	}
}
