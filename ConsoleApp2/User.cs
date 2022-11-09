using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    //Whatsapp example
   public class User
    {
        public void chat()
        {
            Console.WriteLine("I can chat");
        }
        public void videoCall()
        {
            Console.WriteLine("I can make video call");
        }
        public void sendDocs()
        {
            Console.WriteLine("I can send docs");
        }
        public void changeGrpName()
        {
            Console.WriteLine("I can change group name");
        }
    }
    
    //admin is a child class inherited from use class(base class/parent class)

    public class Admin: User
    {
        //creating reference variable of user inside the admin class

        public void restrict()
        {
            Console.WriteLine("I can restrict user");
        }
        public void addUser()
        {
            Console.WriteLine("I can add users");
        }
    }
}
