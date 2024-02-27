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
    public partial class UserProduct : UserControl
    {
        public UserProduct ()
        {
            InitializeComponent();
        }
        public string Lab1
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public string Lab2
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }

        public string Lab4
        {
            get { return label4.Text; }
            set { label4.Text = value; }
        }
        public void AddPicture ( string path )
        {
            if (!string.IsNullOrEmpty(path))
            {
                string absolutePath = Path.Combine(Environment.CurrentDirectory, path.TrimStart('\\'));

                if (File.Exists(absolutePath))
                {
                    pictureBox1.Image = Image.FromFile(absolutePath);
                }
                else
                {
                    MessageBox.Show("Файл не найден: " + absolutePath, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}