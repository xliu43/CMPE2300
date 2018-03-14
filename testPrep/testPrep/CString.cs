using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testPrep
{
    class CString:IComparable
    {
        internal String str;
        static int counter;
        static CString()
        {
            Console.WriteLine("hello");

        }
        public CString(string s)
        {
            str = s;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is CString))
            {
                return false;
            }
            return str.Equals(((CString)obj).str); 
        }

        public override int GetHashCode()
        {
            return 1;
        }
        public int CompareTo(object obj)
        {


            if (!(obj is CString))
            {
                throw new ArgumentException();
            }
            if (str.Length== ((CString)obj).str.Length)
            {
                return str.CompareTo(((CString)obj).str);
            }
            return str.Length.CompareTo(((CString)obj).str.Length);

        }
        public static int CompDesc(CString a, CString b)
        {
            return -1 * (a.str.CompareTo(b.str));


        }


        public override string ToString()
        {
            return str;
        }
    }
}
