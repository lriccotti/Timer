/*
 * Created by SharpDevelop.
 * User: PC
 * Date: 26/11/2021
 * Time: 16:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Timer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int horas,minutos,segundos;
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
		void TimerTick(object sender, EventArgs e)
		{
			segundos+=1;
			lbl3.Text=Convert.ToString(segundos);
			if (segundos==60) {
				minutos+=1;
				lbl2.Text=Convert.ToString(minutos);
				segundos=0;
				
			}
			if (minutos==60) {
				horas+=1;
				lbl1.Text=Convert.ToString(horas);
				minutos=0;
			}
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			horas=0;
			minutos=0;
			segundos=0;
		}
		void Btn_iniciarClick(object sender, EventArgs e)
		{
			timer.Enabled=true;
			horas=0;
			minutos=0;
			segundos=0;
		}
		void Btn_pararClick(object sender, EventArgs e)
		{
			timer.Enabled=false;
		}
		void Btn_reiniciarClick(object sender, EventArgs e)
		{
			timer.Enabled=true;
			horas=0;
			minutos=0;
			segundos=0;
		}
	}
}
