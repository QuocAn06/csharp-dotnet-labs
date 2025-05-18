using System;
using System.Collections.Generic;

class SearchAndSortList
{
    static void Main()
    {
        //Khoi tao danh sach
        List<int> numbers = new List<int>();

        Console.Write("Nhap so luong phan tu: ");
        int count;
        while(!int.TryParse(Console.ReadLine(), out count) || count <= 0)
        {
            Console.WriteLine("Vui long nhap mot so nguyen duong.");
        }

        //Nhap danh sach tu nguoi dung
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Nhap so thu {i + 1}: ");
            int num;
            while( !int.TryParse(Console.ReadLine(),out num))
            {
                Console.WriteLine("Vui long nhap so nguyen.");
            }

            numbers.Add(num);
        }

        //In danh sach ban dau ra
        Console.Write("\nDanh Sach Ban Dau: ");
        PrintList(numbers);

        //Tim kiem so trong danh sach
        Console.Write("\nNhap so can tim: ");
        int searchNumber;
        while( !int.TryParse(Console.ReadLine(),out searchNumber))
        {
            Console.WriteLine("Vui long nhap so nguyen.");
        }

        bool found = false;
        foreach (int number in numbers)
        {
            if(number == searchNumber)
            {
                found = true; 
                break;
            }
        }

        if (found)
        {
            Console.WriteLine($"So {searchNumber} co trong danh sach.");
        }
        else 
        {
            Console.WriteLine($"So {searchNumber} khong co trong danh sach");
        }

        //Sap xep danh sach
        numbers.Sort();

        //In ra danh sach sau khi sap xep
        Console.Write("\nDanh sach sau khi sap xep: ");
        PrintList(numbers);
    }

    static void PrintList(List<int> list)
    {
        foreach (int number in list)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
    }
}