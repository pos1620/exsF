/*
 * Created by SharpDevelop.
 * User: home
 * Date: 04/01/2019
 * Time: 11:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace exs.classes
{
	/// <summary>
	/// Description of produto.
	/// </summary>
	public class produto:methods
	{
		public string nome;
		public string Nome{
			get{return nome;}
			set{nome=value;}
		}
		
		public string tipo;
		public string Tipo{
			get{return tipo;}
			set{nome=value;}
		}
	}
}
