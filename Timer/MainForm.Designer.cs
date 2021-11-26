/*
 * Created by SharpDevelop.
 * User: PC
 * Date: 26/11/2021
 * Time: 16:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Timer
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn_iniciar;
		private System.Windows.Forms.Button btn_parar;
		private System.Windows.Forms.Button btn_reiniciar;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.Label lbl3;
		private System.Windows.Forms.Timer timer;
		
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
			this.components = new System.ComponentModel.Container();
			this.btn_iniciar = new System.Windows.Forms.Button();
			this.btn_parar = new System.Windows.Forms.Button();
			this.btn_reiniciar = new System.Windows.Forms.Button();
			this.lbl1 = new System.Windows.Forms.Label();
			this.lbl2 = new System.Windows.Forms.Label();
			this.lbl3 = new System.Windows.Forms.Label();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// btn_iniciar
			// 
			this.btn_iniciar.Location = new System.Drawing.Point(17, 164);
			this.btn_iniciar.Name = "btn_iniciar";
			this.btn_iniciar.Size = new System.Drawing.Size(117, 56);
			this.btn_iniciar.TabIndex = 0;
			this.btn_iniciar.Text = "iniciar";
			this.btn_iniciar.UseVisualStyleBackColor = true;
			this.btn_iniciar.Click += new System.EventHandler(this.Btn_iniciarClick);
			// 
			// btn_parar
			// 
			this.btn_parar.Location = new System.Drawing.Point(165, 164);
			this.btn_parar.Name = "btn_parar";
			this.btn_parar.Size = new System.Drawing.Size(117, 56);
			this.btn_parar.TabIndex = 1;
			this.btn_parar.Text = "parar";
			this.btn_parar.UseVisualStyleBackColor = true;
			this.btn_parar.Click += new System.EventHandler(this.Btn_pararClick);
			// 
			// btn_reiniciar
			// 
			this.btn_reiniciar.Location = new System.Drawing.Point(309, 164);
			this.btn_reiniciar.Name = "btn_reiniciar";
			this.btn_reiniciar.Size = new System.Drawing.Size(117, 56);
			this.btn_reiniciar.TabIndex = 2;
			this.btn_reiniciar.Text = "reiniciar";
			this.btn_reiniciar.UseVisualStyleBackColor = true;
			this.btn_reiniciar.Click += new System.EventHandler(this.Btn_reiniciarClick);
			// 
			// lbl1
			// 
			this.lbl1.Location = new System.Drawing.Point(23, 22);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(110, 18);
			this.lbl1.TabIndex = 3;
			this.lbl1.Text = "00";
			// 
			// lbl2
			// 
			this.lbl2.Location = new System.Drawing.Point(165, 22);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(110, 18);
			this.lbl2.TabIndex = 4;
			this.lbl2.Text = "00";
			// 
			// lbl3
			// 
			this.lbl3.Location = new System.Drawing.Point(316, 22);
			this.lbl3.Name = "lbl3";
			this.lbl3.Size = new System.Drawing.Size(110, 18);
			this.lbl3.TabIndex = 5;
			this.lbl3.Text = "00";
			// 
			// timer
			// 
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.TimerTick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(438, 261);
			this.Controls.Add(this.lbl3);
			this.Controls.Add(this.lbl2);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.btn_reiniciar);
			this.Controls.Add(this.btn_parar);
			this.Controls.Add(this.btn_iniciar);
			this.Name = "MainForm";
			this.Text = "Timer";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);

		}
	}
}
