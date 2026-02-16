namespace InvoiceTotal
{
    partial class frmInvoiceTotal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSubtotal = new Label();
            txtSubtotal = new TextBox();
            lblDiscountPercent = new Label();
            txtDiscountPercent = new TextBox();
            lblDiscountAmount = new Label();
            txtDiscountAmount = new TextBox();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtotal.Location = new Point(47, 58);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(86, 25);
            lblSubtotal.TabIndex = 0;
            lblSubtotal.Text = "&Subtotal:";
            lblSubtotal.TextAlign = ContentAlignment.MiddleLeft;
            lblSubtotal.Click += label1_Click;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtSubtotal.Location = new Point(234, 58);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(188, 32);
            txtSubtotal.TabIndex = 1;
            txtSubtotal.TextChanged += txtSubtotal_TextChanged;
            // 
            // lblDiscountPercent
            // 
            lblDiscountPercent.AutoSize = true;
            lblDiscountPercent.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiscountPercent.Location = new Point(47, 103);
            lblDiscountPercent.Name = "lblDiscountPercent";
            lblDiscountPercent.Size = new Size(158, 25);
            lblDiscountPercent.TabIndex = 2;
            lblDiscountPercent.Text = "Discount Percent:";
            lblDiscountPercent.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDiscountPercent
            // 
            txtDiscountPercent.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiscountPercent.Location = new Point(234, 103);
            txtDiscountPercent.Name = "txtDiscountPercent";
            txtDiscountPercent.ReadOnly = true;
            txtDiscountPercent.Size = new Size(188, 32);
            txtDiscountPercent.TabIndex = 0;
            txtDiscountPercent.TabStop = false;
            txtDiscountPercent.TextChanged += txtDiscountPct_TextChanged;
            // 
            // lblDiscountAmount
            // 
            lblDiscountAmount.AutoSize = true;
            lblDiscountAmount.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiscountAmount.Location = new Point(47, 139);
            lblDiscountAmount.Name = "lblDiscountAmount";
            lblDiscountAmount.Size = new Size(162, 25);
            lblDiscountAmount.TabIndex = 4;
            lblDiscountAmount.Text = "Discount Amount:";
            lblDiscountAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDiscountAmount
            // 
            txtDiscountAmount.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiscountAmount.Location = new Point(234, 144);
            txtDiscountAmount.Name = "txtDiscountAmount";
            txtDiscountAmount.ReadOnly = true;
            txtDiscountAmount.Size = new Size(188, 32);
            txtDiscountAmount.TabIndex = 0;
            txtDiscountAmount.TabStop = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(47, 182);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(56, 25);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total:";
            lblTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.Location = new Point(234, 182);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(188, 32);
            txtTotal.TabIndex = 0;
            txtTotal.TabStop = false;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(121, 267);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(121, 38);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(286, 267);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(121, 38);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // frmInvoiceTotal
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(495, 335);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(txtDiscountAmount);
            Controls.Add(lblDiscountAmount);
            Controls.Add(txtDiscountPercent);
            Controls.Add(lblDiscountPercent);
            Controls.Add(txtSubtotal);
            Controls.Add(lblSubtotal);
            Name = "frmInvoiceTotal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice Total";
            Load += frmInvoiceTotal_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label lblSubtotal;
        private TextBox txtSubtotal;
        private Label lblDiscountPercent;
        private TextBox txtDiscountPercent;
        private Label lblDiscountAmount;
        private TextBox txtDiscountAmount;
        private Label lblTotal;
        private TextBox txtTotal;
        private Button btnCalculate;
        private Button btnExit;
    }
}