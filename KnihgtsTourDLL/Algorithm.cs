using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace KnihgtsTourDLL
{
    public class AlgorithmClass
    {

        public AlgorithmClass()
        {


        }

        public List<ObjectsClass.StepsStruct> StepSolution = new List<ObjectsClass.StepsStruct>();
     
        public List<Point> PointSolution = new List<Point>();
        ObjectsClass.StepsStruct NextStep;
        Point NextStepPoint;
        int d=0;

        public void Loop64(ObjectsClass.StepsStruct Step)
        {
            StepSolution.Add(Step);
            PointSolution.Add(Step.Identity);
            ObjectsClass.Kareler[Step.Identity.X, Step.Identity.Y].Steps.Alive = false;
            KillStep(ObjectsClass.Kareler[Step.Identity.X, Step.Identity.Y].Steps);

            if (StepSolution.Count < 64)
            {
                if ((Step.AliveSteps.Count == 0) || (Step.TriedSteps.Count == Step.AliveSteps.Count))
                {
                    Step = GoBackStep(ObjectsClass.Kareler[Step.Identity.X, Step.Identity.Y].Steps);
                    StepSolution.RemoveAt(0); // yeni gelenide çıkarıyoruz çünkü geri döndürüp tekrar deneyeceğiz
                    PointSolution.Remove(Step.Identity);//aynı şekilde point sollitondan da çıkarıyorz
                    ObjectsClass.Kareler[Step.Identity.X, Step.Identity.Y].Steps.Alive = true;
                }
                else
                {
                    Step = StepDecition(Step);
                }
            }

            if (StepSolution.Count < 64)
            {
                Loop64(ObjectsClass.Kareler[Step.Identity.X, Step.Identity.Y].Steps);
            }
            else
            {
                ObjectsClass.Solved = true;
                return;
            }
        }

        public void KillStep(ObjectsClass.StepsStruct Step)
        {
                foreach (Point P in Step.AllSteps)//tüm üyelerinin içinde bu adımı öldürüyoruz
                {
                    ObjectsClass.Kareler[P.X, P.Y].Steps.AliveSteps.Remove(Step.Identity);// yaşayanlar arasında öl
                    ObjectsClass.Kareler[P.X, P.Y].Steps.KilledSteps.Push(Step.Identity);//ölüler arasına katıl
                }
        }
        public ObjectsClass.StepsStruct StepDecition(ObjectsClass.StepsStruct Step)
        {
            ObjectsClass.StepsStruct DecitedStep = ObjectsClass.Kareler[Step.AliveSteps[0].X,Step.AliveSteps[0].Y].Steps;
            
            foreach (Point P in Step.AliveSteps) //yaşayan tüm stepleri tarıyoruz
            {
                if ((ObjectsClass.Kareler[P.X, P.Y].Steps.AliveSteps.Count < DecitedStep.AliveSteps.Count) && (!ObjectsClass.Kareler[Step.Identity.X,Step.Identity.Y].Steps.TriedSteps.Contains(P))) 
                    // amaç en az elemanı bulunan stepbe dallanmak ikinci şarttaki amaç daha önce denenmiş stebi denememek
                {
                    DecitedStep = ObjectsClass.Kareler[P.X, P.Y].Steps;

                }
            
            }
            ObjectsClass.Kareler[Step.Identity.X,Step.Identity.Y].Steps.TriedSteps.Add(DecitedStep.Identity);// denenmiş olan stepleri listeye ekliyoruz ki geri adım attığımızda tekrar denemeyelim
            ObjectsClass.Kareler[DecitedStep.Identity.X, DecitedStep.Identity.Y].Steps.CameFrom = Step.Identity;  //neden geldiğini ekliyoruz, geri adımlarda işimize yarıyor


            return ObjectsClass.Kareler[DecitedStep.Identity.X, DecitedStep.Identity.Y].Steps;
        }

        public ObjectsClass.StepsStruct GoBackStep(ObjectsClass.StepsStruct Step) // eğer step'in hiç çocuğu yok ve solution 64 olmamışsa buraya girer
        {

            ObjectsClass.Kareler[Step.Identity.X, Step.Identity.Y].Steps.AliveSteps.Clear();
            ObjectsClass.Kareler[Step.Identity.X, Step.Identity.Y].Steps.KilledSteps.Clear();
            ObjectsClass.Kareler[Step.Identity.X, Step.Identity.Y].Steps.TriedSteps.Clear();
            ObjectsClass.Kareler[Step.Identity.X, Step.Identity.Y].Steps.Alive = true;
            //ObjectsClass.Kareler[Step.Identity.X, Step.Identity.Y].Steps.TriedSteps.Clear(); // geri gittiğimiz ve daha sonra tekrar geldiğimizde denemiş çocuklar sıfırlanmalı
            StepSolution.RemoveAt(0); // daha önce soluşuna eklenmiş olan stebi solution'dan çıkarıyoruz
            PointSolution.Remove(Step.Identity);//aynı şekilde point sollitondan da çıkarıyorz

            foreach (Point P in Step.AllSteps)// step'ten geri dönüyorsan daha önce öldürdüğümüz stebi diğer üyeler içinde canlandırıyoruz
            {
                if (ObjectsClass.Kareler[P.X, P.Y].Steps.Alive)
                {
                    Step.AliveSteps.Add(P);
                }

                else
                {
                    Step.KilledSteps.Push(P);
                }

                ObjectsClass.Kareler[P.X, P.Y].Steps.AliveSteps.Add(Step.Identity);// Canlan
                ObjectsClass.Kareler[P.X, P.Y].Steps.KilledSteps.Pop();//ölüler arasından çık
                //ObjectsClass.Kareler[P.X, P.Y].Steps.TriedSteps.Remove(Step.Identity);

            }

            ObjectsClass.StepsStruct BackStep = ObjectsClass.Kareler[Step.CameFrom.X,Step.CameFrom.Y].Steps; // step'in parentine gidiyoruz
            Step.CameFrom = new Point(99,99);//geri gidiyorsak bir daha kii gelişimizde parenti değişebilir sıfırlıyorz
          
            return ObjectsClass.Kareler[BackStep.Identity.X, BackStep.Identity.Y].Steps;
        
        
        }

        public void CalcSteps()
        {

            foreach (ObjectsClass.OneKare Kare in ObjectsClass.Kareler)
            {
                int x = Kare.MatrixKonum.X;
                int y = Kare.MatrixKonum.Y;
          
                if (x + 1 <= 7)
                {
                    if (y + 2 <= 7)
                        Kare.Steps.AllSteps.Add(new Point(x + 1, y + 2));
                    if (y - 2 >= 0)
                        Kare.Steps.AllSteps.Add(new Point(x + 1, y - 2));
                }
                //x azaltım
                if (x - 1 >= 0)
                {
                    if (y + 2 <= 7)
                        Kare.Steps.AllSteps.Add(new Point(x - 1, y + 2));
                    if (y - 2 >= 0)
                        Kare.Steps.AllSteps.Add(new Point(x - 1, y - 2));
                }

                //y artırım

                if (y + 1 <= 7)
                {
                    if (x + 2 <= 7)
                        Kare.Steps.AllSteps.Add(new Point(x + 2, y + 1));
                    if (x - 2 >= 0)
                        Kare.Steps.AllSteps.Add(new Point(x - 2, y + 1));
                }
                //y azaltım
                if (y - 1 >= 0)
                {
                    if (x + 2 <= 7)
                        Kare.Steps.AllSteps.Add(new Point(x + 2, y - 1));
                    if (x - 2 >= 0)
                        Kare.Steps.AllSteps.Add(new Point(x - 2, y - 1));
                }

                Kare.Steps.AliveSteps.AddRange(Kare.Steps.AllSteps); //en başta tüm eklenen stepler hayatta

            }
        }
    }
}
