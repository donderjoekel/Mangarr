using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangaFabSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangafab";

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
        // https://mangafab.com/painter-of-the-night
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZhYi5jb20vcGFpbnRlci1vZi10aGUtbmlnaHR8cGFpbnRlci1vZi10aGUtbmlnaHQ=");
        // https://mangafab.com/i-can-hear-it-without-a-microphone
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZhYi5jb20vaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZXxpLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25l");
        // https://mangafab.com/bj-alex
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZhYi5jb20vYmotYWxleHxiai1hbGV4");
        // https://mangafab.com/19-days
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZhYi5jb20vMTktZGF5c3wxOS1kYXlz");
        // https://mangafab.com/dangerous-convenience-store
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZhYi5jb20vZGFuZ2Vyb3VzLWNvbnZlbmllbmNlLXN0b3JlfGRhbmdlcm91cy1jb252ZW5pZW5jZS1zdG9yZQ==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangafab.com/i-can-hear-it-without-a-microphone/chapter-116
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZhYi5jb20vaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTExNg==");
        // https://mangafab.com/i-can-hear-it-without-a-microphone/chapter-34
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZhYi5jb20vaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTM0");
        // https://mangafab.com/bj-alex/chapter-76
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZhYi5jb20vYmotYWxleC9jaGFwdGVyLTc2");
        // https://mangafab.com/painter-of-the-night/chapter-129
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZhYi5jb20vcGFpbnRlci1vZi10aGUtbmlnaHQvY2hhcHRlci0xMjk=");
        // https://mangafab.com/i-can-hear-it-without-a-microphone/chapter-30-5-creators-note
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYWZhYi5jb20vaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTMwLTUtY3JlYXRvcnMtbm90ZQ==");
    }

    public static IEnumerable ValidImages()
    {
        // https://s11.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-34/c6c72c756bc9_59.jpg?acc=GDNJh_X7pn-Xz-gUUrLHTw&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTEubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTM0L2M2YzcyYzc1NmJjOV81OS5qcGc/YWNjPUdETkpoX1g3cG4tWHotZ1VVckxIVHcmZXhwPTE3MDQ0ODQ4MDA=");
        // https://s14.mbbcdn.com/res/manga/painter-of-the-night/chapter-129/952d0b5926384780a297729cb55e2847.jpeg?acc=z07xsC0tQf9NJKc3G-NkzQ&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTQubWJiY2RuLmNvbS9yZXMvbWFuZ2EvcGFpbnRlci1vZi10aGUtbmlnaHQvY2hhcHRlci0xMjkvOTUyZDBiNTkyNjM4NDc4MGEyOTc3MjljYjU1ZTI4NDcuanBlZz9hY2M9ejA3eHNDMHRRZjlOSktjM0ctTmt6USZleHA9MTcwNDQ4NDgwMA==");
        // https://s16.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-34/6e52d0c6721f_4.jpg?acc=EWTMUSm4qpcd_FWY1mYNQg&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTYubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTM0LzZlNTJkMGM2NzIxZl80LmpwZz9hY2M9RVdUTVVTbTRxcGNkX0ZXWTFtWU5RZyZleHA9MTcwNDQ4NDgwMA==");
        // https://s9.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-34/0b53a2e895d5_17.jpg?acc=BGxb-_1NwZQmt-ozbFX_pQ&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zOS5tYmJjZG4uY29tL3Jlcy9tYW5nYS9pLWNhbi1oZWFyLWl0LXdpdGhvdXQtYS1taWNyb3Bob25lL2NoYXB0ZXItMzQvMGI1M2EyZTg5NWQ1XzE3LmpwZz9hY2M9Qkd4Yi1fMU53WlFtdC1vemJGWF9wUSZleHA9MTcwNDQ4NDgwMA==");
        // https://s16.mbbcdn.com/res/manga/i-can-hear-it-without-a-microphone/chapter-34/0137abc7e187_64.jpg?acc=CDzGBiU0oX4rtsYkdTimwA&exp=1704484800
        yield return new TestCaseData("aHR0cHM6Ly9zMTYubWJiY2RuLmNvbS9yZXMvbWFuZ2EvaS1jYW4taGVhci1pdC13aXRob3V0LWEtbWljcm9waG9uZS9jaGFwdGVyLTM0LzAxMzdhYmM3ZTE4N182NC5qcGc/YWNjPUNEekdCaVUwb1g0cnRzWWtkVGltd0EmZXhwPTE3MDQ0ODQ4MDA=");
    }
}

