using System;
namespace ConsoleApp1
{
    public class Program
    {
        static public double Hipotenus(double a, double b)// ���� ���������
        {
            double c = Math.Sqrt(a + b);
            Console.WriteLine("���������� = " + c.ToString());
            return c;
        }
        static public double Per(double a, double b, double c)// ���� ��������
        {
            double p = a + b + c;
            Console.WriteLine("�������� = " + p.ToString());
            return p;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("����i�� ����� �����");
            string S1 = Console.ReadLine();
            double a = double.Parse(S1);
            Console.WriteLine("����i�� ����� �����");
            string S2 = Console.ReadLine();
            double b = double.Parse(S2);
            double c = Hipotenus(a, b);
            Per(a, b, c);
            Console.ReadLine();
        }
    }
}
