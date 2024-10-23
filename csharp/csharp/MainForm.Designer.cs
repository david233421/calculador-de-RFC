/*
 * Created by SharpDevelop.
 * User: CC2-CP03
 * Date: 23/10/2024
 * Time: 03:12 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace csharp
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.cmbsem = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtnom = new System.Windows.Forms.TextBox();
			this.txtapemas = new System.Windows.Forms.TextBox();
			this.txtapemate = new System.Windows.Forms.TextBox();
			this.txttel = new System.Windows.Forms.TextBox();
			this.btncal = new System.Windows.Forms.Button();
			this.txtdir = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtdia = new System.Windows.Forms.TextBox();
			this.txtmes = new System.Windows.Forms.TextBox();
			this.txtanio = new System.Windows.Forms.TextBox();
			this.txtrfc = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cmbsem
			// 
			this.cmbsem.FormattingEnabled = true;
			this.cmbsem.Items.AddRange(new object[] {
									"1ro",
									"2do",
									"3ro",
									"4to",
									"5to",
									"6to"});
			this.cmbsem.Location = new System.Drawing.Point(187, 130);
			this.cmbsem.Name = "cmbsem";
			this.cmbsem.Size = new System.Drawing.Size(121, 21);
			this.cmbsem.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(35, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "nombre:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(35, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "apellido 1:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(35, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "apellido 2:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(35, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "telefono:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(35, 110);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "direccion:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(35, 133);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 6;
			this.label6.Text = "semestre:";
			// 
			// txtnom
			// 
			this.txtnom.Location = new System.Drawing.Point(187, 15);
			this.txtnom.Name = "txtnom";
			this.txtnom.Size = new System.Drawing.Size(100, 20);
			this.txtnom.TabIndex = 9;
			// 
			// txtapemas
			// 
			this.txtapemas.Location = new System.Drawing.Point(187, 38);
			this.txtapemas.Name = "txtapemas";
			this.txtapemas.Size = new System.Drawing.Size(100, 20);
			this.txtapemas.TabIndex = 10;
			// 
			// txtapemate
			// 
			this.txtapemate.Location = new System.Drawing.Point(187, 61);
			this.txtapemate.Name = "txtapemate";
			this.txtapemate.Size = new System.Drawing.Size(100, 20);
			this.txtapemate.TabIndex = 11;
			// 
			// txttel
			// 
			this.txttel.Location = new System.Drawing.Point(187, 84);
			this.txttel.Name = "txttel";
			this.txttel.Size = new System.Drawing.Size(100, 20);
			this.txttel.TabIndex = 12;
			// 
			// btncal
			// 
			this.btncal.Location = new System.Drawing.Point(187, 271);
			this.btncal.Name = "btncal";
			this.btncal.Size = new System.Drawing.Size(75, 23);
			this.btncal.TabIndex = 18;
			this.btncal.Text = "calcular";
			this.btncal.UseVisualStyleBackColor = true;
			this.btncal.Click += new System.EventHandler(this.BtncalClick);
			// 
			// txtdir
			// 
			this.txtdir.Location = new System.Drawing.Point(187, 107);
			this.txtdir.Name = "txtdir";
			this.txtdir.Size = new System.Drawing.Size(100, 20);
			this.txtdir.TabIndex = 19;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(35, 157);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(149, 23);
			this.label7.TabIndex = 21;
			this.label7.Text = "dia de nacimiento";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(35, 180);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 22;
			this.label8.Text = "mes";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(35, 203);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 23;
			this.label9.Text = "año";
			// 
			// txtdia
			// 
			this.txtdia.Location = new System.Drawing.Point(187, 154);
			this.txtdia.Name = "txtdia";
			this.txtdia.Size = new System.Drawing.Size(100, 20);
			this.txtdia.TabIndex = 24;
			// 
			// txtmes
			// 
			this.txtmes.Location = new System.Drawing.Point(187, 180);
			this.txtmes.Name = "txtmes";
			this.txtmes.Size = new System.Drawing.Size(100, 20);
			this.txtmes.TabIndex = 25;
			// 
			// txtanio
			// 
			this.txtanio.Location = new System.Drawing.Point(187, 203);
			this.txtanio.Name = "txtanio";
			this.txtanio.Size = new System.Drawing.Size(100, 20);
			this.txtanio.TabIndex = 26;
			// 
			// txtrfc
			// 
			this.txtrfc.Location = new System.Drawing.Point(346, 244);
			this.txtrfc.Name = "txtrfc";
			this.txtrfc.Size = new System.Drawing.Size(100, 20);
			this.txtrfc.TabIndex = 27;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(486, 329);
			this.Controls.Add(this.txtrfc);
			this.Controls.Add(this.txtanio);
			this.Controls.Add(this.txtmes);
			this.Controls.Add(this.txtdia);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtdir);
			this.Controls.Add(this.btncal);
			this.Controls.Add(this.txttel);
			this.Controls.Add(this.txtapemate);
			this.Controls.Add(this.txtapemas);
			this.Controls.Add(this.txtnom);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbsem);
			this.Name = "MainForm";
			this.Text = "csharp";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtrfc;
		private System.Windows.Forms.TextBox txtanio;
		private System.Windows.Forms.TextBox txtmes;
		private System.Windows.Forms.TextBox txtdia;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtdir;
		private System.Windows.Forms.Button btncal;
		private System.Windows.Forms.TextBox txttel;
		private System.Windows.Forms.TextBox txtapemate;
		private System.Windows.Forms.TextBox txtapemas;
		private System.Windows.Forms.TextBox txtnom;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbsem;
	}
}
