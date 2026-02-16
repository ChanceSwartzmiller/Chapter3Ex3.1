namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPct = 0m;
            if (subtotal >= 500)
            {
                discountPct = .2m;
            }
            else if (subtotal >= 250 && subtotal < 500)
            {
                discountPct = .15m;
            }
            else if (subtotal >= 100 && subtotal < 250)
            {
                discountPct = .1m;
            }

            decimal discountAmt = subtotal * discountPct;
            decimal invoiceTotal = subtotal - discountAmt;

            txtDiscountPercent.Text = discountPct.ToString("p1");
            txtDiscountAmount.Text = discountAmt.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            txtSubtotal.Focus();
        }
                private void frmInvoiceTotal_Load(object sender, EventArgs e)
                {

                }

        private void txtDiscountPct_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}