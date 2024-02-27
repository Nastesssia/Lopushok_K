using Lopushok_K.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lopushok_K
{
    public partial class AddProductForm : Form
    {
        private string selectedImagePath;

        public AddProductForm()
        {
            InitializeComponent();
        }

        public Product GetNewProduct()
        {
            // Проверка наличия введенных данных и корректности их формата
            if (string.IsNullOrEmpty(tbProductName.Text) ||
                string.IsNullOrEmpty(tbProductType.Text) ||
                string.IsNullOrEmpty(tbArticle.Text) ||
                string.IsNullOrEmpty(tbMinCost.Text))
            {
                // Обработка ошибки (например, отображение сообщения пользователю)
                MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return new Product
            {
                Product_name = tbProductName.Text,
                Type_product = tbProductType.Text,
                Article = tbArticle.Text,
                Min_agent_cost = tbMinCost.Text,
                Image = selectedImagePath // Сохраняем путь к изображению
            };
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            // Проверка наличия выбранного изображения
            if (string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("Пожалуйста, выберите изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void browsebtn_Click ( object sender, EventArgs e )
        {
     
        }

        private void pictureBox1_Click ( object sender, EventArgs e )
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Изображения (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif|Все файлы (*.*)|*.*";
            openFileDialog.InitialDirectory = @"C:\Users\User12\Desktop\WPF\Lopushok_K\Lopushok_K\products";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;

                // Загрузите изображение в pictureBox1
                try
                {
                    pictureBox1.Image = Image.FromFile(selectedImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки изображения: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}