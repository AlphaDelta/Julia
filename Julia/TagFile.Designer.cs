﻿namespace Julia
{
    partial class TagFile
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
            this.menubar = new System.Windows.Forms.Label();
            this.bTag = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menubar
            // 
            this.menubar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menubar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menubar.Location = new System.Drawing.Point(0, 261);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(279, 42);
            this.menubar.TabIndex = 0;
            // 
            // bTag
            // 
            this.bTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bTag.Location = new System.Drawing.Point(111, 270);
            this.bTag.Name = "bTag";
            this.bTag.Size = new System.Drawing.Size(75, 23);
            this.bTag.TabIndex = 1;
            this.bTag.Text = "Tag";
            this.bTag.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.Location = new System.Drawing.Point(192, 270);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // TagFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(279, 303);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bTag);
            this.Controls.Add(this.menubar);
            this.Name = "TagFile";
            this.ShowIcon = false;
            this.Text = "TagFile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label menubar;
        private System.Windows.Forms.Button bTag;
        private System.Windows.Forms.Button bCancel;
    }
}