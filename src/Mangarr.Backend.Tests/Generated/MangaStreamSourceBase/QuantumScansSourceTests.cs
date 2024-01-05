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
        // https://readers-point.space/series/the-strongest-chef-in-another-world/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL3Nlcmllcy90aGUtc3Ryb25nZXN0LWNoZWYtaW4tYW5vdGhlci13b3JsZC8=");
        // https://readers-point.space/series/tribe-nine/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL3Nlcmllcy90cmliZS1uaW5lLw==");
        // https://readers-point.space/series/mount-hua-sects-greatest-genius/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL3Nlcmllcy9tb3VudC1odWEtc2VjdHMtZ3JlYXRlc3QtZ2VuaXVzLw==");
        // https://readers-point.space/series/kill-the-emperor/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL3Nlcmllcy9raWxsLXRoZS1lbXBlcm9yLw==");
        // https://readers-point.space/series/nebulas-civilization/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL3Nlcmllcy9uZWJ1bGFzLWNpdmlsaXphdGlvbi8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://readers-point.space/nebulas-civilization-chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL25lYnVsYXMtY2l2aWxpemF0aW9uLWNoYXB0ZXItMy8=");
        // https://readers-point.space/nebulas-civilization-chapter-5/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL25lYnVsYXMtY2l2aWxpemF0aW9uLWNoYXB0ZXItNS8=");
        // https://readers-point.space/nebulas-civilization-chapter-8/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL25lYnVsYXMtY2l2aWxpemF0aW9uLWNoYXB0ZXItOC8=");
        // https://readers-point.space/nebulas-civilization-chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL25lYnVsYXMtY2l2aWxpemF0aW9uLWNoYXB0ZXItMS8=");
        // https://readers-point.space/kill-the-emperor-chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL2tpbGwtdGhlLWVtcGVyb3ItY2hhcHRlci0yLw==");
    }

    public static IEnumerable ValidImages()
    {
        // https://readers-point.space/wp-content/uploads/2023/12/kte2-21.jpg
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyL2t0ZTItMjEuanBn");
        // https://readers-point.space/wp-content/uploads/2023/12/kte2-24.jpg
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyL2t0ZTItMjQuanBn");
        // https://readers-point.space/wp-content/uploads/2023/12/kte2-11.jpg
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyL2t0ZTItMTEuanBn");
        // https://readers-point.space/wp-content/uploads/2023/12/NC01-12.jpg
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyL05DMDEtMTIuanBn");
        // https://readers-point.space/wp-content/uploads/2023/12/NC01-07.jpg
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXJzLXBvaW50LnNwYWNlL3dwLWNvbnRlbnQvdXBsb2Fkcy8yMDIzLzEyL05DMDEtMDcuanBn");
    }
}

