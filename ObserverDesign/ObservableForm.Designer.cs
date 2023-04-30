
namespace ObserverDesign
{
    partial class ObservableForm
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
            this.blogtext_textbox = new System.Windows.Forms.TextBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.MyObserver_listbox = new System.Windows.Forms.ListBox();
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.NumberOfObservers_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // blogtext_textbox
            // 
            this.blogtext_textbox.Location = new System.Drawing.Point(43, 145);
            this.blogtext_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.blogtext_textbox.Multiline = true;
            this.blogtext_textbox.Name = "blogtext_textbox";
            this.blogtext_textbox.Size = new System.Drawing.Size(500, 355);
            this.blogtext_textbox.TabIndex = 0;
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(351, 72);
            this.update_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(192, 65);
            this.update_btn.TabIndex = 1;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // MyObserver_listbox
            // 
            this.MyObserver_listbox.FormattingEnabled = true;
            this.MyObserver_listbox.ItemHeight = 25;
            this.MyObserver_listbox.Location = new System.Drawing.Point(602, 255);
            this.MyObserver_listbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MyObserver_listbox.Name = "MyObserver_listbox";
            this.MyObserver_listbox.Size = new System.Drawing.Size(201, 154);
            this.MyObserver_listbox.TabIndex = 2;
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.Location = new System.Drawing.Point(655, 427);
            this.Refresh_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(104, 38);
            this.Refresh_btn.TabIndex = 3;
            this.Refresh_btn.Text = "Refresh";
            this.Refresh_btn.UseVisualStyleBackColor = true;
            this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // NumberOfObservers_label
            // 
            this.NumberOfObservers_label.AutoSize = true;
            this.NumberOfObservers_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumberOfObservers_label.Location = new System.Drawing.Point(681, 192);
            this.NumberOfObservers_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumberOfObservers_label.Name = "NumberOfObservers_label";
            this.NumberOfObservers_label.Size = new System.Drawing.Size(35, 37);
            this.NumberOfObservers_label.TabIndex = 4;
            this.NumberOfObservers_label.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(561, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of my observers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(46, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Text:";
            // 
            // ObservableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberOfObservers_label);
            this.Controls.Add(this.Refresh_btn);
            this.Controls.Add(this.MyObserver_listbox);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.blogtext_textbox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ObservableForm";
            this.Text = "ObservableForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox blogtext_textbox;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.ListBox MyObserver_listbox;
        private System.Windows.Forms.Button Refresh_btn;
        private System.Windows.Forms.Label NumberOfObservers_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}