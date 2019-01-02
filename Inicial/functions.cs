/*
 * Created by SharpDevelop.
 * User: home
 * Date: 02/01/2019
 * Time: 09:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
namespace Inicial
{
	/// <summary>
	/// Description of functions.
	/// </summary>
	public static class functions
	{
		public static void LerArquivos(string path)
		{
			if(File.Exists(path)){
			//	Console.WriteLine("file was found it");
			using(StreamReader arq = File.OpenText(path))
			{
				String ln;
				while((ln=arq.ReadLine())!=null)
					Console.WriteLine(ln);
				
			}
			}
			else
				Console.WriteLine("not found it");
		}
	}
}
