namespace WindowsFormsApp1
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
            this.Item_Price = new System.Windows.Forms.TextBox();
            this.Number_Units = new System.Windows.Forms.TextBox();
            this.Money_Amount = new System.Windows.Forms.TextBox();
            this.Results = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Submit_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Item_Price
            // 
            this.Item_Price.Location = new System.Drawing.Point(319, 38);
            this.Item_Price.Name = "Item_Price";
            this.Item_Price.Size = new System.Drawing.Size(222, 20);
            this.Item_Price.TabIndex = 0;
            // 
            // Number_Units
            // 
            this.Number_Units.Location = new System.Drawing.Point(319, 95);
            this.Number_Units.Name = "Number_Units";
            this.Number_Units.Size = new System.Drawing.Size(222, 20);
            this.Number_Units.TabIndex = 1;
            // 
            // Money_Amount
            // 
            this.Money_Amount.Location = new System.Drawing.Point(319, 148);
            this.Money_Amount.Name = "Money_Amount";
            this.Money_Amount.Size = new System.Drawing.Size(222, 20);
            this.Money_Amount.TabIndex = 2;
            // 
            // Results
            // 
            this.Results.Location = new System.Drawing.Point(319, 201);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(222, 20);
            this.Results.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter item price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter number of units:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter money amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Results:";
            // 
            // Submit_BTN
            // 
            this.Submit_BTN.Location = new System.Drawing.Point(319, 258);
            this.Submit_BTN.Name = "Submit_BTN";
            this.Submit_BTN.Size = new System.Drawing.Size(75, 23);
            this.Submit_BTN.TabIndex = 8;
            this.Submit_BTN.Text = "Submit";
            this.Submit_BTN.UseVisualStyleBackColor = true;
            this.Submit_BTN.Click += new System.EventHandler(this.Submit_BTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Submit_BTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.Money_Amount);
            this.Controls.Add(this.Number_Units);
            this.Controls.Add(this.Item_Price);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Item_Price;
        private System.Windows.Forms.TextBox Number_Units;
        private System.Windows.Forms.TextBox Money_Amount;
        private System.Windows.Forms.TextBox Results;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Submit_BTN;
    }
}

