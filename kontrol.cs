using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Добрый день! \n Пожайлуста сжальтесь надо мною!!!!\n Я только перевёлся и плохо знаю C# \n Введите текст.");
            string stroka = Console.ReadLine().ToUpper(); 
            long all = stroka.Length; 
                                     
            string buk = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            int kol = buk.Length; 
            double[] m = new double[buk.Length];
          
            for (int i = 0; i < all; i++)   
                for (int j = 0; j < kol; j++)   
                    if (stroka[i] == buk[j])
                    {
                        m[j]++;
                        break;  
                    }
            
            double n = 0;
            for (int j = 0; j < kol; j++)
                n += m[j];
            
            double c;
            char b1;
            char b2;
            char b3 = ' ';
            for (int i = 1; i < buk.Length - 1; i++)
                for (int j = 0; j < buk.Length - 1; j++)
                    if (m[j] < m[j + 1])
                    {
                        
                        c = m[j];
                        m[j] = m[j + 1];
                        m[j + 1] = c;
                        
                        b1 = buk[j];
                        b2 = buk[j + 1];
                        buk = buk.Replace(b1, b3);    
                        buk = buk.Replace(b2, b1);    
                        buk = buk.Replace(b3, b2);
                    }
            
            if (n < 1)
                Console.WriteLine("Вы не ввели  букву ");
            else
            {
                Console.WriteLine("Проценты ");
                for (int i = 0; i < buk.Length; i++)
                {
                    if (m[i] > 0)
                    {
                        m[i] = Math.Round(m[i] / n * 100, 2);
                        Console.WriteLine("{0}:\t{1}%", buk[i], m[i]);
                    }
                }
            }
        }
    }
}
