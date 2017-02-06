namespace SittirChar
{
    public class Model
    {
        [Clean]
        public int Id { get; set; }

        [Clean]
        public string Name { get; set; }

        [Clean]
        public double Double { get; set; }

        [Clean]
        public float Float { get; set; }

        [Clean]
        public char Char { get; set; }

        [Clean]
        public object Obj { get; set; }
    }
}