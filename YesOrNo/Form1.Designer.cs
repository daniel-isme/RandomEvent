namespace YesOrNo
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
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.getAnswerButton = new System.Windows.Forms.Button();
            this.answerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messageTextBox
            // 
            this.messageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTextBox.Location = new System.Drawing.Point(126, 58);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(525, 34);
            this.messageTextBox.TabIndex = 0;
            this.messageTextBox.Click += new System.EventHandler(this.messageTextBox_Click);
            // 
            // getAnswerButton
            // 
            this.getAnswerButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.getAnswerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAnswerButton.Location = new System.Drawing.Point(308, 112);
            this.getAnswerButton.Name = "getAnswerButton";
            this.getAnswerButton.Size = new System.Drawing.Size(144, 39);
            this.getAnswerButton.TabIndex = 1;
            this.getAnswerButton.Text = "answer";
            this.getAnswerButton.UseVisualStyleBackColor = false;
            this.getAnswerButton.Click += new System.EventHandler(this.getAnswerButton_Click);
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.BackColor = System.Drawing.SystemColors.Control;
            this.answerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.answerLabel.Location = new System.Drawing.Point(292, 249);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(66, 91);
            this.answerLabel.TabIndex = 2;
            this.answerLabel.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.getAnswerButton);
            this.Controls.Add(this.messageTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button getAnswerButton;
        private System.Windows.Forms.Label answerLabel;
    }
}

