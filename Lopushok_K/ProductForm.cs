using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private int current = 20;
        public ProductForm()
        {
            InitializeComponent();
            using (ModelDB db = new ModelDB())
            {
                list = db.Product.ToList();
                temp = list.Take(current).ToList();
                foreach (var l in temp)
                {
                    UserProduct up = new UserProduct
                    {
                        Lab1 = l.Product_name + " | " + l.Type_product,
                        Lab2 = l.Article,
                        Lab4 = l.Min_agent_cost
                    };
                    up.AddPicture(l.Image);
                    flowLayoutPanel1.Controls.Add(up);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (current + 20 < list.Count)
            {
                DisplayNextProducts();
            }
            else
            {
                MessageBox.Show("Достигнут конец списка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (current >= 20)
            {
                current -= 20;
                flowLayoutPanel1.Controls.Clear();
                for (int i = current; i < current + 20; i++)
                {
                    UserProduct up = new UserProduct
                    {
                        Lab1 = list[i].Product_name + " | " + list[i].Type_product,
                        Lab2 = list[i].Article,
                        Lab4 = list[i].Min_agent_cost,
                    };
                    up.AddPicture(list[i].Image);
                    flowLayoutPanel1.Controls.Add(up);
                }
            }
            else
            {
                MessageBox.Show("Вы достигли начала списка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
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
        private void DisplaySearchResults(List<Product> results)
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

        private void DisplayNextProducts()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = current; i < current + 20; i++)
            {
                UserProduct up = new UserProduct
                {
                    Lab1 = list[i].Product_name + " | " + list[i].Type_product,
                    Lab2 = list[i].Article,
                    Lab4 = list[i].Min_agent_cost,
                };
                up.AddPicture(list[i].Image);
                flowLayoutPanel1.Controls.Add(up);
            }
            current += 20;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = ""; // Очищаем поле поиска
            DisplayNextProducts(); // Отображаем все элементы из исходного списка
        }
        private void DisplayProducts(List<Product> products)
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

        private void comboBoxOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortAndDisplayProducts();
            
        }
        private void SortAndDisplayProducts()
        {
            List<Product> sortedList;

            if (comboBoxOrder.SelectedItem.ToString() == "Возрастание")
            {
                sortedList = list.OrderBy(product => product.Min_agent_cost).ToList();
            }
            else // "Уменьшение"
            {
                sortedList = list.OrderByDescending(product => product.Min_agent_cost).ToList();
            }

            DisplayProducts(sortedList);
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            DisplayNextProducts();
            comboBoxOrder.Items.Add("Возрастание");
            comboBoxOrder.Items.Add("Уменьшение");
            comboBoxOrder.SelectedIndex = 0;
        }

        private void buttonAdd_Click ( object sender, EventArgs e )
        {
            using (AddProductForm addProductForm = new AddProductForm())
            {
                if (addProductForm.ShowDialog() == DialogResult.OK)
                {
                    // Получаем новый продукт из формы добавления продукта
                    Product newProduct = addProductForm.GetNewProduct();

                    // Добавляем новый продукт к исходному списку
                    list.Add(newProduct);

                    // Отображаем обновленный список продуктов
                    SortAndDisplayProducts();

                    // Закрываем форму добавления продукта
                    addProductForm.Close();
                }
            }
        }

        private void flowLayoutPanel1_Paint ( object sender, PaintEventArgs e )
        {

        }

        private void deletebtn_Click ( object sender, EventArgs e )
        {

        }
    }
}
