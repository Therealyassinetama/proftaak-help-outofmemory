namespace I_Hope_Final_version
{
    partial class Form1
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
            this.BT_MakeMeal = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BT_Order_Ready = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BT_MakeMeal
            // 
            this.BT_MakeMeal.Location = new System.Drawing.Point(12, 12);
            this.BT_MakeMeal.Name = "BT_MakeMeal";
            this.BT_MakeMeal.Size = new System.Drawing.Size(611, 185);
            this.BT_MakeMeal.TabIndex = 1;
            this.BT_MakeMeal.Text = "Make Meal";
            this.BT_MakeMeal.UseVisualStyleBackColor = true;
            this.BT_MakeMeal.Click += new System.EventHandler(this.BT_MakeMeal_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(629, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(149, 173);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // BT_Order_Ready
            // 
            this.BT_Order_Ready.Location = new System.Drawing.Point(12, 203);
            this.BT_Order_Ready.Name = "BT_Order_Ready";
            this.BT_Order_Ready.Size = new System.Drawing.Size(611, 185);
            this.BT_Order_Ready.TabIndex = 4;
            this.BT_Order_Ready.Text = "ORDER READY";
            this.BT_Order_Ready.UseVisualStyleBackColor = true;
            this.BT_Order_Ready.Click += new System.EventHandler(this.BT_Order_Ready_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(784, 11);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(140, 173);
            this.listBox2.TabIndex = 5;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(930, 12);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(122, 173);
            this.listBox3.TabIndex = 6;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 401);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.BT_Order_Ready);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BT_MakeMeal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BT_MakeMeal;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BT_Order_Ready;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
    }
}

