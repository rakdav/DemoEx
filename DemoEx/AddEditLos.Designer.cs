namespace DemoEx
{
    partial class AddEditLos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(15, 318);
            button1.Name = "button1";
            button1.Size = new Size(157, 23);
            button1.TabIndex = 8;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(225, 318);
            button2.Name = "button2";
            button2.Size = new Size(181, 23);
            button2.TabIndex = 9;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(15, 269);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "ИНН";
            textBox6.Size = new Size(391, 23);
            textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(15, 225);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "email";
            textBox5.Size = new Size(391, 23);
            textBox5.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(15, 183);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Телефон";
            textBox4.Size = new Size(391, 23);
            textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(15, 136);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "ФИОДиректора";
            textBox3.Size = new Size(391, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 93);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Адрес";
            textBox2.Size = new Size(391, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 12);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Наименование";
            textBox1.Size = new Size(393, 23);
            textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ОАО", "ООО", "ЗАО", "ЛосьСнабО" });
            comboBox1.Location = new Point(15, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(175, 23);
            comboBox1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(205, 48);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(201, 23);
            numericUpDown1.TabIndex = 10;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AddEditLos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 372);
            Controls.Add(numericUpDown1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Name = "AddEditLos";
            Text = "AddEditLos";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        public TextBox textBox6;
        public TextBox textBox5;
        public TextBox textBox4;
        public TextBox textBox3;
        public TextBox textBox2;
        public TextBox textBox1;
        public ComboBox comboBox1;
        public NumericUpDown numericUpDown1;
    }
}