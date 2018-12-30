/*
 * Created by SharpDevelop.
 * User: home
 * Date: 30/12/2018
 * Time: 08:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Inicial
{
	/// <summary>
	/// Description of produto.
	/// </summary>
	public class produto
	{
		public byte valor;
		public byte Valor{
			set{valor=value;}
			get{return valor;}
		}
		public string[] nomes = {"Mac", "Jessica", "MiMi"};
	
		
		public void imp(){
			for(byte i=0;i<nomes.Length;i++){
				Console.WriteLine("produtos:"+this.nomes[i]);
				Console.WriteLine("Tamanho das letras:"+this.nomes[i].Length);
			}
			}
			
			
			
			
		public void QuemSou(){
			Console.WriteLine("quem sou?:"+this.GetType());
			System.Diagnostics.Debug.WriteLine("quem sou?:"+this.GetType().Name);
		}
	}
}
