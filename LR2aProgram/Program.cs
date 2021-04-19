using System;
using LR2a;

namespace LR2aProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;    //для використання "і"
            Console.Write("Введіть кількість смартфонів --> ");
            int n = Convert.ToInt32(Console.ReadLine());
            //int n = 1;
            Phone[] mas = new Phone[n];
            //занесення данних в клас з клавіатури
            for (int i = 0; i < n; i++)
            {
                mas[i] = new Phone();
                Console.Write("Назва телефону (мах 18 симвл.) --> ");
                string name = Console.ReadLine();
                Console.Write("Операційна система (Android or IOS) --> ");
                string operatitong_sistem = Console.ReadLine();
                Console.Write("Центральний процессор --> ");
                string cpu = Console.ReadLine();
                Console.Write("Графічний адаптер --> ");
                string gpu = Console.ReadLine();
                Console.Write("Тип корпусу (пластик, метал, скло) --> ");
                string tip_body = Console.ReadLine();
                Console.Write("ROM (Gb) --> ");
                int rom = Convert.ToInt32(Console.ReadLine());
                Console.Write("RAM (Gb) --> ");
                int ram = Convert.ToInt32(Console.ReadLine());
                Console.Write("Наявність камери --> ");
                ConsoleKeyInfo camera = Console.ReadKey();
                Console.WriteLine();
                Console.Write("Наявність біометричних сканерів --> ");
                ConsoleKeyInfo biometrics = Console.ReadKey();
                mas[i].Set_Phone(name, operatitong_sistem, cpu, gpu, rom, ram, tip_body, camera, biometrics);
                Console.Clear();
            }
            //шапка
            mas[0].Get_Phone_Shapka();
            foreach (Phone i in mas)
                i.Get_Phone();
            Console.Write("Потрібне редагування назви (y-yes n-no) --> ");
            ConsoleKeyInfo edit = Console.ReadKey();
            bool exit_while = edit.Key == ConsoleKey.Y ? true : false;
            while (exit_while)
            {
                Console.WriteLine("");
                Console.Write("Номер елемента редагування (від 0) --> ");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Нове імя {i} елемента --> ");
                mas[i].Remove_name = Console.ReadLine();
                Console.WriteLine($"Нове імя {mas[i].Remove_name}");
                Console.Write("Потрібне редагування назви (y-yes n-no) --> ");
                edit = Console.ReadKey();
                exit_while = edit.Key == ConsoleKey.Y ? true : false;
            }
            Console.Clear();
            mas[0].Get_Phone_Shapka();
            foreach (Phone i in mas)
                i.Get_Phone();
            Array.Clear(mas, 0, n);
        }
    }
}
