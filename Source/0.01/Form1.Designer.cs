namespace HashTableDemo
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
            HashTableSizeTB = new TextBox();
            HashTableElementsTB = new TextBox();
            label2 = new Label();
            AddElementsBTN = new Button();
            ReadElementsBTN = new Button();
            DeleteElementsTB = new TextBox();
            label3 = new Label();
            DeleteElementsBTN = new Button();
            SearchElementTB = new TextBox();
            label4 = new Label();
            SearchElementBTN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "HashTable Size";
            // 
            // HashTableSizeTB
            // 
            HashTableSizeTB.Location = new Point(12, 32);
            HashTableSizeTB.Name = "HashTableSizeTB";
            HashTableSizeTB.Size = new Size(163, 27);
            HashTableSizeTB.TabIndex = 1;
            // 
            // HashTableElementsTB
            // 
            HashTableElementsTB.Location = new Point(12, 100);
            HashTableElementsTB.Multiline = true;
            HashTableElementsTB.Name = "HashTableElementsTB";
            HashTableElementsTB.Size = new Size(163, 85);
            HashTableElementsTB.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 2;
            label2.Text = "Elements of Hash Table";
            // 
            // AddElementsBTN
            // 
            AddElementsBTN.Location = new Point(12, 200);
            AddElementsBTN.Name = "AddElementsBTN";
            AddElementsBTN.Size = new Size(163, 52);
            AddElementsBTN.TabIndex = 4;
            AddElementsBTN.Text = "Add element(s)";
            AddElementsBTN.UseVisualStyleBackColor = true;
            AddElementsBTN.Click += AddElementsBTN_Click;
            // 
            // ReadElementsBTN
            // 
            ReadElementsBTN.Location = new Point(12, 268);
            ReadElementsBTN.Name = "ReadElementsBTN";
            ReadElementsBTN.Size = new Size(163, 56);
            ReadElementsBTN.TabIndex = 5;
            ReadElementsBTN.Text = "Read element(s)";
            ReadElementsBTN.UseVisualStyleBackColor = true;
            ReadElementsBTN.Click += ReadElementsBTN_Click;
            // 
            // DeleteElementsTB
            // 
            DeleteElementsTB.Location = new Point(266, 32);
            DeleteElementsTB.Multiline = true;
            DeleteElementsTB.Name = "DeleteElementsTB";
            DeleteElementsTB.Size = new Size(163, 85);
            DeleteElementsTB.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 9);
            label3.Name = "label3";
            label3.Size = new Size(163, 20);
            label3.TabIndex = 6;
            label3.Text = "Elements to be deleted";
            // 
            // DeleteElementsBTN
            // 
            DeleteElementsBTN.Location = new Point(266, 133);
            DeleteElementsBTN.Name = "DeleteElementsBTN";
            DeleteElementsBTN.Size = new Size(163, 52);
            DeleteElementsBTN.TabIndex = 8;
            DeleteElementsBTN.Text = "Delete element(s)";
            DeleteElementsBTN.UseVisualStyleBackColor = true;
            DeleteElementsBTN.Click += DeleteElementsBTN_Click;
            // 
            // SearchElementTB
            // 
            SearchElementTB.Location = new Point(540, 32);
            SearchElementTB.Name = "SearchElementTB";
            SearchElementTB.Size = new Size(163, 27);
            SearchElementTB.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(540, 9);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 9;
            label4.Text = "Elements to Search";
            // 
            // SearchElementBTN
            // 
            SearchElementBTN.Location = new Point(540, 77);
            SearchElementBTN.Name = "SearchElementBTN";
            SearchElementBTN.Size = new Size(163, 56);
            SearchElementBTN.TabIndex = 11;
            SearchElementBTN.Text = "Search element";
            SearchElementBTN.UseVisualStyleBackColor = true;
            SearchElementBTN.Click += SearchElementBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchElementBTN);
            Controls.Add(SearchElementTB);
            Controls.Add(label4);
            Controls.Add(DeleteElementsBTN);
            Controls.Add(DeleteElementsTB);
            Controls.Add(label3);
            Controls.Add(ReadElementsBTN);
            Controls.Add(AddElementsBTN);
            Controls.Add(HashTableElementsTB);
            Controls.Add(label2);
            Controls.Add(HashTableSizeTB);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox HashTableSizeTB;
        private TextBox HashTableElementsTB;
        private Label label2;
        private Button AddElementsBTN;
        private Button ReadElementsBTN;
        private TextBox DeleteElementsTB;
        private Label label3;
        private Button DeleteElementsBTN;
        private TextBox SearchElementTB;
        private Label label4;
        private Button SearchElementBTN;
    }
}