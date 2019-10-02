using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VyFood
{
    public class Food
    {
        public string Name;
        public float Price;
        public int Quantity;

        public System.Windows.Forms.Panel GUIMenuPanel;
        private System.Windows.Forms.Label GUIMenuName;
        public System.Windows.Forms.PictureBox GUIMenuImage;
        private System.Windows.Forms.Label GUIMenuPrice;
        private System.Windows.Forms.Button GUIMenuAdd;
        private System.Windows.Forms.TextBox GUIMenuQuantity;
        private System.Windows.Forms.Button GUIMenuSubtract;

        public System.Windows.Forms.Panel GUICartPanel;
        public System.Windows.Forms.PictureBox GUICartImage;
        private System.Windows.Forms.Label GUICartName;
        private System.Windows.Forms.Label GUICartTotalMoney;
        public System.Windows.Forms.Label GUICartQuantity;
        private System.Windows.Forms.Label GUICartPrice;

        public void InitializeGUIComponent()
        {
            this.GUIMenuPanel = new System.Windows.Forms.Panel();
            this.GUIMenuImage = new System.Windows.Forms.PictureBox();
            this.GUIMenuName = new System.Windows.Forms.Label();
            this.GUIMenuPrice = new System.Windows.Forms.Label();
            this.GUIMenuSubtract = new System.Windows.Forms.Button();
            this.GUIMenuQuantity = new System.Windows.Forms.TextBox();
            this.GUIMenuAdd = new System.Windows.Forms.Button();

            this.GUICartPanel = new System.Windows.Forms.Panel();
            this.GUICartName = new System.Windows.Forms.Label();
            this.GUICartImage = new System.Windows.Forms.PictureBox();
            this.GUICartPrice = new System.Windows.Forms.Label();
            this.GUICartQuantity = new System.Windows.Forms.Label();
            this.GUICartTotalMoney = new System.Windows.Forms.Label();
            // 
            // GUIMenuPanel
            // 
            this.GUIMenuPanel.Controls.Add(this.GUIMenuAdd);
            this.GUIMenuPanel.Controls.Add(this.GUIMenuQuantity);
            this.GUIMenuPanel.Controls.Add(this.GUIMenuSubtract);
            this.GUIMenuPanel.Controls.Add(this.GUIMenuPrice);
            this.GUIMenuPanel.Controls.Add(this.GUIMenuName);
            this.GUIMenuPanel.Controls.Add(this.GUIMenuImage);
            this.GUIMenuPanel.Location = new System.Drawing.Point(12, 12);
            this.GUIMenuPanel.Name = "GUIMenuPanel";
            this.GUIMenuPanel.Size = new System.Drawing.Size(170, 250);
            this.GUIMenuPanel.TabIndex = 0;
            // 
            // GUIMenuImage
            // 
            this.GUIMenuImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GUIMenuImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GUIMenuImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GUIMenuImage.Location = new System.Drawing.Point(0, 0);
            this.GUIMenuImage.Name = "GUIMenuImage";
            this.GUIMenuImage.Size = new System.Drawing.Size(167, 127);
            this.GUIMenuImage.TabIndex = 0;
            this.GUIMenuImage.TabStop = false;
            // 
            // GUIMenuName
            // 
            this.GUIMenuName.BackColor = System.Drawing.Color.DarkCyan;
            this.GUIMenuName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GUIMenuName.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GUIMenuName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GUIMenuName.Location = new System.Drawing.Point(4, 134);
            this.GUIMenuName.Name = "GUIMenuName";
            this.GUIMenuName.Size = new System.Drawing.Size(162, 37);
            this.GUIMenuName.TabIndex = 1;
            this.GUIMenuName.Text = Name;
            this.GUIMenuName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GUIMenuPrice
            // 
            this.GUIMenuPrice.BackColor = System.Drawing.Color.DarkCyan;
            this.GUIMenuPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GUIMenuPrice.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GUIMenuPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GUIMenuPrice.Location = new System.Drawing.Point(4, 171);
            this.GUIMenuPrice.Name = "GUIMenuPrice";
            this.GUIMenuPrice.Size = new System.Drawing.Size(162, 37);
            this.GUIMenuPrice.TabIndex = 2;
            this.GUIMenuPrice.Text = Convert.ToString(Price) + " $";
            this.GUIMenuPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GUIMenuSubtract
            // 
            this.GUIMenuSubtract.BackColor = System.Drawing.Color.DarkCyan;
            this.GUIMenuSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GUIMenuSubtract.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GUIMenuSubtract.Location = new System.Drawing.Point(4, 212);
            this.GUIMenuSubtract.Name = "GUIMenuSubtract";
            this.GUIMenuSubtract.Size = new System.Drawing.Size(38, 33);
            this.GUIMenuSubtract.TabIndex = 3;
            this.GUIMenuSubtract.Text = "-";
            this.GUIMenuSubtract.UseVisualStyleBackColor = false;
            this.GUIMenuSubtract.Click += new System.EventHandler(this.GUIMenuSubtract_Click);
            // 
            // GUIMenuQuantity
            // 
            this.GUIMenuQuantity.BackColor = System.Drawing.Color.DarkCyan;
            this.GUIMenuQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GUIMenuQuantity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GUIMenuQuantity.Location = new System.Drawing.Point(48, 212);
            this.GUIMenuQuantity.Name = "GUIMenuQuantity";
            this.GUIMenuQuantity.Size = new System.Drawing.Size(73, 29);
            this.GUIMenuQuantity.TabIndex = 4;
            this.GUIMenuQuantity.Text = "0";
            this.GUIMenuQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GUIMenuQuantity.TextChanged += new System.EventHandler(this.GUIMenuQuantity_TextChanged);
            // 
            // GUIMenuAdd
            // 
            this.GUIMenuAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.GUIMenuAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GUIMenuAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GUIMenuAdd.Location = new System.Drawing.Point(127, 212);
            this.GUIMenuAdd.Name = "GUIMenuAdd";
            this.GUIMenuAdd.Size = new System.Drawing.Size(38, 33);
            this.GUIMenuAdd.TabIndex = 5;
            this.GUIMenuAdd.Text = "+";
            this.GUIMenuAdd.UseVisualStyleBackColor = false;
            this.GUIMenuAdd.Click += new System.EventHandler(this.GUIMenuAdd_Click);
            // 
            // GUICartPanel
            // 
            this.GUICartPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;      
            this.GUICartPanel.Controls.Add(this.GUICartTotalMoney);
            this.GUICartPanel.Controls.Add(this.GUICartQuantity);
            this.GUICartPanel.Controls.Add(this.GUICartPrice);
            this.GUICartPanel.Controls.Add(this.GUICartName);
            this.GUICartPanel.Controls.Add(this.GUICartImage);
            this.GUICartPanel.Location = new System.Drawing.Point(6, 78);
            this.GUICartPanel.Name = "GUICartPanel";
            this.GUICartPanel.Size = new System.Drawing.Size(875, 136);
            this.GUICartPanel.TabIndex = 0;
            // 
            // GUICartName
            // 
            this.GUICartName.BackColor = System.Drawing.Color.DarkCyan;
            this.GUICartName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GUICartName.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GUICartName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GUICartName.Location = new System.Drawing.Point(188, 28);
            this.GUICartName.Name = "GUICartName";
            this.GUICartName.Size = new System.Drawing.Size(162, 75);
            this.GUICartName.TabIndex = 1;
            this.GUICartName.Text = Name;
            this.GUICartName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GUICartImage
            // 
            this.GUICartImage.BackColor = System.Drawing.Color.White;
            this.GUICartImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GUICartImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GUICartImage.Location = new System.Drawing.Point(4, 4);
            this.GUICartImage.Name = "GUICartImage";
            this.GUICartImage.Size = new System.Drawing.Size(167, 127);
            this.GUICartImage.TabIndex = 0;
            this.GUICartImage.TabStop = false;
            // 
            // GUICartPrice
            // 
            this.GUICartPrice.BackColor = System.Drawing.Color.DarkCyan;
            this.GUICartPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GUICartPrice.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GUICartPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GUICartPrice.Location = new System.Drawing.Point(356, 28);
            this.GUICartPrice.Name = "GUICartPrice";
            this.GUICartPrice.Size = new System.Drawing.Size(162, 75);
            this.GUICartPrice.TabIndex = 1;
            this.GUICartPrice.Text = Convert.ToString(Price) + " $";
            this.GUICartPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GUICartQuantity
            // 
            this.GUICartQuantity.BackColor = System.Drawing.Color.DarkCyan;
            this.GUICartQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GUICartQuantity.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GUICartQuantity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GUICartQuantity.Location = new System.Drawing.Point(524, 28);
            this.GUICartQuantity.Name = "GUICartQuantity";
            this.GUICartQuantity.Size = new System.Drawing.Size(162, 75);
            this.GUICartQuantity.TabIndex = 1;
            this.GUICartQuantity.Text = Convert.ToString(Quantity);
            this.GUICartQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GUICartTotalMoney
            // 
            this.GUICartTotalMoney.BackColor = System.Drawing.Color.DarkCyan;
            this.GUICartTotalMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GUICartTotalMoney.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GUICartTotalMoney.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GUICartTotalMoney.Location = new System.Drawing.Point(699, 28);
            this.GUICartTotalMoney.Name = "GUICartTotalMoney";
            this.GUICartTotalMoney.Size = new System.Drawing.Size(162, 75);
            this.GUICartTotalMoney.TabIndex = 1;
            this.GUICartTotalMoney.Text = Convert.ToString(Fee()) + " $";
            this.GUICartTotalMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        public void UpdateGUIMenuQuantity()
        {
            GUIMenuQuantity.Text = Convert.ToString(Quantity);
        }        
                
        public void UpdateGUICartQuantity()
        {
            GUICartQuantity.Text = Convert.ToString(Quantity);
        }        
        
        public void UpdateGUICartTotalMoney()
        {
            GUICartTotalMoney.Text = Convert.ToString(Fee()) + " $";
        }

        private void GUIMenuSubtract_Click(object sender, EventArgs e)
        {
            Quantity--;
            GUIMenuQuantity.Text = Convert.ToString(Quantity);
        }

        private void GUIMenuAdd_Click(object sender, EventArgs e)
        {
            Quantity++;
            GUIMenuQuantity.Text = Convert.ToString(Quantity);

        }

        private void GUIMenuQuantity_TextChanged(object sender, EventArgs e)
        {
            Quantity = Convert.ToInt32(GUIMenuQuantity.Text);
            Quantity = Math.Min(999, Quantity);
            Quantity = Math.Max(0, Quantity);
            GUIMenuQuantity.Text = Convert.ToString(Quantity);

        }

        public float Fee()
        {
            return Price * Quantity;
        }
    }
}
