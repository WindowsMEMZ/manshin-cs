namespace manshin
{
    partial class NetworkSetting
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
            this.label9 = new System.Windows.Forms.Label();
            this.roundButton1 = new manshin.RoundButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("汉仪文黑-85W", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(188)))), ((int)(((byte)(142)))));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "设置 / 网络";
            // 
            // roundButton1
            // 
            this.roundButton1.BackgroundImage = global::manshin.Properties.Resources.CloseNormal;
            this.roundButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.ImageEnter = null;
            this.roundButton1.ImageNormal = global::manshin.Properties.Resources.CloseNormal;
            this.roundButton1.Location = new System.Drawing.Point(750, 3);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Radius = 38;
            this.roundButton1.Size = new System.Drawing.Size(38, 38);
            this.roundButton1.TabIndex = 15;
            this.roundButton1.UseVisualStyleBackColor = true;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            this.roundButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.roundButton1_MouseDown);
            this.roundButton1.MouseEnter += new System.EventHandler(this.roundButton1_MouseEnter);
            this.roundButton1.MouseLeave += new System.EventHandler(this.roundButton1_MouseLeave);
            this.roundButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.roundButton1_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 54);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("汉仪文黑-85W", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "前面的区域，以后再来探索吧";
            // 
            // NetworkSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.roundButton1);
            this.Name = "NetworkSetting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private RoundButton roundButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}