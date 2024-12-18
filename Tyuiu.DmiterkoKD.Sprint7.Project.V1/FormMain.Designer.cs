namespace Tyuiu.DmiterkoKD.Sprint7.Project.V1
{
    partial class FormMain
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
            buttonPlan_DKD = new Button();
            buttonMove_DKD = new Button();
            buttonStop_DKD = new Button();
            buttonEnergy_DKD = new Button();
            buttonSO_DKD = new Button();
            buttonFridge_DKD = new Button();
            buttonXCH_DKD = new Button();
            buttonOil_DKD = new Button();
            panel_DKD = new Panel();
            panel_DKD.SuspendLayout();
            SuspendLayout();
            // 
            // buttonPlan_DKD
            // 
            buttonPlan_DKD.Location = new Point(83, 92);
            buttonPlan_DKD.Name = "buttonPlan_DKD";
            buttonPlan_DKD.Size = new Size(212, 206);
            buttonPlan_DKD.TabIndex = 0;
            buttonPlan_DKD.Text = "Плановое обслуживание";
            buttonPlan_DKD.UseVisualStyleBackColor = true;
            buttonPlan_DKD.Click += buttonOpenForm1_Click;
            // 
            // buttonMove_DKD
            // 
            buttonMove_DKD.Location = new Point(564, 402);
            buttonMove_DKD.Name = "buttonMove_DKD";
            buttonMove_DKD.Size = new Size(203, 143);
            buttonMove_DKD.TabIndex = 1;
            buttonMove_DKD.Text = "Ремонт двигателя";
            buttonMove_DKD.UseVisualStyleBackColor = true;
            buttonMove_DKD.Click += buttonOpenForm1_Click;
            // 
            // buttonStop_DKD
            // 
            buttonStop_DKD.Location = new Point(345, 409);
            buttonStop_DKD.Name = "buttonStop_DKD";
            buttonStop_DKD.Size = new Size(172, 151);
            buttonStop_DKD.TabIndex = 2;
            buttonStop_DKD.Text = "Ремонт тормозной системы";
            buttonStop_DKD.UseVisualStyleBackColor = true;
            buttonStop_DKD.Click += buttonOpenForm1_Click;
            // 
            // buttonEnergy_DKD
            // 
            buttonEnergy_DKD.Location = new Point(83, 402);
            buttonEnergy_DKD.Name = "buttonEnergy_DKD";
            buttonEnergy_DKD.Size = new Size(224, 164);
            buttonEnergy_DKD.TabIndex = 3;
            buttonEnergy_DKD.Text = "Ремонт электронных систем";
            buttonEnergy_DKD.UseVisualStyleBackColor = true;
            buttonEnergy_DKD.Click += buttonOpenForm1_Click;
            // 
            // buttonSO_DKD
            // 
            buttonSO_DKD.Location = new Point(751, 92);
            buttonSO_DKD.Name = "buttonSO_DKD";
            buttonSO_DKD.Size = new Size(206, 216);
            buttonSO_DKD.TabIndex = 4;
            buttonSO_DKD.Text = "Обслуживание систем охлаждения";
            buttonSO_DKD.UseVisualStyleBackColor = true;
            buttonSO_DKD.Click += buttonOpenForm1_Click;
            // 
            // buttonFridge_DKD
            // 
            buttonFridge_DKD.Location = new Point(564, 95);
            buttonFridge_DKD.Name = "buttonFridge_DKD";
            buttonFridge_DKD.Size = new Size(171, 203);
            buttonFridge_DKD.TabIndex = 5;
            buttonFridge_DKD.Text = "Заправка кондиционера";
            buttonFridge_DKD.UseVisualStyleBackColor = true;
            buttonFridge_DKD.Click += buttonOpenForm1_Click;
            // 
            // buttonXCH_DKD
            // 
            buttonXCH_DKD.Location = new Point(804, 388);
            buttonXCH_DKD.Name = "buttonXCH_DKD";
            buttonXCH_DKD.Size = new Size(167, 178);
            buttonXCH_DKD.TabIndex = 6;
            buttonXCH_DKD.Text = "Ремонт ходовой части";
            buttonXCH_DKD.UseVisualStyleBackColor = true;
            buttonXCH_DKD.Click += buttonOpenForm1_Click;
            // 
            // buttonOil_DKD
            // 
            buttonOil_DKD.AutoEllipsis = true;
            buttonOil_DKD.Location = new Point(318, 95);
            buttonOil_DKD.Name = "buttonOil_DKD";
            buttonOil_DKD.Size = new Size(208, 203);
            buttonOil_DKD.TabIndex = 7;
            buttonOil_DKD.Text = "Замена масла";
            buttonOil_DKD.UseVisualStyleBackColor = true;
            buttonOil_DKD.Click += buttonOpenForm1_Click;
            // 
            // panel_DKD
            // 
            panel_DKD.Controls.Add(buttonOil_DKD);
            panel_DKD.Controls.Add(buttonXCH_DKD);
            panel_DKD.Controls.Add(buttonFridge_DKD);
            panel_DKD.Controls.Add(buttonSO_DKD);
            panel_DKD.Controls.Add(buttonEnergy_DKD);
            panel_DKD.Controls.Add(buttonStop_DKD);
            panel_DKD.Controls.Add(buttonMove_DKD);
            panel_DKD.Controls.Add(buttonPlan_DKD);
            panel_DKD.Dock = DockStyle.Fill;
            panel_DKD.Location = new Point(0, 0);
            panel_DKD.Name = "panel_DKD";
            panel_DKD.Size = new Size(1036, 656);
            panel_DKD.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 656);
            Controls.Add(panel_DKD);
            Name = "FormMain";
            Text = "Авторемонтная мастерская";
            panel_DKD.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonPlan_DKD;
        private Button buttonMove_DKD;
        private Button buttonStop_DKD;
        private Button buttonEnergy_DKD;
        private Button buttonSO_DKD;
        private Button buttonFridge_DKD;
        private Button buttonXCH_DKD;
        private Button buttonOil_DKD;
        private Panel panel_DKD;
    }
}
