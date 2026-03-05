/*
 * Created by SharpDevelop.
 * User: mathq
 * Date: 13/09/2024
 * Time: 15:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HACKATON
{
	/// <summary>
	/// Description of Form5.
	/// </summary>
	public partial class Form5 : Form
	{
		public Form5()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
		}
		void Button5Click(object sender, EventArgs e)
		{
			MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.Show();
		}
		void Label2Click(object sender, EventArgs e)
		{
			MessageBox.Show("Você deseja sacar R$ 20,00?, clique em CONFIRMAR para imprimir");
		}
		void Label3Click(object sender, EventArgs e)
		{
			MessageBox.Show("Você deseja sacar R$ 50,00?, clique em CONFIRMAR para imprimir");
		}
		void Label4Click(object sender, EventArgs e)
		{
			MessageBox.Show("Você deseja sacar R$ 70,00?, clique em CONFIRMAR para imprimir");
		}
		void Label5Click(object sender, EventArgs e)
		{
			MessageBox.Show("Você deseja sacar R$ 100,00?, clique em CONFIRMAR para imprimir");
		}
		void Label6Click(object sender, EventArgs e)
		{
			MessageBox.Show("Você deseja sacar R$ 500,00?, clique em CONFIRMAR para imprimir");
		}
		void Label7Click(object sender, EventArgs e)
		{
			MessageBox.Show("Você deseja sacar R$ 1000,00?, clique em CONFIRMAR para imprimir");
		}
		void Label11Click(object sender, EventArgs e)
		{
			MessageBox.Show("Valor Escolhido. Clique em Confirmar.");
		}
		void Button6Click(object sender, EventArgs e)
		{
			Form4 form4 = new Form4();
                this.Hide();
                form4.Show();
		}
	}
}
