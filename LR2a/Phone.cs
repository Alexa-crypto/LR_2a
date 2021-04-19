using System;

namespace LR2a
{
    public class Phone
    {
        string name;
        string operatitong_sistem;
        string cpu;
        string gpu;
        int rom;
        int ram;
        string tip_body;
        bool camera;
        bool biometrics;
        //занесення данних в клас
        public void Set_Phone(string name, string operatitong_sistem, string cpu, string gpu, int rom, int ram, string tip_body, ConsoleKeyInfo camera, ConsoleKeyInfo biometrics)
        {
            this.name = name;
            this.operatitong_sistem = operatitong_sistem;
            this.cpu = cpu;
            this.gpu = gpu;
            this.rom = rom;
            this.ram = ram;
            this.tip_body = tip_body;
            this.camera = camera.Key == ConsoleKey.Y ? true : false;
            this.biometrics = biometrics.Key == ConsoleKey.Y ? true : false;
        }
        //вивід даних
        public void Get_Phone()
        {
            //Console.WriteLine($"| {name.PadLeft(18)} | {operatitong_sistem.PadLeft(7)} | {cpu.PadLeft(15)} | {gpu.PadLeft(8)} | {Convert.ToString(rom).PadLeft(2)}/{Convert.ToString(ram).PadLeft(3)} | {tip_body.PadLeft(7)} | " + (camera ? "+" : "-") + "/" + (biometrics ? "+" : "-") + "|");
            Console.WriteLine($"| {Truncate(name, 18)} | {Truncate(operatitong_sistem, 7)} | {Truncate(cpu, 15)} | {Truncate(gpu, 8)} | {Truncate(Convert.ToString(rom), 2)}/{Truncate(Convert.ToString(ram), 3)} | {Truncate(tip_body, 7)} | " + (camera ? "+" : "-") + "/" + (biometrics ? "+" : "-") + "|");
            Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
        }
        //шапка таблиці
        public void Get_Phone_Shapka()
        {
            Console.WriteLine("┌───────────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("|        Name        |    OS   |     Processor   |  Grafic  | ROM/RAM|   Body  | ...|");
            Console.WriteLine("└───────────────────────────────────────────────────────────────────────────────────┘");
        }
        public string Remove_name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        //перевірка розмірності строки, щоб красива табличка
        string Truncate(string value, int maxLength) 
        { 
            return value.Length <= maxLength ? value.PadLeft(maxLength) : value.Substring(0, maxLength - 3) + "..."; 
        }
    }
}
