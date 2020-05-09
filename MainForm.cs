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
			MessageBox.Show("Information","Please put plus between the words :)");
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
			textBox3.Visible = true;
			
			
		}
		void PictureBox3Click(object sender, EventArgs e)
		{
			webBrowser1.Refresh();
		}
		void Button5Click(object sender, EventArgs e)
		{
			Form1 frm1 = new Form1();
			frm1.Show();
			this.Hide();
		}
		void WebBrowser1Navigating(object sender, WebBrowserNavigatingEventArgs e)
		{
			pictureBox6.Visible = true;
			statusStrip1.Visible = true;
			toolStripStatusLabel1.Visible = true;
			toolStripStatusLabel1.Text = "Connecting site:" + textBox1.Text;
		
		}
		void WebBrowser1Navigated(object sender, WebBrowserNavigatedEventArgs e)
		{
			pictureBox6.Visible = false;
		}
		void StatusStrip1ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
	
		}
		void PictureBox5Click(object sender, EventArgs e)
		{
			webBrowser1.GoBack();
		}
		void PictureBox4Click(object sender, EventArgs e)
		{
			webBrowser1.GoForward();
		}
		void PictureBox7Click(object sender, EventArgs e)
		{
			webBrowser1.Stop();
		}
		void Button13Click(object sender, EventArgs e)
		{
			panel5.Visible = true;
			button14.Visible = true;
		}
		void PictureBox8Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate("https://www.instagram.com/");	
		}
		void TextBox1KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				webBrowser1.Navigate(textBox1.Text);
			}
		}
		void Button12Click(object sender, EventArgs e)
		{
			textBox4.Visible = true;
			pictureBox9.Visible = true;
			button12.Visible = false;
		}
		void PictureBox9Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate("youtube.com/results?search_query="+textBox4.Text);
		}
		void TextBox7TextChanged(object sender, EventArgs e)
		{
	
		}
		void ToolStripStatusLabel1Click(object sender, EventArgs e)
		{
	
		}
		void Panel6Paint(object sender, PaintEventArgs e)
		{
	
		}
		void PictureBox10Click(object sender, EventArgs e)
		{
				webBrowser1.Navigate("https://www.youtube.com/");	
		}
		void PictureBox11Click(object sender, EventArgs e)
		{
	webBrowser1.Navigate("https://www.facebook.com/");
		}
		void Button14Click(object sender, EventArgs e)
		{
	panel5.Visible = false;
			button14.Visible = false;
			button13.Visible = true;
		}
	}
}
