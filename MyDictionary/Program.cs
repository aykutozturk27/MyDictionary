using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> employees = new MyDictionary<int, string>();
            employees.Add(1, "Aykut Öztürk");
            employees.Add(2, "Engin Demiroğ");

            employees.GetList();
        }
    }
}
