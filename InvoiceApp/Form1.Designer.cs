namespace InvoiceApp
{
    partial class MainAppForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.readButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.byCategoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(14, 40);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(91, 23);
            this.readButton.TabIndex = 0;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(14, 11);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(774, 23);
            this.pathTextBox.TabIndex = 1;
            this.pathTextBox.Text = "C:\\Users\\Marcin\\Desktop\\Invoices.txt";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(14, 69);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(772, 369);
            this.resultTextBox.TabIndex = 2;
            // 
            // byCategoryButton
            // 
            this.byCategoryButton.Location = new System.Drawing.Point(108, 40);
            this.byCategoryButton.Name = "byCategoryButton";
            this.byCategoryButton.Size = new System.Drawing.Size(85, 23);
            this.byCategoryButton.TabIndex = 3;
            this.byCategoryButton.Text = "By category";
            this.byCategoryButton.UseVisualStyleBackColor = true;
            this.byCategoryButton.Click += new System.EventHandler(this.byCategoryButton_Click);
            // 
            // MainAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.byCategoryButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.readButton);
            this.Name = "MainAppForm";
            this.Text = "Invoice application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button readButton;
        private TextBox pathTextBox;
        private TextBox resultTextBox;
        private Button byCategoryButton;
    }
}