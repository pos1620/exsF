﻿/*
 * Created by SharpDevelop.
 * User: home
 * Date: 06/01/2019
 * Time: 10:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace exsF
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem desenvolvimentoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem doaçToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ãToolStripMenuItem;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ToolStripMenuItem progressoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem geralToolStripMenuItem;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.desenvolvimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.doaçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ãToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.progressoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button1 = new System.Windows.Forms.Button();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.geralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(75, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "exs";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.cadastrarToolStripMenuItem,
			this.consultarToolStripMenuItem,
			this.sobreToolStripMenuItem,
			this.desenvolvimentoToolStripMenuItem,
			this.geralToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(712, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// cadastrarToolStripMenuItem
			// 
			this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
			this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
			this.cadastrarToolStripMenuItem.Text = " Cadastrar";
			this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.CadastrarToolStripMenuItemClick);
			// 
			// consultarToolStripMenuItem
			// 
			this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
			this.consultarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.consultarToolStripMenuItem.Text = "Consultar";
			this.consultarToolStripMenuItem.Click += new System.EventHandler(this.ConsultarToolStripMenuItemClick);
			// 
			// sobreToolStripMenuItem
			// 
			this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
			this.sobreToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.sobreToolStripMenuItem.Text = "Sobre";
			this.sobreToolStripMenuItem.Click += new System.EventHandler(this.SobreToolStripMenuItemClick);
			// 
			// desenvolvimentoToolStripMenuItem
			// 
			this.desenvolvimentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.doaçToolStripMenuItem,
			this.ãToolStripMenuItem,
			this.progressoToolStripMenuItem});
			this.desenvolvimentoToolStripMenuItem.Name = "desenvolvimentoToolStripMenuItem";
			this.desenvolvimentoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
			this.desenvolvimentoToolStripMenuItem.Text = "Desenvolvimento";
			// 
			// doaçToolStripMenuItem
			// 
			this.doaçToolStripMenuItem.Name = "doaçToolStripMenuItem";
			this.doaçToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.doaçToolStripMenuItem.Text = "Docao";
			// 
			// ãToolStripMenuItem
			// 
			this.ãToolStripMenuItem.Name = "ãToolStripMenuItem";
			this.ãToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.ãToolStripMenuItem.Text = "Github";
			this.ãToolStripMenuItem.Click += new System.EventHandler(this.ÃToolStripMenuItemClick);
			// 
			// progressoToolStripMenuItem
			// 
			this.progressoToolStripMenuItem.Name = "progressoToolStripMenuItem";
			this.progressoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.progressoToolStripMenuItem.Text = "Progresso";
			this.progressoToolStripMenuItem.Click += new System.EventHandler(this.ProgressoToolStripMenuItemClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(268, 185);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "QuemSouEu";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "exs";
			this.notifyIcon1.Visible = true;
			// 
			// geralToolStripMenuItem
			// 
			this.geralToolStripMenuItem.Name = "geralToolStripMenuItem";
			this.geralToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.geralToolStripMenuItem.Text = "geral";
			this.geralToolStripMenuItem.Click += new System.EventHandler(this.GeralToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(712, 273);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "exsF";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
