using Lopushok_K.model;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lopushok_K
{
    public partial class EditProductForm : Form
    {
        private string article;
        private Product updatedProduct;
        private string selectedImagePath = "";

        public EditProductForm ( string article )
        {
            InitializeComponent();
            this.article = article;

            comboBoxType.Items.Add("Один слой");
            comboBoxType.Items.Add("Два слоя");
            comboBoxType.Items.Add("Три слоя");
            comboBoxType.Items.Add("Детская");
            comboBoxType.Items.Add("Супер мягкая");
        }

        private void EditProductForm_Load ( object sender, EventArgs e )
        {
            // Загрузите данные о продукте с артикулом из базы данных
            using (ModelDB db = new ModelDB())
            {
                updatedProduct = db.Product.FirstOrDefault(p => p.Article == article);

                // Заполните элементы управления данными о продукте
                if (updatedProduct != null)
                {
                    textBoxProductName.Text = updatedProduct.Product_name;

                    // Установим значение ComboBox в соответствии с текущим типом продукта
                    if (comboBoxType.Items.Contains(updatedProduct.Type_product))
                    {
                        comboBoxType.SelectedItem = updatedProduct.Type_product;
                    }

                    textBoxArticle.Text = updatedProduct.Article;
                    textBoxMinCost.Text = updatedProduct.Min_agent_cost.ToString();

                    // Если у вас есть изображение, то также отобразите его
                    if (!string.IsNullOrEmpty(updatedProduct.Image) && File.Exists(updatedProduct.Image))
                    {
                        try
                        {
                            selectedImagePath = updatedProduct.Image;

                            // Проверка на допустимость символов в пути
                            if (!IsValidPath(selectedImagePath))
                            {
                                MessageBox.Show("Путь к изображению содержит недопустимые символы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Загрузите изображение в pictureBoxProduct
                            pictureBoxProduct.Image = Image.FromFile(selectedImagePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка загрузки изображения: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    // Заполним текстовые поля новыми элементами
                    tbEgual.Text = updatedProduct.Equal;
                    tbSnum.Text = updatedProduct.Standart_num;
                }
            }
        }

        public Product GetUpdatedProduct ()
        {
            // Получите измененные данные о продукте из элементов управления формы
            updatedProduct.Product_name = textBoxProductName.Text;

            // Установим тип продукта из ComboBox
            updatedProduct.Type_product = comboBoxType.SelectedItem?.ToString();

            updatedProduct.Article = textBoxArticle.Text;
            updatedProduct.Min_agent_cost = textBoxMinCost.Text;

            // Если у вас есть новый путь к изображению, обновите его
            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                updatedProduct.Image = selectedImagePath;
            }

            // Обновим значения новых полей
            updatedProduct.Equal = tbEgual.Text;
            updatedProduct.Standart_num = tbSnum.Text;

            return updatedProduct;
        }

        private void pictureBoxProduct_Click ( object sender, EventArgs e )
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Изображения (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif|Все файлы (*.*)|*.*";
            openFileDialog.InitialDirectory = @"C:\Users\User12\Desktop\WPF\Lopushok_K\Lopushok_K\products";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;

                // Attempt to load the image
                try
                {
                    pictureBoxProduct.Image = Image.FromFile(selectedImagePath);
                    pictureBoxProduct.Invalidate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private bool IsValidPath ( string path )
        {
            try
            {
                Path.GetFullPath(path);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void buttonCancel_Click ( object sender, EventArgs e )
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonSave_Click ( object sender, EventArgs e )
        {
            // Сохранение изменений продукта
            Product updatedProduct = GetUpdatedProduct();

            // Ваш код сохранения обновленных данных в базу данных
            // ...

            // Если выбрано новое изображение, скопируйте его в папку продуктов и обновите путь в базе данных
            if (!string.IsNullOrEmpty(selectedImagePath) && File.Exists(selectedImagePath))
            {
                string destinationPath = Path.Combine(@"C:\Users\User12\Desktop\WPF\Lopushok_K\Lopushok_K\products", updatedProduct.Article + Path.GetExtension(selectedImagePath));

                File.Copy(selectedImagePath, destinationPath, true);

                // Обновите путь к изображению в базе данных
                updatedProduct.Image = destinationPath;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pictureBox1_Click ( object sender, EventArgs e )
        {

        }
    }
}
