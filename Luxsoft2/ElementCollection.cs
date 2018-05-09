using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luxsoft2
{
    class ElementCollection
    {
        public class Element
        {
            private int num;
            private String name;
            private int age;

            public int Num
            {
                get { return num; }
                set { num = value; }
            }
            public String Name
            {
                get { return name; }
                set { name = value; }
            }
            public int Age
            {
                get { return age; }
                set { age = value; }
            }
        }

        public static Collection<Element> uniqueColection(Collection<Element> input)
        {

            return new Collection<Element>(input
                .Where(y => y.Age > 20)//age>20
                .GroupBy(x => x.Num)//all elements are unique by "num"
                .Select(x => x.ElementAt(0)).ToList());//any of input elements

        }

        static void Main(string[] args)
        {

            Collection<Element> element =
                new Collection<Element>{ new Element {Num=3 ,Name="Barley", Age=23 },
                                new Element { Num=3,Name="Boots", Age=45 },
                                new Element { Num=1,Name="Whiskers", Age=1 },
                                new Element { Num=2,Name="Daisy", Age=56 } };

            Collection<Element> element2 = uniqueColection(element);


        }
    }
}
