using System.Collections;

namespace Mangarr.Backend.Tests;

public class PawMangaSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "pawmanga";

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
        // https://pawmanga.com/manga/nameless/
        yield return new TestCaseData("aHR0cHM6Ly9wYXdtYW5nYS5jb20vbWFuZ2EvbmFtZWxlc3Mv");
        // https://pawmanga.com/manga/the-road-where-forsythia-fell/
        yield return new TestCaseData("aHR0cHM6Ly9wYXdtYW5nYS5jb20vbWFuZ2EvdGhlLXJvYWQtd2hlcmUtZm9yc3l0aGlhLWZlbGwv");
        // https://pawmanga.com/manga/groan/
        yield return new TestCaseData("aHR0cHM6Ly9wYXdtYW5nYS5jb20vbWFuZ2EvZ3JvYW4v");
        // https://pawmanga.com/manga/count-tachibana/
        yield return new TestCaseData("aHR0cHM6Ly9wYXdtYW5nYS5jb20vbWFuZ2EvY291bnQtdGFjaGliYW5hLw==");
        // https://pawmanga.com/manga/chasing-lilies/
        yield return new TestCaseData("aHR0cHM6Ly9wYXdtYW5nYS5jb20vbWFuZ2EvY2hhc2luZy1saWxpZXMv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://pawmanga.com/manga/count-tachibana/chapter-25/
        yield return new TestCaseData("aHR0cHM6Ly9wYXdtYW5nYS5jb20vbWFuZ2EvY291bnQtdGFjaGliYW5hL2NoYXB0ZXItMjUv");
        // https://pawmanga.com/manga/the-road-where-forsythia-fell/chapter-30-5/
        yield return new TestCaseData("aHR0cHM6Ly9wYXdtYW5nYS5jb20vbWFuZ2EvdGhlLXJvYWQtd2hlcmUtZm9yc3l0aGlhLWZlbGwvY2hhcHRlci0zMC01Lw==");
        // https://pawmanga.com/manga/count-tachibana/chapter-20/
        yield return new TestCaseData("aHR0cHM6Ly9wYXdtYW5nYS5jb20vbWFuZ2EvY291bnQtdGFjaGliYW5hL2NoYXB0ZXItMjAv");
        // https://pawmanga.com/manga/nameless/chapter-17/
        yield return new TestCaseData("aHR0cHM6Ly9wYXdtYW5nYS5jb20vbWFuZ2EvbmFtZWxlc3MvY2hhcHRlci0xNy8=");
        // https://pawmanga.com/manga/count-tachibana/chapter-37/
        yield return new TestCaseData("aHR0cHM6Ly9wYXdtYW5nYS5jb20vbWFuZ2EvY291bnQtdGFjaGliYW5hL2NoYXB0ZXItMzcv");
    }

    public static IEnumerable ValidImages()
    {
        // https://image.pawmanga.com/nameless/chapter-17/029.webp
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZS5wYXdtYW5nYS5jb20vbmFtZWxlc3MvY2hhcHRlci0xNy8wMjkud2VicA==");
        // https://image.pawmanga.com/nameless/chapter-17/001.webp
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZS5wYXdtYW5nYS5jb20vbmFtZWxlc3MvY2hhcHRlci0xNy8wMDEud2VicA==");
        // https://image.pawmanga.com/nameless/chapter-17/027.webp
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZS5wYXdtYW5nYS5jb20vbmFtZWxlc3MvY2hhcHRlci0xNy8wMjcud2VicA==");
        // https://image.pawmanga.com/count-tachibana/chapter-37/005.webp
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZS5wYXdtYW5nYS5jb20vY291bnQtdGFjaGliYW5hL2NoYXB0ZXItMzcvMDA1LndlYnA=");
        // https://image.pawmanga.com/count-tachibana/chapter-37/003.webp
        yield return new TestCaseData("aHR0cHM6Ly9pbWFnZS5wYXdtYW5nYS5jb20vY291bnQtdGFjaGliYW5hL2NoYXB0ZXItMzcvMDAzLndlYnA=");
    }
}

