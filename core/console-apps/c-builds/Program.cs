// import 대신 using
// 그럼 from 은 그대로?
using System;
// 입출력 시스템콜 사용
using System.IO;

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
}
catch (IOException ex)
{
    Console.WriteLine($"IO Err: {ex.Message}");
}
