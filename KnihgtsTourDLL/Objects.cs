using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace KnihgtsTourDLL
{
    public class ObjectsClass
    {
        public static bool RunMode;
        public static bool Algorithm_T_Started; //thread başlayınca true oluyor thread tekrar çalışmasın
        public static bool Solved;
        public static bool ShowSolliton_T_Started;
        public static int ThreadSlepTime;
        public static int ActionNo;
        public static Pen Kalem;
        public static AdjustableArrowCap Cap;
        public Stack<ObjectsClass.StepsStruct> StepSolution;//cisim solitionu
        public List<Point> PointSolution;//point solliitionu
        public static ChessBoardUserKont ChessBoardControl;
        public static Color[] KareRenk;
        public struct StepsStruct
        {
            public bool Alive;
            public Point CameFrom;
            public Point Identity;
            public List<Point> AllSteps;
            public List<Point> AliveSteps;
            public Stack<Point> KilledSteps;
            public List<Point> TriedSteps;
        
        }
        public struct OneKare
        {
            public PictureBox GraundImage;
            public Color DefaultRenk;
            public int No;
            public Point MatrixKonum;
            public StepsStruct Steps;

        }
        public static OneKare[,] Kareler;
        public static OneKare StartKare;//seçilmiş başlangıç karesi
        public static Bitmap KnightTransparent;
        public static ArrayList Corners;
        public static int KareBoyut;

        public ObjectsClass(ChessBoardUserKont ChessBoardControl)
        {
           StepSolution = new Stack<ObjectsClass.StepsStruct>();
            PointSolution = new List<Point>();
            ThreadSlepTime = 300;
            ActionNo =1;
            Cap =new AdjustableArrowCap(3.5f, 2, false );
            Kalem = new Pen(Color.FromArgb(150,Color.BlueViolet),10);
            Kalem.CustomEndCap = Cap;
            Kalem.StartCap = LineCap.Round;
            ObjectsClass.ChessBoardControl = ChessBoardControl;
            KareRenk = new Color[2] { Color.White, Color.Sienna}; //karelerin renkleri
            Corners = new ArrayList();
            Kareler = new OneKare[8, 8];
            KnightTransparent = new Bitmap(Resource.Knight);
            KnightTransparent.MakeTransparent(Color.White);
            KareBoyut = 70; //karelerin boyutları
        }
    }
}
