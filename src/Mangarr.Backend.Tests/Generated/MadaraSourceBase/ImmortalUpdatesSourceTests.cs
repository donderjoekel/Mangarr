using System.Collections;

namespace Mangarr.Backend.Tests;

public class ImmortalUpdatesSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "immortalupdates";

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
        // https://immortalupdates.com/manga/mesopotamian-mythology-of-hongkki/
        yield return new TestCaseData("aHR0cHM6Ly9pbW1vcnRhbHVwZGF0ZXMuY29tL21hbmdhL21lc29wb3RhbWlhbi1teXRob2xvZ3ktb2YtaG9uZ2traS8=");
        // https://immortalupdates.com/manga/the-saviors-bucket-list/
        yield return new TestCaseData("aHR0cHM6Ly9pbW1vcnRhbHVwZGF0ZXMuY29tL21hbmdhL3RoZS1zYXZpb3JzLWJ1Y2tldC1saXN0Lw==");
        // https://immortalupdates.com/manga/life-in-a-single-room-with-saintess/
        yield return new TestCaseData("aHR0cHM6Ly9pbW1vcnRhbHVwZGF0ZXMuY29tL21hbmdhL2xpZmUtaW4tYS1zaW5nbGUtcm9vbS13aXRoLXNhaW50ZXNzLw==");
        // https://immortalupdates.com/manga/black-behemoth/
        yield return new TestCaseData("aHR0cHM6Ly9pbW1vcnRhbHVwZGF0ZXMuY29tL21hbmdhL2JsYWNrLWJlaGVtb3RoLw==");
        // https://immortalupdates.com/manga/i-became-an-evolving-space-monsters/
        yield return new TestCaseData("aHR0cHM6Ly9pbW1vcnRhbHVwZGF0ZXMuY29tL21hbmdhL2ktYmVjYW1lLWFuLWV2b2x2aW5nLXNwYWNlLW1vbnN0ZXJzLw==");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://immortalupdates.com/manga/life-in-a-single-room-with-saintess/chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9pbW1vcnRhbHVwZGF0ZXMuY29tL21hbmdhL2xpZmUtaW4tYS1zaW5nbGUtcm9vbS13aXRoLXNhaW50ZXNzL2NoYXB0ZXItMi8=");
        // https://immortalupdates.com/manga/the-saviors-bucket-list/chapter-3/
        yield return new TestCaseData("aHR0cHM6Ly9pbW1vcnRhbHVwZGF0ZXMuY29tL21hbmdhL3RoZS1zYXZpb3JzLWJ1Y2tldC1saXN0L2NoYXB0ZXItMy8=");
        // https://immortalupdates.com/manga/black-behemoth/chapter-26/
        yield return new TestCaseData("aHR0cHM6Ly9pbW1vcnRhbHVwZGF0ZXMuY29tL21hbmdhL2JsYWNrLWJlaGVtb3RoL2NoYXB0ZXItMjYv");
        // https://immortalupdates.com/manga/mesopotamian-mythology-of-hongkki/chapter-1/
        yield return new TestCaseData("aHR0cHM6Ly9pbW1vcnRhbHVwZGF0ZXMuY29tL21hbmdhL21lc29wb3RhbWlhbi1teXRob2xvZ3ktb2YtaG9uZ2traS9jaGFwdGVyLTEv");
        // https://immortalupdates.com/manga/black-behemoth/chapter-12/
        yield return new TestCaseData("aHR0cHM6Ly9pbW1vcnRhbHVwZGF0ZXMuY29tL21hbmdhL2JsYWNrLWJlaGVtb3RoL2NoYXB0ZXItMTIv");
    }

    public static IEnumerable ValidImages()
    {
        // https://immortalupdates.com/wp-content/uploads/WP-manga/data/manga_65895ae717211/af60469d9c2bf28587bc3f77a819b4fb/16.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbW1vcnRhbHVwZGF0ZXMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1ODk1YWU3MTcyMTEvYWY2MDQ2OWQ5YzJiZjI4NTg3YmMzZjc3YTgxOWI0ZmIvMTYuanBn");
        // https://immortalupdates.com/wp-content/uploads/WP-manga/data/manga_65895ae717211/af60469d9c2bf28587bc3f77a819b4fb/09.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbW1vcnRhbHVwZGF0ZXMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1ODk1YWU3MTcyMTEvYWY2MDQ2OWQ5YzJiZjI4NTg3YmMzZjc3YTgxOWI0ZmIvMDkuanBn");
        // https://immortalupdates.com/wp-content/uploads/WP-manga/data/manga_650810fc07620/18c1e46da426d9d0ad9100fd1187e7d2/09.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbW1vcnRhbHVwZGF0ZXMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1MDgxMGZjMDc2MjAvMThjMWU0NmRhNDI2ZDlkMGFkOTEwMGZkMTE4N2U3ZDIvMDkuanBn");
        // https://immortalupdates.com/wp-content/uploads/WP-manga/data/manga_6584a89037056/13f5ef456468f37bbfe20150887fdd58/03.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbW1vcnRhbHVwZGF0ZXMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1ODRhODkwMzcwNTYvMTNmNWVmNDU2NDY4ZjM3YmJmZTIwMTUwODg3ZmRkNTgvMDMuanBn");
        // https://immortalupdates.com/wp-content/uploads/WP-manga/data/manga_6525aa27498af/40641c52bfbbba580c09d869c4e62c46/06.jpg
        yield return new TestCaseData("aHR0cHM6Ly9pbW1vcnRhbHVwZGF0ZXMuY29tL3dwLWNvbnRlbnQvdXBsb2Fkcy9XUC1tYW5nYS9kYXRhL21hbmdhXzY1MjVhYTI3NDk4YWYvNDA2NDFjNTJiZmJiYmE1ODBjMDlkODY5YzRlNjJjNDYvMDYuanBn");
    }
}

