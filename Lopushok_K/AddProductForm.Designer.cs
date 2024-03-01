namespace Lopushok_K
{
    partial class AddProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && ( components != null ))
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
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbArticle = new System.Windows.Forms.TextBox();
            this.tbMinCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.TextBox();
            this.Snum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbProductType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbProductName
            // 
            this.tbProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.tbProductName.Font = new System.Drawing.Font("Gabriola", 12F);
            this.tbProductName.Location = new System.Drawing.Point(330, 95);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(200, 35);
            this.tbProductName.TabIndex = 0;
            this.tbProductName.TextChanged += new System.EventHandler(this.tbProductName_TextChanged);
            // 
            // tbArticle
            // 
            this.tbArticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.tbArticle.Font = new System.Drawing.Font("Gabriola", 12F);
            this.tbArticle.Location = new System.Drawing.Point(330, 179);
            this.tbArticle.Name = "tbArticle";
            this.tbArticle.Size = new System.Drawing.Size(200, 35);
            this.tbArticle.TabIndex = 2;
            this.tbArticle.TextChanged += new System.EventHandler(this.tbArticle_TextChanged);
            // 
            // tbMinCost
            // 
            this.tbMinCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.tbMinCost.Font = new System.Drawing.Font("Gabriola", 12F);
            this.tbMinCost.Location = new System.Drawing.Point(330, 220);
            this.tbMinCost.Name = "tbMinCost";
            this.tbMinCost.Size = new System.Drawing.Size(200, 35);
            this.tbMinCost.TabIndex = 3;
            this.tbMinCost.TextChanged += new System.EventHandler(this.tbMinCost_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 12F);
            this.label1.Location = new System.Drawing.Point(206, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название продукта";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gabriola", 12F);
            this.label2.Location = new System.Drawing.Point(206, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Тип продукта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gabriola", 12F);
            this.label3.Location = new System.Drawing.Point(206, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Артикул";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gabriola", 12F);
            this.label4.Location = new System.Drawing.Point(206, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Мин. стоимость";
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(118)))));
            this.buttonAddProduct.Font = new System.Drawing.Font("Gabriola", 12F);
            this.buttonAddProduct.Location = new System.Drawing.Point(211, 379);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(150, 43);
            this.buttonAddProduct.TabIndex = 9;
            this.buttonAddProduct.Text = "Добавить продукт";
            this.buttonAddProduct.UseVisualStyleBackColor = false;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // Equal
            // 
            this.Equal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.Equal.Font = new System.Drawing.Font("Gabriola", 12F);
            this.Equal.Location = new System.Drawing.Point(330, 261);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(200, 35);
            this.Equal.TabIndex = 11;
            this.Equal.TextChanged += new System.EventHandler(this.Equal_TextChanged);
            // 
            // Snum
            // 
            this.Snum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.Snum.Font = new System.Drawing.Font("Gabriola", 12F);
            this.Snum.Location = new System.Drawing.Point(330, 302);
            this.Snum.Name = "Snum";
            this.Snum.Size = new System.Drawing.Size(200, 35);
            this.Snum.TabIndex = 12;
            this.Snum.TextChanged += new System.EventHandler(this.Snum_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gabriola", 12F);
            this.label5.Location = new System.Drawing.Point(206, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Количество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gabriola", 12F);
            this.label6.Location = new System.Drawing.Point(206, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Номер";
            // 
            // tbProductType
            // 
            this.tbProductType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.tbProductType.Font = new System.Drawing.Font("Gabriola", 12F);
            this.tbProductType.FormattingEnabled = true;
            this.tbProductType.Items.AddRange(new object[] {
            "Один слой",
            "Два слоя",
            "Три слоя",
            "Детская",
            "Супер мягкая"});
            this.tbProductType.Location = new System.Drawing.Point(330, 136);
            this.tbProductType.Name = "tbProductType";
            this.tbProductType.Size = new System.Drawing.Size(200, 37);
            this.tbProductType.TabIndex = 15;
            this.tbProductType.SelectedIndexChanged += new System.EventHandler(this.tbProductType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Gabriola", 12F);
            this.label7.Location = new System.Drawing.Point(31, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 62);
            this.label7.TabIndex = 16;
            this.label7.Text = "Нажмите, чтобы добавить изображение";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(118)))));
            this.pictureBox1.Location = new System.Drawing.Point(36, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 112);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 59);
            this.label8.TabIndex = 15;
            this.label8.Text = "Лопушок";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(78, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 73);
            this.panel1.TabIndex = 19;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Lopushok_K.Properties.Resources.Лопушок;
            this.pictureBox2.Image = global::Lopushok_K.Properties.Resources.Лопушок;
            this.pictureBox2.InitialImage = global::Lopushok_K.Properties.Resources.Лопушок;
            this.pictureBox2.Location = new System.Drawing.Point(29, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(-22, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 73);
            this.panel2.TabIndex = 20;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(573, 472);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbProductType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Snum);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMinCost);
            this.Controls.Add(this.tbArticle);
            this.Controls.Add(this.tbProductName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProductForm";
            this.Text = "Добавление продукта";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.TextBox tbArticle;
        private System.Windows.Forms.TextBox tbMinCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Equal;
        private System.Windows.Forms.TextBox Snum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tbProductType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
    }
}