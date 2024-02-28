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
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbArticle = new System.Windows.Forms.TextBox();
            this.tbMinCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Equal = new System.Windows.Forms.TextBox();
            this.Snum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbProductType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(249, 16);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(200, 20);
            this.tbProductName.TabIndex = 0;
            // 
            // tbArticle
            // 
            this.tbArticle.Location = new System.Drawing.Point(249, 90);
            this.tbArticle.Name = "tbArticle";
            this.tbArticle.Size = new System.Drawing.Size(200, 20);
            this.tbArticle.TabIndex = 2;
            // 
            // tbMinCost
            // 
            this.tbMinCost.Location = new System.Drawing.Point(249, 125);
            this.tbMinCost.Name = "tbMinCost";
            this.tbMinCost.Size = new System.Drawing.Size(200, 20);
            this.tbMinCost.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя продукта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Тип продукта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Артикул";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Мин. стоимость";
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(163, 323);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(150, 23);
            this.buttonAddProduct.TabIndex = 9;
            this.buttonAddProduct.Text = "Добавить продукт";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(12, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 112);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Equal
            // 
            this.Equal.Location = new System.Drawing.Point(249, 165);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(200, 20);
            this.Equal.TabIndex = 11;
            this.Equal.TextChanged += new System.EventHandler(this.Equal_TextChanged);
            // 
            // Snum
            // 
            this.Snum.Location = new System.Drawing.Point(249, 212);
            this.Snum.Name = "Snum";
            this.Snum.Size = new System.Drawing.Size(200, 20);
            this.Snum.TabIndex = 12;
            this.Snum.TextChanged += new System.EventHandler(this.Snum_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Количество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Номер";
            // 
            // tbProductType
            // 
            this.tbProductType.FormattingEnabled = true;
            this.tbProductType.Items.AddRange(new object[] {
            "Один слой",
            "Два слоя",
            "Три слоя",
            "Детская",
            "Супер мягкая"});
            this.tbProductType.Location = new System.Drawing.Point(249, 54);
            this.tbProductType.Name = "tbProductType";
            this.tbProductType.Size = new System.Drawing.Size(200, 21);
            this.tbProductType.TabIndex = 15;
            this.tbProductType.SelectedIndexChanged += new System.EventHandler(this.tbProductType_SelectedIndexChanged);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 508);
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
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}