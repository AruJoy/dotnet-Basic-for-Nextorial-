// import 대신 using
// 그럼 from 은 그대로?
// using System;
// 입출력 시스템콜 사용
// using System.IO;
// 중괄호 코드스타일이 이게 맞나? 아니라면, 저장시, 코드 컨벤션 관리 설정 필요
try
{
    // StreamWriter 문법적 제시 부재 해결 필요
    // 함수 카멜카멜 스타일 확인
    using var w = new StreamWriter("out.txt");
    // js 에서 ` ${}` => $" {}"
    for (int i = 0; i < 3; i++)
        w.WriteLine($"line{i}");
    Console.WriteLine("written");

    Console.WriteLine(Overloading.Add(3, 5));
    Console.WriteLine(Overloading.Add(3.5, 5.3));
    int a = 10;

    RefOut.Increment(ref a);
    Console.WriteLine(a);
    double result;
    Console.WriteLine(RefOut.TryDivide(11, 0, out result));
    Console.WriteLine(result);
    Console.WriteLine(RefOut.TryDivide(11, 2, out result));
    Console.WriteLine(result);

    var car = new Car { Model = "달구지" };
    car.Accelerate(10);
    Console.WriteLine($"{car.Model}: {car.Speed}km/h");

    var player = new Player("도덕리");
    player.LevelUp();
    Console.WriteLine($"닉네임: {player.Name} 레벨:{player.Level}");

    var user = new
    {
        Name = "양춘식",
        Age = 84,
        Ability = "인생 최후의 끌어치기"
    };
    Console.WriteLine($"이름:{user.Name}, 나이: {user.Age}, 특기: {user.Ability}");
    var (sum, diff) = Calc(4, 3);
    Console.WriteLine($"4+3 = {sum}, 4-3 = {diff}");
}
catch (IOException ex)
{
    Console.WriteLine($"IO Err: {ex.Message}");
}

static (int sum, int diff) Calc(int a, int b)
{
    return (a + b, a - b);
}
