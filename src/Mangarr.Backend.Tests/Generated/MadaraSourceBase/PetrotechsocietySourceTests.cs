using System.Collections;

namespace Mangarr.Backend.Tests;

public class PetrotechsocietySourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "petrotechsociety";

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
        // https://www.petrotechsociety.org/manga/campus-trap-mgs/
        yield return new TestCaseData("aHR0cHM6Ly93d3cucGV0cm90ZWNoc29jaWV0eS5vcmcvbWFuZ2EvY2FtcHVzLXRyYXAtbWdzLw==");
        // https://www.petrotechsociety.org/manga/hair-raising-desires/
        yield return new TestCaseData("aHR0cHM6Ly93d3cucGV0cm90ZWNoc29jaWV0eS5vcmcvbWFuZ2EvaGFpci1yYWlzaW5nLWRlc2lyZXMv");
        // https://www.petrotechsociety.org/manga/how-to-train-a-good-for-nothing-rich-boy/
        yield return new TestCaseData("aHR0cHM6Ly93d3cucGV0cm90ZWNoc29jaWV0eS5vcmcvbWFuZ2EvaG93LXRvLXRyYWluLWEtZ29vZC1mb3Itbm90aGluZy1yaWNoLWJveS8=");
        // https://www.petrotechsociety.org/manga/cupid-in-the-rainbow-trap/
        yield return new TestCaseData("aHR0cHM6Ly93d3cucGV0cm90ZWNoc29jaWV0eS5vcmcvbWFuZ2EvY3VwaWQtaW4tdGhlLXJhaW5ib3ctdHJhcC8=");
        // https://www.petrotechsociety.org/manga/guiding-hazard/
        yield return new TestCaseData("aHR0cHM6Ly93d3cucGV0cm90ZWNoc29jaWV0eS5vcmcvbWFuZ2EvZ3VpZGluZy1oYXphcmQv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://www.petrotechsociety.org/manga/hair-raising-desires/no-0007-chapter-007/
        yield return new TestCaseData("aHR0cHM6Ly93d3cucGV0cm90ZWNoc29jaWV0eS5vcmcvbWFuZ2EvaGFpci1yYWlzaW5nLWRlc2lyZXMvbm8tMDAwNy1jaGFwdGVyLTAwNy8=");
        // https://www.petrotechsociety.org/manga/how-to-train-a-good-for-nothing-rich-boy/no-0041-chapter-041/
        yield return new TestCaseData("aHR0cHM6Ly93d3cucGV0cm90ZWNoc29jaWV0eS5vcmcvbWFuZ2EvaG93LXRvLXRyYWluLWEtZ29vZC1mb3Itbm90aGluZy1yaWNoLWJveS9uby0wMDQxLWNoYXB0ZXItMDQxLw==");
        // https://www.petrotechsociety.org/manga/guiding-hazard/no-0010-chapter-010/
        yield return new TestCaseData("aHR0cHM6Ly93d3cucGV0cm90ZWNoc29jaWV0eS5vcmcvbWFuZ2EvZ3VpZGluZy1oYXphcmQvbm8tMDAxMC1jaGFwdGVyLTAxMC8=");
        // https://www.petrotechsociety.org/manga/hair-raising-desires/no-0012-chapter-012/
        yield return new TestCaseData("aHR0cHM6Ly93d3cucGV0cm90ZWNoc29jaWV0eS5vcmcvbWFuZ2EvaGFpci1yYWlzaW5nLWRlc2lyZXMvbm8tMDAxMi1jaGFwdGVyLTAxMi8=");
        // https://www.petrotechsociety.org/manga/hair-raising-desires/no-0011-chapter-011/
        yield return new TestCaseData("aHR0cHM6Ly93d3cucGV0cm90ZWNoc29jaWV0eS5vcmcvbWFuZ2EvaGFpci1yYWlzaW5nLWRlc2lyZXMvbm8tMDAxMS1jaGFwdGVyLTAxMS8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://www.petrotechsociety.org/wp-content/uploads/WP-manga/data/manga_65561f02b1fb8/c7707b6b5d08e50bcf977b32b4fdb7c5/003.jpg
        yield return new TestCaseData("aHR0cHM6Ly93d3cucGV0cm90ZWNoc29jaWV0eS5vcmcvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU1NjFmMDJiMWZiOC9jNzcwN2I2YjVkMDhlNTBiY2Y5NzdiMzJiNGZkYjdjNS8wMDMuanBn");
        // https://www.petrotechsociety.org/wp-content/uploads/WP-manga/data/manga_65561f02c1550/9c1c8fa6b14cd0795f874625f7d2c09e/006.jpg
        yield return new TestCaseData("aHR0cHM6Ly93d3cucGV0cm90ZWNoc29jaWV0eS5vcmcvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU1NjFmMDJjMTU1MC85YzFjOGZhNmIxNGNkMDc5NWY4NzQ2MjVmN2QyYzA5ZS8wMDYuanBn");
        // https://www.petrotechsociety.org/wp-content/uploads/WP-manga/data/manga_65561f02b1fb8/c7707b6b5d08e50bcf977b32b4fdb7c5/016.jpg
        yield return new TestCaseData("aHR0cHM6Ly93d3cucGV0cm90ZWNoc29jaWV0eS5vcmcvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU1NjFmMDJiMWZiOC9jNzcwN2I2YjVkMDhlNTBiY2Y5NzdiMzJiNGZkYjdjNS8wMTYuanBn");
        // https://www.petrotechsociety.org/wp-content/uploads/WP-manga/data/manga_6554d64502c01/1dbd67041bc54f1226eaeca5313b6261/002.jpg
        yield return new TestCaseData("aHR0cHM6Ly93d3cucGV0cm90ZWNoc29jaWV0eS5vcmcvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU1NGQ2NDUwMmMwMS8xZGJkNjcwNDFiYzU0ZjEyMjZlYWVjYTUzMTNiNjI2MS8wMDIuanBn");
        // https://www.petrotechsociety.org/wp-content/uploads/WP-manga/data/manga_65561f02c1550/c7971d1c1c11bee7ed0d5d0616eccbf8/006.jpg
        yield return new TestCaseData("aHR0cHM6Ly93d3cucGV0cm90ZWNoc29jaWV0eS5vcmcvd3AtY29udGVudC91cGxvYWRzL1dQLW1hbmdhL2RhdGEvbWFuZ2FfNjU1NjFmMDJjMTU1MC9jNzk3MWQxYzFjMTFiZWU3ZWQwZDVkMDYxNmVjY2JmOC8wMDYuanBn");
    }
}

