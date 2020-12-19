using System;
namespace control
{
    public class AfroHaircut : Haircut
    {
        public AfroHaircut(int length, int visit) : base(length, visit) { }

        public override void CutHair()
        {
            Console.WriteLine("Getting an Afro haircut...");
        }
    }
}
