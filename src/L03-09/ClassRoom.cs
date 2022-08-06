using L03_09.Pupil.DerivedClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_09.Pupil;
internal class ClassRoom
{
    private static readonly int classmatesNumber = 4;
    private static Random _random = new Random();

    private Pupil[] classmates;
    public ClassRoom(Pupil pupil1)
    {
        classmates = new Pupil[classmatesNumber];
        classmates[0] = pupil1;
        FillClass(1);
    }
    public ClassRoom(Pupil pupil1, Pupil pupil2)
    {
        classmates = new Pupil[classmatesNumber];
        classmates[0] = pupil1;
        classmates[1] = pupil2;
        FillClass(2);
    }
    private void FillClass(int lastClassmate)
    {
        for (int i = lastClassmate; i < classmatesNumber; i++)
        {
            switch (PupilDerivedclassesList.Subclasses[_random.Next(PupilDerivedclassesList.Subclasses.Length)])
            {
                case "ExcelentPupil":
                    classmates[i] = new DerivedClasses.ExcelentPupil();
                    break;
                case "GoodPupil":
                    classmates[i] = new DerivedClasses.GoodPupil();
                    break;
                case "BadPupil":
                    classmates[i] = new DerivedClasses.BadPupil();
                    break;
                default:
                    classmates[i] = new Pupil();
                    break;
            }
        }
    }
    public void Show()
    {
        for (int i = 0; i < classmatesNumber; i++)
        {
            Console.WriteLine($"Pupil {i}: ");
            classmates[i].Study();
            classmates[i].Read();
            classmates[i].Write();
            classmates[i].Relax();
            Console.WriteLine("-------------");
        }
    }
}
