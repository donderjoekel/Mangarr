using System.Collections;

namespace Mangarr.Backend.Tests;

public class ReaperScansSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "reaperscans";

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
        // https://reaperscans.com/comics/5134-level-up-with-skills
        yield return new TestCaseData("aHR0cHM6Ly9yZWFwZXJzY2Fucy5jb20vY29taWNzLzUxMzQtbGV2ZWwtdXAtd2l0aC1za2lsbHM=");
        // https://reaperscans.com/comics/8713-dungeon-reset
        yield return new TestCaseData("aHR0cHM6Ly9yZWFwZXJzY2Fucy5jb20vY29taWNzLzg3MTMtZHVuZ2Vvbi1yZXNldA==");
        // https://reaperscans.com/comics/2809-player-from-today-onwards
        yield return new TestCaseData("aHR0cHM6Ly9yZWFwZXJzY2Fucy5jb20vY29taWNzLzI4MDktcGxheWVyLWZyb20tdG9kYXktb253YXJkcw==");
        // https://reaperscans.com/comics/1648-advanced-evolution
        yield return new TestCaseData("aHR0cHM6Ly9yZWFwZXJzY2Fucy5jb20vY29taWNzLzE2NDgtYWR2YW5jZWQtZXZvbHV0aW9u");
        // https://reaperscans.com/comics/5062-strongest-fighter
        yield return new TestCaseData("aHR0cHM6Ly9yZWFwZXJzY2Fucy5jb20vY29taWNzLzUwNjItc3Ryb25nZXN0LWZpZ2h0ZXI=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://reaperscans.com/comics/8713-dungeon-reset/chapters/63041658-chapter-113
        yield return new TestCaseData("aHR0cHM6Ly9yZWFwZXJzY2Fucy5jb20vY29taWNzLzg3MTMtZHVuZ2Vvbi1yZXNldC9jaGFwdGVycy82MzA0MTY1OC1jaGFwdGVyLTExMw==");
        // https://reaperscans.com/comics/5134-level-up-with-skills/chapters/69265763-chapter-31
        yield return new TestCaseData("aHR0cHM6Ly9yZWFwZXJzY2Fucy5jb20vY29taWNzLzUxMzQtbGV2ZWwtdXAtd2l0aC1za2lsbHMvY2hhcHRlcnMvNjkyNjU3NjMtY2hhcHRlci0zMQ==");
        // https://reaperscans.com/comics/2809-player-from-today-onwards/chapters/98582465-chapter-50
        yield return new TestCaseData("aHR0cHM6Ly9yZWFwZXJzY2Fucy5jb20vY29taWNzLzI4MDktcGxheWVyLWZyb20tdG9kYXktb253YXJkcy9jaGFwdGVycy85ODU4MjQ2NS1jaGFwdGVyLTUw");
        // https://reaperscans.com/comics/2809-player-from-today-onwards/chapters/47425910-chapter-57
        yield return new TestCaseData("aHR0cHM6Ly9yZWFwZXJzY2Fucy5jb20vY29taWNzLzI4MDktcGxheWVyLWZyb20tdG9kYXktb253YXJkcy9jaGFwdGVycy80NzQyNTkxMC1jaGFwdGVyLTU3");
        // https://reaperscans.com/comics/2809-player-from-today-onwards/chapters/54316337-chapter-33
        yield return new TestCaseData("aHR0cHM6Ly9yZWFwZXJzY2Fucy5jb20vY29taWNzLzI4MDktcGxheWVyLWZyb20tdG9kYXktb253YXJkcy9jaGFwdGVycy81NDMxNjMzNy1jaGFwdGVyLTMz");
    }

    public static IEnumerable ValidImages()
    {
        // https://media.reaperscans.com/file/4SRBHm/comics/f999031a-b706-4407-bfaf-726855728da7/chapters/ba56fa64-55e1-455a-984e-c7d6b306c7fa/2.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tZWRpYS5yZWFwZXJzY2Fucy5jb20vZmlsZS80U1JCSG0vY29taWNzL2Y5OTkwMzFhLWI3MDYtNDQwNy1iZmFmLTcyNjg1NTcyOGRhNy9jaGFwdGVycy9iYTU2ZmE2NC01NWUxLTQ1NWEtOTg0ZS1jN2Q2YjMwNmM3ZmEvMi5qcGc=");
        // https://media.reaperscans.com/file/4SRBHm/comics/f999031a-b706-4407-bfaf-726855728da7/chapters/ba56fa64-55e1-455a-984e-c7d6b306c7fa/8.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tZWRpYS5yZWFwZXJzY2Fucy5jb20vZmlsZS80U1JCSG0vY29taWNzL2Y5OTkwMzFhLWI3MDYtNDQwNy1iZmFmLTcyNjg1NTcyOGRhNy9jaGFwdGVycy9iYTU2ZmE2NC01NWUxLTQ1NWEtOTg0ZS1jN2Q2YjMwNmM3ZmEvOC5qcGc=");
        // https://media.reaperscans.com/file/4SRBHm/comics/f999031a-b706-4407-bfaf-726855728da7/chapters/106866aa-87cc-48c9-a77e-8f7c30ea2e74/15.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tZWRpYS5yZWFwZXJzY2Fucy5jb20vZmlsZS80U1JCSG0vY29taWNzL2Y5OTkwMzFhLWI3MDYtNDQwNy1iZmFmLTcyNjg1NTcyOGRhNy9jaGFwdGVycy8xMDY4NjZhYS04N2NjLTQ4YzktYTc3ZS04ZjdjMzBlYTJlNzQvMTUuanBn");
        // https://media.reaperscans.com/file/4SRBHm/comics/f999031a-b706-4407-bfaf-726855728da7/chapters/1ceb6a69-f955-46e1-a64a-30eb4c5a4a72/07%20copy.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tZWRpYS5yZWFwZXJzY2Fucy5jb20vZmlsZS80U1JCSG0vY29taWNzL2Y5OTkwMzFhLWI3MDYtNDQwNy1iZmFmLTcyNjg1NTcyOGRhNy9jaGFwdGVycy8xY2ViNmE2OS1mOTU1LTQ2ZTEtYTY0YS0zMGViNGM1YTRhNzIvMDclMjBjb3B5LmpwZw==");
        // https://media.reaperscans.com/file/4SRBHm/comics/f999031a-b706-4407-bfaf-726855728da7/chapters/106866aa-87cc-48c9-a77e-8f7c30ea2e74/4.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tZWRpYS5yZWFwZXJzY2Fucy5jb20vZmlsZS80U1JCSG0vY29taWNzL2Y5OTkwMzFhLWI3MDYtNDQwNy1iZmFmLTcyNjg1NTcyOGRhNy9jaGFwdGVycy8xMDY4NjZhYS04N2NjLTQ4YzktYTc3ZS04ZjdjMzBlYTJlNzQvNC5qcGc=");
    }
}

