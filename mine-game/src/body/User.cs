namespace mine_game.src.body
{
    internal class User
    {
        private long id;
        private string name;
        private int age;
        private string pwd;

        public string Pwd { get => pwd; set => pwd = value; }
        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }


    }
}
