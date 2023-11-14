namespace AnnuityIntallment
{
    partial class Form1
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
            label1 = new Label();
            amountOfCreditInput = new TextBox();
            label2 = new Label();
            bankRateInput = new TextBox();
            label3 = new Label();
            numberOfInstallmentsInput = new TextBox();
            button1 = new Button();
            yearsInput = new TextBox();
            label4 = new Label();
            listView1 = new ListView();
            nr = new ColumnHeader();
            creditpart = new ColumnHeader();
            interestpart = new ColumnHeader();
            annuited = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 72);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 0;
            label1.Text = "Amount of credit: ";
            // 
            // amountOfCreditInput
            // 
            amountOfCreditInput.Location = new Point(58, 100);
            amountOfCreditInput.Name = "amountOfCreditInput";
            amountOfCreditInput.Size = new Size(274, 31);
            amountOfCreditInput.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 177);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 2;
            label2.Text = "Bank rate:";
            // 
            // bankRateInput
            // 
            bankRateInput.Location = new Point(58, 205);
            bankRateInput.Name = "bankRateInput";
            bankRateInput.Size = new Size(268, 31);
            bankRateInput.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 284);
            label3.Name = "label3";
            label3.Size = new Size(267, 25);
            label3.TabIndex = 4;
            label3.Text = "Numbers of installments in year:";
            // 
            // numberOfInstallmentsInput
            // 
            numberOfInstallmentsInput.Location = new Point(58, 312);
            numberOfInstallmentsInput.Name = "numberOfInstallmentsInput";
            numberOfInstallmentsInput.Size = new Size(269, 31);
            numberOfInstallmentsInput.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(58, 522);
            button1.Name = "button1";
            button1.Size = new Size(268, 55);
            button1.TabIndex = 6;
            button1.Text = "Count installments";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // yearsInput
            // 
            yearsInput.Location = new Point(58, 423);
            yearsInput.Name = "yearsInput";
            yearsInput.Size = new Size(269, 31);
            yearsInput.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 395);
            label4.Name = "label4";
            label4.Size = new Size(198, 25);
            label4.TabIndex = 7;
            label4.Text = "Numbers of credit year:";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { nr, creditpart, interestpart, annuited });
            listView1.Location = new Point(460, 72);
            listView1.Name = "listView1";
            listView1.Size = new Size(674, 547);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // nr
            // 
            nr.Text = "Nr";
            nr.Width = 90;
            // 
            // creditpart
            // 
            creditpart.Text = "Credit Part";
            creditpart.Width = 190;
            // 
            // interestpart
            // 
            interestpart.Text = "Interest Part";
            interestpart.Width = 190;
            // 
            // annuited
            // 
            annuited.Text = "Annuited Installment";
            annuited.Width = 190;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 696);
            Controls.Add(listView1);
            Controls.Add(yearsInput);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(numberOfInstallmentsInput);
            Controls.Add(label3);
            Controls.Add(bankRateInput);
            Controls.Add(label2);
            Controls.Add(amountOfCreditInput);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Annuity Installment Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox amountOfCreditInput;
        private Label label2;
        private TextBox bankRateInput;
        private Label label3;
        private TextBox numberOfInstallmentsInput;
        private Button button1;
        private TextBox yearsInput;
        private Label label4;
        private ListView listView1;
        private ColumnHeader creditpart;
        private ColumnHeader interestpart;
        private ColumnHeader annuited;
        private ColumnHeader nr;
    }
}