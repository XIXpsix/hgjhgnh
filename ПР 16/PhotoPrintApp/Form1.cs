using System;
using System.Windows.Forms;

namespace PhotoPrintApp
{
    public partial class Form1 : Form
    {
        // Константы с ценами
        private const decimal PRICE_9x13 = 5.0m;
        private const decimal PRICE_10x15 = 8.0m;
        private const decimal PRICE_15x21 = 12.0m;
        private const decimal SURCHARGE_MATTE = 2.0m;
        private const decimal SURCHARGE_GLOSSY = 3.0m;

        private decimal currentSizePrice = 0m;
        private decimal currentPaperSurcharge = 0m;

        public Form1()
        {
            InitializeComponent();

            // Подключаем обработчики событий для всех RadioButton
            radioSize9X13.Click += AnyRadioButton_Click;
            radioSize10X15.Click += AnyRadioButton_Click;
            radioSize15X21.Click += AnyRadioButton_Click;
            radioPaperMatte.Click += AnyRadioButton_Click;
            radioPaperGlossy.Click += AnyRadioButton_Click;

            // Подключаем обработчики для TextBox
            textBoxQuantity.Enter += TextBoxQuantity_Enter;
            textBoxQuantity.KeyPress += TextBoxQuantity_KeyPress;

            // Подключаем обработчик для кнопки OK
            buttonOK.Click += ButtonOK_Click;
        }

        // Общий обработчик для всех RadioButton
        private void AnyRadioButton_Click(object sender, EventArgs e)
        {
            labelResult.Text = "";
            textBoxQuantity.Focus();
            textBoxQuantity.SelectAll();
        }

        // Обработчик кнопки OK
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            // Проверка выбора размера
            if (radioSize9X13.Checked)
                currentSizePrice = PRICE_9x13;
            else if (radioSize10X15.Checked)
                currentSizePrice = PRICE_10x15;
            else if (radioSize15X21.Checked)
                currentSizePrice = PRICE_15x21;
            else
            {
                MessageBox.Show("Выберите РАЗМЕР фотографии!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка выбора бумаги
            if (radioPaperMatte.Checked)
                currentPaperSurcharge = SURCHARGE_MATTE;
            else if (radioPaperGlossy.Checked)
                currentPaperSurcharge = SURCHARGE_GLOSSY;
            else
            {
                MessageBox.Show("Выберите ТИП БУМАГИ!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка количества
            if (!int.TryParse(textBoxQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Введите целое положительное число!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxQuantity.Text = "";
                textBoxQuantity.Focus();
                return;
            }

            // Расчёт стоимости
            decimal pricePerPhoto = currentSizePrice + currentPaperSurcharge;
            decimal totalCost = pricePerPhoto * quantity;

            // Вывод результата в рублях
            string resultText = $"Стоимость заказа: {totalCost:F2} руб.\n" +
                               $"Размер: {GetSizeText()} ({currentSizePrice:F2} руб.)\n" +
                               $"Бумага: {GetPaperText()} (+{currentPaperSurcharge:F2} руб.)\n" +
                               $"Количество: {quantity} шт.\n" +
                               $"Цена за 1 фото: {pricePerPhoto:F2} руб.";

            labelResult.Text = resultText;
        }

        // Получить текст размера
        private string GetSizeText()
        {
            if (radioSize9X13.Checked) return "9x13";
            if (radioSize10X15.Checked) return "10x15";
            if (radioSize15X21.Checked) return "15x21";
            return "не выбран";
        }

        // Получить текст бумаги
        private string GetPaperText()
        {
            if (radioPaperMatte.Checked) return "матовая";
            if (radioPaperGlossy.Checked) return "глянцевая";
            return "не выбрана";
        }

        // Очистка результата при входе в поле количества
        private void TextBoxQuantity_Enter(object sender, EventArgs e)
        {
            labelResult.Text = "";
        }

        // Обработка нажатия Enter в поле количества
        private void TextBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ButtonOK_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}