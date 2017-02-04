namespace SittirChar
{
    public class Start
    {
        public Start()
        {
            Model model = new Model();
            TextCleanerHandler<Model> cleanerHandler = new TextCleanerHandler<Model>();
            cleanerHandler.Clean(model);
        }
    }
}
