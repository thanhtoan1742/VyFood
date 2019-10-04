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

        // Make a Food Object with given name and price.
        public Food MakeFood(string name, float price)
        {
            Food f = new Food();
            f.Name = name;
            f.Price = price;
            f.Quantity = 0;
            f.InitializeGUIComponent();
            return f;
        }

        // Import Food from "Food.txt".
        public void ImportFood()
        {
            food = new List<Food>();
            StreamReader sr = File.OpenText("Food.txt");
            int i = 0; 

            do
            {
                string line = sr.ReadLine();
                if (line == null) break;

                string[] s = line.Trim().Split('"');
                Food f = MakeFood(s[1], float.Parse(s[2]));

                // If there is not enough images, set the images to null (i.e. nothing)
                if (i < FoodImageList.Images.Count)
                    f.GUIMenuImage.BackgroundImage = FoodImageList.Images[i];
                else
                    f.GUIMenuImage.BackgroundImage = null;
                f.GUICartImage.BackgroundImage = f.GUIMenuImage.BackgroundImage;

                TabMenu.Controls.Add(f.GUIMenuPanel);
                food.Add(f);
                i++;
            }
            while (true);

        }

        private void ExportBill()
        {
            StreamWriter sw = File.CreateText("Bill.txt");

            float totalMoney = 0;
            for (int i = 0; i < food.Count(); i++)
                if (food[i].Quantity > 0)
                {
                    totalMoney += food[i].Fee();
                    sw.WriteLine("{0}  {1}$ {2}  {3}$", food[i].Name, food[i].Price, food[i].Quantity, food[i].Fee());
                }
            sw.WriteLine("Total Money: {0}$", totalMoney);
            sw.Close();
        }
        public Form1()
        {
            InitializeComponent();
            ImportFood();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            // Resize the tab menu to the form's size with some offset.
            tabControl.Size = Size - new Size(20, 40);
        }

        // Arrage food and buttons in TabCart.
        private void ArrageTabCart()
        {
            int j = -1;

            float totalMoney = 0;
            for (int i = 0; i < food.Count(); i++)
                if (food[i].Quantity > 0)
                {
                    // Update some labels and add the current food's CartPanel to TabCart.
                    totalMoney += food[i].Fee();
                    food[i].UpdateGUICartQuantity();
                    food[i].UpdateGUICartTotalMoney();
                    if (!TabCart.Controls.Contains(food[i].GUICartPanel))
                        TabCart.Controls.Add(food[i].GUICartPanel);

                    // If this is not the first food in the list then set its location according to the previous one.
                    if (j != -1)
                        food[i].GUICartPanel.Location = food[j].GUICartPanel.Location
                            + new Size(0, food[i].GUICartPanel.Size.Height + 20);
                    // Else set its location to (6, 78).
                    else
                        food[i].GUICartPanel.Location = new Point(6, 78);
                    j = i;
                }
                else
                    // Remove the food from TabCart if it's necessary.
                    if (TabCart.Controls.Contains(food[i].GUICartPanel))
                    TabCart.Controls.Remove(food[i].GUICartPanel);

            TotalMoney.Text = Convert.ToString(totalMoney) + " $";

            // Set the location of Total Money Label and Pay Button.
            if (j != -1)
            {
                //If the is some food in the list, set the location according to the last food in the list.
                TotalMoney.Location = food[j].GUICartPanel.Location + new Size(0, food[j].GUICartPanel.Size.Height + 20);
                PayButton.Location = food[j].GUICartPanel.Location + new Size(TotalMoney.Size.Width + 20, food[j].GUICartPanel.Size.Height + 20);
            }
            else
            {
                // Else set the location according to Headers.
                TotalMoney.Location = new Point(6, NameHeader.Location.Y + NameHeader.Size.Height + 20);
                PayButton.Location = new Point(TotalMoney.Size.Width + 26, TotalMoney.Location.Y);
            }

        }

        private void TabCart_Enter(object sender, EventArgs e)
        {
            // Arrange food when enter TabCart.
            ArrageTabCart();
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            // Confirmation Box.
            DialogResult result = MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ExportBill();
                // Reset food's Quantity and Quantity Label.
                for (int i = 0; i < food.Count(); i++)
                {
                    food[i].Quantity = 0;
                    food[i].UpdateGUIMenuQuantity();
                }
                // Reset Tabcart
                ArrageTabCart();
            }
                
        }

        // Arrange food in TabMenu.
        private void ReArrangeTabMenuFood()
        {
        	//
            food[0].GUIMenuPanel.Location = new Point(12, 12);
            for (int i = 1; i < food.Count(); i++)
            {
                // Set current food's Location according to the previous one.
                food[i].GUIMenuPanel.Location = food[i - 1].GUIMenuPanel.Location + new Size(food[i].GUIMenuPanel.Size.Width + 25, 0);
                // If its Panel cannot fit in, set its Location to the next line of food.
                if (food[i].GUIMenuPanel.Location.X + food[i].GUIMenuPanel.Size.Width > TabMenu.Size.Width)
                    food[i].GUIMenuPanel.Location = new Point(food[0].GUIMenuPanel.Location.X, food[i].GUIMenuPanel.Location.Y + food[i].GUIMenuPanel.Size.Height + 20);
            }
            // Seem stupid but doing this actually prevents some bugs.
            TabMenu.AutoScroll = false;
            TabMenu.AutoScroll = true;
        }

        private void TabMenu_Enter(object sender, EventArgs e)
        {
            ReArrangeTabMenuFood();
        }

        private void TabMenu_SizeChanged(object sender, EventArgs e)
        {
            ReArrangeTabMenuFood();
        }
    }
}
