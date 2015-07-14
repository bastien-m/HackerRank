using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class AngryProfessor : IAlgorithm
    {
        private int numberOfStudents, requiredStudents;
        private List<int> arrivalTimes;
        private String result;
        

        public AngryProfessor(int numberOfStudents, int requiredStudents, List<int> arrivalTimes)
        {
            this.result = "YES";
            this.numberOfStudents = numberOfStudents;
            this.requiredStudents = requiredStudents;
            this.arrivalTimes = arrivalTimes;
        }


        public void Resolve()
        {
            int count = 0;
            foreach (int time in arrivalTimes)
            {
                count += time <= 0 ? 1 : 0;
                if (count >= this.requiredStudents)
                {
                    this.result = "NO";
                    break;
                }
            }
            
        }

        public string GetResult()
        {
            return this.result;
        }
    }
}
