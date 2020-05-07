/*
 * Developed by @hilalis. Please come my profile : "https://github.com/hilalis"
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PocketGhost
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
		void PictureBox1Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate(textBox1.Text);
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate(button1.Text);
		}
		void Panel1Paint(object sender, PaintEventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void PictureBox2Click(object sender, EventArgs e)
		{
			button1.Text = textBox1.Text;
			button1.Enabled = true;
		}
		void Button4Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate(button4.Text);
		}
		void WebBrowser1DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
	
		}
		void Panel2Paint(object sender, PaintEventArgs e)
		{
	
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			textBox2.Text = "";
			textBox2.ForeColor = Color.Black;
		}
		void Button7Click(object sender, EventArgs e)
		{
			button2.Text = textBox2.Text;
			panel2.Visible = false;
			
		}
		void Button8Click(object sender, EventArgs e)
		{
	button3.Text = textBox5.Text;
	panel3.Visible = false;
		}
		void TextBox3TextChanged(object sender, EventArgs e)
		{
			string yazi;
			yazi = textBox3.Text;
		}
		void TextBox4TextChanged(object sender, EventArgs e)
		{

		}
		void Button10Click(object sender, EventArgs e)
		{
			panel2.Visible = true;
			panel3.Visible = true;
			panel4.Visible = true;
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate(button2.Text);
			
		}
		void Button3Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate(button3.Text);
		}
		void TextBox4Click(object sender, EventArgs e)
		{

		}
		void TextBox3Click(object sender, EventArgs e)
		{

		}
		void TextBox2Click(object sender, EventArgs e)
		{

		}
		void Button9Click(object sender, EventArgs e)
		{
		button4.Text = textBox6.Text;
		panel4.Visible = false;
		}
		void Button6Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void Button11Click(object sender, EventArgs e)
		{
			textBox1.Visible = true;
			
			
		}
		void PictureBox3Click(object sender, EventArgs e)
		{
	
		}
		void Button5Click(object sender, EventArgs e)
		{
			Form1 frm1 = new Form1();
			frm1.Show();
			this.Hide();
		}
	}
}
