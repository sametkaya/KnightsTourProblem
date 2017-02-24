using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace KnihgtsTourDLL
{
    public partial class ChessBoardUserKont : UserControl
    {
        Thread AlgorithmThread;
        public DrawChessBoardClass ChessBoard;
        public AlgorithmClass Algorithm;
        public ObjectsClass Nesne;
        public bool Started;
        public ChessBoardUserKont()
        {
            InitializeComponent();
            Started = false;
            AlgorithmThread = new Thread(new ThreadStart(LetsSolve));
            Algorithm = new AlgorithmClass();
            ChessBoard = new DrawChessBoardClass();
            Nesne = new ObjectsClass(this);

         
        }
        //ChessPlay c;
        private void ChessBoardUserKont_Load(object sender, EventArgs e)
        {

            ChessBoard.LetsDrawChessTable();


        }
        public void LetsSolve()
        {

            if (ObjectsClass.StartKare.GraundImage == null)
            {
                MessageBox.Show("Select Starting Corner");
                return;
            }

            Algorithm.CalcSteps(); //adımları hesaplar
            Algorithm.Loop64(ObjectsClass.StartKare.Steps); //başlangıç adımını verip döngüyü başlayır
            MessageBox.Show("I Solved");
        }
        public void StartLetsSolve() //algoritma threatini başlatma fonksiyonu
        {
            if (ObjectsClass.Algorithm_T_Started)//eğer algoritma treadti başlamıssa geri dön
                return;
            ObjectsClass.Algorithm_T_Started = true;
            AlgorithmThread.Start(); //thread stating
         

        }
        public void GoNext()
        {
            if ((!ObjectsClass.Solved) || (ObjectsClass.ActionNo> Algorithm.PointSolution.Count-1))
                return;

            

            ObjectsClass.Kareler[Algorithm.PointSolution[ObjectsClass.ActionNo].X, Algorithm.PointSolution[ObjectsClass.ActionNo].Y].GraundImage.Image = ObjectsClass.KnightTransparent;
            ObjectsClass.Kareler[Algorithm.PointSolution[ObjectsClass.ActionNo].X, Algorithm.PointSolution[ObjectsClass.ActionNo].Y].GraundImage.BackColor = Color.Yellow;
            ObjectsClass.Kareler[Algorithm.StepSolution[ObjectsClass.ActionNo].CameFrom.X, Algorithm.StepSolution[ObjectsClass.ActionNo].CameFrom.Y].GraundImage.BackColor = ObjectsClass.Kareler[Algorithm.StepSolution[ObjectsClass.ActionNo].CameFrom.X, Algorithm.StepSolution[ObjectsClass.ActionNo].CameFrom.Y].DefaultRenk;
           
            using (Graphics g = PcrBx_ChessImage.CreateGraphics())
            {

                Point P1 = new Point(Algorithm.PointSolution[ObjectsClass.ActionNo - 1].X * 70+45, Algorithm.PointSolution[ObjectsClass.ActionNo - 1].Y*70+45);
                Point P2 = new Point(Algorithm.PointSolution[ObjectsClass.ActionNo].X * 70+45, Algorithm.PointSolution[ObjectsClass.ActionNo].Y * 70+45);
                Point PYaz;
                if (ObjectsClass.ActionNo < 10)
                    PYaz = new Point(P1.X - 10, P1.Y - 10);
                else
                    PYaz = new Point(P1.X - 20, P1.Y - 10);

                

                g.DrawString(ObjectsClass.ActionNo.ToString(), new Font("Arial",30f),Brushes.Red, PYaz);
                g.DrawLine(ObjectsClass.Kalem, P1,P2);

            
            }
            ObjectsClass.ActionNo++;
            
            
        }
        public void ThreadTime(int Time)
        {
            ObjectsClass.ThreadSlepTime = Time;
        
        }
        public void Reset() //reset olayını boşver şimdilik
        { 
        
     
         ObjectsClass.ThreadSlepTime = 300;

         for (int y = 0; y < 8; y++)
         {
             for (int x = 0; x < 8; x++)
             {
                 ObjectsClass.Kareler[x, y].GraundImage.Image = null;
                 ObjectsClass.Kareler[x, y].Steps.Alive = true;
                 ObjectsClass.Kareler[x, y].MatrixKonum = new Point(0, 0);
                 ObjectsClass.Kareler[x, y].No = 0;
                 ObjectsClass.Kareler[x, y].Steps.AliveSteps.Clear();
                 ObjectsClass.Kareler[x, y].Steps.AllSteps.Clear();
                 ObjectsClass.Kareler[x, y].Steps.Identity = new Point(0, 0);
                 ObjectsClass.Kareler[x, y].Steps.TriedSteps.Clear();
                 ObjectsClass.Kareler[x, y].Steps.KilledSteps.Clear();
             }
         }
           

        }

    }
}
