using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICOperations
{
    public class Class1
    {
        //1
        public string Vote(string x)
        {
            if(x=="X")
            {
                return ("Not eligible")

            }
            else
            {
                return ("Eligible");
            }
        }


        //2
        public string FindGender(int num)
        {
            if(num>500)
            {
                return ("Female");
            }

        else
            {
                return ("Male");
            }
        }

        //3
        public string DOB(int num)
        {
            if(num>500)
            {
                num = num - 500;
            }

            if (num >= 1 && num <= 31)
            {
                return ("01." + num);
            }

            else if (num >= 32 && num <= 60)
            {
                return ("02." + (num - 31));
            }

            else if (num >= 61 && num <= 91)
            {
                return ("03." + (num - 60));
            }

            else if (num >= 92 && num <= 121)
            {
                return ("04." + (num - 91));
            }


            else if (num >= 122 && num <= 152)
            {
                return ("05." + (num - 121));

            }


            else if (num >= 153 && num <= 182)
            {
                return ("06." + (num - 152));
            }


            else if (num >= 183 && num <= 213)
            {
                return ("07." + (num - 182));
            }


            else if (num >= 214 && num <= 244)
            {
                return ("08." + (num - 213));
            }


            else if (num >= 245 && num <= 274)
            {
                return ("09." + (num - 244));
            }


            else if (num >= 275 && num <= 305)
            {
                return ("10." + (num - 274));
            }


            else if (num >= 306 && num <= 335)
            {
                return ("11." + (num - 305));
            }


            else
            {
                return ("12." + (num - 335));
            }
        }




    }
}
