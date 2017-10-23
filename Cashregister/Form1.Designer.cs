namespace Cashregister
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
            this.newOrderButton = new System.Windows.Forms.Button();
            this.printRecieptButton = new System.Windows.Forms.Button();
            this.itemOneAmount = new System.Windows.Forms.NumericUpDown();
            this.itemTwoAmount = new System.Windows.Forms.NumericUpDown();
            this.itemThreeAmount = new System.Windows.Forms.NumericUpDown();
            this.itemOneLabel = new System.Windows.Forms.Label();
            this.itemTwoLabel = new System.Windows.Forms.Label();
            this.itemThreeLabel = new System.Windows.Forms.Label();
            this.cashLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.totalsButton = new System.Windows.Forms.Button();
            this.changeAmountLabel = new System.Windows.Forms.Label();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.taxAmountLabel = new System.Windows.Forms.Label();
            this.subTotalAmountLabel = new System.Windows.Forms.Label();
            this.cashAmountTextBox = new System.Windows.Forms.TextBox();
            this.recieptPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.itemOneAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTwoAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemThreeAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // newOrderButton
            // 
            this.newOrderButton.AutoSize = true;
            this.newOrderButton.Location = new System.Drawing.Point(26, 381);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(192, 23);
            this.newOrderButton.TabIndex = 1;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // printRecieptButton
            // 
            this.printRecieptButton.AutoSize = true;
            this.printRecieptButton.Location = new System.Drawing.Point(26, 410);
            this.printRecieptButton.Name = "printRecieptButton";
            this.printRecieptButton.Size = new System.Drawing.Size(192, 23);
            this.printRecieptButton.TabIndex = 2;
            this.printRecieptButton.Text = "Print Reciept";
            this.printRecieptButton.UseVisualStyleBackColor = true;
            this.printRecieptButton.Click += new System.EventHandler(this.printRecieptButton_Click);
            // 
            // itemOneAmount
            // 
            this.itemOneAmount.Location = new System.Drawing.Point(98, 9);
            this.itemOneAmount.Name = "itemOneAmount";
            this.itemOneAmount.Size = new System.Drawing.Size(120, 20);
            this.itemOneAmount.TabIndex = 3;
            // 
            // itemTwoAmount
            // 
            this.itemTwoAmount.Location = new System.Drawing.Point(98, 35);
            this.itemTwoAmount.Name = "itemTwoAmount";
            this.itemTwoAmount.Size = new System.Drawing.Size(120, 20);
            this.itemTwoAmount.TabIndex = 4;
            // 
            // itemThreeAmount
            // 
            this.itemThreeAmount.Location = new System.Drawing.Point(98, 61);
            this.itemThreeAmount.Name = "itemThreeAmount";
            this.itemThreeAmount.Size = new System.Drawing.Size(120, 20);
            this.itemThreeAmount.TabIndex = 5;
            // 
            // itemOneLabel
            // 
            this.itemOneLabel.AutoSize = true;
            this.itemOneLabel.Location = new System.Drawing.Point(55, 14);
            this.itemOneLabel.Name = "itemOneLabel";
            this.itemOneLabel.Size = new System.Drawing.Size(38, 13);
            this.itemOneLabel.TabIndex = 6;
            this.itemOneLabel.Text = "Burger";
            // 
            // itemTwoLabel
            // 
            this.itemTwoLabel.AutoSize = true;
            this.itemTwoLabel.Location = new System.Drawing.Point(64, 40);
            this.itemTwoLabel.Name = "itemTwoLabel";
            this.itemTwoLabel.Size = new System.Drawing.Size(29, 13);
            this.itemTwoLabel.TabIndex = 7;
            this.itemTwoLabel.Text = "Fries";
            // 
            // itemThreeLabel
            // 
            this.itemThreeLabel.AutoSize = true;
            this.itemThreeLabel.Location = new System.Drawing.Point(60, 66);
            this.itemThreeLabel.Name = "itemThreeLabel";
            this.itemThreeLabel.Size = new System.Drawing.Size(32, 13);
            this.itemThreeLabel.TabIndex = 8;
            this.itemThreeLabel.Text = "Coke";
            // 
            // cashLabel
            // 
            this.cashLabel.AutoSize = true;
            this.cashLabel.Location = new System.Drawing.Point(9, 164);
            this.cashLabel.Name = "cashLabel";
            this.cashLabel.Size = new System.Drawing.Size(83, 13);
            this.cashLabel.TabIndex = 6;
            this.cashLabel.Text = "Cash Tendered:";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(8, 189);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(84, 13);
            this.changeLabel.TabIndex = 5;
            this.changeLabel.Text = "Changed Owed:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(58, 139);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "Total:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(64, 115);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(28, 13);
            this.taxLabel.TabIndex = 3;
            this.taxLabel.Text = "Tax:";
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Location = new System.Drawing.Point(36, 91);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(56, 13);
            this.subTotalLabel.TabIndex = 2;
            this.subTotalLabel.Text = "Sub-Total:";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(26, 352);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(192, 23);
            this.changeButton.TabIndex = 1;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // totalsButton
            // 
            this.totalsButton.Location = new System.Drawing.Point(26, 323);
            this.totalsButton.Name = "totalsButton";
            this.totalsButton.Size = new System.Drawing.Size(192, 23);
            this.totalsButton.TabIndex = 0;
            this.totalsButton.Text = "Calculate Totals";
            this.totalsButton.UseVisualStyleBackColor = true;
            this.totalsButton.Click += new System.EventHandler(this.totalsButton_Click);
            // 
            // changeAmountLabel
            // 
            this.changeAmountLabel.BackColor = System.Drawing.Color.White;
            this.changeAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changeAmountLabel.Location = new System.Drawing.Point(98, 185);
            this.changeAmountLabel.Name = "changeAmountLabel";
            this.changeAmountLabel.Size = new System.Drawing.Size(120, 20);
            this.changeAmountLabel.TabIndex = 9;
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.BackColor = System.Drawing.Color.White;
            this.totalAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalAmountLabel.Location = new System.Drawing.Point(98, 135);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(120, 20);
            this.totalAmountLabel.TabIndex = 11;
            // 
            // taxAmountLabel
            // 
            this.taxAmountLabel.BackColor = System.Drawing.Color.White;
            this.taxAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxAmountLabel.Location = new System.Drawing.Point(98, 111);
            this.taxAmountLabel.Name = "taxAmountLabel";
            this.taxAmountLabel.Size = new System.Drawing.Size(120, 20);
            this.taxAmountLabel.TabIndex = 12;
            // 
            // subTotalAmountLabel
            // 
            this.subTotalAmountLabel.BackColor = System.Drawing.Color.White;
            this.subTotalAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subTotalAmountLabel.Location = new System.Drawing.Point(98, 87);
            this.subTotalAmountLabel.Name = "subTotalAmountLabel";
            this.subTotalAmountLabel.Size = new System.Drawing.Size(120, 20);
            this.subTotalAmountLabel.TabIndex = 13;
            // 
            // cashAmountTextBox
            // 
            this.cashAmountTextBox.Location = new System.Drawing.Point(98, 160);
            this.cashAmountTextBox.Name = "cashAmountTextBox";
            this.cashAmountTextBox.Size = new System.Drawing.Size(120, 20);
            this.cashAmountTextBox.TabIndex = 14;
            // 
            // recieptPanel
            // 
            this.recieptPanel.BackColor = System.Drawing.Color.White;
            this.recieptPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recieptPanel.Location = new System.Drawing.Point(224, 9);
            this.recieptPanel.Name = "recieptPanel";
            this.recieptPanel.Size = new System.Drawing.Size(256, 423);
            this.recieptPanel.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 441);
            this.Controls.Add(this.recieptPanel);
            this.Controls.Add(this.cashAmountTextBox);
            this.Controls.Add(this.subTotalAmountLabel);
            this.Controls.Add(this.taxAmountLabel);
            this.Controls.Add(this.totalAmountLabel);
            this.Controls.Add(this.changeAmountLabel);
            this.Controls.Add(this.itemOneLabel);
            this.Controls.Add(this.printRecieptButton);
            this.Controls.Add(this.itemThreeLabel);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.itemOneAmount);
            this.Controls.Add(this.cashLabel);
            this.Controls.Add(this.itemTwoLabel);
            this.Controls.Add(this.itemTwoAmount);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.itemThreeAmount);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.totalsButton);
            this.Controls.Add(this.changeButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Aidan\'s POS";
            ((System.ComponentModel.ISupportInitialize)(this.itemOneAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTwoAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemThreeAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button printRecieptButton;
        private System.Windows.Forms.NumericUpDown itemOneAmount;
        private System.Windows.Forms.NumericUpDown itemTwoAmount;
        private System.Windows.Forms.NumericUpDown itemThreeAmount;
        private System.Windows.Forms.Label itemOneLabel;
        private System.Windows.Forms.Label itemTwoLabel;
        private System.Windows.Forms.Label itemThreeLabel;
        private System.Windows.Forms.Label cashLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button totalsButton;
        private System.Windows.Forms.Label changeAmountLabel;
        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.Label taxAmountLabel;
        private System.Windows.Forms.Label subTotalAmountLabel;
        private System.Windows.Forms.TextBox cashAmountTextBox;
        private System.Windows.Forms.Panel recieptPanel;
    }
}

