using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.FileSystemComposite
{
    public abstract class FileSystemItem
    {
        public abstract string Name { get; }
        
        public abstract int GetSize();
        public abstract void Display(int indent = 0);
     
        public abstract void Add(FileSystemItem item);
        public abstract void Remove(string name);

    }
}
