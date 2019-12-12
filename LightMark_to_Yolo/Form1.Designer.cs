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
            this.groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_Paint
            // 
            this.checkBox_Paint.AutoSize = true;
            this.checkBox_Paint.Location = new System.Drawing.Point(11, 26);
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
            this.groupBoxSettings.Location = new System.Drawing.Point(704, 309);
            this.groupBoxSettings.Name = "groupBoxSettings";
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
            this.lblWidth.Location = new System.Drawing.Point(11, 61);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(59, 17);
            this.lblWidth.TabIndex = 3;
            this.lblWidth.Text = "Ширина";
            // 
            // tBoxHeight
            // 
            this.tBoxHeight.Location = new System.Drawing.Point(76, 92);
            this.tBoxHeight.Name = "tBoxHeight";
            this.tBoxHeight.Size = new System.Drawing.Size(130, 22);
            this.tBoxHeight.TabIndex = 2;
            this.tBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBoxHeight_KeyPress);
            this.tBoxHeight.Leave += new System.EventHandler(this.TBoxHeight_Leave);
            // 
            // tBoxWidth
            // 
            this.tBoxWidth.Location = new System.Drawing.Point(76, 58);
            this.tBoxWidth.Name = "tBoxWidth";
            this.tBoxWidth.Size = new System.Drawing.Size(130, 22);
            this.tBoxWidth.TabIndex = 1;
            this.tBoxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBoxWidth_KeyPress);
            this.tBoxWidth.Leave += new System.EventHandler(this.TBoxWidth_Leave);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(826, 442);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 44);
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
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(675, 474);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFolder.Location = new System.Drawing.Point(704, 13);
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
            this.treeView1.Location = new System.Drawing.Point(704, 47);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(220, 241);
            this.treeView1.TabIndex = 6;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(704, 442);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 44);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 498);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBoxSettings);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
    }
}

