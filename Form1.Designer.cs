namespace MIAPR1
{
    partial class Form1
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
            this.ClassesTextBox = new System.Windows.Forms.TextBox();
            this.ObjectsTextBox = new System.Windows.Forms.TextBox();
            this.Objects = new System.Windows.Forms.Label();
            this.Classes = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassesTextBox
            // 
            this.ClassesTextBox.Location = new System.Drawing.Point(32, 97);
            this.ClassesTextBox.Name = "ClassesTextBox";
            this.ClassesTextBox.Size = new System.Drawing.Size(125, 27);
            this.ClassesTextBox.TabIndex = 0;
            this.ClassesTextBox.Text = "9";
            // 
            // ObjectsTextBox
            // 
            this.ObjectsTextBox.Location = new System.Drawing.Point(30, 37);
            this.ObjectsTextBox.Name = "ObjectsTextBox";
            this.ObjectsTextBox.Size = new System.Drawing.Size(125, 27);
            this.ObjectsTextBox.TabIndex = 1;
            this.ObjectsTextBox.Text = "50000";
            // 
            // Objects
            // 
            this.Objects.AutoSize = true;
            this.Objects.Location = new System.Drawing.Point(18, 14);
            this.Objects.Name = "Objects";
            this.Objects.Size = new System.Drawing.Size(59, 20);
            this.Objects.TabIndex = 2;
            this.Objects.Text = "Objects";
            // 
            // Classes
            // 
            this.Classes.AutoSize = true;
            this.Classes.Location = new System.Drawing.Point(21, 74);
            this.Classes.Name = "Classes";
            this.Classes.Size = new System.Drawing.Size(56, 20);
            this.Classes.TabIndex = 3;
            this.Classes.Text = "Classes";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(180, 95);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(94, 29);
            this.GenerateButton.TabIndex = 4;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(941, 529);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 676);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.Classes);
            this.Controls.Add(this.Objects);
            this.Controls.Add(this.ObjectsTextBox);
            this.Controls.Add(this.ClassesTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ClassesTextBox;
        private TextBox ObjectsTextBox;
        private Label Objects;
        private Label Classes;
        private Button GenerateButton;
        private PictureBox pictureBox1;
    }
}