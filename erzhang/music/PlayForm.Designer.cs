namespace music
{
    partial class PlayForm
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
            this.rbtnViolin = new System.Windows.Forms.RadioButton();
            this.rbtnSachs = new System.Windows.Forms.RadioButton();
            this.rbtnPiano = new System.Windows.Forms.RadioButton();
            this.btnPlay = new System.Windows.Forms.Button();
            this.gbPlay = new System.Windows.Forms.GroupBox();
            this.gbPlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnViolin
            // 
            this.rbtnViolin.AutoSize = true;
            this.rbtnViolin.Location = new System.Drawing.Point(51, 73);
            this.rbtnViolin.Name = "rbtnViolin";
            this.rbtnViolin.Size = new System.Drawing.Size(73, 19);
            this.rbtnViolin.TabIndex = 1;
            this.rbtnViolin.TabStop = true;
            this.rbtnViolin.Text = "小提琴";
            this.rbtnViolin.UseVisualStyleBackColor = true;
            this.rbtnViolin.CheckedChanged += new System.EventHandler(this.rbtnViolin_CheckedChanged);
            // 
            // rbtnSachs
            // 
            this.rbtnSachs.AutoSize = true;
            this.rbtnSachs.Location = new System.Drawing.Point(51, 109);
            this.rbtnSachs.Name = "rbtnSachs";
            this.rbtnSachs.Size = new System.Drawing.Size(73, 19);
            this.rbtnSachs.TabIndex = 2;
            this.rbtnSachs.TabStop = true;
            this.rbtnSachs.Text = "萨克斯";
            this.rbtnSachs.UseVisualStyleBackColor = true;
            // 
            // rbtnPiano
            // 
            this.rbtnPiano.AutoSize = true;
            this.rbtnPiano.Location = new System.Drawing.Point(51, 34);
            this.rbtnPiano.Name = "rbtnPiano";
            this.rbtnPiano.Size = new System.Drawing.Size(58, 19);
            this.rbtnPiano.TabIndex = 0;
            this.rbtnPiano.TabStop = true;
            this.rbtnPiano.Text = "钢琴";
            this.rbtnPiano.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(63, 192);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "演奏";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbPlay
            // 
            this.gbPlay.Controls.Add(this.rbtnPiano);
            this.gbPlay.Controls.Add(this.rbtnSachs);
            this.gbPlay.Controls.Add(this.rbtnViolin);
            this.gbPlay.Location = new System.Drawing.Point(12, 12);
            this.gbPlay.Name = "gbPlay";
            this.gbPlay.Size = new System.Drawing.Size(197, 167);
            this.gbPlay.TabIndex = 4;
            this.gbPlay.TabStop = false;
            this.gbPlay.Text = "groupBox1";
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 227);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.gbPlay);
            this.Name = "PlayForm";
            this.Text = "PlayForm";
            this.gbPlay.ResumeLayout(false);
            this.gbPlay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnViolin;
        private System.Windows.Forms.RadioButton rbtnSachs;
        private System.Windows.Forms.RadioButton rbtnPiano;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.GroupBox gbPlay;

    }
}