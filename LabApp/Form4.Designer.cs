namespace LabApp
{
    partial class Form4
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
            this.task11Button = new System.Windows.Forms.Button();
            this.task16Button = new System.Windows.Forms.Button();
            this.TableLV = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.numTB = new System.Windows.Forms.TextBox();
            this.dateTB = new System.Windows.Forms.TextBox();
            this.task26Button = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // task11Button
            // 
            this.task11Button.Location = new System.Drawing.Point(27, 307);
            this.task11Button.Name = "task11Button";
            this.task11Button.Size = new System.Drawing.Size(102, 45);
            this.task11Button.TabIndex = 0;
            this.task11Button.Text = "Задание 11";
            this.task11Button.UseVisualStyleBackColor = true;
            this.task11Button.Click += new System.EventHandler(this.task11Button_Click);
            // 
            // task16Button
            // 
            this.task16Button.Location = new System.Drawing.Point(27, 358);
            this.task16Button.Name = "task16Button";
            this.task16Button.Size = new System.Drawing.Size(102, 45);
            this.task16Button.TabIndex = 1;
            this.task16Button.Text = "Задание 16";
            this.task16Button.UseVisualStyleBackColor = true;
            this.task16Button.Click += new System.EventHandler(this.task16Button_Click);
            // 
            // TableLV
            // 
            this.TableLV.HideSelection = false;
            this.TableLV.Location = new System.Drawing.Point(27, 41);
            this.TableLV.Name = "TableLV";
            this.TableLV.Size = new System.Drawing.Size(901, 239);
            this.TableLV.TabIndex = 52;
            this.TableLV.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 16);
            this.label7.TabIndex = 51;
            this.label7.Text = "Результат запроса";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(24, 488);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(78, 16);
            this.statusLabel.TabIndex = 53;
            this.statusLabel.Text = "StatusLabel";
            // 
            // numTB
            // 
            this.numTB.Location = new System.Drawing.Point(146, 420);
            this.numTB.Name = "numTB";
            this.numTB.Size = new System.Drawing.Size(729, 22);
            this.numTB.TabIndex = 54;
            // 
            // dateTB
            // 
            this.dateTB.Location = new System.Drawing.Point(146, 369);
            this.dateTB.Name = "dateTB";
            this.dateTB.Size = new System.Drawing.Size(131, 22);
            this.dateTB.TabIndex = 55;
            // 
            // task26Button
            // 
            this.task26Button.Location = new System.Drawing.Point(27, 409);
            this.task26Button.Name = "task26Button";
            this.task26Button.Size = new System.Drawing.Size(102, 45);
            this.task26Button.TabIndex = 56;
            this.task26Button.Text = "Задание 41";
            this.task26Button.UseVisualStyleBackColor = true;
            this.task26Button.Click += new System.EventHandler(this.task26Button_Click);
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(934, 22);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(26, 23);
            this.menuButton.TabIndex = 72;
            this.menuButton.Text = "X";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 527);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.task26Button);
            this.Controls.Add(this.dateTB);
            this.Controls.Add(this.numTB);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.TableLV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.task16Button);
            this.Controls.Add(this.task11Button);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button task11Button;
        private System.Windows.Forms.Button task16Button;
        private System.Windows.Forms.ListView TableLV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox numTB;
        private System.Windows.Forms.TextBox dateTB;
        private System.Windows.Forms.Button task26Button;
        private System.Windows.Forms.Button menuButton;
    }
}