using System;
using doit_study_homework_template.testcase;
using System.Collections.Generic;

namespace doit_study_homework_template
{
    public class Assignment02 : TestCase02, IAssignment
    {
        /* Dont Touch */
        public bool isRunning { get;  set; }
        public Assignment02(bool _isRunning){
            isRunning = _isRunning;
        }
        /********************/
        public void main(){
            var inputs = input();
            var results = new List<string>();

            foreach (TestCase data in inputs){
                var str = data.str;
                var res = String.Empty;

                //res에 str의 Upper상태를 저장해주세요.
                //여기에 코드를 작성해주세요.

                /*foreach(char letter in str)
                {
                    if(Char.IsLower(letter))
                    {
                        Char.ToUpper(letter);                        
                    }
                }

                res = str;*/

                res = str.ToUpper();

                results.Add(res);
            }

            output(results.ToArray());
        }
    }
}