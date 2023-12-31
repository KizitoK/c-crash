namespace Giraffe
{
    class NigerianChef : Chef
    {
        public void MakeJollof()
        {
            Console.WriteLine("The Chef makes Jollof");
        }
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes Ofe Nsala with Chicken");
        }
    }
}