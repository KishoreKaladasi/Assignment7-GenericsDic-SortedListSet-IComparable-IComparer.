using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;
using Assignment7Library;
using System.Text;
using System.Linq;

namespace Assignment7_GenericsDic_SortedListSet_IComparable
{
    public class SmartPhones
    {
        static void Main(string[] args)
        {
            List<SmartPhone> SmartPhonesList = new List<SmartPhone>();
            //1st way of adding data
            SmartPhone s1 = new SmartPhone(5, "Iphone", "15Series", 2500000.0);
            SmartPhonesList.Add(s1);
            //2nd way of adding data
            SmartPhone s2 = new SmartPhone();
            s2.IMEINo = 2;
            s2.Name = "Samsung";
            s2.Model = "S22";
            s2.Price = 80000;
            SmartPhonesList.Add(s2);
            //3rd way of adding data
            SmartPhone s3 = new SmartPhone(3, "Oneplus", "Nord", 15000.0);
            SmartPhonesList.Add(s3);
            SmartPhone s4 = new SmartPhone(1, "Pixel", "S10", 112000.0);
            SmartPhonesList.Add(s4);
            SmartPhone s5 = new SmartPhone(5, "poco", "x2", 16500.0);
            SmartPhonesList.Add(s5);


            IComparable(SmartPhonesList);
            Console.WriteLine("*****************************");
            IComparer(SmartPhonesList);
            Console.WriteLine("*****************************");
            Concat_Intersect_Dictionaries();
            Console.WriteLine("*****************************");
            SortedSet(s1, s2, s3, s4, s5);
            Console.WriteLine("*****************************");


            //LinkedList<SmartPhone> lilist = new LinkedList<SmartPhone>();
            //lilist.AddFirst(s1);
            //LinkedListNode<SmartPhone> nodeFor2 = lilist.AddAfter(lilist.First, s2);
            //lilist.AddAfter(nodeFor2, 3);
            //lilist.AddBefore(nodeFor2, 100);

            //lilist.AddLast(20);
            //foreach (var item in lilist)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadLine();

        }

        private static void SortedSet(SmartPhone s1, SmartPhone s2, SmartPhone s3, SmartPhone s4, SmartPhone s5)
        {
            SortedSet<SmartPhone> smt = new SortedSet<SmartPhone>();
            smt.Add(s1);
            smt.Add(s2);
            smt.Add(s3);
            smt.Add(s4);
            smt.Add(s5);

            foreach (SmartPhone phone in smt)
            {
                Console.WriteLine("Name: " + phone.Name + "||"
                 + " Price: " + phone.Price + "||"
                 + " MOdel: " + phone.Model + "||"
                 + " its IMEI: " + phone.IMEINo);
            }
        }

        private static void Concat_Intersect_Dictionaries()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();            //int---Key, string--value
            dic.Add(1, "Ajay");
            dic.Add(2, "Kajal");
            dic.Add(5, "Sujay");

            Dictionary<int, string> second_dic = new Dictionary<int, string>();
            second_dic.Add(1, "Ajay");
            second_dic.Add(2, "Jack");
            second_dic.Add(3, "Payal");
            second_dic.Add(5, "Sujay");

            Console.WriteLine("Concatenated Dictionaries");

            IEnumerable<KeyValuePair<int, String>> ConcatObj = dic.Concat(second_dic);

            foreach (KeyValuePair<int, string> pair in ConcatObj)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }


            Console.WriteLine("_________________________");
            Console.WriteLine("Intersection Dictionaries");
            Console.WriteLine("It returns only common data in both dictionaries");
            IEnumerable<KeyValuePair<int, String>> IntersectObj = dic.Intersect(second_dic);

            foreach (KeyValuePair<int, string> item in IntersectObj)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }

        private static void IComparer(List<SmartPhone> SmartPhonesList)
        {
            IComparerClass sorted = new IComparerClass();
            SmartPhonesList.Sort(sorted);
            foreach (SmartPhone phone in SmartPhonesList)
            {

                Console.WriteLine("Name: " + phone.Name + "||"
                  + " Price: " + phone.Price + "||"
                  + " MOdel: " + phone.Model + "||"
                  + " its IMEI: " + phone.IMEINo);
            }
             
        }

        private static void IComparable(List<SmartPhone> SmartPhonesList)
        {
            SmartPhonesList.Sort();
            foreach (SmartPhone phone in SmartPhonesList)
            {

                Console.WriteLine("Name: " + phone.Name + "||"
                  + " Price: " + phone.Price + "||"
                  + " MOdel: " + phone.Model + "||"
                  + " its IMEI: " + phone.IMEINo);
            }
        }
    }
}

