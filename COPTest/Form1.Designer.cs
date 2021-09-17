using COP;
namespace COPTest
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonSet = new System.Windows.Forms.Button();
            this.buttonGet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAddToTree = new System.Windows.Forms.Button();
            this.buttonGetFromTree = new System.Windows.Forms.Button();
            this.buttonGetIdFromTree = new System.Windows.Forms.Button();
            this.controlCheckedListBox = new COP.ControlCheckedListBox();
            this.controlDateTimePicker = new COP.ControlDateTimePickerRange();
            this.controlTree = new COP.ControlTree();
            this.buttonSetIdForTree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 245);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 21);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 269);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(150, 21);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 328);
            this.textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(151, 20);
            this.textBox.TabIndex = 3;
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(166, 245);
            this.buttonSet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(150, 21);
            this.buttonSet.TabIndex = 4;
            this.buttonSet.Text = "Установить значение";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(166, 269);
            this.buttonGet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(150, 22);
            this.buttonGet.TabIndex = 5;
            this.buttonGet.Text = "Прочитать значение";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 22);
            this.button1.TabIndex = 6;
            this.button1.Text = "Взять дату";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAddToTree
            // 
            this.buttonAddToTree.Location = new System.Drawing.Point(557, 206);
            this.buttonAddToTree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddToTree.Name = "buttonAddToTree";
            this.buttonAddToTree.Size = new System.Drawing.Size(150, 23);
            this.buttonAddToTree.TabIndex = 7;
            this.buttonAddToTree.Text = "Добавить";
            this.buttonAddToTree.UseVisualStyleBackColor = true;
            this.buttonAddToTree.Click += new System.EventHandler(this.buttonAddToTree_Click);
            // 
            // buttonGetFromTree
            // 
            this.buttonGetFromTree.Location = new System.Drawing.Point(553, 245);
            this.buttonGetFromTree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGetFromTree.Name = "buttonGetFromTree";
            this.buttonGetFromTree.Size = new System.Drawing.Size(154, 21);
            this.buttonGetFromTree.TabIndex = 8;
            this.buttonGetFromTree.Text = "Получить запись";
            this.buttonGetFromTree.UseVisualStyleBackColor = true;
            this.buttonGetFromTree.Click += new System.EventHandler(this.buttonGetFromTree_Click);
            // 
            // buttonGetIdFromTree
            // 
            this.buttonGetIdFromTree.Location = new System.Drawing.Point(553, 285);
            this.buttonGetIdFromTree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGetIdFromTree.Name = "buttonGetIdFromTree";
            this.buttonGetIdFromTree.Size = new System.Drawing.Size(154, 21);
            this.buttonGetIdFromTree.TabIndex = 9;
            this.buttonGetIdFromTree.Text = "Получить индекс";
            this.buttonGetIdFromTree.UseVisualStyleBackColor = true;
            this.buttonGetIdFromTree.Click += new System.EventHandler(this.buttonGetIdFromTree_Click);
            // 
            // controlCheckedListBox
            // 
            this.controlCheckedListBox.Location = new System.Drawing.Point(12, 84);
            this.controlCheckedListBox.Name = "controlCheckedListBox";
            this.controlCheckedListBox.SelectedItem = "";
            this.controlCheckedListBox.Size = new System.Drawing.Size(150, 156);
            this.controlCheckedListBox.TabIndex = 0;
            this.controlCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.controlCheckedListBox_SelectedIndexChanged);
            // 
            // controlDateTimePicker
            // 
            this.controlDateTimePicker.Location = new System.Drawing.Point(12, 12);
            this.controlDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlDateTimePicker.MaxDate = null;
            this.controlDateTimePicker.MinDate = null;
            this.controlDateTimePicker.Name = "controlDateTimePicker";
            this.controlDateTimePicker.Size = new System.Drawing.Size(150, 21);
            this.controlDateTimePicker.TabIndex = 0;
            this.controlDateTimePicker.Value = null;
            // 
            // controlTree
            // 
            this.controlTree.Location = new System.Drawing.Point(557, 12);
            this.controlTree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlTree.Name = "controlTree";
            this.controlTree.Size = new System.Drawing.Size(150, 168);
            this.controlTree.TabIndex = 0;
            // 
            // buttonSetIdForTree
            // 
            this.buttonSetIdForTree.Location = new System.Drawing.Point(553, 327);
            this.buttonSetIdForTree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSetIdForTree.Name = "buttonSetIdForTree";
            this.buttonSetIdForTree.Size = new System.Drawing.Size(154, 21);
            this.buttonSetIdForTree.TabIndex = 10;
            this.buttonSetIdForTree.Text = "Установить индекс";
            this.buttonSetIdForTree.UseVisualStyleBackColor = true;
            this.buttonSetIdForTree.Click += new System.EventHandler(this.buttonSetIdForTree_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSetIdForTree);
            this.Controls.Add(this.buttonGetIdFromTree);
            this.Controls.Add(this.buttonGetFromTree);
            this.Controls.Add(this.buttonAddToTree);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.controlCheckedListBox);
            this.Controls.Add(this.controlDateTimePicker);
            this.Controls.Add(this.controlTree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected ControlCheckedListBox controlCheckedListBox;
        private ControlDateTimePickerRange controlDateTimePicker;
        private ControlTree controlTree;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAddToTree;
        private System.Windows.Forms.Button buttonGetFromTree;
        private System.Windows.Forms.Button buttonGetIdFromTree;
        private System.Windows.Forms.Button buttonSetIdForTree;
    }
}

