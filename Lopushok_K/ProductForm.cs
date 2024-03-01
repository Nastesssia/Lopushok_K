using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lopushok_K.model
{

    public partial class ProductForm : Form
    {
        List<Product> list;
        List<Product> temp;
        private int itemsPerPage = 20;
        private int currentPage = 1;
        public ProductForm ()
        {
            InitializeComponent();
            using (ModelDB db = new ModelDB())
            {
                list = db.Product.ToList();
                DisplayNextProducts();
            }
        }

        private void button2_Click ( object sender, EventArgs e )
        {
            int totalPages = (int)Math.Ceiling((double)list.Count / itemsPerPage);
            if (currentPage < totalPages)
            {
                currentPage++;
                DisplayNextProducts();
            }
            else
            {
                MessageBox.Show("Достигнут конец списка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            if (currentPage > 1)
            {
                currentPage--;
                DisplayNextProducts();
            }
            else
            {
                MessageBox.Show("Вы достигли начала списка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_Click ( object sender, EventArgs e )
        {
            string searchTerm = textBoxSearch.Text.ToLower(); // Получаем текст поиска и приводим его к нижнему регистру

            List<Product> searchResults = list.Where(product =>
                product.Product_name.ToLower().Contains(searchTerm) ||
                product.Type_product.ToLower().Contains(searchTerm) ||
                product.Article.ToLower().Contains(searchTerm) ||
                product.Min_agent_cost.ToString().Contains(searchTerm)
            ).ToList();

            DisplaySearchResults(searchResults);
        }
        private void DisplaySearchResults ( List<Product> results )
        {
            if (results.Any())
            {
                flowLayoutPanel1.Controls.Clear();
                foreach (Product product in results)
                {
                    UserProduct up = new UserProduct
                    {
                        Lab1 = product.Product_name + " | " + product.Type_product,
                        Lab2 = product.Article,
                        Lab4 = product.Min_agent_cost,
                    };
                    up.AddPicture(product.Image);
                    flowLayoutPanel1.Controls.Add(up);
                }
            }
            else
            {
                MessageBox.Show("Поиск не дал результатов.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
    }

    private void DisplayNextProducts ()
        {
            int startIndex = ( currentPage - 1 ) * itemsPerPage;
            int endIndex = Math.Min(startIndex + itemsPerPage, list.Count);

            DisplayProducts(list.Skip(startIndex).Take(itemsPerPage).ToList());
        }


        private void buttonReset_Click ( object sender, EventArgs e )
        {
            textBoxSearch.Text = ""; // Очищаем поле поиска
            currentPage = 0; // Сброс текущей позиции просмотра к началу списка

            // Перезагрузка исходного списка продуктов из базы данных или кэша
            using (ModelDB db = new ModelDB())
            {
                list = db.Product.ToList(); // Перезагрузка списка продуктов из базы данных
                temp = list.Take(20).ToList(); // Обновление временного списка для отображения
            }

            // Отображаем первые 20 элементов из исходного списка
            DisplayProducts(temp);
        }

        private void DisplayProducts ( List<Product> products )
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (Product product in products)
            {
                UserProduct up = new UserProduct
                {
                    Lab1 = product.Product_name + " | " + product.Type_product,
                    Lab2 = product.Article,
                    Lab4 = product.Min_agent_cost,
                };
                up.AddPicture(product.Image);
                flowLayoutPanel1.Controls.Add(up);
            }
        }

        private void comboBoxOrder_SelectedIndexChanged ( object sender, EventArgs e )
        {
            SortAndDisplayProducts();

        }
        private void SortAndDisplayProducts ()
        {
            int currentPage = this.currentPage;

            List<Product> sortedList;

            if (comboBoxOrder.SelectedItem.ToString() == "Возрастание")
            {
                sortedList = list.OrderBy(product =>
                {
                    decimal.TryParse(product.Min_agent_cost, out decimal cost);
                    return cost;
                }).ToList();
            }
            else // "Уменьшение"
            {
                sortedList = list.OrderByDescending(product =>
                {
                    decimal.TryParse(product.Min_agent_cost, out decimal cost);
                    return cost;
                }).ToList();
            }

            DisplayProducts(sortedList.Skip(( currentPage - 1 ) * itemsPerPage).Take(itemsPerPage).ToList());
        }

        private void ProductForm_Load ( object sender, EventArgs e )
        {
            DisplayNextProducts();
            comboBoxOrder.Items.Add("Уменьшение");
            comboBoxOrder.Items.Add("Возрастание");
            comboBoxOrder.SelectedIndex = 0;
        }
        private void buttonAdd_Click ( object sender, EventArgs e )
        {
            using (AddProductForm addProductForm = new AddProductForm())
            {
                if (addProductForm.ShowDialog() != DialogResult.OK)
                    return;

                Product newProduct = addProductForm.GetNewProduct();

                try
                {
                    using (ModelDB db = new ModelDB())
                    {
                        if (db.Product.Any(p => p.Product_name == newProduct.Product_name))
                            return;

                        db.Product.Add(newProduct);
                        db.SaveChanges();

                        list = db.Product.ToList();
                        DisplayProducts(list); // Обновляем отображение продуктов
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    addProductForm.Close();
                }
            }
        }


        private void deletebtn_Click ( object sender, EventArgs e )
        {
            List<UserProduct> selectedProducts = flowLayoutPanel1.Controls.OfType<UserProduct>()
                .Where(up => up.BackColor == Color.LightBlue).ToList(); // Находим все выделенные продукты

            using (var db = new ModelDB()) // Предположим, что ModelDB - ваш контекст базы данных
            {
                foreach (UserProduct selectedProduct in selectedProducts)
                {
                    var article = selectedProduct.Lab2; // Предполагаем, что Lab2 хранит артикул продукта
                    var productToDelete = db.Product.FirstOrDefault(p => p.Article == article);
                    if (productToDelete != null)
                    {
                        db.Product.Remove(productToDelete); // Удаляем продукт из базы данных
                        flowLayoutPanel1.Controls.Remove(selectedProduct); // Удаляем из FlowLayoutPanel
                        selectedProduct.Dispose();
                    }
                }
                db.SaveChanges(); // Сохраняем изменения в базе данных
            }
        }

        private void comboBox1_SelectedIndexChanged ( object sender, EventArgs e )
        {
            // Получаем выбранный тип продукта из comboBox1
            string selectedType = comboBox1.SelectedItem.ToString();

            // Фильтруем список продуктов по выбранному типу
            List<Product> filteredList = list.Where(product => product.Type_product == selectedType).ToList();

            // Отображаем отфильтрованный список продуктов
            DisplayProducts(filteredList);
        }

        private void flowLayoutPanel1_Paint ( object sender, PaintEventArgs e )
        {

        }

        private void button3_Click ( object sender, EventArgs e )
        {
            textBoxSearch.Text = ""; // Очищаем поле поиска
            currentPage = 0; // Сброс текущей позиции просмотра к началу списка

            // Перезагрузка исходного списка продуктов из базы данных или кэша
            using (ModelDB db = new ModelDB())
            {
                list = db.Product.ToList(); // Перезагрузка списка продуктов из базы данных
                temp = list.Take(20).ToList(); // Обновление временного списка для отображения
            }

            // Отображаем первые 20 элементов из исходного списка
            DisplayProducts(temp);
        }

        private void textBoxSearch_TextChanged ( object sender, EventArgs e )
        {
            string searchTerm = textBoxSearch.Text.ToLower(); // Получаем текст поиска и приводим его к нижнему регистру

            List<Product> searchResults = list.Where(product =>
                product.Product_name.ToLower().Contains(searchTerm) ||
                product.Type_product.ToLower().Contains(searchTerm) ||
                product.Article.ToLower().Contains(searchTerm) ||
                product.Min_agent_cost.ToString().Contains(searchTerm)
            ).ToList();
            DisplaySearchResults(searchResults);
        }

        private void label1_Click ( object sender, EventArgs e )
        {

        }

        private void pictureBox1_Click ( object sender, EventArgs e )
        {

        }
    }
}