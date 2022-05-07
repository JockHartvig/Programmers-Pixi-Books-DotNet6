namespace PPB.WinForms.Cs
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFormComboBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFormComboBox
            // 
            this.buttonFormComboBox.Location = new System.Drawing.Point(34, 53);
            this.buttonFormComboBox.Name = "buttonFormComboBox";
            this.buttonFormComboBox.Size = new System.Drawing.Size(75, 23);
            this.buttonFormComboBox.TabIndex = 0;
            this.buttonFormComboBox.Text = "ComboBox";
            this.buttonFormComboBox.UseVisualStyleBackColor = true;
            this.buttonFormComboBox.Click += new System.EventHandler(this.buttonFormComboBox_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFormComboBox);
            this.Name = "FormMenu";
            this.Text = "WinForms DotNet 6 CS - Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonFormComboBox;
    }
}