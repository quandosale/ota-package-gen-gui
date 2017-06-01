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
            this.keyfile_url = new System.Windows.Forms.TextBox();
            this.btn_keyfile = new System.Windows.Forms.Button();
            this.btn_package = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_keyfile_browse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.firmware_url = new System.Windows.Forms.TextBox();
            this.btn_firmware_browse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // keyfile_url
            // 
            this.keyfile_url.Enabled = false;
            this.keyfile_url.Location = new System.Drawing.Point(65, 20);
            this.keyfile_url.Margin = new System.Windows.Forms.Padding(0);
            this.keyfile_url.Name = "keyfile_url";
            this.keyfile_url.Size = new System.Drawing.Size(274, 20);
            this.keyfile_url.TabIndex = 0;
            // 
            // btn_keyfile
            // 
            this.btn_keyfile.Location = new System.Drawing.Point(183, 83);
            this.btn_keyfile.Name = "btn_keyfile";
            this.btn_keyfile.Size = new System.Drawing.Size(75, 23);
            this.btn_keyfile.TabIndex = 1;
            this.btn_keyfile.Text = "Keyfile";
            this.btn_keyfile.UseVisualStyleBackColor = true;
            this.btn_keyfile.Click += new System.EventHandler(this.btn_keyfile_Click);
            // 
            // btn_package
            // 
            this.btn_package.Location = new System.Drawing.Point(264, 83);
            this.btn_package.Name = "btn_package";
            this.btn_package.Size = new System.Drawing.Size(75, 23);
            this.btn_package.TabIndex = 2;
            this.btn_package.Text = "Package";
            this.btn_package.UseVisualStyleBackColor = true;
            this.btn_package.Click += new System.EventHandler(this.btn_package_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Keyfile:";
            // 
            // btn_keyfile_browse
            // 
            this.btn_keyfile_browse.Location = new System.Drawing.Point(348, 19);
            this.btn_keyfile_browse.Margin = new System.Windows.Forms.Padding(0);
            this.btn_keyfile_browse.Name = "btn_keyfile_browse";
            this.btn_keyfile_browse.Size = new System.Drawing.Size(24, 22);
            this.btn_keyfile_browse.TabIndex = 4;
            this.btn_keyfile_browse.Text = "···";
            this.btn_keyfile_browse.UseVisualStyleBackColor = true;
            this.btn_keyfile_browse.Click += new System.EventHandler(this.btn_keyfile_browse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Firmware:";
            // 
            // firmware_url
            // 
            this.firmware_url.Enabled = false;
            this.firmware_url.Location = new System.Drawing.Point(65, 50);
            this.firmware_url.Margin = new System.Windows.Forms.Padding(0);
            this.firmware_url.Name = "firmware_url";
            this.firmware_url.Size = new System.Drawing.Size(274, 20);
            this.firmware_url.TabIndex = 5;
            // 
            // btn_firmware_browse
            // 
            this.btn_firmware_browse.Location = new System.Drawing.Point(348, 50);
            this.btn_firmware_browse.Margin = new System.Windows.Forms.Padding(0);
            this.btn_firmware_browse.Name = "btn_firmware_browse";
            this.btn_firmware_browse.Size = new System.Drawing.Size(24, 22);
            this.btn_firmware_browse.TabIndex = 7;
            this.btn_firmware_browse.Text = "···";
            this.btn_firmware_browse.UseVisualStyleBackColor = true;
            this.btn_firmware_browse.Click += new System.EventHandler(this.btn_firmware_browse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 125);
            this.Controls.Add(this.btn_firmware_browse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firmware_url);
            this.Controls.Add(this.btn_keyfile_browse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_package);
            this.Controls.Add(this.btn_keyfile);
            this.Controls.Add(this.keyfile_url);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DFU Package Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox keyfile_url;
        private System.Windows.Forms.Button btn_keyfile;
        private System.Windows.Forms.Button btn_package;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_keyfile_browse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firmware_url;
        private System.Windows.Forms.Button btn_firmware_browse;
    }
}

