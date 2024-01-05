using System.Collections;

namespace Mangarr.Backend.Tests;

public class BestManhuaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "bestmanhua";

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
        // https://bestmanhua.com/manga/emperor-qin-returns-i-am-the-eternal-immortal-emperor/
        yield return new TestCaseData("aHR0cHM6Ly9iZXN0bWFuaHVhLmNvbS9tYW5nYS9lbXBlcm9yLXFpbi1yZXR1cm5zLWktYW0tdGhlLWV0ZXJuYWwtaW1tb3J0YWwtZW1wZXJvci8=");
        // https://bestmanhua.com/manga/all-hail-the-sect-leader/
        yield return new TestCaseData("aHR0cHM6Ly9iZXN0bWFuaHVhLmNvbS9tYW5nYS9hbGwtaGFpbC10aGUtc2VjdC1sZWFkZXIv");
        // https://bestmanhua.com/manga/upgrade-from-wild-monsters/
        yield return new TestCaseData("aHR0cHM6Ly9iZXN0bWFuaHVhLmNvbS9tYW5nYS91cGdyYWRlLWZyb20td2lsZC1tb25zdGVycy8=");
        // https://bestmanhua.com/manga/i-have-a-blade-that-can-cut-heaven-and-earth/
        yield return new TestCaseData("aHR0cHM6Ly9iZXN0bWFuaHVhLmNvbS9tYW5nYS9pLWhhdmUtYS1ibGFkZS10aGF0LWNhbi1jdXQtaGVhdmVuLWFuZC1lYXJ0aC8=");
        // https://bestmanhua.com/manga/million-times-attack-speed/
        yield return new TestCaseData("aHR0cHM6Ly9iZXN0bWFuaHVhLmNvbS9tYW5nYS9taWxsaW9uLXRpbWVzLWF0dGFjay1zcGVlZC8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://bestmanhua.com/manga/all-hail-the-sect-leader/chapter-228/
        yield return new TestCaseData("aHR0cHM6Ly9iZXN0bWFuaHVhLmNvbS9tYW5nYS9hbGwtaGFpbC10aGUtc2VjdC1sZWFkZXIvY2hhcHRlci0yMjgv");
        // https://bestmanhua.com/manga/all-hail-the-sect-leader/chapter-146/
        yield return new TestCaseData("aHR0cHM6Ly9iZXN0bWFuaHVhLmNvbS9tYW5nYS9hbGwtaGFpbC10aGUtc2VjdC1sZWFkZXIvY2hhcHRlci0xNDYv");
        // https://bestmanhua.com/manga/all-hail-the-sect-leader/chapter-178/
        yield return new TestCaseData("aHR0cHM6Ly9iZXN0bWFuaHVhLmNvbS9tYW5nYS9hbGwtaGFpbC10aGUtc2VjdC1sZWFkZXIvY2hhcHRlci0xNzgv");
        // https://bestmanhua.com/manga/all-hail-the-sect-leader/chapter-134/
        yield return new TestCaseData("aHR0cHM6Ly9iZXN0bWFuaHVhLmNvbS9tYW5nYS9hbGwtaGFpbC10aGUtc2VjdC1sZWFkZXIvY2hhcHRlci0xMzQv");
        // https://bestmanhua.com/manga/all-hail-the-sect-leader/chapter-230/
        yield return new TestCaseData("aHR0cHM6Ly9iZXN0bWFuaHVhLmNvbS9tYW5nYS9hbGwtaGFpbC10aGUtc2VjdC1sZWFkZXIvY2hhcHRlci0yMzAv");
    }

    public static IEnumerable ValidImages()
    {
        // https://meo.comick.pictures/29-LXDhTXq3HP5Hp-m.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tZW8uY29taWNrLnBpY3R1cmVzLzI5LUxYRGhUWHEzSFA1SHAtbS5qcGc=");
        // https://meo.comick.pictures/26-_Is8fYkF-T_gT-m.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tZW8uY29taWNrLnBpY3R1cmVzLzI2LV9JczhmWWtGLVRfZ1QtbS5qcGc=");
        // https://meo.comick.pictures/5-uQRoL8VBwmz-d.png
        yield return new TestCaseData("aHR0cHM6Ly9tZW8uY29taWNrLnBpY3R1cmVzLzUtdVFSb0w4VkJ3bXotZC5wbmc=");
        // https://meo.comick.pictures/14-qAHNVLYDOVMsi.png
        yield return new TestCaseData("aHR0cHM6Ly9tZW8uY29taWNrLnBpY3R1cmVzLzE0LXFBSE5WTFlET1ZNc2kucG5n");
        // https://meo.comick.pictures/28-lfBFt95tfagGZ-m.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tZW8uY29taWNrLnBpY3R1cmVzLzI4LWxmQkZ0OTV0ZmFnR1otbS5qcGc=");
    }
}

