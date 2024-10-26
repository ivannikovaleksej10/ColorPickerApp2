namespace ColorPickerApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pickColorButton = new Button();
            defaultColorButton = new Button();
            SuspendLayout();
            // 
            // pickColorButton
            // 
            pickColorButton.Location = new Point(20, 14);
            pickColorButton.Name = "pickColorButton";
            pickColorButton.Size = new Size(113, 23);
            pickColorButton.TabIndex = 0;
            pickColorButton.Text = "Выбрать цвет";
            pickColorButton.UseVisualStyleBackColor = true;
            pickColorButton.Click += pickColorButton_Click;
            // 
            // defaultColorButton
            // 
            defaultColorButton.Location = new Point(14, 43);
            defaultColorButton.Name = "defaultColorButton";
            defaultColorButton.Size = new Size(125, 23);
            defaultColorButton.TabIndex = 1;
            defaultColorButton.Text = "Вернуть к дефолту";
            defaultColorButton.UseVisualStyleBackColor = true;
            defaultColorButton.Click += defaultColorButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(153, 81);
            Controls.Add(defaultColorButton);
            Controls.Add(pickColorButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "ColorPicker";
            ResumeLayout(false);
        }

        #endregion

        private Button pickColorButton;
        private Button defaultColorButton;
    }
}
