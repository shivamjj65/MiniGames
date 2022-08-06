
namespace MiniGames
{
    partial class TicTacToe
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutGrid = new System.Windows.Forms.TableLayoutPanel();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.TableLayoutHead = new System.Windows.Forms.TableLayoutPanel();
            this.btnO = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.head = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnComp = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.TableLayoutGrid.SuspendLayout();
            this.TableLayoutHead.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.TableLayoutGrid, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TableLayoutHead, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnResult, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.7523F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 505);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TableLayoutGrid
            // 
            this.TableLayoutGrid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TableLayoutGrid.ColumnCount = 3;
            this.TableLayoutGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutGrid.Controls.Add(this.nine, 2, 2);
            this.TableLayoutGrid.Controls.Add(this.eight, 1, 2);
            this.TableLayoutGrid.Controls.Add(this.seven, 0, 2);
            this.TableLayoutGrid.Controls.Add(this.six, 2, 1);
            this.TableLayoutGrid.Controls.Add(this.five, 1, 1);
            this.TableLayoutGrid.Controls.Add(this.four, 0, 1);
            this.TableLayoutGrid.Controls.Add(this.three, 2, 0);
            this.TableLayoutGrid.Controls.Add(this.two, 1, 0);
            this.TableLayoutGrid.Controls.Add(this.one, 0, 0);
            this.TableLayoutGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLayoutGrid.Location = new System.Drawing.Point(198, 150);
            this.TableLayoutGrid.Name = "TableLayoutGrid";
            this.TableLayoutGrid.RowCount = 3;
            this.TableLayoutGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutGrid.Size = new System.Drawing.Size(385, 319);
            this.TableLayoutGrid.TabIndex = 13;
            // 
            // nine
            // 
            this.nine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nine.Location = new System.Drawing.Point(259, 215);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(123, 101);
            this.nine.TabIndex = 8;
            this.nine.Text = "?";
            this.nine.UseVisualStyleBackColor = true;
            // 
            // eight
            // 
            this.eight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eight.Location = new System.Drawing.Point(131, 215);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(122, 101);
            this.eight.TabIndex = 7;
            this.eight.Text = "?";
            this.eight.UseVisualStyleBackColor = true;
            // 
            // seven
            // 
            this.seven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seven.Location = new System.Drawing.Point(3, 215);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(122, 101);
            this.seven.TabIndex = 6;
            this.seven.Text = "?";
            this.seven.UseVisualStyleBackColor = true;
            // 
            // six
            // 
            this.six.Dock = System.Windows.Forms.DockStyle.Fill;
            this.six.Location = new System.Drawing.Point(259, 109);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(123, 100);
            this.six.TabIndex = 5;
            this.six.Text = "?";
            this.six.UseVisualStyleBackColor = true;
            // 
            // five
            // 
            this.five.Dock = System.Windows.Forms.DockStyle.Fill;
            this.five.Location = new System.Drawing.Point(131, 109);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(122, 100);
            this.five.TabIndex = 4;
            this.five.Text = "?";
            this.five.UseVisualStyleBackColor = true;
            // 
            // four
            // 
            this.four.Dock = System.Windows.Forms.DockStyle.Fill;
            this.four.Location = new System.Drawing.Point(3, 109);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(122, 100);
            this.four.TabIndex = 3;
            this.four.Text = "?";
            this.four.UseVisualStyleBackColor = true;
            // 
            // three
            // 
            this.three.Dock = System.Windows.Forms.DockStyle.Fill;
            this.three.Location = new System.Drawing.Point(259, 3);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(123, 100);
            this.three.TabIndex = 2;
            this.three.Text = "?";
            this.three.UseVisualStyleBackColor = true;
            // 
            // two
            // 
            this.two.Dock = System.Windows.Forms.DockStyle.Fill;
            this.two.Location = new System.Drawing.Point(131, 3);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(122, 100);
            this.two.TabIndex = 1;
            this.two.Text = "?";
            this.two.UseVisualStyleBackColor = true;
            // 
            // one
            // 
            this.one.Dock = System.Windows.Forms.DockStyle.Fill;
            this.one.Location = new System.Drawing.Point(3, 3);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(122, 100);
            this.one.TabIndex = 0;
            this.one.Text = "?";
            this.one.UseVisualStyleBackColor = true;
            // 
            // TableLayoutHead
            // 
            this.TableLayoutHead.ColumnCount = 2;
            this.TableLayoutHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutHead.Controls.Add(this.btnO, 1, 1);
            this.TableLayoutHead.Controls.Add(this.btnX, 0, 1);
            this.TableLayoutHead.Controls.Add(this.head, 0, 0);
            this.TableLayoutHead.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableLayoutHead.Location = new System.Drawing.Point(198, 3);
            this.TableLayoutHead.Name = "TableLayoutHead";
            this.TableLayoutHead.RowCount = 2;
            this.TableLayoutHead.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutHead.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.TableLayoutHead.Size = new System.Drawing.Size(385, 67);
            this.TableLayoutHead.TabIndex = 14;
            // 
            // btnO
            // 
            this.btnO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnO.Location = new System.Drawing.Point(195, 26);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(187, 38);
            this.btnO.TabIndex = 7;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = true;
            this.btnO.Click += new System.EventHandler(this.btnO_Click);
            // 
            // btnX
            // 
            this.btnX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnX.Location = new System.Drawing.Point(3, 26);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(186, 38);
            this.btnX.TabIndex = 3;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // head
            // 
            this.head.AutoSize = true;
            this.TableLayoutHead.SetColumnSpan(this.head, 2);
            this.head.Dock = System.Windows.Forms.DockStyle.Fill;
            this.head.Location = new System.Drawing.Point(3, 0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(379, 23);
            this.head.TabIndex = 6;
            this.head.Text = "SELECT YOUR  CHOICE";
            this.head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnComp, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnUser, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.Label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(198, 76);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(385, 68);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // btnComp
            // 
            this.btnComp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnComp.Location = new System.Drawing.Point(3, 33);
            this.btnComp.Name = "btnComp";
            this.btnComp.Size = new System.Drawing.Size(186, 32);
            this.btnComp.TabIndex = 0;
            this.btnComp.Text = "COMPUTER";
            this.btnComp.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUser.Location = new System.Drawing.Point(195, 33);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(187, 32);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "USER";
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.Label1, 2);
            this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label1.Location = new System.Drawing.Point(3, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(379, 30);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Want To Play Against ??";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResult
            // 
            this.btnResult.AutoSize = true;
            this.btnResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResult.Location = new System.Drawing.Point(198, 473);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(385, 32);
            this.btnResult.TabIndex = 16;
            this.btnResult.Text = "RESULT";
            this.btnResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TicTacToe";
            this.Size = new System.Drawing.Size(782, 505);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.TableLayoutGrid.ResumeLayout(false);
            this.TableLayoutHead.ResumeLayout(false);
            this.TableLayoutHead.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel TableLayoutGrid;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.TableLayoutPanel TableLayoutHead;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label head;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnComp;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label btnResult;
    }
}
