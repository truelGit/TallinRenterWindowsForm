namespace TallinRenter
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblKvarplata = new System.Windows.Forms.Label();
			this.txtKvarplata = new System.Windows.Forms.TextBox();
			this.txtElectricity = new System.Windows.Forms.TextBox();
			this.lblElectricity = new System.Windows.Forms.Label();
			this.txtGas = new System.Windows.Forms.TextBox();
			this.lblGas = new System.Windows.Forms.Label();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.lblResult = new System.Windows.Forms.Label();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.btnCopy = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblKvarplata
			// 
			this.lblKvarplata.AutoSize = true;
			this.lblKvarplata.Location = new System.Drawing.Point(13, 13);
			this.lblKvarplata.Name = "lblKvarplata";
			this.lblKvarplata.Size = new System.Drawing.Size(61, 13);
			this.lblKvarplata.TabIndex = 0;
			this.lblKvarplata.Text = "Кварплата";
			// 
			// txtKvarplata
			// 
			this.txtKvarplata.Location = new System.Drawing.Point(16, 30);
			this.txtKvarplata.Name = "txtKvarplata";
			this.txtKvarplata.Size = new System.Drawing.Size(100, 20);
			this.txtKvarplata.TabIndex = 1;
			// 
			// txtElectricity
			// 
			this.txtElectricity.Location = new System.Drawing.Point(16, 70);
			this.txtElectricity.Name = "txtElectricity";
			this.txtElectricity.Size = new System.Drawing.Size(100, 20);
			this.txtElectricity.TabIndex = 3;
			// 
			// lblElectricity
			// 
			this.lblElectricity.AutoSize = true;
			this.lblElectricity.Location = new System.Drawing.Point(13, 53);
			this.lblElectricity.Name = "lblElectricity";
			this.lblElectricity.Size = new System.Drawing.Size(83, 13);
			this.lblElectricity.TabIndex = 2;
			this.lblElectricity.Text = "Электричество";
			// 
			// txtGas
			// 
			this.txtGas.Location = new System.Drawing.Point(16, 110);
			this.txtGas.Name = "txtGas";
			this.txtGas.Size = new System.Drawing.Size(100, 20);
			this.txtGas.TabIndex = 5;
			// 
			// lblGas
			// 
			this.lblGas.AutoSize = true;
			this.lblGas.Location = new System.Drawing.Point(13, 93);
			this.lblGas.Name = "lblGas";
			this.lblGas.Size = new System.Drawing.Size(25, 13);
			this.lblGas.TabIndex = 4;
			this.lblGas.Text = "Газ";
			// 
			// txtResult
			// 
			this.txtResult.Location = new System.Drawing.Point(16, 150);
			this.txtResult.Name = "txtResult";
			this.txtResult.Size = new System.Drawing.Size(697, 20);
			this.txtResult.TabIndex = 7;
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Location = new System.Drawing.Point(13, 133);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(37, 13);
			this.lblResult.TabIndex = 6;
			this.lblResult.Text = "Итого";
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(148, 107);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate.TabIndex = 8;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// btnCopy
			// 
			this.btnCopy.Location = new System.Drawing.Point(245, 107);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(75, 23);
			this.btnCopy.TabIndex = 9;
			this.btnCopy.Text = "Copy";
			this.btnCopy.UseVisualStyleBackColor = true;
			this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(725, 181);
			this.Controls.Add(this.btnCopy);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.txtGas);
			this.Controls.Add(this.lblGas);
			this.Controls.Add(this.txtElectricity);
			this.Controls.Add(this.lblElectricity);
			this.Controls.Add(this.txtKvarplata);
			this.Controls.Add(this.lblKvarplata);
			this.Name = "Form1";
			this.Text = "Расчет кварплаты";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblKvarplata;
		private System.Windows.Forms.TextBox txtKvarplata;
		private System.Windows.Forms.TextBox txtElectricity;
		private System.Windows.Forms.Label lblElectricity;
		private System.Windows.Forms.TextBox txtGas;
		private System.Windows.Forms.Label lblGas;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Button btnCopy;
	}
}

