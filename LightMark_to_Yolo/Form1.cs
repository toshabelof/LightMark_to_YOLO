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

namespace LightMark_to_Yolo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        

        DirectoryInfo dir;
        Markup markup;
        TreeNode nodeSelecID;
        Size sizeRectangle;
        Pen pen = new Pen(Color.Red, 2);

        List<Markup> markupList = new List<Markup>();
        List<Rectangle> rectangleList = new List<Rectangle>();

        string pathFolder;
        
        
        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    pathFolder = folderBrowserDialog.SelectedPath + @"\";
                }
            }
            Console.WriteLine(pathFolder);
            TranslateInListView(pathFolder);
        }

        /// <summary>
        /// Метод заполняет treeView1 списком фото, находящиеся ввыбранном каталоге
        /// </summary>
        /// <param name="path">Путь к папке</param>
        private void TranslateInListView(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (FileInfo files in dir.GetFiles())
            {
                if (files.Extension.IsIn(".png", ".jpg"))
                {
                    treeView1.Nodes.Add(files.Name);
                }
            }

            if (treeView1.GetNodeCount(true) == 0)
            {
                MessageBox.Show("Выбранная папка не содержит фото. Фотографии должны иметь расширение PNG или JPG.",
                                "Не найдены фото",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (treeView1.SelectedNode != null)
                {
                    pictureBox1.Image = Image.FromFile(pathFolder + e.Node.FullPath);
                    nodeSelecID = e.Node;
                    Console.WriteLine(nodeSelecID.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void TBoxWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBoxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var rec in rectangleList)
            {
                e.Graphics.DrawRectangle(pen, rec);
            }
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!checkBox_Paint.Checked) { return; }

            if (String.IsNullOrEmpty(tBoxWidth.Text))
            {
                MessageBox.Show("Введите ширину рамки для разметки", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (String.IsNullOrEmpty(tBoxHeight.Text))
            {
                MessageBox.Show("Введите высоту рамки для разметки", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            sizeRectangle = new Size(Convert.ToInt32(tBoxWidth.Text), Convert.ToInt32(tBoxHeight.Text));
            rectangleList.Add(new Rectangle(e.Location, sizeRectangle));
            pictureBox1.Refresh();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            rectangleList.Clear();
            pictureBox1.Refresh();

            SelectNode();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes == null) { return; }
            if (rectangleList.Count == 0)
            {
                MessageBox.Show("Вы ничего не разметили.", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            SelectNode();
        }

        private void CheckBox_Paint_CheckedChanged(object sender, EventArgs e)
        {
            SelectNode();
        }

        private void SelectNode()
        {
            if (treeView1.Nodes == null) { return; }
            if (nodeSelecID == null) { return; }

            treeView1.Focus();
            treeView1.SelectedNode = nodeSelecID;
        }

        private void TBoxWidth_Leave(object sender, EventArgs e)
        {
            SelectNode();
        }

        private void TBoxHeight_Leave(object sender, EventArgs e)
        {
            SelectNode();
        }
    }

    public static class MyExtension
    {
        /// <summary>
        /// Метод сравнивающий строку с набором строк
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this">Строка, которая сравнивается</param>
        /// <param name="possibles">Набор строк, с которыми сравнивать</param>
        /// <returns></returns>
        public static bool IsIn<T>(this T @this, params T[] possibles)
        {
            return possibles.Contains(@this);
        }
    }
}
