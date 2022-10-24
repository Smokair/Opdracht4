namespace Opdracht4
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox_Time = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Titel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_Info = new System.Windows.Forms.TextBox();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(360, 215);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 37);
            this.button4.TabIndex = 21;
            this.button4.Text = "Zet Achteraan";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(360, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 37);
            this.button3.TabIndex = 20;
            this.button3.Text = "Taak is afgewerkt";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 37);
            this.button2.TabIndex = 19;
            this.button2.Text = "Volgende Taak";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 18;
            this.button1.Text = "Taak Toevoegen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox_Time
            // 
            this.checkBox_Time.AutoSize = true;
            this.checkBox_Time.Location = new System.Drawing.Point(124, 320);
            this.checkBox_Time.Name = "checkBox_Time";
            this.checkBox_Time.Size = new System.Drawing.Size(45, 19);
            this.checkBox_Time.TabIndex = 17;
            this.checkBox_Time.Text = "Tijd";
            this.checkBox_Time.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tijd:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Informatie:";
            // 
            // Titel
            // 
            this.Titel.AutoSize = true;
            this.Titel.Location = new System.Drawing.Point(56, 84);
            this.Titel.Name = "Titel";
            this.Titel.Size = new System.Drawing.Size(32, 15);
            this.Titel.TabIndex = 14;
            this.Titel.Text = "Titel:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 291);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // textBox_Info
            // 
            this.textBox_Info.Location = new System.Drawing.Point(124, 129);
            this.textBox_Info.Multiline = true;
            this.textBox_Info.Name = "textBox_Info";
            this.textBox_Info.Size = new System.Drawing.Size(200, 142);
            this.textBox_Info.TabIndex = 12;
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(124, 84);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(200, 23);
            this.textBox_Title.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox_Time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Titel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_Info);
            this.Controls.Add(this.textBox_Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private CheckBox checkBox_Time;
        private Label label1;
        private Label label2;
        private Label Titel;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox_Info;
        private TextBox textBox_Title;
    }
}