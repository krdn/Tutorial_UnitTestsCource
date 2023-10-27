# Tutorial_UnitTestsCource

### Teddy Smith
������ 8�� 
��ȸ�� 81,131ȸ 
���� ������Ʈ: 2022. 4. 4.

## [C# Unit Testing Course](https://www.youtube.com/playlist?list=PL82C6-O4XrHeyeJcI5xrywgpfbrqdkQd4)

1. Unit Testing in C# 2022: 1. Intro + First Test
2. Unit Testing in C# 2022: 2. XUnit & Fluent Assertions
3. Unit Testing in C# 2022: 3. Testing Objects, IEnumerable, & Dates
4. Unit Testing in C# 2022: 4. Mocking EXPLAINED SIMPLY [FakeItEasy]
5. Unit Testing in C# 2022: 5. MVC Controllers
6. Unit Testing in C# 2022: 6. MVC Entity Framework
7. Unit Testing in C# 2022: 7. Web API Controllers
8. Unit Testing in C# 2022: 8. Web API Entity Framework


## ����: 
[Fluent Assertions](https://fluentassertions.com/introduction)

�����ϱ�

Fluent Assertions�� TDD �Ǵ� BDD ��Ÿ�� ���� �׽�Ʈ�� ���� ����� ���� �ڿ������� ������ �� �ִ� .NET Ȯ�� �޼��� ��Ʈ�Դϴ�. �̸� ���� ��� ���� using������ �����ϴ� �����ϰ� �������� ������ ���������ϴ�.

```csharp
using FluentAssertions;
```

�̴� ���� ������ ���� Ȯ�� ����� �����մϴ�. ���� ���, ���ڿ��� �����ϰ� ������ Ư�� ������ �����ϴ��� Ȯ���մϴ�.

```c#
string actual = "ABCDEFGHI";
actual.Should().StartWith("AB").And.EndWith("HI").And.Contain("EF").And.HaveLength(9);
```

�÷����� ��� ��Ұ� �����ڿ� ��ġ�ϰ� �÷��ǿ� ������ ���� ��Ұ� ���ԵǾ� �ִ��� Ȯ���մϴ�.

```c#
IEnumerable<int> numbers = new[] { 1, 2, 3 };

numbers.Should().OnlyContain(n => n > 0);
numbers.Should().HaveCount(4, "because we thought we put four items in the collection");
```

�� ��° ������ ������ ���� ���� �޽����� �Բ� ���ܰ� �߻��Ѵٴ� ���Դϴ�.



[���� �׽�Ʈ ����(AAA ����, �׽�Ʈ �Ƚ���, ����)](https://kukim.tistory.com/47)

## AUT, MUT, CUT, OUT �����ε� �Ҹ� �� �ִµ���.
- SUT - System Under Test
- AUT - Application Under Test
- MUT - Method Under Test
- CUT - Class Under Test
- OUT - Object Under Test