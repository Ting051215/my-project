namespace 自主學習專題
{
    partial class Form5_Checkout
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
            this.listBoxSummary = new System.Windows.Forms.ListBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.dateTimePickerPickup = new System.Windows.Forms.DateTimePicker();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.radioButtonCreditCard = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonLinePay = new System.Windows.Forms.RadioButton();
            this.radioButtonCash = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxSummary
            // 
            this.listBoxSummary.FormattingEnabled = true;
            this.listBoxSummary.ItemHeight = 24;
            this.listBoxSummary.Location = new System.Drawing.Point(79, 104);
            this.listBoxSummary.Name = "listBoxSummary";
            this.listBoxSummary.Size = new System.Drawing.Size(268, 340);
            this.listBoxSummary.TabIndex = 0;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(451, 104);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(64, 24);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "label1";
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Location = new System.Drawing.Point(665, 158);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(154, 32);
            this.comboBoxRegion.TabIndex = 2;
            this.comboBoxRegion.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegion_SelectedIndexChanged);
            // 
            // dateTimePickerPickup
            // 
            this.dateTimePickerPickup.Location = new System.Drawing.Point(665, 236);
            this.dateTimePickerPickup.Name = "dateTimePickerPickup";
            this.dateTimePickerPickup.Size = new System.Drawing.Size(200, 36);
            this.dateTimePickerPickup.TabIndex = 3;
            this.dateTimePickerPickup.ValueChanged += new System.EventHandler(this.dateTimePickerPickup_ValueChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(665, 340);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(154, 84);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "結帳";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // radioButtonCreditCard
            // 
            this.radioButtonCreditCard.AutoSize = true;
            this.radioButtonCreditCard.Location = new System.Drawing.Point(25, 62);
            this.radioButtonCreditCard.Name = "radioButtonCreditCard";
            this.radioButtonCreditCard.Size = new System.Drawing.Size(113, 28);
            this.radioButtonCreditCard.TabIndex = 5;
            this.radioButtonCreditCard.TabStop = true;
            this.radioButtonCreditCard.Text = "信用卡";
            this.radioButtonCreditCard.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonLinePay);
            this.groupBox1.Controls.Add(this.radioButtonCash);
            this.groupBox1.Controls.Add(this.radioButtonCreditCard);
            this.groupBox1.Location = new System.Drawing.Point(387, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 264);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "付款方式";
            // 
            // radioButtonLinePay
            // 
            this.radioButtonLinePay.AutoSize = true;
            this.radioButtonLinePay.Location = new System.Drawing.Point(25, 216);
            this.radioButtonLinePay.Name = "radioButtonLinePay";
            this.radioButtonLinePay.Size = new System.Drawing.Size(122, 28);
            this.radioButtonLinePay.TabIndex = 7;
            this.radioButtonLinePay.TabStop = true;
            this.radioButtonLinePay.Text = "Line Pay";
            this.radioButtonLinePay.UseVisualStyleBackColor = true;
            // 
            // radioButtonCash
            // 
            this.radioButtonCash.AutoSize = true;
            this.radioButtonCash.Location = new System.Drawing.Point(25, 135);
            this.radioButtonCash.Name = "radioButtonCash";
            this.radioButtonCash.Size = new System.Drawing.Size(89, 28);
            this.radioButtonCash.TabIndex = 6;
            this.radioButtonCash.TabStop = true;
            this.radioButtonCash.Text = "現金";
            this.radioButtonCash.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(661, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "( 只能選擇7天內";
            // 
            // Form5_Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 573);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dateTimePickerPickup);
            this.Controls.Add(this.comboBoxRegion);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.listBoxSummary);
            this.Name = "Form5_Checkout";
            this.Text = "Form5_Checkout";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSummary;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.DateTimePicker dateTimePickerPickup;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.RadioButton radioButtonCreditCard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonLinePay;
        private System.Windows.Forms.RadioButton radioButtonCash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}