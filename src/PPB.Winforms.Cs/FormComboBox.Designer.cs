namespace PPB.WinForms.Cs
{
    partial class FormComboBox
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
            this.buttonFormComboBoxMvvmCommunityToolkit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFormComboBoxMvvmCommunityToolkit
            // 
            this.buttonFormComboBoxMvvmCommunityToolkit.Location = new System.Drawing.Point(23, 179);
            this.buttonFormComboBoxMvvmCommunityToolkit.Name = "buttonFormComboBoxMvvmCommunityToolkit";
            this.buttonFormComboBoxMvvmCommunityToolkit.Size = new System.Drawing.Size(266, 23);
            this.buttonFormComboBoxMvvmCommunityToolkit.TabIndex = 0;
            this.buttonFormComboBoxMvvmCommunityToolkit.Text = "ComboBox MVVM Community Toolkit";
            this.buttonFormComboBoxMvvmCommunityToolkit.UseVisualStyleBackColor = true;
            this.buttonFormComboBoxMvvmCommunityToolkit.Click += new System.EventHandler(this.buttonFormComboBoxMvvmCommunityToolkit_Click);
            // 
            // FormComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFormComboBoxMvvmCommunityToolkit);
            this.Name = "FormComboBox";
            this.Text = "FormComboBox - CS";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonFormComboBoxMvvmCommunityToolkit;
    }
}