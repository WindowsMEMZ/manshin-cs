namespace manshin
{
    partial class Map
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.roundButton1 = new manshin.RoundButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("汉仪文黑-85W", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(788, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "前面的区域，以后再来探索吧";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("汉仪文黑-85W", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "快速传送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackgroundImage = global::manshin.Properties.Resources.CloseNormal;
            this.roundButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.ImageEnter = null;
            this.roundButton1.ImageNormal = global::manshin.Properties.Resources.CloseNormal;
            this.roundButton1.Location = new System.Drawing.Point(1837, 12);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Radius = 49;
            this.roundButton1.Size = new System.Drawing.Size(49, 49);
            this.roundButton1.TabIndex = 1;
            this.roundButton1.UseVisualStyleBackColor = true;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            this.roundButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.roundButton1_MouseDown);
            this.roundButton1.MouseEnter += new System.EventHandler(this.roundButton1_MouseEnter);
            this.roundButton1.MouseLeave += new System.EventHandler(this.roundButton1_MouseLeave);
            this.roundButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.roundButton1_MouseUp);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Map";
            this.Text = "Map";
            this.Load += new System.EventHandler(this.Map_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RoundButton roundButton1;
        private System.Windows.Forms.Button button1;
    }
}