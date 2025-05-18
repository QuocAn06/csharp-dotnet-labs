//Lab 01: Tinh chi so BMI
//BMI = weight / (height * height)

double weight, height, bmi;
string classification;

Console.WriteLine("=== TINH CHI SO BMI ===");

Console.Write("Nhap can nang (kg): ");
if (!double.TryParse(Console.ReadLine(), out weight) || weight <= 0)
{
    Console.WriteLine("Can nang khong hop le!");
    return;
}

Console.Write("Nhap chieu cao (m): ");
if (!double.TryParse(Console.ReadLine(), out height) || height <= 0)
{
    Console.WriteLine("Chieu cao khong hop le!");
    return;
}

bmi = weight / (height * height);
Console.WriteLine($"\nChi so BMI cua ban la: {bmi:F2}");

// Phan loai suc khoe theo BMI
if (bmi < 18.5)
    classification = "Gay (Underweight)";
else if (bmi < 25)
    classification = "Binh Thuong (Normal weight)";
else if (bmi < 30)
    classification = "Thua Can (Overweight)";
else if (bmi < 35)
    classification = "Beo Phi Cap Do I (Obesity Class I)";
else if (bmi < 40)
    classification = "Beo Phi Cap Do II (Obesity Class II)";
else
    classification = "Beo Phi Cap Do III (Obesity Class III)";

Console.WriteLine("Phan loai: " + classification);