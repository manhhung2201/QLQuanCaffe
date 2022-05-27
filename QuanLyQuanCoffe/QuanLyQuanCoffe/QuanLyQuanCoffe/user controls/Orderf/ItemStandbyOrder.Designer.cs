
namespace QuanLyQuanCoffe.user_controls.Orderf
{
    partial class ItemStandbyOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderSelect = new System.Windows.Forms.CheckBox();
            this.btnDown = new Guna.UI2.WinForms.Guna2Button();
            this.btnUp = new Guna.UI2.WinForms.Guna2Button();
            this.itemPrice = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemName
            // 
            this.itemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.Location = new System.Drawing.Point(3, 15);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(129, 30);
            this.itemName.TabIndex = 1;
            this.itemName.Text = "Customer Oder";
            this.itemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.btnUp);
            this.panel1.Controls.Add(this.btnDown);
            this.panel1.Location = new System.Drawing.Point(208, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 45);
            this.panel1.TabIndex = 2;
            // 
            // orderSelect
            // 
            this.orderSelect.AutoSize = true;
            this.orderSelect.Location = new System.Drawing.Point(184, 26);
            this.orderSelect.Name = "orderSelect";
            this.orderSelect.Size = new System.Drawing.Size(15, 14);
            this.orderSelect.TabIndex = 3;
            this.orderSelect.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.CustomBorderColor = System.Drawing.Color.LightGray;
            this.btnDown.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.btnDown.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDown.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDown.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDown.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDown.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDown.FillColor = System.Drawing.Color.White;
            this.btnDown.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.ForeColor = System.Drawing.Color.Black;
            this.btnDown.Location = new System.Drawing.Point(0, 0);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(60, 45);
            this.btnDown.TabIndex = 3;
            this.btnDown.Text = "-";
            // 
            // btnUp
            // 
            this.btnUp.CustomBorderColor = System.Drawing.Color.LightGray;
            this.btnUp.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.btnUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUp.FillColor = System.Drawing.Color.White;
            this.btnUp.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.ForeColor = System.Drawing.Color.Black;
            this.btnUp.Location = new System.Drawing.Point(117, 0);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(55, 45);
            this.btnUp.TabIndex = 4;
            this.btnUp.Text = "+";
            // 
            // itemPrice
            // 
            this.itemPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPrice.ForeColor = System.Drawing.Color.Green;
            this.itemPrice.Location = new System.Drawing.Point(383, 15);
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Size = new System.Drawing.Size(87, 33);
            this.itemPrice.TabIndex = 4;
            this.itemPrice.Text = "gia";
            this.itemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAmount
            // 
            this.txtAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAmount.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(60, 0);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(57, 45);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.Text = "1";
            this.txtAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemStandbyOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itemPrice);
            this.Controls.Add(this.orderSelect);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.itemName);
            this.Name = "ItemStandbyOrder";
            this.Size = new System.Drawing.Size(502, 66);
            this.Load += new System.EventHandler(this.ItemStandbyOrder_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox orderSelect;
        public System.Windows.Forms.Label txtAmount;
        public Guna.UI2.WinForms.Guna2Button btnUp;
        public Guna.UI2.WinForms.Guna2Button btnDown;
        public System.Windows.Forms.Label itemPrice;
    }
}
