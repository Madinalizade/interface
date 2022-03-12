using System;

namespace Interface
{
    interface IMedine
    {
        string Name { get; set; }
        string Surname { get; set; }
    }
    class Person : IMedine
    {
        public string Name { get ; set ; }
        public string Surname { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
