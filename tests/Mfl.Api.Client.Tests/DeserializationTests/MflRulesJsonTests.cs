using System.Text.Json;
using Mfl.Api.Model.Rules;
using Xunit;

namespace Mfl.Api.Client.Tests.DeserializationTests
{
    public class MflRulesJsonTests
    {
        private readonly JsonSerializerOptions _jsonOptions = new()
        {
            PropertyNameCaseInsensitive = true
        };

        private readonly string _sampleJson = @"
{
  ""version"": ""1.0"",
  ""encoding"": ""utf-8"",
  ""rules"": {
    ""positionRules"": [
      {
        ""positions"": ""QB""
      },
      {
        ""rule"": [
          {
            ""event"": { ""$t"": ""#P"" },
            ""range"": { ""$t"": ""1-99"" },
            ""points"": { ""$t"": ""*3"" }
          },
          {
            ""range"": { ""$t"": ""-999-199"" },
            ""points"": { ""$t"": ""0"" },
            ""event"": { ""$t"": ""PY"" }
          },
          {
            ""points"": { ""$t"": ""7"" },
            ""range"": { ""$t"": ""200-299"" },
            ""event"": { ""$t"": ""PY"" }
          },
          {
            ""range"": { ""$t"": ""300-399"" },
            ""points"": { ""$t"": ""10"" },
            ""event"": { ""$t"": ""PY"" }
          },
          {
            ""range"": { ""$t"": ""400-499"" },
            ""points"": { ""$t"": ""14"" },
            ""event"": { ""$t"": ""PY"" }
          },
          {
            ""event"": { ""$t"": ""PY"" },
            ""range"": { ""$t"": ""500-599"" },
            ""points"": { ""$t"": ""17"" }
          },
          {
            ""range"": { ""$t"": ""600-699"" },
            ""points"": { ""$t"": ""21"" },
            ""event"": { ""$t"": ""PY"" }
          },
          {
            ""points"": { ""$t"": ""24"" },
            ""range"": { ""$t"": ""700-799"" },
            ""event"": { ""$t"": ""PY"" }
          },
          {
            ""event"": { ""$t"": ""PY"" },
            ""range"": { ""$t"": ""800-9999"" },
            ""points"": { ""$t"": ""28"" }
          },
          {
            ""event"": { ""$t"": ""P2"" },
            ""range"": { ""$t"": ""1-99"" },
            ""points"": { ""$t"": ""*1"" }
          },
          {
            ""event"": { ""$t"": ""#R"" },
            ""points"": { ""$t"": ""*6"" },
            ""range"": { ""$t"": ""1-99"" }
          },
          {
            ""points"": { ""$t"": ""0"" },
            ""range"": { ""$t"": ""-999-79"" },
            ""event"": { ""$t"": ""RY"" }
          },
          {
            ""event"": { ""$t"": ""RY"" },
            ""range"": { ""$t"": ""80-119"" },
            ""points"": { ""$t"": ""7"" }
          },
          {
            ""event"": { ""$t"": ""RY"" },
            ""range"": { ""$t"": ""120-159"" },
            ""points"": { ""$t"": ""10"" }
          },
          {
            ""event"": { ""$t"": ""RY"" },
            ""range"": { ""$t"": ""160-199"" },
            ""points"": { ""$t"": ""14"" }
          },
          {
            ""points"": { ""$t"": ""17"" },
            ""range"": { ""$t"": ""200-239"" },
            ""event"": { ""$t"": ""RY"" }
          },
          {
            ""event"": { ""$t"": ""RY"" },
            ""points"": { ""$t"": ""21"" },
            ""range"": { ""$t"": ""240-279"" }
          },
          {
            ""event"": { ""$t"": ""RY"" },
            ""range"": { ""$t"": ""280-319"" },
            ""points"": { ""$t"": ""24"" }
          },
          {
            ""range"": { ""$t"": ""320-359"" },
            ""points"": { ""$t"": ""28"" },
            ""event"": { ""$t"": ""RY"" }
          },
          {
            ""event"": { ""$t"": ""RY"" },
            ""range"": { ""$t"": ""360-399"" },
            ""points"": { ""$t"": ""31"" }
          },
          {
            ""event"": { ""$t"": ""RY"" },
            ""range"": { ""$t"": ""400-439"" },
            ""points"": { ""$t"": ""35"" }
          },
          {
            ""points"": { ""$t"": ""38"" },
            ""range"": { ""$t"": ""440-999"" },
            ""event"": { ""$t"": ""RY"" }
          },
          {
            ""range"": { ""$t"": ""1-99"" },
            ""points"": { ""$t"": ""*2"" },
            ""event"": { ""$t"": ""R2"" }
          },
          {
            ""event"": { ""$t"": ""#C"" },
            ""points"": { ""$t"": ""*6"" },
            ""range"": { ""$t"": ""1-99"" }
          },
          {
            ""range"": { ""$t"": ""-999-79"" },
            ""points"": { ""$t"": ""0"" },
            ""event"": { ""$t"": ""CY"" }
          },
          {
            ""event"": { ""$t"": ""CY"" },
            ""range"": { ""$t"": ""80-119"" },
            ""points"": { ""$t"": ""7"" }
          },
          {
            ""event"": { ""$t"": ""CY"" },
            ""range"": { ""$t"": ""120-159"" },
            ""points"": { ""$t"": ""10"" }
          },
          {
            ""points"": { ""$t"": ""14"" },
            ""range"": { ""$t"": ""160-199"" },
            ""event"": { ""$t"": ""CY"" }
          },
          {
            ""points"": { ""$t"": ""17"" },
            ""range"": { ""$t"": ""200-239"" },
            ""event"": { ""$t"": ""CY"" }
          },
          {
            ""event"": { ""$t"": ""CY"" },
            ""points"": { ""$t"": ""21"" },
            ""range"": { ""$t"": ""240-279"" }
          },
          {
            ""event"": { ""$t"": ""CY"" },
            ""points"": { ""$t"": ""24"" },
            ""range"": { ""$t"": ""280-319"" }
          },
          {
            ""event"": { ""$t"": ""CY"" },
            ""points"": { ""$t"": ""28"" },
            ""range"": { ""$t"": ""320-359"" }
          },
          {
            ""range"": { ""$t"": ""360-399"" },
            ""points"": { ""$t"": ""31"" },
            ""event"": { ""$t"": ""CY"" }
          },
          {
            ""event"": { ""$t"": ""CY"" },
            ""points"": { ""$t"": ""35"" },
            ""range"": { ""$t"": ""400-439"" }
          },
          {
            ""range"": { ""$t"": ""440-999"" },
            ""points"": { ""$t"": ""38"" },
            ""event"": { ""$t"": ""CY"" }
          },
          {
            ""range"": { ""$t"": ""1-99"" },
            ""points"": { ""$t"": ""*2"" },
            ""event"": { ""$t"": ""C2"" }
          },
          {
            ""range"": { ""$t"": ""1-44"" },
            ""points"": { ""$t"": ""3"" },
            ""event"": { ""$t"": ""FG"" }
          },
          {
            ""event"": { ""$t"": ""FG"" },
            ""range"": { ""$t"": ""45-110"" },
            ""points"": { ""$t"": ""7"" }
          },
          {
            ""points"": { ""$t"": ""*1"" },
            ""range"": { ""$t"": ""1-99"" },
            ""event"": { ""$t"": ""EP"" }
          },
          {
            ""event"": { ""$t"": ""#UT"" },
            ""points"": { ""$t"": ""*10"" },
            ""range"": { ""$t"": ""1-10"" }
          },
          {
            ""range"": { ""$t"": ""1-10"" },
            ""points"": { ""$t"": ""*10"" },
            ""event"": { ""$t"": ""#KT"" }
          },
          {
            ""event"": { ""$t"": ""#DR"" },
            ""range"": { ""$t"": ""1-10"" },
            ""points"": { ""$t"": ""*10"" }
          },
          {
            ""points"": { ""$t"": ""*10"" },
            ""range"": { ""$t"": ""1-99"" },
            ""event"": { ""$t"": ""#FR"" }
          },
          {
            ""points"": { ""$t"": ""*2"" },
            ""range"": { ""$t"": ""1-99"" },
            ""event"": { ""$t"": ""SF"" }
          }
        ],
        ""positions"": ""QB|RB|WR|TE|PK""
      }
    ]
  }
}
";

        [Fact]
        public void DeserializeStaticRulesData()
        {
            var root = JsonSerializer.Deserialize<LeagueRulesRoot>(_sampleJson, _jsonOptions);

            Assert.NotNull(root);
            Assert.NotNull(root.Rules);
            Assert.NotNull(root.Rules.PositionRuleGroups);
            Assert.Equal(2, root.Rules.PositionRuleGroups.Count);

            // Empty QB group
            Assert.Equal("QB", root.Rules.PositionRuleGroups[0].Positions);
            Assert.Empty(root.Rules.PositionRuleGroups[0].Rules);

            // Shared bonus group
            Assert.Equal("QB|RB|WR|TE|PK", root.Rules.PositionRuleGroups[1].Positions);
            Assert.Equal(44, root.Rules.PositionRuleGroups[1].Rules.Count);

            // First rule: passing attempts bonus
            var firstRule = root.Rules.PositionRuleGroups[1].Rules[0];
            Assert.Equal("#P", firstRule.Event.Value);
            Assert.Equal("*3", firstRule.Points.Value);

            // FG short
            var fgShort = root.Rules.PositionRuleGroups[1].Rules[42];
            Assert.Equal("#FR", fgShort.Event.Value);
            Assert.Equal("1-99", fgShort.Range.Value);
            Assert.Equal("*10", fgShort.Points.Value);

            // FG long
            var fgLong = root.Rules.PositionRuleGroups[1].Rules[43];
            Assert.Equal("SF", fgLong.Event.Value);
            Assert.Equal("1-99", fgLong.Range.Value);
            Assert.Equal("*2", fgLong.Points.Value);
        }
    }
}