namespace Equipment
{
    partial class Form1
    {
        /// Обязательная переменная конструктора.
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

        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        private void InitializeComponent()
        {
            this.chkAbs = new System.Windows.Forms.CheckBox();
            this.chkConditioner = new System.Windows.Forms.CheckBox();
            this.chkSunroof = new System.Windows.Forms.CheckBox();
            this.chkHeating = new System.Windows.Forms.CheckBox();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.SuspendLayout();
            
            // chkAbs
            this.chkAbs.AutoSize = true;
            this.chkAbs.Location = new System.Drawing.Point(49, 47);
            this.chkAbs.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.chkAbs.Name = "chkAbs";
            this.chkAbs.Size = new System.Drawing.Size(78, 29);
            this.chkAbs.TabIndex = 0;
            this.chkAbs.Text = "ABS";
            this.chkAbs.UseVisualStyleBackColor = true;
           
            // chkConditioner
            this.chkConditioner.AutoSize = true;
            this.chkConditioner.Location = new System.Drawing.Point(49, 94);
            this.chkConditioner.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.chkConditioner.Name = "chkConditioner";
            this.chkConditioner.Size = new System.Drawing.Size(169, 29);
            this.chkConditioner.TabIndex = 1;
            this.chkConditioner.Text = "Кондиционер";
            this.chkConditioner.UseVisualStyleBackColor = true;
            
            // chkSunroof
            this.chkSunroof.AutoSize = true;
            this.chkSunroof.Location = new System.Drawing.Point(49, 141);
            this.chkSunroof.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.chkSunroof.Name = "chkSunroof";
            this.chkSunroof.Size = new System.Drawing.Size(77, 29);
            this.chkSunroof.TabIndex = 2;
            this.chkSunroof.Text = "Люк";
            this.chkSunroof.UseVisualStyleBackColor = true;
         
            // chkHeating
            this.chkHeating.AutoSize = true;
            this.chkHeating.Location = new System.Drawing.Point(49, 188);
            this.chkHeating.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.chkHeating.Name = "chkHeating";
            this.chkHeating.Size = new System.Drawing.Size(220, 29);
            this.chkHeating.TabIndex = 3;
            this.chkHeating.Text = "Подогрев сидений";
            this.chkHeating.UseVisualStyleBackColor = true;
           
            // pictureBoxCar
            this.pictureBoxCar.Image = global::Equipment.Properties.Resources.Car;
            this.pictureBoxCar.Location = new System.Drawing.Point(318, 42);
            this.pictureBoxCar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(406, 234);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar.TabIndex = 4;
            this.pictureBoxCar.TabStop = false;
            
            // lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(49, 281);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(303, 25);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Базовая цена: 1 000 000 руб.";
            
            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(66, 332);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(275, 43);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Расчитать цену";
            this.btnCalculate.UseVisualStyleBackColor = true;
            
            // Form1 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 703);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.pictureBoxCar);
            this.Controls.Add(this.chkHeating);
            this.Controls.Add(this.chkSunroof);
            this.Controls.Add(this.chkConditioner);
            this.Controls.Add(this.chkAbs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAbs;
        private System.Windows.Forms.CheckBox chkConditioner;
        private System.Windows.Forms.CheckBox chkSunroof;
        private System.Windows.Forms.CheckBox chkHeating;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnCalculate;
    }
}

