namespace LabApp
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.TableLV = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.organizationIdTB = new System.Windows.Forms.TextBox();
            this.typeTB = new System.Windows.Forms.TextBox();
            this.summaryTB = new System.Windows.Forms.TextBox();
            this.registrationDateTB = new System.Windows.Forms.TextBox();
            this.idTB = new System.Windows.Forms.TextBox();
            this.dCodeTB = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.employeeIdTB = new System.Windows.Forms.TextBox();
            this.menuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(398, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 67);
            this.button2.TabIndex = 51;
            this.button2.Text = "Вывести таблицу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TableLV
            // 
            this.TableLV.HideSelection = false;
            this.TableLV.Location = new System.Drawing.Point(398, 39);
            this.TableLV.Name = "TableLV";
            this.TableLV.Size = new System.Drawing.Size(854, 348);
            this.TableLV.TabIndex = 50;
            this.TableLV.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 16);
            this.label7.TabIndex = 49;
            this.label7.Text = "Результат запроса";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 48;
            this.label6.Text = "Id организации";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "Тип документа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Описание документа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Дата регистрации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Id документа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Код документа";
            // 
            // organizationIdTB
            // 
            this.organizationIdTB.Location = new System.Drawing.Point(28, 305);
            this.organizationIdTB.Name = "organizationIdTB";
            this.organizationIdTB.Size = new System.Drawing.Size(257, 22);
            this.organizationIdTB.TabIndex = 42;
            // 
            // typeTB
            // 
            this.typeTB.Location = new System.Drawing.Point(28, 252);
            this.typeTB.Name = "typeTB";
            this.typeTB.Size = new System.Drawing.Size(257, 22);
            this.typeTB.TabIndex = 41;
            // 
            // summaryTB
            // 
            this.summaryTB.Location = new System.Drawing.Point(28, 199);
            this.summaryTB.Name = "summaryTB";
            this.summaryTB.Size = new System.Drawing.Size(257, 22);
            this.summaryTB.TabIndex = 40;
            // 
            // registrationDateTB
            // 
            this.registrationDateTB.Location = new System.Drawing.Point(28, 145);
            this.registrationDateTB.Name = "registrationDateTB";
            this.registrationDateTB.Size = new System.Drawing.Size(257, 22);
            this.registrationDateTB.TabIndex = 39;
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(28, 92);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(257, 22);
            this.idTB.TabIndex = 38;
            // 
            // dCodeTB
            // 
            this.dCodeTB.Location = new System.Drawing.Point(28, 39);
            this.dCodeTB.Name = "dCodeTB";
            this.dCodeTB.Size = new System.Drawing.Size(257, 22);
            this.dCodeTB.TabIndex = 37;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(25, 487);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(78, 16);
            this.statusLabel.TabIndex = 36;
            this.statusLabel.Text = "StatusLabel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 67);
            this.button1.TabIndex = 35;
            this.button1.Text = "Добавить документ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 53;
            this.label8.Text = "Id работника";
            // 
            // employeeIdTB
            // 
            this.employeeIdTB.Location = new System.Drawing.Point(28, 365);
            this.employeeIdTB.Name = "employeeIdTB";
            this.employeeIdTB.Size = new System.Drawing.Size(257, 22);
            this.employeeIdTB.TabIndex = 52;
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(1265, 17);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(26, 23);
            this.menuButton.TabIndex = 72;
            this.menuButton.Text = "X";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 521);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.employeeIdTB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TableLV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.organizationIdTB);
            this.Controls.Add(this.typeTB);
            this.Controls.Add(this.summaryTB);
            this.Controls.Add(this.registrationDateTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.dCodeTB);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView TableLV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox organizationIdTB;
        private System.Windows.Forms.TextBox typeTB;
        private System.Windows.Forms.TextBox summaryTB;
        private System.Windows.Forms.TextBox registrationDateTB;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox dCodeTB;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox employeeIdTB;
        private System.Windows.Forms.Button menuButton;
    }
}