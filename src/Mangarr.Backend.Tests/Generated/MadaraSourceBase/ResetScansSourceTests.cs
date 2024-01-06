using System.Collections;

namespace Mangarr.Backend.Tests;

public class ResetScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "resetscans";

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
        // https://reset-scans.us/manga/the-wizards-restaurant/
        yield return new TestCaseData("aHR0cHM6Ly9yZXNldC1zY2Fucy51cy9tYW5nYS90aGUtd2l6YXJkcy1yZXN0YXVyYW50Lw==");
        // https://reset-scans.us/manga/golden-mage/
        yield return new TestCaseData("aHR0cHM6Ly9yZXNldC1zY2Fucy51cy9tYW5nYS9nb2xkZW4tbWFnZS8=");
        // https://reset-scans.us/manga/hammer-gramps/
        yield return new TestCaseData("aHR0cHM6Ly9yZXNldC1zY2Fucy51cy9tYW5nYS9oYW1tZXItZ3JhbXBzLw==");
        // https://reset-scans.us/manga/panty-warrior/
        yield return new TestCaseData("aHR0cHM6Ly9yZXNldC1zY2Fucy51cy9tYW5nYS9wYW50eS13YXJyaW9yLw==");
        // https://reset-scans.us/manga/control-player/
        yield return new TestCaseData("aHR0cHM6Ly9yZXNldC1zY2Fucy51cy9tYW5nYS9jb250cm9sLXBsYXllci8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://reset-scans.us/manga/panty-warrior/chapter-04/
        yield return new TestCaseData("aHR0cHM6Ly9yZXNldC1zY2Fucy51cy9tYW5nYS9wYW50eS13YXJyaW9yL2NoYXB0ZXItMDQv");
        // https://reset-scans.us/manga/control-player/chapter-18/
        yield return new TestCaseData("aHR0cHM6Ly9yZXNldC1zY2Fucy51cy9tYW5nYS9jb250cm9sLXBsYXllci9jaGFwdGVyLTE4Lw==");
        // https://reset-scans.us/manga/control-player/chapter-21/
        yield return new TestCaseData("aHR0cHM6Ly9yZXNldC1zY2Fucy51cy9tYW5nYS9jb250cm9sLXBsYXllci9jaGFwdGVyLTIxLw==");
        // https://reset-scans.us/manga/control-player/chapter-25/
        yield return new TestCaseData("aHR0cHM6Ly9yZXNldC1zY2Fucy51cy9tYW5nYS9jb250cm9sLXBsYXllci9jaGFwdGVyLTI1Lw==");
        // https://reset-scans.us/manga/hammer-gramps/chapter-04/
        yield return new TestCaseData("aHR0cHM6Ly9yZXNldC1zY2Fucy51cy9tYW5nYS9oYW1tZXItZ3JhbXBzL2NoYXB0ZXItMDQv");
    }

    public static IEnumerable ValidImages()
    {
        // https://reset-scans.us/wp-content/uploads/WP-manga/data/manga_6447d341508e5/a683871bfff863f1467500cedecfb81a/13.jpg
        yield return new TestCaseData("aHR0cHM6Ly9yZXNldC1zY2Fucy51cy93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NDQ3ZDM0MTUwOGU1L2E2ODM4NzFiZmZmODYzZjE0Njc1MDBjZWRlY2ZiODFhLzEzLmpwZw==");
        // https://reset-scans.us/wp-content/uploads/WP-manga/data/manga_6447d341508e5/552c58c234c6c37d5d4247bfefcebd87/05.jpg
        yield return new TestCaseData("aHR0cHM6Ly9yZXNldC1zY2Fucy51cy93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NDQ3ZDM0MTUwOGU1LzU1MmM1OGMyMzRjNmMzN2Q1ZDQyNDdiZmVmY2ViZDg3LzA1LmpwZw==");
        // https://reset-scans.us/wp-content/uploads/WP-manga/data/manga_64d62756f315f/1224a09e8022aed76b49bb6c254aaf62/31.webp
        yield return new TestCaseData("aHR0cHM6Ly9yZXNldC1zY2Fucy51cy93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NGQ2Mjc1NmYzMTVmLzEyMjRhMDllODAyMmFlZDc2YjQ5YmI2YzI1NGFhZjYyLzMxLndlYnA=");
        // https://reset-scans.us/wp-content/uploads/WP-manga/data/manga_64d62756f315f/1224a09e8022aed76b49bb6c254aaf62/06.webp
        yield return new TestCaseData("aHR0cHM6Ly9yZXNldC1zY2Fucy51cy93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NGQ2Mjc1NmYzMTVmLzEyMjRhMDllODAyMmFlZDc2YjQ5YmI2YzI1NGFhZjYyLzA2LndlYnA=");
        // https://reset-scans.us/wp-content/uploads/WP-manga/data/manga_64d62756f315f/1224a09e8022aed76b49bb6c254aaf62/05.webp
        yield return new TestCaseData("aHR0cHM6Ly9yZXNldC1zY2Fucy51cy93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NGQ2Mjc1NmYzMTVmLzEyMjRhMDllODAyMmFlZDc2YjQ5YmI2YzI1NGFhZjYyLzA1LndlYnA=");
    }
}

