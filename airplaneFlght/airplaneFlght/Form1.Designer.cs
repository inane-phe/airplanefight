namespace airplaneFlght
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Air = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.bob = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Air)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bob)).BeginInit();
            this.SuspendLayout();
            // 
            // Air
            // 
            this.Air.Image = global::airplaneFlght.Properties.Resources.plane_removeBG;
            this.Air.Location = new System.Drawing.Point(323, 407);
            this.Air.Name = "Air";
            this.Air.Size = new System.Drawing.Size(94, 84);
            this.Air.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Air.TabIndex = 0;
            this.Air.TabStop = false;
            // 
            // Enemy
            // 
            this.Enemy.Image = global::airplaneFlght.Properties.Resources.enemy_removeBG;
            this.Enemy.Location = new System.Drawing.Point(196, 83);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(100, 70);
            this.Enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Enemy.TabIndex = 1;
            this.Enemy.TabStop = false;
            this.Enemy.Visible = false;
            // 
            // bob
            // 
            this.bob.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bob.Image = global::airplaneFlght.Properties.Resources.bomb_removeBG;
            this.bob.Location = new System.Drawing.Point(205, 495);
            this.bob.Name = "bob";
            this.bob.Size = new System.Drawing.Size(34, 44);
            this.bob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bob.TabIndex = 2;
            this.bob.TabStop = false;
            this.bob.Visible = false;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(40, 43);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(24, 25);
            this.score.TabIndex = 3;
            this.score.Text = "0";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(639, 43);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(24, 25);
            this.time.TabIndex = 5;
            this.time.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "100";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.TabStop = false;
            this.button1.Text = "開始";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.score);
            this.Controls.Add(this.bob);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.Air);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Air)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Air;
        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.PictureBox bob;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

