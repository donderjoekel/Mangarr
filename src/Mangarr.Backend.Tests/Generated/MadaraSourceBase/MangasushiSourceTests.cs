using System.Collections;

namespace Mangarr.Backend.Tests;

public class MangasushiSourceTests : SourceTestBase
{
    protected override string SourceIdentifier => "mangasushi";

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
        // https://mangasushi.org/manga/tensei-akuma-no-saikyou-yuusha-ikusei-keikaku/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXN1c2hpLm9yZy9tYW5nYS90ZW5zZWktYWt1bWEtbm8tc2Fpa3lvdS15dXVzaGEtaWt1c2VpLWtlaWtha3Uv");
        // https://mangasushi.org/manga/isekai-ni-shoukan-saretan-dakedo-nandemo-kireteshimau-kennou-wo-teni-ireta-node-easy-mode-deshita/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXN1c2hpLm9yZy9tYW5nYS9pc2VrYWktbmktc2hvdWthbi1zYXJldGFuLWRha2Vkby1uYW5kZW1vLWtpcmV0ZXNoaW1hdS1rZW5ub3Utd28tdGVuaS1pcmV0YS1ub2RlLWVhc3ktbW9kZS1kZXNoaXRhLw==");
        // https://mangasushi.org/manga/maou-reijou-no-shikousha-isekai-shitsuji-wa-ouse-no-mama-ni/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXN1c2hpLm9yZy9tYW5nYS9tYW91LXJlaWpvdS1uby1zaGlrb3VzaGEtaXNla2FpLXNoaXRzdWppLXdhLW91c2Utbm8tbWFtYS1uaS8=");
        // https://mangasushi.org/manga/the-white-mage-who-was-banished-from-the-heros-party-is-picked-up-by-an-s-rank-adventurer-this-white-mage-is-too-out-of-the-ordinary/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXN1c2hpLm9yZy9tYW5nYS90aGUtd2hpdGUtbWFnZS13aG8td2FzLWJhbmlzaGVkLWZyb20tdGhlLWhlcm9zLXBhcnR5LWlzLXBpY2tlZC11cC1ieS1hbi1zLXJhbmstYWR2ZW50dXJlci10aGlzLXdoaXRlLW1hZ2UtaXMtdG9vLW91dC1vZi10aGUtb3JkaW5hcnkv");
        // https://mangasushi.org/manga/goinkyo-maou-sama-no-kaerizaki/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXN1c2hpLm9yZy9tYW5nYS9nb2lua3lvLW1hb3Utc2FtYS1uby1rYWVyaXpha2kv");
    }

    public static IEnumerable ValidPageLists()
    {
        // https://mangasushi.org/manga/the-white-mage-who-was-banished-from-the-heros-party-is-picked-up-by-an-s-rank-adventurer-this-white-mage-is-too-out-of-the-ordinary/chapter-16-2/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXN1c2hpLm9yZy9tYW5nYS90aGUtd2hpdGUtbWFnZS13aG8td2FzLWJhbmlzaGVkLWZyb20tdGhlLWhlcm9zLXBhcnR5LWlzLXBpY2tlZC11cC1ieS1hbi1zLXJhbmstYWR2ZW50dXJlci10aGlzLXdoaXRlLW1hZ2UtaXMtdG9vLW91dC1vZi10aGUtb3JkaW5hcnkvY2hhcHRlci0xNi0yLw==");
        // https://mangasushi.org/manga/the-white-mage-who-was-banished-from-the-heros-party-is-picked-up-by-an-s-rank-adventurer-this-white-mage-is-too-out-of-the-ordinary/chapter-22-2/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXN1c2hpLm9yZy9tYW5nYS90aGUtd2hpdGUtbWFnZS13aG8td2FzLWJhbmlzaGVkLWZyb20tdGhlLWhlcm9zLXBhcnR5LWlzLXBpY2tlZC11cC1ieS1hbi1zLXJhbmstYWR2ZW50dXJlci10aGlzLXdoaXRlLW1hZ2UtaXMtdG9vLW91dC1vZi10aGUtb3JkaW5hcnkvY2hhcHRlci0yMi0yLw==");
        // https://mangasushi.org/manga/the-white-mage-who-was-banished-from-the-heros-party-is-picked-up-by-an-s-rank-adventurer-this-white-mage-is-too-out-of-the-ordinary/chapter-19-3/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXN1c2hpLm9yZy9tYW5nYS90aGUtd2hpdGUtbWFnZS13aG8td2FzLWJhbmlzaGVkLWZyb20tdGhlLWhlcm9zLXBhcnR5LWlzLXBpY2tlZC11cC1ieS1hbi1zLXJhbmstYWR2ZW50dXJlci10aGlzLXdoaXRlLW1hZ2UtaXMtdG9vLW91dC1vZi10aGUtb3JkaW5hcnkvY2hhcHRlci0xOS0zLw==");
        // https://mangasushi.org/manga/the-white-mage-who-was-banished-from-the-heros-party-is-picked-up-by-an-s-rank-adventurer-this-white-mage-is-too-out-of-the-ordinary/chapter-28/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXN1c2hpLm9yZy9tYW5nYS90aGUtd2hpdGUtbWFnZS13aG8td2FzLWJhbmlzaGVkLWZyb20tdGhlLWhlcm9zLXBhcnR5LWlzLXBpY2tlZC11cC1ieS1hbi1zLXJhbmstYWR2ZW50dXJlci10aGlzLXdoaXRlLW1hZ2UtaXMtdG9vLW91dC1vZi10aGUtb3JkaW5hcnkvY2hhcHRlci0yOC8=");
        // https://mangasushi.org/manga/the-white-mage-who-was-banished-from-the-heros-party-is-picked-up-by-an-s-rank-adventurer-this-white-mage-is-too-out-of-the-ordinary/chapter-09/
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXN1c2hpLm9yZy9tYW5nYS90aGUtd2hpdGUtbWFnZS13aG8td2FzLWJhbmlzaGVkLWZyb20tdGhlLWhlcm9zLXBhcnR5LWlzLXBpY2tlZC11cC1ieS1hbi1zLXJhbmstYWR2ZW50dXJlci10aGlzLXdoaXRlLW1hZ2UtaXMtdG9vLW91dC1vZi10aGUtb3JkaW5hcnkvY2hhcHRlci0wOS8=");
    }

    public static IEnumerable ValidImages()
    {
        // https://mangasushi.org/wp-content/uploads/WP-manga/data/manga_649871ed76796/2a481f59b81d6e68f030dd84a1cec790/10.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXN1c2hpLm9yZy93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NDk4NzFlZDc2Nzk2LzJhNDgxZjU5YjgxZDZlNjhmMDMwZGQ4NGExY2VjNzkwLzEwLmpwZw==");
        // https://mangasushi.org/wp-content/uploads/WP-manga/data/manga_649871ed76796/c0d1d068f0d306853800ce11372527f4/10.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXN1c2hpLm9yZy93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NDk4NzFlZDc2Nzk2L2MwZDFkMDY4ZjBkMzA2ODUzODAwY2UxMTM3MjUyN2Y0LzEwLmpwZw==");
        // https://mangasushi.org/wp-content/uploads/WP-manga/data/manga_649871ed76796/2a481f59b81d6e68f030dd84a1cec790/15.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXN1c2hpLm9yZy93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NDk4NzFlZDc2Nzk2LzJhNDgxZjU5YjgxZDZlNjhmMDMwZGQ4NGExY2VjNzkwLzE1LmpwZw==");
        // https://mangasushi.org/wp-content/uploads/WP-manga/data/manga_649871ed76796/c0d1d068f0d306853800ce11372527f4/20.jpg
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXN1c2hpLm9yZy93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NDk4NzFlZDc2Nzk2L2MwZDFkMDY4ZjBkMzA2ODUzODAwY2UxMTM3MjUyN2Y0LzIwLmpwZw==");
        // https://mangasushi.org/wp-content/uploads/WP-manga/data/manga_649871ed76796/c750db1f74514f387b243710ce92a09d/c009---009.png
        yield return new TestCaseData("aHR0cHM6Ly9tYW5nYXN1c2hpLm9yZy93cC1jb250ZW50L3VwbG9hZHMvV1AtbWFuZ2EvZGF0YS9tYW5nYV82NDk4NzFlZDc2Nzk2L2M3NTBkYjFmNzQ1MTRmMzg3YjI0MzcxMGNlOTJhMDlkL2MwMDktLS0wMDkucG5n");
    }
}

