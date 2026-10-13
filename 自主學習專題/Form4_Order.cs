using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace 自主學習專題
{
    public partial class Form4_Order : Form
    {
        public class MenuItem
        {
            public string Category { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
            public override string ToString() => $"{Name} - ${Price}";
        }

        private List<MenuItem> allItems = new List<MenuItem>();
        private List<MenuItem> cart = new List<MenuItem>();
        private Point dragStartPoint;


        public Form4_Order()
        {
            this.Text = "點餐";
            InitializeComponent();
            LoadMenu();
            ShowCategory("主餐");

            listBoxMenu.MouseDown += listBoxMenu_MouseDown;
            listBoxCart.DragEnter += listBoxCart_DragEnter;
            listBoxCart.DragDrop += listBoxCart_DragDrop;

            InitializeToolStrip();
            InitializeStatusStrip();
        }

        private void LoadMenu()
        {
            allItems.Add(new MenuItem { Category = "主餐", Name = "炸雞", Price = 100 });
            allItems.Add(new MenuItem { Category = "主餐", Name = "牛排", Price = 220 });
            allItems.Add(new MenuItem { Category = "主餐", Name = "豬排飯", Price = 140 });
            allItems.Add(new MenuItem { Category = "飲料", Name = "紅茶", Price = 35 });
            allItems.Add(new MenuItem { Category = "飲料", Name = "果汁", Price = 45 });
            allItems.Add(new MenuItem { Category = "飲料", Name = "奶茶", Price = 50 });
            allItems.Add(new MenuItem { Category = "甜點", Name = "冰淇淋", Price = 50 });
            allItems.Add(new MenuItem { Category = "甜點", Name = "蛋糕", Price = 60 });
            allItems.Add(new MenuItem { Category = "甜點", Name = "布丁", Price = 70 });
        }

        private void ShowCategory(string category)
        {
            listBoxMenu.Items.Clear();
            foreach (var item in allItems)
            {
                if (item.Category == category)
                    listBoxMenu.Items.Add(item);
            }
            HighlightButton(category);
        }

        private void HighlightButton(string category)
        {
            btnMain.BackColor = SystemColors.Control;
            btnDrink.BackColor = SystemColors.Control;
            btnDessert.BackColor = SystemColors.Control;

            switch (category)
            {
                case "主餐": btnMain.BackColor = Color.LightBlue; break;
                case "飲料": btnDrink.BackColor = Color.LightBlue; break;
                case "甜點": btnDessert.BackColor = Color.LightBlue; break;
            }
        }


        private void btnMain_Click(object sender, EventArgs e)
        {
            ShowCategory("主餐");
            btnMain.BackColor = Color.LightBlue;
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            ShowCategory("飲料");
            btnDrink.BackColor = Color.LightBlue;
        }
        private void btnDessert_Click(object sender, EventArgs e)
        {
            ShowCategory("甜點");
            btnDessert.BackColor = Color.LightBlue;
        }

        private void listBoxMenu_MouseDown(object sender, MouseEventArgs e)
        {
            dragStartPoint = e.Location;
        }

        private void listBoxMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // 拖曳距離達到門檻才觸發
                if (Math.Abs(e.X - dragStartPoint.X) >= SystemInformation.DragSize.Width / 2 ||
                    Math.Abs(e.Y - dragStartPoint.Y) >= SystemInformation.DragSize.Height / 2)
                {
                    if (listBoxMenu.SelectedItems.Count > 0)
                    {
                        List<MenuItem> selectedItems = new List<MenuItem>();
                        foreach (var item in listBoxMenu.SelectedItems)
                        {
                            if (item is MenuItem menuItem)
                                selectedItems.Add(menuItem);
                        }

                        listBoxMenu.DoDragDrop(selectedItems, DragDropEffects.Copy);
                    }
                }
            }
        }


        private void listBoxCart_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<MenuItem>)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBoxCart_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<MenuItem>)))
            {
                var droppedItems = (List<MenuItem>)e.Data.GetData(typeof(List<MenuItem>));

                foreach (var item in droppedItems)
                {
                    // 檢查購物車中是否已經有這項（用 Name 判斷）
                    if (!cart.Exists(x => x.Name == item.Name))
                    {
                        cart.Add(item);
                        listBoxCart.Items.Add(item.ToString());
                    }
                }
            }
        }


        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Form5_Checkout checkout = new Form5_Checkout(cart);
            checkout.Show();
        }

        private void InitializeToolStrip()
        {
            ToolStrip toolStrip = new ToolStrip();

            var btnBack = new ToolStripButton("返回");
            btnBack.Click += (s, e) =>
            {
                Form1 loginForm = new Form1();
                loginForm.Show();   // 或 ShowDialog()
                this.Close();        // 隱藏目前 Form4，或用 this.Close(); 若你希望關掉
            };
            toolStrip.Items.Add(btnBack);

            toolStrip.Items.Add(new ToolStripButton("清空購物車", null, (s, e) => {
                cart.Clear();
                listBoxCart.Items.Clear();
            }));

            this.Controls.Add(toolStrip);
        }


        private ToolStripStatusLabel toolStripStatusLabel1;
        private void InitializeStatusStrip()
        {
            StatusStrip statusStrip = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel("狀態：正在點餐");
            statusStrip.Items.Add(toolStripStatusLabel1);
            this.Controls.Add(statusStrip);
        }
    }
}




