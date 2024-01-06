using System.Collections;

namespace Mangarr.Backend.Tests;

public class QuantumScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "quantumscans";

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
        // https://readers-point.space?p=6405
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlP3A9NjQwNXw2NDA1");
        // https://readers-point.space?p=6371
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlP3A9NjM3MXw2Mzcx");
        // https://readers-point.space?p=5935
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlP3A9NTkzNXw1OTM1");
        // https://readers-point.space?p=5258
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlP3A9NTI1OHw1MjU4");
        // https://readers-point.space?p=5197
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlP3A9NTE5N3w1MTk3");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://readers-point.space/tribe-nine-chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL3RyaWJlLW5pbmUtY2hhcHRlci0yL3xodHRwczovL3JlYWRlcnMtcG9pbnQuc3BhY2U/cD02MzcxfDI=");
        // https://readers-point.space/the-strongest-chef-in-another-world-chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL3RoZS1zdHJvbmdlc3QtY2hlZi1pbi1hbm90aGVyLXdvcmxkLWNoYXB0ZXItMy98aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlP3A9NjQwNXwz");
        // https://readers-point.space/kill-the-emperor-chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL2tpbGwtdGhlLWVtcGVyb3ItY2hhcHRlci0yL3xodHRwczovL3JlYWRlcnMtcG9pbnQuc3BhY2U/cD01MjU4fDI=");
        // https://readers-point.space/nebulas-civilization-chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL25lYnVsYXMtY2l2aWxpemF0aW9uLWNoYXB0ZXItMi98aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlP3A9NTE5N3wy");
        // https://readers-point.space/nebulas-civilization-chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL25lYnVsYXMtY2l2aWxpemF0aW9uLWNoYXB0ZXItNS98aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlP3A9NTE5N3w1");
    }

    public static IEnumerable ValidImages()
    {
        // https://readers-point.space/wp-content/uploads/2023/12/tribe9ch2_15.jpg
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyL3RyaWJlOWNoMl8xNS5qcGc=");
        // https://readers-point.space/wp-content/uploads/2023/12/NC02-09.jpg
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyL05DMDItMDkuanBn");
        // https://readers-point.space/wp-content/uploads/2023/12/strongestchef3-24.jpg
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyL3N0cm9uZ2VzdGNoZWYzLTI0LmpwZw==");
        // https://readers-point.space/wp-content/uploads/2023/12/tribe9ch2_07.jpg
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyL3RyaWJlOWNoMl8wNy5qcGc=");
        // https://readers-point.space/wp-content/uploads/2023/12/NC05-16.jpg
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyL05DMDUtMTYuanBn");
    }
}

