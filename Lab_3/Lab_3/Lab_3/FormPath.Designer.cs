namespace Lab_3
{
    partial class filePathForm
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
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonLeftDelete = new System.Windows.Forms.Button();
            this.buttonLeftRemove = new System.Windows.Forms.Button();
            this.buttonRightComeBack = new System.Windows.Forms.Button();
            this.buttonRightDelete = new System.Windows.Forms.Button();
            this.listBoxLeft = new System.Windows.Forms.ListBox();
            this.listBoxRight = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(12, 42);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(607, 20);
            this.textBoxPath.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(625, 39);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(142, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonLeftDelete
            // 
            this.buttonLeftDelete.Location = new System.Drawing.Point(12, 214);
            this.buttonLeftDelete.Name = "buttonLeftDelete";
            this.buttonLeftDelete.Size = new System.Drawing.Size(182, 92);
            this.buttonLeftDelete.TabIndex = 4;
            this.buttonLeftDelete.Text = "Удалить";
            this.buttonLeftDelete.UseVisualStyleBackColor = true;
            this.buttonLeftDelete.Click += new System.EventHandler(this.buttonLeftDelete_Click);
            // 
            // buttonLeftRemove
            // 
            this.buttonLeftRemove.Location = new System.Drawing.Point(200, 214);
            this.buttonLeftRemove.Name = "buttonLeftRemove";
            this.buttonLeftRemove.Size = new System.Drawing.Size(182, 92);
            this.buttonLeftRemove.TabIndex = 5;
            this.buttonLeftRemove.Text = "Переместить";
            this.buttonLeftRemove.UseVisualStyleBackColor = true;
            this.buttonLeftRemove.Click += new System.EventHandler(this.buttonLeftRemove_Click);
            // 
            // buttonRightComeBack
            // 
            this.buttonRightComeBack.Location = new System.Drawing.Point(585, 214);
            this.buttonRightComeBack.Name = "buttonRightComeBack";
            this.buttonRightComeBack.Size = new System.Drawing.Size(182, 92);
            this.buttonRightComeBack.TabIndex = 7;
            this.buttonRightComeBack.Text = "Вернуть";
            this.buttonRightComeBack.UseVisualStyleBackColor = true;
            this.buttonRightComeBack.Click += new System.EventHandler(this.buttonRightComeBack_Click);
            // 
            // buttonRightDelete
            // 
            this.buttonRightDelete.Location = new System.Drawing.Point(388, 214);
            this.buttonRightDelete.Name = "buttonRightDelete";
            this.buttonRightDelete.Size = new System.Drawing.Size(191, 92);
            this.buttonRightDelete.TabIndex = 6;
            this.buttonRightDelete.Text = "Удалить";
            this.buttonRightDelete.UseVisualStyleBackColor = true;
            this.buttonRightDelete.Click += new System.EventHandler(this.buttonRightDelete_Click);
            // 
            // listBoxLeft
            // 
            this.listBoxLeft.FormattingEnabled = true;
            this.listBoxLeft.Location = new System.Drawing.Point(12, 68);
            this.listBoxLeft.Name = "listBoxLeft";
            this.listBoxLeft.Size = new System.Drawing.Size(370, 134);
            this.listBoxLeft.TabIndex = 8;
            // 
            // listBoxRight
            // 
            this.listBoxRight.FormattingEnabled = true;
            this.listBoxRight.Location = new System.Drawing.Point(388, 68);
            this.listBoxRight.Name = "listBoxRight";
            this.listBoxRight.Size = new System.Drawing.Size(379, 134);
            this.listBoxRight.TabIndex = 9;
            // 
            // filePathForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 318);
            this.Controls.Add(this.listBoxRight);
            this.Controls.Add(this.listBoxLeft);
            this.Controls.Add(this.buttonRightComeBack);
            this.Controls.Add(this.buttonRightDelete);
            this.Controls.Add(this.buttonLeftRemove);
            this.Controls.Add(this.buttonLeftDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPath);
            this.Name = "filePathForm";
            this.Text = "Lab_3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonLeftDelete;
        private System.Windows.Forms.Button buttonLeftRemove;
        private System.Windows.Forms.Button buttonRightComeBack;
        private System.Windows.Forms.Button buttonRightDelete;
        private System.Windows.Forms.ListBox listBoxLeft;
        private System.Windows.Forms.ListBox listBoxRight;
    }
}

