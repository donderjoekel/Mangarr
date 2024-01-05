using System.Collections;

namespace Mangarr.Backend.Tests;

public class CypherScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "cypherscans";

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
        // https://cypherscans.xyz/manga/i-use-my-muscles-to-dominate-the-world-of-cultivating-immortals/
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovbWFuZ2EvaS11c2UtbXktbXVzY2xlcy10by1kb21pbmF0ZS10aGUtd29ybGQtb2YtY3VsdGl2YXRpbmctaW1tb3J0YWxzLw==");
        // https://cypherscans.xyz/manga/reborn-as-the-heavenly-martial-demon/
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovbWFuZ2EvcmVib3JuLWFzLXRoZS1oZWF2ZW5seS1tYXJ0aWFsLWRlbW9uLw==");
        // https://cypherscans.xyz/manga/dark-and-light-martial-emperor/
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovbWFuZ2EvZGFyay1hbmQtbGlnaHQtbWFydGlhbC1lbXBlcm9yLw==");
        // https://cypherscans.xyz/manga/i-can-crit-infinitely/
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovbWFuZ2EvaS1jYW4tY3JpdC1pbmZpbml0ZWx5Lw==");
        // https://cypherscans.xyz/manga/i-really-dont-want-to-be-the-first/
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovbWFuZ2EvaS1yZWFsbHktZG9udC13YW50LXRvLWJlLXRoZS1maXJzdC8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://cypherscans.xyz/i-really-dont-want-to-be-the-first-chapter-100/
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovaS1yZWFsbHktZG9udC13YW50LXRvLWJlLXRoZS1maXJzdC1jaGFwdGVyLTEwMC8=");
        // https://cypherscans.xyz/i-really-dont-want-to-be-the-first-chapter-121/
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovaS1yZWFsbHktZG9udC13YW50LXRvLWJlLXRoZS1maXJzdC1jaGFwdGVyLTEyMS8=");
        // https://cypherscans.xyz/i-really-dont-want-to-be-the-first-chapter-50/
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovaS1yZWFsbHktZG9udC13YW50LXRvLWJlLXRoZS1maXJzdC1jaGFwdGVyLTUwLw==");
        // https://cypherscans.xyz/i-really-dont-want-to-be-the-first-chapter-2/
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovaS1yZWFsbHktZG9udC13YW50LXRvLWJlLXRoZS1maXJzdC1jaGFwdGVyLTIv");
        // https://cypherscans.xyz/i-really-dont-want-to-be-the-first-chapter-106/
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovaS1yZWFsbHktZG9udC13YW50LXRvLWJlLXRoZS1maXJzdC1jaGFwdGVyLTEwNi8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://cypherscans.xyz/wp-content/uploads/2024/01/300-126.webp
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMzAwLTEyNi53ZWJw");
        // https://cypherscans.xyz/wp-content/uploads/2024/01/005-49.jpeg
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDA1LTQ5LmpwZWc=");
        // https://cypherscans.xyz/wp-content/uploads/2024/01/006-45.webp
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDA2LTQ1LndlYnA=");
        // https://cypherscans.xyz/wp-content/uploads/2024/01/300-105.webp
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMzAwLTEwNS53ZWJw");
        // https://cypherscans.xyz/wp-content/uploads/2024/01/002-49.jpeg
        yield return new TestCaseData("aHR0cHM6Ly9jeXBoZXJzY2Fucy54eXovd3AtY29udGVudC91cGxvYWRzLzIwMjQvMDEvMDAyLTQ5LmpwZWc=");
    }
}

