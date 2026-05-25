namespace ZhalyuziApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Элементы управления
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblCm1;
        private System.Windows.Forms.Label lblCm2;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblCm1 = new System.Windows.Forms.Label();
            this.lblCm2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Заголовок
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(100, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Расчет жалюзи";

            // Метка "Материал"
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(40, 70);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(61, 17);
            this.lblMaterial.TabIndex = 1;
            this.lblMaterial.Text = "Материал:";

            // ComboBox
            this.comboBoxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterial.Location = new System.Drawing.Point(120, 67);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(150, 24);
            this.comboBoxMaterial.TabIndex = 2;

            // Метка "Ширина"
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(40, 110);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(69, 17);
            this.lblWidth.TabIndex = 3;
            this.lblWidth.Text = "Ширина (см):";

            // Поле ввода ширины
            this.txtWidth.Location = new System.Drawing.Point(120, 107);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 22);
            this.txtWidth.TabIndex = 4;

            // Метка "см" после ширины
            this.lblCm1.AutoSize = true;
            this.lblCm1.Location = new System.Drawing.Point(226, 110);
            this.lblCm1.Name = "lblCm1";
            this.lblCm1.Size = new System.Drawing.Size(28, 17);
            this.lblCm1.TabIndex = 5;
            this.lblCm1.Text = "см";

            // Метка "Высота"
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(40, 150);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(72, 17);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Высота (см):";

            // Поле ввода высоты
            this.txtHeight.Location = new System.Drawing.Point(120, 147);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 22);
            this.txtHeight.TabIndex = 7;

            // Метка "см" после высоты
            this.lblCm2.AutoSize = true;
            this.lblCm2.Location = new System.Drawing.Point(226, 150);
            this.lblCm2.Name = "lblCm2";
            this.lblCm2.Size = new System.Drawing.Size(28, 17);
            this.lblCm2.TabIndex = 8;
            this.lblCm2.Text = "см";

            // Кнопка
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(120, 200);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 35);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Рассчитать";
            this.btnOk.UseVisualStyleBackColor = true;

            // Подключение обработчиков событий
            this.comboBoxMaterial.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaterial_SelectedIndexChanged);
            this.txtWidth.TextChanged += new System.EventHandler(this.TextFields_TextChanged);
            this.txtHeight.TextChanged += new System.EventHandler(this.TextFields_TextChanged);
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);

            // Настройка формы
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 270);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblCm2);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblCm1);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Жалюзи";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}