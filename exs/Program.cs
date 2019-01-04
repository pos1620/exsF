/*
 * Created by SharpDevelop.
 * User: home
 * Date: 04/01/2019
 * Time: 11:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using exs.classes;

namespace exs
{
	class Program
	{
		public static void Main(string[] args)
		{
			pessoa p = new pessoa{
			nome="pokemon",
			};
			
			pessoa p1 = new pessoa();
			p1.Nome="Brunna pedroza";
			produto pr = new produto();
			pr.Nome="shampoo";
			pr.Tipo="cosmetico";
			
			
			
			Console.WriteLine("Welcome to world map "+p1.Nome);
			//Console.WriteLine("vc esta comprando "+pr.Nome+" do tipo:"+pr.Tipo);
			p1.gravar();
			p1.gravar();
			pr.gravar();
			Console.ReadKey(true);
		}
		
		
	}//fim classe
}//fim namespace