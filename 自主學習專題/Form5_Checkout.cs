using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace 自主學習專題
{
    public partial class Form5_Checkout : Form
    {
        private List<Form4_Order.MenuItem> cart;
        private Dictionary<string, (TimeSpan start, TimeSpan end)> regionTimeRanges = new Dictionary<string, (TimeSpan, TimeSpan)>
        {
            { "台北", (new TimeSpan(10, 0, 0), new TimeSpan(20, 0, 0)) },
            { "台中", (new TimeSpan(11, 0, 0), new TimeSpan(19, 0, 0)) },
            { "高雄", (new TimeSpan(9, 30, 0), new TimeSpan(18, 30, 0)) }
        };

        public Form5_Checkout(List<Form4_Order.MenuItem> cart)
        {
            this.Text = "結帳";
            InitializeComponent();
            this.cart = cart;
            LoadCart();
            InitializePaymentOptions();

            this.FormClosing += Form5_Checkout_FormClosing; // 關閉前提示
            InitializeStatusStrip();
        }

        private void LoadCart()
        {
            listBoxSummary.Items.Clear();
            int total = 0;
            foreach (var item in cart)
            {
                listBoxSummary.Items.Add(item.ToString());
                total += item.Price;
            }
            labelTotal.Text = "總金額: $" + total;
        }

        private void InitializePaymentOptions()
        {
            // ComboBox 地區選擇
            comboBoxRegion.Items.AddRange(new string[] { "台北", "台中", "高雄" });
            comboBoxRegion.SelectedIndex = 0;

            // RadioButton 預設付款方式
            radioButtonCreditCard.Checked = true;

            // DateTimePicker 限制只能選今天~7天內
            dateTimePickerPickup.MinDate = DateTime.Today;
            dateTimePickerPickup.MaxDate = DateTime.Today.AddDays(7);

            // 日期時間格式設定為自訂（含日期與時間）
            dateTimePickerPickup.Format = DateTimePickerFormat.Custom;
            dateTimePickerPickup.CustomFormat = "yyyy/MM/dd HH:mm";
            dateTimePickerPickup.Value = DateTime.Now.AddMinutes(30); // 預設時間

            // 綁定事件
            dateTimePickerPickup.ValueChanged += dateTimePickerPickup_ValueChanged;
            comboBoxRegion.SelectedIndexChanged += comboBoxRegion_SelectedIndexChanged;
        }


        private void dateTimePickerPickup_ValueChanged(object sender, EventArgs e)
        {
            DateTime selected = dateTimePickerPickup.Value;
            DateTime today = DateTime.Today;
            if ((selected - today).TotalDays > 7)
            {
                MessageBox.Show("已超過7天，無法選擇。", "日期超出限制", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePickerPickup.Value = today.AddDays(1).AddHours(12); // 自動改回明天中午
            }
        }

        private void comboBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string region = comboBoxRegion.SelectedItem.ToString();
            if (regionTimeRanges.TryGetValue(region, out var timeRange))
            {
                label1.Text = $"可取餐時間：{timeRange.start:hh\\:mm} ~ {timeRange.end:hh\\:mm}";
                DateTime today = DateTime.Today;
                DateTime suggestedTime = today + timeRange.start;

                if (DateTime.Now.TimeOfDay > timeRange.start && DateTime.Now.TimeOfDay < timeRange.end)
                    suggestedTime = DateTime.Now.AddMinutes(30);

                dateTimePickerPickup.Value = suggestedTime;
            }
        }

        private void Form5_Checkout_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("您確定要離開結帳畫面嗎？", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string paymentMethod = radioButtonCreditCard.Checked ? "信用卡" : radioButtonCash.Checked ? "現金" : "Line Pay";
            string region = comboBoxRegion.SelectedItem.ToString();
            DateTime pickupTime = dateTimePickerPickup.Value;

            MessageBox.Show($"付款方式: {paymentMethod}\n出貨地區: {region}\n取餐時間: {pickupTime:yyyy/MM/dd HH:mm}\n\n感謝您的訂購！", "訂單確認");
        }

        private ToolStripStatusLabel toolStripStatusLabel1;
        private void InitializeStatusStrip()
        {
            StatusStrip statusStrip = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel("狀態：結帳");
            statusStrip.Items.Add(toolStripStatusLabel1);
            this.Controls.Add(statusStrip);
        }
    }
}

