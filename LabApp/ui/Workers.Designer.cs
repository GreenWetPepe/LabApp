namespace LabApp
{
    partial class Workers
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
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.patronymicsTB = new System.Windows.Forms.TextBox();
            this.jobTitleTB = new System.Windows.Forms.TextBox();
            this.employmentDateTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TableLV = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить работника";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(59, 422);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(78, 16);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "StatusLabel";
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(41, 45);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(257, 22);
            this.idTB.TabIndex = 2;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(41, 98);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(257, 22);
            this.lastNameTB.TabIndex = 3;
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(41, 151);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(257, 22);
            this.firstNameTB.TabIndex = 4;
            // 
            // patronymicsTB
            // 
            this.patronymicsTB.Location = new System.Drawing.Point(41, 205);
            this.patronymicsTB.Name = "patronymicsTB";
            this.patronymicsTB.Size = new System.Drawing.Size(257, 22);
            this.patronymicsTB.TabIndex = 5;
            // 
            // jobTitleTB
            // 
            this.jobTitleTB.Location = new System.Drawing.Point(41, 258);
            this.jobTitleTB.Name = "jobTitleTB";
            this.jobTitleTB.Size = new System.Drawing.Size(257, 22);
            this.jobTitleTB.TabIndex = 6;
            // 
            // employmentDateTB
            // 
            this.employmentDateTB.Location = new System.Drawing.Point(41, 311);
            this.employmentDateTB.Name = "employmentDateTB";
            this.employmentDateTB.Size = new System.Drawing.Size(257, 22);
            this.employmentDateTB.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id работника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Фамилия работника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Имя работника";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Отчество работника";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Должность работника";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Дата принятия на работу";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Результат запроса";
            // 
            // TableLV
            // 
            this.TableLV.HideSelection = false;
            this.TableLV.Location = new System.Drawing.Point(411, 45);
            this.TableLV.Name = "TableLV";
            this.TableLV.Size = new System.Drawing.Size(854, 288);
            this.TableLV.TabIndex = 16;
            this.TableLV.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(411, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 67);
            this.button2.TabIndex = 17;
            this.button2.Text = "Вывести таблицу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(1264, 18);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(26, 23);
            this.menuButton.TabIndex = 72;
            this.menuButton.Text = "X";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 450);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TableLV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employmentDateTB);
            this.Controls.Add(this.jobTitleTB);
            this.Controls.Add(this.patronymicsTB);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.TextBox patronymicsTB;
        private System.Windows.Forms.TextBox jobTitleTB;
        private System.Windows.Forms.TextBox employmentDateTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView TableLV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button menuButton;
    }
}

