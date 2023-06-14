namespace MCC79;

public class Program
{
    static void Menu()
    {
        Console.WriteLine("===================================================");
        Console.WriteLine("\t\tMenu Ganjil Genap");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("1. Cek Ganjil Genap");
        Console.WriteLine("2. Print Ganjil/Genap (dengan limit)");
        Console.WriteLine("3. Exit");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine();
        Console.Write("Pilihan: ");
        string pilihan = Console.ReadLine();
        switch (pilihan)
        {
            case "1":
                Console.Write("Masukkan Bilangan yang ingin di cek : ");
                string bilangan = Console.ReadLine();
                bool cek = int.TryParse(bilangan, out int angka);
                if (cek)
                {
                    Console.WriteLine(EvenOddCheck(angka));
                }
                else
                {
                    Console.WriteLine("Invalid Input!!!");
                }
                Console.WriteLine("===================================================");
                Menu();
                break;
            case "2":
                Console.Write("Pilih (Ganjil/Genap) : ");
                string pilih = Console.ReadLine();
                Console.Write("Masukkan limit : ");
                string limit = Console.ReadLine();
                bool berhasil = int.TryParse(limit, out int number);
                if (berhasil)
                {
                    PrintEvenOdd(number, pilih);
                }
                else
                {
                    Console.WriteLine("Input limit tidak valid!!!");
                }
                Console.WriteLine("===================================================");
                Menu();
                break;
            case "3":
                Console.WriteLine("Selamat tinggal :D");
                Console.WriteLine("===================================================");
                break;
            default:
                Console.WriteLine("Pilihan tidak tersedia, silahkan coba kembali");
                Console.WriteLine("===================================================");
                Menu();
                break;
        }
    }

    static void PrintEvenOdd(int limit, string choice)
    {
        if (choice != "Ganjil" && choice != "Genap")
        {
            Console.WriteLine("Input pilihan tidak valid!!!");
        }
        else
        {
            Console.WriteLine("Print bilangan 1 - " + limit + " :");
            if (limit < 1)
            {
                Console.WriteLine("Input limit tidak valid!!!");
            }
            else
            {
                if (choice == "Ganjil")
                {
                    for (int i = 1; i < limit; i++)
                    {
                        if (i % 2 == 1)
                        {
                            Console.Write(i + ", ");
                        }
                    }
                    Console.WriteLine();
                }
                if (choice == "Genap")
                {
                    for (int i = 1; i < limit; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(i + ", ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }

    static string EvenOddCheck(int input)
    {
        if (input >= 1)
        {
            if (input % 2 == 0)
            {
                return "Genap";
            }
            else if (input % 2 == 1)
            {
                return "Ganjil";
            }
            else
            {
                return "Invalid Input!!!";
            }
        }
        else
        {
            return "invalid Input!!!";
        }
    }
    public static void Main(string[] args)
    {
        Menu();
    }
}
