/*
 * Created by SharpDevelop.
 * User: lenovo
 * Date: 21/04/2020
 * Time: 2:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace inheritance
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Mahasiswa mahasiswa = new Mahasiswa();
		
		public MainForm()
		{
			InitializeComponent();
			button1.Text="inheritance";
			button2.Text="Unboxing";
			
			mahasiswa.Nama= "Diki Taufik Gurohman";
			mahasiswa.JenisKelamin="laki-laki";
			mahasiswa.Alamat="Jl.Raung 4 selatan";
			mahasiswa.Jurusan="Teknologi Informasi";
			mahasiswa.NamaProgramStudi="TKK";
			mahasiswa.Semester=0;
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.AppendText("Data dari Inheritance Class : "+ Environment.NewLine + Environment.NewLine);
			textBox1.AppendText("Nama : "+mahasiswa.Nama + Environment.NewLine);
			textBox1.AppendText("Alamat : "+mahasiswa.Alamat + Environment.NewLine);
			textBox1.AppendText("Kelamin : "+mahasiswa.JenisKelamin + Environment.NewLine);
			textBox1.AppendText("Semester : "+mahasiswa.Semester + Environment.NewLine);
			textBox1.AppendText("Jurusan : "+mahasiswa.Jurusan + Environment.NewLine);
			textBox1.AppendText("Program Studi : "+mahasiswa.NamaProgramStudi + Environment.NewLine);
		}
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.AppendText("Data dari Identitas (Unboxing) : " + Environment.NewLine + Environment.NewLine);
			var id = (Identitas) mahasiswa;
			textBox1.AppendText("Nama : "+id.Nama + Environment.NewLine);
			textBox1.AppendText("Alamat : "+id.Alamat + Environment.NewLine);
			textBox1.AppendText("Kelamin : "+id.JenisKelamin + Environment.NewLine);
		}
	}
}
