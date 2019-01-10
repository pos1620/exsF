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
		
		public void OperationWindow(Object ob,string op){
			if(Application.OpenForms.Count==0){
				Application.Exit();
			}
			else{
				foreach(Form formA in Application.OpenForms)
					if(formA is Object && op.Equals("retomar")){
		//			if(formA.Equals(ob.GetType().Name) && op.Equals("retomar")){
					
					//formA.Show();
					//formA.WindowState = FormWindowState.Normal;
					//	formA.BringToFront();
								formA.Focus();
				break;
				}
				else if(formA is Object && op.Equals("fechar")){
						formA.Close();
				break;
				
				}
			}
			
		}//fim classe OperationWindow
		public void OperationWindow2(Object ob,string op){
			if(Application.OpenForms.Count==0){
				Application.Exit();
			}
			else{
				foreach(Form formA in Application.OpenForms)
						//.GetType().Name.Equals("MainForm")?(MainForm)retornando(ob):(MainForm)retornando(ob);
				if(ob.GetType().Name.Equals(ob.GetType().Name) && op.Equals("retomar")){
				if(formA is MainForm){
						formA.Focus();
						break;
				}
				}
				else if(ob.GetType().Name.Equals(ob.GetType().Name) && op.Equals("retomar")){
				if(formA is Consultar){
						formA.Focus();
						break;
				}
				}
				else if(ob.GetType().Name.Equals(ob.GetType().Name) && op.Equals("retomar")){
				if(formA is Cadastro){
						formA.Focus();
						break;
				}
				}
			}
		}//fim classe OperationWindow2
		
		public void OperationWindowList(){
			if(Application.OpenForms.Count==0){
				Application.Exit();
			}
			else{
				foreach(Form formA in Application.OpenForms)
				MessageBox.Show("formA.GetType().Name->"+formA.GetType().Name+ 
					             "\nformA.GetType()->"+formA.GetType());
			}
		}//fim classe OperationWindowList
	
		
		 public Object retornando(Object o){
        return o;
}
		
		
		
	
	}//fim classe
}//fim namespace


