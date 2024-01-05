using System.Collections;

namespace Mangarr.Backend.Tests;

public class WebdexScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "webdexscans";

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
        // https://webdexscans.com/series/decryption-game/
        yield return new TestCaseData("aHR0cHM6Ly93ZWJkZXhzY2Fucy5jb20vc2VyaWVzL2RlY3J5cHRpb24tZ2FtZS8=");
        // https://webdexscans.com/series/after-10000-years-i-will-do-whatever-i-wanted10k/
        yield return new TestCaseData("aHR0cHM6Ly93ZWJkZXhzY2Fucy5jb20vc2VyaWVzL2FmdGVyLTEwMDAwLXllYXJzLWktd2lsbC1kby13aGF0ZXZlci1pLXdhbnRlZDEway8=");
        // https://webdexscans.com/series/max-level-necromancer/
        yield return new TestCaseData("aHR0cHM6Ly93ZWJkZXhzY2Fucy5jb20vc2VyaWVzL21heC1sZXZlbC1uZWNyb21hbmNlci8=");
        // https://webdexscans.com/series/the-great-dao-has-no-name/
        yield return new TestCaseData("aHR0cHM6Ly93ZWJkZXhzY2Fucy5jb20vc2VyaWVzL3RoZS1ncmVhdC1kYW8taGFzLW5vLW5hbWUv");
        // https://webdexscans.com/series/began-with-a-bang-i-relied-on-killing-monsters-to-lengthen-my-life/
        yield return new TestCaseData("aHR0cHM6Ly93ZWJkZXhzY2Fucy5jb20vc2VyaWVzL2JlZ2FuLXdpdGgtYS1iYW5nLWktcmVsaWVkLW9uLWtpbGxpbmctbW9uc3RlcnMtdG8tbGVuZ3RoZW4tbXktbGlmZS8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://webdexscans.com/series/began-with-a-bang-i-relied-on-killing-monsters-to-lengthen-my-life/chapter-12/
        yield return new TestCaseData("aHR0cHM6Ly93ZWJkZXhzY2Fucy5jb20vc2VyaWVzL2JlZ2FuLXdpdGgtYS1iYW5nLWktcmVsaWVkLW9uLWtpbGxpbmctbW9uc3RlcnMtdG8tbGVuZ3RoZW4tbXktbGlmZS9jaGFwdGVyLTEyLw==");
        // https://webdexscans.com/series/began-with-a-bang-i-relied-on-killing-monsters-to-lengthen-my-life/chapter-01/
        yield return new TestCaseData("aHR0cHM6Ly93ZWJkZXhzY2Fucy5jb20vc2VyaWVzL2JlZ2FuLXdpdGgtYS1iYW5nLWktcmVsaWVkLW9uLWtpbGxpbmctbW9uc3RlcnMtdG8tbGVuZ3RoZW4tbXktbGlmZS9jaGFwdGVyLTAxLw==");
        // https://webdexscans.com/series/the-great-dao-has-no-name/chapter-07/
        yield return new TestCaseData("aHR0cHM6Ly93ZWJkZXhzY2Fucy5jb20vc2VyaWVzL3RoZS1ncmVhdC1kYW8taGFzLW5vLW5hbWUvY2hhcHRlci0wNy8=");
        // https://webdexscans.com/series/after-10000-years-i-will-do-whatever-i-wanted10k/chapter-03/
        yield return new TestCaseData("aHR0cHM6Ly93ZWJkZXhzY2Fucy5jb20vc2VyaWVzL2FmdGVyLTEwMDAwLXllYXJzLWktd2lsbC1kby13aGF0ZXZlci1pLXdhbnRlZDEway9jaGFwdGVyLTAzLw==");
        // https://webdexscans.com/series/the-great-dao-has-no-name/chapter-05/
        yield return new TestCaseData("aHR0cHM6Ly93ZWJkZXhzY2Fucy5jb20vc2VyaWVzL3RoZS1ncmVhdC1kYW8taGFzLW5vLW5hbWUvY2hhcHRlci0wNS8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://i0.wp.com/webdexscans.com/wp-content/uploads/WP-manga/data/manga_654c85bccf1f8/a8411283e53b52c1aa24ee6c67592d1a/01_07.jpg?ssl=1
        yield return new TestCaseData("aHR0cHM6Ly9pMC53cC5jb20vd2ViZGV4c2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1NGM4NWJjY2YxZjgvYTg0MTEyODNlNTNiNTJjMWFhMjRlZTZjNjc1OTJkMWEvMDFfMDcuanBnP3NzbD0x");
        // https://i0.wp.com/webdexscans.com/wp-content/uploads/WP-manga/data/manga_652848607b53e/940525b4fd422cd6e5d6b88b412837cc/01_05.jpg?ssl=1
        yield return new TestCaseData("aHR0cHM6Ly9pMC53cC5jb20vd2ViZGV4c2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1Mjg0ODYwN2I1M2UvOTQwNTI1YjRmZDQyMmNkNmU1ZDZiODhiNDEyODM3Y2MvMDFfMDUuanBnP3NzbD0x");
    }
}

