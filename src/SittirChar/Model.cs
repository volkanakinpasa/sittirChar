namespace SittirChar
{
    public class Model
    {
        [Clean()]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Double { get; set; }
        public float Float { get; set; }
        public char Char { get; set; }
        public object Obj { get; set; }

    }
}