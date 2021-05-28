namespace Decryptor
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textView = new System.Windows.Forms.RichTextBox();
            this.decryptButton = new System.Windows.Forms.Button();
            this.textButton = new System.Windows.Forms.Button();
            this.doubleButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.keyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textView
            // 
            this.textView.AcceptsTab = true;
            this.textView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textView.BackColor = System.Drawing.SystemColors.Window;
            this.textView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textView.DetectUrls = false;
            this.textView.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textView.Location = new System.Drawing.Point(16, 15);
            this.textView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textView.Name = "textView";
            this.textView.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.textView.Size = new System.Drawing.Size(853, 697);
            this.textView.TabIndex = 0;
            this.textView.Text = "";
            // 
            // decryptButton
            // 
            this.decryptButton.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decryptButton.Location = new System.Drawing.Point(553, 724);
            this.decryptButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(100, 70);
            this.decryptButton.TabIndex = 1;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // textButton
            // 
            this.textButton.Location = new System.Drawing.Point(661, 724);
            this.textButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textButton.Name = "textButton";
            this.textButton.Size = new System.Drawing.Size(100, 69);
            this.textButton.TabIndex = 4;
            this.textButton.Text = "Text";
            this.textButton.UseVisualStyleBackColor = true;
            this.textButton.Click += new System.EventHandler(this.textButton_Click);
            // 
            // doubleButton
            // 
            this.doubleButton.Location = new System.Drawing.Point(769, 724);
            this.doubleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doubleButton.Name = "doubleButton";
            this.doubleButton.Size = new System.Drawing.Size(100, 69);
            this.doubleButton.TabIndex = 5;
            this.doubleButton.Text = "Decrypt + Text";
            this.doubleButton.UseVisualStyleBackColor = true;
            this.doubleButton.Click += new System.EventHandler(this.doubleButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(445, 724);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 69);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(16, 724);
            this.openButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(100, 69);
            this.openButton.TabIndex = 8;
            this.openButton.Text = "Open file";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // keyButton
            // 
            this.keyButton.Location = new System.Drawing.Point(124, 724);
            this.keyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.keyButton.Name = "keyButton";
            this.keyButton.Size = new System.Drawing.Size(100, 69);
            this.keyButton.TabIndex = 9;
            this.keyButton.Text = "Set key";
            this.keyButton.UseVisualStyleBackColor = true;
            this.keyButton.Click += new System.EventHandler(this.keyButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(891, 809);
            this.Controls.Add(this.keyButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.doubleButton);
            this.Controls.Add(this.textButton);
            this.Controls.Add(this.textView);
            this.Controls.Add(this.decryptButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "Duck Decryptor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textView;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button textButton;
        private System.Windows.Forms.Button doubleButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button keyButton;
    }
}

