using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luxsoft2
{

    class TreesNodes
    {
        class BTN
        {
            private int val;
            private BTN left;
            private BTN right;


            public int Val
            {
                get { return val; }
                set { val = value; }
            }
            public BTN Left
            {
                get { return left; }
                set { left = value; }
            }
            public BTN Right
            {
                get { return right; }
                set { right = value; }
            }

            public override bool Equals(object obj)
            {
                BTN _obj = (BTN)obj;
                return  Val == _obj.Val 
                        &&object.Equals(Left, _obj.Left) 
                        && object.Equals(Right, _obj.Right);
            }
        }


        static void Main(string[] args)
        {
            BTN bTN2 = new BTN();
            bTN2.Val = 4;
            //bTN.Left = bTN2;
            //bTN.Right = bTN3;
            BTN bTN3 = new BTN();
            bTN3.Val = 6;
            object.Equals(bTN2, bTN3);
            //bool asd = object.Equals(bTN2, bTN3);

            BTN bTN = new BTN();
            bTN.Val = 1;
            bTN.Left = bTN2;
            bTN.Right = bTN3;
            //



            BTN bTN22 = new BTN();
            bTN22.Val = 4;
            //bTN22.Left = bTN;

            //bTN.Left = bTN2;
            //bTN.Right = bTN3;
            BTN bTN32 = new BTN();
            bTN32.Val = 6;



            BTN bTN12 = new BTN();
            bTN12.Val = 1;
            bTN12.Left = bTN22;
            bTN12.Right = bTN32;
            ////

            bool a=bTN.Equals(bTN12);


        }
    }
}
