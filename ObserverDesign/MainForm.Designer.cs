
namespace ObserverDesign
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddObservable_btn = new System.Windows.Forms.Button();
            this.AddObserver_btn = new System.Windows.Forms.Button();
            this.blogname_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(418, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Interface";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(32, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Observable Subject (blog)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(740, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Observer (Subscriber)";
            // 
            // AddObservable_btn
            // 
            this.AddObservable_btn.Location = new System.Drawing.Point(163, 342);
            this.AddObservable_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddObservable_btn.Name = "AddObservable_btn";
            this.AddObservable_btn.Size = new System.Drawing.Size(232, 90);
            this.AddObservable_btn.TabIndex = 3;
            this.AddObservable_btn.Text = "Add";
            this.AddObservable_btn.UseVisualStyleBackColor = true;
            this.AddObservable_btn.Click += new System.EventHandler(this.AddObservable_btn_Click);
            // 
            // AddObserver_btn
            // 
            this.AddObserver_btn.Location = new System.Drawing.Point(828, 337);
            this.AddObserver_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddObserver_btn.Name = "AddObserver_btn";
            this.AddObserver_btn.Size = new System.Drawing.Size(229, 95);
            this.AddObserver_btn.TabIndex = 4;
            this.AddObserver_btn.Text = "Add";
            this.AddObserver_btn.UseVisualStyleBackColor = true;
            this.AddObserver_btn.Click += new System.EventHandler(this.AddObserver_btn_Click);
            // 
            // blogname_textbox
            // 
            this.blogname_textbox.Location = new System.Drawing.Point(192, 290);
            this.blogname_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.blogname_textbox.Name = "blogname_textbox";
            this.blogname_textbox.Size = new System.Drawing.Size(179, 31);
            this.blogname_textbox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Blog Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 544);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.blogname_textbox);
            this.Controls.Add(this.AddObserver_btn);
            this.Controls.Add(this.AddObservable_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddObservable_btn;
        private System.Windows.Forms.Button AddObserver_btn;
        private System.Windows.Forms.TextBox blogname_textbox;
        private System.Windows.Forms.Label label4;
    }
}

