using System.Collections;

namespace Mangarr.Backend.Tests;

public class FlameComicsSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "flamecomics";

    public static IEnumerable ValidSearchResults()
    {
        yield return new TestCaseData("a");
        yield return new TestCaseData("e");
        yield return new TestCaseData("i");
        yield return new TestCaseData("o");
        yield return new TestCaseData("u");
    }

    public static IEnumerable ValidChapterLists()
    {
        // https://flamecomics.com?p=149764
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20/cD0xNDk3NjR8MTQ5NzY0");
        // https://flamecomics.com?p=148701
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20/cD0xNDg3MDF8MTQ4NzAx");
        // https://flamecomics.com?p=147024
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20/cD0xNDcwMjR8MTQ3MDI0");
        // https://flamecomics.com?p=143300
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20/cD0xNDMzMDB8MTQzMzAw");
        // https://flamecomics.com?p=143136
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20/cD0xNDMxMzZ8MTQzMTM2");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://flamecomics.com/baek-clans-terminally-ill-young-master-chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vYmFlay1jbGFucy10ZXJtaW5hbGx5LWlsbC15b3VuZy1tYXN0ZXItY2hhcHRlci01L3xodHRwczovL2ZsYW1lY29taWNzLmNvbT9wPTE0NzAyNHw1");
        // https://flamecomics.com/the-god-of-war-who-regressed-to-level-2-chapter-21/
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vdGhlLWdvZC1vZi13YXItd2hvLXJlZ3Jlc3NlZC10by1sZXZlbC0yLWNoYXB0ZXItMjEvfGh0dHBzOi8vZmxhbWVjb21pY3MuY29tP3A9MTQzMTM2fDIx");
        // https://flamecomics.com/star-fostered-swordmaster-chapter-7/
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vc3Rhci1mb3N0ZXJlZC1zd29yZG1hc3Rlci1jaGFwdGVyLTcvfGh0dHBzOi8vZmxhbWVjb21pY3MuY29tP3A9MTQ5NzY0fDc=");
        // https://flamecomics.com/baek-clans-terminally-ill-young-master-chapter-23/
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vYmFlay1jbGFucy10ZXJtaW5hbGx5LWlsbC15b3VuZy1tYXN0ZXItY2hhcHRlci0yMy98aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20/cD0xNDcwMjR8MjM=");
        // https://flamecomics.com/academys-genius-swordsman-chapter-9/
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vYWNhZGVteXMtZ2VuaXVzLXN3b3Jkc21hbi1jaGFwdGVyLTkvfGh0dHBzOi8vZmxhbWVjb21pY3MuY29tP3A9MTQzMzAwfDk=");
    }

    public static IEnumerable ValidImages()
    {
        // https://flamecomics.com/wp-content/uploads/2023/08/AGS_12-1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMDgvQUdTXzEyLTEuanBn");
        // https://flamecomics.com/wp-content/uploads/2023/08/AGS_02-1.jpg
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMDgvQUdTXzAyLTEuanBn");
        // https://flamecomics.com/wp-content/uploads/2023/08/BCTIYM-2.jpg
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMDgvQkNUSVlNLTIuanBn");
        // https://flamecomics.com/wp-content/uploads/2023/12/BTYIM_23_01.jpg
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvQlRZSU1fMjNfMDEuanBn");
        // https://flamecomics.com/wp-content/uploads/2023/12/BTYIM_23_02.jpg
        yield return new TestCaseData("aHR0cHM6Ly9mbGFtZWNvbWljcy5jb20vd3AtY29udGVudC91cGxvYWRzLzIwMjMvMTIvQlRZSU1fMjNfMDIuanBn");
    }
}

