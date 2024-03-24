namespace LabApp
{
    partial class Menu
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
            this.employeesButton = new System.Windows.Forms.Button();
            this.organizationsButton = new System.Windows.Forms.Button();
            this.documentationButton = new System.Windows.Forms.Button();
            this.tasksButton = new System.Windows.Forms.Button();
            this.consoleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeesButton
            // 
            this.employeesButton.Location = new System.Drawing.Point(33, 22);
            this.employeesButton.Name = "employeesButton";
            this.employeesButton.Size = new System.Drawing.Size(138, 23);
            this.employeesButton.TabIndex = 0;
            this.employeesButton.Text = "Работники";
            this.employeesButton.UseVisualStyleBackColor = true;
            this.employeesButton.Click += new System.EventHandler(this.employeesButton_Click);
            // 
            // organizationsButton
            // 
            this.organizationsButton.Location = new System.Drawing.Point(33, 52);
            this.organizationsButton.Name = "organizationsButton";
            this.organizationsButton.Size = new System.Drawing.Size(138, 23);
            this.organizationsButton.TabIndex = 1;
            this.organizationsButton.Text = "Организации";
            this.organizationsButton.UseVisualStyleBackColor = true;
            this.organizationsButton.Click += new System.EventHandler(this.organizationsButton_Click);
            // 
            // documentationButton
            // 
            this.documentationButton.Location = new System.Drawing.Point(33, 81);
            this.documentationButton.Name = "documentationButton";
            this.documentationButton.Size = new System.Drawing.Size(138, 23);
            this.documentationButton.TabIndex = 2;
            this.documentationButton.Text = "Документация";
            this.documentationButton.UseVisualStyleBackColor = true;
            this.documentationButton.Click += new System.EventHandler(this.documentationButton_Click);
            // 
            // tasksButton
            // 
            this.tasksButton.Location = new System.Drawing.Point(33, 110);
            this.tasksButton.Name = "tasksButton";
            this.tasksButton.Size = new System.Drawing.Size(138, 23);
            this.tasksButton.TabIndex = 3;
            this.tasksButton.Text = "Задания";
            this.tasksButton.UseVisualStyleBackColor = true;
            this.tasksButton.Click += new System.EventHandler(this.tasksButton_Click);
            // 
            // consoleButton
            // 
            this.consoleButton.Location = new System.Drawing.Point(33, 139);
            this.consoleButton.Name = "consoleButton";
            this.consoleButton.Size = new System.Drawing.Size(138, 23);
            this.consoleButton.TabIndex = 4;
            this.consoleButton.Text = "Командная строка";
            this.consoleButton.UseVisualStyleBackColor = true;
            this.consoleButton.Click += new System.EventHandler(this.consoleButton_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 190);
            this.Controls.Add(this.consoleButton);
            this.Controls.Add(this.tasksButton);
            this.Controls.Add(this.documentationButton);
            this.Controls.Add(this.organizationsButton);
            this.Controls.Add(this.employeesButton);
            this.Name = "menu";
            this.Text = "menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button employeesButton;
        private System.Windows.Forms.Button organizationsButton;
        private System.Windows.Forms.Button documentationButton;
        private System.Windows.Forms.Button tasksButton;
        private System.Windows.Forms.Button consoleButton;
    }
}