# Tutorial_UnitTestsCource

### Teddy Smith
동영상 8개 
조회수 81,131회 
최종 업데이트: 2022. 4. 4.

## [C# Unit Testing Course](https://www.youtube.com/playlist?list=PL82C6-O4XrHeyeJcI5xrywgpfbrqdkQd4)

1. Unit Testing in C# 2022: 1. Intro + First Test
2. Unit Testing in C# 2022: 2. XUnit & Fluent Assertions
3. Unit Testing in C# 2022: 3. Testing Objects, IEnumerable, & Dates
4. Unit Testing in C# 2022: 4. Mocking EXPLAINED SIMPLY [FakeItEasy]
5. Unit Testing in C# 2022: 5. MVC Controllers
6. Unit Testing in C# 2022: 6. MVC Entity Framework
7. Unit Testing in C# 2022: 7. Web API Controllers
8. Unit Testing in C# 2022: 8. Web API Entity Framework


## 참고: 
[Fluent Assertions](https://fluentassertions.com/introduction)

시작하기

Fluent Assertions는 TDD 또는 BDD 스타일 단위 테스트의 예상 결과를 보다 자연스럽게 지정할 수 있는 .NET 확장 메서드 세트입니다. 이를 통해 모두 다음 using문으로 시작하는 간단하고 직관적인 구문이 가능해집니다.

```csharp
using FluentAssertions;
```

이는 현재 범위에 많은 확장 방법을 제공합니다. 예를 들어, 문자열이 시작하고 끝나며 특정 문구를 포함하는지 확인합니다.

```c#
string actual = "ABCDEFGHI";
actual.Should().StartWith("AB").And.EndWith("HI").And.Contain("EF").And.HaveLength(9);
```

컬렉션의 모든 요소가 조건자와 일치하고 컬렉션에 지정된 수의 요소가 포함되어 있는지 확인합니다.

```c#
IEnumerable<int> numbers = new[] { 1, 2, 3 };

numbers.Should().OnlyContain(n => n > 0);
numbers.Should().HaveCount(4, "because we thought we put four items in the collection");
```

두 번째 실패한 예제의 좋은 점은 메시지와 함께 예외가 발생한다는 것입니다.



[단위 테스트 구조(AAA 패턴, 테스트 픽스터, 명명법)](https://kukim.tistory.com/47)

## AUT, MUT, CUT, OUT 등으로도 불릴 수 있는데요.
- SUT - System Under Test
- AUT - Application Under Test
- MUT - Method Under Test
- CUT - Class Under Test
- OUT - Object Under Test