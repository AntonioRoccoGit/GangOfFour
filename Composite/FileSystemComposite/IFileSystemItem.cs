using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.FileSystemComposite
{
    public abstract class FileSystemComponent
    {
        public abstract string Name { get; }
        
        public abstract int GetSize();
        public abstract void Display(int indent = 0);
     
        public virtual void Add(FileSystemComponent item)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(string name)
        {
            throw new NotImplementedException();
        }

    }
}
