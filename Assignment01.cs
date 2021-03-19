using System;
using doit_study_homework_template.testcase;
using System.Collections.Generic;

namespace doit_study_homework_template
{
    public class Assignment01 : TestCase01, IAssignment
    {
        /* Dont Touch */
        public bool isRunning { get;  set; }
        public Assignment01(bool _isRunning){
            isRunning = _isRunning;
        }
        /********************/
        public void main(){
            var inputs = input();
            var results = new List<int>();

            foreach (TestCase data in inputs){
                var num01 = data.num01;
                var num02 = data.num02;
                int res = 0;
                
                if(num01 >= num02)
                {
                    res = num01;
                }
                else
                {
                    res = num02;
                }

                results.Add(res);
            }

            output(results.ToArray());
        }
    }
}