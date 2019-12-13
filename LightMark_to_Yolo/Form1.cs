using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
        List<string> classesList = new List<string>();


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
                    Bitmap bmp = (Bitmap)Image.FromFile(pathFolder + e.Node.FullPath);
                    bmp = ResizeBitmap(bmp, pictureBox1.Width, pictureBox1.Height);
                    pictureBox1.Image = bmp;

                    nodeSelecID = e.Node;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }

            return result;
        }


        private void TBoxWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) { return; }    //Если нажат символ (не число)
            if (Char.IsControl(e.KeyChar)) { return; }  //Если нажата клавиша контрол
            e.Handled = true;
            
        }

        private void TBoxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) { return; }    //Если нажат символ (не число)
            if (Char.IsControl(e.KeyChar)) { return; }  //Если нажата клавиша контрол
            e.Handled = true;
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
            Point point = new Point(e.Location.X - (int)(sizeRectangle.Width / 2), e.Location.Y - (int)(sizeRectangle.Height / 2));
            
            rectangleList.Add(new Rectangle(point, sizeRectangle));
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

            Bitmap bmp1 = new Bitmap(pictureBox1.Image);

            for (int i = 0; i < rectangleList.Count; ++i)
            {
                Bitmap bmp2 = bmp1.Clone(rectangleList[i], bmp1.PixelFormat);
                Console.WriteLine(rectangleList[i].X);
                Console.WriteLine(rectangleList[i].Y);
                Console.WriteLine(rectangleList[i].Width);
                Console.WriteLine(rectangleList[i].Height);
                bmp2.Save(String.Concat("frame", i, ".jpg"), ImageFormat.Jpeg);
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

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewClasses();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chekList_Classes.Items.Clear();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            chekList_Classes.Items.Remove(chekList_Classes.SelectedItem);
        }

        private void Btn_ClassesClear_Click(object sender, EventArgs e)
        {
            chekList_Classes.Items.Clear();
            classesList.Clear();
        }


        private void ChekList_Classes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < chekList_Classes.Items.Count; ++i)
            {
                if (i != e.Index)
                {
                    chekList_Classes.SetItemChecked(i, false);
                }
            }
        }

        private void TBox_ClassesName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; //убирает звуковой сигнал при нажатии на Enter
                AddNewClasses();
            }
        }

        /// <summary>
        /// Добавляет новый класс в chekedList и classesList, введенный в tBox_ClassesName
        /// </summary>
        private void AddNewClasses()
        {
            if (!classesList.Contains(tBox_ClassesName.Text))
            {
                chekList_Classes.Items.Add(tBox_ClassesName.Text);
                classesList.Add(tBox_ClassesName.Text);
                tBox_ClassesName.Focus();
                tBox_ClassesName.SelectAll();
            }
            else
            {
                MessageBox.Show("Такой класс уже существует", "Внимение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) { return; }

            Bitmap bmp = (Bitmap)Image.FromFile(pathFolder + nodeSelecID.FullPath);
            bmp = ResizeBitmap(bmp, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
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
