using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    //Composite-Klasse
    public class Directory : FileSystemComponent
    {
        private List<FileSystemComponent> includedFiles = new List<FileSystemComponent>();
        public Directory(string name)
        {
            Name = name;
        }

        //rekursiver Aufruf
        public override void Print()
        {
            Console.WriteLine($"Verzeichnis: {Name}");

            foreach (FileSystemComponent component in includedFiles)
            {
                component.Print();
            }
        }

        //Helfer-Methoden
        public void Add(FileSystemComponent component)
        {
            includedFiles.Add(component);
        }
        public void Remove(FileSystemComponent component)
        {
            includedFiles.Remove(component);
        }
        public FileSystemComponent GetFileSystemComponent(int index)
        {
            return includedFiles[index];
        }

    }
}
