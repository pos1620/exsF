/*
 * Created by SharpDevelop.
 * User: home
 * Date: 04/01/2019
 * Time: 11:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Configuration;
namespace exs.classes
{
	/// <summary>
	/// Description of methods.
	/// </summary>
	public class methods
	{
		public string nome;
		public string Nome{
			get{return nome;}
			set{nome=value;}
		}
	
		
		public static string caminho(){
			return ConfigurationManager.AppSettings["db"];
		}
	

		public void gravar(){
		Console.WriteLine("vc esta gravando um objeto do tipo:"+this.GetType().Name);
		if(Directory.Exists(caminho())){
			File.AppendAllText(caminho()+"db.txt",this.nome+"\r\n");
		}//fim if
		}
		
}//fim classe
}//fim namespace