namespace KnightTourAplication
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Resume = new System.Windows.Forms.Button();
            this.Btn_GoNext = new System.Windows.Forms.Button();
            this.Btn_Pause = new System.Windows.Forms.Button();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Control_ChessBoard = new KnihgtsTourDLL.ChessBoardUserKont();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Resume);
            this.panel1.Controls.Add(this.Btn_GoNext);
            this.panel1.Controls.Add(this.Btn_Pause);
            this.panel1.Controls.Add(this.Btn_Start);
            this.panel1.Location = new System.Drawing.Point(853, 256);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 263);
            this.panel1.TabIndex = 1;
            // 
            // Btn_Resume
            // 
            this.Btn_Resume.Location = new System.Drawing.Point(16, 135);
            this.Btn_Resume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Resume.Name = "Btn_Resume";
            this.Btn_Resume.Size = new System.Drawing.Size(79, 54);
            this.Btn_Resume.TabIndex = 4;
            this.Btn_Resume.Text = "Resume";
            this.Btn_Resume.UseVisualStyleBackColor = true;
            this.Btn_Resume.Click += new System.EventHandler(this.Btn_Resume_Click);
            // 
            // Btn_GoNext
            // 
            this.Btn_GoNext.Location = new System.Drawing.Point(17, 197);
            this.Btn_GoNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_GoNext.Name = "Btn_GoNext";
            this.Btn_GoNext.Size = new System.Drawing.Size(77, 54);
            this.Btn_GoNext.TabIndex = 2;
            this.Btn_GoNext.Text = "GoNext";
            this.Btn_GoNext.UseVisualStyleBackColor = true;
            this.Btn_GoNext.Click += new System.EventHandler(this.Btn_GoNext_Click);
            // 
            // Btn_Pause
            // 
            this.Btn_Pause.Location = new System.Drawing.Point(16, 74);
            this.Btn_Pause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Pause.Name = "Btn_Pause";
            this.Btn_Pause.Size = new System.Drawing.Size(79, 54);
            this.Btn_Pause.TabIndex = 1;
            this.Btn_Pause.Text = "Pause";
            this.Btn_Pause.UseVisualStyleBackColor = true;
            this.Btn_Pause.Click += new System.EventHandler(this.Btn_Pause_Click);
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(17, 12);
            this.Btn_Start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(77, 54);
            this.Btn_Start.TabIndex = 0;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Control_ChessBoard
            // 
            this.Control_ChessBoard.Location = new System.Drawing.Point(14, 26);
            this.Control_ChessBoard.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Control_ChessBoard.Name = "Control_ChessBoard";
            this.Control_ChessBoard.Size = new System.Drawing.Size(1787, 788);
            this.Control_ChessBoard.TabIndex = 0;
            this.Control_ChessBoard.Load += new System.EventHandler(this.Control_ChessBoard_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Control_ChessBoard);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private KnihgtsTourDLL.ChessBoardUserKont Control_ChessBoard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Resume;
        private System.Windows.Forms.Button Btn_GoNext;
        private System.Windows.Forms.Button Btn_Pause;
        private System.Windows.Forms.Button Btn_Start;
    }
}