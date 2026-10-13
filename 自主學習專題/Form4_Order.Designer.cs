namespace 自主學習專題
{
    partial class Form4_Order
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
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.listBoxCart = new System.Windows.Forms.ListBox();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnDrink = new System.Windows.Forms.Button();
            this.btnDessert = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.ItemHeight = 24;
            this.listBoxMenu.Location = new System.Drawing.Point(317, 153);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxMenu.Size = new System.Drawing.Size(238, 340);
            this.listBoxMenu.TabIndex = 0;
            this.listBoxMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxMenu_MouseDown);
            this.listBoxMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBoxMenu_MouseMove);
            // 
            // listBoxCart
            // 
            this.listBoxCart.AllowDrop = true;
            this.listBoxCart.FormattingEnabled = true;
            this.listBoxCart.ItemHeight = 24;
            this.listBoxCart.Location = new System.Drawing.Point(599, 153);
            this.listBoxCart.Name = "listBoxCart";
            this.listBoxCart.Size = new System.Drawing.Size(238, 340);
            this.listBoxCart.TabIndex = 1;
            this.listBoxCart.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxCart_DragDrop);
            this.listBoxCart.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxCart_DragEnter);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(119, 153);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(131, 69);
            this.btnMain.TabIndex = 2;
            this.btnMain.Text = "主餐";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnDrink
            // 
            this.btnDrink.Location = new System.Drawing.Point(119, 289);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(131, 69);
            this.btnDrink.TabIndex = 3;
            this.btnDrink.Text = "飲料";
            this.btnDrink.UseVisualStyleBackColor = true;
            this.btnDrink.Click += new System.EventHandler(this.btnDrink_Click);
            // 
            // btnDessert
            // 
            this.btnDessert.Location = new System.Drawing.Point(119, 424);
            this.btnDessert.Name = "btnDessert";
            this.btnDessert.Size = new System.Drawing.Size(131, 69);
            this.btnDessert.TabIndex = 4;
            this.btnDessert.Text = "甜點";
            this.btnDessert.UseVisualStyleBackColor = true;
            this.btnDessert.Click += new System.EventHandler(this.btnDessert_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(513, 526);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(140, 71);
            this.btnCheckout.TabIndex = 5;
            this.btnCheckout.Text = "結帳";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // Form4_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 709);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnDessert);
            this.Controls.Add(this.btnDrink);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.listBoxCart);
            this.Controls.Add(this.listBoxMenu);
            this.Name = "Form4_Order";
            this.Text = "Form4_Order";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.ListBox listBoxCart;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnDrink;
        private System.Windows.Forms.Button btnDessert;
        private System.Windows.Forms.Button btnCheckout;
    }
}