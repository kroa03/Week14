namespace COMP123_002_Assignment05
{
    partial class StartForm
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
            this.StartANewOrderButton = new System.Windows.Forms.Button();
            this.LoadASavedOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartANewOrderButton
            // 
            this.StartANewOrderButton.Location = new System.Drawing.Point(363, 163);
            this.StartANewOrderButton.Name = "StartANewOrderButton";
            this.StartANewOrderButton.Size = new System.Drawing.Size(110, 23);
            this.StartANewOrderButton.TabIndex = 0;
            this.StartANewOrderButton.Text = "Start A New Order";
            this.StartANewOrderButton.UseVisualStyleBackColor = true;
            this.StartANewOrderButton.Click += new System.EventHandler(this.StartANewOrderButton_Click);
            // 
            // LoadASavedOrderButton
            // 
            this.LoadASavedOrderButton.Location = new System.Drawing.Point(363, 214);
            this.LoadASavedOrderButton.Name = "LoadASavedOrderButton";
            this.LoadASavedOrderButton.Size = new System.Drawing.Size(130, 23);
            this.LoadASavedOrderButton.TabIndex = 1;
            this.LoadASavedOrderButton.Text = "Load A Saved Order";
            this.LoadASavedOrderButton.UseVisualStyleBackColor = true;
            this.LoadASavedOrderButton.Click += new System.EventHandler(this.LoadASavedOrderButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(363, 259);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoadASavedOrderButton);
            this.Controls.Add(this.StartANewOrderButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartANewOrderButton;
        private System.Windows.Forms.Button LoadASavedOrderButton;
        private System.Windows.Forms.Button ExitButton;
    }
}