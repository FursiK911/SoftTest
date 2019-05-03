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

namespace Lab_3
{
    public partial class filePathForm : Form
    {
        public filePathForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxPath.Text != null && textBoxPath.Text != "")
            {
                bool isValid = isDirectoryValid(textBoxPath.Text);

                if(isValid)
                {
                    listBoxLeft.Items.Add(textBoxPath.Text);
                }
                else
                {
                    listBoxRight.Items.Add(textBoxPath.Text);
                }
                textBoxPath.Text = "";
            }
            else
            {
                MessageBox.Show("Пустая строка!", "Что-то пошло не так!");
            }
        }
                 
        private bool isDirectoryValid(string dir)
        {
            if (!Path.IsPathRooted(dir))
                return false;
            return true;
        }

        private void buttonLeftDelete_Click(object sender, EventArgs e)
        {
            if(listBoxLeft.SelectedItems.Count >= 1)
                listBoxLeft.Items.RemoveAt(listBoxLeft.SelectedIndex);
        }

        private void buttonRightDelete_Click(object sender, EventArgs e)
        {
            if (listBoxRight.SelectedItems.Count >= 1)
                listBoxRight.Items.RemoveAt(listBoxRight.SelectedIndex);
        }

        private void buttonLeftRemove_Click(object sender, EventArgs e)
        {
            if (listBoxLeft.SelectedItems.Count >= 1)
            {
                listBoxRight.Items.Add(listBoxLeft.SelectedItem.ToString());
                listBoxLeft.Items.RemoveAt(listBoxLeft.SelectedIndex);
            }
        }

        private void buttonRightComeBack_Click(object sender, EventArgs e)
        {
            if (listBoxRight.SelectedItems.Count >= 1)
            {
                textBoxPath.Text = listBoxRight.SelectedItem.ToString();
                listBoxRight.Items.RemoveAt(listBoxRight.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Вы не выбрали строку для повторной проверки!", "Что-то пошло не так!");
            }
        }
    }
}
