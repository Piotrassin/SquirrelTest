namespace WinFormsApp1
{
    partial class Form1
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
            checkUpdatesButton = new Button();
            versionTextBox = new TextBox();
            UpdateButton = new Button();
            SuspendLayout();
            // 
            // checkUpdatesButton
            // 
            checkUpdatesButton.Location = new Point(257, 181);
            checkUpdatesButton.Name = "checkUpdatesButton";
            checkUpdatesButton.Size = new Size(252, 45);
            checkUpdatesButton.TabIndex = 0;
            checkUpdatesButton.Text = "Check for updates";
            checkUpdatesButton.UseVisualStyleBackColor = true;
            checkUpdatesButton.Click += button1_Click;
            // 
            // versionTextBox
            // 
            versionTextBox.Location = new Point(281, 112);
            versionTextBox.Name = "versionTextBox";
            versionTextBox.Size = new Size(210, 23);
            versionTextBox.TabIndex = 1;
            // 
            // UpdateButton
            // 
            UpdateButton.Enabled = false;
            UpdateButton.Location = new Point(257, 252);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(252, 45);
            UpdateButton.TabIndex = 2;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UpdateButton);
            Controls.Add(versionTextBox);
            Controls.Add(checkUpdatesButton);
            Name = "Form1";
            Text = "Form1 v.1.0.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button checkUpdatesButton;
        private TextBox versionTextBox;
        private Button UpdateButton;
    }
}