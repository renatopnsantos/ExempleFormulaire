namespace ExempleFormulaire
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PrenomTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.CourrielTextBox = new System.Windows.Forms.TextBox();
            this.MessagemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agê";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Courriel";
            // 
            // PrenomTextBox
            // 
            this.PrenomTextBox.Location = new System.Drawing.Point(150, 56);
            this.PrenomTextBox.Name = "PrenomTextBox";
            this.PrenomTextBox.Size = new System.Drawing.Size(229, 23);
            this.PrenomTextBox.TabIndex = 3;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(150, 85);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(57, 23);
            this.AgeTextBox.TabIndex = 4;
            // 
            // CourrielTextBox
            // 
            this.CourrielTextBox.Location = new System.Drawing.Point(150, 115);
            this.CourrielTextBox.Name = "CourrielTextBox";
            this.CourrielTextBox.Size = new System.Drawing.Size(229, 23);
            this.CourrielTextBox.TabIndex = 5;
            // 
            // MessagemButton
            // 
            this.MessagemButton.Location = new System.Drawing.Point(304, 177);
            this.MessagemButton.Name = "MessagemButton";
            this.MessagemButton.Size = new System.Drawing.Size(75, 23);
            this.MessagemButton.TabIndex = 6;
            this.MessagemButton.Text = "Message";
            this.MessagemButton.UseVisualStyleBackColor = true;
            this.MessagemButton.Click += new System.EventHandler(this.MessagemButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 239);
            this.Controls.Add(this.MessagemButton);
            this.Controls.Add(this.CourrielTextBox);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.PrenomTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ExempleFormulaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox PrenomTextBox;
        private TextBox AgeTextBox;
        private TextBox CourrielTextBox;
        private Button MessagemButton;
    }
}