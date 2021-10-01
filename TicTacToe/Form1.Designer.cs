
namespace TicTacToe
{
    partial class Form1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtMessageArea = new System.Windows.Forms.TextBox();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(414, 121);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtMessageArea
            // 
            this.txtMessageArea.Location = new System.Drawing.Point(119, 29);
            this.txtMessageArea.Name = "txtMessageArea";
            this.txtMessageArea.Size = new System.Drawing.Size(197, 20);
            this.txtMessageArea.TabIndex = 15;
            this.txtMessageArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlBoard
            // 
            this.pnlBoard.Location = new System.Drawing.Point(42, 73);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(359, 340);
            this.pnlBoard.TabIndex = 16;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.txtMessageArea);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtMessageArea;
        private System.Windows.Forms.Panel pnlBoard;
    }
}

