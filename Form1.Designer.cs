
namespace Turtle_s_Revenge
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.turtle = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ufo = new System.Windows.Forms.PictureBox();
            this.tree = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.turtle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).BeginInit();
            this.SuspendLayout();
            // 
            // turtle
            // 
            this.turtle.Image = global::Turtle_s_Revenge.Properties.Resources.Turtle;
            this.turtle.Location = new System.Drawing.Point(107, 131);
            this.turtle.Name = "turtle";
            this.turtle.Size = new System.Drawing.Size(70, 73);
            this.turtle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.turtle.TabIndex = 0;
            this.turtle.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Turtle_s_Revenge.Properties.Resources.ground;
            this.pictureBox2.Location = new System.Drawing.Point(-2, 400);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(803, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // ufo
            // 
            this.ufo.Image = global::Turtle_s_Revenge.Properties.Resources.UFO;
            this.ufo.Location = new System.Drawing.Point(701, 71);
            this.ufo.Name = "ufo";
            this.ufo.Size = new System.Drawing.Size(100, 50);
            this.ufo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ufo.TabIndex = 2;
            this.ufo.TabStop = false;
            this.ufo.Tag = "enemy";
            // 
            // tree
            // 
            this.tree.Image = global::Turtle_s_Revenge.Properties.Resources.Tree;
            this.tree.Location = new System.Drawing.Point(342, 227);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(121, 174);
            this.tree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tree.TabIndex = 3;
            this.tree.TabStop = false;
            this.tree.Tag = "tree";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtScore.Location = new System.Drawing.Point(-2, -2);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(114, 25);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "Score : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.ufo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.turtle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsup);
            ((System.ComponentModel.ISupportInitialize)(this.turtle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox turtle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox ufo;
        private System.Windows.Forms.PictureBox tree;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label txtScore;
    }
}

