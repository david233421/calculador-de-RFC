/*
 * Created by SharpDevelop.
 * User: CC2-CP03
 * Date: 23/10/2024
 * Time: 03:12 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace csharp
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtncalClick(object sender, EventArgs e)
		{
			string apepa,apemate,nombre,derec,tel,dia,anio,mes,rfc;
			int longitud;
			
			apepa=txtapemas.Text;
			apemate=txtapemate.Text;
			nombre=txtnom.Text;
			derec=txtdir.Text;
			tel=txttel.Text;
			dia=txtdia.Text;
			mes=txtmes.Text;
			anio=txtanio.Text;
			
			longitud=anio.Length;
			
			apepa=apepa.Substring(0,2);
			apemate=apemate.Substring(0,1);
			nombre=nombre.Substring(0,1);
			anio=anio.Substring(2,2);
			dia=dia.Substring(0,2);
			mes=mes.Substring(0,2);
			
			rfc=apepa+apemate+nombre+anio+dia+mes;
			txtrfc.Text=rfc;
			
			
		}
	}
}
