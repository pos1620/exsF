/*
 * Created by SharpDevelop.
 * User: home
 * Date: 06/01/2019
 * Time: 10:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
namespace exsF.classes
{
	/// <summary>
	/// Description of Valores.
	/// </summary>
	public class Valores
	{
		
		
		public string QuemSouEu(){
			return this.GetType().Name;
		}
		
		public Object QuemSouEu2(){
			return this.GetType();
		}
		
		
		public Valores[] objts;
		public Valores()
		{
		}
		
		
		public string engineer="alxsy mostovik";
		public string Engineer{
			get{return engineer;}
		}
		public string nome;
		public string Nome{
			get{return nome;}
			set{nome=value;}
		}
		
		public string url;
		public string Url{
			get{return url;}
			set{url=value;}
		}
		
		public string tipoProduto;
		public string TipoProduto{
			get{return tipoProduto;}
			set{tipoProduto=value;}
		}
		
		public string phone;
		public string Phone{
			get{return phone;}
			set{phone=value;}
		}
		
		public string email;
		public string Email{
			get{return email;}
			set{email=value;}
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
	
	public void objtss(Valores obj){
		//for(byte i=0;i<=objts.Length;i++)
		//	if(objts[i]==null)
		//	objts[i] = obj;
			objts[0] = obj;
	}
			
	}//fim classe
}//fim namespace
