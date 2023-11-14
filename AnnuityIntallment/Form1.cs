using System;
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
            decimal[,] creditInterestPart = CountCreditInterestPart(creditAmount, bankRate, installments, years, annuitedInstallment);
            MessageBox.Show("Annuited installment: " + Math.Round(annuitedInstallment) + "\n" 
                + "Czêœci kapita³owa: " + "Czêœci odsetkowa: " 
                + "\n" + Math.Round(creditInterestPart[0, 0]) + ' ' + Math.Round(creditInterestPart[1, 0])
                + "\n" + Math.Round(creditInterestPart[0, 1]) + ' ' + Math.Round(creditInterestPart[1, 1])
                + "\n" + Math.Round(creditInterestPart[0, 2]) + ' ' + Math.Round(creditInterestPart[1, 2])
                + "\n" + Math.Round(creditInterestPart[0, 3]) + ' ' + Math.Round(creditInterestPart[1, 3])
                + "\n" + Math.Round(creditInterestPart[0, 4]) + ' ' + Math.Round(creditInterestPart[1, 4])
                + "\n" + Math.Round(creditInterestPart[0, 5]) + ' ' + Math.Round(creditInterestPart[1, 5]));
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

        private decimal[,] CountCreditInterestPart(decimal amountOfCredit, double bankRate, int installments, int years, decimal annuitedInstallment)
        {
            int allInstallment = installments * years;
            decimal[,] CreditInterestInstallments = new decimal[2, allInstallment];

            for (int i = 0; i< allInstallment; i++)
            {
                CreditInterestInstallments[1, i] = (amountOfCredit * (decimal)bankRate) / installments;
                CreditInterestInstallments[0, i] = annuitedInstallment - CreditInterestInstallments[1, i];
                amountOfCredit -= CreditInterestInstallments[0, i];
            }

            return CreditInterestInstallments;
        }
    }
}