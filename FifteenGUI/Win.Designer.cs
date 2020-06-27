namespace FifteenGUI
{
    partial class Win
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
            this.step = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // step
            // 
            this.step.AutoSize = true;
            this.step.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step.Location = new System.Drawing.Point(53, 94);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(226, 33);
            this.step.TabIndex = 3;
            this.step.Text = "Количество ходов:";
            // 
            // duration
            // 
            this.duration.AutoSize = true;
            this.duration.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.duration.Location = new System.Drawing.Point(53, 44);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(157, 33);
            this.duration.TabIndex = 4;
            this.duration.Text = "Время игры:";
            // 
            // Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.step);
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Win";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Победа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Win_FormClosing);
            this.Load += new System.EventHandler(this.Win_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label step;
        private System.Windows.Forms.Label duration;
    }
}