using System.Runtime.InteropServices;

namespace RPC_game
{

    partial class RPCGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPCGUI));
            this.rockBt = new System.Windows.Forms.Button();
            this.paperBt = new System.Windows.Forms.Button();
            this.scissorBt = new System.Windows.Forms.Button();
            this.Npc = new System.Windows.Forms.PictureBox();
            this.RESULTS = new System.Windows.Forms.Label();
            this.plyrChoice = new System.Windows.Forms.Label();
            this.FinalVs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Npc)).BeginInit();
            this.SuspendLayout();
            // 
            // rockBt
            // 
            this.rockBt.BackColor = System.Drawing.Color.White;
            this.rockBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rockBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rockBt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rockBt.Location = new System.Drawing.Point(12, 466);
            this.rockBt.Name = "rockBt";
            this.rockBt.Size = new System.Drawing.Size(201, 79);
            this.rockBt.TabIndex = 0;
            this.rockBt.Text = "ROCK";
            this.rockBt.UseVisualStyleBackColor = false;
            this.rockBt.Click += new System.EventHandler(this.rockBt_Click);
            // 
            // paperBt
            // 
            this.paperBt.BackColor = System.Drawing.Color.White;
            this.paperBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paperBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paperBt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paperBt.Location = new System.Drawing.Point(431, 466);
            this.paperBt.Name = "paperBt";
            this.paperBt.Size = new System.Drawing.Size(199, 79);
            this.paperBt.TabIndex = 1;
            this.paperBt.Text = "PAPER";
            this.paperBt.UseVisualStyleBackColor = false;
            this.paperBt.Click += new System.EventHandler(this.paperBt_Click);
            // 
            // scissorBt
            // 
            this.scissorBt.BackColor = System.Drawing.Color.White;
            this.scissorBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scissorBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scissorBt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scissorBt.Location = new System.Drawing.Point(226, 515);
            this.scissorBt.Name = "scissorBt";
            this.scissorBt.Size = new System.Drawing.Size(196, 79);
            this.scissorBt.TabIndex = 2;
            this.scissorBt.Text = "SCISSOR";
            this.scissorBt.UseVisualStyleBackColor = false;
            this.scissorBt.Click += new System.EventHandler(this.scissorBt_Click);
            // 
            // Npc
            // 
            this.Npc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Npc.Image = global::RPC_game.Properties.Resources._637799866799448709;
            this.Npc.Location = new System.Drawing.Point(190, 80);
            this.Npc.Name = "Npc";
            this.Npc.Size = new System.Drawing.Size(264, 237);
            this.Npc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Npc.TabIndex = 3;
            this.Npc.TabStop = false;
            // 
            // RESULTS
            // 
            this.RESULTS.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RESULTS.Dock = System.Windows.Forms.DockStyle.Top;
            this.RESULTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESULTS.ForeColor = System.Drawing.Color.Lime;
            this.RESULTS.Location = new System.Drawing.Point(0, 0);
            this.RESULTS.Name = "RESULTS";
            this.RESULTS.Size = new System.Drawing.Size(642, 68);
            this.RESULTS.TabIndex = 4;
            this.RESULTS.Text = "GAME RESULTS";
            this.RESULTS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plyrChoice
            // 
            this.plyrChoice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.plyrChoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plyrChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plyrChoice.ForeColor = System.Drawing.Color.Lime;
            this.plyrChoice.Location = new System.Drawing.Point(190, 383);
            this.plyrChoice.Name = "plyrChoice";
            this.plyrChoice.Size = new System.Drawing.Size(276, 68);
            this.plyrChoice.TabIndex = 5;
            this.plyrChoice.Text = "\"Chose to Start!!\"";
            this.plyrChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FinalVs
            // 
            this.FinalVs.Font = new System.Drawing.Font("Chiller", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalVs.Location = new System.Drawing.Point(218, 320);
            this.FinalVs.Name = "FinalVs";
            this.FinalVs.Size = new System.Drawing.Size(204, 51);
            this.FinalVs.TabIndex = 6;
            this.FinalVs.Text = "V.S";
            this.FinalVs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RPCGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(642, 649);
            this.Controls.Add(this.FinalVs);
            this.Controls.Add(this.plyrChoice);
            this.Controls.Add(this.RESULTS);
            this.Controls.Add(this.Npc);
            this.Controls.Add(this.scissorBt);
            this.Controls.Add(this.paperBt);
            this.Controls.Add(this.rockBt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RPCGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPC Game";
            
            ((System.ComponentModel.ISupportInitialize)(this.Npc)).EndInit();
            this.ResumeLayout(false);

        }

   

        #endregion
        private System.Windows.Forms.Button paperBt;
        private System.Windows.Forms.Button scissorBt;
        private System.Windows.Forms.PictureBox Npc;
        private System.Windows.Forms.Button rockBt;
        private System.Windows.Forms.Label RESULTS;
        private System.Windows.Forms.Label plyrChoice;
        private System.Windows.Forms.Label FinalVs;
    }
}

