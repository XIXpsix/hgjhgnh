using System;
using System.Windows.Forms;

namespace ZhalyuziApp
{
    public partial class Form1 : Form
    {
        // Конструктор формы
        public Form1()
        {
            InitializeComponent();      // Создание элементов формы
            InitializeComboBox();       // Заполнение списка материалов
        }

        // Метод заполнения списка материалов
        private void InitializeComboBox()
        {
            // Добавление материалов
            comboBoxMaterial.Items.Add("пластик");
            comboBoxMaterial.Items.Add("алюминий");
            comboBoxMaterial.Items.Add("соломка");
            comboBoxMaterial.Items.Add("текстиль");
            comboBoxMaterial.Items.Add("бамбук");

            // Сортировка по алфавиту
            comboBoxMaterial.Sorted = true;

            // Ничего не выбрано
            comboBoxMaterial.SelectedIndex = -1;
        }

        // Обработчик кнопки "Рассчитать"
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем выбранный материал
                string material = comboBoxMaterial.SelectedItem?.ToString();

                // Получаем размеры
                string widthText = txtWidth.Text;
                string heightText = txtHeight.Text;

                // Проверяем заполнение полей
                if (string.IsNullOrEmpty(material) ||
                    string.IsNullOrEmpty(widthText) ||
                    string.IsNullOrEmpty(heightText))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Преобразуем в числа
                if (!double.TryParse(widthText, out double width) || width <= 0)
                {
                    MessageBox.Show("Введите корректную ширину!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!double.TryParse(heightText, out double height) || height <= 0)
                {
                    MessageBox.Show("Введите корректную высоту!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Получаем цену за материал
                double price = GetPrice(material);

                // Расчет площади в м²
                double area = (width * height) / 10000;

                // Расчет стоимости
                double total = area * price;

                // Вывод результата
                MessageBox.Show(
                    $"Материал: {material}\n" +
                    $"Размеры: {width} x {height} см\n" +
                    $"Площадь: {area:F2} м²\n" +
                    $"Цена за м²: {price:F2} руб.\n" +
                    $"Стоимость: {total:F2} руб.",
                    "Результат расчета",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод определения цены по материалу
        private double GetPrice(string material)
        {
            switch (material.ToLower())
            {
                case "пластик": return 500;
                case "алюминий": return 800;
                case "соломка": return 700;
                case "текстиль": return 600;
                case "бамбук": return 900;
                default: return 0;
            }
        }

        // Обработчик изменения текста в полях
        private void TextFields_TextChanged(object sender, EventArgs e)
        {
            // Кнопка активна, если выбран материал и оба поля заполнены
            btnOk.Enabled = (comboBoxMaterial.SelectedIndex != -1) &&
                            !string.IsNullOrEmpty(txtWidth.Text) &&
                            !string.IsNullOrEmpty(txtHeight.Text);
        }

        // Обработчик выбора материала
        private void comboBoxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextFields_TextChanged(sender, e);
        }
    }
}