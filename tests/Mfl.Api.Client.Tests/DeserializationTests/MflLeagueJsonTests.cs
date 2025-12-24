using System.Text.Json;
using mflLeague = Mfl.Api.Model.League;

namespace Mfl.Api.Client.Tests.DeserializationTests;

public class MFLLeagueJsonTests
{
    private readonly JsonSerializerOptions _jsonOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };

    private readonly string sampleJson = @"{
  ""version"": ""1.0"",
  ""encoding"": ""utf-8"",
  ""league"": {
    ""victoryPointsBuckets"": ""0 0 0"",
    ""playerLimitUnit"": ""LEAGUE"",
    ""id"": ""15999"",
    ""rosterLimits"": {
      ""position"": [
        {
          ""name"": ""QB"",
          ""limit"": ""0-0""
        },
        {
          ""limit"": ""0-0"",
          ""name"": ""RB""
        },
        {
          ""name"": ""WR+TE"",
          ""limit"": ""0-0""
        },
        {
          ""limit"": ""0-0"",
          ""name"": ""PK""
        }
      ]
    },
    ""starters"": {
      ""count"": ""10"",
      ""position"": [
        {
          ""limit"": ""1-2"",
          ""name"": ""QB""
        },
        {
          ""name"": ""RB"",
          ""limit"": ""3-5""
        },
        {
          ""name"": ""WR+TE"",
          ""limit"": ""3-5""
        },
        {
          ""limit"": ""1-2"",
          ""name"": ""PK""
        }
      ]
    },
    ""survivorPoolStartWeek"": ""10"",
    ""rosterSize"": ""30"",
    ""precision"": ""0"",
    ""name"": ""UnitTest"",
    ""currentWaiverType"": ""WAIVERS"",
    ""victoryPointsStartWeek"": ""1"",
    ""taxiSquad"": ""0"",
    ""franchises"": {
      ""franchise"": [
        {
          ""waiverSortOrder"": ""4"",
          ""id"": ""0001"",
          ""logo"": ""https://www44.myfantasyleague.com/fflnet2003/helmets/h-0665.gif"",
          ""icon"": ""https://www44.myfantasyleague.com/fflnet2003/helmets/h-0666.gif"",
          ""name"": ""WS""
        },
        {
          ""sound"": ""https://www43.myfantasyleague.com/fflnetdynamic2006/35869_franchise_sound0002.wav"",
          ""stadium"": ""Bemis Woods"",
          ""logo"": ""https://www44.myfantasyleague.com/fflnetdynamic2003/46358_franchise_logo0002.jpg"",
          ""name"": ""BK"",
          ""icon"": ""https://www44.myfantasyleague.com/fflnetdynamic2023/15930_franchise_icon0002.gif"",
          ""waiverSortOrder"": ""10"",
          ""id"": ""0002""
        },
        {
          ""id"": ""0003"",
          ""stadium"": ""Double Doink Stadium"",
          ""waiverSortOrder"": ""7"",
          ""icon"": ""https://www44.myfantasyleague.com/fflnet2007/helmets/h-0678.gif"",
          ""name"": ""JR"",
          ""logo"": ""https://www44.myfantasyleague.com/fflnet2007/helmets/h-0678.gif""
        },
        {
          ""waiverSortOrder"": ""5"",
          ""id"": ""0004"",
          ""logo"": ""https://www44.myfantasyleague.com/fflnet2022/helmets/h-0442.gif"",
          ""name"": ""BH"",
          ""icon"": ""https://www44.myfantasyleague.com/fflnet2022/helmets/h-0442.gif""
        },
        {
          ""waiverSortOrder"": ""9"",
          ""id"": ""0005"",
          ""logo"": ""https://www44.myfantasyleague.com/fflnet2003/logos/Football_Ball_8.gif"",
          ""name"": ""JT"",
          ""icon"": ""https://www44.myfantasyleague.com/fflnet2003/helmets/h-0886.gif""
        },
        {
          ""logo"": ""https://www44.myfantasyleague.com/fflnetdynamic2018/15930_franchise_logo0006.jpg"",
          ""name"": ""KT"",
          ""icon"": ""https://www44.myfantasyleague.com/fflnet2013/newhelmets/nh-0031.png"",
          ""stadium"": ""GPG Stadium"",
          ""waiverSortOrder"": ""8"",
          ""id"": ""0006""
        },
        {
          ""waiverSortOrder"": ""6"",
          ""id"": ""0007"",
          ""logo"": ""https://www44.myfantasyleague.com/fflnetdynamic2017/15930_franchise_logo0007.png"",
          ""icon"": ""https://www44.myfantasyleague.com/fflnetdynamic2017/15930_franchise_icon0007.png"",
          ""name"": ""RB""
        },
        {
          ""waiverSortOrder"": ""3"",
          ""id"": ""0008"",
          ""logo"": ""https://www44.myfantasyleague.com/fflnet2007/helmets/h-0674.gif"",
          ""icon"": ""https://www44.myfantasyleague.com/fflnet2009/helmets/h-0449.gif"",
          ""name"": ""CL""
        },
        {
          ""logo"": ""https://www44.myfantasyleague.com/fflnet2007/helmets/h-0818.gif"",
          ""icon"": ""https://www44.myfantasyleague.com/fflnet2007/helmets/h-0818.gif"",
          ""name"": ""DC"",
          ""waiverSortOrder"": ""2"",
          ""id"": ""0009""
        },
        {
          ""icon"": ""https://www44.myfantasyleague.com/fflnet2016/helmets/h-0873.gif"",
          ""name"": ""DB"",
          ""logo"": ""https://www44.myfantasyleague.com/fflnet2016/helmets/h-0873.gif"",
          ""id"": ""0010"",
          ""waiverSortOrder"": ""1""
        }
      ],
      ""count"": ""10""
    },
    ""survivorPoolEndWeek"": ""17"",
    ""endWeek"": ""17"",
    ""loadRosters"": ""none"",
    ""partialLineupAllowed"": ""YES"",
    ""lastRegularSeasonWeek"": ""16"",
    ""injuredReserve"": ""10"",
    ""rostersPerPlayer"": ""1"",
    ""victoryPointsEndWeek"": ""16"",
    ""survivorPool"": ""Yes"",
    ""startWeek"": ""1"",
    ""h2h"": ""YES"",
    ""mobileAlerts"": """",
    ""baseURL"": ""https://www44.myfantasyleague.com"",
    ""history"": {
      ""league"": [
        {
          ""url"": ""https://www44.myfantasyleague.com/2025/home/15999"",
          ""year"": ""2025""
        },
        {
          ""url"": ""https://www41.myfantasyleague.com/2002/home/69999"",
          ""year"": ""2002""
        },
        {
          ""url"": ""https://www44.myfantasyleague.com/2003/home/46999"",
          ""year"": ""2003""
        },
        {
          ""url"": ""https://www41.myfantasyleague.com/2004/home/38999"",
          ""year"": ""2004""
        },
        {
          ""url"": ""https://www43.myfantasyleague.com/2005/home/43999"",
          ""year"": ""2005""
        },
        {
          ""year"": ""2006"",
          ""url"": ""https://www43.myfantasyleague.com/2006/home/35999""
        },
        {
          ""year"": ""2007"",
          ""url"": ""https://www45.myfantasyleague.com/2007/home/18999""
        },
        {
          ""url"": ""https://www43.myfantasyleague.com/2008/home/25999"",
          ""year"": ""2008""
        },
        {
          ""year"": ""2009"",
          ""url"": ""https://www42.myfantasyleague.com/2009/home/14999""
        },
        {
          ""year"": ""2010"",
          ""url"": ""https://www49.myfantasyleague.com/2010/home/37999""
        },
        {
          ""year"": ""2011"",
          ""url"": ""https://www47.myfantasyleague.com/2011/home/26999""
        },
        {
          ""year"": ""2012"",
          ""url"": ""https://www46.myfantasyleague.com/2012/home/25999""
        },
        {
          ""year"": ""2013"",
          ""url"": ""https://www45.myfantasyleague.com/2013/home/44999""
        },
        {
          ""url"": ""https://www45.myfantasyleague.com/2014/home/30999"",
          ""year"": ""2014""
        },
        {
          ""year"": ""2015"",
          ""url"": ""https://www44.myfantasyleague.com/2015/home/22999""
        },
        {
          ""url"": ""https://www44.myfantasyleague.com/2016/home/15999"",
          ""year"": ""2016""
        },
        {
          ""url"": ""http://www44.myfantasyleague.com/2017/home/15999"",
          ""year"": ""2017""
        },
        {
          ""url"": ""https://www44.myfantasyleague.com/2018/home/15999"",
          ""year"": ""2018""
        },
        {
          ""year"": ""2019"",
          ""url"": ""https://www44.myfantasyleague.com/2019/home/15999""
        },
        {
          ""year"": ""2020"",
          ""url"": ""https://www44.myfantasyleague.com/2020/home/15999""
        },
        {
          ""year"": ""2021"",
          ""url"": ""https://www44.myfantasyleague.com/2021/home/15999""
        },
        {
          ""url"": ""https://www44.myfantasyleague.com/2022/home/15999"",
          ""year"": ""2022""
        },
        {
          ""url"": ""https://www44.myfantasyleague.com/2023/home/15999"",
          ""year"": ""2023""
        },
        {
          ""url"": ""https://www44.myfantasyleague.com/2024/home/15999"",
          ""year"": ""2024""
        }
      ]
    },
    ""bestLineup"": ""No"",
    ""usesContractYear"": ""0"",
    ""victoryPointsTie"": "".4"",
    ""defaultTradeExpirationDays"": ""5"",
    ""victoryPointsWin"": ""1"",
    ""lockout"": ""No"",
    ""maxWaiverRounds"": ""6"",
    ""standingsSort"": ""PCT,VICTORY_POINTS,PTS,H2H,"",
    ""victoryPointsLoss"": ""0"",
    ""usesSalaries"": ""0""
  }
}
";

    [Fact]
    public void DeserializeStaticLeagueData()
    {


        var root = JsonSerializer.Deserialize<mflLeague.MflLeagueRoot>(sampleJson, _jsonOptions);

        Assert.False(root == null, "Deserialized root object should not be null.");
        Assert.True("UnitTest" == root.League.Name, "League name should be 'UnitTest'.");
        Assert.True("10" == root.League.Franchises.Count, "There should be 10 franchises.");
        Assert.True(10 == root.League.Franchises.FranchiseList.Count, "Franchise list should contain 10 items.");
    }

}
