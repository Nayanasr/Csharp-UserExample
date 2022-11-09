using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin _admin = new Admin();
            _admin.sendDocs();
            _admin.restrict();
        }
    }
}
