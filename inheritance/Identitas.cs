/*
 * Created by SharpDevelop.
 * User: lenovo
 * Date: 21/04/2020
 * Time: 2:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace inheritance
{
	public class Identitas
	{
		private string nama= "";
		private string jenisKelamin = "Laki-laki";
		private string alamat = "";
		
		public Identitas()
		{
		}
	
		public string Nama{
			get{
				return nama;
			}set{
				nama = value;
			}
		}
		public string JenisKelamin{
			get{
				return jenisKelamin;
			}set{
				if (jenisKelamin.ToLower()=="laki-laki" ||
					jenisKelamin.ToLower()=="perempuan"){
					jenisKelamin=value;
				}
			}
		}
		public string Alamat{
			get{
				return alamat;
			}set{
				alamat=value;
			}
		}
	}
}
