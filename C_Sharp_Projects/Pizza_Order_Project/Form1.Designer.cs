namespace Pizza_Order_Project
{
    partial class frm_MakePizza
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.rb_Small = new System.Windows.Forms.RadioButton();
            this.rb_Larg = new System.Windows.Forms.RadioButton();
            this.rb_Meduim = new System.Windows.Forms.RadioButton();
            this.gb_Size = new System.Windows.Forms.GroupBox();
            this.gb_Crust = new System.Windows.Forms.GroupBox();
            this.rb_Thin = new System.Windows.Forms.RadioButton();
            this.rb_Think = new System.Windows.Forms.RadioButton();
            this.gb_Toppings = new System.Windows.Forms.GroupBox();
            this.chk_GreenPeppers = new System.Windows.Forms.CheckBox();
            this.chk_Oilves = new System.Windows.Forms.CheckBox();
            this.chk_Onion = new System.Windows.Forms.CheckBox();
            this.chk_Tomatoes = new System.Windows.Forms.CheckBox();
            this.chk_Mushrooms = new System.Windows.Forms.CheckBox();
            this.chk_ExtraChees = new System.Windows.Forms.CheckBox();
            this.gb_WhereToEat = new System.Windows.Forms.GroupBox();
            this.rb_EatIn = new System.Windows.Forms.RadioButton();
            this.rb_TakeAway = new System.Windows.Forms.RadioButton();
            this.btn_Order = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.lbl_Size = new System.Windows.Forms.Label();
            this.lbl_Toppings = new System.Windows.Forms.Label();
            this.lbl_CrustType = new System.Windows.Forms.Label();
            this.lbl_WhereToEat = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_OrderS_Size = new System.Windows.Forms.Label();
            this.lbl_OrderS_CrustType = new System.Windows.Forms.Label();
            this.lbl_OrderS_WhereToEat = new System.Windows.Forms.Label();
            this.lbl_OrderS_Price = new System.Windows.Forms.Label();
            this.lbl_OrderS_Toppings = new System.Windows.Forms.Label();
            this.gb_OrderSummary = new System.Windows.Forms.GroupBox();
            this.gb_Size.SuspendLayout();
            this.gb_Crust.SuspendLayout();
            this.gb_Toppings.SuspendLayout();
            this.gb_WhereToEat.SuspendLayout();
            this.gb_OrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.White;
            this.lbl_Title.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Title.Location = new System.Drawing.Point(315, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(389, 50);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Make Your Pizza";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rb_Small
            // 
            this.rb_Small.AutoSize = true;
            this.rb_Small.Checked = true;
            this.rb_Small.Location = new System.Drawing.Point(24, 38);
            this.rb_Small.Name = "rb_Small";
            this.rb_Small.Size = new System.Drawing.Size(71, 25);
            this.rb_Small.TabIndex = 1;
            this.rb_Small.TabStop = true;
            this.rb_Small.Tag = "40";
            this.rb_Small.Text = "Small";
            this.rb_Small.UseVisualStyleBackColor = true;
            this.rb_Small.CheckedChanged += new System.EventHandler(this.rb_Small_CheckedChanged);
            // 
            // rb_Larg
            // 
            this.rb_Larg.AutoSize = true;
            this.rb_Larg.Location = new System.Drawing.Point(24, 138);
            this.rb_Larg.Name = "rb_Larg";
            this.rb_Larg.Size = new System.Drawing.Size(63, 25);
            this.rb_Larg.TabIndex = 2;
            this.rb_Larg.Tag = "60";
            this.rb_Larg.Text = "Larg";
            this.rb_Larg.UseVisualStyleBackColor = true;
            this.rb_Larg.CheckedChanged += new System.EventHandler(this.rb_Larg_CheckedChanged);
            // 
            // rb_Meduim
            // 
            this.rb_Meduim.AutoSize = true;
            this.rb_Meduim.Location = new System.Drawing.Point(24, 88);
            this.rb_Meduim.Name = "rb_Meduim";
            this.rb_Meduim.Size = new System.Drawing.Size(89, 25);
            this.rb_Meduim.TabIndex = 3;
            this.rb_Meduim.Tag = "50";
            this.rb_Meduim.Text = "Meduim";
            this.rb_Meduim.UseVisualStyleBackColor = true;
            this.rb_Meduim.CheckedChanged += new System.EventHandler(this.rb_Meduim_CheckedChanged);
            // 
            // gb_Size
            // 
            this.gb_Size.Controls.Add(this.rb_Small);
            this.gb_Size.Controls.Add(this.rb_Meduim);
            this.gb_Size.Controls.Add(this.rb_Larg);
            this.gb_Size.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Size.Location = new System.Drawing.Point(12, 86);
            this.gb_Size.Name = "gb_Size";
            this.gb_Size.Size = new System.Drawing.Size(171, 191);
            this.gb_Size.TabIndex = 4;
            this.gb_Size.TabStop = false;
            this.gb_Size.Text = "Size";
            // 
            // gb_Crust
            // 
            this.gb_Crust.Controls.Add(this.rb_Thin);
            this.gb_Crust.Controls.Add(this.rb_Think);
            this.gb_Crust.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Crust.Location = new System.Drawing.Point(12, 304);
            this.gb_Crust.Name = "gb_Crust";
            this.gb_Crust.Size = new System.Drawing.Size(171, 123);
            this.gb_Crust.TabIndex = 5;
            this.gb_Crust.TabStop = false;
            this.gb_Crust.Text = "Crust Type";
            // 
            // rb_Thin
            // 
            this.rb_Thin.AutoSize = true;
            this.rb_Thin.Checked = true;
            this.rb_Thin.Location = new System.Drawing.Point(24, 38);
            this.rb_Thin.Name = "rb_Thin";
            this.rb_Thin.Size = new System.Drawing.Size(107, 25);
            this.rb_Thin.TabIndex = 1;
            this.rb_Thin.TabStop = true;
            this.rb_Thin.Tag = "0";
            this.rb_Thin.Text = "Thin Crust";
            this.rb_Thin.UseVisualStyleBackColor = true;
            this.rb_Thin.CheckedChanged += new System.EventHandler(this.rb_Thin_CheckedChanged);
            // 
            // rb_Think
            // 
            this.rb_Think.AutoSize = true;
            this.rb_Think.Location = new System.Drawing.Point(24, 77);
            this.rb_Think.Name = "rb_Think";
            this.rb_Think.Size = new System.Drawing.Size(115, 25);
            this.rb_Think.TabIndex = 3;
            this.rb_Think.Tag = "10";
            this.rb_Think.Text = "Think Crust";
            this.rb_Think.UseVisualStyleBackColor = true;
            this.rb_Think.CheckedChanged += new System.EventHandler(this.rb_Think_CheckedChanged);
            // 
            // gb_Toppings
            // 
            this.gb_Toppings.Controls.Add(this.chk_GreenPeppers);
            this.gb_Toppings.Controls.Add(this.chk_Oilves);
            this.gb_Toppings.Controls.Add(this.chk_Onion);
            this.gb_Toppings.Controls.Add(this.chk_Tomatoes);
            this.gb_Toppings.Controls.Add(this.chk_Mushrooms);
            this.gb_Toppings.Controls.Add(this.chk_ExtraChees);
            this.gb_Toppings.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Toppings.Location = new System.Drawing.Point(254, 86);
            this.gb_Toppings.Name = "gb_Toppings";
            this.gb_Toppings.Size = new System.Drawing.Size(339, 191);
            this.gb_Toppings.TabIndex = 5;
            this.gb_Toppings.TabStop = false;
            this.gb_Toppings.Text = "Toppings";
            // 
            // chk_GreenPeppers
            // 
            this.chk_GreenPeppers.AutoSize = true;
            this.chk_GreenPeppers.Location = new System.Drawing.Point(190, 137);
            this.chk_GreenPeppers.Name = "chk_GreenPeppers";
            this.chk_GreenPeppers.Size = new System.Drawing.Size(140, 25);
            this.chk_GreenPeppers.TabIndex = 5;
            this.chk_GreenPeppers.Tag = "5";
            this.chk_GreenPeppers.Text = "Green Peppers";
            this.chk_GreenPeppers.UseVisualStyleBackColor = true;
            this.chk_GreenPeppers.CheckedChanged += new System.EventHandler(this.chk_GreenPeppers_CheckedChanged);
            // 
            // chk_Oilves
            // 
            this.chk_Oilves.AutoSize = true;
            this.chk_Oilves.Location = new System.Drawing.Point(190, 90);
            this.chk_Oilves.Name = "chk_Oilves";
            this.chk_Oilves.Size = new System.Drawing.Size(77, 25);
            this.chk_Oilves.TabIndex = 4;
            this.chk_Oilves.Tag = "5";
            this.chk_Oilves.Text = "Oilves";
            this.chk_Oilves.UseVisualStyleBackColor = true;
            this.chk_Oilves.CheckedChanged += new System.EventHandler(this.chk_Oilves_CheckedChanged);
            // 
            // chk_Onion
            // 
            this.chk_Onion.AutoSize = true;
            this.chk_Onion.Location = new System.Drawing.Point(190, 43);
            this.chk_Onion.Name = "chk_Onion";
            this.chk_Onion.Size = new System.Drawing.Size(75, 25);
            this.chk_Onion.TabIndex = 3;
            this.chk_Onion.Tag = "5";
            this.chk_Onion.Text = "Onion";
            this.chk_Onion.UseVisualStyleBackColor = true;
            this.chk_Onion.CheckedChanged += new System.EventHandler(this.chk_Onion_CheckedChanged);
            // 
            // chk_Tomatoes
            // 
            this.chk_Tomatoes.AutoSize = true;
            this.chk_Tomatoes.Location = new System.Drawing.Point(16, 138);
            this.chk_Tomatoes.Name = "chk_Tomatoes";
            this.chk_Tomatoes.Size = new System.Drawing.Size(106, 25);
            this.chk_Tomatoes.TabIndex = 2;
            this.chk_Tomatoes.Tag = "5";
            this.chk_Tomatoes.Text = "Tomatoes";
            this.chk_Tomatoes.UseVisualStyleBackColor = true;
            this.chk_Tomatoes.CheckedChanged += new System.EventHandler(this.chk_Tomatoes_CheckedChanged);
            // 
            // chk_Mushrooms
            // 
            this.chk_Mushrooms.AutoSize = true;
            this.chk_Mushrooms.Location = new System.Drawing.Point(16, 88);
            this.chk_Mushrooms.Name = "chk_Mushrooms";
            this.chk_Mushrooms.Size = new System.Drawing.Size(117, 25);
            this.chk_Mushrooms.TabIndex = 1;
            this.chk_Mushrooms.Tag = "5";
            this.chk_Mushrooms.Text = "Mushrooms";
            this.chk_Mushrooms.UseVisualStyleBackColor = true;
            this.chk_Mushrooms.CheckedChanged += new System.EventHandler(this.chk_Mushrooms_CheckedChanged);
            // 
            // chk_ExtraChees
            // 
            this.chk_ExtraChees.AutoSize = true;
            this.chk_ExtraChees.Location = new System.Drawing.Point(16, 38);
            this.chk_ExtraChees.Name = "chk_ExtraChees";
            this.chk_ExtraChees.Size = new System.Drawing.Size(121, 25);
            this.chk_ExtraChees.TabIndex = 0;
            this.chk_ExtraChees.Tag = "5";
            this.chk_ExtraChees.Text = "Extra Chees";
            this.chk_ExtraChees.UseVisualStyleBackColor = true;
            this.chk_ExtraChees.CheckedChanged += new System.EventHandler(this.chk_ExtraChees_CheckedChanged);
            // 
            // gb_WhereToEat
            // 
            this.gb_WhereToEat.Controls.Add(this.rb_EatIn);
            this.gb_WhereToEat.Controls.Add(this.rb_TakeAway);
            this.gb_WhereToEat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_WhereToEat.Location = new System.Drawing.Point(254, 304);
            this.gb_WhereToEat.Name = "gb_WhereToEat";
            this.gb_WhereToEat.Size = new System.Drawing.Size(339, 123);
            this.gb_WhereToEat.TabIndex = 6;
            this.gb_WhereToEat.TabStop = false;
            this.gb_WhereToEat.Text = "Where To Eat";
            // 
            // rb_EatIn
            // 
            this.rb_EatIn.AutoSize = true;
            this.rb_EatIn.Checked = true;
            this.rb_EatIn.Location = new System.Drawing.Point(16, 57);
            this.rb_EatIn.Name = "rb_EatIn";
            this.rb_EatIn.Size = new System.Drawing.Size(74, 25);
            this.rb_EatIn.TabIndex = 1;
            this.rb_EatIn.TabStop = true;
            this.rb_EatIn.Text = "Eat in";
            this.rb_EatIn.UseVisualStyleBackColor = true;
            this.rb_EatIn.CheckedChanged += new System.EventHandler(this.rb_EatIn_CheckedChanged);
            // 
            // rb_TakeAway
            // 
            this.rb_TakeAway.AutoSize = true;
            this.rb_TakeAway.Location = new System.Drawing.Point(190, 57);
            this.rb_TakeAway.Name = "rb_TakeAway";
            this.rb_TakeAway.Size = new System.Drawing.Size(113, 25);
            this.rb_TakeAway.TabIndex = 3;
            this.rb_TakeAway.Text = "Take Away";
            this.rb_TakeAway.UseVisualStyleBackColor = true;
            this.rb_TakeAway.CheckedChanged += new System.EventHandler(this.rb_TakeAway_CheckedChanged);
            // 
            // btn_Order
            // 
            this.btn_Order.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Order.Location = new System.Drawing.Point(352, 454);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(114, 42);
            this.btn_Order.TabIndex = 7;
            this.btn_Order.Text = "Order";
            this.btn_Order.UseVisualStyleBackColor = true;
            this.btn_Order.Click += new System.EventHandler(this.MakeOrder);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Enabled = false;
            this.btn_Reset.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(526, 454);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(114, 42);
            this.btn_Reset.TabIndex = 8;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.ResetOrder);
            // 
            // lbl_Size
            // 
            this.lbl_Size.AutoSize = true;
            this.lbl_Size.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Size.Location = new System.Drawing.Point(15, 49);
            this.lbl_Size.Name = "lbl_Size";
            this.lbl_Size.Size = new System.Drawing.Size(51, 21);
            this.lbl_Size.TabIndex = 0;
            this.lbl_Size.Text = "Size:";
            // 
            // lbl_Toppings
            // 
            this.lbl_Toppings.AutoSize = true;
            this.lbl_Toppings.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Toppings.Location = new System.Drawing.Point(15, 100);
            this.lbl_Toppings.Name = "lbl_Toppings";
            this.lbl_Toppings.Size = new System.Drawing.Size(95, 21);
            this.lbl_Toppings.TabIndex = 1;
            this.lbl_Toppings.Text = "Toppings:";
            // 
            // lbl_CrustType
            // 
            this.lbl_CrustType.AutoSize = true;
            this.lbl_CrustType.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CrustType.Location = new System.Drawing.Point(15, 184);
            this.lbl_CrustType.Name = "lbl_CrustType";
            this.lbl_CrustType.Size = new System.Drawing.Size(107, 21);
            this.lbl_CrustType.TabIndex = 2;
            this.lbl_CrustType.Text = "Crust Type:";
            // 
            // lbl_WhereToEat
            // 
            this.lbl_WhereToEat.AutoSize = true;
            this.lbl_WhereToEat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WhereToEat.Location = new System.Drawing.Point(15, 229);
            this.lbl_WhereToEat.Name = "lbl_WhereToEat";
            this.lbl_WhereToEat.Size = new System.Drawing.Size(129, 21);
            this.lbl_WhereToEat.TabIndex = 3;
            this.lbl_WhereToEat.Text = "Where To Eat:";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(15, 274);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(58, 21);
            this.lbl_Price.TabIndex = 4;
            this.lbl_Price.Text = "Price:";
            // 
            // lbl_OrderS_Size
            // 
            this.lbl_OrderS_Size.AutoSize = true;
            this.lbl_OrderS_Size.Location = new System.Drawing.Point(60, 49);
            this.lbl_OrderS_Size.Name = "lbl_OrderS_Size";
            this.lbl_OrderS_Size.Size = new System.Drawing.Size(50, 21);
            this.lbl_OrderS_Size.TabIndex = 5;
            this.lbl_OrderS_Size.Text = "Small";
            // 
            // lbl_OrderS_CrustType
            // 
            this.lbl_OrderS_CrustType.AutoSize = true;
            this.lbl_OrderS_CrustType.Location = new System.Drawing.Point(128, 184);
            this.lbl_OrderS_CrustType.Name = "lbl_OrderS_CrustType";
            this.lbl_OrderS_CrustType.Size = new System.Drawing.Size(86, 21);
            this.lbl_OrderS_CrustType.TabIndex = 7;
            this.lbl_OrderS_CrustType.Text = "Thin Crust";
            // 
            // lbl_OrderS_WhereToEat
            // 
            this.lbl_OrderS_WhereToEat.AutoSize = true;
            this.lbl_OrderS_WhereToEat.Location = new System.Drawing.Point(150, 229);
            this.lbl_OrderS_WhereToEat.Name = "lbl_OrderS_WhereToEat";
            this.lbl_OrderS_WhereToEat.Size = new System.Drawing.Size(53, 21);
            this.lbl_OrderS_WhereToEat.TabIndex = 8;
            this.lbl_OrderS_WhereToEat.Text = "Eat in";
            // 
            // lbl_OrderS_Price
            // 
            this.lbl_OrderS_Price.AutoSize = true;
            this.lbl_OrderS_Price.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderS_Price.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_OrderS_Price.Location = new System.Drawing.Point(98, 275);
            this.lbl_OrderS_Price.Name = "lbl_OrderS_Price";
            this.lbl_OrderS_Price.Size = new System.Drawing.Size(87, 50);
            this.lbl_OrderS_Price.TabIndex = 9;
            this.lbl_OrderS_Price.Text = "$40";
            // 
            // lbl_OrderS_Toppings
            // 
            this.lbl_OrderS_Toppings.Location = new System.Drawing.Point(15, 137);
            this.lbl_OrderS_Toppings.Name = "lbl_OrderS_Toppings";
            this.lbl_OrderS_Toppings.Size = new System.Drawing.Size(325, 47);
            this.lbl_OrderS_Toppings.TabIndex = 6;
            this.lbl_OrderS_Toppings.Text = "No Toppings";
            // 
            // gb_OrderSummary
            // 
            this.gb_OrderSummary.Controls.Add(this.lbl_OrderS_Price);
            this.gb_OrderSummary.Controls.Add(this.lbl_OrderS_WhereToEat);
            this.gb_OrderSummary.Controls.Add(this.lbl_OrderS_CrustType);
            this.gb_OrderSummary.Controls.Add(this.lbl_OrderS_Toppings);
            this.gb_OrderSummary.Controls.Add(this.lbl_OrderS_Size);
            this.gb_OrderSummary.Controls.Add(this.lbl_Price);
            this.gb_OrderSummary.Controls.Add(this.lbl_WhereToEat);
            this.gb_OrderSummary.Controls.Add(this.lbl_CrustType);
            this.gb_OrderSummary.Controls.Add(this.lbl_Toppings);
            this.gb_OrderSummary.Controls.Add(this.lbl_Size);
            this.gb_OrderSummary.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_OrderSummary.Location = new System.Drawing.Point(664, 86);
            this.gb_OrderSummary.Name = "gb_OrderSummary";
            this.gb_OrderSummary.Size = new System.Drawing.Size(346, 341);
            this.gb_OrderSummary.TabIndex = 5;
            this.gb_OrderSummary.TabStop = false;
            this.gb_OrderSummary.Text = "Order Summary";
            // 
            // frm_MakePizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 520);
            this.Controls.Add(this.gb_OrderSummary);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Order);
            this.Controls.Add(this.gb_WhereToEat);
            this.Controls.Add(this.gb_Toppings);
            this.Controls.Add(this.gb_Crust);
            this.Controls.Add(this.gb_Size);
            this.Controls.Add(this.lbl_Title);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frm_MakePizza";
            this.Text = "Order Pizza";
            this.gb_Size.ResumeLayout(false);
            this.gb_Size.PerformLayout();
            this.gb_Crust.ResumeLayout(false);
            this.gb_Crust.PerformLayout();
            this.gb_Toppings.ResumeLayout(false);
            this.gb_Toppings.PerformLayout();
            this.gb_WhereToEat.ResumeLayout(false);
            this.gb_WhereToEat.PerformLayout();
            this.gb_OrderSummary.ResumeLayout(false);
            this.gb_OrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.RadioButton rb_Small;
        private System.Windows.Forms.RadioButton rb_Larg;
        private System.Windows.Forms.RadioButton rb_Meduim;
        private System.Windows.Forms.GroupBox gb_Size;
        private System.Windows.Forms.GroupBox gb_Crust;
        private System.Windows.Forms.RadioButton rb_Thin;
        private System.Windows.Forms.RadioButton rb_Think;
        private System.Windows.Forms.GroupBox gb_Toppings;
        private System.Windows.Forms.CheckBox chk_GreenPeppers;
        private System.Windows.Forms.CheckBox chk_Oilves;
        private System.Windows.Forms.CheckBox chk_Onion;
        private System.Windows.Forms.CheckBox chk_Tomatoes;
        private System.Windows.Forms.CheckBox chk_Mushrooms;
        private System.Windows.Forms.CheckBox chk_ExtraChees;
        private System.Windows.Forms.GroupBox gb_WhereToEat;
        private System.Windows.Forms.RadioButton rb_EatIn;
        private System.Windows.Forms.RadioButton rb_TakeAway;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label lbl_Size;
        private System.Windows.Forms.Label lbl_Toppings;
        private System.Windows.Forms.Label lbl_CrustType;
        private System.Windows.Forms.Label lbl_WhereToEat;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_OrderS_Size;
        private System.Windows.Forms.Label lbl_OrderS_CrustType;
        private System.Windows.Forms.Label lbl_OrderS_WhereToEat;
        private System.Windows.Forms.Label lbl_OrderS_Price;
        private System.Windows.Forms.Label lbl_OrderS_Toppings;
        private System.Windows.Forms.GroupBox gb_OrderSummary;
    }
}

