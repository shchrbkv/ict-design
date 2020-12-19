using System;
namespace control
{
    public abstract class Haircut
    {
        public int LastVisit { get; set; }
        public int Length { get; set; }

        public Haircut(int length, int visit)
        {
            Length = length;
            LastVisit = visit;
        }

        public void GetHaircut()
        {
            ChooseParameters(Length, LastVisit);
            CutHair();
            Console.WriteLine("You've got a haircut with length {0}cm in {1} minutes",
                Length, LastVisit * 0.6);
        }

        private void ChooseParameters(int length, int visit)
        {
            Length = length;
            LastVisit = visit;
        }

        public abstract void CutHair();
    }
}
