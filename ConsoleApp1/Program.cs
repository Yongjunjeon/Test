using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 변수형 종류 주석으로 작성후, 각 변수형들의 최대값  최소값 출력하기
            System.Console.WriteLine(int.MaxValue);
            System.Console.WriteLine(int.MinValue);

            //float
            //double


            //2. string으로 이름 나이 입력 받고, 출력하기
            string myName;

            System.Console.WriteLine("이름을 입력해 주세요 : ");
            myName = System.Console.ReadLine();
            //나이는 출생년도만 입력받기
            string mybirthyear;
            System.Console.WriteLine("태어난 연도를 적어주세요 : ");
            mybirthyear = System.Console.ReadLine();
            int aaa = Convert.ToInt32(mybirthyear);
            int kkkk = 2023 - aaa;
            System.Console.WriteLine($"당신의 태어난 연도는 {aaa}이고, 당신의 나이는 {kkkk}입니다");



            //3.  @사용 해서 별 그리기
            System.Console.WriteLine(@"
                     ㅁ
                   ㅁㅁ
                 ㅁㅁㅁㅁ
   ㅁ           ㅁㅁㅁㅁㅁ        ㅁ
  ㅁㅁㅁ        ㅁㅁㅁㅁㅁㅁ    ㅁㅁㅁ
  ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ
  ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ
   ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ
     ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ
      ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ
           ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ
          ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ
          ㅁㅁㅁㅁㅁ  ㅁㅁㅁㅁㅁ
          ㅁㅁㅁㅁㅁ  ㅁㅁㅁㅁㅁ
          ㅁㅁㅁ        ㅁㅁㅁ 
            ㅁ              ㅁ
   
                                    
                           ");

            //4. int값을 float 로 캐스팅하기

            int kk = 3;
            float f1222 = (float)kk;

            float ff22 = 3.12f;
            int converNum = Convert.ToInt32(ff22);

            System.Console.WriteLine(converNum);

            int[] iii = new int[3];

            int[] kkk = new int[4] { 89, 6, 456, 4 };
            string[] lang = new string[3] { "C#", "C++", "C" };
            long[] lolo = new long[1] { 2 };

            //kkk -> 89 , 6 , 456, 4
            //long -> C# , C++ , C

            System.Console.WriteLine(kkk[0]);

            //식당에 음식이 떡볶이, 김밥, 라면, 라뽁이 가 있다.
            //이중에 숫자를 입력받으면
            //입력받은 값은 비어있게 된다.

            //최초 음식들과
            //숫자를 입력받았을때 음식을 출력하고

            //비어있게 되었다라는 결과값도 출력하라

            string[] _food = new string[4];
            _food[0] = "떡볶이";
            _food[1] = "김밥";
            _food[2] = "라면";
            _food[3] = "라뽁이";

            System.Console.WriteLine($"지금 음식은 {_food[0]} , {_food[1]}, {_food[2]}, {_food[3]} 입니다");
            string gimbabcheongug;
            System.Console.WriteLine("주문하신 음식은 ");
            gimbabcheongug = System.Console.ReadLine();
            int kikiki = Convert.ToInt32(gimbabcheongug);
            _food[kikiki] = "";

            System.Console.WriteLine($"지금 음식은 {_food[0]} , {_food[1]}, {_food[2]}, {_food[3]} 입니다");
            
        }
    }
}
