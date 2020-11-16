namespace ConsoleUI
{
    class Repository
    {
        public string Destination { get; set; }
        public int Type { get; set; }

        public Repository(string _destination, int _type)
        {
            this.Destination = _destination;
            this.Type = _type;
        }
        public Repository()
        {
            Destination = "";
            Type = 0;
        }

    }
}
