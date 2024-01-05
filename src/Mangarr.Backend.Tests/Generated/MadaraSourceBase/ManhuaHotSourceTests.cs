using System.Collections;

namespace Mangarr.Backend.Tests;

public class ManhuaHotSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "manhuahot";

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
        // https://manhuahot.com/manga/the-young-master-relies-on-his-beauty-to-dominate-the-entire-system/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFob3QuY29tL21hbmdhL3RoZS15b3VuZy1tYXN0ZXItcmVsaWVzLW9uLWhpcy1iZWF1dHktdG8tZG9taW5hdGUtdGhlLWVudGlyZS1zeXN0ZW0v");
        // https://manhuahot.com/manga/fall-in-love-with-the-substitute/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFob3QuY29tL21hbmdhL2ZhbGwtaW4tbG92ZS13aXRoLXRoZS1zdWJzdGl0dXRlLw==");
        // https://manhuahot.com/manga/the-emperor-is-pregnant/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFob3QuY29tL21hbmdhL3RoZS1lbXBlcm9yLWlzLXByZWduYW50Lw==");
        // https://manhuahot.com/manga/thrive-in-catastrophe/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFob3QuY29tL21hbmdhL3Rocml2ZS1pbi1jYXRhc3Ryb3BoZS8=");
        // https://manhuahot.com/manga/my-father-in-law-is-my-wife/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFob3QuY29tL21hbmdhL215LWZhdGhlci1pbi1sYXctaXMtbXktd2lmZS8=");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://manhuahot.com/manga/my-father-in-law-is-my-wife/chap-36/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFob3QuY29tL21hbmdhL215LWZhdGhlci1pbi1sYXctaXMtbXktd2lmZS9jaGFwLTM2Lw==");
        // https://manhuahot.com/manga/the-emperor-is-pregnant/chap-3/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFob3QuY29tL21hbmdhL3RoZS1lbXBlcm9yLWlzLXByZWduYW50L2NoYXAtMy8=");
        // https://manhuahot.com/manga/my-father-in-law-is-my-wife/chap-35/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFob3QuY29tL21hbmdhL215LWZhdGhlci1pbi1sYXctaXMtbXktd2lmZS9jaGFwLTM1Lw==");
        // https://manhuahot.com/manga/my-father-in-law-is-my-wife/chap-1/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFob3QuY29tL21hbmdhL215LWZhdGhlci1pbi1sYXctaXMtbXktd2lmZS9jaGFwLTEv");
        // https://manhuahot.com/manga/my-father-in-law-is-my-wife/chap-6/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5odWFob3QuY29tL21hbmdhL215LWZhdGhlci1pbi1sYXctaXMtbXktd2lmZS9jaGFwLTYv");
    }

    public static IEnumerable ValidImages()
    {
        // http://farm66.staticflickr.com/65535/53352423946_7cee7e8379_o.jpg
        yield return new TestCaseData("aHR0cDovL2Zhcm02Ni5zdGF0aWNmbGlja3IuY29tLzY1NTM1LzUzMzUyNDIzOTQ2XzdjZWU3ZTgzNzlfby5qcGc=");
        // http://farm66.staticflickr.com/65535/53381674363_fa0a207ffe_o.jpg
        yield return new TestCaseData("aHR0cDovL2Zhcm02Ni5zdGF0aWNmbGlja3IuY29tLzY1NTM1LzUzMzgxNjc0MzYzX2ZhMGEyMDdmZmVfby5qcGc=");
        // http://farm66.staticflickr.com/65535/53352425831_f81a405768_o.jpg
        yield return new TestCaseData("aHR0cDovL2Zhcm02Ni5zdGF0aWNmbGlja3IuY29tLzY1NTM1LzUzMzUyNDI1ODMxX2Y4MWE0MDU3Njhfby5qcGc=");
        // http://farm66.staticflickr.com/65535/53405893232_39aa1d540a_o.jpg
        yield return new TestCaseData("aHR0cDovL2Zhcm02Ni5zdGF0aWNmbGlja3IuY29tLzY1NTM1LzUzNDA1ODkzMjMyXzM5YWExZDU0MGFfby5qcGc=");
        // http://farm66.staticflickr.com/65535/53352423931_71f60be30a_o.jpg
        yield return new TestCaseData("aHR0cDovL2Zhcm02Ni5zdGF0aWNmbGlja3IuY29tLzY1NTM1LzUzMzUyNDIzOTMxXzcxZjYwYmUzMGFfby5qcGc=");
    }
}

