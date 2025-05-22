namespace ingatlanForm
{
    partial class Ingatlanok
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSellers = new System.Windows.Forms.Label();
            this.btnSellers = new System.Windows.Forms.Button();
            this.listBoxSellers = new System.Windows.Forms.ListBox();
            this.lblSellerName = new System.Windows.Forms.Label();
            this.lblSellerPhone = new System.Windows.Forms.Label();
            this.btnHirdetesek = new System.Windows.Forms.Button();
            this.lblCpunt = new System.Windows.Forms.Label();
            this.listBoxCordinates = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.lblCpunt, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnHirdetesek, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSellerPhone, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSellers, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSellers, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.listBoxSellers, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSellerName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBoxCordinates, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(820, 491);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblSellers
            // 
            this.lblSellers.AutoSize = true;
            this.lblSellers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSellers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSellers.Location = new System.Drawing.Point(3, 0);
            this.lblSellers.Name = "lblSellers";
            this.lblSellers.Size = new System.Drawing.Size(267, 49);
            this.lblSellers.TabIndex = 0;
            this.lblSellers.Text = "Ügynökök";
            this.lblSellers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSellers
            // 
            this.btnSellers.BackColor = System.Drawing.Color.Chartreuse;
            this.btnSellers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSellers.Location = new System.Drawing.Point(3, 444);
            this.btnSellers.Name = "btnSellers";
            this.btnSellers.Size = new System.Drawing.Size(267, 44);
            this.btnSellers.TabIndex = 1;
            this.btnSellers.Text = "Aktív ügynökök";
            this.btnSellers.UseVisualStyleBackColor = false;
            this.btnSellers.Click += new System.EventHandler(this.btnSellers_Click);
            // 
            // listBoxSellers
            // 
            this.listBoxSellers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSellers.FormattingEnabled = true;
            this.listBoxSellers.Location = new System.Drawing.Point(3, 52);
            this.listBoxSellers.Name = "listBoxSellers";
            this.tableLayoutPanel1.SetRowSpan(this.listBoxSellers, 4);
            this.listBoxSellers.Size = new System.Drawing.Size(267, 386);
            this.listBoxSellers.TabIndex = 2;
            this.listBoxSellers.SelectedIndexChanged += new System.EventHandler(this.listBoxSellers_SelectedIndexChanged);
            // 
            // lblSellerName
            // 
            this.lblSellerName.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblSellerName, 2);
            this.lblSellerName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSellerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSellerName.Location = new System.Drawing.Point(276, 0);
            this.lblSellerName.Name = "lblSellerName";
            this.lblSellerName.Size = new System.Drawing.Size(76, 49);
            this.lblSellerName.TabIndex = 3;
            this.lblSellerName.Text = "Eladó neve";
            this.lblSellerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSellerPhone
            // 
            this.lblSellerPhone.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblSellerPhone, 2);
            this.lblSellerPhone.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSellerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSellerPhone.Location = new System.Drawing.Point(276, 49);
            this.lblSellerPhone.Name = "lblSellerPhone";
            this.lblSellerPhone.Size = new System.Drawing.Size(126, 49);
            this.lblSellerPhone.TabIndex = 4;
            this.lblSellerPhone.Text = "Eladó telefonszáma";
            this.lblSellerPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnHirdetesek
            // 
            this.btnHirdetesek.BackColor = System.Drawing.Color.Turquoise;
            this.tableLayoutPanel1.SetColumnSpan(this.btnHirdetesek, 2);
            this.btnHirdetesek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHirdetesek.Location = new System.Drawing.Point(276, 101);
            this.btnHirdetesek.Name = "btnHirdetesek";
            this.btnHirdetesek.Size = new System.Drawing.Size(541, 43);
            this.btnHirdetesek.TabIndex = 5;
            this.btnHirdetesek.Text = "Hirdetések betöltése";
            this.btnHirdetesek.UseVisualStyleBackColor = false;
            this.btnHirdetesek.Click += new System.EventHandler(this.btnHirdetesek_Click);
            // 
            // lblCpunt
            // 
            this.lblCpunt.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblCpunt, 2);
            this.lblCpunt.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCpunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCpunt.Location = new System.Drawing.Point(276, 147);
            this.lblCpunt.Name = "lblCpunt";
            this.lblCpunt.Size = new System.Drawing.Size(116, 49);
            this.lblCpunt.TabIndex = 6;
            this.lblCpunt.Text = "Hirdetések száma";
            this.lblCpunt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxCordinates
            // 
            this.listBoxCordinates.CausesValidation = false;
            this.tableLayoutPanel1.SetColumnSpan(this.listBoxCordinates, 2);
            this.listBoxCordinates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCordinates.FormattingEnabled = true;
            this.listBoxCordinates.Location = new System.Drawing.Point(276, 199);
            this.listBoxCordinates.Name = "listBoxCordinates";
            this.tableLayoutPanel1.SetRowSpan(this.listBoxCordinates, 2);
            this.listBoxCordinates.Size = new System.Drawing.Size(541, 289);
            this.listBoxCordinates.TabIndex = 7;
            // 
            // Ingatlanok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 491);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Ingatlanok";
            this.Text = "Ingatlanok";
            this.Load += new System.EventHandler(this.Ingatlanok_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSellers;
        private System.Windows.Forms.Button btnSellers;
        private System.Windows.Forms.Label lblSellerPhone;
        private System.Windows.Forms.ListBox listBoxSellers;
        private System.Windows.Forms.Label lblSellerName;
        private System.Windows.Forms.Label lblCpunt;
        private System.Windows.Forms.Button btnHirdetesek;
        private System.Windows.Forms.ListBox listBoxCordinates;
    }
}

