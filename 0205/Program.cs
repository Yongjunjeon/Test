using System;

namespace Yongjunjeon
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 이름 입력받기
            string myName;
            System.Console.WriteLine("이름 :");
            myName = System.Console.ReadLine();
            //2. 생년 입력받기
            string mybirthyear;
            System.Console.WriteLine("생년월일");
            mybirthyear = System.Console.ReadLine();
            //3. 자기소개 입력받기 (1줄)
            string mylikegame;
            System.Console.WriteLine("취미");
            mylikegame = System.Console.ReadLine();
            //4. writline으로 출력하기(생년 -> 나이로)
            string myAge;
            System.Console.WriteLine("태어난 연도를 적어주세요 : ");
            myAge = System.Console.ReadLine();
            int aaa = Convert.ToInt32(myAge);
            int lol = 2023 - aaa;
            System.Console.WriteLine($"당신의 태어난 연도는 {aaa}이고, 당신의 나이는 {lol}입니다");
            //5. $ 넣어서 표현하기
            string yourName = "Yongjun";
            System.Console.WriteLine($"{yourName}");
            //6. @를 넣어서 사각형 그리기
            System.Console.WriteLine(@"ㅁㅁㅁㅁㅁㅁㅁㅁㅁ
ㅁ              ㅁ
ㅁ              ㅁ
ㅁ              ㅁ
ㅁ              ㅁ
ㅁㅁㅁㅁㅁㅁㅁㅁㅁ");
            //7. 1,2,3, string배열에 넣기
            string[] stringValues = new string[3];
            stringValues[0] = myName;
            stringValues[1] = mybirthyear;
            stringValues[2] = mylikegame;
            //8. string 배열값을 4번과 같은 방식으로 출력하기
            System.Console.WriteLine("이름 {0} , 나이 {1}, 소개 {2}", stringValues[0], stringValues[1], stringValues[2]);
            //9. string 배열값을 5번과 같은 방식으로 출력하기
            System.Console.WriteLine($"이름 {stringValues[0]} , 나이 {stringValues[1]}, 소개 {stringValues[2]}");



        }
    }
}
