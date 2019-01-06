/*
 * Created by SharpDevelop.
 * User: home
 * Date: 06/01/2019
 * Time: 10:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace exsF.mthds
{
	/// <summary>
	/// Description of Valores.
	/// </summary>
	public class Valores
	{
		public Valores()
		{
		}
		
		
		
		public byte horasT=0;
		public byte HorasT{
			get{return horasT;}
			set{horasT=value;}
		}
		
		public float salarioHora=0;
		public float SalarioHora{
			get{return salarioHora;}
			set{salarioHora=value;}
		}
		
		public float preco;
		public float Preco{
			get{return preco;}
			set{preco=value;}
		}
			
		public float CalcularPreco(){
			return Preco+=111;
		}
		
			
		public float CalcularPrecoServico(){
			return CalcularPreco()*2;
		}
	
	/*
	public float CalcularSalario(float S,byte H){
		return S*H;
	}
	*/
	public float CalcularSalario(){
		return HorasT*SalarioHora;
	}
	}//fim classe
}//fim namespace
