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
                        // ���������� ������� ����� �������
                        using (RegistryKey key1 = Registry.CurrentUser.OpenSubKey(@"Control Panel\Colors", true))
                        {
                            if (key1 != null)
                            {
                                key1.SetValue("Highlight", $"{selectedColor.R} {selectedColor.G} {selectedColor.B}");
                                key1.SetValue("HotTrackingColor", $"{selectedColor.R} {selectedColor.G} {selectedColor.B}");
                                MessageBox.Show("���� ��������� � HotTrackingColor ��� ����� Colors ���������!");
                            }
                            else
                            {
                                MessageBox.Show("���������� ������� ���� ������� Colors.");
                            }
                        }

                        // ���������� ������� ����� �������
                        using (RegistryKey key2 = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop\Colors", true))
                        {
                            if (key2 != null)
                            {
                                key2.SetValue("Highlight", $"{selectedColor.R} {selectedColor.G} {selectedColor.B}");
                                key2.SetValue("Hilight", $"{selectedColor.R} {selectedColor.G} {selectedColor.B}");
                                key2.SetValue("HotTrackingColor", $"{selectedColor.R} {selectedColor.G} {selectedColor.B}");
                                MessageBox.Show("���� ��������� � HotTrackingColor ��� ����� Desktop\\Colors ���������!");
                            }
                            else
                            {
                                MessageBox.Show("���������� ������� ���� ������� Desktop\\Colors.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"������: {ex.Message}");
                    }
                }
            }
        }

        private void defaultColorButton_Click(object sender, EventArgs e)
        {
            try
            {
                // ����� ��� ������� ����� �������
                using (RegistryKey key1 = Registry.CurrentUser.OpenSubKey(@"Control Panel\Colors", true))
                {
                    if (key1 != null)
                    {
                        key1.SetValue("Highlight", "10 36 106"); // ��������� ����
                        key1.SetValue("HotTrackingColor", "0 0 128"); // ��������� ����
                        MessageBox.Show("��������� ��� ����� Colors �������� � �������!");
                    }
                    else
                    {
                        MessageBox.Show("���������� ������� ���� ������� Colors.");
                    }
                }

                // ����� ��� ������� ����� �������
                using (RegistryKey key2 = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop\Colors", true))
                {
                    if (key2 != null)
                    {
                        key2.SetValue("Highlight", "10 36 106"); // ��������� ����
                        key2.SetValue("Hilight", "10 36 106"); // ��������� ����
                        key2.SetValue("HotTrackingColor", "0 0 128"); // ��������� ����
                        MessageBox.Show("��������� ��� ����� Desktop\\Colors �������� � �������!");
                    }
                    else
                    {
                        MessageBox.Show("���������� ������� ���� ������� Desktop\\Colors.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������: {ex.Message}");
            }
        }
    }
}
