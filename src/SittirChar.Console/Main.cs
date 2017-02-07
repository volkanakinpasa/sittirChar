using System;

namespace SittirChar.Cons
{
    public class Start
    {
        public Start()
        {
            var model = new Model() {Name = @"ÈÈÈÈÈÈÈÈÈÈÈÇ¾å%&''''''''''''''''''"};

            var cleanerHandler = new TextCleanerHandler<Model>(new []{ 'È', '\''});

            cleanerHandler.Clean(model);

            System.Console.ReadLine();
        }
    }
}
