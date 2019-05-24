namespace WinformsDemo
{
    partial class RPSLSpWinformsDemo
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
            this.gbNames = new System.Windows.Forms.GroupBox();
            this.tbPlayer2 = new System.Windows.Forms.TextBox();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.tbPlayer1 = new System.Windows.Forms.TextBox();
            this.gbPlayer1Type = new System.Windows.Forms.GroupBox();
            this.rbAlwaysRock1 = new System.Windows.Forms.RadioButton();
            this.rbRandAI1 = new System.Windows.Forms.RadioButton();
            this.rbHuman1 = new System.Windows.Forms.RadioButton();
            this.gbPlayer2Type = new System.Windows.Forms.GroupBox();
            this.rbAlwaysRock2 = new System.Windows.Forms.RadioButton();
            this.rbRandAI2 = new System.Windows.Forms.RadioButton();
            this.rbHuman2 = new System.Windows.Forms.RadioButton();
            this.gbNames.SuspendLayout();
            this.gbPlayer1Type.SuspendLayout();
            this.gbPlayer2Type.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNames
            // 
            this.gbNames.Controls.Add(this.tbPlayer2);
            this.gbNames.Controls.Add(this.lblPlayer2);
            this.gbNames.Controls.Add(this.lblPlayer1);
            this.gbNames.Controls.Add(this.tbPlayer1);
            this.gbNames.Location = new System.Drawing.Point(12, 12);
            this.gbNames.Name = "gbNames";
            this.gbNames.Size = new System.Drawing.Size(413, 91);
            this.gbNames.TabIndex = 0;
            this.gbNames.TabStop = false;
            this.gbNames.Text = "Names";
            // 
            // tbPlayer2
            // 
            this.tbPlayer2.Location = new System.Drawing.Point(57, 58);
            this.tbPlayer2.Name = "tbPlayer2";
            this.tbPlayer2.Size = new System.Drawing.Size(350, 20);
            this.tbPlayer2.TabIndex = 3;
            this.tbPlayer2.Text = "Player2";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(6, 61);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(45, 13);
            this.lblPlayer2.TabIndex = 2;
            this.lblPlayer2.Text = "Player2:";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(6, 26);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(45, 13);
            this.lblPlayer1.TabIndex = 1;
            this.lblPlayer1.Text = "Player1:";
            // 
            // tbPlayer1
            // 
            this.tbPlayer1.Location = new System.Drawing.Point(57, 23);
            this.tbPlayer1.Name = "tbPlayer1";
            this.tbPlayer1.Size = new System.Drawing.Size(350, 20);
            this.tbPlayer1.TabIndex = 0;
            this.tbPlayer1.Text = "Player1";
            // 
            // gbPlayer1Type
            // 
            this.gbPlayer1Type.Controls.Add(this.rbAlwaysRock1);
            this.gbPlayer1Type.Controls.Add(this.rbRandAI1);
            this.gbPlayer1Type.Controls.Add(this.rbHuman1);
            this.gbPlayer1Type.Location = new System.Drawing.Point(12, 109);
            this.gbPlayer1Type.Name = "gbPlayer1Type";
            this.gbPlayer1Type.Size = new System.Drawing.Size(200, 146);
            this.gbPlayer1Type.TabIndex = 1;
            this.gbPlayer1Type.TabStop = false;
            this.gbPlayer1Type.Text = "Player 1 Type";
            // 
            // rbAlwaysRock1
            // 
            this.rbAlwaysRock1.AutoSize = true;
            this.rbAlwaysRock1.Location = new System.Drawing.Point(9, 106);
            this.rbAlwaysRock1.Name = "rbAlwaysRock1";
            this.rbAlwaysRock1.Size = new System.Drawing.Size(84, 17);
            this.rbAlwaysRock1.TabIndex = 2;
            this.rbAlwaysRock1.TabStop = true;
            this.rbAlwaysRock1.Text = "AlwaysRock";
            this.rbAlwaysRock1.UseVisualStyleBackColor = true;
            // 
            // rbRandAI1
            // 
            this.rbRandAI1.AutoSize = true;
            this.rbRandAI1.Location = new System.Drawing.Point(9, 70);
            this.rbRandAI1.Name = "rbRandAI1";
            this.rbRandAI1.Size = new System.Drawing.Size(61, 17);
            this.rbRandAI1.TabIndex = 1;
            this.rbRandAI1.TabStop = true;
            this.rbRandAI1.Text = "RandAI";
            this.rbRandAI1.UseVisualStyleBackColor = true;
            // 
            // rbHuman1
            // 
            this.rbHuman1.AutoSize = true;
            this.rbHuman1.Checked = true;
            this.rbHuman1.Location = new System.Drawing.Point(9, 33);
            this.rbHuman1.Name = "rbHuman1";
            this.rbHuman1.Size = new System.Drawing.Size(59, 17);
            this.rbHuman1.TabIndex = 0;
            this.rbHuman1.TabStop = true;
            this.rbHuman1.Text = "Human";
            this.rbHuman1.UseVisualStyleBackColor = true;
            // 
            // gbPlayer2Type
            // 
            this.gbPlayer2Type.Controls.Add(this.rbAlwaysRock2);
            this.gbPlayer2Type.Controls.Add(this.rbRandAI2);
            this.gbPlayer2Type.Controls.Add(this.rbHuman2);
            this.gbPlayer2Type.Location = new System.Drawing.Point(225, 109);
            this.gbPlayer2Type.Name = "gbPlayer2Type";
            this.gbPlayer2Type.Size = new System.Drawing.Size(200, 146);
            this.gbPlayer2Type.TabIndex = 2;
            this.gbPlayer2Type.TabStop = false;
            this.gbPlayer2Type.Text = "Player 2 Type";
            // 
            // rbAlwaysRock2
            // 
            this.rbAlwaysRock2.AutoSize = true;
            this.rbAlwaysRock2.Location = new System.Drawing.Point(9, 106);
            this.rbAlwaysRock2.Name = "rbAlwaysRock2";
            this.rbAlwaysRock2.Size = new System.Drawing.Size(84, 17);
            this.rbAlwaysRock2.TabIndex = 2;
            this.rbAlwaysRock2.TabStop = true;
            this.rbAlwaysRock2.Text = "AlwaysRock";
            this.rbAlwaysRock2.UseVisualStyleBackColor = true;
            // 
            // rbRandAI2
            // 
            this.rbRandAI2.AutoSize = true;
            this.rbRandAI2.Checked = true;
            this.rbRandAI2.Location = new System.Drawing.Point(9, 70);
            this.rbRandAI2.Name = "rbRandAI2";
            this.rbRandAI2.Size = new System.Drawing.Size(61, 17);
            this.rbRandAI2.TabIndex = 1;
            this.rbRandAI2.TabStop = true;
            this.rbRandAI2.Text = "RandAI";
            this.rbRandAI2.UseVisualStyleBackColor = true;
            // 
            // rbHuman2
            // 
            this.rbHuman2.AutoSize = true;
            this.rbHuman2.Location = new System.Drawing.Point(9, 33);
            this.rbHuman2.Name = "rbHuman2";
            this.rbHuman2.Size = new System.Drawing.Size(59, 17);
            this.rbHuman2.TabIndex = 0;
            this.rbHuman2.Text = "Human";
            this.rbHuman2.UseVisualStyleBackColor = true;
            // 
            // RPSLSpWinformsDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 386);
            this.Controls.Add(this.gbPlayer2Type);
            this.Controls.Add(this.gbPlayer1Type);
            this.Controls.Add(this.gbNames);
            this.Name = "RPSLSpWinformsDemo";
            this.Text = "RPSLSp Winforms Demo";
            this.gbNames.ResumeLayout(false);
            this.gbNames.PerformLayout();
            this.gbPlayer1Type.ResumeLayout(false);
            this.gbPlayer1Type.PerformLayout();
            this.gbPlayer2Type.ResumeLayout(false);
            this.gbPlayer2Type.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNames;
        private System.Windows.Forms.TextBox tbPlayer1;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.TextBox tbPlayer2;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.GroupBox gbPlayer1Type;
        private System.Windows.Forms.RadioButton rbHuman1;
        private System.Windows.Forms.RadioButton rbAlwaysRock1;
        private System.Windows.Forms.RadioButton rbRandAI1;
        private System.Windows.Forms.GroupBox gbPlayer2Type;
        private System.Windows.Forms.RadioButton rbAlwaysRock2;
        private System.Windows.Forms.RadioButton rbRandAI2;
        private System.Windows.Forms.RadioButton rbHuman2;
    }
}

