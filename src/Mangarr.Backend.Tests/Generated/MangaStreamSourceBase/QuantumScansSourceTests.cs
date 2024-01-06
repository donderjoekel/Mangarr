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
        // https://readers-point.space?p=6373
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlP3A9NjM3M3w2Mzcz");
        // https://readers-point.space?p=5489
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlP3A9NTQ4OXw1NDg5");
        // https://readers-point.space?p=6566
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlP3A9NjU2Nnw2NTY2");
        // https://readers-point.space?p=5260
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlP3A9NTI2MHw1MjYw");
        // https://readers-point.space?p=5233
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlP3A9NTIzM3w1MjMz");
    }

    public static IEnumerable ValidImages()
    {
        // https://readers-point.space/wp-content/uploads/2023/12/NC03-07.jpg
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyL05DMDMtMDcuanBn");
        // https://readers-point.space/wp-content/uploads/2023/12/tribe9ch1_10.jpg
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyL3RyaWJlOWNoMV8xMC5qcGc=");
        // https://readers-point.space/wp-content/uploads/2023/12/NC01-24.jpg
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyL05DMDEtMjQuanBn");
        // https://readers-point.space/wp-content/uploads/2023/12/NC03-02.jpg
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyL05DMDMtMDIuanBn");
        // https://readers-point.space/wp-content/uploads/2023/12/strongestchef3-23.jpg
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyL3N0cm9uZ2VzdGNoZWYzLTIzLmpwZw==");
    }
}

