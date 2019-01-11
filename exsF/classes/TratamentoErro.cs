/*
 * Created by SharpDevelop.
 * User: home
 * Date: 09/01/2019
 * Time: 11:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;


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
		
		
		/*method returns operation that user allow
		 * object plus option does the action to window
		 *return window or close window on actual object 
		*/
		public void OperationWindow(Object ob,string op){
			if(Application.OpenForms.Count==0){
				Application.Exit();
			
			}
			else{
			foreach(Form formA in Application.OpenForms)

				if(formA.GetType() == ob.GetType()){
				switch(op){
					case "retomar":
						formA.Focus();
							break;
					case "fechar":
						formA.Close();
							break;
				}
				}
			
			}//fim do 1 else
		}//fim classe OperationWindow2
		
		
		/*
		 * list all form open,and verify the tipes or names follow the steps bellow
		 
		 */
		public void OperationWindowList(Object ob){
			if(Application.OpenForms.Count==0){
				Application.Exit();
			}
			else{
				foreach(Form formA in Application.OpenForms)
				MessageBox.Show("formA.GetType().Name->"+formA.GetType().Name+ 
					             "\nformA.GetType()->"+formA.GetType()+
					            "\nob.getType()->"+ob.GetType());
			
}

		}//fim classe OperationWindowList
	
		
		 public Object retornando(Object o){
        return o;
}
		
		
		
	
	}//fim classe
}//fim namespace


