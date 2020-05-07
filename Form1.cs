/*
 * This is help file. You not need using codes :D
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PocketGhost
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
	
		}
		void Form1Load(object sender, EventArgs e)
		{
	
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void Label34Click(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			MainForm mfr = new MainForm();
			mfr.Show();
			this.Close();
		}
	}
}
