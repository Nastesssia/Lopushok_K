using Lopushok_K.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
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

        public Product GetNewProduct ()
        {
            // Проверка наличия введенных данных и корректности их формата
            if (string.IsNullOrEmpty(tbProductName.Text) ||
                tbProductType.SelectedItem == null ||
                string.IsNullOrEmpty(tbArticle.Text) ||
                string.IsNullOrEmpty(tbMinCost.Text) ||
                string.IsNullOrEmpty(Equal.Text) ||
                string.IsNullOrEmpty(Snum.Text))
            {
                // Обработка ошибки (например, отображение сообщения пользователю)
                MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return new Product
            {
                Product_name = tbProductName.Text,
                Type_product = tbProductType.SelectedItem.ToString(), // Используем выбранный элемент из ComboBox
                Article = tbArticle.Text,
                Min_agent_cost = tbMinCost.Text,
                Equal = Equal.Text,
                Standart_num = Snum.Text,
                Image = selectedImagePath // Сохраняем путь к изображению
            };
        }



        private void buttonAddProduct_Click(object sender, EventArgs e)
{
    // Создаем новый продукт на основе заполненных данных
    Product newProduct = GetNewProduct();

    // Если продукт не был создан из-за отсутствия данных, выходим из метода
    if (newProduct == null)
        return;

    // Создаем контекст базы данных
    using (ModelDB dbContext = new ModelDB())
    {
        try
        {
            // Добавляем новый продукт в DbSet
            dbContext.Product.Add(newProduct);

            // Сохраняем изменения в базе данных
            dbContext.SaveChanges();

            // Показываем сообщение об успешном добавлении
            MessageBox.Show("Продукт успешно добавлен в базу данных", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Закрываем форму
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        catch (DbEntityValidationException ex)
        {
            // Обработка ошибок валидации сущности (если такие есть)
            foreach (var validationErrors in ex.EntityValidationErrors)
            {
                foreach (var validationError in validationErrors.ValidationErrors)
                {
                    MessageBox.Show($"Ошибка валидации: {validationError.ErrorMessage}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        catch (Exception ex)
        {
            // Обработка других исключений
            MessageBox.Show($"Произошла ошибка при добавлении продукта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
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

        private void Equal_TextChanged ( object sender, EventArgs e )
        {

        }

        private void Snum_TextChanged ( object sender, EventArgs e )
        {

        }

        private void tbProductType_TextChanged ( object sender, EventArgs e )
        {

        }

        private void tbProductType_SelectedIndexChanged ( object sender, EventArgs e )
        {

        }

        private void tbArticle_TextChanged ( object sender, EventArgs e )
        {

        }

        private void AddProductForm_Load ( object sender, EventArgs e )
        {

        }

        private void tbMinCost_TextChanged ( object sender, EventArgs e )
        {

        }

        private void tbProductName_TextChanged ( object sender, EventArgs e )
        {

        }
    }
}