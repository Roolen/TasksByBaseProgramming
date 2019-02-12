namespace Task7
{
    class Appliance
    {
        public readonly string name;
        public readonly string iD;
        public readonly int price;

        public Appliance(string iD, int price, string name)
        {
            this.name = name;
            this.iD = iD;
            this.price = price;
        }
    }
}