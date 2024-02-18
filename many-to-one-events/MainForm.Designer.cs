namespace many_to_one_events
{
    partial class MainForm
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
            checkBoxUseBeginInvoke = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            richTextBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // checkBoxUseBeginInvoke
            // 
            checkBoxUseBeginInvoke.AutoSize = true;
            checkBoxUseBeginInvoke.Location = new Point(28, 21);
            checkBoxUseBeginInvoke.Name = "checkBoxUseBeginInvoke";
            checkBoxUseBeginInvoke.Size = new Size(174, 29);
            checkBoxUseBeginInvoke.TabIndex = 0;
            checkBoxUseBeginInvoke.Text = "Use Begin Invoke";
            checkBoxUseBeginInvoke.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 14F);
            numericUpDown1.Location = new Point(28, 66);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(139, 45);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Segoe UI", 14F);
            numericUpDown2.Location = new Point(28, 117);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(139, 45);
            numericUpDown2.TabIndex = 1;
            numericUpDown2.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Font = new Font("Segoe UI", 14F);
            numericUpDown3.Location = new Point(28, 168);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(139, 45);
            numericUpDown3.TabIndex = 1;
            numericUpDown3.TextAlign = HorizontalAlignment.Center;
            // 
            // richTextBox
            // 
            richTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox.Location = new Point(208, 13);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(258, 219);
            richTextBox.TabIndex = 2;
            richTextBox.Text = "";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 244);
            Controls.Add(richTextBox);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(checkBoxUseBeginInvoke);
            Name = "MainForm";
            Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxUseBeginInvoke;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private RichTextBox richTextBox;
    }
}
