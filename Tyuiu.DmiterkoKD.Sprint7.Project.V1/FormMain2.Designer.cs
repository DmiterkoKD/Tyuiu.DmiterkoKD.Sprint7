namespace Tyuiu.DmiterkoKD.Sprint7.Project.V1
{
    partial class FormMain2
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
            labelDisplay = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelDisplay
            // 
            labelDisplay.AutoSize = true;
            labelDisplay.Location = new Point(78, 51);
            labelDisplay.Name = "labelDisplay";
            labelDisplay.Size = new Size(38, 15);
            labelDisplay.TabIndex = 0;
            labelDisplay.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(484, 172);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            
            // 
            // FormMain2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(labelDisplay);
            Name = "FormMain2";
            Text = "FormMain2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDisplay;
        private Button button1;
    }
}