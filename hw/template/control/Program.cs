using System;

namespace control
{
    class Program
    {
        static void Main(string[] args)
        {
            Haircut afro = new AfroHaircut(5, 60);
            afro.GetHaircut();
        }
    }
}
