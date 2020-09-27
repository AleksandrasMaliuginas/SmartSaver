using System;

namespace SmartSaver
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.transactionDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.transactionCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.transactionReason = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.transactionExpense = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Transaction";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // transactionDate
            // 
            this.transactionDate.Location = new System.Drawing.Point(59, 41);
            this.transactionDate.Name = "transactionDate";
            this.transactionDate.Size = new System.Drawing.Size(200, 23);
            this.transactionDate.TabIndex = 2;
            this.transactionDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date";
            // 
            // transactionCategory
            // 
            this.transactionCategory.FormattingEnabled = true;
            this.transactionCategory.Items.AddRange(new object[] {
            "Category 1",
            "Category 2",
            "Category 3",
            "Category 4"});
            this.transactionCategory.Location = new System.Drawing.Point(326, 41);
            this.transactionCategory.Name = "transactionCategory";
            this.transactionCategory.Size = new System.Drawing.Size(121, 23);
            this.transactionCategory.TabIndex = 4;
            this.transactionCategory.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Reason";
            // 
            // transactionReason
            // 
            this.transactionReason.Location = new System.Drawing.Point(63, 87);
            this.transactionReason.Name = "transactionReason";
            this.transactionReason.Size = new System.Drawing.Size(196, 23);
            this.transactionReason.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Expense";
            // 
            // transactionExpense
            // 
            this.transactionExpense.Location = new System.Drawing.Point(387, 87);
            this.transactionExpense.Name = "transactionExpense";
            this.transactionExpense.Size = new System.Drawing.Size(60, 23);
            this.transactionExpense.TabIndex = 8;
            this.transactionExpense.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.transactionExpense_KeyPress);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(372, 127);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 162);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.transactionExpense);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.transactionReason);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.transactionCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.transactionDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "New Transaction";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker transactionDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox transactionCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox transactionReason;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox transactionExpense;
        private System.Windows.Forms.Button addButton;
    }
}