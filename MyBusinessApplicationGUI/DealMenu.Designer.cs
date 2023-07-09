
namespace MyBusinessApplicationGUI
{
    partial class DealMenu
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
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.DealListView = new System.Windows.Forms.ListView();
            this.DealNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DealPrices = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxTotalPrice.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalPrice.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxTotalPrice.Location = new System.Drawing.Point(12, 387);
            this.textBoxTotalPrice.Multiline = true;
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.Size = new System.Drawing.Size(223, 42);
            this.textBoxTotalPrice.TabIndex = 48;
            this.textBoxTotalPrice.TextChanged += new System.EventHandler(this.textBoxTotalPrice_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(14, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 36);
            this.button2.TabIndex = 45;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(837, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 22);
            this.label8.TabIndex = 44;
            this.label8.Text = "CALORIES";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(839, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 22);
            this.label7.TabIndex = 43;
            this.label7.Text = "The";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(839, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 22);
            this.label6.TabIndex = 42;
            this.label6.Text = "Not";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(839, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 41;
            this.label5.Text = "MEMORIES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(837, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 22);
            this.label4.TabIndex = 40;
            this.label4.Text = "The";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(837, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 39;
            this.label3.Text = "Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(375, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 44);
            this.label2.TabIndex = 38;
            this.label2.Text = "California";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(146, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(661, 82);
            this.label1.TabIndex = 37;
            this.label1.Text = "SMASH    BURGERS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 31);
            this.label10.TabIndex = 50;
            this.label10.Text = "Total Price Is: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 31);
            this.label9.TabIndex = 49;
            this.label9.Text = "Enter Quantity: ";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxQuantity.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantity.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxQuantity.Location = new System.Drawing.Point(14, 300);
            this.textBoxQuantity.Multiline = true;
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(223, 42);
            this.textBoxQuantity.TabIndex = 47;
            // 
            // DealListView
            // 
            this.DealListView.BackColor = System.Drawing.Color.DarkOrange;
            this.DealListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DealNames,
            this.DealPrices});
            this.DealListView.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealListView.ForeColor = System.Drawing.Color.Maroon;
            this.DealListView.HideSelection = false;
            this.DealListView.Location = new System.Drawing.Point(241, 173);
            this.DealListView.Name = "DealListView";
            this.DealListView.Size = new System.Drawing.Size(594, 355);
            this.DealListView.TabIndex = 51;
            this.DealListView.UseCompatibleStateImageBehavior = false;
            this.DealListView.View = System.Windows.Forms.View.Details;
            this.DealListView.SelectedIndexChanged += new System.EventHandler(this.DealListView_SelectedIndexChanged);
            // 
            // DealNames
            // 
            this.DealNames.Text = "Deal Name";
            this.DealNames.Width = 440;
            // 
            // DealPrices
            // 
            this.DealPrices.Text = "Deal Price";
            this.DealPrices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DealPrices.Width = 100;
            // 
            // DealMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(961, 540);
            this.Controls.Add(this.DealListView);
            this.Controls.Add(this.textBoxTotalPrice);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxQuantity);
            this.Name = "DealMenu";
            this.Text = "DealMenu";
            this.Load += new System.EventHandler(this.DealMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.ListView DealListView;
        private System.Windows.Forms.ColumnHeader DealNames;
        private System.Windows.Forms.ColumnHeader DealPrices;
    }
}