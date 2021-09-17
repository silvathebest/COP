
using System.Drawing;
using System.Windows.Forms;

namespace COP
{
    partial class ControlCheckedListBox
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.checkedListBox = new CheckedListBox();
            base.SuspendLayout();
            this.checkedListBox.Dock = DockStyle.Fill;
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new Point(0, 0);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new Size(150, 150);
            this.checkedListBox.TabIndex = 0;
            this.checkedListBox.ItemCheck += new ItemCheckEventHandler(this.CheckedListBox_ItemCheck);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.Controls.Add(this.checkedListBox);
            base.Name = "ControlSelectedCheckedListBox";
            base.ResumeLayout(false);
        }

        #endregion

        protected System.Windows.Forms.CheckedListBox checkedListBox;
    }
}
