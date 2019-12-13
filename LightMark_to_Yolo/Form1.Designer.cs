namespace LightMark_to_Yolo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox_Paint = new System.Windows.Forms.CheckBox();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.tBoxHeight = new System.Windows.Forms.TextBox();
            this.tBoxWidth = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn_ClassesCreate = new System.Windows.Forms.Button();
            this.tBox_ClassesName = new System.Windows.Forms.TextBox();
            this.btn_ClassesDelete = new System.Windows.Forms.Button();
            this.chekList_Classes = new System.Windows.Forms.CheckedListBox();
            this.btn_ClassesClear = new System.Windows.Forms.Button();
            this.groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_Paint
            // 
            this.checkBox_Paint.AutoSize = true;
            this.checkBox_Paint.Location = new System.Drawing.Point(11, 26);
            this.checkBox_Paint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Paint.Name = "checkBox_Paint";
            this.checkBox_Paint.Size = new System.Drawing.Size(99, 21);
            this.checkBox_Paint.TabIndex = 0;
            this.checkBox_Paint.Text = "Рисовать?";
            this.checkBox_Paint.UseVisualStyleBackColor = true;
            this.checkBox_Paint.CheckedChanged += new System.EventHandler(this.CheckBox_Paint_CheckedChanged);
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSettings.Controls.Add(this.lblHeight);
            this.groupBoxSettings.Controls.Add(this.lblWidth);
            this.groupBoxSettings.Controls.Add(this.tBoxHeight);
            this.groupBoxSettings.Controls.Add(this.tBoxWidth);
            this.groupBoxSettings.Controls.Add(this.checkBox_Paint);
            this.groupBoxSettings.Location = new System.Drawing.Point(1092, 405);
            this.groupBoxSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSettings.Size = new System.Drawing.Size(220, 127);
            this.groupBoxSettings.TabIndex = 1;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Настройки";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(11, 92);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(57, 17);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Высота";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(11, 62);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(59, 17);
            this.lblWidth.TabIndex = 3;
            this.lblWidth.Text = "Ширина";
            // 
            // tBoxHeight
            // 
            this.tBoxHeight.Location = new System.Drawing.Point(76, 92);
            this.tBoxHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxHeight.Name = "tBoxHeight";
            this.tBoxHeight.Size = new System.Drawing.Size(129, 22);
            this.tBoxHeight.TabIndex = 2;
            this.tBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBoxHeight_KeyPress);
            this.tBoxHeight.Leave += new System.EventHandler(this.TBoxHeight_Leave);
            // 
            // tBoxWidth
            // 
            this.tBoxWidth.Location = new System.Drawing.Point(76, 58);
            this.tBoxWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxWidth.Name = "tBoxWidth";
            this.tBoxWidth.Size = new System.Drawing.Size(129, 22);
            this.tBoxWidth.TabIndex = 1;
            this.tBoxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBoxWidth_KeyPress);
            this.tBoxWidth.Leave += new System.EventHandler(this.TBoxWidth_Leave);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1213, 545);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 44);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(276, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(797, 577);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFolder.Location = new System.Drawing.Point(1091, 14);
            this.btnOpenFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(220, 28);
            this.btnOpenFolder.TabIndex = 5;
            this.btnOpenFolder.Text = "Открыть папку";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(1091, 47);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(220, 341);
            this.treeView1.TabIndex = 6;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(1091, 545);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 44);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btn_ClassesCreate
            // 
            this.btn_ClassesCreate.Location = new System.Drawing.Point(16, 47);
            this.btn_ClassesCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ClassesCreate.Name = "btn_ClassesCreate";
            this.btn_ClassesCreate.Size = new System.Drawing.Size(253, 28);
            this.btn_ClassesCreate.TabIndex = 10;
            this.btn_ClassesCreate.Text = "Создать класс";
            this.btn_ClassesCreate.UseVisualStyleBackColor = true;
            this.btn_ClassesCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBox_ClassesName
            // 
            this.tBox_ClassesName.Location = new System.Drawing.Point(16, 15);
            this.tBox_ClassesName.Margin = new System.Windows.Forms.Padding(4);
            this.tBox_ClassesName.Name = "tBox_ClassesName";
            this.tBox_ClassesName.Size = new System.Drawing.Size(252, 22);
            this.tBox_ClassesName.TabIndex = 11;
            this.tBox_ClassesName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBox_ClassesName_KeyDown);
            // 
            // btn_ClassesDelete
            // 
            this.btn_ClassesDelete.Location = new System.Drawing.Point(17, 84);
            this.btn_ClassesDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ClassesDelete.Name = "btn_ClassesDelete";
            this.btn_ClassesDelete.Size = new System.Drawing.Size(117, 28);
            this.btn_ClassesDelete.TabIndex = 12;
            this.btn_ClassesDelete.Text = "Удалить класс";
            this.btn_ClassesDelete.UseVisualStyleBackColor = true;
            this.btn_ClassesDelete.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // chekList_Classes
            // 
            this.chekList_Classes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chekList_Classes.BackColor = System.Drawing.SystemColors.Control;
            this.chekList_Classes.CheckOnClick = true;
            this.chekList_Classes.FormattingEnabled = true;
            this.chekList_Classes.Location = new System.Drawing.Point(16, 141);
            this.chekList_Classes.Margin = new System.Windows.Forms.Padding(4);
            this.chekList_Classes.Name = "chekList_Classes";
            this.chekList_Classes.Size = new System.Drawing.Size(252, 446);
            this.chekList_Classes.Sorted = true;
            this.chekList_Classes.TabIndex = 14;
            this.chekList_Classes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ChekList_Classes_ItemCheck);
            // 
            // btn_ClassesClear
            // 
            this.btn_ClassesClear.Location = new System.Drawing.Point(151, 84);
            this.btn_ClassesClear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ClassesClear.Name = "btn_ClassesClear";
            this.btn_ClassesClear.Size = new System.Drawing.Size(117, 28);
            this.btn_ClassesClear.TabIndex = 15;
            this.btn_ClassesClear.Text = "Очистить";
            this.btn_ClassesClear.UseVisualStyleBackColor = true;
            this.btn_ClassesClear.Click += new System.EventHandler(this.Btn_ClassesClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 600);
            this.Controls.Add(this.btn_ClassesClear);
            this.Controls.Add(this.chekList_Classes);
            this.Controls.Add(this.btn_ClassesDelete);
            this.Controls.Add(this.tBox_ClassesName);
            this.Controls.Add(this.btn_ClassesCreate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBoxSettings);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_Paint;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox tBoxHeight;
        private System.Windows.Forms.TextBox tBoxWidth;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn_ClassesCreate;
        private System.Windows.Forms.TextBox tBox_ClassesName;
        private System.Windows.Forms.Button btn_ClassesDelete;
        private System.Windows.Forms.CheckedListBox chekList_Classes;
        private System.Windows.Forms.Button btn_ClassesClear;
    }
}

