namespace ota_package_gen_gui
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
            this.btn_keyfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_keyfile
            // 
            this.btn_keyfile.Location = new System.Drawing.Point(46, 26);
            this.btn_keyfile.Name = "btn_keyfile";
            this.btn_keyfile.Size = new System.Drawing.Size(191, 23);
            this.btn_keyfile.TabIndex = 1;
            this.btn_keyfile.Text = "Generate";
            this.btn_keyfile.UseVisualStyleBackColor = true;
            this.btn_keyfile.Click += new System.EventHandler(this.btn_keyfile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 72);
            this.Controls.Add(this.btn_keyfile);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DFU Package Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_keyfile;
    }
}

