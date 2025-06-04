namespace WFShahMat
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
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRooks3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRooks2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRooks1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKing = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtRooks3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtRooks2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtRooks1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtKing);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 116);
            this.panel1.TabIndex = 0;
            // 
            // txtRooks3
            // 
            this.txtRooks3.Location = new System.Drawing.Point(134, 82);
            this.txtRooks3.Name = "txtRooks3";
            this.txtRooks3.Size = new System.Drawing.Size(50, 20);
            this.txtRooks3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Третья ладья:";
            // 
            // txtRooks2
            // 
            this.txtRooks2.Location = new System.Drawing.Point(134, 56);
            this.txtRooks2.Name = "txtRooks2";
            this.txtRooks2.Size = new System.Drawing.Size(50, 20);
            this.txtRooks2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Вторая ладья:";
            // 
            // txtRooks1
            // 
            this.txtRooks1.Location = new System.Drawing.Point(134, 30);
            this.txtRooks1.Name = "txtRooks1";
            this.txtRooks1.Size = new System.Drawing.Size(50, 20);
            this.txtRooks1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Первая ладья:";
            // 
            // txtKing
            // 
            this.txtKing.Location = new System.Drawing.Point(134, 4);
            this.txtKing.Name = "txtKing";
            this.txtKing.Size = new System.Drawing.Size(50, 20);
            this.txtKing.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Расположение короля:";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(13, 136);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(193, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(13, 166);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(58, 13);
            this.lbMessage.TabIndex = 2;
            this.lbMessage.Text = "lbMessage";
            this.lbMessage.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 191);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(235, 230);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проверка боя короля";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRooks1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRooks3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRooks2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lbMessage;
    }
}

