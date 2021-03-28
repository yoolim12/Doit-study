using System;
using System.Collections.Generic;
using DoitStudy.Interface;
using DoitStudy.Testcase;

namespace DoitStudy.Assignments
{
    public class Assignment02 : IAssignment
    {
        public object main(object data){
            string[] strArr = ((TestCase02.TestCase)data).strArr; // Ex:) strArr = {"123", "-123", "32"} 
            int res = 0; // Ex:) res = -91 위의 예제 기준
            int[] a = new int[strArr.Length];
            int i = 0;

            if(strArr.Length < 2)
            {
                res = 0;
            }

            else
            {
                foreach(var element in strArr)
                {
                    int b = int.Parse(element);
                    a[i] = b;
                    ++i;
                }

                Array.Sort(a);
                res = a[0] + a[1];
            }

            return res;
        }
    }
}