
namespace MyBusinessApplicationGUI
{
    partial class AdminSideReveiwForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserListView = new System.Windows.Forms.ListView();
            this.UserNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserNumbers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserRatings = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(12, 569);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(279, 36);
            this.button2.TabIndex = 51;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(331, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 44);
            this.label2.TabIndex = 50;
            this.label2.Text = "California";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(102, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(661, 82);
            this.label1.TabIndex = 49;
            this.label1.Text = "SMASH    BURGERS";
            // 
            // UserListView
            // 
            this.UserListView.BackColor = System.Drawing.Color.DarkOrange;
            this.UserListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserNames,
            this.UserNumbers,
            this.UserRatings,
            this.UserMessage});
            this.UserListView.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserListView.ForeColor = System.Drawing.Color.Maroon;
            this.UserListView.HideSelection = false;
            this.UserListView.Location = new System.Drawing.Point(12, 174);
            this.UserListView.Name = "UserListView";
            this.UserListView.Size = new System.Drawing.Size(801, 347);
            this.UserListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.UserListView.TabIndex = 78;
            this.UserListView.UseCompatibleStateImageBehavior = false;
            this.UserListView.View = System.Windows.Forms.View.Details;
            this.UserListView.SelectedIndexChanged += new System.EventHandler(this.UserListView_SelectedIndexChanged);
            // 
            // UserNames
            // 
            this.UserNames.Text = "Names";
            this.UserNames.Width = 215;
            // 
            // UserNumbers
            // 
            this.UserNumbers.Text = "Numbers";
            this.UserNumbers.Width = 170;
            // 
            // UserRatings
            // 
            this.UserRatings.Text = "Ratings";
            this.UserRatings.Width = 92;
            // 
            // UserMessage
            // 
            this.UserMessage.Text = "Message";
            this.UserMessage.Width = 333;
            // 
            // AdminSideReveiwForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(818, 617);
            this.Controls.Add(this.UserListView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminSideReveiwForm";
            this.Text = "AdminSideReveiwForm";
            this.Load += new System.EventHandler(this.AdminSideReveiwForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView UserListView;
        private System.Windows.Forms.ColumnHeader UserNames;
        private System.Windows.Forms.ColumnHeader UserNumbers;
        private System.Windows.Forms.ColumnHeader UserRatings;
        private System.Windows.Forms.ColumnHeader UserMessage;
    }
}