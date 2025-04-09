namespace TodoApp
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
            label1 = new Label();
            label2 = new Label();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            lstTodo = new ListBox();
            btn_Add = new Button();
            btn_Delete = new Button();
            btn_Update = new Button();
            btn_List = new Button();
            label3 = new Label();
            dtmDueDate = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 41);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Başlık";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.CausesValidation = false;
            label2.Location = new Point(37, 84);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Açıklama";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(115, 41);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(252, 23);
            txtTitle.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(115, 84);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(252, 23);
            txtDescription.TabIndex = 2;
            // 
            // lstTodo
            // 
            lstTodo.FormattingEnabled = true;
            lstTodo.ItemHeight = 15;
            lstTodo.Location = new Point(485, 41);
            lstTodo.Name = "lstTodo";
            lstTodo.Size = new Size(251, 169);
            lstTodo.TabIndex = 3;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(37, 297);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(75, 23);
            btn_Add.TabIndex = 4;
            btn_Add.Text = "Ekle";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(160, 297);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(75, 23);
            btn_Delete.TabIndex = 4;
            btn_Delete.Text = "Sil";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(292, 297);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(75, 23);
            btn_Update.TabIndex = 4;
            btn_Update.Text = "Güncelle";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_List
            // 
            btn_List.Location = new Point(402, 297);
            btn_List.Name = "btn_List";
            btn_List.Size = new Size(75, 23);
            btn_List.TabIndex = 4;
            btn_List.Text = "Listele";
            btn_List.UseVisualStyleBackColor = true;
            btn_List.Click += btn_List_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 137);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 1;
            label3.Text = "Bitiş Tarihi";
            // 
            // dtmDueDate
            // 
            dtmDueDate.Location = new Point(115, 131);
            dtmDueDate.Name = "dtmDueDate";
            dtmDueDate.Size = new Size(252, 23);
            dtmDueDate.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtmDueDate);
            Controls.Add(btn_List);
            Controls.Add(btn_Update);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Add);
            Controls.Add(lstTodo);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private ListBox lstTodo;
        private Button btn_Add;
        private Button btn_Delete;
        private Button btn_Update;
        private Button btn_List;
        private Label label3;
        private DateTimePicker dtmDueDate;
    }
}
