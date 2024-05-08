namespace areaCalc
{
    partial class Form2
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
            this.squareRadio = new System.Windows.Forms.RadioButton();
            this.triangleRadio = new System.Windows.Forms.RadioButton();
            this.inputLength = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // squareRadio
            // 
            this.squareRadio.AutoSize = true;
            this.squareRadio.Location = new System.Drawing.Point(263, 193);
            this.squareRadio.Name = "squareRadio";
            this.squareRadio.Size = new System.Drawing.Size(59, 16);
            this.squareRadio.TabIndex = 0;
            this.squareRadio.TabStop = true;
            this.squareRadio.Text = "四角形";
            this.squareRadio.UseVisualStyleBackColor = true;
            // 
            // triangleRadio
            // 
            this.triangleRadio.AutoSize = true;
            this.triangleRadio.Location = new System.Drawing.Point(411, 193);
            this.triangleRadio.Name = "triangleRadio";
            this.triangleRadio.Size = new System.Drawing.Size(59, 16);
            this.triangleRadio.TabIndex = 1;
            this.triangleRadio.TabStop = true;
            this.triangleRadio.Text = "三角形";
            this.triangleRadio.UseVisualStyleBackColor = true;
            // 
            // inputLength
            // 
            this.inputLength.Location = new System.Drawing.Point(294, 227);
            this.inputLength.Name = "inputLength";
            this.inputLength.Size = new System.Drawing.Size(127, 19);
            this.inputLength.TabIndex = 2;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(263, 314);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 3;
            this.calcButton.Text = "計算";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(371, 314);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "キャンセル";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.inputLength);
            this.Controls.Add(this.triangleRadio);
            this.Controls.Add(this.squareRadio);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton squareRadio;
        private System.Windows.Forms.RadioButton triangleRadio;
        private System.Windows.Forms.TextBox inputLength;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button cancelButton;
    }
}