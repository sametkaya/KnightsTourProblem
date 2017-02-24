namespace KnihgtsTourDLL
{
    partial class ChessBoardUserKont
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
            this.Pnl_ChessBoard = new System.Windows.Forms.Panel();
            this.Pnl_ChessBoardGrnd = new System.Windows.Forms.Panel();
            this.Pnl_Platform = new System.Windows.Forms.Panel();
            this.PcrBx_ChessImage = new System.Windows.Forms.PictureBox();
            this.Pnl_ChessBoardGrnd.SuspendLayout();
            this.Pnl_Platform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcrBx_ChessImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_ChessBoard
            // 
            this.Pnl_ChessBoard.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Pnl_ChessBoard.Location = new System.Drawing.Point(17, 17);
            this.Pnl_ChessBoard.Name = "Pnl_ChessBoard";
            this.Pnl_ChessBoard.Size = new System.Drawing.Size(186, 135);
            this.Pnl_ChessBoard.TabIndex = 0;
            // 
            // Pnl_ChessBoardGrnd
            // 
            this.Pnl_ChessBoardGrnd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pnl_ChessBoardGrnd.Controls.Add(this.Pnl_ChessBoard);
            this.Pnl_ChessBoardGrnd.Location = new System.Drawing.Point(3, 3);
            this.Pnl_ChessBoardGrnd.Name = "Pnl_ChessBoardGrnd";
            this.Pnl_ChessBoardGrnd.Size = new System.Drawing.Size(249, 205);
            this.Pnl_ChessBoardGrnd.TabIndex = 1;
            // 
            // Pnl_Platform
            // 
            this.Pnl_Platform.BackColor = System.Drawing.Color.IndianRed;
            this.Pnl_Platform.Controls.Add(this.PcrBx_ChessImage);
            this.Pnl_Platform.Controls.Add(this.Pnl_ChessBoardGrnd);
            this.Pnl_Platform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Platform.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Platform.Name = "Pnl_Platform";
            this.Pnl_Platform.Size = new System.Drawing.Size(496, 346);
            this.Pnl_Platform.TabIndex = 2;
            // 
            // PcrBx_ChessImage
            // 
            this.PcrBx_ChessImage.BackColor = System.Drawing.Color.Lime;
            this.PcrBx_ChessImage.Location = new System.Drawing.Point(287, 20);
            this.PcrBx_ChessImage.Name = "PcrBx_ChessImage";
            this.PcrBx_ChessImage.Size = new System.Drawing.Size(131, 91);
            this.PcrBx_ChessImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcrBx_ChessImage.TabIndex = 1;
            this.PcrBx_ChessImage.TabStop = false;
            // 
            // ChessBoardUserKont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pnl_Platform);
            this.Name = "ChessBoardUserKont";
            this.Size = new System.Drawing.Size(496, 346);
            this.Load += new System.EventHandler(this.ChessBoardUserKont_Load);
            this.Pnl_ChessBoardGrnd.ResumeLayout(false);
            this.Pnl_Platform.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PcrBx_ChessImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel Pnl_ChessBoard;
        public System.Windows.Forms.Panel Pnl_ChessBoardGrnd;
        public System.Windows.Forms.Panel Pnl_Platform;
        public System.Windows.Forms.PictureBox PcrBx_ChessImage;
    }
}
