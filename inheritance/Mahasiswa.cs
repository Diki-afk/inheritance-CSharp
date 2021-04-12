/*
 * Created by SharpDevelop.
 * User: lenovo
 * Date: 21/04/2020
 * Time: 2:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace inheritance
{
	
	public class Mahasiswa: Identitas
	{
		private	string jurusan="";
		private string programStudi="";
		private int semester=1;
		
		public Mahasiswa()
		{
		}
		public int Semester{
			get{
				return semester;
			}set{
				if (value>0) semester=value;
			}
		}
		public string Jurusan{
			get{
				return jurusan;
			}set{
				jurusan=value;
			}
		}
		public string NamaProgramStudi{
			get{
				return programStudi;
			}set{
				programStudi=value;
			}
		}
	}
}
