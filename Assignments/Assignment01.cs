using System;
using System.Collections.Generic;
using DoitStudy.Interface;
using DoitStudy.Testcase;

namespace DoitStudy.Assignments
{
    public class Assignment01 : IAssignment
    {
        public object main(object data){
            char token = ((TestCase01.TestCase)data).token; // token
            string[] strArr = ((TestCase01.TestCase)data).strArr; // string이 저장된 array
            //res에 값을 저장시켜주세요.

            int count = 0;

            foreach(var element in strArr)
            {
                if(element == null || element == String.Empty)
                    continue;
                if(element.Contains(token)){
                    ++count;
                }
            }

            string[] temp = new string[count];

            int i = 0;

            foreach(var element in strArr)
            {
                if(element == null || element == String.Empty)
                    continue;
                if(element.Contains(token)){
                    temp[i] = element;
                    ++i;
                }
            }

            Array.Sort(temp);

            string[] res = {}; // strArr에 저장된 데이터 중에서 token을 포함한 값을 추출하여 저장한 뒤, 사전 순으로 정렬하기.
            res = temp;
            //return 값은 string Array 형식으로 string[] 입니다.

            return res;
        }
    }
}

            /*List<string> temp = new List<string>();

            foreach(var e in strArr)
            {
                if(e.Contains(token))
                {
                    temp.Add(e);
                }
            }

            temp.Sort();
            res = temp.ToArray();*/