/*
 * Created by SharpDevelop.
 * User: home
 * Date: 28/12/2018
 * Time: 09:13e
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
//using Inicial;
using people;
namespace Inicial
{
	
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("What ur name!");
//			string nome=Console.ReadLine();
//			Console.WriteLine("What ur money month!");
//			float salario=Convert.ToSingle(Console.ReadLine());
//			Console.WriteLine("welcome: "+nome);
//			Console.WriteLine("salário de: "+string.Format("{0:n}", (salario+5)).Replace(",","."));
//			Console.WriteLine("salário de: "+salario.ToString("c").Replace(",","."));
			//Console.WriteLine("salário de: "+String.Format("{0:#,###.##}", (salario+5)));
			//Console.WriteLine("{0:F2}", 12);
			
			
			
			
			
	//objeto pessoa
//	people.pessoa p2 =new people.pessoa();
//	people.example p3 =new people.example();
pessoa p3 = new pessoa();
//example p2 = new example();
//p2.QuemSou();
p3.QuemSou();
//	produto p1 =  new produto();
//	p1.QuemSou();
//	p1.imp();

		
			// test conditional{
	/*		cond c1 = new cond();
			c1.idade=89;
			
			Console.WriteLine(c1.Idade>55?"usuario aprovado":"try again!");
			c1.assinatura();
	*/
	
	
	
	loop l1 = new loop();
//	p1.Valor=9;
//	l1.loopfor(p1.Valor);
//	l1.loopwhile(3);
//	loop.loopdo(3);
//	l1.recursiva(1);
//	l1.tabuada(1);
	
	
	vars v1 = new vars();
	v1.Imprimirvars();
	functions.LerArquivos(@"c:\nome.txt");
		Console.ReadKey(true);
		}//fim main
	}//fim clsdde
}//fim namespace