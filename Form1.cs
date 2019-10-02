using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VyFood
{
    public partial class Form1 : Form
    {
        public List<Food> food;

        public Food MakeFood(string name, float price)
        {
            Food f = new Food();
            f.Name = name;
            f.Price = price;
            f.Quantity = 0;
            f.InitializeGUIComponent();
            return f;
        }

        int i = 0;
        public void ImportFood()
        {
            food = new List<Food>();

            StreamReader sr = File.OpenText("Food.txt");
            do
            {
                string line = sr.ReadLine();
                if (line == null) break;

                string[] s = line.Trim().Split('"');
                Food f = MakeFood(s[1], float.Parse(s[2]));

                f.GUIMenuImage.BackgroundImage = FoodImageList.Images[i];
                f.GUICartImage.BackgroundImage = FoodImageList.Images[i];
                TabMenu.Controls.Add(f.GUIMenuPanel);
                if (i > 0)
                    f.GUIMenuPanel.Location = food[i - 1].GUIMenuPanel.Location + new Size(f.GUIMenuPanel.Size.Width + 25, 0);

                food.Add(f);
                i++;
            }
            while (true);

        }

        public Form1()
        {
            InitializeComponent();
            ImportFood();
            Food call = new Food();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            tabControl.Size = Size - new Size(20, 40);
        }

        private void TabCart_Enter(object sender, EventArgs e)
        {
            int j = -1;

            float totalMoney = 0;
            for (int i = 0; i < food.Count(); i++)
                if (food[i].Quantity > 0)
                {
                    totalMoney += food[i].Fee();
                    food[i].UpdateGUICartQuantity();
                    food[i].UpdateGUICartTotalMoney();
                    if (!TabCart.Controls.Contains(food[i].GUICartPanel))
                        TabCart.Controls.Add(food[i].GUICartPanel);

                    if (j != -1)
                        food[i].GUICartPanel.Location = food[j].GUICartPanel.Location
                            + new Size(0, food[i].GUICartPanel.Size.Height + 20);
                    else
                        food[i].GUICartPanel.Location = new Point(6, 78);
                    j = i;
                }
                else
                    if (TabCart.Controls.Contains(food[i].GUICartPanel))
                        TabCart.Controls.Remove(food[i].GUICartPanel);

            TotalMoney.Text = Convert.ToString(totalMoney) + " $";

            if (j != -1)
            {
                TotalMoney.Location = food[j].GUICartPanel.Location + new Size(0, food[j].GUICartPanel.Size.Height + 20);
                PayButton.Location = food[j].GUICartPanel.Location + new Size(TotalMoney.Size.Width + 20, food[j].GUICartPanel.Size.Height + 20);
            }
            else
            {
                TotalMoney.Location = new Point(6, NameHeader.Location.Y + NameHeader.Size.Height + 20);
                PayButton.Location = new Point(TotalMoney.Size.Width + 26, TotalMoney.Location.Y);
            }
        }

        private void ExportBill()
        {
            StreamWriter sw = File.CreateText("Bill.txt");

            float totalMoney = 0;
            for (int i = 0; i < food.Count(); i++)
                if (food[i].Quantity > 0)
                {
                    totalMoney += food[i].Fee();
                    sw.WriteLine(food[i].Name + "\t" + food[i].Quantity + "\t" + food[i].Price + " $\t" + food[i].Fee() + " $");
                }
            sw.WriteLine("Total Money:\t" + totalMoney + " $");
            sw.Close();
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ExportBill();
                for (int i = 0; i < food.Count(); i++)
                {
                    food[i].Quantity = 0;
                    food[i].UpdateGUIMenuQuantity();
                }
                TabCart_Enter(null, null);
            }
                
        }
    }
}
