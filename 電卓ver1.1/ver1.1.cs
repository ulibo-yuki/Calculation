using System;
using System.ComponentModel;
using System.Security.Cryptography;

namespace calculator
{
    class calculation
    {
        public static void Main(string[] args)
        //数値登録メソッド
        {
            decimal input1 = 0;
            decimal input2 = 0;
            bool repeat = false;
            do
            {
                if (repeat == false)
                {
                    //数値の登録
                    Console.WriteLine("値1を入力してください。");
                    string inputnum1 = Console.ReadLine();
                    input1 = Convert.ToDecimal(inputnum1);

                }

                Console.WriteLine("値2を入力してください。累乗の場合は指数を入力してください。");
                string inputnum2 = Console.ReadLine();
                input2 = Convert.ToDecimal(inputnum2);



                //算法の選択と設定
                Console.WriteLine("2数の和はa,差はs,積はm,商はd,余りはr,累乗はeを入力してください。");
                string art = Console.ReadLine();

                decimal result = 0;
                //結果用の変数
                string a = "+";
                //演算子用の変数

                switch (art)
                {
                    case "a":
                        result = CalculateSum(input1, input2);
                        a = "+";
                        break;
                    case "s":
                        result = CalculateDiff(input1, input2);
                        a = "-";
                        break;
                    case "m":
                        result = CalculateProd(input1, input2);
                        a = "×";
                        break;
                    case "d":
                        result = CalculateQuot(input1, input2);
                        a = "÷";
                        break;
                    case "r":
                        result = CalculateMod(input1, input2);
                        a = "余り";
                        break;
                    case "e":
                        result = CalculateEx(input1, input2);
                        a = "^";
                        break;
                    default:
                        Console.WriteLine("2数の和はa,差はs,積はm,商はd,余りはrを入力してください。");
                        break;
                }
                //結果表示
                Console.WriteLine(input1 + a + input2 + "=" + result);

                //次の操作を決定
                Console.WriteLine("終了する場合0、クリアして再計算する場合は1、この答えに再計算する場合は2を入力してください。");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 0:
                        //終了
                        repeat = false;
                        Console.WriteLine("3秒後にプログラムを終了します。");
                        Thread.Sleep(1000);
                        Console.WriteLine("2秒後にプログラムを終了します。");
                        Thread.Sleep(1000);
                        Console.WriteLine("1秒後にプログラムを終了します。");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                        break;
                    case 1:
                        repeat = true;
                        Console.WriteLine("値1を入力してください。");
                        string inputnum1 = Console.ReadLine();
                        input1 = Convert.ToDecimal(inputnum1);
                        break;
                    case 2:
                        repeat = true;
                        input1 = result;
                        Console.WriteLine(result + "に何を計算しますか。");
                        break;
                        //クリア計算
                }
 
            }
            while (repeat == true);
        }

        public static decimal CalculateSum(decimal num1, decimal num2)
        {
            //加法
            decimal sum = num1 + num2;
            return sum;
        }
        public static decimal CalculateDiff(decimal num1, decimal num2)
        {
            //減法
            decimal diff = num1 - num2;
            return diff;
        }
        public static decimal CalculateProd(decimal num1, decimal num2)
        {
            //乗法
            decimal diff = num1 * num2;
            return diff;
        }
        public static decimal CalculateQuot(decimal num1, decimal num2)
        {
            //除法
            decimal quot = num1 / num2;
            return quot;
        }
        public static decimal CalculateMod(decimal num1, decimal num2)
        {
            //剰余
            decimal mod = num1 % num2;
            return mod;
        }
        public static decimal CalculateEx(decimal num1, decimal num2)
        {
            //累乗
            int num2_int = Convert.ToInt32(num2);
            decimal Ex = 1;
            for (int i = 1; i > 0; i -= 1)
            {
                Ex = num1 * num1;
            }
            return Ex;
        }
    }
}
