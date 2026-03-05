/*
 * Created by SharpDevelop.
 * User: mathq
 * Date: 13/09/2024
 * Time: 15:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HACKATON
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
		void Label1Click(object sender, EventArgs e)
		{
			MessageBox.Show("Seja bem vindo, faça o login para prosseguir.");
		}
		void Button1Click(object sender, EventArgs e)
		{
	Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
		}
	}
}
