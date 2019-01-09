/*
 * Created by SharpDevelop.
 * User: home
 * Date: 09/01/2019
 * Time: 11:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace exsF.classes
{
	/// <summary>
	/// Description of TratamentErro.
	/// </summary>
	public class TratamentoErro : Exception
	{
		public TratamentoErro()
		{
		}
		
		public string QuemSouEu(){
			return this.GetType().Name;
		}
		
		public void Testando(string text,Valores v1){
			Valores v4 = v1;
			try{
				
			}
			catch{
				System.Windows.Forms.MessageBox.Show("Apenas numeros!");
				//precoTXT.Clear();
				//precoTXT.Focus();
			
			}
		}
		
		
	}
}
