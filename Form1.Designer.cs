using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private async Task InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dolgota = new System.Windows.Forms.TextBox();
            this.lonBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.degrees = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.feelslike = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.windSpeed = new System.Windows.Forms.Label();
            this.place = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dolgota
            // 
            this.dolgota.Location = new System.Drawing.Point(99, 50);
            this.dolgota.Name = "dolgota";
            this.dolgota.Size = new System.Drawing.Size(100, 20);
            this.dolgota.TabIndex = 0;
            this.dolgota.Text = "52,37125";
            // 
            // lonBox
            // 
            this.lonBox.Location = new System.Drawing.Point(256, 50);
            this.lonBox.Name = "lonBox";
            this.lonBox.Size = new System.Drawing.Size(100, 20);
            this.lonBox.TabIndex = 1;
            this.lonBox.Text = "4,89388";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Показать погоду";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // degrees
            // 
            this.degrees.AutoSize = true;
            this.degrees.Location = new System.Drawing.Point(99, 69);
            this.degrees.Name = "degrees";
            this.degrees.Size = new System.Drawing.Size(0, 13);
            this.degrees.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Широта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Долгота";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите координаты места!";
            // 
            // feelslike
            // 
            this.feelslike.AutoSize = true;
            this.feelslike.Location = new System.Drawing.Point(99, 95);
            this.feelslike.Name = "feelslike";
            this.feelslike.Size = new System.Drawing.Size(0, 13);
            this.feelslike.TabIndex = 7;
            // 
            // windSpeed
            // 
            this.windSpeed.AutoSize = true;
            this.windSpeed.Location = new System.Drawing.Point(96, 119);
            this.windSpeed.Name = "windSpeed";
            this.windSpeed.Size = new System.Drawing.Size(0, 13);
            this.windSpeed.TabIndex = 8;
            // 
            // place
            // 
            this.place.AutoSize = true;
            this.place.Location = new System.Drawing.Point(43, 22);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(0, 13);
            this.place.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 189);
            this.Controls.Add(this.place);
            this.Controls.Add(this.windSpeed);
            this.Controls.Add(this.feelslike);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.degrees);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lonBox);
            this.Controls.Add(this.dolgota);
            this.Name = "Form1";
            this.Text = "Прогноз погоды!";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dolgota;
        private System.Windows.Forms.TextBox lonBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label degrees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label feelslike;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label windSpeed;
        private System.Windows.Forms.Label place;
    }
}

