using System;
using System.Drawing;
using System.Windows.Forms;

namespace Equipment
{
    public partial class Form1 : Form
    {
        // Базовая цена автомобиля
        private int basePrice = 1000000;

        public Form1()
        {
            InitializeComponent();

            // Привязываем обработчик для кнопки
            this.btnCalculate.Click += new EventHandler(BtnCalculate_Click);

            // Показываем начальную цену (базовую)
            lblPrice.Text = $"Базовая цена: {basePrice:N0} руб.";
        }

        // Обработчик для кнопки "Рассчитать цену"
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        // Метод для расчёта цены
        private void CalculatePrice()
        {
            int totalPrice = basePrice;

           
            if (chkAbs.Checked)
                totalPrice += 50000;      // ABS +50 000

            if (chkConditioner.Checked)
                totalPrice += 80000;      // Кондиционер +80 000

            if (chkSunroof.Checked)
                totalPrice += 70000;      // Люк +70 000

            if (chkHeating.Checked)
                totalPrice += 30000;      // Подогрев +30 000

            // Выводим итоговую цену
            lblPrice.Text = $"Итоговая цена: {totalPrice:N0} руб.";
        }
    }
}