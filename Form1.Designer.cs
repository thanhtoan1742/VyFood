namespace VyFood
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FoodImageList = new System.Windows.Forms.ImageList(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.TabMenu = new System.Windows.Forms.TabPage();
            this.TabCart = new System.Windows.Forms.TabPage();
            this.PayButton = new System.Windows.Forms.Button();
            this.TotalMoney = new System.Windows.Forms.Label();
            this.TotalMoneyHeader = new System.Windows.Forms.Label();
            this.QuantityHeader = new System.Windows.Forms.Label();
            this.PriceHeader = new System.Windows.Forms.Label();
            this.NameHeader = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.TabCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // FoodImageList
            // 
            this.FoodImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("FoodImageList.ImageStream")));
            this.FoodImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.FoodImageList.Images.SetKeyName(0, "milktea");
            this.FoodImageList.Images.SetKeyName(1, "chicken");
            this.FoodImageList.Images.SetKeyName(2, "coca");
            this.FoodImageList.Images.SetKeyName(3, "coffee");
            this.FoodImageList.Images.SetKeyName(4, "potato");
            this.FoodImageList.Images.SetKeyName(5, "blacksugar");
            this.FoodImageList.Images.SetKeyName(6, "taco");
            this.FoodImageList.Images.SetKeyName(7, "hamburger");
            this.FoodImageList.Images.SetKeyName(8, "steak.jpg");
            this.FoodImageList.Images.SetKeyName(9, "Vy");
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.TabMenu);
            this.tabControl.Controls.Add(this.TabCart);
            this.tabControl.Location = new System.Drawing.Point(2, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(895, 452);
            this.tabControl.TabIndex = 0;
            // 
            // TabMenu
            // 
            this.TabMenu.AutoScroll = true;
            this.TabMenu.BackColor = System.Drawing.SystemColors.Control;
            this.TabMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TabMenu.Location = new System.Drawing.Point(4, 22);
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.TabMenu.Size = new System.Drawing.Size(887, 426);
            this.TabMenu.TabIndex = 0;
            this.TabMenu.Text = "Menu";
            this.TabMenu.SizeChanged += new System.EventHandler(this.TabMenu_SizeChanged);
            this.TabMenu.Enter += new System.EventHandler(this.TabMenu_Enter);
            // 
            // TabCart
            // 
            this.TabCart.AutoScroll = true;
            this.TabCart.BackColor = System.Drawing.SystemColors.Control;
            this.TabCart.Controls.Add(this.PayButton);
            this.TabCart.Controls.Add(this.TotalMoney);
            this.TabCart.Controls.Add(this.TotalMoneyHeader);
            this.TabCart.Controls.Add(this.QuantityHeader);
            this.TabCart.Controls.Add(this.PriceHeader);
            this.TabCart.Controls.Add(this.NameHeader);
            this.TabCart.ForeColor = System.Drawing.Color.DarkCyan;
            this.TabCart.Location = new System.Drawing.Point(4, 22);
            this.TabCart.Name = "TabCart";
            this.TabCart.Padding = new System.Windows.Forms.Padding(3);
            this.TabCart.Size = new System.Drawing.Size(887, 426);
            this.TabCart.TabIndex = 1;
            this.TabCart.Text = "Cart";
            this.TabCart.Enter += new System.EventHandler(this.TabCart_Enter);
            // 
            // PayButton
            // 
            this.PayButton.BackColor = System.Drawing.Color.DarkCyan;
            this.PayButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PayButton.Location = new System.Drawing.Point(672, 361);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(209, 54);
            this.PayButton.TabIndex = 1;
            this.PayButton.Text = "Order Now";
            this.PayButton.UseVisualStyleBackColor = false;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // TotalMoney
            // 
            this.TotalMoney.BackColor = System.Drawing.Color.DarkCyan;
            this.TotalMoney.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMoney.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalMoney.Location = new System.Drawing.Point(297, 361);
            this.TotalMoney.Name = "TotalMoney";
            this.TotalMoney.Size = new System.Drawing.Size(369, 54);
            this.TotalMoney.TabIndex = 0;
            this.TotalMoney.Text = "0 $";
            this.TotalMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalMoneyHeader
            // 
            this.TotalMoneyHeader.BackColor = System.Drawing.Color.DarkCyan;
            this.TotalMoneyHeader.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMoneyHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalMoneyHeader.Location = new System.Drawing.Point(707, 10);
            this.TotalMoneyHeader.Name = "TotalMoneyHeader";
            this.TotalMoneyHeader.Size = new System.Drawing.Size(162, 50);
            this.TotalMoneyHeader.TabIndex = 0;
            this.TotalMoneyHeader.Text = "Total Money";
            this.TotalMoneyHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuantityHeader
            // 
            this.QuantityHeader.BackColor = System.Drawing.Color.DarkCyan;
            this.QuantityHeader.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.QuantityHeader.Location = new System.Drawing.Point(528, 10);
            this.QuantityHeader.Name = "QuantityHeader";
            this.QuantityHeader.Size = new System.Drawing.Size(162, 50);
            this.QuantityHeader.TabIndex = 0;
            this.QuantityHeader.Text = "Quantity";
            this.QuantityHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceHeader
            // 
            this.PriceHeader.BackColor = System.Drawing.Color.DarkCyan;
            this.PriceHeader.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PriceHeader.Location = new System.Drawing.Point(360, 10);
            this.PriceHeader.Name = "PriceHeader";
            this.PriceHeader.Size = new System.Drawing.Size(162, 50);
            this.PriceHeader.TabIndex = 0;
            this.PriceHeader.Text = "Price";
            this.PriceHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameHeader
            // 
            this.NameHeader.BackColor = System.Drawing.Color.DarkCyan;
            this.NameHeader.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameHeader.Location = new System.Drawing.Point(192, 10);
            this.NameHeader.Name = "NameHeader";
            this.NameHeader.Size = new System.Drawing.Size(162, 50);
            this.NameHeader.TabIndex = 0;
            this.NameHeader.Text = "Name";
            this.NameHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "VyFood";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.tabControl.ResumeLayout(false);
            this.TabCart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList FoodImageList;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage TabMenu;
        private System.Windows.Forms.TabPage TabCart;
        private System.Windows.Forms.Label NameHeader;
        private System.Windows.Forms.Label TotalMoneyHeader;
        private System.Windows.Forms.Label QuantityHeader;
        private System.Windows.Forms.Label PriceHeader;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.Label TotalMoney;
    }
}

