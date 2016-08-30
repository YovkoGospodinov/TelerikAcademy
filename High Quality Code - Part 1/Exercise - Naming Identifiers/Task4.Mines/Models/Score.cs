namespace Task4.Mines.Models
{
    public class Score
    {
        private string name;
        private int result;

        public Score()
        {
        }

        public Score(string name, int result) 
            : this()
        {
            this.Name = name;
            this.Result = result;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public int Result
        {
            get { return this.result; }
            private set { this.result = value; }
        }
    }
}
