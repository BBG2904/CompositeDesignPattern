namespace CompositeDesignPattern
{
    internal class Folder : IFileSystem
    {
        private readonly string _name;
        private List<IFileSystem> _files = new List<IFileSystem>();
        public Folder(string name)
        {
            _name = name;
        }

        public void AddFile(IFileSystem file)
        {
            _files.Add(file);
            
        }
        public void RemoveFile(IFileSystem file)
        {
            _files.Remove(file);
            
        }
        public void Display()
        {
            Console.WriteLine("Folder name is "+_name);
            foreach (var file in _files)
            {
                file.Display();
            }

        }
    }
}
