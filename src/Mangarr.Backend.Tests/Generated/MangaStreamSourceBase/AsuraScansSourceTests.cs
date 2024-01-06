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
        // https://asuratoon.com/0873280421-regressor-of-the-fallen-family-chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tLzA4NzMyODA0MjEtcmVncmVzc29yLW9mLXRoZS1mYWxsZW4tZmFtaWx5LWNoYXB0ZXItNS98aHR0cHM6Ly9hc3VyYXRvb24uY29tP3A9Mjc2NjQ2fDU=");
        // https://asuratoon.com/0873280421-mr-devourer-please-act-like-a-final-boss-chapter-11/
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tLzA4NzMyODA0MjEtbXItZGV2b3VyZXItcGxlYXNlLWFjdC1saWtlLWEtZmluYWwtYm9zcy1jaGFwdGVyLTExL3xodHRwczovL2FzdXJhdG9vbi5jb20/cD0yNzUyOTR8MTE=");
        // https://asuratoon.com/0873280421-mr-devourer-please-act-like-a-final-boss-chapter-14/
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tLzA4NzMyODA0MjEtbXItZGV2b3VyZXItcGxlYXNlLWFjdC1saWtlLWEtZmluYWwtYm9zcy1jaGFwdGVyLTE0L3xodHRwczovL2FzdXJhdG9vbi5jb20/cD0yNzUyOTR8MTQ=");
        // https://asuratoon.com/0873280421-mr-devourer-please-act-like-a-final-boss-chapter-9/
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tLzA4NzMyODA0MjEtbXItZGV2b3VyZXItcGxlYXNlLWFjdC1saWtlLWEtZmluYWwtYm9zcy1jaGFwdGVyLTkvfGh0dHBzOi8vYXN1cmF0b29uLmNvbT9wPTI3NTI5NHw5");
        // https://asuratoon.com/0873280421-the-extras-academy-survival-guide-chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tLzA4NzMyODA0MjEtdGhlLWV4dHJhcy1hY2FkZW15LXN1cnZpdmFsLWd1aWRlLWNoYXB0ZXItMy98aHR0cHM6Ly9hc3VyYXRvb24uY29tP3A9Mjc0NjQ0fDM=");
    }

    public static IEnumerable ValidImages()
    {
        // https://asuratoon.com/wp-content/uploads/custom-upload/275294/14/04.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9jdXN0b20tdXBsb2FkLzI3NTI5NC8xNC8wNC5qcGc=");
        // https://asuratoon.com/wp-content/uploads/2023/12/02_result-copy.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyLzAyX3Jlc3VsdC1jb3B5LmpwZw==");
        // https://asuratoon.com/wp-content/uploads/custom-upload/275294/14/08.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9jdXN0b20tdXBsb2FkLzI3NTI5NC8xNC8wOC5qcGc=");
        // https://asuratoon.com/wp-content/uploads/custom-upload/274644/3/06.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9jdXN0b20tdXBsb2FkLzI3NDY0NC8zLzA2LmpwZw==");
        // https://asuratoon.com/wp-content/uploads/custom-upload/275294/11/00_Mr Devourer, Please Act Like a Final Boss copy.jpg
        yield return new TestCaseData("aHR0cHM6Ly9hc3VyYXRvb24uY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9jdXN0b20tdXBsb2FkLzI3NTI5NC8xMS8wMF9NciBEZXZvdXJlciwgUGxlYXNlIEFjdCBMaWtlIGEgRmluYWwgQm9zcyBjb3B5LmpwZw==");
    }
}

