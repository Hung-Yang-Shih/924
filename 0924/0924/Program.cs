using System;

class Program
{
    static void Main(string[] args)
    {
        // 提示使用者輸入身高（單位：公分）
        Console.Write("請輸入身高（公分）：");
        string heightInput = Console.ReadLine();
        double height = Convert.ToDouble(heightInput);

        // 提示使用者輸入體重（單位：公斤）
        Console.Write("請輸入體重（公斤）：");
        string weightInput = Console.ReadLine();
        double weight = Convert.ToDouble(weightInput);

        // 計算 BMI
        double bmi = weight / (height/100 * height/100);

        // 輸出 BMI 結果
        Console.WriteLine($"您的 BMI 值為：{bmi:F2}");

        // 分類輸出（可選）
        if (bmi < 18.5)
        {
            Console.WriteLine("BMI分類：過輕");
        }
        else if (bmi < 24)
        {
            Console.WriteLine("BMI分類：正常");
        }
        else if (bmi < 27)
        {
            Console.WriteLine("BMI分類：過重");
        }
        else if (bmi < 30)
        {
            Console.WriteLine("BMI分類：輕度肥胖");
        }
        else if (bmi < 35)
        {
            Console.WriteLine("BMI分類：中度肥胖");
        }
        else
        {
            Console.WriteLine("BMI分類：重度肥胖");
        }

        // 等待使用者按任意鍵後結束程式
        Console.WriteLine("按任意鍵結束...");
        Console.ReadKey();
    }
}
