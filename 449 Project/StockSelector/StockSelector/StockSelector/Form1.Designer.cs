namespace StockSelector
{
    partial class StockSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockSelector));
            this.selectorTab = new System.Windows.Forms.TabControl();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.homeDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sectorTab = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SectorComboBox = new System.Windows.Forms.ComboBox();
            this.sectorTextBox = new System.Windows.Forms.TextBox();
            this.volatilityTab = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.VolatilityComboBox = new System.Windows.Forms.ComboBox();
            this.sectorVolatility = new System.Windows.Forms.TextBox();
            this.liquidityTab = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.LiquidityComboBox = new System.Windows.Forms.ComboBox();
            this.liquidityTextBox = new System.Windows.Forms.TextBox();
            this.priceTab = new System.Windows.Forms.TabPage();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.PriceComboBox = new System.Windows.Forms.ComboBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.stockSelectionTab = new System.Windows.Forms.TabPage();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.StockSelectorButton = new System.Windows.Forms.Button();
            this.stockSelectionTextBox = new System.Windows.Forms.TextBox();
            this.selectorTab.SuspendLayout();
            this.homeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sectorTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.volatilityTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.liquidityTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.priceTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.stockSelectionTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectorTab
            // 
            this.selectorTab.Controls.Add(this.homeTab);
            this.selectorTab.Controls.Add(this.sectorTab);
            this.selectorTab.Controls.Add(this.volatilityTab);
            this.selectorTab.Controls.Add(this.liquidityTab);
            this.selectorTab.Controls.Add(this.priceTab);
            this.selectorTab.Controls.Add(this.stockSelectionTab);
            this.selectorTab.Location = new System.Drawing.Point(16, 15);
            this.selectorTab.Margin = new System.Windows.Forms.Padding(4);
            this.selectorTab.Name = "selectorTab";
            this.selectorTab.SelectedIndex = 0;
            this.selectorTab.Size = new System.Drawing.Size(887, 457);
            this.selectorTab.TabIndex = 0;
            // 
            // homeTab
            // 
            this.homeTab.Controls.Add(this.homeDescriptionTextBox);
            this.homeTab.Controls.Add(this.dateTimePicker1);
            this.homeTab.Controls.Add(this.pictureBox1);
            this.homeTab.Location = new System.Drawing.Point(4, 25);
            this.homeTab.Margin = new System.Windows.Forms.Padding(4);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(4);
            this.homeTab.Size = new System.Drawing.Size(879, 428);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "Homepage";
            this.homeTab.UseVisualStyleBackColor = true;
            // 
            // homeDescriptionTextBox
            // 
            this.homeDescriptionTextBox.Location = new System.Drawing.Point(513, 38);
            this.homeDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.homeDescriptionTextBox.Name = "homeDescriptionTextBox";
            this.homeDescriptionTextBox.Size = new System.Drawing.Size(292, 351);
            this.homeDescriptionTextBox.TabIndex = 3;
            this.homeDescriptionTextBox.Text = resources.GetString("homeDescriptionTextBox.Text");
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 318);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StockSelector.Properties.Resources.GrowthTimeline1;
            this.pictureBox1.Location = new System.Drawing.Point(53, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // sectorTab
            // 
            this.sectorTab.Controls.Add(this.pictureBox2);
            this.sectorTab.Controls.Add(this.SectorComboBox);
            this.sectorTab.Controls.Add(this.sectorTextBox);
            this.sectorTab.Location = new System.Drawing.Point(4, 25);
            this.sectorTab.Margin = new System.Windows.Forms.Padding(4);
            this.sectorTab.Name = "sectorTab";
            this.sectorTab.Padding = new System.Windows.Forms.Padding(4);
            this.sectorTab.Size = new System.Drawing.Size(879, 428);
            this.sectorTab.TabIndex = 1;
            this.sectorTab.Text = "Sector";
            this.sectorTab.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StockSelector.Properties.Resources.GrowthTimeline1;
            this.pictureBox2.Location = new System.Drawing.Point(257, 69);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(387, 270);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // SectorComboBox
            // 
            this.SectorComboBox.FormattingEnabled = true;
            this.SectorComboBox.Items.AddRange(new object[] {
            "Communication Services",
            "Consumer Discretionary",
            "Consumer Staples",
            "Energy",
            "Financials",
            "Health Care",
            "Industrials",
            "Information Technology",
            "Materials",
            "Real Estate",
            "Utilities"});
            this.SectorComboBox.Location = new System.Drawing.Point(257, 347);
            this.SectorComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.SectorComboBox.Name = "SectorComboBox";
            this.SectorComboBox.Size = new System.Drawing.Size(387, 24);
            this.SectorComboBox.TabIndex = 1;
            this.SectorComboBox.Text = "Sector";
            this.SectorComboBox.SelectedIndexChanged += new System.EventHandler(this.SectorComboBox_SelectedIndexChanged);
            // 
            // sectorTextBox
            // 
            this.sectorTextBox.Location = new System.Drawing.Point(257, 39);
            this.sectorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sectorTextBox.Name = "sectorTextBox";
            this.sectorTextBox.Size = new System.Drawing.Size(394, 22);
            this.sectorTextBox.TabIndex = 0;
            this.sectorTextBox.Text = "Please Select a Sector to Invest";
            this.sectorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // volatilityTab
            // 
            this.volatilityTab.Controls.Add(this.pictureBox3);
            this.volatilityTab.Controls.Add(this.VolatilityComboBox);
            this.volatilityTab.Controls.Add(this.sectorVolatility);
            this.volatilityTab.Location = new System.Drawing.Point(4, 25);
            this.volatilityTab.Margin = new System.Windows.Forms.Padding(4);
            this.volatilityTab.Name = "volatilityTab";
            this.volatilityTab.Size = new System.Drawing.Size(879, 428);
            this.volatilityTab.TabIndex = 2;
            this.volatilityTab.Text = "Volatility";
            this.volatilityTab.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::StockSelector.Properties.Resources.GrowthTimeline1;
            this.pictureBox3.Location = new System.Drawing.Point(257, 69);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(387, 270);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // VolatilityComboBox
            // 
            this.VolatilityComboBox.FormattingEnabled = true;
            this.VolatilityComboBox.Items.AddRange(new object[] {
            "Stable",
            "High Growth"});
            this.VolatilityComboBox.Location = new System.Drawing.Point(257, 347);
            this.VolatilityComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.VolatilityComboBox.Name = "VolatilityComboBox";
            this.VolatilityComboBox.Size = new System.Drawing.Size(387, 24);
            this.VolatilityComboBox.TabIndex = 4;
            this.VolatilityComboBox.Text = "Volatility";
            this.VolatilityComboBox.SelectedIndexChanged += new System.EventHandler(this.VolatilityComboBox_SelectedIndexChanged);
            // 
            // sectorVolatility
            // 
            this.sectorVolatility.Location = new System.Drawing.Point(257, 39);
            this.sectorVolatility.Margin = new System.Windows.Forms.Padding(4);
            this.sectorVolatility.Name = "sectorVolatility";
            this.sectorVolatility.Size = new System.Drawing.Size(387, 22);
            this.sectorVolatility.TabIndex = 3;
            this.sectorVolatility.Text = "Which level of volaitility?";
            this.sectorVolatility.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // liquidityTab
            // 
            this.liquidityTab.Controls.Add(this.pictureBox4);
            this.liquidityTab.Controls.Add(this.LiquidityComboBox);
            this.liquidityTab.Controls.Add(this.liquidityTextBox);
            this.liquidityTab.Location = new System.Drawing.Point(4, 25);
            this.liquidityTab.Margin = new System.Windows.Forms.Padding(4);
            this.liquidityTab.Name = "liquidityTab";
            this.liquidityTab.Size = new System.Drawing.Size(879, 428);
            this.liquidityTab.TabIndex = 3;
            this.liquidityTab.Text = "Liquidity";
            this.liquidityTab.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::StockSelector.Properties.Resources.GrowthTimeline1;
            this.pictureBox4.Location = new System.Drawing.Point(257, 69);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(387, 270);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // LiquidityComboBox
            // 
            this.LiquidityComboBox.FormattingEnabled = true;
            this.LiquidityComboBox.Items.AddRange(new object[] {
            "Low Trade Volume(More price control, harder to sell)",
            "High Trade Volume(Less price control, instant sales)"});
            this.LiquidityComboBox.Location = new System.Drawing.Point(257, 347);
            this.LiquidityComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.LiquidityComboBox.Name = "LiquidityComboBox";
            this.LiquidityComboBox.Size = new System.Drawing.Size(387, 24);
            this.LiquidityComboBox.TabIndex = 4;
            this.LiquidityComboBox.Text = "Liquidity";
            this.LiquidityComboBox.SelectedIndexChanged += new System.EventHandler(this.LiquidityComboBox_SelectedIndexChanged);
            // 
            // liquidityTextBox
            // 
            this.liquidityTextBox.Location = new System.Drawing.Point(257, 37);
            this.liquidityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.liquidityTextBox.Name = "liquidityTextBox";
            this.liquidityTextBox.Size = new System.Drawing.Size(387, 22);
            this.liquidityTextBox.TabIndex = 3;
            this.liquidityTextBox.Text = "What level of liquidty would you like?";
            this.liquidityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceTab
            // 
            this.priceTab.Controls.Add(this.pictureBox5);
            this.priceTab.Controls.Add(this.PriceComboBox);
            this.priceTab.Controls.Add(this.priceTextBox);
            this.priceTab.Location = new System.Drawing.Point(4, 25);
            this.priceTab.Margin = new System.Windows.Forms.Padding(4);
            this.priceTab.Name = "priceTab";
            this.priceTab.Size = new System.Drawing.Size(879, 428);
            this.priceTab.TabIndex = 4;
            this.priceTab.Text = "Price";
            this.priceTab.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::StockSelector.Properties.Resources.GrowthTimeline1;
            this.pictureBox5.Location = new System.Drawing.Point(257, 69);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(387, 270);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // PriceComboBox
            // 
            this.PriceComboBox.FormattingEnabled = true;
            this.PriceComboBox.Items.AddRange(new object[] {
            "< $50",
            "< $100",
            "< $200",
            "Any"});
            this.PriceComboBox.Location = new System.Drawing.Point(257, 347);
            this.PriceComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.PriceComboBox.Name = "PriceComboBox";
            this.PriceComboBox.Size = new System.Drawing.Size(387, 24);
            this.PriceComboBox.TabIndex = 4;
            this.PriceComboBox.Text = "Price";
            this.PriceComboBox.SelectedIndexChanged += new System.EventHandler(this.PriceComboBox_SelectedIndexChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(257, 37);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(387, 22);
            this.priceTextBox.TabIndex = 3;
            this.priceTextBox.Text = "What is the price per stock you are willing to pay?";
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stockSelectionTab
            // 
            this.stockSelectionTab.Controls.Add(this.resultsListBox);
            this.stockSelectionTab.Controls.Add(this.StockSelectorButton);
            this.stockSelectionTab.Controls.Add(this.stockSelectionTextBox);
            this.stockSelectionTab.Location = new System.Drawing.Point(4, 25);
            this.stockSelectionTab.Margin = new System.Windows.Forms.Padding(4);
            this.stockSelectionTab.Name = "stockSelectionTab";
            this.stockSelectionTab.Size = new System.Drawing.Size(879, 428);
            this.stockSelectionTab.TabIndex = 6;
            this.stockSelectionTab.Text = "Stock Selection";
            this.stockSelectionTab.UseVisualStyleBackColor = true;
            // 
            // resultsListBox
            // 
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.ItemHeight = 16;
            this.resultsListBox.Location = new System.Drawing.Point(309, 66);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(271, 292);
            this.resultsListBox.TabIndex = 7;
            // 
            // StockSelectorButton
            // 
            this.StockSelectorButton.Location = new System.Drawing.Point(309, 365);
            this.StockSelectorButton.Margin = new System.Windows.Forms.Padding(4);
            this.StockSelectorButton.Name = "StockSelectorButton";
            this.StockSelectorButton.Size = new System.Drawing.Size(271, 28);
            this.StockSelectorButton.TabIndex = 6;
            this.StockSelectorButton.Text = "Select My Stocks";
            this.StockSelectorButton.UseVisualStyleBackColor = true;
            this.StockSelectorButton.Click += new System.EventHandler(this.StockSelectorButton_Click);
            // 
            // stockSelectionTextBox
            // 
            this.stockSelectionTextBox.Location = new System.Drawing.Point(309, 37);
            this.stockSelectionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.stockSelectionTextBox.Name = "stockSelectionTextBox";
            this.stockSelectionTextBox.Size = new System.Drawing.Size(271, 22);
            this.stockSelectionTextBox.TabIndex = 3;
            this.stockSelectionTextBox.Text = "Preferences are loaded and ready select:";
            this.stockSelectionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StockSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 554);
            this.Controls.Add(this.selectorTab);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StockSelector";
            this.Text = "Stock Selector";
            this.selectorTab.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sectorTab.ResumeLayout(false);
            this.sectorTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.volatilityTab.ResumeLayout(false);
            this.volatilityTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.liquidityTab.ResumeLayout(false);
            this.liquidityTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.priceTab.ResumeLayout(false);
            this.priceTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.stockSelectionTab.ResumeLayout(false);
            this.stockSelectionTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl selectorTab;
        private System.Windows.Forms.TabPage homeTab;
        private System.Windows.Forms.TabPage sectorTab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage volatilityTab;
        private System.Windows.Forms.TabPage liquidityTab;
        private System.Windows.Forms.TabPage priceTab;
        private System.Windows.Forms.TabPage stockSelectionTab;
        private System.Windows.Forms.TextBox sectorTextBox;
        private System.Windows.Forms.RichTextBox homeDescriptionTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox SectorComboBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox VolatilityComboBox;
        private System.Windows.Forms.TextBox sectorVolatility;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox LiquidityComboBox;
        private System.Windows.Forms.TextBox liquidityTextBox;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ComboBox PriceComboBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button StockSelectorButton;
        private System.Windows.Forms.TextBox stockSelectionTextBox;
        private System.Windows.Forms.ListBox resultsListBox;
    }
}

