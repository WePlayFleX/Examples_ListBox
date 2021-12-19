namespace ExampleCheckedListBox
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.chlstSourse = new System.Windows.Forms.CheckedListBox();
			this.chlstTarget = new System.Windows.Forms.CheckedListBox();
			this.btnCopySelect = new System.Windows.Forms.Button();
			this.btnSelect = new System.Windows.Forms.Button();
			this.btnUnSelect = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// chlstSourse
			// 
			this.chlstSourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.chlstSourse.FormattingEnabled = true;
			this.chlstSourse.Location = new System.Drawing.Point(12, 27);
			this.chlstSourse.Name = "chlstSourse";
			this.chlstSourse.Size = new System.Drawing.Size(221, 270);
			this.chlstSourse.TabIndex = 0;
			this.chlstSourse.ThreeDCheckBoxes = true;
			// 
			// chlstTarget
			// 
			this.chlstTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.chlstTarget.FormattingEnabled = true;
			this.chlstTarget.Location = new System.Drawing.Point(250, 27);
			this.chlstTarget.Name = "chlstTarget";
			this.chlstTarget.Size = new System.Drawing.Size(221, 270);
			this.chlstTarget.TabIndex = 0;
			this.chlstTarget.ThreeDCheckBoxes = true;
			// 
			// btnCopySelect
			// 
			this.btnCopySelect.Location = new System.Drawing.Point(12, 324);
			this.btnCopySelect.Name = "btnCopySelect";
			this.btnCopySelect.Size = new System.Drawing.Size(98, 36);
			this.btnCopySelect.TabIndex = 1;
			this.btnCopySelect.Text = "Копировать выделенные";
			this.btnCopySelect.UseVisualStyleBackColor = true;
			this.btnCopySelect.Click += new System.EventHandler(this.btnCopySelect_Click);
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(250, 324);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(98, 36);
			this.btnSelect.TabIndex = 1;
			this.btnSelect.Text = "Выделить все";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// btnUnSelect
			// 
			this.btnUnSelect.Location = new System.Drawing.Point(373, 324);
			this.btnUnSelect.Name = "btnUnSelect";
			this.btnUnSelect.Size = new System.Drawing.Size(98, 36);
			this.btnUnSelect.TabIndex = 1;
			this.btnUnSelect.Text = "Снять выделение";
			this.btnUnSelect.UseVisualStyleBackColor = true;
			this.btnUnSelect.Click += new System.EventHandler(this.btnUnSelect_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(498, 432);
			this.Controls.Add(this.btnUnSelect);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.btnCopySelect);
			this.Controls.Add(this.chlstTarget);
			this.Controls.Add(this.chlstSourse);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chlstSourse;
        private System.Windows.Forms.CheckedListBox chlstTarget;
        private System.Windows.Forms.Button btnCopySelect;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnUnSelect;
    }
}

