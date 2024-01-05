using System.Collections;

namespace Mangarr.Backend.Tests;

public class LHTranslationSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "lhtranslation";

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
        // https://lhtranslation.net/manga/nenrei-seigentsuki-otome-game-no-akuyaku-reijou-desu-ga-katabutsu-kishi-sama-ga-yuushuu-sugite-r-event-ga-issai-okinai/
        yield return new TestCaseData("aHR0cHM6Ly9saHRyYW5zbGF0aW9uLm5ldC9tYW5nYS9uZW5yZWktc2VpZ2VudHN1a2ktb3RvbWUtZ2FtZS1uby1ha3V5YWt1LXJlaWpvdS1kZXN1LWdhLWthdGFidXRzdS1raXNoaS1zYW1hLWdhLXl1dXNodXUtc3VnaXRlLXItZXZlbnQtZ2EtaXNzYWktb2tpbmFpLw==");
        // https://lhtranslation.net/manga/akuyaku-onzoushi-no-kanchigai-seija-seikatsu-nidome-no-jinsei-wa-yaritai-houdai-shitai-dake-na-no-ni/
        yield return new TestCaseData("aHR0cHM6Ly9saHRyYW5zbGF0aW9uLm5ldC9tYW5nYS9ha3V5YWt1LW9uem91c2hpLW5vLWthbmNoaWdhaS1zZWlqYS1zZWlrYXRzdS1uaWRvbWUtbm8tamluc2VpLXdhLXlhcml0YWktaG91ZGFpLXNoaXRhaS1kYWtlLW5hLW5vLW5pLw==");
        // https://lhtranslation.net/manga/7th-demon-prince-jilbagias-the-demon-kingdom-destroyer/
        yield return new TestCaseData("aHR0cHM6Ly9saHRyYW5zbGF0aW9uLm5ldC9tYW5nYS83dGgtZGVtb24tcHJpbmNlLWppbGJhZ2lhcy10aGUtZGVtb24ta2luZ2RvbS1kZXN0cm95ZXIv");
        // https://lhtranslation.net/manga/heroic-tale-of-villainous-prince/
        yield return new TestCaseData("aHR0cHM6Ly9saHRyYW5zbGF0aW9uLm5ldC9tYW5nYS9oZXJvaWMtdGFsZS1vZi12aWxsYWlub3VzLXByaW5jZS8=");
        // https://lhtranslation.net/manga/saitei-rank-no-boukensha-yuusha-shoujo-wo-sodateru-orette/
        yield return new TestCaseData("aHR0cHM6Ly9saHRyYW5zbGF0aW9uLm5ldC9tYW5nYS9zYWl0ZWktcmFuay1uby1ib3VrZW5zaGEteXV1c2hhLXNob3Vqby13by1zb2RhdGVydS1vcmV0dGUv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://lhtranslation.net/manga/heroic-tale-of-villainous-prince/chapter-3-2/
        yield return new TestCaseData("aHR0cHM6Ly9saHRyYW5zbGF0aW9uLm5ldC9tYW5nYS9oZXJvaWMtdGFsZS1vZi12aWxsYWlub3VzLXByaW5jZS9jaGFwdGVyLTMtMi8=");
        // https://lhtranslation.net/manga/heroic-tale-of-villainous-prince/chapter-4-1/
        yield return new TestCaseData("aHR0cHM6Ly9saHRyYW5zbGF0aW9uLm5ldC9tYW5nYS9oZXJvaWMtdGFsZS1vZi12aWxsYWlub3VzLXByaW5jZS9jaGFwdGVyLTQtMS8=");
        // https://lhtranslation.net/manga/heroic-tale-of-villainous-prince/chapter-3-1/
        yield return new TestCaseData("aHR0cHM6Ly9saHRyYW5zbGF0aW9uLm5ldC9tYW5nYS9oZXJvaWMtdGFsZS1vZi12aWxsYWlub3VzLXByaW5jZS9jaGFwdGVyLTMtMS8=");
        // https://lhtranslation.net/manga/nenrei-seigentsuki-otome-game-no-akuyaku-reijou-desu-ga-katabutsu-kishi-sama-ga-yuushuu-sugite-r-event-ga-issai-okinai/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9saHRyYW5zbGF0aW9uLm5ldC9tYW5nYS9uZW5yZWktc2VpZ2VudHN1a2ktb3RvbWUtZ2FtZS1uby1ha3V5YWt1LXJlaWpvdS1kZXN1LWdhLWthdGFidXRzdS1raXNoaS1zYW1hLWdhLXl1dXNodXUtc3VnaXRlLXItZXZlbnQtZ2EtaXNzYWktb2tpbmFpL2NoYXB0ZXItMi8=");
        // https://lhtranslation.net/manga/7th-demon-prince-jilbagias-the-demon-kingdom-destroyer/chapter-03/
        yield return new TestCaseData("aHR0cHM6Ly9saHRyYW5zbGF0aW9uLm5ldC9tYW5nYS83dGgtZGVtb24tcHJpbmNlLWppbGJhZ2lhcy10aGUtZGVtb24ta2luZ2RvbS1kZXN0cm95ZXIvY2hhcHRlci0wMy8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://lhtranslation.net/wp-content/uploads/WP-manga/data/manga_652eab158ad6f/7a2fbb748642e9707065510c51a1bd52/09.jpg
        yield return new TestCaseData("aHR0cHM6Ly9saHRyYW5zbGF0aW9uLm5ldC93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTJlYWIxNThhZDZmLzdhMmZiYjc0ODY0MmU5NzA3MDY1NTEwYzUxYTFiZDUyLzA5LmpwZw==");
        // https://lhtranslation.net/wp-content/uploads/WP-manga/data/manga_65862d1c5143a/9923e84c5e6defb75f5806294af8153b/34.jpg
        yield return new TestCaseData("aHR0cHM6Ly9saHRyYW5zbGF0aW9uLm5ldC93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTg2MmQxYzUxNDNhLzk5MjNlODRjNWU2ZGVmYjc1ZjU4MDYyOTRhZjgxNTNiLzM0LmpwZw==");
        // https://lhtranslation.net/wp-content/uploads/WP-manga/data/manga_65862d1c5143a/9923e84c5e6defb75f5806294af8153b/12.jpg
        yield return new TestCaseData("aHR0cHM6Ly9saHRyYW5zbGF0aW9uLm5ldC93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTg2MmQxYzUxNDNhLzk5MjNlODRjNWU2ZGVmYjc1ZjU4MDYyOTRhZjgxNTNiLzEyLmpwZw==");
        // https://lhtranslation.net/wp-content/uploads/WP-manga/data/manga_65862d1c5143a/9923e84c5e6defb75f5806294af8153b/28.jpg
        yield return new TestCaseData("aHR0cHM6Ly9saHRyYW5zbGF0aW9uLm5ldC93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTg2MmQxYzUxNDNhLzk5MjNlODRjNWU2ZGVmYjc1ZjU4MDYyOTRhZjgxNTNiLzI4LmpwZw==");
        // https://lhtranslation.net/wp-content/uploads/WP-manga/data/manga_65451ad985a00/c7172fbf997e759c1a8f6e63f4b52839/c003---016.jpg
        yield return new TestCaseData("aHR0cHM6Ly9saHRyYW5zbGF0aW9uLm5ldC93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NTQ1MWFkOTg1YTAwL2M3MTcyZmJmOTk3ZTc1OWMxYThmNmU2M2Y0YjUyODM5L2MwMDMtLS0wMTYuanBn");
    }
}

