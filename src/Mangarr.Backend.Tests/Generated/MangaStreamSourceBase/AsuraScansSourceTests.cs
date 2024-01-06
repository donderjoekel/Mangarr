using System.Collections;

namespace Mangarr.Backend.Tests;

public class AsuraScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "asurascans";

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
        // https://asuratoon.com?p=276646
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tP3A9Mjc2NjQ2fDI3NjY0Ng==");
        // https://asuratoon.com?p=275294
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tP3A9Mjc1Mjk0fDI3NTI5NA==");
        // https://asuratoon.com?p=275119
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tP3A9Mjc1MTE5fDI3NTExOQ==");
        // https://asuratoon.com?p=274644
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tP3A9Mjc0NjQ0fDI3NDY0NA==");
        // https://asuratoon.com?p=269628
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tP3A9MjY5NjI4fDI2OTYyOA==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://asuratoon.com?p=275588
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tP3A9Mjc1NTg4fDI3NTU4OA==");
        // https://asuratoon.com?p=275265
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tP3A9Mjc1MjY1fDI3NTI2NQ==");
        // https://asuratoon.com?p=275723
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tP3A9Mjc1NzIzfDI3NTcyMw==");
        // https://asuratoon.com?p=275959
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tP3A9Mjc1OTU5fDI3NTk1OQ==");
        // https://asuratoon.com?p=275546
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tP3A9Mjc1NTQ2fDI3NTU0Ng==");
    }

    public static IEnumerable ValidImages()
    {
        // https://asuratoon.com/wp-content/uploads/custom-upload/275294/17/07.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9jdXN0b20tdXBsb2FkLzI3NTI5NC8xNy8wNy5qcGc=");
        // https://asuratoon.com/wp-content/uploads/custom-upload/275294/8/03.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9jdXN0b20tdXBsb2FkLzI3NTI5NC84LzAzLmpwZw==");
        // https://asuratoon.com/wp-content/uploads/custom-upload/275294/4/07 kopya.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9jdXN0b20tdXBsb2FkLzI3NTI5NC80LzA3IGtvcHlhLmpwZw==");
        // https://asuratoon.com/wp-content/uploads/custom-upload/275294/22/07.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9jdXN0b20tdXBsb2FkLzI3NTI5NC8yMi8wNy5qcGc=");
        // https://asuratoon.com/wp-content/uploads/custom-upload/275294/4/08 kopya.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9jdXN0b20tdXBsb2FkLzI3NTI5NC80LzA4IGtvcHlhLmpwZw==");
    }
}

