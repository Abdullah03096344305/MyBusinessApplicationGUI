
namespace MyBusinessApplicationGUI
{
    partial class DeleteDealMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DealListView = new System.Windows.Forms.ListView();
            this.DealNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DealPrices = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(523, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 36);
            this.button1.TabIndex = 78;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(458, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 82);
            this.label2.TabIndex = 77;
            this.label2.Text = "BURGERS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(136, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 82);
            this.label1.TabIndex = 76;
            this.label1.Text = "SMASH";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(12, 569);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 36);
            this.button2.TabIndex = 75;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(313, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 23);
            this.label3.TabIndex = 79;
            this.label3.Text = "Select a Item and Press Delete";
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
            this.DealListView.Location = new System.Drawing.Point(107, 180);
            this.DealListView.Name = "DealListView";
            this.DealListView.Size = new System.Drawing.Size(594, 355);
            this.DealListView.TabIndex = 80;
            this.DealListView.UseCompatibleStateImageBehavior = false;
            this.DealListView.View = System.Windows.Forms.View.Details;
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
            // DeleteDealMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(818, 617);
            this.Controls.Add(this.DealListView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "DeleteDealMenu";
            this.Text = "DeleteDealMenu";
            this.Load += new System.EventHandler(this.DeleteDealMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView DealListView;
        private System.Windows.Forms.ColumnHeader DealNames;
        private System.Windows.Forms.ColumnHeader DealPrices;
    }
}