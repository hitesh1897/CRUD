namespace demo
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
            txtunm = new TextBox();
            txtpwd = new TextBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // txtunm
            // 
            txtunm.Location = new Point(124, 2);
            txtunm.Name = "txtunm";
            txtunm.Size = new Size(219, 27);
            txtunm.TabIndex = 1;
            // 
            // txtpwd
            // 
            txtpwd.Location = new Point(124, 49);
            txtpwd.Name = "txtpwd";
            txtpwd.Size = new Size(219, 27);
            txtpwd.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 49);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // button1
            // 
            button1.Location = new Point(12, 94);
            button1.Name = "button1";
            button1.Size = new Size(331, 38);
            button1.TabIndex = 4;
            button1.Text = "Log In ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 136);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(txtpwd);
            Controls.Add(label2);
            Controls.Add(txtunm);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtunm;
        private TextBox txtpwd;
        private Label label2;
        private Button button1;
    }
}
