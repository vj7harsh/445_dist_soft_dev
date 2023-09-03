namespace Doodle_Browser
{
    partial class Doodle
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
            this.searchBar = new System.Windows.Forms.TextBox();
            this.go = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.randomString = new System.Windows.Forms.TextBox();
            this.length = new System.Windows.Forms.TextBox();
            this.stringSize = new System.Windows.Forms.Label();
            this.getStockPrice = new System.Windows.Forms.Button();
            this.stockPrice = new System.Windows.Forms.TextBox();
            this.stockLabel = new System.Windows.Forms.Label();
            this.stockName = new System.Windows.Forms.TextBox();
            this.getRandomString = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchBar
            // 
            this.searchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBar.BackColor = System.Drawing.Color.AliceBlue;
            this.searchBar.Location = new System.Drawing.Point(12, 13);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(687, 20);
            this.searchBar.TabIndex = 0;
            this.searchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // go
            // 
            this.go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.go.BackColor = System.Drawing.Color.AliceBlue;
            this.go.Font = new System.Drawing.Font("Papyrus", 8F, System.Drawing.FontStyle.Bold);
            this.go.ForeColor = System.Drawing.Color.Black;
            this.go.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.go.Location = new System.Drawing.Point(702, 11);
            this.go.Margin = new System.Windows.Forms.Padding(0);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(45, 23);
            this.go.TabIndex = 1;
            this.go.Text = "Go";
            this.go.UseVisualStyleBackColor = false;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 39);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(735, 408);
            this.webBrowser1.TabIndex = 2;
            // 
            // randomString
            // 
            this.randomString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.randomString.Location = new System.Drawing.Point(175, 454);
            this.randomString.Name = "randomString";
            this.randomString.Size = new System.Drawing.Size(216, 20);
            this.randomString.TabIndex = 3;
            // 
            // length
            // 
            this.length.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.length.Location = new System.Drawing.Point(54, 454);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(29, 20);
            this.length.TabIndex = 5;
            // 
            // stringSize
            // 
            this.stringSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stringSize.AutoSize = true;
            this.stringSize.BackColor = System.Drawing.Color.CadetBlue;
            this.stringSize.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringSize.Location = new System.Drawing.Point(12, 456);
            this.stringSize.Name = "stringSize";
            this.stringSize.Size = new System.Drawing.Size(40, 14);
            this.stringSize.TabIndex = 6;
            this.stringSize.Text = "SIZE :";
            // 
            // getStockPrice
            // 
            this.getStockPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.getStockPrice.BackColor = System.Drawing.Color.AliceBlue;
            this.getStockPrice.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getStockPrice.Location = new System.Drawing.Point(495, 453);
            this.getStockPrice.Name = "getStockPrice";
            this.getStockPrice.Size = new System.Drawing.Size(75, 23);
            this.getStockPrice.TabIndex = 7;
            this.getStockPrice.Text = "Stock Price";
            this.getStockPrice.UseVisualStyleBackColor = false;
            this.getStockPrice.Click += new System.EventHandler(this.getStockPrice_Click);
            // 
            // stockPrice
            // 
            this.stockPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stockPrice.Location = new System.Drawing.Point(573, 455);
            this.stockPrice.Name = "stockPrice";
            this.stockPrice.Size = new System.Drawing.Size(174, 20);
            this.stockPrice.TabIndex = 8;
            // 
            // stockLabel
            // 
            this.stockLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stockLabel.AutoSize = true;
            this.stockLabel.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLabel.Location = new System.Drawing.Point(394, 456);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(54, 14);
            this.stockLabel.TabIndex = 9;
            this.stockLabel.Text = "STOCK :";
            // 
            // stockName
            // 
            this.stockName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stockName.Location = new System.Drawing.Point(449, 454);
            this.stockName.Name = "stockName";
            this.stockName.Size = new System.Drawing.Size(43, 20);
            this.stockName.TabIndex = 10;
            // 
            // getRandomString
            // 
            this.getRandomString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.getRandomString.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getRandomString.Location = new System.Drawing.Point(86, 452);
            this.getRandomString.Name = "getRandomString";
            this.getRandomString.Size = new System.Drawing.Size(85, 23);
            this.getRandomString.TabIndex = 11;
            this.getRandomString.Text = "Random String";
            this.getRandomString.UseVisualStyleBackColor = true;
            this.getRandomString.Click += new System.EventHandler(this.getRandomString_Click);
            // 
            // Doodle
            // 
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(759, 484);
            this.Controls.Add(this.getRandomString);
            this.Controls.Add(this.stockName);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.stockPrice);
            this.Controls.Add(this.getStockPrice);
            this.Controls.Add(this.stringSize);
            this.Controls.Add(this.length);
            this.Controls.Add(this.randomString);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.go);
            this.Controls.Add(this.searchBar);
            this.Name = "Doodle";
            this.Text = "Doodle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox randomString;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.Label stringSize;
        private System.Windows.Forms.Button getStockPrice;
        private System.Windows.Forms.TextBox stockPrice;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.TextBox stockName;
        private System.Windows.Forms.Button getRandomString;
    }
}

