using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    class car
    {
        public car()
        {

        }
    }

    public class MyIntList
    {
        private List<int> mNumbers = new List<int>();

        public void AddNumber(int number)
        {
            mNumbers.Add(number);
        }

        public int GetNumber(int i)
        {
            return mNumbers[i];
        }
    }

    public class MyStringList
    {
        private List<string> mString = new List<string>();

        public void AddString(String txt)
        {
            mString.Add(txt);
        }

        public string GetString(int i)
        {
            return mString[i];
        }
    }

    public class MyList<T>
    {
        private List<T> mList = new List<T>();

        public void AddNumber(T thing)
        {
            mList.Add(thing);
        }

        public T GetThing(int i)
        {
            return mList[i];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new MyIntList();
            numbers.AddNumber(10);
            numbers.AddNumber(20);
            numbers.AddNumber(30);
            numbers.AddNumber(40);

            Console.WriteLine(numbers.GetNumber(6));

            var txt = new MyStringList();
            txt.AddString("0l");
            txt.AddString("1st");
            txt.AddString("2yt");
            txt.AddString("33");
            txt.AddString("4h");
            txt.AddString("5f");
            txt.AddString("6i");
        
            Console.WriteLine(txt.GetString(6));
            Console.ReadLine();

            var getallen = new MyList<int>();
            getallen.AddNumber(100);
            getallen.AddNumber(90);
            getallen.AddNumber(80);
            getallen.AddNumber(70);
            getallen.AddNumber(60);
            getallen.AddNumber(50);
        }
    }
}
