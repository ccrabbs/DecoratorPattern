namespace DecoratorPattern
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
            this.DecoratorTest = new System.Windows.Forms.Button();
            this.btnDecoratorByDerivation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // DecoratorTest
            this.DecoratorTest.Location = new System.Drawing.Point(97, 112);
            this.DecoratorTest.Name = "DecoratorTest";
            this.DecoratorTest.Size = new System.Drawing.Size(95, 23);
            this.DecoratorTest.TabIndex = 0;
            this.DecoratorTest.Text = "DecoratorTest";
            this.DecoratorTest.UseVisualStyleBackColor = true;
            this.DecoratorTest.Click += new System.EventHandler(this.button1_Click);
            // btnDecoratorByDerivation
            this.btnDecoratorByDerivation.Location = new System.Drawing.Point(48, 53);
            this.btnDecoratorByDerivation.Name = "btnDecoratorByDerivation";
            this.btnDecoratorByDerivation.Size = new System.Drawing.Size(162, 23);
            this.btnDecoratorByDerivation.TabIndex = 1;
            this.btnDecoratorByDerivation.Text = "Decorator By Derivation";
            this.btnDecoratorByDerivation.UseVisualStyleBackColor = true;
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnDecoratorByDerivation);
            this.Controls.Add(this.DecoratorTest);
            this.Name = "Form1";
            this.Text = "DecotratorTest";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button DecoratorTest;
        private System.Windows.Forms.Button btnDecoratorByDerivation;
    }
}
