
namespace MiniGames
{
    partial class RPS
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPS));
            this.Scissors = new System.Windows.Forms.Button();
            this.Rock = new System.Windows.Forms.Button();
            this.TableLayoutGrid = new System.Windows.Forms.TableLayoutPanel();
            this.Paper = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.result = new System.Windows.Forms.Label();
            this.head = new System.Windows.Forms.Label();
            this.TableLayoutGrid.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Scissors
            // 
            this.Scissors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.Scissors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Scissors.FlatAppearance.BorderSize = 0;
            this.Scissors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scissors.Image = ((System.Drawing.Image)(resources.GetObject("Scissors.Image")));
            this.Scissors.Location = new System.Drawing.Point(273, 3);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(130, 258);
            this.Scissors.TabIndex = 2;
            this.Scissors.UseVisualStyleBackColor = false;
            this.Scissors.Click += new System.EventHandler(this.Scissors_Click_1);
            // 
            // Rock
            // 
            this.Rock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.Rock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rock.FlatAppearance.BorderSize = 0;
            this.Rock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rock.Image = ((System.Drawing.Image)(resources.GetObject("Rock.Image")));
            this.Rock.Location = new System.Drawing.Point(3, 3);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(129, 258);
            this.Rock.TabIndex = 0;
            this.Rock.UseVisualStyleBackColor = false;
            this.Rock.Click += new System.EventHandler(this.Rock_Click_1);
            // 
            // TableLayoutGrid
            // 
            this.TableLayoutGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.TableLayoutGrid.ColumnCount = 3;
            this.TableLayoutGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutGrid.Controls.Add(this.Scissors, 2, 0);
            this.TableLayoutGrid.Controls.Add(this.Paper, 1, 0);
            this.TableLayoutGrid.Controls.Add(this.Rock, 0, 0);
            this.TableLayoutGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLayoutGrid.Location = new System.Drawing.Point(209, 90);
            this.TableLayoutGrid.Name = "TableLayoutGrid";
            this.TableLayoutGrid.RowCount = 1;
            this.TableLayoutGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutGrid.Size = new System.Drawing.Size(406, 264);
            this.TableLayoutGrid.TabIndex = 13;
            // 
            // Paper
            // 
            this.Paper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.Paper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Paper.FlatAppearance.BorderSize = 0;
            this.Paper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Paper.Image = ((System.Drawing.Image)(resources.GetObject("Paper.Image")));
            this.Paper.Location = new System.Drawing.Point(138, 3);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(129, 258);
            this.Paper.TabIndex = 1;
            this.Paper.UseVisualStyleBackColor = false;
            this.Paper.Click += new System.EventHandler(this.Paper_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.TableLayoutGrid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.result, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.head, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.7523F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(824, 481);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result.Location = new System.Drawing.Point(209, 357);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(406, 124);
            this.result.TabIndex = 15;
            this.result.Text = "RESULT";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // head
            // 
            this.head.AutoSize = true;
            this.head.Dock = System.Windows.Forms.DockStyle.Fill;
            this.head.Location = new System.Drawing.Point(209, 0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(406, 87);
            this.head.TabIndex = 16;
            this.head.Text = "SELECT YOUR CHOICE";
            this.head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RPS";
            this.Size = new System.Drawing.Size(824, 481);
            this.TableLayoutGrid.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Scissors;
        private System.Windows.Forms.Button Rock;
        private System.Windows.Forms.TableLayoutPanel TableLayoutGrid;
        private System.Windows.Forms.Button Paper;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label head;
    }
}
