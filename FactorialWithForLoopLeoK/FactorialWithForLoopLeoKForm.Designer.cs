namespace FactorialWithForLoopLeoK
{
    partial class frmFactorialWithForLoopLeoK
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
            this.nudNum = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lstFacNum = new System.Windows.Forms.ListBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNum
            // 
            this.nudNum.Location = new System.Drawing.Point(114, 23);
            this.nudNum.Name = "nudNum";
            this.nudNum.Size = new System.Drawing.Size(72, 20);
            this.nudNum.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(94, 49);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(110, 35);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lstFacNum
            // 
            this.lstFacNum.FormattingEnabled = true;
            this.lstFacNum.Location = new System.Drawing.Point(68, 90);
            this.lstFacNum.Name = "lstFacNum";
            this.lstFacNum.Size = new System.Drawing.Size(167, 121);
            this.lstFacNum.TabIndex = 2;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(100, 229);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 24);
            this.lblAnswer.TabIndex = 3;
            // 
            // frmFactorialWithForLoopLeoK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 279);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lstFacNum);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.nudNum);
            this.Name = "frmFactorialWithForLoopLeoK";
            this.Text = "Factorial With For Loop by Leo Kay";
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudNum;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox lstFacNum;
        private System.Windows.Forms.Label lblAnswer;
    }
}

