namespace TestAttentiveness
{
	partial class TestForm
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
			this.grdNums = new System.Windows.Forms.DataGridView();
			this.grdRowIndex = new System.Windows.Forms.DataGridView();
			this.txtRules = new System.Windows.Forms.TextBox();
			this.btnEnd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grdNums)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdRowIndex)).BeginInit();
			this.SuspendLayout();
			// 
			// grdNums
			// 
			this.grdNums.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdNums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdNums.Location = new System.Drawing.Point(89, 86);
			this.grdNums.Name = "grdNums";
			this.grdNums.Size = new System.Drawing.Size(630, 449);
			this.grdNums.TabIndex = 0;
			// 
			// grdRowIndex
			// 
			this.grdRowIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.grdRowIndex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdRowIndex.Location = new System.Drawing.Point(12, 86);
			this.grdRowIndex.Name = "grdRowIndex";
			this.grdRowIndex.Size = new System.Drawing.Size(30, 449);
			this.grdRowIndex.TabIndex = 1;
			// 
			// txtRules
			// 
			this.txtRules.Location = new System.Drawing.Point(89, 13);
			this.txtRules.Multiline = true;
			this.txtRules.Name = "txtRules";
			this.txtRules.ReadOnly = true;
			this.txtRules.Size = new System.Drawing.Size(630, 46);
			this.txtRules.TabIndex = 2;
			// 
			// btnEnd
			// 
			this.btnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEnd.Location = new System.Drawing.Point(644, 625);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.Size = new System.Drawing.Size(75, 23);
			this.btnEnd.TabIndex = 3;
			this.btnEnd.Text = "Конец";
			this.btnEnd.UseVisualStyleBackColor = true;
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// TestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(745, 660);
			this.Controls.Add(this.btnEnd);
			this.Controls.Add(this.txtRules);
			this.Controls.Add(this.grdRowIndex);
			this.Controls.Add(this.grdNums);
			this.Name = "TestForm";
			this.Text = "TestForm";
			((System.ComponentModel.ISupportInitialize)(this.grdNums)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdRowIndex)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView grdNums;
		private System.Windows.Forms.DataGridView grdRowIndex;
		private System.Windows.Forms.TextBox txtRules;
		private System.Windows.Forms.Button btnEnd;
	}
}