
namespace MiniGames
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TTT = new System.Windows.Forms.Button();
            this.RPS = new System.Windows.Forms.Button();
            this.GAMEPANEL = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tictactoe1 = new MiniGames.TicTacToe();
            this.rps1 = new MiniGames.RPS();
            this.TableLayout.SuspendLayout();
            this.GAMEPANEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayout
            // 
            this.TableLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.TableLayout.ColumnCount = 4;
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayout.Controls.Add(this.button4, 3, 1);
            this.TableLayout.Controls.Add(this.button3, 2, 1);
            this.TableLayout.Controls.Add(this.TTT, 1, 1);
            this.TableLayout.Controls.Add(this.RPS, 0, 1);
            this.TableLayout.Controls.Add(this.GAMEPANEL, 0, 2);
            this.TableLayout.Controls.Add(this.pictureBox1, 0, 0);
            this.TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout.Location = new System.Drawing.Point(0, 0);
            this.TableLayout.Name = "TableLayout";
            this.TableLayout.RowCount = 3;
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.45374F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.397944F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.00146F));
            this.TableLayout.Size = new System.Drawing.Size(1064, 681);
            this.TableLayout.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(801, 81);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(260, 58);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(535, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 58);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // TTT
            // 
            this.TTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.TTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TTT.FlatAppearance.BorderSize = 0;
            this.TTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TTT.Image = ((System.Drawing.Image)(resources.GetObject("TTT.Image")));
            this.TTT.Location = new System.Drawing.Point(269, 81);
            this.TTT.Name = "TTT";
            this.TTT.Size = new System.Drawing.Size(260, 58);
            this.TTT.TabIndex = 2;
            this.TTT.UseVisualStyleBackColor = false;
            this.TTT.Click += new System.EventHandler(this.TTT_Click);
            // 
            // RPS
            // 
            this.RPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.RPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RPS.FlatAppearance.BorderSize = 0;
            this.RPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RPS.Image = ((System.Drawing.Image)(resources.GetObject("RPS.Image")));
            this.RPS.Location = new System.Drawing.Point(3, 81);
            this.RPS.Name = "RPS";
            this.RPS.Size = new System.Drawing.Size(260, 58);
            this.RPS.TabIndex = 1;
            this.RPS.UseVisualStyleBackColor = false;
            this.RPS.Click += new System.EventHandler(this.RPS_Click);
            // 
            // GAMEPANEL
            // 
            this.GAMEPANEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.TableLayout.SetColumnSpan(this.GAMEPANEL, 4);
            this.GAMEPANEL.Controls.Add(this.tictactoe1);
            this.GAMEPANEL.Controls.Add(this.rps1);
            this.GAMEPANEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GAMEPANEL.Location = new System.Drawing.Point(3, 145);
            this.GAMEPANEL.Name = "GAMEPANEL";
            this.GAMEPANEL.Size = new System.Drawing.Size(1058, 533);
            this.GAMEPANEL.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.TableLayout.SetColumnSpan(this.pictureBox1, 4);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1058, 72);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // tictactoe1
            // 
            this.tictactoe1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.tictactoe1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tictactoe1.Location = new System.Drawing.Point(0, 0);
            this.tictactoe1.Name = "tictactoe1";
            this.tictactoe1.Size = new System.Drawing.Size(1058, 533);
            this.tictactoe1.TabIndex = 1;
            // 
            // rps1
            // 
            this.rps1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.rps1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rps1.Location = new System.Drawing.Point(0, 0);
            this.rps1.Name = "rps1";
            this.rps1.Size = new System.Drawing.Size(1058, 533);
            this.rps1.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.TableLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Games";
            this.TableLayout.ResumeLayout(false);
            this.GAMEPANEL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayout;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button TTT;
        private System.Windows.Forms.Button RPS;
        private System.Windows.Forms.Panel GAMEPANEL;
        private RPS rps1;
        private TicTacToe tictactoe1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

