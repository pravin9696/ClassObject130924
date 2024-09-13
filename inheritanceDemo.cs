using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject130924
{
    class student
    {
        public int roll { get; set; }
        public int totalMarks{ get; set; }
        protected float per;
       virtual public void showResult()
        {
             per= totalMarks / 5;
            Console.WriteLine("Roll = "+roll+" per="+per);
        }
    }
    class Mystud:student
    {
        char grade;
       override public void showResult()//extensiblity
        {
            base.showResult();//reuse

            if (per>90)
            {
                grade = 'A';
            }
            else
            {
                grade = 'B';
            }
            Console.WriteLine("Grade ="+grade);
        }
    }
    internal class inheritanceDemo
    {
    }
}
