namespace ControlWork
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
            this.backGround1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.enterAbox = new System.Windows.Forms.TextBox();
            this.enterBbox = new System.Windows.Forms.TextBox();
            this.enterCbox = new System.Windows.Forms.TextBox();
            this.equationBox = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.answerBox = new System.Windows.Forms.Label();
            this.goBackBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backGround1
            // 
            this.backGround1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.backGround1.Enabled = false;
            this.backGround1.Location = new System.Drawing.Point(12, 23);
            this.backGround1.Name = "backGround1";
            this.backGround1.Size = new System.Drawing.Size(350, 60);
            this.backGround1.TabIndex = 0;
            this.backGround1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Коэффициенты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(132, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(240, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "c:";
            // 
            // enterAbox
            // 
            this.enterAbox.Location = new System.Drawing.Point(52, 48);
            this.enterAbox.Name = "enterAbox";
            this.enterAbox.Size = new System.Drawing.Size(55, 20);
            this.enterAbox.TabIndex = 5;
            this.enterAbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.enterAbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.enterAbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // enterBbox
            // 
            this.enterBbox.Location = new System.Drawing.Point(160, 48);
            this.enterBbox.Name = "enterBbox";
            this.enterBbox.Size = new System.Drawing.Size(55, 20);
            this.enterBbox.TabIndex = 6;
            this.enterBbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.enterBbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            this.enterBbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // enterCbox
            // 
            this.enterCbox.Location = new System.Drawing.Point(268, 48);
            this.enterCbox.Name = "enterCbox";
            this.enterCbox.Size = new System.Drawing.Size(55, 20);
            this.enterCbox.TabIndex = 7;
            this.enterCbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.enterCbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            this.enterCbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // equationBox
            // 
            this.equationBox.AutoSize = true;
            this.equationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equationBox.Location = new System.Drawing.Point(131, 95);
            this.equationBox.Name = "equationBox";
            this.equationBox.Size = new System.Drawing.Size(110, 20);
            this.equationBox.TabIndex = 8;
            this.equationBox.Text = "Уравнение: ";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(106, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Найти корни";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // answerBox
            // 
            this.answerBox.AutoSize = true;
            this.answerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerBox.Location = new System.Drawing.Point(9, 7);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(51, 16);
            this.answerBox.TabIndex = 10;
            this.answerBox.Text = "label5";
            // 
            // goBackBox
            // 
            this.goBackBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBackBox.Location = new System.Drawing.Point(106, 126);
            this.goBackBox.Name = "goBackBox";
            this.goBackBox.Size = new System.Drawing.Size(150, 23);
            this.goBackBox.TabIndex = 11;
            this.goBackBox.Text = "OK";
            this.goBackBox.UseVisualStyleBackColor = true;
            this.goBackBox.Click += new System.EventHandler(this.goBackBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.goBackBox);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.equationBox);
            this.Controls.Add(this.enterCbox);
            this.Controls.Add(this.enterBbox);
            this.Controls.Add(this.enterAbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backGround1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backGround1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox enterAbox;
        private System.Windows.Forms.TextBox enterBbox;
        private System.Windows.Forms.TextBox enterCbox;
        private System.Windows.Forms.Label equationBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label answerBox;
        private System.Windows.Forms.Button goBackBox;
    }
}

