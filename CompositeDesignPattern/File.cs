namespace CompositeDesignPattern
{
    internal class File : IFileSystem
    {
        private readonly string _name;
        public File(string name)
        {
            _name = name;
        }

        //To display file name
        public void Display()
        {
            Console.WriteLine("File Name:"+ _name);
        }
    }
}
