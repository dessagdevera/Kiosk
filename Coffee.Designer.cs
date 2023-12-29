namespace kiosk
{
    partial class Coffee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Coffee));
            this.button1 = new System.Windows.Forms.Button();
            this.AMERICANO = new System.Windows.Forms.Button();
            this.CAPPU = new System.Windows.Forms.Button();
            this.HAZLATTE = new System.Windows.Forms.Button();
            this.CARAMEL = new System.Windows.Forms.Button();
            this.SPANISH = new System.Windows.Forms.Button();
            this.VANILATTE = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cart = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HOT = new System.Windows.Forms.CheckBox();
            this.COLD = new System.Windows.Forms.CheckBox();
            this.size1 = new System.Windows.Forms.CheckBox();
            this.size2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(32, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 124);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AMERICANO
            // 
            this.AMERICANO.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AMERICANO.Location = new System.Drawing.Point(4, 4);
            this.AMERICANO.Margin = new System.Windows.Forms.Padding(4);
            this.AMERICANO.Name = "AMERICANO";
            this.AMERICANO.Size = new System.Drawing.Size(197, 103);
            this.AMERICANO.TabIndex = 1;
            this.AMERICANO.Text = "Americano";
            this.AMERICANO.UseVisualStyleBackColor = true;
            this.AMERICANO.Click += new System.EventHandler(this.button2_Click);
            // 
            // CAPPU
            // 
            this.CAPPU.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAPPU.Location = new System.Drawing.Point(4, 115);
            this.CAPPU.Margin = new System.Windows.Forms.Padding(4);
            this.CAPPU.Name = "CAPPU";
            this.CAPPU.Size = new System.Drawing.Size(197, 103);
            this.CAPPU.TabIndex = 2;
            this.CAPPU.Text = "Cappucino";
            this.CAPPU.UseVisualStyleBackColor = true;
            this.CAPPU.Click += new System.EventHandler(this.button3_Click);
            // 
            // HAZLATTE
            // 
            this.HAZLATTE.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HAZLATTE.Location = new System.Drawing.Point(414, 4);
            this.HAZLATTE.Margin = new System.Windows.Forms.Padding(4);
            this.HAZLATTE.Name = "HAZLATTE";
            this.HAZLATTE.Size = new System.Drawing.Size(197, 103);
            this.HAZLATTE.TabIndex = 3;
            this.HAZLATTE.Text = "Hazelnut Latte";
            this.HAZLATTE.UseVisualStyleBackColor = true;
            this.HAZLATTE.Click += new System.EventHandler(this.button4_Click);
            // 
            // CARAMEL
            // 
            this.CARAMEL.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CARAMEL.Location = new System.Drawing.Point(209, 4);
            this.CARAMEL.Margin = new System.Windows.Forms.Padding(4);
            this.CARAMEL.Name = "CARAMEL";
            this.CARAMEL.Size = new System.Drawing.Size(197, 103);
            this.CARAMEL.TabIndex = 4;
            this.CARAMEL.Text = "Salted Caramel Latte";
            this.CARAMEL.UseVisualStyleBackColor = true;
            this.CARAMEL.Click += new System.EventHandler(this.button5_Click);
            // 
            // SPANISH
            // 
            this.SPANISH.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPANISH.Location = new System.Drawing.Point(209, 115);
            this.SPANISH.Margin = new System.Windows.Forms.Padding(4);
            this.SPANISH.Name = "SPANISH";
            this.SPANISH.Size = new System.Drawing.Size(197, 103);
            this.SPANISH.TabIndex = 5;
            this.SPANISH.Text = "Spanish Latte";
            this.SPANISH.UseVisualStyleBackColor = true;
            this.SPANISH.Click += new System.EventHandler(this.button6_Click);
            // 
            // VANILATTE
            // 
            this.VANILATTE.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VANILATTE.Location = new System.Drawing.Point(414, 115);
            this.VANILATTE.Margin = new System.Windows.Forms.Padding(4);
            this.VANILATTE.Name = "VANILATTE";
            this.VANILATTE.Size = new System.Drawing.Size(197, 103);
            this.VANILATTE.TabIndex = 6;
            this.VANILATTE.Text = "Vanilla Latte";
            this.VANILATTE.UseVisualStyleBackColor = true;
            this.VANILATTE.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1127, 667);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 49);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Cart
            // 
            this.Cart.BackColor = System.Drawing.Color.Black;
            this.Cart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cart.BackgroundImage")));
            this.Cart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cart.Location = new System.Drawing.Point(1068, 12);
            this.Cart.Margin = new System.Windows.Forms.Padding(4);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(75, 63);
            this.Cart.TabIndex = 48;
            this.Cart.UseVisualStyleBackColor = false;
            this.Cart.Click += new System.EventHandler(this.Cart_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.AMERICANO);
            this.flowLayoutPanel1.Controls.Add(this.CARAMEL);
            this.flowLayoutPanel1.Controls.Add(this.HAZLATTE);
            this.flowLayoutPanel1.Controls.Add(this.CAPPU);
            this.flowLayoutPanel1.Controls.Add(this.SPANISH);
            this.flowLayoutPanel1.Controls.Add(this.VANILATTE);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(116, 252);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(623, 386);
            this.flowLayoutPanel1.TabIndex = 50;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(792, 588);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(227, 50);
            this.button8.TabIndex = 51;
            this.button8.Text = "ADD TO CART";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(788, 546);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 53;
            // 
            // HOT
            // 
            this.HOT.AutoSize = true;
            this.HOT.BackColor = System.Drawing.Color.Transparent;
            this.HOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOT.ForeColor = System.Drawing.Color.White;
            this.HOT.Location = new System.Drawing.Point(807, 256);
            this.HOT.Margin = new System.Windows.Forms.Padding(4);
            this.HOT.Name = "HOT";
            this.HOT.Size = new System.Drawing.Size(94, 35);
            this.HOT.TabIndex = 54;
            this.HOT.Text = "HOT";
            this.HOT.UseVisualStyleBackColor = false;
            this.HOT.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // COLD
            // 
            this.COLD.AutoSize = true;
            this.COLD.BackColor = System.Drawing.Color.Transparent;
            this.COLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COLD.ForeColor = System.Drawing.Color.White;
            this.COLD.Location = new System.Drawing.Point(807, 299);
            this.COLD.Margin = new System.Windows.Forms.Padding(4);
            this.COLD.Name = "COLD";
            this.COLD.Size = new System.Drawing.Size(112, 35);
            this.COLD.TabIndex = 55;
            this.COLD.Text = "COLD";
            this.COLD.UseVisualStyleBackColor = false;
            this.COLD.CheckedChanged += new System.EventHandler(this.COLD_CheckedChanged);
            // 
            // size1
            // 
            this.size1.AutoSize = true;
            this.size1.BackColor = System.Drawing.Color.Transparent;
            this.size1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size1.ForeColor = System.Drawing.Color.White;
            this.size1.Location = new System.Drawing.Point(807, 342);
            this.size1.Margin = new System.Windows.Forms.Padding(4);
            this.size1.Name = "size1";
            this.size1.Size = new System.Drawing.Size(182, 35);
            this.size1.TabIndex = 56;
            this.size1.Text = "16oz ( ₱ 50)";
            this.size1.UseVisualStyleBackColor = false;
            this.size1.CheckedChanged += new System.EventHandler(this.size1_CheckedChanged);
            // 
            // size2
            // 
            this.size2.AutoSize = true;
            this.size2.BackColor = System.Drawing.Color.Transparent;
            this.size2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size2.ForeColor = System.Drawing.Color.White;
            this.size2.Location = new System.Drawing.Point(807, 385);
            this.size2.Margin = new System.Windows.Forms.Padding(4);
            this.size2.Name = "size2";
            this.size2.Size = new System.Drawing.Size(182, 35);
            this.size2.TabIndex = 57;
            this.size2.Text = "22oz ( ₱ 70)";
            this.size2.UseVisualStyleBackColor = false;
            this.size2.CheckedChanged += new System.EventHandler(this.size2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(792, 230);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(227, 214);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            // 
            // Coffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1193, 729);
            this.Controls.Add(this.size2);
            this.Controls.Add(this.size1);
            this.Controls.Add(this.COLD);
            this.Controls.Add(this.HOT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Cart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Coffee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee";
            this.Activated += new System.EventHandler(this.Coffee_Activated);
            this.Load += new System.EventHandler(this.Coffee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AMERICANO;
        private System.Windows.Forms.Button CAPPU;
        private System.Windows.Forms.Button HAZLATTE;
        private System.Windows.Forms.Button CARAMEL;
        private System.Windows.Forms.Button SPANISH;
        private System.Windows.Forms.Button VANILATTE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Cart;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox HOT;
        private System.Windows.Forms.CheckBox COLD;
        private System.Windows.Forms.CheckBox size1;
        private System.Windows.Forms.CheckBox size2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}