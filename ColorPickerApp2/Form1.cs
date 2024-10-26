using Microsoft.Win32;

namespace ColorPickerApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pickColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;
                    try
                    {
                        // Обновление первого ключа реестра
                        using (RegistryKey key1 = Registry.CurrentUser.OpenSubKey(@"Control Panel\Colors", true))
                        {
                            if (key1 != null)
                            {
                                key1.SetValue("Highlight", $"{selectedColor.R} {selectedColor.G} {selectedColor.B}");
                                key1.SetValue("HotTrackingColor", $"{selectedColor.R} {selectedColor.G} {selectedColor.B}");
                                MessageBox.Show("Цвет выделения и HotTrackingColor для ключа Colors сохранены!");
                            }
                            else
                            {
                                MessageBox.Show("Невозможно открыть ключ реестра Colors.");
                            }
                        }

                        // Обновление второго ключа реестра
                        using (RegistryKey key2 = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop\Colors", true))
                        {
                            if (key2 != null)
                            {
                                key2.SetValue("Highlight", $"{selectedColor.R} {selectedColor.G} {selectedColor.B}");
                                key2.SetValue("Hilight", $"{selectedColor.R} {selectedColor.G} {selectedColor.B}");
                                key2.SetValue("HotTrackingColor", $"{selectedColor.R} {selectedColor.G} {selectedColor.B}");
                                MessageBox.Show("Цвет выделения и HotTrackingColor для ключа Desktop\\Colors сохранены!");
                            }
                            else
                            {
                                MessageBox.Show("Невозможно открыть ключ реестра Desktop\\Colors.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex.Message}");
                    }
                }
            }
        }

        private void defaultColorButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Сброс для первого ключа реестра
                using (RegistryKey key1 = Registry.CurrentUser.OpenSubKey(@"Control Panel\Colors", true))
                {
                    if (key1 != null)
                    {
                        key1.SetValue("Highlight", "10 36 106"); // Дефолтный цвет
                        key1.SetValue("HotTrackingColor", "0 0 128"); // Дефолтный цвет
                        MessageBox.Show("Настройки для ключа Colors сброшены к дефолту!");
                    }
                    else
                    {
                        MessageBox.Show("Невозможно открыть ключ реестра Colors.");
                    }
                }

                // Сброс для второго ключа реестра
                using (RegistryKey key2 = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop\Colors", true))
                {
                    if (key2 != null)
                    {
                        key2.SetValue("Highlight", "10 36 106"); // Дефолтный цвет
                        key2.SetValue("Hilight", "10 36 106"); // Дефолтный цвет
                        key2.SetValue("HotTrackingColor", "0 0 128"); // Дефолтный цвет
                        MessageBox.Show("Настройки для ключа Desktop\\Colors сброшены к дефолту!");
                    }
                    else
                    {
                        MessageBox.Show("Невозможно открыть ключ реестра Desktop\\Colors.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
