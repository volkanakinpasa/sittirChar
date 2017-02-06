using System;

namespace SittirChar.Cons
{
    public class Start
    {
        public Start()
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;

            while (true)
            {
                System.Console.WriteLine("Enter a name");
                var input = System.Console.ReadLine();

                if (input != null && input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                var model = new Model() {Name = input};

                var cleanerHandler = new TextCleanerHandler<Model>(new []{'Ş','ş'});

                cleanerHandler.Clean(model);

                System.Console.WriteLine(model.Name);
            }
        }
    }
}
