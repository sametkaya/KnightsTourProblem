using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace KnihgtsTourDLL
{
    public class DrawChessBoardClass
    {
  
        public DrawChessBoardClass(ChessBoardUserKont ChessBoardControl)
        {
            ObjectsClass.ChessBoardControl = ChessBoardControl;
        }
        public DrawChessBoardClass()
        { }
        public void LetsDrawChessTable()
        {
            Point KareLocation = new Point(0, 0);
            int xi = 1;
         
            for (int y = 0; y < 8; y++)
            { 
                KareLocation.X = 0;
                for (int x = 0; x < 8; x++)
                {
                    ObjectsClass.Kareler[x, y].GraundImage = new PictureBox();
                    ObjectsClass.Kareler[x, y].GraundImage.Size = new Size(ObjectsClass.KareBoyut, ObjectsClass.KareBoyut);
                    ObjectsClass.Kareler[x, y].GraundImage.Name = "Kare[" + x.ToString() + y.ToString()+"]";
                    ObjectsClass.Kareler[x, y].GraundImage.Tag = new Point(x,y);
                    ObjectsClass.Kareler[x, y].GraundImage.Location = new Point(KareLocation.X, KareLocation.Y);
                    ObjectsClass.Kareler[x, y].GraundImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    ObjectsClass.Kareler[x, y].GraundImage.BorderStyle = BorderStyle.Fixed3D;
                    ObjectsClass.Kareler[x, y].GraundImage.BackColor = ObjectsClass.KareRenk[(x + y) % 2];
                    ObjectsClass.Kareler[x, y].GraundImage.MouseHover += new EventHandler(AllMouseOver);
                    ObjectsClass.Kareler[x, y].GraundImage.MouseClick +=new MouseEventHandler(AllMouseClick);
                    
                    ObjectsClass.Kareler[x, y].DefaultRenk = ObjectsClass.KareRenk[(x + y) % 2];
                    ObjectsClass.Kareler[x, y].MatrixKonum = new Point(x, y);
                    ObjectsClass.Kareler[x, y].No = xi;
                    ObjectsClass.Kareler[x, y].Steps.Identity = new Point(x, y);
                    ObjectsClass.Kareler[x, y].Steps.AllSteps = new List<Point>();
                    ObjectsClass.Kareler[x, y].Steps.AliveSteps = new List<Point>();
                    ObjectsClass.Kareler[x, y].Steps.KilledSteps = new Stack<Point>();
                    ObjectsClass.Kareler[x, y].Steps.TriedSteps = new List<Point>();
                    ObjectsClass.Kareler[x, y].Steps.Alive = true;

                    ObjectsClass.ChessBoardControl.Pnl_ChessBoard.Controls.Add(ObjectsClass.Kareler[x, y].GraundImage);
                    KareLocation.X = KareLocation.X + ObjectsClass.KareBoyut;

                    xi++;
                }

                KareLocation.Y = KareLocation.Y + ObjectsClass.KareBoyut;
            }



            ObjectsClass.ChessBoardControl.Pnl_ChessBoardGrnd.Location = new Point(20, 20);
            ObjectsClass.ChessBoardControl.Pnl_ChessBoard.Location = new Point(20, 20);
            ObjectsClass.ChessBoardControl.Pnl_ChessBoard.Size = new Size(ObjectsClass.KareBoyut * 8, ObjectsClass.KareBoyut * 8);

            ObjectsClass.ChessBoardControl.Pnl_ChessBoardGrnd.Size = new Size(ObjectsClass.ChessBoardControl.Pnl_ChessBoard.Size.Width + 40, ObjectsClass.ChessBoardControl.Pnl_ChessBoard.Size.Height + 40);


            Bitmap ChessBoardBitmap = new Bitmap(ObjectsClass.ChessBoardControl.Pnl_ChessBoardGrnd.Width, ObjectsClass.ChessBoardControl.Pnl_ChessBoardGrnd.Height);
            Rectangle Rectang = new Rectangle(0, 0, ObjectsClass.ChessBoardControl.Pnl_ChessBoardGrnd.Width, ObjectsClass.ChessBoardControl.Pnl_ChessBoardGrnd.Height);
            ObjectsClass.ChessBoardControl.Pnl_ChessBoardGrnd.DrawToBitmap(ChessBoardBitmap, Rectang);
            ObjectsClass.ChessBoardControl.PcrBx_ChessImage.Location = new Point(ObjectsClass.ChessBoardControl.Pnl_ChessBoardGrnd.Location.X + ObjectsClass.ChessBoardControl.Pnl_ChessBoardGrnd.Width + 100, ObjectsClass.ChessBoardControl.Pnl_ChessBoardGrnd.Location.Y);
            ObjectsClass.ChessBoardControl.PcrBx_ChessImage.Size = ObjectsClass.ChessBoardControl.Pnl_ChessBoardGrnd.Size;
            ObjectsClass.ChessBoardControl.PcrBx_ChessImage.Image = ChessBoardBitmap;


            ObjectsClass.ChessBoardControl.Size = new Size((ObjectsClass.ChessBoardControl.Pnl_ChessBoard.Size.Width * 2) + 220, ObjectsClass.ChessBoardControl.Pnl_ChessBoard.Size.Height + 80);
        }

        public void AllMouseOver(object Sender, EventArgs e)
        { 

        }

        public void AllMouseClick(object sender, MouseEventArgs e)
        {
            if (ObjectsClass.ChessBoardControl.Started)
                return;

            ObjectsClass.Kareler[ObjectsClass.StartKare.Steps.Identity.X, ObjectsClass.StartKare.Steps.Identity.Y].GraundImage.BackColor = ObjectsClass.Kareler[ObjectsClass.StartKare.Steps.Identity.X, ObjectsClass.StartKare.Steps.Identity.Y].DefaultRenk;
            ObjectsClass.Kareler[ObjectsClass.StartKare.Steps.Identity.X, ObjectsClass.StartKare.Steps.Identity.Y].GraundImage.Image = null;
            ObjectsClass.Kareler[((Point)(((PictureBox)sender).Tag)).X, ((Point)(((PictureBox)sender).Tag)).Y].GraundImage.BackColor = Color.Pink;
            ObjectsClass.Kareler[((Point)(((PictureBox)sender).Tag)).X, ((Point)(((PictureBox)sender).Tag)).Y].GraundImage.Image = ObjectsClass.KnightTransparent;
            ObjectsClass.StartKare = ObjectsClass.Kareler[((Point)(((PictureBox)sender).Tag)).X, ((Point)(((PictureBox)sender).Tag)).Y];

        }


 

     

    }
}
