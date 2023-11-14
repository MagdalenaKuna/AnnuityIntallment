using System;
using System.Linq;
using System.Windows.Forms.VisualStyles;

namespace AnnuityIntallment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            decimal annuitedInstallment;
            decimal creditAmount = decimal.Parse(amountOfCreditInput.Text);
            double bankRate = double.Parse(bankRateInput.Text);
            int installments = int.Parse(numberOfInstallmentsInput.Text);
            int years = int.Parse(yearsInput.Text);

            annuitedInstallment = CountAnnuityIntallment(creditAmount, bankRate, installments, years);
            decimal[][] creditInterestPart = CountCreditInterestPart(creditAmount, bankRate, installments, years, annuitedInstallment);

            listView1.Items.Clear();
            for (int i = 0; i < creditInterestPart[0].Length; i++)
            {
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(Math.Round(creditInterestPart[0][i], 2).ToString());
                item.SubItems.Add(Math.Round(creditInterestPart[1][i], 2).ToString());
                item.SubItems.Add(Math.Round(annuitedInstallment, 2).ToString());
                listView1.Items.Add(item);
            }

            ListViewItem itemSum = new ListViewItem("Sum up:");
            itemSum.SubItems.Add(Math.Round(creditInterestPart[0].Sum(), 2).ToString());
            itemSum.SubItems.Add(Math.Round(creditInterestPart[1].Sum(), 2).ToString());
            itemSum.SubItems.Add(Math.Round(annuitedInstallment * installments * years, 2).ToString());
            listView1.Items.Add(itemSum);
        }

        private decimal CountAnnuityIntallment(decimal amountOfCredit, double bankRate, int installments, int years)
        {
            decimal result;
            int allInstallment = installments * years;
            decimal seriesSum = decimal.Zero;

            for (int i = 0; i < allInstallment; i++)
            {
                seriesSum += decimal.One / (decimal)Math.Pow((installments + bankRate) / installments, i + 1);
            }

            result = amountOfCredit / seriesSum;
            return result;
        }

        private decimal[][] CountCreditInterestPart(decimal amountOfCredit, double bankRate, int installments, int years, decimal annuitedInstallment)
        {
            int allInstallment = installments * years;
            decimal[][] CreditInterestInstallments = new decimal[2][];
            CreditInterestInstallments[0] = new decimal[allInstallment];
            CreditInterestInstallments[1] = new decimal[allInstallment];

            for (int i = 0; i < allInstallment; i++)
            {
                CreditInterestInstallments[1][i] = (amountOfCredit * (decimal)bankRate) / installments;
                CreditInterestInstallments[0][i] = annuitedInstallment - CreditInterestInstallments[1][i];
                amountOfCredit -= CreditInterestInstallments[0][i];
            }

            return CreditInterestInstallments;
        }
    }
}