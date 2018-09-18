namespace WindowsFormsLocomotive
{
    partial class FormLocomotive
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
            this.pictureBoxLoc = new System.Windows.Forms.PictureBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoc)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLoc
            // 
            this.pictureBoxLoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLoc.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLoc.Name = "pictureBoxLoc";
            this.pictureBoxLoc.Size = new System.Drawing.Size(884, 461);
            this.pictureBoxLoc.TabIndex = 0;
            this.pictureBoxLoc.TabStop = false;
            this.pictureBoxLoc.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(0, 0);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // right
            // 
            this.right.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.right.BackgroundImage = global::WindowsFormsLocomotive.Properties.Resources.Зелёная_стрелкаП;
            this.right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.right.ForeColor = System.Drawing.SystemColors.ControlText;
            this.right.Location = new System.Drawing.Point(842, 419);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(30, 30);
            this.right.TabIndex = 2;
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // left
            // 
            this.left.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.left.BackgroundImage = global::WindowsFormsLocomotive.Properties.Resources.Зелёная_стрелкаЛ;
            this.left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.left.Location = new System.Drawing.Point(770, 419);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(30, 30);
            this.left.TabIndex = 3;
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // up
            // 
            this.up.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.up.BackColor = System.Drawing.SystemColors.ControlLight;
            this.up.BackgroundImage = global::WindowsFormsLocomotive.Properties.Resources.Зелёная_стрелкаВв;
            this.up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.up.Location = new System.Drawing.Point(806, 383);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(30, 30);
            this.up.TabIndex = 4;
            this.up.UseVisualStyleBackColor = false;
            this.up.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // down
            // 
            this.down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.down.BackgroundImage = global::WindowsFormsLocomotive.Properties.Resources.Зелёная_стрелкаВн;
            this.down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.down.Location = new System.Drawing.Point(806, 419);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(30, 30);
            this.down.TabIndex = 5;
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // FormLocomotive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.left);
            this.Controls.Add(this.right);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.pictureBoxLoc);
            this.Name = "FormLocomotive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLocomotive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLoc;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button up;
    }
}

