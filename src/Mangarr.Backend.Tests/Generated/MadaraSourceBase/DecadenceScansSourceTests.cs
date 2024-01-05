using System.Collections;

namespace Mangarr.Backend.Tests;

public class DecadenceScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "decadencescans";

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
        // https://reader.decadencescans.com/manga/onna-no-ko-ga-iru-basho-wa/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXIuZGVjYWRlbmNlc2NhbnMuY29tL21hbmdhL29ubmEtbm8ta28tZ2EtaXJ1LWJhc2hvLXdhLw==");
        // https://reader.decadencescans.com/manga/akatsuki-no-stallion/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXIuZGVjYWRlbmNlc2NhbnMuY29tL21hbmdhL2FrYXRzdWtpLW5vLXN0YWxsaW9uLw==");
        // https://reader.decadencescans.com/manga/hadaka-no-banri-kun/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXIuZGVjYWRlbmNlc2NhbnMuY29tL21hbmdhL2hhZGFrYS1uby1iYW5yaS1rdW4v");
        // https://reader.decadencescans.com/manga/sugar-baby/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXIuZGVjYWRlbmNlc2NhbnMuY29tL21hbmdhL3N1Z2FyLWJhYnkv");
        // https://reader.decadencescans.com/manga/kibyou-musume-to-toribito-no-hiyaku/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXIuZGVjYWRlbmNlc2NhbnMuY29tL21hbmdhL2tpYnlvdS1tdXN1bWUtdG8tdG9yaWJpdG8tbm8taGl5YWt1Lw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://reader.decadencescans.com/manga/hadaka-no-banri-kun/chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXIuZGVjYWRlbmNlc2NhbnMuY29tL21hbmdhL2hhZGFrYS1uby1iYW5yaS1rdW4vY2hhcHRlci0zLw==");
        // https://reader.decadencescans.com/manga/hadaka-no-banri-kun/chapter-4/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXIuZGVjYWRlbmNlc2NhbnMuY29tL21hbmdhL2hhZGFrYS1uby1iYW5yaS1rdW4vY2hhcHRlci00Lw==");
        // https://reader.decadencescans.com/manga/hadaka-no-banri-kun/chapter-1-hadaka-no-banri-kun/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXIuZGVjYWRlbmNlc2NhbnMuY29tL21hbmdhL2hhZGFrYS1uby1iYW5yaS1rdW4vY2hhcHRlci0xLWhhZGFrYS1uby1iYW5yaS1rdW4v");
        // https://reader.decadencescans.com/manga/akatsuki-no-stallion/akatsuki-no-stallion/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXIuZGVjYWRlbmNlc2NhbnMuY29tL21hbmdhL2FrYXRzdWtpLW5vLXN0YWxsaW9uL2FrYXRzdWtpLW5vLXN0YWxsaW9uLw==");
        // https://reader.decadencescans.com/manga/onna-no-ko-ga-iru-basho-wa/volume-01/the-day-i-kicked-the-soccer-ball/
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXIuZGVjYWRlbmNlc2NhbnMuY29tL21hbmdhL29ubmEtbm8ta28tZ2EtaXJ1LWJhc2hvLXdhL3ZvbHVtZS0wMS90aGUtZGF5LWkta2lja2VkLXRoZS1zb2NjZXItYmFsbC8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://reader.decadencescans.com/wp-content/uploads/WP-manga/data/manga_64a040437e13e/f74e7b143e750f0a038f1255fed68990/Oujo_to_Kamen_p01.png
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXIuZGVjYWRlbmNlc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY0YTA0MDQzN2UxM2UvZjc0ZTdiMTQzZTc1MGYwYTAzOGYxMjU1ZmVkNjg5OTAvT3Vqb190b19LYW1lbl9wMDEucG5n");
        // https://reader.decadencescans.com/wp-content/uploads/WP-manga/data/manga_63cdbf8b07575/4a8372276ee4dbe27d9afd03091a67ea/Akatsuki_no_Stallion_p00.jpg
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXIuZGVjYWRlbmNlc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzYzY2RiZjhiMDc1NzUvNGE4MzcyMjc2ZWU0ZGJlMjdkOWFmZDAzMDkxYTY3ZWEvQWthdHN1a2lfbm9fU3RhbGxpb25fcDAwLmpwZw==");
        // https://reader.decadencescans.com/wp-content/uploads/WP-manga/data/manga_6563ebbf8dd2d/d0a7ebd8a47e131dd499c51045a34184/Onna_no_ko_ch1_p001.jpg
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXIuZGVjYWRlbmNlc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1NjNlYmJmOGRkMmQvZDBhN2ViZDhhNDdlMTMxZGQ0OTljNTEwNDVhMzQxODQvT25uYV9ub19rb19jaDFfcDAwMS5qcGc=");
        // https://reader.decadencescans.com/wp-content/uploads/WP-manga/data/manga_64a040437e13e/49b656206ec1e0f6921c304afb3a1788/Hadaka_no_Banri_kun_p001.jpg
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXIuZGVjYWRlbmNlc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY0YTA0MDQzN2UxM2UvNDliNjU2MjA2ZWMxZTBmNjkyMWMzMDRhZmIzYTE3ODgvSGFkYWthX25vX0JhbnJpX2t1bl9wMDAxLmpwZw==");
        // https://reader.decadencescans.com/wp-content/uploads/WP-manga/data/manga_64a040437e13e/e883b68478b0f53241561eda2a810b05/01.png
        yield return new TestCaseData("aHR0cHM6Ly9yZWFkZXIuZGVjYWRlbmNlc2NhbnMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY0YTA0MDQzN2UxM2UvZTg4M2I2ODQ3OGIwZjUzMjQxNTYxZWRhMmE4MTBiMDUvMDEucG5n");
    }
}

