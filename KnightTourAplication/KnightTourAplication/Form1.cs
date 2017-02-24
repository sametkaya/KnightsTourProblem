using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KnightTourAplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            Control_ChessBoard.StartLetsSolve();
           
        }

        private void Btn_Pause_Click(object sender, EventArgs e)
        {
            //Control_ChessBoard.ShowSolution();
        }

        private void Btn_Resume_Click(object sender, EventArgs e)
        {
            //Control_ChessBoard.StartShowSollition();
        }

        private void Btn_GoNext_Click(object sender, EventArgs e)
        {
            Control_ChessBoard.GoNext();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Control_ChessBoard.Reset();
        }

        private void Control_ChessBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
