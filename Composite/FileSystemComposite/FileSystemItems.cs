﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.FileSystemComposite
{
    public class FolderItem(string name) : FileSystemComponent
    {
        public override string Name { get; } = name;
        public IReadOnlyList<FileSystemComponent> Items => _items;

        private readonly List<FileSystemComponent> _items = [];

        public override void Add(FileSystemComponent item) => _items.Add(item);

        public override int GetSize() => Items.Sum(item => item.GetSize());

        public override void Display(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)}{Name} ({GetSize()}KB)");
            foreach (var item in Items)
            {
                item.Display(indent + 4);
            }
        }


        public override void Remove(string name)
        {
            var toRemove = _items.FirstOrDefault(it => it.Name == name)
                ?? throw new FileNotFoundException();

            _items.Remove(toRemove);
        }
    }

    public class FileItem(string name, int size) : FileSystemComponent
    {
        public override string Name { get; } = name;
        public int Size { get; set; } = size;

        public override int GetSize() => Size;

        public override void Display(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)}{Name} ({GetSize()}KB)");

        }
    }
}
