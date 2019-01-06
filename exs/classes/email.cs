/*
 * Created by SharpDevelop.
 * User: home
 * Date: 06/01/2019
 * Time: 08:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace exs.classes
{
	/// <summary>
	/// Description of email.
	/// </summary>
	public class email
	{
		private email(){}
		private static email ins;
		public static email Inst{
			get{return ins==null?ins = new email():ins;}
			//set{email=value; }
		}
		
		
		public string VerifyingIns(){
			return Inst==null?"isn't SingleTon":"it's SingleTon";
		}
		
		public string de;
		public string De{
			get{return de;}
			set{de=value; }
		
		}
		public string to="alxsymtvk@icloud.com";
		public string To{
			get{return to;}
		}
//		public string body;
	//	public string subject;
		
		
		
		
		public void SendEmail(){
			Console.WriteLine("sending email de "+De+" to "+To);
		}
	}
}
