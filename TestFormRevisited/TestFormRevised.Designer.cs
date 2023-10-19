namespace TestFormRevisited
{
    partial class TestFormRevised
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
            addButton = new Button();
            removeButton = new Button();
            dataGridView1 = new DataGridView();
            saveButton = new Button();
            cancelButton = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            editPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            editPanel.SuspendLayout();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 12);
            addButton.Name = "addButton";
            addButton.Size = new Size(71, 29);
            addButton.TabIndex = 0;
            addButton.Text = "button1";
            addButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(89, 12);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(71, 29);
            removeButton.TabIndex = 1;
            removeButton.Text = "button1";
            removeButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(405, 245);
            dataGridView1.TabIndex = 2;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(32, 175);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(71, 29);
            saveButton.TabIndex = 3;
            saveButton.Text = "button1";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(32, 210);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(71, 29);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "button1";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 51);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 99);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 10;
            label3.Text = "label3";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 121);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            // 
            // editPanel
            // 
            editPanel.Controls.Add(saveButton);
            editPanel.Controls.Add(label3);
            editPanel.Controls.Add(cancelButton);
            editPanel.Controls.Add(textBox3);
            editPanel.Controls.Add(label1);
            editPanel.Controls.Add(label2);
            editPanel.Controls.Add(textBox1);
            editPanel.Controls.Add(textBox2);
            editPanel.Location = new Point(423, 47);
            editPanel.Name = "editPanel";
            editPanel.Size = new Size(110, 245);
            editPanel.TabIndex = 11;
            // 
            // TestFormRevised
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 304);
            Controls.Add(editPanel);
            Controls.Add(dataGridView1);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Name = "TestFormRevised";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            editPanel.ResumeLayout(false);
            editPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button addButton;
        private Button removeButton;
        private DataGridView dataGridView1;
        private Button saveButton;
        private Button cancelButton;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Panel editPanel;
    }
}