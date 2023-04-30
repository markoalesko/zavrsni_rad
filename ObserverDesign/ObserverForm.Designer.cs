
namespace ObserverDesign
{
    partial class ObserverForm
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
            this.AvailableBlogs_listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Subscribe_btn = new System.Windows.Forms.Button();
            this.SubscribedBlogs_listbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.blogtext_label = new System.Windows.Forms.Label();
            this.mynotiflabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AvailableBlogs_listbox
            // 
            this.AvailableBlogs_listbox.FormattingEnabled = true;
            this.AvailableBlogs_listbox.Location = new System.Drawing.Point(17, 57);
            this.AvailableBlogs_listbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AvailableBlogs_listbox.Name = "AvailableBlogs_listbox";
            this.AvailableBlogs_listbox.Size = new System.Drawing.Size(151, 160);
            this.AvailableBlogs_listbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available blogs";
            // 
            // Subscribe_btn
            // 
            this.Subscribe_btn.Location = new System.Drawing.Point(198, 120);
            this.Subscribe_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Subscribe_btn.Name = "Subscribe_btn";
            this.Subscribe_btn.Size = new System.Drawing.Size(102, 29);
            this.Subscribe_btn.TabIndex = 2;
            this.Subscribe_btn.Text = "Subscribe";
            this.Subscribe_btn.UseVisualStyleBackColor = true;
            this.Subscribe_btn.Click += new System.EventHandler(this.Subscribe_btn_Click);
            // 
            // SubscribedBlogs_listbox
            // 
            this.SubscribedBlogs_listbox.FormattingEnabled = true;
            this.SubscribedBlogs_listbox.Location = new System.Drawing.Point(335, 57);
            this.SubscribedBlogs_listbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SubscribedBlogs_listbox.Name = "SubscribedBlogs_listbox";
            this.SubscribedBlogs_listbox.Size = new System.Drawing.Size(163, 160);
            this.SubscribedBlogs_listbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(330, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subscribed Blogs";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.blogtext_label);
            this.groupBox1.Location = new System.Drawing.Point(51, 252);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(399, 218);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // blogtext_label
            // 
            this.blogtext_label.AutoSize = true;
            this.blogtext_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.blogtext_label.Location = new System.Drawing.Point(135, 15);
            this.blogtext_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blogtext_label.Name = "blogtext_label";
            this.blogtext_label.Size = new System.Drawing.Size(123, 17);
            this.blogtext_label.TabIndex = 0;
            this.blogtext_label.Text = "Text updates here";
            // 
            // mynotiflabel
            // 
            this.mynotiflabel.AutoSize = true;
            this.mynotiflabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mynotiflabel.Location = new System.Drawing.Point(62, 230);
            this.mynotiflabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mynotiflabel.Name = "mynotiflabel";
            this.mynotiflabel.Size = new System.Drawing.Size(0, 20);
            this.mynotiflabel.TabIndex = 8;
            // 
            // ObserverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 513);
            this.Controls.Add(this.mynotiflabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SubscribedBlogs_listbox);
            this.Controls.Add(this.Subscribe_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AvailableBlogs_listbox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ObserverForm";
            this.Text = "ObserverForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AvailableBlogs_listbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Subscribe_btn;
        private System.Windows.Forms.ListBox SubscribedBlogs_listbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label blogtext_label;
        private System.Windows.Forms.Label mynotiflabel;
    }
}