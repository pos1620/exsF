/*
 * Created by SharpDevelop.
 * User: home
 * Date: 29/12/2018
 * Time: 10:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Inicial
{
	/// <summary>
	/// Description of loop.
	/// </summary>
	public class loop
	{
		public void loopfor(byte i)
		{
				Console.WriteLine("loopFor:");
			for(;i<=10;i++)
				Console.WriteLine("valor de i:"+i);
					Console.WriteLine("\n\n");
		
		}
		
		public void loopwhile(byte i){
					Console.WriteLine("loopWhile:");
			while(i<9){
				Console.WriteLine("valor de i:"+i);
			i++;
			}
							Console.WriteLine("\n\n");
		
		}
		
		public static void loopdo(byte i){
					Console.WriteLine("loopDo:");
			do{
				Console.WriteLine("valor de i:"+i);
				i++;
					}
			while(i<9);
							Console.WriteLine("\n\n");
		
		}
		
		public void recursiva(byte x){
			Console.WriteLine("o valor é:"+x);
			if(x<5){
				recursiva(++x);
		}
		}
		
	}//fim classe
}//fim namespace
