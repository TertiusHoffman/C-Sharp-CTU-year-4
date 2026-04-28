namespace FavouriteLanguagesApp
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
            lblTitle = new Label();
            listBox1 = new ListBox();
            txtLanguage = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            lblInfo = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(213, 44);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(359, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "My Favourite Programming Languages";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(153, 85);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(507, 154);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // txtLanguage
            // 
            txtLanguage.Location = new Point(213, 272);
            txtLanguage.Name = "txtLanguage";
            txtLanguage.Size = new Size(363, 23);
            txtLanguage.TabIndex = 2;
            txtLanguage.TextChanged += txtLanguage_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(241, 315);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(443, 315);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(129, 23);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(406, 367);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 15);
            lblInfo.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInfo);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(txtLanguage);
            Controls.Add(listBox1);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ListBox listBox1;
        private TextBox txtLanguage;
        private Button btnAdd;
        private Button btnRemove;
        private Label lblInfo;
    }
}
