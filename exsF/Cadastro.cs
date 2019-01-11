/*
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
using exsF.classes;
using System.IO;
using System.Configuration;

namespace exsF
{
	/// <summary>
	/// Description of Cadastro.
	/// </summary>
	public partial class Cadastro : Form
	{
vendedor v2 	= new vendedor();
produto prod2 = new produto();
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
		public Cadastro(vendedor v,produto prod)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			v2=v;
			prod2=prod;
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
	if(string.IsNullOrEmpty(nomeTXT.Text)||
	   string.IsNullOrEmpty(emailTXT.Text)||
	   string.IsNullOrEmpty(phoneTXT.Text)||
	   string.IsNullOrEmpty(urlTXT.Text)||
	   string.IsNullOrEmpty(tipoTXT.Text)||
	   string.IsNullOrEmpty(precoTXT.Text)){
		MessageBox.Show("todos os valores obrigatorios");
	
	}
		
		else{
		try{
			v2.Preco=float.Parse(precoTXT.Text);
			v2.Nome=nomeTXT.Text;
			v2.Email=emailTXT.Text;
			v2.Phone=phoneTXT.Text;
			v2.Url=urlTXT.Text;
			prod2.TipoProduto=tipoTXT.Text;	
			nomeTXT.Clear();
			emailTXT.Clear();
			phoneTXT.Clear();
			urlTXT.Clear();
			tipoTXT.Clear();
			precoTXT.Clear();
			valorLABEL.Text="valor="+v2.Preco.ToString("f2");
			MessageBox.Show("Cadastrado!");
}catch{
			precoTXT.Clear();
			precoTXT.Focus();
			MessageBox.Show("Apenas numeros!");
			}
		
				
//				new TratamentoErro().OperationWindow(new Consultar(),"retomar");
//		new TratamentoErro().OperationWindowList(new Consultar());
//GravandoNoArquivo()

	}
		
}

//Gravando arquivo in db.csv
		public void GravandoNoArquivo(){
	string pathf=ConfigurationManager.AppSettings["pathf"];
	long len2=File.ReadAllBytes(pathf).Length;
	if(File.Exists(pathf)&& len2==0 ){
File.WriteAllText(pathf,"Nome;Email;Telefone;Url;Tipo;Preço\r\n");
	
	}
File.AppendAllText(pathf,v2.Nome+";"+v2.Email+";"+v2.Phone+";"+v2.Url+";"+v2.TipoProduto+";"+v2.Preco+"\r\n");

		}//fim GravandoNoArquivo()

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
		//	new MainForm().Show();
		
		}
		void CadastroFormClosed(object sender, FormClosedEventArgs e){

		//	new MainForm().OperationWinwdow(new MainForm(),"retomar");
		//	new MainForm().OperationWinwdow(new MainForm(),"fechar");
		}
	}//fim classe
}//fim namesspace
