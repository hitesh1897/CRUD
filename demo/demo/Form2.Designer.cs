namespace demo
{
    partial class Form2
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
            label1 = new Label();
            txtsnm = new TextBox();
            txtmob = new TextBox();
            label2 = new Label();
            insbtn = new Button();
            updatebtn = new Button();
            deletebtn = new Button();
            firstbtn = new Button();
            nextbtn = new Button();
            prevbtn = new Button();
            lastbtn = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Student Name";
            // 
            // txtsnm
            // 
            txtsnm.Location = new Point(129, 12);
            txtsnm.Name = "txtsnm";
            txtsnm.Size = new Size(188, 27);
            txtsnm.TabIndex = 1;
            // 
            // txtmob
            // 
            txtmob.Location = new Point(129, 64);
            txtmob.Name = "txtmob";
            txtmob.Size = new Size(188, 27);
            txtmob.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 67);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 2;
            label2.Text = "Mobile No";
            // 
            // insbtn
            // 
            insbtn.Location = new Point(10, 131);
            insbtn.Name = "insbtn";
            insbtn.Size = new Size(125, 34);
            insbtn.TabIndex = 4;
            insbtn.Text = "insert";
            insbtn.UseVisualStyleBackColor = true;
            insbtn.Click += insbtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.Enabled = false;
            updatebtn.Location = new Point(101, 131);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(116, 34);
            updatebtn.TabIndex = 5;
            updatebtn.Text = "update";
            updatebtn.UseVisualStyleBackColor = true;
            updatebtn.Click += updatebtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.Enabled = false;
            deletebtn.Location = new Point(223, 131);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(94, 34);
            deletebtn.TabIndex = 6;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // firstbtn
            // 
            firstbtn.Location = new Point(12, 171);
            firstbtn.Name = "firstbtn";
            firstbtn.Size = new Size(72, 34);
            firstbtn.TabIndex = 7;
            firstbtn.Text = "First";
            firstbtn.UseVisualStyleBackColor = true;
            firstbtn.Click += firstbtn_Click;
            // 
            // nextbtn
            // 
            nextbtn.Location = new Point(90, 171);
            nextbtn.Name = "nextbtn";
            nextbtn.Size = new Size(72, 34);
            nextbtn.TabIndex = 8;
            nextbtn.Text = "Next";
            nextbtn.UseVisualStyleBackColor = true;
            nextbtn.Click += nextbtn_Click;
            // 
            // prevbtn
            // 
            prevbtn.Location = new Point(167, 171);
            prevbtn.Name = "prevbtn";
            prevbtn.Size = new Size(72, 34);
            prevbtn.TabIndex = 9;
            prevbtn.Text = "prev";
            prevbtn.UseVisualStyleBackColor = true;
            prevbtn.Click += prevbtn_Click;
            // 
            // lastbtn
            // 
            lastbtn.Location = new Point(245, 171);
            lastbtn.Name = "lastbtn";
            lastbtn.Size = new Size(72, 34);
            lastbtn.TabIndex = 10;
            lastbtn.Text = "Last";
            lastbtn.UseVisualStyleBackColor = true;
            lastbtn.Click += lastbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 234);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(303, 274);
            dataGridView1.TabIndex = 11;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(328, 575);
            Controls.Add(dataGridView1);
            Controls.Add(lastbtn);
            Controls.Add(prevbtn);
            Controls.Add(nextbtn);
            Controls.Add(firstbtn);
            Controls.Add(deletebtn);
            Controls.Add(updatebtn);
            Controls.Add(insbtn);
            Controls.Add(txtmob);
            Controls.Add(label2);
            Controls.Add(txtsnm);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtsnm;
        private TextBox txtmob;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button insbtn;
        private Button updatebtn;
        private Button deletebtn;
        private Button firstbtn;
        private Button nextbtn;
        private Button prevbtn;
        private Button lastbtn;
        private DataGridView dataGridView1;
    }
}