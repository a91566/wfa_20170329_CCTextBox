﻿namespace wfa_20170329_CCTextBox
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.ccTextBox1 = new wfa_20170329_CCTextBox.CCTextBox(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ccTextBox1
			// 
			this.ccTextBox1.ccFormat = "0.01d";
			this.ccTextBox1.Location = new System.Drawing.Point(59, 44);
			this.ccTextBox1.Name = "ccTextBox1";
			this.ccTextBox1.Size = new System.Drawing.Size(100, 21);
			this.ccTextBox1.TabIndex = 0;
			this.ccTextBox1.Text = "0";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(63, 116);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(288, 264);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.ccTextBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CCTextBox ccTextBox1;
		private System.Windows.Forms.Button button1;
	}
}

