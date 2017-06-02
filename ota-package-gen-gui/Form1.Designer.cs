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
            this.btn_package = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.firmware_url = new System.Windows.Forms.TextBox();
            this.btn_firmware_browse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_package
            // 
            this.btn_package.Location = new System.Drawing.Point(301, 52);
            this.btn_package.Name = "btn_package";
            this.btn_package.Size = new System.Drawing.Size(75, 23);
            this.btn_package.TabIndex = 2;
            this.btn_package.Text = "Generate";
            this.btn_package.UseVisualStyleBackColor = true;
            this.btn_package.Click += new System.EventHandler(this.btn_package_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Firmware:";
            // 
            // firmware_url
            // 
            this.firmware_url.Enabled = false;
            this.firmware_url.Location = new System.Drawing.Point(69, 18);
            this.firmware_url.Margin = new System.Windows.Forms.Padding(0);
            this.firmware_url.Name = "firmware_url";
            this.firmware_url.Size = new System.Drawing.Size(274, 20);
            this.firmware_url.TabIndex = 5;
            // 
            // btn_firmware_browse
            // 
            this.btn_firmware_browse.Location = new System.Drawing.Point(352, 17);
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
            this.ClientSize = new System.Drawing.Size(387, 89);
            this.Controls.Add(this.btn_firmware_browse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firmware_url);
            this.Controls.Add(this.btn_package);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DFU Package Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_package;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firmware_url;
        private System.Windows.Forms.Button btn_firmware_browse;
    }
}

