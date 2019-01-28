namespace Task3
{
    enum TypeChimicalElement
    {
        Lithium,
        Cobalt,
        Nickel,
        Iron,
        Gold,
        Mercury
    }

    class Sample
    {
        public int number;
        public ChimicalElement[] chimicalElements = new ChimicalElement[6];

        public Sample()
        {
            for (int i = 0; i < chimicalElements.Length; i++)
            {
                chimicalElements[i].Name = "";
                chimicalElements[i].Procent = 0;
            }
        }

        public struct ChimicalElement
        {
            public string Name { get; set; }
            private int procent;

            public int Procent
            {
                set
                {
                    if (value >= 0 && value <= 100)
                        procent = value;
                }
                get => procent;
            }
        }
    }
}