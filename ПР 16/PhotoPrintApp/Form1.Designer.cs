namespace PhotoPrintApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Освобождение ресурсов при закрытии формы
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioSize15X21 = new System.Windows.Forms.RadioButton();
            this.radioSize10X15 = new System.Windows.Forms.RadioButton();
            this.radioSize9X13 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioPaperGlossy = new System.Windows.Forms.RadioButton();
            this.radioPaperMatte = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();

            // groupBox1
            this.groupBox1.Controls.Add(this.radioSize15X21);
            this.groupBox1.Controls.Add(this.radioSize10X15);
            this.groupBox1.Controls.Add(this.radioSize9X13);
            this.groupBox1.Location = new System.Drawing.Point(30, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите размер";

            // radioSize15X21
            this.radioSize15X21.AutoSize = true;
            this.radioSize15X21.Location = new System.Drawing.Point(20, 100);
            this.radioSize15X21.Name = "radioSize15X21";
            this.radioSize15X21.Size = new System.Drawing.Size(62, 20);
            this.radioSize15X21.TabIndex = 2;
            this.radioSize15X21.TabStop = true;
            this.radioSize15X21.Text = "15x21";
            this.radioSize15X21.UseVisualStyleBackColor = true;

            // radioSize10X15
            this.radioSize10X15.AutoSize = true;
            this.radioSize10X15.Location = new System.Drawing.Point(20, 70);
            this.radioSize10X15.Name = "radioSize10X15";
            this.radioSize10X15.Size = new System.Drawing.Size(62, 20);
            this.radioSize10X15.TabIndex = 1;
            this.radioSize10X15.TabStop = true;
            this.radioSize10X15.Text = "10x15";
            this.radioSize10X15.UseVisualStyleBackColor = true;

            // radioSize9X13
            this.radioSize9X13.AutoSize = true;
            this.radioSize9X13.Location = new System.Drawing.Point(20, 40);
            this.radioSize9X13.Name = "radioSize9X13";
            this.radioSize9X13.Size = new System.Drawing.Size(55, 20);
            this.radioSize9X13.TabIndex = 0;
            this.radioSize9X13.TabStop = true;
            this.radioSize9X13.Text = "9x13";
            this.radioSize9X13.UseVisualStyleBackColor = true;

            // groupBox2
            this.groupBox2.Controls.Add(this.radioPaperGlossy);
            this.groupBox2.Controls.Add(this.radioPaperMatte);
            this.groupBox2.Location = new System.Drawing.Point(250, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выберите бумагу";

            // radioPaperGlossy
            this.radioPaperGlossy.AutoSize = true;
            this.radioPaperGlossy.Location = new System.Drawing.Point(20, 70);
            this.radioPaperGlossy.Name = "radioPaperGlossy";
            this.radioPaperGlossy.Size = new System.Drawing.Size(84, 20);
            this.radioPaperGlossy.TabIndex = 1;
            this.radioPaperGlossy.TabStop = true;
            this.radioPaperGlossy.Text = "Глянцевая";
            this.radioPaperGlossy.UseVisualStyleBackColor = true;

            // radioPaperMatte
            this.radioPaperMatte.AutoSize = true;
            this.radioPaperMatte.Location = new System.Drawing.Point(20, 40);
            this.radioPaperMatte.Name = "radioPaperMatte";
            this.radioPaperMatte.Size = new System.Drawing.Size(79, 20);
            this.radioPaperMatte.TabIndex = 0;
            this.radioPaperMatte.TabStop = true;
            this.radioPaperMatte.Text = "Матовая";
            this.radioPaperMatte.UseVisualStyleBackColor = true;

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество:";

            // textBoxQuantity
            this.textBoxQuantity.Location = new System.Drawing.Point(120, 197);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 22);
            this.textBoxQuantity.TabIndex = 3;

            // buttonOK
            this.buttonOK.Location = new System.Drawing.Point(240, 197);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;

            // labelResult
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelResult.Location = new System.Drawing.Point(30, 250);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 17);
            this.labelResult.TabIndex = 5;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Фото-2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioSize15X21;
        private System.Windows.Forms.RadioButton radioSize10X15;
        private System.Windows.Forms.RadioButton radioSize9X13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioPaperGlossy;
        private System.Windows.Forms.RadioButton radioPaperMatte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelResult;
    }
}