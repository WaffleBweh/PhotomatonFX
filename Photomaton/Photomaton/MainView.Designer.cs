namespace Photomaton
{
    partial class MainView
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbSrc = new System.Windows.Forms.PictureBox();
            this.pbDest = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnStep = new System.Windows.Forms.Button();
            this.lbEffects = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stepTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDest)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSrc
            // 
            this.pbSrc.BackColor = System.Drawing.Color.White;
            this.pbSrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSrc.Location = new System.Drawing.Point(12, 33);
            this.pbSrc.Name = "pbSrc";
            this.pbSrc.Size = new System.Drawing.Size(256, 256);
            this.pbSrc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSrc.TabIndex = 0;
            this.pbSrc.TabStop = false;
            // 
            // pbDest
            // 
            this.pbDest.BackColor = System.Drawing.Color.White;
            this.pbDest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDest.Location = new System.Drawing.Point(302, 33);
            this.pbDest.Name = "pbDest";
            this.pbDest.Size = new System.Drawing.Size(256, 256);
            this.pbDest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDest.TabIndex = 1;
            this.pbDest.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Transformed image";
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Location = new System.Drawing.Point(12, 295);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(256, 29);
            this.btnChooseImage.TabIndex = 4;
            this.btnChooseImage.Text = "Choose image";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Enabled = false;
            this.btnPlayPause.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnPlayPause.Location = new System.Drawing.Point(436, 295);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(122, 29);
            this.btnPlayPause.TabIndex = 6;
            this.btnPlayPause.Text = "4";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnStep
            // 
            this.btnStep.Enabled = false;
            this.btnStep.Location = new System.Drawing.Point(302, 295);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(122, 29);
            this.btnStep.TabIndex = 7;
            this.btnStep.Text = "Step";
            this.btnStep.UseVisualStyleBackColor = true;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // lbEffects
            // 
            this.lbEffects.FormattingEnabled = true;
            this.lbEffects.Location = new System.Drawing.Point(593, 33);
            this.lbEffects.Name = "lbEffects";
            this.lbEffects.ScrollAlwaysVisible = true;
            this.lbEffects.Size = new System.Drawing.Size(171, 251);
            this.lbEffects.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "List of effects";
            // 
            // stepTimer
            // 
            this.stepTimer.Interval = 16;
            this.stepTimer.Tick += new System.EventHandler(this.stepTimer_Tick);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 334);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbEffects);
            this.Controls.Add(this.btnStep);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbDest);
            this.Controls.Add(this.pbSrc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image effects";
            ((System.ComponentModel.ISupportInitialize)(this.pbSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSrc;
        private System.Windows.Forms.PictureBox pbDest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.ListBox lbEffects;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer stepTimer;
    }
}

