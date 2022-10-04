namespace KurgerBingShop
{
    partial class form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            this.imageborder = new System.Windows.Forms.Label();
            this.wherppoLabel = new System.Windows.Forms.Label();
            this.bingLabel = new System.Windows.Forms.Label();
            this.kriesLabel = new System.Windows.Forms.Label();
            this.wherppoInput = new System.Windows.Forms.TextBox();
            this.bingInput = new System.Windows.Forms.TextBox();
            this.kriesInput = new System.Windows.Forms.TextBox();
            this.totalsButton = new System.Windows.Forms.Button();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.subTotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.spacer = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeOutput = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.receiptTitleLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.logopic = new System.Windows.Forms.PictureBox();
            this.burgerBox1 = new System.Windows.Forms.PictureBox();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.burgerBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageborder
            // 
            this.imageborder.BackColor = System.Drawing.Color.SandyBrown;
            this.imageborder.Location = new System.Drawing.Point(-6, -4);
            this.imageborder.Name = "imageborder";
            this.imageborder.Size = new System.Drawing.Size(884, 125);
            this.imageborder.TabIndex = 1;
            // 
            // wherppoLabel
            // 
            this.wherppoLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wherppoLabel.ForeColor = System.Drawing.Color.Red;
            this.wherppoLabel.Location = new System.Drawing.Point(36, 188);
            this.wherppoLabel.Name = "wherppoLabel";
            this.wherppoLabel.Size = new System.Drawing.Size(241, 49);
            this.wherppoLabel.TabIndex = 3;
            this.wherppoLabel.Text = "$5 Wherppo";
            // 
            // bingLabel
            // 
            this.bingLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bingLabel.ForeColor = System.Drawing.Color.Red;
            this.bingLabel.Location = new System.Drawing.Point(36, 247);
            this.bingLabel.Name = "bingLabel";
            this.bingLabel.Size = new System.Drawing.Size(356, 49);
            this.bingLabel.TabIndex = 4;
            this.bingLabel.Text = "$1 Bing Chiling";
            // 
            // kriesLabel
            // 
            this.kriesLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kriesLabel.ForeColor = System.Drawing.Color.Red;
            this.kriesLabel.Location = new System.Drawing.Point(36, 305);
            this.kriesLabel.Name = "kriesLabel";
            this.kriesLabel.Size = new System.Drawing.Size(241, 49);
            this.kriesLabel.TabIndex = 5;
            this.kriesLabel.Text = "$2 Kries";
            // 
            // wherppoInput
            // 
            this.wherppoInput.Location = new System.Drawing.Point(329, 196);
            this.wherppoInput.Name = "wherppoInput";
            this.wherppoInput.Size = new System.Drawing.Size(87, 31);
            this.wherppoInput.TabIndex = 6;
            this.wherppoInput.Text = "0";
            // 
            // bingInput
            // 
            this.bingInput.Location = new System.Drawing.Point(329, 254);
            this.bingInput.Name = "bingInput";
            this.bingInput.Size = new System.Drawing.Size(87, 31);
            this.bingInput.TabIndex = 7;
            this.bingInput.Text = "0";
            // 
            // kriesInput
            // 
            this.kriesInput.Location = new System.Drawing.Point(329, 313);
            this.kriesInput.Name = "kriesInput";
            this.kriesInput.Size = new System.Drawing.Size(87, 31);
            this.kriesInput.TabIndex = 8;
            this.kriesInput.Text = "0";
            // 
            // totalsButton
            // 
            this.totalsButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.totalsButton.FlatAppearance.BorderSize = 2;
            this.totalsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.totalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalsButton.Font = new System.Drawing.Font("Georgia", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsButton.ForeColor = System.Drawing.Color.Red;
            this.totalsButton.Location = new System.Drawing.Point(43, 387);
            this.totalsButton.Name = "totalsButton";
            this.totalsButton.Size = new System.Drawing.Size(373, 58);
            this.totalsButton.TabIndex = 9;
            this.totalsButton.Text = "Calculate Totals";
            this.totalsButton.UseVisualStyleBackColor = false;
            this.totalsButton.Click += new System.EventHandler(this.totalsButton_Click);
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.Font = new System.Drawing.Font("Georgia", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.ForeColor = System.Drawing.Color.Red;
            this.subTotalLabel.Location = new System.Drawing.Point(36, 482);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(241, 49);
            this.subTotalLabel.TabIndex = 10;
            this.subTotalLabel.Text = "Sub Total";
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.Font = new System.Drawing.Font("Georgia", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalOutput.ForeColor = System.Drawing.Color.Red;
            this.subTotalOutput.Location = new System.Drawing.Point(214, 482);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.Size = new System.Drawing.Size(202, 49);
            this.subTotalOutput.TabIndex = 11;
            this.subTotalOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // taxOutput
            // 
            this.taxOutput.Font = new System.Drawing.Font("Georgia", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.ForeColor = System.Drawing.Color.Red;
            this.taxOutput.Location = new System.Drawing.Point(214, 531);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(202, 49);
            this.taxOutput.TabIndex = 13;
            this.taxOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // taxLabel
            // 
            this.taxLabel.Font = new System.Drawing.Font("Georgia", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.Color.Red;
            this.taxLabel.Location = new System.Drawing.Point(36, 531);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(241, 49);
            this.taxLabel.TabIndex = 12;
            this.taxLabel.Text = "Tax";
            // 
            // totalOutput
            // 
            this.totalOutput.Font = new System.Drawing.Font("Georgia", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.ForeColor = System.Drawing.Color.Red;
            this.totalOutput.Location = new System.Drawing.Point(214, 580);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(202, 49);
            this.totalOutput.TabIndex = 15;
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Georgia", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.Red;
            this.totalLabel.Location = new System.Drawing.Point(36, 580);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(241, 49);
            this.totalLabel.TabIndex = 14;
            this.totalLabel.Text = "Total";
            // 
            // spacer
            // 
            this.spacer.BackColor = System.Drawing.Color.SeaShell;
            this.spacer.Font = new System.Drawing.Font("NSimSun", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spacer.ForeColor = System.Drawing.Color.White;
            this.spacer.Location = new System.Drawing.Point(43, 621);
            this.spacer.Name = "spacer";
            this.spacer.Size = new System.Drawing.Size(373, 52);
            this.spacer.TabIndex = 16;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.Font = new System.Drawing.Font("Georgia", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.ForeColor = System.Drawing.Color.Red;
            this.tenderedLabel.Location = new System.Drawing.Point(36, 682);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(178, 49);
            this.tenderedLabel.TabIndex = 17;
            this.tenderedLabel.Text = "Tendered";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(329, 682);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(87, 31);
            this.tenderedInput.TabIndex = 18;
            this.tenderedInput.Text = "0";
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.changeButton.Enabled = false;
            this.changeButton.FlatAppearance.BorderSize = 2;
            this.changeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Georgia", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.Color.Red;
            this.changeButton.Location = new System.Drawing.Point(42, 752);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(373, 58);
            this.changeButton.TabIndex = 19;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeOutput
            // 
            this.changeOutput.Font = new System.Drawing.Font("Georgia", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.ForeColor = System.Drawing.Color.Red;
            this.changeOutput.Location = new System.Drawing.Point(214, 834);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(202, 49);
            this.changeOutput.TabIndex = 21;
            this.changeOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // changeLabel
            // 
            this.changeLabel.Font = new System.Drawing.Font("Georgia", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.Color.Red;
            this.changeLabel.Location = new System.Drawing.Point(36, 834);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(241, 49);
            this.changeLabel.TabIndex = 20;
            this.changeLabel.Text = "Change";
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.Color.SeaShell;
            this.receiptLabel.Font = new System.Drawing.Font("NSimSun", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(463, 250);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(370, 633);
            this.receiptLabel.TabIndex = 22;
            this.receiptLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.receiptLabel.Visible = false;
            // 
            // receiptButton
            // 
            this.receiptButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.receiptButton.Enabled = false;
            this.receiptButton.FlatAppearance.BorderSize = 2;
            this.receiptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.receiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptButton.Font = new System.Drawing.Font("Georgia", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.ForeColor = System.Drawing.Color.Red;
            this.receiptButton.Location = new System.Drawing.Point(42, 901);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(373, 58);
            this.receiptButton.TabIndex = 23;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = false;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.newOrderButton.Enabled = false;
            this.newOrderButton.FlatAppearance.BorderSize = 2;
            this.newOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderButton.Font = new System.Drawing.Font("Georgia", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.ForeColor = System.Drawing.Color.Red;
            this.newOrderButton.Location = new System.Drawing.Point(460, 901);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(373, 58);
            this.newOrderButton.TabIndex = 24;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // receiptTitleLabel
            // 
            this.receiptTitleLabel.BackColor = System.Drawing.Color.SeaShell;
            this.receiptTitleLabel.Font = new System.Drawing.Font("NSimSun", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptTitleLabel.Location = new System.Drawing.Point(463, 196);
            this.receiptTitleLabel.Name = "receiptTitleLabel";
            this.receiptTitleLabel.Size = new System.Drawing.Size(370, 54);
            this.receiptTitleLabel.TabIndex = 25;
            this.receiptTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.receiptTitleLabel.Visible = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.FlatAppearance.BorderSize = 2;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Georgia", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.SeaShell;
            this.exitButton.Location = new System.Drawing.Point(738, 28);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(111, 58);
            this.exitButton.TabIndex = 26;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // logopic
            // 
            this.logopic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logopic.Image = global::KurgerBingShop.Properties.Resources.kurgerbing_logo;
            this.logopic.InitialImage = global::KurgerBingShop.Properties.Resources.kurgerbing_logo;
            this.logopic.Location = new System.Drawing.Point(383, -4);
            this.logopic.Name = "logopic";
            this.logopic.Size = new System.Drawing.Size(134, 125);
            this.logopic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logopic.TabIndex = 2;
            this.logopic.TabStop = false;
            // 
            // burgerBox1
            // 
            this.burgerBox1.Image = global::KurgerBingShop.Properties.Resources.giphy;
            this.burgerBox1.Location = new System.Drawing.Point(-1, 127);
            this.burgerBox1.Name = "burgerBox1";
            this.burgerBox1.Size = new System.Drawing.Size(866, 861);
            this.burgerBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.burgerBox1.TabIndex = 27;
            this.burgerBox1.TabStop = false;
            this.burgerBox1.Visible = false;
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 2000;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(874, 1129);
            this.Controls.Add(this.burgerBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.receiptTitleLabel);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.spacer);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalOutput);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.totalsButton);
            this.Controls.Add(this.kriesInput);
            this.Controls.Add(this.bingInput);
            this.Controls.Add(this.wherppoInput);
            this.Controls.Add(this.kriesLabel);
            this.Controls.Add(this.bingLabel);
            this.Controls.Add(this.wherppoLabel);
            this.Controls.Add(this.logopic);
            this.Controls.Add(this.imageborder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 1200);
            this.MinimumSize = new System.Drawing.Size(900, 1148);
            this.Name = "form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kurger Bing";
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.burgerBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imageborder;
        private System.Windows.Forms.PictureBox logopic;
        private System.Windows.Forms.Label wherppoLabel;
        private System.Windows.Forms.Label bingLabel;
        private System.Windows.Forms.Label kriesLabel;
        private System.Windows.Forms.TextBox wherppoInput;
        private System.Windows.Forms.TextBox bingInput;
        private System.Windows.Forms.TextBox kriesInput;
        private System.Windows.Forms.Button totalsButton;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label subTotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label spacer;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label receiptTitleLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox burgerBox1;
        private System.Windows.Forms.Timer animationTimer;
    }
}

