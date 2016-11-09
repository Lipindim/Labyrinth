namespace Labyrinth.Levels
{
    partial class Level01
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level01));
            this.start1 = new Labyrinth.Start();
            this.finish1 = new Labyrinth.Finish();
            this.wall2 = new Labyrinth.Wall();
            this.wall8 = new Labyrinth.Wall();
            this.wall7 = new Labyrinth.Wall();
            this.wall6 = new Labyrinth.Wall();
            this.wall5 = new Labyrinth.Wall();
            this.wall4 = new Labyrinth.Wall();
            this.wall3 = new Labyrinth.Wall();
            this.wall1 = new Labyrinth.Wall();
            this.SuspendLayout();
            // 
            // start1
            // 
            this.start1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("start1.BackgroundImage")));
            this.start1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.start1.Location = new System.Drawing.Point(23, 21);
            this.start1.Name = "start1";
            this.start1.Size = new System.Drawing.Size(71, 29);
            this.start1.TabIndex = 3;
            // 
            // finish1
            // 
            this.finish1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.finish1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finish1.BackgroundImage")));
            this.finish1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.finish1.Location = new System.Drawing.Point(536, 461);
            this.finish1.Name = "finish1";
            this.finish1.Size = new System.Drawing.Size(92, 42);
            this.finish1.TabIndex = 2;
            // 
            // wall2
            // 
            this.wall2.BackColor = System.Drawing.Color.Green;
            this.wall2.Location = new System.Drawing.Point(628, -3);
            this.wall2.Name = "wall2";
            this.wall2.Size = new System.Drawing.Size(23, 527);
            this.wall2.TabIndex = 0;
            // 
            // wall8
            // 
            this.wall8.BackColor = System.Drawing.Color.Green;
            this.wall8.Location = new System.Drawing.Point(353, 302);
            this.wall8.Name = "wall8";
            this.wall8.Size = new System.Drawing.Size(25, 201);
            this.wall8.TabIndex = 0;
            // 
            // wall7
            // 
            this.wall7.BackColor = System.Drawing.Color.Green;
            this.wall7.Location = new System.Drawing.Point(121, 239);
            this.wall7.Name = "wall7";
            this.wall7.Size = new System.Drawing.Size(25, 180);
            this.wall7.TabIndex = 0;
            // 
            // wall6
            // 
            this.wall6.BackColor = System.Drawing.Color.Green;
            this.wall6.Location = new System.Drawing.Point(121, 223);
            this.wall6.Name = "wall6";
            this.wall6.Size = new System.Drawing.Size(507, 21);
            this.wall6.TabIndex = 0;
            // 
            // wall5
            // 
            this.wall5.BackColor = System.Drawing.Color.Green;
            this.wall5.Location = new System.Drawing.Point(23, 119);
            this.wall5.Name = "wall5";
            this.wall5.Size = new System.Drawing.Size(375, 21);
            this.wall5.TabIndex = 0;
            // 
            // wall4
            // 
            this.wall4.BackColor = System.Drawing.Color.Green;
            this.wall4.Location = new System.Drawing.Point(0, 0);
            this.wall4.Name = "wall4";
            this.wall4.Size = new System.Drawing.Size(651, 21);
            this.wall4.TabIndex = 0;
            // 
            // wall3
            // 
            this.wall3.BackColor = System.Drawing.Color.Green;
            this.wall3.Location = new System.Drawing.Point(0, 503);
            this.wall3.Name = "wall3";
            this.wall3.Size = new System.Drawing.Size(651, 21);
            this.wall3.TabIndex = 0;
            // 
            // wall1
            // 
            this.wall1.BackColor = System.Drawing.Color.Green;
            this.wall1.Location = new System.Drawing.Point(0, 0);
            this.wall1.Name = "wall1";
            this.wall1.Size = new System.Drawing.Size(23, 524);
            this.wall1.TabIndex = 0;
            // 
            // Level01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.start1);
            this.Controls.Add(this.finish1);
            this.Controls.Add(this.wall2);
            this.Controls.Add(this.wall8);
            this.Controls.Add(this.wall7);
            this.Controls.Add(this.wall6);
            this.Controls.Add(this.wall5);
            this.Controls.Add(this.wall4);
            this.Controls.Add(this.wall3);
            this.Controls.Add(this.wall1);
            this.Name = "Level01";
            this.Size = new System.Drawing.Size(651, 524);
            this.ResumeLayout(false);

        }

        #endregion

        private Wall wall1;
        private Wall wall2;
        private Wall wall3;
        private Wall wall4;
        private Finish finish1;
        private Start start1;
        private Wall wall5;
        private Wall wall6;
        private Wall wall7;
        private Wall wall8;
    }
}
