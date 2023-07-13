namespace ListaZakupów
{
    partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.grpInput = new System.Windows.Forms.GroupBox();
			this.cmbUnits = new System.Windows.Forms.ComboBox();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lstItems = new System.Windows.Forms.ListBox();
			this.btnChange = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.grpInput.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpInput
			// 
			this.grpInput.Controls.Add(this.txtPrice);
			this.grpInput.Controls.Add(this.label5);
			this.grpInput.Controls.Add(this.label4);
			this.grpInput.Controls.Add(this.cmbUnits);
			this.grpInput.Controls.Add(this.txtAmount);
			this.grpInput.Controls.Add(this.txtName);
			this.grpInput.Controls.Add(this.label2);
			this.grpInput.Controls.Add(this.label1);
			this.grpInput.Location = new System.Drawing.Point(736, 134);
			this.grpInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.grpInput.Name = "grpInput";
			this.grpInput.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.grpInput.Size = new System.Drawing.Size(421, 184);
			this.grpInput.TabIndex = 0;
			this.grpInput.TabStop = false;
			this.grpInput.Text = "Wpis";
			// 
			// cmbUnits
			// 
			this.cmbUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbUnits.FormattingEnabled = true;
			this.cmbUnits.Location = new System.Drawing.Point(301, 145);
			this.cmbUnits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cmbUnits.Name = "cmbUnits";
			this.cmbUnits.Size = new System.Drawing.Size(91, 28);
			this.cmbUnits.TabIndex = 4;
			// 
			// txtAmount
			// 
			this.txtAmount.Location = new System.Drawing.Point(84, 91);
			this.txtAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(142, 26);
			this.txtAmount.TabIndex = 3;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(84, 37);
			this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(257, 26);
			this.txtName.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 94);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ilość:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 40);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Produkt:";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(54, 24);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(122, 40);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "Dodaj";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lstItems
			// 
			this.lstItems.BackColor = System.Drawing.SystemColors.Info;
			this.lstItems.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstItems.FormattingEnabled = true;
			this.lstItems.ItemHeight = 22;
			this.lstItems.Location = new System.Drawing.Point(365, 322);
			this.lstItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.lstItems.Name = "lstItems";
			this.lstItems.Size = new System.Drawing.Size(983, 686);
			this.lstItems.TabIndex = 2;
			this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged);
			// 
			// btnChange
			// 
			this.btnChange.Location = new System.Drawing.Point(54, 85);
			this.btnChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnChange.Name = "btnChange";
			this.btnChange.Size = new System.Drawing.Size(122, 45);
			this.btnChange.TabIndex = 3;
			this.btnChange.Text = "Zmień";
			this.btnChange.UseVisualStyleBackColor = true;
			this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(54, 149);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(122, 45);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Usuń";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Controls.Add(this.btnDelete);
			this.groupBox1.Controls.Add(this.btnChange);
			this.groupBox1.Location = new System.Drawing.Point(1368, 331);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(209, 209);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Akcja";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 142);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Cena:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(200, 148);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(87, 20);
			this.label5.TabIndex = 7;
			this.label5.Text = "Jednostka:";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(84, 142);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(100, 26);
			this.txtPrice.TabIndex = 8;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1924, 1028);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lstItems);
			this.Controls.Add(this.grpInput);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "MainForm";
			this.ShowInTaskbar = false;
			this.Text = "Lista zakupów";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.grpInput.ResumeLayout(false);
			this.grpInput.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.ComboBox cmbUnits;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
	}
}

