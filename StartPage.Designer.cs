
namespace Turtle_s_Revenge
{
    partial class StartPage
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
            this.startBtn = new System.Windows.Forms.Button();
            this.instructionBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.startBtn.Location = new System.Drawing.Point(374, 120);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(88, 32);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // instructionBtn
            // 
            this.instructionBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.instructionBtn.Location = new System.Drawing.Point(374, 183);
            this.instructionBtn.Name = "instructionBtn";
            this.instructionBtn.Size = new System.Drawing.Size(88, 31);
            this.instructionBtn.TabIndex = 1;
            this.instructionBtn.Text = "Instruction";
            this.instructionBtn.UseVisualStyleBackColor = false;
            this.instructionBtn.Click += new System.EventHandler(this.instructionBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.exitBtn.Location = new System.Drawing.Point(374, 250);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(88, 30);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.instructionBtn);
            this.Controls.Add(this.startBtn);
            this.Name = "StartPage";
            this.Text = "StartPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button instructionBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}