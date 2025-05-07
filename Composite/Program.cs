using Composite.FileSystemComposite;

namespace GangOfFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EsempioFileSystem();
        }

        static void EsempioFileSystem()
        {
            var file1 = new FileItem("file1.txt", 254);
            var file2 = new FileItem("file2.txt", 126);
            var file3 = new FileItem("file3.txt", 117);

            var subfolder = new FolderItem("subfolder");
            subfolder.Add(file2);
            subfolder.Add(file3);

            var root = new FolderItem("root");
            root.Add(file1);
            root.Add(subfolder);

            root.Display();

            // Rimuoviamo un file dalla sottocartella
            subfolder.Remove("file2.txt");

            Console.WriteLine("\nDopo la rimozione:");
            root.Display();
        }
    }
}
