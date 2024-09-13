
namespace ClassObject130924
{
    class TestPaper
    {
        public void sum()
        {

            int total=0;
           
            string str;
            Console.WriteLine("Enter String");
            str=Console.ReadLine();//"pravin12Gaikwad3solapur

            char[] ch = str.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i]>='0'&& ch[i]<='9')
                {
                    // total =(int)(total + char.GetNumericValue(ch[i]));
                    total = total + ch[i];
                }
            }
            Console.WriteLine("total="+total);
        }
    }
    class Class123
    {
        int x=100;// instance variable or field
        //int x;
        public void show(int a,int b)
        {
            int x=200; //local
         

            int y = this.x;
            Console.WriteLine("y="+y);
        }
        public void show(float a, int b)
        {
            //return 1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            char cc = '1';
            int nn = cc - '0'; 
            Console.WriteLine("nn="+nn);
            // Console.WriteLine(char.IsNumber(cc));
            //Console.WriteLine(char.GetNumericValue(cc));

            //student s1 = new student();
            //s1.totalMarks = 490;
            //s1.roll = 111;
            //s1.showResult();
            //Console.WriteLine("-------------------------");

            //Mystud ms1=new Mystud();
            //ms1.roll = 222;
            //ms1.totalMarks = 490;
            //ms1.showResult();

            //new TestPaper().sum();

            int[] n1 = { 1, 2, 3, 4 };
            int [] n2 = { 3,4,5 };
            var n3 = n1.Intersect<int>(n2).ToArray();

            for (int i = 0; i < n3.Length; i++)
            {
                Console.WriteLine(n3[i]);
            }
            Console.WriteLine("-------------------------");
            int[] n4=n1.Union<int>(n2).ToArray();
            for (int i = 0; i < n4.Length; i++)
            {
                Console.WriteLine(n4[i]);
            }
        }
    }
}
