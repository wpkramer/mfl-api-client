
using System.Text.Json;
using theNfl = Mfl.Api.Model.NFL;

namespace Mfl.Api.Client.Tests.DeserializationTests;


public class NFLScheduleJsonTests
{
    private const string fullSeasonJson = @"{
  ""encoding"": ""utf-8"",
  ""fullNflSchedule"": {
    ""nflSchedule"": [
      {
        ""matchup"": [
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1757031600"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushDefenseRank"": ""24"",
                ""hasPossession"": ""0"",
                ""score"": ""20"",
                ""passOffenseRank"": ""17"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""10"",
                ""id"": ""DAL"",
                ""passDefenseRank"": ""7"",
                ""spread"": ""7.5""
              },
              {
                ""hasPossession"": ""0"",
                ""score"": ""24"",
                ""rushDefenseRank"": ""19"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""24"",
                ""rushOffenseRank"": ""5"",
                ""isHome"": ""1"",
                ""spread"": ""-7.5"",
                ""passDefenseRank"": ""14"",
                ""id"": ""PHI""
              }
            ]
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1757116800"",
            ""team"": [
              {
                ""passOffenseRank"": ""9"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""12"",
                ""score"": ""21"",
                ""hasPossession"": ""0"",
                ""id"": ""KCC"",
                ""passDefenseRank"": ""28"",
                ""spread"": ""-3"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""16""
              },
              {
                ""rushOffenseRank"": ""17"",
                ""isHome"": ""1"",
                ""spread"": ""3.0"",
                ""passDefenseRank"": ""22"",
                ""id"": ""LAC"",
                ""score"": ""27"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""13"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""3""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""team"": [
              {
                ""passDefenseRank"": ""23"",
                ""id"": ""MIA"",
                ""spread"": ""1.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""19"",
                ""passOffenseRank"": ""27"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""8"",
                ""rushDefenseRank"": ""23""
              },
              {
                ""score"": ""33"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""10"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""8"",
                ""rushOffenseRank"": ""6"",
                ""isHome"": ""1"",
                ""spread"": ""-1.5"",
                ""passDefenseRank"": ""4"",
                ""id"": ""IND""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1757264400""
          },
          {
            ""kickoff"": ""1757264400"",
            ""gameSecondsRemaining"": ""0"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""passDefenseRank"": ""25"",
                ""id"": ""LVR"",
                ""spread"": ""-2.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""25"",
                ""passOffenseRank"": ""2"",
                ""inRedZone"": ""0"",
                ""score"": ""20"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""5""
              },
              {
                ""hasPossession"": ""0"",
                ""score"": ""13"",
                ""rushDefenseRank"": ""4"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""6"",
                ""rushOffenseRank"": ""24"",
                ""isHome"": ""1"",
                ""spread"": ""2.5"",
                ""passDefenseRank"": ""29"",
                ""id"": ""NEP""
              }
            ]
          },
          {
            ""kickoff"": ""1757264400"",
            ""gameSecondsRemaining"": ""0"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushOffenseRank"": ""26"",
                ""isHome"": ""0"",
                ""spread"": ""-2.5"",
                ""id"": ""PIT"",
                ""passDefenseRank"": ""19"",
                ""rushDefenseRank"": ""25"",
                ""hasPossession"": ""0"",
                ""score"": ""34"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""11""
              },
              {
                ""passOffenseRank"": ""12"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""32"",
                ""rushDefenseRank"": ""3"",
                ""passDefenseRank"": ""20"",
                ""id"": ""NYJ"",
                ""spread"": ""2.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""4""
              }
            ]
          },
          {
            ""team"": [
              {
                ""spread"": ""-5.5"",
                ""passDefenseRank"": ""26"",
                ""id"": ""CIN"",
                ""rushOffenseRank"": ""28"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""29"",
                ""hasPossession"": ""0"",
                ""score"": ""17"",
                ""rushDefenseRank"": ""2""
              },
              {
                ""hasPossession"": ""0"",
                ""score"": ""16"",
                ""rushDefenseRank"": ""1"",
                ""passOffenseRank"": ""5"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""27"",
                ""passDefenseRank"": ""2"",
                ""id"": ""CLE"",
                ""spread"": ""5.5""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1757264400"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""kickoff"": ""1757264400"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""rushOffenseRank"": ""12"",
                ""isHome"": ""0"",
                ""spread"": ""3"",
                ""passDefenseRank"": ""13"",
                ""id"": ""CAR"",
                ""hasPossession"": ""0"",
                ""score"": ""10"",
                ""rushDefenseRank"": ""26"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""25""
              },
              {
                ""id"": ""JAC"",
                ""passDefenseRank"": ""6"",
                ""spread"": ""-3.0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""3"",
                ""passOffenseRank"": ""18"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""17"",
                ""hasPossession"": ""0"",
                ""score"": ""26""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""kickoff"": ""1757264400"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""20"",
                ""passDefenseRank"": ""19"",
                ""id"": ""NYG"",
                ""spread"": ""6"",
                ""hasPossession"": ""0"",
                ""score"": ""6"",
                ""rushDefenseRank"": ""27"",
                ""passOffenseRank"": ""21"",
                ""inRedZone"": ""0""
              },
              {
                ""passDefenseRank"": ""10"",
                ""id"": ""WAS"",
                ""spread"": ""-6.0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""2"",
                ""passOffenseRank"": ""12"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""21"",
                ""rushDefenseRank"": ""9""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""team"": [
              {
                ""spread"": ""-2.5"",
                ""passDefenseRank"": ""27"",
                ""id"": ""TBB"",
                ""rushOffenseRank"": ""15"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""20"",
                ""hasPossession"": ""0"",
                ""score"": ""23"",
                ""rushDefenseRank"": ""6""
              },
              {
                ""spread"": ""2.5"",
                ""id"": ""ATL"",
                ""passDefenseRank"": ""11"",
                ""rushOffenseRank"": ""23"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""4"",
                ""rushDefenseRank"": ""14"",
                ""score"": ""20"",
                ""hasPossession"": ""0""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1757264400"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""team"": [
              {
                ""passOffenseRank"": ""28"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""15"",
                ""hasPossession"": ""0"",
                ""score"": ""20"",
                ""id"": ""ARI"",
                ""passDefenseRank"": ""18"",
                ""spread"": ""-6.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""8""
              },
              {
                ""passOffenseRank"": ""13"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""21"",
                ""hasPossession"": ""0"",
                ""score"": ""13"",
                ""id"": ""NOS"",
                ""passDefenseRank"": ""3"",
                ""spread"": ""6.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""14""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1757264400"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""team"": [
              {
                ""spread"": ""8.5"",
                ""passDefenseRank"": ""12"",
                ""id"": ""TEN"",
                ""rushOffenseRank"": ""22"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""30"",
                ""hasPossession"": ""0"",
                ""score"": ""12"",
                ""rushDefenseRank"": ""22""
              },
              {
                ""spread"": ""-8.5"",
                ""id"": ""DEN"",
                ""passDefenseRank"": ""1"",
                ""rushOffenseRank"": ""7"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""19"",
                ""rushDefenseRank"": ""7"",
                ""score"": ""20"",
                ""hasPossession"": ""0""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1757275500""
          },
          {
            ""kickoff"": ""1757275500"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""id"": ""SFO"",
                ""passDefenseRank"": ""8"",
                ""spread"": ""-2.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""10"",
                ""passOffenseRank"": ""7"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""11"",
                ""hasPossession"": ""0"",
                ""score"": ""17""
              },
              {
                ""passOffenseRank"": ""23"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""13"",
                ""rushDefenseRank"": ""19"",
                ""passDefenseRank"": ""24"",
                ""id"": ""SEA"",
                ""spread"": ""2.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""18""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""team"": [
              {
                ""hasPossession"": ""0"",
                ""score"": ""13"",
                ""rushDefenseRank"": ""10"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""14"",
                ""rushOffenseRank"": ""28"",
                ""isHome"": ""0"",
                ""spread"": ""2.5"",
                ""passDefenseRank"": ""14"",
                ""id"": ""DET""
              },
              {
                ""passDefenseRank"": ""17"",
                ""id"": ""GBP"",
                ""spread"": ""-2.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""19"",
                ""passOffenseRank"": ""17"",
                ""inRedZone"": ""0"",
                ""score"": ""27"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""1""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1757276700"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""kickoff"": ""1757276700"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""score"": ""9"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""8"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""22"",
                ""rushOffenseRank"": ""11"",
                ""isHome"": ""0"",
                ""spread"": ""2.5"",
                ""passDefenseRank"": ""21"",
                ""id"": ""HOU""
              },
              {
                ""rushOffenseRank"": ""21"",
                ""isHome"": ""1"",
                ""spread"": ""-2.5"",
                ""id"": ""LAR"",
                ""passDefenseRank"": ""9"",
                ""rushDefenseRank"": ""18"",
                ""hasPossession"": ""0"",
                ""score"": ""14"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""10""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""passOffenseRank"": ""16"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""16"",
                ""hasPossession"": ""0"",
                ""score"": ""40"",
                ""id"": ""BAL"",
                ""passDefenseRank"": ""30"",
                ""spread"": ""0.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""1""
              },
              {
                ""rushOffenseRank"": ""13"",
                ""isHome"": ""1"",
                ""spread"": ""-0.5"",
                ""passDefenseRank"": ""15"",
                ""id"": ""BUF"",
                ""hasPossession"": ""0"",
                ""score"": ""41"",
                ""rushDefenseRank"": ""28"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""1""
              }
            ],
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1757290800""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1757376900"",
            ""team"": [
              {
                ""passOffenseRank"": ""26"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""27"",
                ""rushDefenseRank"": ""19"",
                ""passDefenseRank"": ""16"",
                ""id"": ""MIN"",
                ""spread"": ""-1.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""9""
              },
              {
                ""score"": ""24"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""20"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""15"",
                ""rushOffenseRank"": ""10"",
                ""isHome"": ""1"",
                ""spread"": ""1.5"",
                ""passDefenseRank"": ""5"",
                ""id"": ""CHI""
              }
            ],
            ""status"": ""FINAL""
          }
        ],
        ""lastUpdate"": ""1766140832"",
        ""week"": ""1""
      },
      {
        ""matchup"": [
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushDefenseRank"": ""21"",
                ""score"": ""18"",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""23"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""25"",
                ""id"": ""WAS"",
                ""passDefenseRank"": ""21"",
                ""spread"": ""3.5""
              },
              {
                ""rushDefenseRank"": ""4"",
                ""hasPossession"": ""0"",
                ""score"": ""27"",
                ""passOffenseRank"": ""10"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""8"",
                ""id"": ""GBP"",
                ""passDefenseRank"": ""8"",
                ""spread"": ""-3.5""
              }
            ],
            ""kickoff"": ""1757636100"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""team"": [
              {
                ""id"": ""NEP"",
                ""passDefenseRank"": ""24"",
                ""spread"": ""1.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""10"",
                ""passOffenseRank"": ""14"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""5"",
                ""score"": ""33"",
                ""hasPossession"": ""0""
              },
              {
                ""score"": ""27"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""19"",
                ""passOffenseRank"": ""7"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""24"",
                ""passDefenseRank"": ""17"",
                ""id"": ""MIA"",
                ""spread"": ""-1.5""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1757869200""
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""passDefenseRank"": ""1"",
                ""id"": ""BUF"",
                ""spread"": ""-7"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""1"",
                ""passOffenseRank"": ""23"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""30"",
                ""rushDefenseRank"": ""13""
              },
              {
                ""hasPossession"": ""0"",
                ""score"": ""10"",
                ""rushDefenseRank"": ""28"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""30"",
                ""rushOffenseRank"": ""16"",
                ""isHome"": ""1"",
                ""spread"": ""7.0"",
                ""passDefenseRank"": ""8"",
                ""id"": ""NYJ""
              }
            ],
            ""kickoff"": ""1757869200"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""team"": [
              {
                ""rushOffenseRank"": ""7"",
                ""isHome"": ""0"",
                ""spread"": ""3.5"",
                ""passDefenseRank"": ""25"",
                ""id"": ""JAC"",
                ""score"": ""27"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""2"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""12""
              },
              {
                ""score"": ""31"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""22"",
                ""passOffenseRank"": ""6"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""27"",
                ""passDefenseRank"": ""19"",
                ""id"": ""CIN"",
                ""spread"": ""-3.5""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1757869200"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""kickoff"": ""1757869200"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""rushOffenseRank"": ""6"",
                ""isHome"": ""0"",
                ""spread"": ""-5.5"",
                ""id"": ""LAR"",
                ""passDefenseRank"": ""5"",
                ""rushDefenseRank"": ""14"",
                ""score"": ""33"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""8""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""26"",
                ""score"": ""19"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""23"",
                ""spread"": ""5.5"",
                ""passDefenseRank"": ""23"",
                ""id"": ""TEN"",
                ""rushOffenseRank"": ""15"",
                ""isHome"": ""1""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""kickoff"": ""1757869200"",
            ""gameSecondsRemaining"": ""0"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""spread"": ""3"",
                ""id"": ""SEA"",
                ""passDefenseRank"": ""12"",
                ""rushOffenseRank"": ""13"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""9"",
                ""rushDefenseRank"": ""7"",
                ""hasPossession"": ""0"",
                ""score"": ""31""
              },
              {
                ""spread"": ""-3.0"",
                ""passDefenseRank"": ""22"",
                ""id"": ""PIT"",
                ""rushOffenseRank"": ""22"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""19"",
                ""hasPossession"": ""0"",
                ""score"": ""17"",
                ""rushDefenseRank"": ""16""
              }
            ]
          },
          {
            ""kickoff"": ""1757869200"",
            ""gameSecondsRemaining"": ""0"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""passOffenseRank"": ""1"",
                ""inRedZone"": ""0"",
                ""score"": ""37"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""21"",
                ""passDefenseRank"": ""29"",
                ""id"": ""NYG"",
                ""spread"": ""6"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""17""
              },
              {
                ""spread"": ""-6.0"",
                ""id"": ""DAL"",
                ""passDefenseRank"": ""30"",
                ""rushOffenseRank"": ""8"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""2"",
                ""rushDefenseRank"": ""12"",
                ""score"": ""40"",
                ""hasPossession"": ""0""
              }
            ]
          },
          {
            ""kickoff"": ""1757869200"",
            ""gameSecondsRemaining"": ""0"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""spread"": ""4.5"",
                ""passDefenseRank"": ""28"",
                ""id"": ""CHI"",
                ""rushOffenseRank"": ""9"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""17"",
                ""score"": ""21"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""26""
              },
              {
                ""spread"": ""-4.5"",
                ""id"": ""DET"",
                ""passDefenseRank"": ""14"",
                ""rushOffenseRank"": ""3"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""3"",
                ""rushDefenseRank"": ""20"",
                ""hasPossession"": ""0"",
                ""score"": ""52""
              }
            ]
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""id"": ""SFO"",
                ""passDefenseRank"": ""10"",
                ""spread"": ""-4.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""21"",
                ""passOffenseRank"": ""11"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""18"",
                ""score"": ""26"",
                ""hasPossession"": ""0""
              },
              {
                ""score"": ""21"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""8"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""21"",
                ""rushOffenseRank"": ""11"",
                ""isHome"": ""1"",
                ""spread"": ""4.5"",
                ""passDefenseRank"": ""20"",
                ""id"": ""NOS""
              }
            ],
            ""kickoff"": ""1757869200"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""team"": [
              {
                ""rushDefenseRank"": ""1"",
                ""score"": ""17"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""15"",
                ""rushOffenseRank"": ""14"",
                ""isHome"": ""0"",
                ""spread"": ""10.5"",
                ""id"": ""CLE"",
                ""passDefenseRank"": ""13""
              },
              {
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""28"",
                ""passDefenseRank"": ""16"",
                ""id"": ""BAL"",
                ""spread"": ""-10.5"",
                ""hasPossession"": ""0"",
                ""score"": ""41"",
                ""rushDefenseRank"": ""15"",
                ""passOffenseRank"": ""18"",
                ""inRedZone"": ""0""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1757869200"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""team"": [
              {
                ""spread"": ""-2.5"",
                ""id"": ""DEN"",
                ""passDefenseRank"": ""27"",
                ""rushOffenseRank"": ""12"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""16"",
                ""rushDefenseRank"": ""24"",
                ""score"": ""28"",
                ""hasPossession"": ""0""
              },
              {
                ""hasPossession"": ""0"",
                ""score"": ""29"",
                ""rushDefenseRank"": ""17"",
                ""passOffenseRank"": ""4"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""5"",
                ""passDefenseRank"": ""15"",
                ""id"": ""IND"",
                ""spread"": ""2.5""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1757880300"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""kickoff"": ""1757880300"",
            ""gameSecondsRemaining"": ""0"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""hasPossession"": ""0"",
                ""score"": ""22"",
                ""rushDefenseRank"": ""11"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""5"",
                ""rushOffenseRank"": ""26"",
                ""isHome"": ""0"",
                ""spread"": ""6.5"",
                ""passDefenseRank"": ""17"",
                ""id"": ""CAR""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""14"",
                ""score"": ""27"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""3"",
                ""spread"": ""-6.5"",
                ""passDefenseRank"": ""26"",
                ""id"": ""ARI"",
                ""rushOffenseRank"": ""18"",
                ""isHome"": ""1""
              }
            ]
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushOffenseRank"": ""10"",
                ""isHome"": ""0"",
                ""spread"": ""-1.5"",
                ""id"": ""PHI"",
                ""passDefenseRank"": ""7"",
                ""rushDefenseRank"": ""18"",
                ""score"": ""20"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""29""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""24"",
                ""hasPossession"": ""0"",
                ""score"": ""17"",
                ""rushDefenseRank"": ""19"",
                ""spread"": ""1.5"",
                ""passDefenseRank"": ""2"",
                ""id"": ""KCC"",
                ""rushOffenseRank"": ""11"",
                ""isHome"": ""1""
              }
            ],
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1757881500""
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushOffenseRank"": ""2"",
                ""isHome"": ""0"",
                ""spread"": ""5.5"",
                ""passDefenseRank"": ""4"",
                ""id"": ""ATL"",
                ""hasPossession"": ""0"",
                ""score"": ""22"",
                ""rushDefenseRank"": ""9"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""28""
              },
              {
                ""score"": ""6"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""27"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""27"",
                ""rushOffenseRank"": ""20"",
                ""isHome"": ""1"",
                ""spread"": ""-5.5"",
                ""passDefenseRank"": ""3"",
                ""id"": ""MIN""
              }
            ],
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1757895600""
          },
          {
            ""kickoff"": ""1757977200"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""passOffenseRank"": ""20"",
                ""inRedZone"": ""0"",
                ""score"": ""20"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""12"",
                ""passDefenseRank"": ""9"",
                ""id"": ""TBB"",
                ""spread"": ""3"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""4""
              },
              {
                ""passOffenseRank"": ""22"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""25"",
                ""score"": ""19"",
                ""hasPossession"": ""0"",
                ""id"": ""HOU"",
                ""passDefenseRank"": ""11"",
                ""spread"": ""-3.0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""17""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""spread"": ""-3.5"",
                ""passDefenseRank"": ""6"",
                ""id"": ""LAC"",
                ""rushOffenseRank"": ""19"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""13"",
                ""hasPossession"": ""0"",
                ""score"": ""20"",
                ""rushDefenseRank"": ""6""
              },
              {
                ""passDefenseRank"": ""18"",
                ""id"": ""LVR"",
                ""spread"": ""3.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""23"",
                ""passOffenseRank"": ""25"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""9"",
                ""rushDefenseRank"": ""10""
              }
            ],
            ""kickoff"": ""1757988000"",
            ""gameSecondsRemaining"": ""0""
          }
        ],
        ""week"": ""2"",
        ""lastUpdate"": ""1766140832""
      },
      {
        ""matchup"": [
          {
            ""team"": [
              {
                ""rushDefenseRank"": ""25"",
                ""score"": ""21"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""12"",
                ""rushOffenseRank"": ""23"",
                ""isHome"": ""0"",
                ""spread"": ""12.5"",
                ""id"": ""MIA"",
                ""passDefenseRank"": ""18""
              },
              {
                ""hasPossession"": ""0"",
                ""score"": ""31"",
                ""rushDefenseRank"": ""18"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""20"",
                ""rushOffenseRank"": ""2"",
                ""isHome"": ""1"",
                ""spread"": ""-12.5"",
                ""passDefenseRank"": ""1"",
                ""id"": ""BUF""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1758240900""
          },
          {
            ""kickoff"": ""1758474000"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""passOffenseRank"": ""27"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""21"",
                ""rushDefenseRank"": ""19"",
                ""passDefenseRank"": ""26"",
                ""id"": ""PIT"",
                ""spread"": ""-1.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""30""
              },
              {
                ""passOffenseRank"": ""11"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""14"",
                ""rushDefenseRank"": ""2"",
                ""passDefenseRank"": ""20"",
                ""id"": ""NEP"",
                ""spread"": ""1.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""10""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""15"",
                ""rushDefenseRank"": ""5"",
                ""hasPossession"": ""0"",
                ""score"": ""10"",
                ""spread"": ""-8.5"",
                ""id"": ""GBP"",
                ""passDefenseRank"": ""6"",
                ""rushOffenseRank"": ""15"",
                ""isHome"": ""0""
              },
              {
                ""passOffenseRank"": ""28"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""3"",
                ""hasPossession"": ""0"",
                ""score"": ""13"",
                ""id"": ""CLE"",
                ""passDefenseRank"": ""9"",
                ""spread"": ""8.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""17""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1758474000"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1758474000"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""spread"": ""-3.5"",
                ""id"": ""IND"",
                ""passDefenseRank"": ""14"",
                ""rushOffenseRank"": ""5"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""5"",
                ""rushDefenseRank"": ""13"",
                ""score"": ""41"",
                ""hasPossession"": ""0""
              },
              {
                ""score"": ""20"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""28"",
                ""passOffenseRank"": ""26"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""22"",
                ""passDefenseRank"": ""25"",
                ""id"": ""TEN"",
                ""spread"": ""3.5""
              }
            ]
          },
          {
            ""team"": [
              {
                ""rushDefenseRank"": ""22"",
                ""hasPossession"": ""0"",
                ""score"": ""10"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""23"",
                ""rushOffenseRank"": ""26"",
                ""isHome"": ""0"",
                ""spread"": ""1.5"",
                ""id"": ""HOU"",
                ""passDefenseRank"": ""12""
              },
              {
                ""spread"": ""-1.5"",
                ""id"": ""JAC"",
                ""passDefenseRank"": ""23"",
                ""rushOffenseRank"": ""13"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""10"",
                ""rushDefenseRank"": ""4"",
                ""score"": ""17"",
                ""hasPossession"": ""0""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1758474000"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1758474000"",
            ""team"": [
              {
                ""spread"": ""3"",
                ""passDefenseRank"": ""8"",
                ""id"": ""LAR"",
                ""rushOffenseRank"": ""4"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""9"",
                ""score"": ""26"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""12""
              },
              {
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""18"",
                ""id"": ""PHI"",
                ""passDefenseRank"": ""11"",
                ""spread"": ""-3.0"",
                ""rushDefenseRank"": ""26"",
                ""hasPossession"": ""0"",
                ""score"": ""33"",
                ""passOffenseRank"": ""31"",
                ""inRedZone"": ""0""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""kickoff"": ""1758474000"",
            ""gameSecondsRemaining"": ""0"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushOffenseRank"": ""27"",
                ""isHome"": ""0"",
                ""spread"": ""3.5"",
                ""passDefenseRank"": ""19"",
                ""id"": ""LVR"",
                ""score"": ""24"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""27"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""18""
              },
              {
                ""id"": ""WAS"",
                ""passDefenseRank"": ""27"",
                ""spread"": ""-3.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""8"",
                ""passOffenseRank"": ""21"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""17"",
                ""hasPossession"": ""0"",
                ""score"": ""41""
              }
            ]
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1758474000"",
            ""team"": [
              {
                ""passOffenseRank"": ""14"",
                ""inRedZone"": ""0"",
                ""score"": ""10"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""30"",
                ""passDefenseRank"": ""22"",
                ""id"": ""CIN"",
                ""spread"": ""3"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""32""
              },
              {
                ""id"": ""MIN"",
                ""passDefenseRank"": ""2"",
                ""spread"": ""-3.0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""9"",
                ""passOffenseRank"": ""30"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""23"",
                ""score"": ""48"",
                ""hasPossession"": ""0""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1758474000"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""21"",
                ""passDefenseRank"": ""15"",
                ""id"": ""NYJ"",
                ""spread"": ""7"",
                ""hasPossession"": ""0"",
                ""score"": ""27"",
                ""rushDefenseRank"": ""32"",
                ""passOffenseRank"": ""32"",
                ""inRedZone"": ""0""
              },
              {
                ""passOffenseRank"": ""17"",
                ""inRedZone"": ""0"",
                ""score"": ""29"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""9"",
                ""passDefenseRank"": ""10"",
                ""id"": ""TBB"",
                ""spread"": ""-7.0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""6""
              }
            ]
          },
          {
            ""kickoff"": ""1758474000"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""hasPossession"": ""0"",
                ""score"": ""0"",
                ""rushDefenseRank"": ""11"",
                ""passOffenseRank"": ""29"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""3"",
                ""passDefenseRank"": ""3"",
                ""id"": ""ATL"",
                ""spread"": ""-5.5""
              },
              {
                ""rushDefenseRank"": ""14"",
                ""score"": ""30"",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""16"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""28"",
                ""id"": ""CAR"",
                ""passDefenseRank"": ""17"",
                ""spread"": ""5.5""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""team"": [
              {
                ""passDefenseRank"": ""29"",
                ""id"": ""DEN"",
                ""spread"": ""2.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""11"",
                ""passOffenseRank"": ""25"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""20"",
                ""rushDefenseRank"": ""24""
              },
              {
                ""passOffenseRank"": ""7"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""10"",
                ""score"": ""23"",
                ""hasPossession"": ""0"",
                ""id"": ""LAC"",
                ""passDefenseRank"": ""5"",
                ""spread"": ""-2.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""25""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1758485100"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""team"": [
              {
                ""passOffenseRank"": ""19"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""13"",
                ""rushDefenseRank"": ""7"",
                ""passDefenseRank"": ""24"",
                ""id"": ""NOS"",
                ""spread"": ""7.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""20""
              },
              {
                ""score"": ""44"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""6"",
                ""passOffenseRank"": ""6"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""19"",
                ""passDefenseRank"": ""13"",
                ""id"": ""SEA"",
                ""spread"": ""-7.5""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1758485100"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""kickoff"": ""1758486300"",
            ""gameSecondsRemaining"": ""0"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""passOffenseRank"": ""1"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""8"",
                ""score"": ""14"",
                ""hasPossession"": ""0"",
                ""id"": ""DAL"",
                ""passDefenseRank"": ""32"",
                ""spread"": ""1.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""7""
              },
              {
                ""passOffenseRank"": ""8"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""31"",
                ""rushDefenseRank"": ""29"",
                ""passDefenseRank"": ""31"",
                ""id"": ""CHI"",
                ""spread"": ""-1.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""14""
              }
            ]
          },
          {
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""24"",
                ""rushDefenseRank"": ""1"",
                ""score"": ""15"",
                ""hasPossession"": ""0"",
                ""spread"": ""1.5"",
                ""id"": ""ARI"",
                ""passDefenseRank"": ""30"",
                ""rushOffenseRank"": ""24"",
                ""isHome"": ""0""
              },
              {
                ""hasPossession"": ""0"",
                ""score"": ""16"",
                ""rushDefenseRank"": ""16"",
                ""passOffenseRank"": ""3"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""29"",
                ""passDefenseRank"": ""7"",
                ""id"": ""SFO"",
                ""spread"": ""-1.5""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1758486300"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""team"": [
              {
                ""passOffenseRank"": ""22"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""22"",
                ""rushDefenseRank"": ""21"",
                ""passDefenseRank"": ""4"",
                ""id"": ""KCC"",
                ""spread"": ""-6"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""12""
              },
              {
                ""hasPossession"": ""0"",
                ""score"": ""9"",
                ""rushDefenseRank"": ""20"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""2"",
                ""rushOffenseRank"": ""16"",
                ""isHome"": ""1"",
                ""spread"": ""6.0"",
                ""passDefenseRank"": ""28"",
                ""id"": ""NYG""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1758500400""
          },
          {
            ""team"": [
              {
                ""rushDefenseRank"": ""15"",
                ""score"": ""38"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""4"",
                ""rushOffenseRank"": ""1"",
                ""isHome"": ""0"",
                ""spread"": ""5.5"",
                ""id"": ""DET"",
                ""passDefenseRank"": ""21""
              },
              {
                ""rushOffenseRank"": ""31"",
                ""isHome"": ""1"",
                ""spread"": ""-5.5"",
                ""id"": ""BAL"",
                ""passDefenseRank"": ""16"",
                ""rushDefenseRank"": ""31"",
                ""hasPossession"": ""0"",
                ""score"": ""30"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""13""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1758586500"",
            ""gameSecondsRemaining"": ""0""
          }
        ],
        ""lastUpdate"": ""1766140832"",
        ""week"": ""3""
      },
      {
        ""matchup"": [
          {
            ""kickoff"": ""1758845700"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""15"",
                ""passDefenseRank"": ""9"",
                ""id"": ""SEA"",
                ""spread"": ""1.5"",
                ""hasPossession"": ""0"",
                ""score"": ""23"",
                ""rushDefenseRank"": ""3"",
                ""passOffenseRank"": ""6"",
                ""inRedZone"": ""0""
              },
              {
                ""passOffenseRank"": ""23"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""20"",
                ""rushDefenseRank"": ""7"",
                ""passDefenseRank"": ""28"",
                ""id"": ""ARI"",
                ""spread"": ""-1.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""25""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1759066200"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""20"",
                ""rushDefenseRank"": ""22"",
                ""score"": ""21"",
                ""hasPossession"": ""0"",
                ""spread"": ""-2.5"",
                ""id"": ""MIN"",
                ""passDefenseRank"": ""4"",
                ""rushOffenseRank"": ""19"",
                ""isHome"": ""0""
              },
              {
                ""passDefenseRank"": ""29"",
                ""id"": ""PIT"",
                ""spread"": ""2.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""26"",
                ""passOffenseRank"": ""27"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""24"",
                ""rushDefenseRank"": ""10""
              }
            ]
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1759078800"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""passDefenseRank"": ""21"",
                ""id"": ""NOS"",
                ""spread"": ""16.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""10"",
                ""passOffenseRank"": ""29"",
                ""inRedZone"": ""0"",
                ""score"": ""19"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""13""
              },
              {
                ""rushOffenseRank"": ""1"",
                ""isHome"": ""1"",
                ""spread"": ""-16.5"",
                ""id"": ""BUF"",
                ""passDefenseRank"": ""1"",
                ""rushDefenseRank"": ""25"",
                ""hasPossession"": ""0"",
                ""score"": ""31"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""22""
              }
            ]
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""passDefenseRank"": ""13"",
                ""id"": ""CAR"",
                ""spread"": ""5.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""24"",
                ""passOffenseRank"": ""19"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""13"",
                ""rushDefenseRank"": ""11""
              },
              {
                ""spread"": ""-5.5"",
                ""id"": ""NEP"",
                ""passDefenseRank"": ""16"",
                ""rushOffenseRank"": ""16"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""12"",
                ""rushDefenseRank"": ""4"",
                ""hasPossession"": ""0"",
                ""score"": ""42""
              }
            ],
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1759078800""
          },
          {
            ""team"": [
              {
                ""rushOffenseRank"": ""18"",
                ""isHome"": ""0"",
                ""spread"": ""-6"",
                ""id"": ""LAC"",
                ""passDefenseRank"": ""3"",
                ""rushDefenseRank"": ""16"",
                ""hasPossession"": ""0"",
                ""score"": ""18"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""9""
              },
              {
                ""rushDefenseRank"": ""21"",
                ""score"": ""21"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""13"",
                ""rushOffenseRank"": ""13"",
                ""isHome"": ""1"",
                ""spread"": ""6.0"",
                ""id"": ""NYG"",
                ""passDefenseRank"": ""23""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1759078800"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushDefenseRank"": ""2"",
                ""score"": ""10"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""28"",
                ""rushOffenseRank"": ""23"",
                ""isHome"": ""0"",
                ""spread"": ""8.5"",
                ""id"": ""CLE"",
                ""passDefenseRank"": ""8""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""8"",
                ""score"": ""34"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""9"",
                ""spread"": ""-8.5"",
                ""passDefenseRank"": ""12"",
                ""id"": ""DET"",
                ""rushOffenseRank"": ""2"",
                ""isHome"": ""1""
              }
            ],
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1759078800""
          },
          {
            ""team"": [
              {
                ""hasPossession"": ""0"",
                ""score"": ""31"",
                ""rushDefenseRank"": ""20"",
                ""passOffenseRank"": ""32"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""22"",
                ""passDefenseRank"": ""18"",
                ""id"": ""PHI"",
                ""spread"": ""-3""
              },
              {
                ""passDefenseRank"": ""6"",
                ""id"": ""TBB"",
                ""spread"": ""3.0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""9"",
                ""passOffenseRank"": ""10"",
                ""inRedZone"": ""0"",
                ""score"": ""25"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""6""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1759078800""
          },
          {
            ""kickoff"": ""1759078800"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""spread"": ""-2.5"",
                ""passDefenseRank"": ""30"",
                ""id"": ""WAS"",
                ""rushOffenseRank"": ""7"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""26"",
                ""score"": ""27"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""18""
              },
              {
                ""hasPossession"": ""0"",
                ""score"": ""34"",
                ""rushDefenseRank"": ""14"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""18"",
                ""rushOffenseRank"": ""3"",
                ""isHome"": ""1"",
                ""spread"": ""2.5"",
                ""passDefenseRank"": ""2"",
                ""id"": ""ATL""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1759078800"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""passDefenseRank"": ""24"",
                ""id"": ""TEN"",
                ""spread"": ""7"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""25"",
                ""passOffenseRank"": ""30"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""0"",
                ""rushDefenseRank"": ""23""
              },
              {
                ""spread"": ""-7.0"",
                ""id"": ""HOU"",
                ""passDefenseRank"": ""7"",
                ""rushOffenseRank"": ""21"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""21"",
                ""rushDefenseRank"": ""15"",
                ""score"": ""26"",
                ""hasPossession"": ""0""
              }
            ]
          },
          {
            ""kickoff"": ""1759089900"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""score"": ""20"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""10"",
                ""passOffenseRank"": ""4"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""10"",
                ""passDefenseRank"": ""25"",
                ""id"": ""IND"",
                ""spread"": ""3.5""
              },
              {
                ""passDefenseRank"": ""11"",
                ""id"": ""LAR"",
                ""spread"": ""-3.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""5"",
                ""passOffenseRank"": ""3"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""27"",
                ""rushDefenseRank"": ""8""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""kickoff"": ""1759089900"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""rushOffenseRank"": ""12"",
                ""isHome"": ""0"",
                ""spread"": ""3"",
                ""passDefenseRank"": ""27"",
                ""id"": ""JAC"",
                ""hasPossession"": ""0"",
                ""score"": ""26"",
                ""rushDefenseRank"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""14""
              },
              {
                ""spread"": ""-3.0"",
                ""passDefenseRank"": ""8"",
                ""id"": ""SFO"",
                ""rushOffenseRank"": ""27"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""2"",
                ""hasPossession"": ""0"",
                ""score"": ""21"",
                ""rushDefenseRank"": ""19""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""16"",
                ""score"": ""20"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""26"",
                ""spread"": ""-2.5"",
                ""passDefenseRank"": ""19"",
                ""id"": ""BAL"",
                ""rushOffenseRank"": ""22"",
                ""isHome"": ""0""
              },
              {
                ""spread"": ""2.5"",
                ""passDefenseRank"": ""5"",
                ""id"": ""KCC"",
                ""rushOffenseRank"": ""17"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""15"",
                ""hasPossession"": ""0"",
                ""score"": ""37"",
                ""rushDefenseRank"": ""24""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1759091100""
          },
          {
            ""team"": [
              {
                ""id"": ""CHI"",
                ""passDefenseRank"": ""22"",
                ""spread"": ""-1.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""23"",
                ""passOffenseRank"": ""7"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""30"",
                ""score"": ""25"",
                ""hasPossession"": ""0""
              },
              {
                ""score"": ""24"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""17"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""24"",
                ""rushOffenseRank"": ""6"",
                ""isHome"": ""1"",
                ""spread"": ""1.5"",
                ""passDefenseRank"": ""17"",
                ""id"": ""LVR""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1759091100"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""kickoff"": ""1759105200"",
            ""gameSecondsRemaining"": ""0"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""11"",
                ""id"": ""GBP"",
                ""passDefenseRank"": ""15"",
                ""spread"": ""-7"",
                ""rushDefenseRank"": ""5"",
                ""hasPossession"": ""0"",
                ""score"": ""40"",
                ""passOffenseRank"": ""5"",
                ""inRedZone"": ""0""
              },
              {
                ""score"": ""40"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""14"",
                ""passOffenseRank"": ""1"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""14"",
                ""passDefenseRank"": ""31"",
                ""id"": ""DAL"",
                ""spread"": ""7.0""
              }
            ]
          },
          {
            ""team"": [
              {
                ""rushOffenseRank"": ""8"",
                ""isHome"": ""0"",
                ""spread"": ""2.5"",
                ""id"": ""NYJ"",
                ""passDefenseRank"": ""10"",
                ""rushDefenseRank"": ""27"",
                ""score"": ""21"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""31""
              },
              {
                ""score"": ""27"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""28"",
                ""passOffenseRank"": ""17"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""20"",
                ""passDefenseRank"": ""14"",
                ""id"": ""MIA"",
                ""spread"": ""-2.5""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1759187700"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""kickoff"": ""1759191300"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""spread"": ""7"",
                ""passDefenseRank"": ""26"",
                ""id"": ""CIN"",
                ""rushOffenseRank"": ""28"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""25"",
                ""score"": ""3"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""29""
              },
              {
                ""passOffenseRank"": ""11"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""12"",
                ""score"": ""28"",
                ""hasPossession"": ""0"",
                ""id"": ""DEN"",
                ""passDefenseRank"": ""20"",
                ""spread"": ""-7.0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""4""
              }
            ],
            ""status"": ""FINAL""
          }
        ],
        ""week"": ""4"",
        ""lastUpdate"": ""1766140832""
      },
      {
        ""lastUpdate"": ""1766140832"",
        ""week"": ""5"",
        ""matchup"": [
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushDefenseRank"": ""17"",
                ""hasPossession"": ""0"",
                ""score"": ""26"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""2"",
                ""rushOffenseRank"": ""30"",
                ""isHome"": ""0"",
                ""spread"": ""5.5"",
                ""id"": ""SFO"",
                ""passDefenseRank"": ""18""
              },
              {
                ""rushOffenseRank"": ""14"",
                ""isHome"": ""1"",
                ""spread"": ""-5.5"",
                ""id"": ""LAR"",
                ""passDefenseRank"": ""20"",
                ""rushDefenseRank"": ""5"",
                ""hasPossession"": ""0"",
                ""score"": ""23"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""1""
              }
            ],
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1759450500""
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""id"": ""MIN"",
                ""passDefenseRank"": ""3"",
                ""spread"": ""-4.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""23"",
                ""passOffenseRank"": ""15"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""26"",
                ""score"": ""21"",
                ""hasPossession"": ""0""
              },
              {
                ""passDefenseRank"": ""7"",
                ""id"": ""CLE"",
                ""spread"": ""4.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""21"",
                ""passOffenseRank"": ""29"",
                ""inRedZone"": ""0"",
                ""score"": ""17"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""2""
              }
            ],
            ""kickoff"": ""1759671000"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""team"": [
              {
                ""score"": ""6"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""16"",
                ""passOffenseRank"": ""27"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""10"",
                ""passDefenseRank"": ""14"",
                ""id"": ""LVR"",
                ""spread"": ""6.5""
              },
              {
                ""score"": ""40"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""14"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""6"",
                ""rushOffenseRank"": ""15"",
                ""isHome"": ""1"",
                ""spread"": ""-6.5"",
                ""passDefenseRank"": ""23"",
                ""id"": ""IND""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1759683600"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1759683600"",
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""5"",
                ""id"": ""DAL"",
                ""passDefenseRank"": ""31"",
                ""spread"": ""-3"",
                ""rushDefenseRank"": ""19"",
                ""score"": ""37"",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""3"",
                ""inRedZone"": ""0""
              },
              {
                ""spread"": ""3.0"",
                ""id"": ""NYJ"",
                ""passDefenseRank"": ""10"",
                ""rushOffenseRank"": ""7"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""32"",
                ""rushDefenseRank"": ""30"",
                ""hasPossession"": ""0"",
                ""score"": ""22""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1759683600"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""6"",
                ""passDefenseRank"": ""22"",
                ""id"": ""DEN"",
                ""spread"": ""4.5"",
                ""score"": ""21"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""7"",
                ""passOffenseRank"": ""12"",
                ""inRedZone"": ""0""
              },
              {
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""27"",
                ""passDefenseRank"": ""15"",
                ""id"": ""PHI"",
                ""spread"": ""-4.5"",
                ""hasPossession"": ""0"",
                ""score"": ""17"",
                ""rushDefenseRank"": ""24"",
                ""passOffenseRank"": ""31"",
                ""inRedZone"": ""0""
              }
            ]
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1759683600"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""29"",
                ""passDefenseRank"": ""8"",
                ""id"": ""MIA"",
                ""spread"": ""1.5"",
                ""hasPossession"": ""0"",
                ""score"": ""24"",
                ""rushDefenseRank"": ""31"",
                ""passOffenseRank"": ""17"",
                ""inRedZone"": ""0""
              },
              {
                ""rushDefenseRank"": ""3"",
                ""hasPossession"": ""0"",
                ""score"": ""27"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""21"",
                ""rushOffenseRank"": ""8"",
                ""isHome"": ""1"",
                ""spread"": ""-1.5"",
                ""id"": ""CAR"",
                ""passDefenseRank"": ""12""
              }
            ]
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1759683600"",
            ""team"": [
              {
                ""passOffenseRank"": ""14"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""20"",
                ""score"": ""14"",
                ""hasPossession"": ""0"",
                ""id"": ""NYG"",
                ""passDefenseRank"": ""25"",
                ""spread"": ""1.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""9""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""25"",
                ""score"": ""26"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""18"",
                ""spread"": ""-1.5"",
                ""passDefenseRank"": ""17"",
                ""id"": ""NOS"",
                ""rushOffenseRank"": ""17"",
                ""isHome"": ""1""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""id"": ""HOU"",
                ""passDefenseRank"": ""6"",
                ""spread"": ""3.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""18"",
                ""passOffenseRank"": ""18"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""10"",
                ""hasPossession"": ""0"",
                ""score"": ""44""
              },
              {
                ""score"": ""10"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""29"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""22"",
                ""rushOffenseRank"": ""28"",
                ""isHome"": ""1"",
                ""spread"": ""-3.5"",
                ""passDefenseRank"": ""19"",
                ""id"": ""BAL""
              }
            ],
            ""kickoff"": ""1759683600"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""19"",
                ""passDefenseRank"": ""9"",
                ""id"": ""TBB"",
                ""spread"": ""3"",
                ""hasPossession"": ""0"",
                ""score"": ""38"",
                ""rushDefenseRank"": ""12"",
                ""passOffenseRank"": ""5"",
                ""inRedZone"": ""0""
              },
              {
                ""rushOffenseRank"": ""16"",
                ""isHome"": ""1"",
                ""spread"": ""-3.0"",
                ""passDefenseRank"": ""21"",
                ""id"": ""SEA"",
                ""hasPossession"": ""0"",
                ""score"": ""35"",
                ""rushDefenseRank"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""4""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1759694700"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""kickoff"": ""1759694700"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""hasPossession"": ""0"",
                ""score"": ""22"",
                ""rushDefenseRank"": ""27"",
                ""passOffenseRank"": ""30"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""26"",
                ""passDefenseRank"": ""21"",
                ""id"": ""TEN"",
                ""spread"": ""8.5""
              },
              {
                ""rushDefenseRank"": ""6"",
                ""hasPossession"": ""0"",
                ""score"": ""21"",
                ""passOffenseRank"": ""26"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""20"",
                ""id"": ""ARI"",
                ""passDefenseRank"": ""28"",
                ""spread"": ""-8.5""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""team"": [
              {
                ""passOffenseRank"": ""9"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""11"",
                ""score"": ""37"",
                ""hasPossession"": ""0"",
                ""id"": ""DET"",
                ""passDefenseRank"": ""13"",
                ""spread"": ""-10"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""3""
              },
              {
                ""rushOffenseRank"": ""31"",
                ""isHome"": ""1"",
                ""spread"": ""10.0"",
                ""id"": ""CIN"",
                ""passDefenseRank"": ""26"",
                ""rushDefenseRank"": ""28"",
                ""hasPossession"": ""0"",
                ""score"": ""24"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""23""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1759695900"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""kickoff"": ""1759695900"",
            ""gameSecondsRemaining"": ""0"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""score"": ""27"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""23"",
                ""passOffenseRank"": ""24"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""4"",
                ""passDefenseRank"": ""27"",
                ""id"": ""WAS"",
                ""spread"": ""2.5""
              },
              {
                ""rushOffenseRank"": ""13"",
                ""isHome"": ""1"",
                ""spread"": ""-2.5"",
                ""id"": ""LAC"",
                ""passDefenseRank"": ""4"",
                ""rushDefenseRank"": ""22"",
                ""score"": ""10"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""13""
              }
            ]
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""11"",
                ""score"": ""23"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""8"",
                ""spread"": ""8.5"",
                ""passDefenseRank"": ""16"",
                ""id"": ""NEP"",
                ""rushOffenseRank"": ""22"",
                ""isHome"": ""0""
              },
              {
                ""rushDefenseRank"": ""21"",
                ""score"": ""20"",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""20"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""1"",
                ""id"": ""BUF"",
                ""passDefenseRank"": ""2"",
                ""spread"": ""-8.5""
              }
            ],
            ""kickoff"": ""1759710000"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""team"": [
              {
                ""rushDefenseRank"": ""25"",
                ""hasPossession"": ""0"",
                ""score"": ""28"",
                ""passOffenseRank"": ""8"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""12"",
                ""id"": ""KCC"",
                ""passDefenseRank"": ""5"",
                ""spread"": ""-3.5""
              },
              {
                ""spread"": ""3.5"",
                ""passDefenseRank"": ""30"",
                ""id"": ""JAC"",
                ""rushOffenseRank"": ""15"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""16"",
                ""hasPossession"": ""0"",
                ""score"": ""31"",
                ""rushDefenseRank"": ""9""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1759796100""
          }
        ]
      },
      {
        ""matchup"": [
          {
            ""team"": [
              {
                ""passDefenseRank"": ""13"",
                ""id"": ""PHI"",
                ""spread"": ""-7"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""30"",
                ""passOffenseRank"": ""27"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""17"",
                ""rushDefenseRank"": ""25""
              },
              {
                ""spread"": ""7.0"",
                ""id"": ""NYG"",
                ""passDefenseRank"": ""24"",
                ""rushOffenseRank"": ""6"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""17"",
                ""rushDefenseRank"": ""17"",
                ""score"": ""34"",
                ""hasPossession"": ""0""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1760055300""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1760275800"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""13"",
                ""rushDefenseRank"": ""8"",
                ""score"": ""13"",
                ""hasPossession"": ""0"",
                ""spread"": ""-7.5"",
                ""id"": ""DEN"",
                ""passDefenseRank"": ""7"",
                ""rushOffenseRank"": ""11"",
                ""isHome"": ""0""
              },
              {
                ""score"": ""11"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""29"",
                ""passOffenseRank"": ""32"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""10"",
                ""passDefenseRank"": ""8"",
                ""id"": ""NYJ"",
                ""spread"": ""7.5""
              }
            ]
          },
          {
            ""team"": [
              {
                ""hasPossession"": ""0"",
                ""score"": ""27"",
                ""rushDefenseRank"": ""13"",
                ""passOffenseRank"": ""20"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""22"",
                ""passDefenseRank"": ""28"",
                ""id"": ""ARI"",
                ""spread"": ""6.5""
              },
              {
                ""rushDefenseRank"": ""12"",
                ""score"": ""31"",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""7"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""8"",
                ""id"": ""IND"",
                ""passDefenseRank"": ""26"",
                ""spread"": ""-6.5""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1760288400"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""12"",
                ""rushDefenseRank"": ""21"",
                ""hasPossession"": ""0"",
                ""score"": ""29"",
                ""spread"": ""-4.5"",
                ""id"": ""LAC"",
                ""passDefenseRank"": ""5"",
                ""rushOffenseRank"": ""9"",
                ""isHome"": ""0""
              },
              {
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""27"",
                ""id"": ""MIA"",
                ""passDefenseRank"": ""13"",
                ""spread"": ""4.5"",
                ""rushDefenseRank"": ""32"",
                ""score"": ""27"",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""18"",
                ""inRedZone"": ""0""
              }
            ],
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1760288400""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1760288400"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""21"",
                ""passDefenseRank"": ""21"",
                ""id"": ""SEA"",
                ""spread"": ""1.5"",
                ""hasPossession"": ""0"",
                ""score"": ""20"",
                ""rushDefenseRank"": ""1"",
                ""passOffenseRank"": ""4"",
                ""inRedZone"": ""0""
              },
              {
                ""spread"": ""-1.5"",
                ""id"": ""JAC"",
                ""passDefenseRank"": ""30"",
                ""rushOffenseRank"": ""19"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""15"",
                ""rushDefenseRank"": ""5"",
                ""hasPossession"": ""0"",
                ""score"": ""12""
              }
            ]
          },
          {
            ""team"": [
              {
                ""rushDefenseRank"": ""4"",
                ""hasPossession"": ""0"",
                ""score"": ""9"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""30"",
                ""rushOffenseRank"": ""25"",
                ""isHome"": ""0"",
                ""spread"": ""4.5"",
                ""id"": ""CLE"",
                ""passDefenseRank"": ""9""
              },
              {
                ""passOffenseRank"": ""26"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""9"",
                ""score"": ""23"",
                ""hasPossession"": ""0"",
                ""id"": ""PIT"",
                ""passDefenseRank"": ""27"",
                ""spread"": ""-4.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""28""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1760288400""
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushOffenseRank"": ""13"",
                ""isHome"": ""0"",
                ""spread"": ""-3.5"",
                ""id"": ""DAL"",
                ""passDefenseRank"": ""31"",
                ""rushDefenseRank"": ""26"",
                ""hasPossession"": ""0"",
                ""score"": ""27"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""2""
              },
              {
                ""rushDefenseRank"": ""2"",
                ""score"": ""30"",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""21"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""3"",
                ""id"": ""CAR"",
                ""passDefenseRank"": ""19"",
                ""spread"": ""3.5""
              }
            ],
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1760288400""
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""score"": ""25"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""6"",
                ""passOffenseRank"": ""9"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""26"",
                ""passDefenseRank"": ""18"",
                ""id"": ""NEP"",
                ""spread"": ""-3.5""
              },
              {
                ""spread"": ""3.5"",
                ""id"": ""NOS"",
                ""passDefenseRank"": ""22"",
                ""rushOffenseRank"": ""18"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""24"",
                ""rushDefenseRank"": ""16"",
                ""score"": ""19"",
                ""hasPossession"": ""0""
              }
            ],
            ""kickoff"": ""1760288400"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""team"": [
              {
                ""spread"": ""-7.5"",
                ""passDefenseRank"": ""11"",
                ""id"": ""LAR"",
                ""rushOffenseRank"": ""16"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""3"",
                ""score"": ""17"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""15""
              },
              {
                ""rushDefenseRank"": ""27"",
                ""score"": ""3"",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""28"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""23"",
                ""id"": ""BAL"",
                ""passDefenseRank"": ""15"",
                ""spread"": ""7.5""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1760288400""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1760299500"",
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""31"",
                ""rushDefenseRank"": ""22"",
                ""score"": ""10"",
                ""hasPossession"": ""0"",
                ""spread"": ""4.5"",
                ""id"": ""TEN"",
                ""passDefenseRank"": ""16"",
                ""rushOffenseRank"": ""29"",
                ""isHome"": ""0""
              },
              {
                ""rushOffenseRank"": ""15"",
                ""isHome"": ""1"",
                ""spread"": ""-4.5"",
                ""id"": ""LVR"",
                ""passDefenseRank"": ""10"",
                ""rushDefenseRank"": ""14"",
                ""hasPossession"": ""0"",
                ""score"": ""20"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""29""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1760300700"",
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""32"",
                ""passDefenseRank"": ""29"",
                ""id"": ""CIN"",
                ""spread"": ""14.5"",
                ""hasPossession"": ""0"",
                ""score"": ""18"",
                ""rushDefenseRank"": ""30"",
                ""passOffenseRank"": ""22"",
                ""inRedZone"": ""0""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""6"",
                ""hasPossession"": ""0"",
                ""score"": ""27"",
                ""rushDefenseRank"": ""3"",
                ""spread"": ""-14.5"",
                ""passDefenseRank"": ""12"",
                ""id"": ""GBP"",
                ""rushOffenseRank"": ""7"",
                ""isHome"": ""1""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""kickoff"": ""1760300700"",
            ""gameSecondsRemaining"": ""0"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""1"",
                ""score"": ""19"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""18"",
                ""spread"": ""3"",
                ""passDefenseRank"": ""20"",
                ""id"": ""SFO"",
                ""rushOffenseRank"": ""31"",
                ""isHome"": ""0""
              },
              {
                ""id"": ""TBB"",
                ""passDefenseRank"": ""17"",
                ""spread"": ""-3.0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""17"",
                ""passOffenseRank"": ""5"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""7"",
                ""score"": ""30"",
                ""hasPossession"": ""0""
              }
            ]
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""score"": ""17"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""11"",
                ""passOffenseRank"": ""11"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""4"",
                ""passDefenseRank"": ""14"",
                ""id"": ""DET"",
                ""spread"": ""1.5""
              },
              {
                ""id"": ""KCC"",
                ""passDefenseRank"": ""6"",
                ""spread"": ""-1.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""12"",
                ""passOffenseRank"": ""8"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""20"",
                ""hasPossession"": ""0"",
                ""score"": ""30""
              }
            ],
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1760314800""
          },
          {
            ""team"": [
              {
                ""spread"": ""-4.5"",
                ""id"": ""BUF"",
                ""passDefenseRank"": ""3"",
                ""rushOffenseRank"": ""2"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""23"",
                ""rushDefenseRank"": ""28"",
                ""hasPossession"": ""0"",
                ""score"": ""14""
              },
              {
                ""rushOffenseRank"": ""1"",
                ""isHome"": ""1"",
                ""spread"": ""4.5"",
                ""id"": ""ATL"",
                ""passDefenseRank"": ""1"",
                ""rushDefenseRank"": ""19"",
                ""hasPossession"": ""0"",
                ""score"": ""24"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""16""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1760397300""
          },
          {
            ""kickoff"": ""1760400900"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""rushOffenseRank"": ""20"",
                ""isHome"": ""0"",
                ""spread"": ""4.5"",
                ""id"": ""CHI"",
                ""passDefenseRank"": ""23"",
                ""rushDefenseRank"": ""31"",
                ""hasPossession"": ""0"",
                ""score"": ""25"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""10""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""25"",
                ""rushDefenseRank"": ""23"",
                ""hasPossession"": ""0"",
                ""score"": ""24"",
                ""spread"": ""-4.5"",
                ""id"": ""WAS"",
                ""passDefenseRank"": ""25"",
                ""rushOffenseRank"": ""5"",
                ""isHome"": ""1""
              }
            ],
            ""status"": ""FINAL""
          }
        ],
        ""week"": ""6"",
        ""lastUpdate"": ""1766140832""
      },
      {
        ""matchup"": [
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1760660100"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushOffenseRank"": ""22"",
                ""isHome"": ""0"",
                ""spread"": ""-5.5"",
                ""passDefenseRank"": ""29"",
                ""id"": ""PIT"",
                ""hasPossession"": ""0"",
                ""score"": ""31"",
                ""rushDefenseRank"": ""12"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""22""
              },
              {
                ""spread"": ""5.5"",
                ""id"": ""CIN"",
                ""passDefenseRank"": ""27"",
                ""rushOffenseRank"": ""31"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""17"",
                ""rushDefenseRank"": ""31"",
                ""hasPossession"": ""0"",
                ""score"": ""33""
              }
            ]
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1760880600"",
            ""team"": [
              {
                ""rushOffenseRank"": ""17"",
                ""isHome"": ""0"",
                ""spread"": ""-3"",
                ""id"": ""LAR"",
                ""passDefenseRank"": ""16"",
                ""rushDefenseRank"": ""15"",
                ""hasPossession"": ""0"",
                ""score"": ""35"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""3""
              },
              {
                ""rushOffenseRank"": ""18"",
                ""isHome"": ""1"",
                ""spread"": ""3.0"",
                ""passDefenseRank"": ""28"",
                ""id"": ""JAC"",
                ""hasPossession"": ""0"",
                ""score"": ""7"",
                ""rushDefenseRank"": ""5"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""14""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""kickoff"": ""1760893200"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""passOffenseRank"": ""26"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""2"",
                ""score"": ""13"",
                ""hasPossession"": ""0"",
                ""id"": ""CAR"",
                ""passDefenseRank"": ""11"",
                ""spread"": ""-1.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""4""
              },
              {
                ""rushDefenseRank"": ""30"",
                ""hasPossession"": ""0"",
                ""score"": ""6"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""32"",
                ""rushOffenseRank"": ""13"",
                ""isHome"": ""1"",
                ""spread"": ""1.5"",
                ""id"": ""NYJ"",
                ""passDefenseRank"": ""8""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1760893200"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""spread"": ""2.5"",
                ""passDefenseRank"": ""9"",
                ""id"": ""MIA"",
                ""rushOffenseRank"": ""28"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""24"",
                ""score"": ""6"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""32""
              },
              {
                ""id"": ""CLE"",
                ""passDefenseRank"": ""7"",
                ""spread"": ""-2.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""25"",
                ""passOffenseRank"": ""30"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""6"",
                ""score"": ""31"",
                ""hasPossession"": ""0""
              }
            ]
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""passOffenseRank"": ""9"",
                ""inRedZone"": ""0"",
                ""score"": ""31"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""3"",
                ""passDefenseRank"": ""19"",
                ""id"": ""NEP"",
                ""spread"": ""-7"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""15""
              },
              {
                ""passOffenseRank"": ""29"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""13"",
                ""rushDefenseRank"": ""25"",
                ""passDefenseRank"": ""15"",
                ""id"": ""TEN"",
                ""spread"": ""7.0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""30""
              }
            ],
            ""kickoff"": ""1760893200"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1760893200"",
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""31"",
                ""hasPossession"": ""0"",
                ""score"": ""0"",
                ""rushDefenseRank"": ""17"",
                ""spread"": ""11.5"",
                ""passDefenseRank"": ""14"",
                ""id"": ""LVR"",
                ""rushOffenseRank"": ""24"",
                ""isHome"": ""0""
              },
              {
                ""score"": ""31"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""16"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""8"",
                ""rushOffenseRank"": ""9"",
                ""isHome"": ""1"",
                ""spread"": ""-11.5"",
                ""passDefenseRank"": ""2"",
                ""id"": ""KCC""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1760893200"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""score"": ""14"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""20"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""23"",
                ""rushOffenseRank"": ""27"",
                ""isHome"": ""0"",
                ""spread"": ""5.5"",
                ""passDefenseRank"": ""18"",
                ""id"": ""NOS""
              },
              {
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""7"",
                ""passDefenseRank"": ""22"",
                ""id"": ""CHI"",
                ""spread"": ""-5.5"",
                ""score"": ""26"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""29"",
                ""passOffenseRank"": ""15"",
                ""inRedZone"": ""0""
              }
            ]
          },
          {
            ""kickoff"": ""1760893200"",
            ""gameSecondsRemaining"": ""0"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""hasPossession"": ""0"",
                ""score"": ""28"",
                ""rushDefenseRank"": ""23"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""20"",
                ""rushOffenseRank"": ""30"",
                ""isHome"": ""0"",
                ""spread"": ""-2.5"",
                ""passDefenseRank"": ""21"",
                ""id"": ""PHI""
              },
              {
                ""spread"": ""2.5"",
                ""passDefenseRank"": ""5"",
                ""id"": ""MIN"",
                ""rushOffenseRank"": ""23"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""11"",
                ""score"": ""22"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""19""
              }
            ]
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushOffenseRank"": ""6"",
                ""isHome"": ""0"",
                ""spread"": ""7"",
                ""passDefenseRank"": ""25"",
                ""id"": ""NYG"",
                ""score"": ""32"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""18"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""16""
              },
              {
                ""id"": ""DEN"",
                ""passDefenseRank"": ""10"",
                ""spread"": ""-7.0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""8"",
                ""passOffenseRank"": ""13"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""9"",
                ""score"": ""33"",
                ""hasPossession"": ""0""
              }
            ],
            ""kickoff"": ""1760904300"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""team"": [
              {
                ""rushOffenseRank"": ""10"",
                ""isHome"": ""0"",
                ""spread"": ""1.5"",
                ""id"": ""IND"",
                ""passDefenseRank"": ""30"",
                ""rushDefenseRank"": ""8"",
                ""hasPossession"": ""0"",
                ""score"": ""38"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""7""
              },
              {
                ""passDefenseRank"": ""6"",
                ""id"": ""LAC"",
                ""spread"": ""-1.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""14"",
                ""passOffenseRank"": ""5"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""24"",
                ""rushDefenseRank"": ""21""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1760904300""
          },
          {
            ""team"": [
              {
                ""rushDefenseRank"": ""24"",
                ""hasPossession"": ""0"",
                ""score"": ""22"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""27"",
                ""rushOffenseRank"": ""5"",
                ""isHome"": ""0"",
                ""spread"": ""-2.5"",
                ""id"": ""WAS"",
                ""passDefenseRank"": ""26""
              },
              {
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""12"",
                ""id"": ""DAL"",
                ""passDefenseRank"": ""31"",
                ""spread"": ""2.5"",
                ""rushDefenseRank"": ""26"",
                ""score"": ""44"",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""1"",
                ""inRedZone"": ""0""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1760905500""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1760905500"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushDefenseRank"": ""4"",
                ""hasPossession"": ""0"",
                ""score"": ""27"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""10"",
                ""rushOffenseRank"": ""11"",
                ""isHome"": ""0"",
                ""spread"": ""-6.5"",
                ""id"": ""GBP"",
                ""passDefenseRank"": ""12""
              },
              {
                ""passDefenseRank"": ""24"",
                ""id"": ""ARI"",
                ""spread"": ""6.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""20"",
                ""passOffenseRank"": ""19"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""23"",
                ""rushDefenseRank"": ""11""
              }
            ]
          },
          {
            ""team"": [
              {
                ""rushDefenseRank"": ""22"",
                ""score"": ""10"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""18"",
                ""rushOffenseRank"": ""2"",
                ""isHome"": ""0"",
                ""spread"": ""2.5"",
                ""id"": ""ATL"",
                ""passDefenseRank"": ""1""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""2"",
                ""rushDefenseRank"": ""13"",
                ""hasPossession"": ""0"",
                ""score"": ""20"",
                ""spread"": ""-2.5"",
                ""id"": ""SFO"",
                ""passDefenseRank"": ""23"",
                ""rushOffenseRank"": ""29"",
                ""isHome"": ""1""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1760919600""
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""6"",
                ""rushDefenseRank"": ""14"",
                ""score"": ""9"",
                ""hasPossession"": ""0"",
                ""spread"": ""4.5"",
                ""id"": ""TBB"",
                ""passDefenseRank"": ""18"",
                ""rushOffenseRank"": ""26"",
                ""isHome"": ""0""
              },
              {
                ""passDefenseRank"": ""13"",
                ""id"": ""DET"",
                ""spread"": ""-4.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""3"",
                ""passOffenseRank"": ""12"",
                ""inRedZone"": ""0"",
                ""score"": ""24"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""7""
              }
            ],
            ""kickoff"": ""1761001200"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""21"",
                ""rushDefenseRank"": ""10"",
                ""score"": ""19"",
                ""hasPossession"": ""0"",
                ""spread"": ""3"",
                ""id"": ""HOU"",
                ""passDefenseRank"": ""4"",
                ""rushOffenseRank"": ""19"",
                ""isHome"": ""0""
              },
              {
                ""spread"": ""-3.0"",
                ""id"": ""SEA"",
                ""passDefenseRank"": ""20"",
                ""rushOffenseRank"": ""16"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""4"",
                ""rushDefenseRank"": ""1"",
                ""score"": ""27"",
                ""hasPossession"": ""0""
              }
            ],
            ""kickoff"": ""1761012000"",
            ""gameSecondsRemaining"": ""0""
          }
        ],
        ""lastUpdate"": ""1766140832"",
        ""week"": ""7""
      },
      {
        ""week"": ""8"",
        ""lastUpdate"": ""1766140832"",
        ""matchup"": [
          {
            ""kickoff"": ""1761264900"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""18"",
                ""score"": ""10"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""22"",
                ""spread"": ""3"",
                ""passDefenseRank"": ""6"",
                ""id"": ""MIN"",
                ""rushOffenseRank"": ""29"",
                ""isHome"": ""0""
              },
              {
                ""rushDefenseRank"": ""18"",
                ""hasPossession"": ""0"",
                ""score"": ""37"",
                ""passOffenseRank"": ""8"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""9"",
                ""id"": ""LAC"",
                ""passDefenseRank"": ""5"",
                ""spread"": ""-3.0""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1761498000"",
            ""team"": [
              {
                ""rushDefenseRank"": ""12"",
                ""score"": ""13"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""30"",
                ""rushOffenseRank"": ""27"",
                ""isHome"": ""0"",
                ""spread"": ""7"",
                ""id"": ""CLE"",
                ""passDefenseRank"": ""8""
              },
              {
                ""rushOffenseRank"": ""15"",
                ""isHome"": ""1"",
                ""spread"": ""-7.0"",
                ""id"": ""NEP"",
                ""passDefenseRank"": ""13"",
                ""rushDefenseRank"": ""2"",
                ""hasPossession"": ""0"",
                ""score"": ""32"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""9""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""spread"": ""6.5"",
                ""id"": ""NYJ"",
                ""passDefenseRank"": ""9"",
                ""rushOffenseRank"": ""4"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""32"",
                ""rushDefenseRank"": ""30"",
                ""hasPossession"": ""0"",
                ""score"": ""39""
              },
              {
                ""rushDefenseRank"": ""31"",
                ""score"": ""38"",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""16"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""30"",
                ""id"": ""CIN"",
                ""passDefenseRank"": ""27"",
                ""spread"": ""-6.5""
              }
            ],
            ""kickoff"": ""1761498000"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""team"": [
              {
                ""rushDefenseRank"": ""25"",
                ""hasPossession"": ""0"",
                ""score"": ""20"",
                ""passOffenseRank"": ""17"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""12"",
                ""id"": ""NYG"",
                ""passDefenseRank"": ""24"",
                ""spread"": ""7""
              },
              {
                ""score"": ""38"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""19"",
                ""passOffenseRank"": ""23"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""21"",
                ""passDefenseRank"": ""19"",
                ""id"": ""PHI"",
                ""spread"": ""-7.0""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1761498000""
          },
          {
            ""kickoff"": ""1761498000"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""rushOffenseRank"": ""23"",
                ""isHome"": ""0"",
                ""spread"": ""7"",
                ""passDefenseRank"": ""7"",
                ""id"": ""MIA"",
                ""score"": ""34"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""27"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""24""
              },
              {
                ""rushDefenseRank"": ""21"",
                ""score"": ""10"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""20"",
                ""rushOffenseRank"": ""6"",
                ""isHome"": ""1"",
                ""spread"": ""-7.0"",
                ""id"": ""ATL"",
                ""passDefenseRank"": ""1""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1761498000"",
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""26"",
                ""rushDefenseRank"": ""23"",
                ""score"": ""40"",
                ""hasPossession"": ""0"",
                ""spread"": ""-7.5"",
                ""id"": ""BUF"",
                ""passDefenseRank"": ""2"",
                ""rushOffenseRank"": ""1"",
                ""isHome"": ""0""
              },
              {
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""3"",
                ""passDefenseRank"": ""10"",
                ""id"": ""CAR"",
                ""spread"": ""7.5"",
                ""hasPossession"": ""0"",
                ""score"": ""9"",
                ""rushDefenseRank"": ""10"",
                ""passOffenseRank"": ""27"",
                ""inRedZone"": ""0""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""id"": ""CHI"",
                ""passDefenseRank"": ""18"",
                ""spread"": ""6.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""11"",
                ""passOffenseRank"": ""11"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""29"",
                ""hasPossession"": ""0"",
                ""score"": ""16""
              },
              {
                ""score"": ""30"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""22"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""29"",
                ""rushOffenseRank"": ""16"",
                ""isHome"": ""1"",
                ""spread"": ""-6.5"",
                ""passDefenseRank"": ""23"",
                ""id"": ""BAL""
              }
            ],
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1761498000""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1761498000"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""passOffenseRank"": ""4"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""17"",
                ""hasPossession"": ""0"",
                ""score"": ""15"",
                ""id"": ""SFO"",
                ""passDefenseRank"": ""26"",
                ""spread"": ""-1.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""31""
              },
              {
                ""id"": ""HOU"",
                ""passDefenseRank"": ""4"",
                ""spread"": ""1.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""17"",
                ""passOffenseRank"": ""14"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""6"",
                ""score"": ""26"",
                ""hasPossession"": ""0""
              }
            ]
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1761509100"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""score"": ""23"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""8"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""10"",
                ""rushOffenseRank"": ""26"",
                ""isHome"": ""0"",
                ""spread"": ""-4.5"",
                ""passDefenseRank"": ""20"",
                ""id"": ""TBB""
              },
              {
                ""rushOffenseRank"": ""28"",
                ""isHome"": ""1"",
                ""spread"": ""4.5"",
                ""passDefenseRank"": ""12"",
                ""id"": ""NOS"",
                ""score"": ""3"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""20"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""21""
              }
            ]
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1761510300"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""passOffenseRank"": ""28"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""14"",
                ""rushDefenseRank"": ""26"",
                ""passDefenseRank"": ""21"",
                ""id"": ""TEN"",
                ""spread"": ""14"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""32""
              },
              {
                ""passDefenseRank"": ""30"",
                ""id"": ""IND"",
                ""spread"": ""-14.0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""7"",
                ""passOffenseRank"": ""7"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""38"",
                ""rushDefenseRank"": ""7""
              }
            ]
          },
          {
            ""team"": [
              {
                ""spread"": ""3"",
                ""passDefenseRank"": ""31"",
                ""id"": ""DAL"",
                ""rushOffenseRank"": ""13"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""1"",
                ""score"": ""24"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""28""
              },
              {
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""5"",
                ""id"": ""DEN"",
                ""passDefenseRank"": ""11"",
                ""spread"": ""-3.0"",
                ""rushDefenseRank"": ""9"",
                ""hasPossession"": ""0"",
                ""score"": ""44"",
                ""passOffenseRank"": ""13"",
                ""inRedZone"": ""0""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1761510300"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1761524400"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushDefenseRank"": ""3"",
                ""score"": ""35"",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""5"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""14"",
                ""id"": ""GBP"",
                ""passDefenseRank"": ""14"",
                ""spread"": ""-3.5""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""22"",
                ""rushDefenseRank"": ""13"",
                ""score"": ""25"",
                ""hasPossession"": ""0"",
                ""spread"": ""3.5"",
                ""id"": ""PIT"",
                ""passDefenseRank"": ""32"",
                ""rushOffenseRank"": ""24"",
                ""isHome"": ""1""
              }
            ]
          },
          {
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""10"",
                ""id"": ""WAS"",
                ""passDefenseRank"": ""28"",
                ""spread"": ""10.5"",
                ""rushDefenseRank"": ""24"",
                ""score"": ""7"",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""25"",
                ""inRedZone"": ""0""
              },
              {
                ""id"": ""KCC"",
                ""passDefenseRank"": ""3"",
                ""spread"": ""-10.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""8"",
                ""passOffenseRank"": ""6"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""14"",
                ""score"": ""28"",
                ""hasPossession"": ""0""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1761610500""
          }
        ]
      },
      {
        ""matchup"": [
          {
            ""team"": [
              {
                ""rushDefenseRank"": ""21"",
                ""hasPossession"": ""0"",
                ""score"": ""28"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""27"",
                ""rushOffenseRank"": ""14"",
                ""isHome"": ""0"",
                ""spread"": ""-7.5"",
                ""id"": ""BAL"",
                ""passDefenseRank"": ""22""
              },
              {
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""23"",
                ""passDefenseRank"": ""6"",
                ""id"": ""MIA"",
                ""spread"": ""7.5"",
                ""hasPossession"": ""0"",
                ""score"": ""6"",
                ""rushDefenseRank"": ""30"",
                ""passOffenseRank"": ""20"",
                ""inRedZone"": ""0""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1761869700"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""kickoff"": ""1762106400"",
            ""gameSecondsRemaining"": ""0"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""hasPossession"": ""0"",
                ""score"": ""23"",
                ""rushDefenseRank"": ""24"",
                ""passOffenseRank"": ""19"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""10"",
                ""passDefenseRank"": ""1"",
                ""id"": ""ATL"",
                ""spread"": ""5.5""
              },
              {
                ""spread"": ""-5.5"",
                ""id"": ""NEP"",
                ""passDefenseRank"": ""14"",
                ""rushOffenseRank"": ""15"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""12"",
                ""rushDefenseRank"": ""1"",
                ""hasPossession"": ""0"",
                ""score"": ""24""
              }
            ]
          },
          {
            ""kickoff"": ""1762106400"",
            ""gameSecondsRemaining"": ""0"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""score"": ""47"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""26"",
                ""passOffenseRank"": ""10"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""2"",
                ""passDefenseRank"": ""26"",
                ""id"": ""CHI"",
                ""spread"": ""-2.5""
              },
              {
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""31"",
                ""passDefenseRank"": ""27"",
                ""id"": ""CIN"",
                ""spread"": ""2.5"",
                ""score"": ""42"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""32"",
                ""passOffenseRank"": ""8"",
                ""inRedZone"": ""0""
              }
            ]
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushDefenseRank"": ""16"",
                ""score"": ""27"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""9"",
                ""rushOffenseRank"": ""8"",
                ""isHome"": ""0"",
                ""spread"": ""-10"",
                ""id"": ""LAC"",
                ""passDefenseRank"": ""3""
              },
              {
                ""rushDefenseRank"": ""27"",
                ""score"": ""20"",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""28"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""32"",
                ""id"": ""TEN"",
                ""passDefenseRank"": ""21"",
                ""spread"": ""10.0""
              }
            ],
            ""kickoff"": ""1762106400"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1762106400"",
            ""team"": [
              {
                ""passOffenseRank"": ""4"",
                ""inRedZone"": ""0"",
                ""score"": ""20"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""4"",
                ""passDefenseRank"": ""28"",
                ""id"": ""IND"",
                ""spread"": ""-3"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""12""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""24"",
                ""score"": ""27"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""6"",
                ""spread"": ""3.0"",
                ""passDefenseRank"": ""32"",
                ""id"": ""PIT"",
                ""rushOffenseRank"": ""29"",
                ""isHome"": ""1""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""6"",
                ""hasPossession"": ""0"",
                ""score"": ""34"",
                ""rushDefenseRank"": ""17"",
                ""spread"": ""-2.5"",
                ""passDefenseRank"": ""23"",
                ""id"": ""SFO"",
                ""rushOffenseRank"": ""27"",
                ""isHome"": ""0""
              },
              {
                ""spread"": ""2.5"",
                ""passDefenseRank"": ""24"",
                ""id"": ""NYG"",
                ""rushOffenseRank"": ""11"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""18"",
                ""hasPossession"": ""0"",
                ""score"": ""24"",
                ""rushDefenseRank"": ""29""
              }
            ],
            ""kickoff"": ""1762106400"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""kickoff"": ""1762106400"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""25"",
                ""id"": ""MIN"",
                ""passDefenseRank"": ""7"",
                ""spread"": ""8.5"",
                ""rushDefenseRank"": ""20"",
                ""score"": ""27"",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""22"",
                ""inRedZone"": ""0""
              },
              {
                ""spread"": ""-8.5"",
                ""passDefenseRank"": ""11"",
                ""id"": ""DET"",
                ""rushOffenseRank"": ""5"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""13"",
                ""hasPossession"": ""0"",
                ""score"": ""24"",
                ""rushDefenseRank"": ""10""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""team"": [
              {
                ""spread"": ""12.5"",
                ""passDefenseRank"": ""13"",
                ""id"": ""CAR"",
                ""rushOffenseRank"": ""3"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""29"",
                ""score"": ""16"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""12""
              },
              {
                ""rushOffenseRank"": ""16"",
                ""isHome"": ""1"",
                ""spread"": ""-12.5"",
                ""passDefenseRank"": ""9"",
                ""id"": ""GBP"",
                ""hasPossession"": ""0"",
                ""score"": ""13"",
                ""rushDefenseRank"": ""7"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""5""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1762106400""
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushDefenseRank"": ""8"",
                ""score"": ""18"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""16"",
                ""rushOffenseRank"": ""6"",
                ""isHome"": ""0"",
                ""spread"": ""1.5"",
                ""id"": ""DEN"",
                ""passDefenseRank"": ""12""
              },
              {
                ""spread"": ""-1.5"",
                ""passDefenseRank"": ""4"",
                ""id"": ""HOU"",
                ""rushOffenseRank"": ""19"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""14"",
                ""score"": ""15"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""5""
              }
            ],
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1762106400""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1762117500"",
            ""team"": [
              {
                ""passOffenseRank"": ""15"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""3"",
                ""hasPossession"": ""0"",
                ""score"": ""30"",
                ""id"": ""JAC"",
                ""passDefenseRank"": ""29"",
                ""spread"": ""-3"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""18""
              },
              {
                ""passDefenseRank"": ""18"",
                ""id"": ""LVR"",
                ""spread"": ""3.0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""28"",
                ""passOffenseRank"": ""30"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""29"",
                ""rushDefenseRank"": ""18""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1762117500"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushDefenseRank"": ""22"",
                ""score"": ""10"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""25"",
                ""rushOffenseRank"": ""30"",
                ""isHome"": ""0"",
                ""spread"": ""13.5"",
                ""id"": ""NOS"",
                ""passDefenseRank"": ""17""
              },
              {
                ""spread"": ""-13.5"",
                ""passDefenseRank"": ""15"",
                ""id"": ""LAR"",
                ""rushOffenseRank"": ""17"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""3"",
                ""hasPossession"": ""0"",
                ""score"": ""34"",
                ""rushDefenseRank"": ""11""
              }
            ]
          },
          {
            ""team"": [
              {
                ""passDefenseRank"": ""5"",
                ""id"": ""KCC"",
                ""spread"": ""-1.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""9"",
                ""passOffenseRank"": ""7"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""21"",
                ""rushDefenseRank"": ""15""
              },
              {
                ""spread"": ""1.5"",
                ""passDefenseRank"": ""2"",
                ""id"": ""BUF"",
                ""rushOffenseRank"": ""1"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""21"",
                ""score"": ""28"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""23""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1762118700""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1762132800"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""1"",
                ""rushDefenseRank"": ""2"",
                ""hasPossession"": ""0"",
                ""score"": ""38"",
                ""spread"": ""-3.5"",
                ""id"": ""SEA"",
                ""passDefenseRank"": ""16"",
                ""rushOffenseRank"": ""20"",
                ""isHome"": ""0""
              },
              {
                ""hasPossession"": ""0"",
                ""score"": ""14"",
                ""rushDefenseRank"": ""25"",
                ""passOffenseRank"": ""26"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""7"",
                ""passDefenseRank"": ""30"",
                ""id"": ""WAS"",
                ""spread"": ""3.5""
              }
            ]
          },
          {
            ""team"": [
              {
                ""id"": ""ARI"",
                ""passDefenseRank"": ""25"",
                ""spread"": ""2.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""21"",
                ""passOffenseRank"": ""17"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""14"",
                ""hasPossession"": ""0"",
                ""score"": ""27""
              },
              {
                ""passOffenseRank"": ""2"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""28"",
                ""hasPossession"": ""0"",
                ""score"": ""17"",
                ""id"": ""DAL"",
                ""passDefenseRank"": ""31"",
                ""spread"": ""-2.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""13""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1762218900"",
            ""gameSecondsRemaining"": ""0""
          }
        ],
        ""lastUpdate"": ""1766140832"",
        ""week"": ""9""
      },
      {
        ""matchup"": [
          {
            ""kickoff"": ""1762478100"",
            ""gameSecondsRemaining"": ""0"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""spread"": ""9.5"",
                ""id"": ""LVR"",
                ""passDefenseRank"": ""14"",
                ""rushOffenseRank"": ""28"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""29"",
                ""rushDefenseRank"": ""16"",
                ""score"": ""7"",
                ""hasPossession"": ""0""
              },
              {
                ""score"": ""10"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""5"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""18"",
                ""rushOffenseRank"": ""9"",
                ""isHome"": ""1"",
                ""spread"": ""-9.5"",
                ""passDefenseRank"": ""9"",
                ""id"": ""DEN""
              }
            ]
          },
          {
            ""kickoff"": ""1762698600"",
            ""gameSecondsRemaining"": ""0"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""passOffenseRank"": ""22"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""31"",
                ""hasPossession"": ""0"",
                ""score"": ""25"",
                ""id"": ""ATL"",
                ""passDefenseRank"": ""1"",
                ""spread"": ""5.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""11""
              },
              {
                ""hasPossession"": ""0"",
                ""score"": ""31"",
                ""rushDefenseRank"": ""6"",
                ""passOffenseRank"": ""5"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""4"",
                ""passDefenseRank"": ""26"",
                ""id"": ""IND"",
                ""spread"": ""-5.5""
              }
            ]
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1762711200"",
            ""team"": [
              {
                ""rushOffenseRank"": ""1"",
                ""isHome"": ""0"",
                ""spread"": ""-9.5"",
                ""id"": ""BUF"",
                ""passDefenseRank"": ""4"",
                ""rushDefenseRank"": ""23"",
                ""score"": ""13"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""17""
              },
              {
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""20"",
                ""passDefenseRank"": ""12"",
                ""id"": ""MIA"",
                ""spread"": ""9.5"",
                ""hasPossession"": ""0"",
                ""score"": ""30"",
                ""rushDefenseRank"": ""25"",
                ""passOffenseRank"": ""23"",
                ""inRedZone"": ""0""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""24"",
                ""passDefenseRank"": ""6"",
                ""id"": ""CLE"",
                ""spread"": ""1.5"",
                ""score"": ""20"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""12"",
                ""passOffenseRank"": ""31"",
                ""inRedZone"": ""0""
              },
              {
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""5"",
                ""id"": ""NYJ"",
                ""passDefenseRank"": ""7"",
                ""spread"": ""-1.5"",
                ""rushDefenseRank"": ""30"",
                ""hasPossession"": ""0"",
                ""score"": ""27"",
                ""passOffenseRank"": ""32"",
                ""inRedZone"": ""0""
              }
            ],
            ""kickoff"": ""1762711200"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1762711200"",
            ""team"": [
              {
                ""passDefenseRank"": ""24"",
                ""id"": ""NYG"",
                ""spread"": ""3.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""7"",
                ""passOffenseRank"": ""15"",
                ""inRedZone"": ""0"",
                ""score"": ""20"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""29""
              },
              {
                ""spread"": ""-3.5"",
                ""passDefenseRank"": ""27"",
                ""id"": ""CHI"",
                ""rushOffenseRank"": ""2"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""13"",
                ""hasPossession"": ""0"",
                ""score"": ""24"",
                ""rushDefenseRank"": ""24""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1762711200"",
            ""team"": [
              {
                ""rushOffenseRank"": ""12"",
                ""isHome"": ""0"",
                ""spread"": ""-3.5"",
                ""id"": ""BAL"",
                ""passDefenseRank"": ""23"",
                ""rushDefenseRank"": ""21"",
                ""score"": ""27"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""27""
              },
              {
                ""rushDefenseRank"": ""22"",
                ""score"": ""19"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""20"",
                ""rushOffenseRank"": ""25"",
                ""isHome"": ""1"",
                ""spread"": ""3.5"",
                ""id"": ""MIN"",
                ""passDefenseRank"": ""8""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushDefenseRank"": ""1"",
                ""hasPossession"": ""0"",
                ""score"": ""28"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""11"",
                ""rushOffenseRank"": ""14"",
                ""isHome"": ""0"",
                ""spread"": ""2.5"",
                ""id"": ""NEP"",
                ""passDefenseRank"": ""17""
              },
              {
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""26"",
                ""id"": ""TBB"",
                ""passDefenseRank"": ""21"",
                ""spread"": ""-2.5"",
                ""rushDefenseRank"": ""13"",
                ""hasPossession"": ""0"",
                ""score"": ""23"",
                ""passOffenseRank"": ""12"",
                ""inRedZone"": ""0""
              }
            ],
            ""kickoff"": ""1762711200"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushDefenseRank"": ""20"",
                ""score"": ""17"",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""21"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""29"",
                ""id"": ""NOS"",
                ""passDefenseRank"": ""11"",
                ""spread"": ""5.5""
              },
              {
                ""spread"": ""-5.5"",
                ""id"": ""CAR"",
                ""passDefenseRank"": ""18"",
                ""rushOffenseRank"": ""6"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""30"",
                ""rushDefenseRank"": ""11"",
                ""hasPossession"": ""0"",
                ""score"": ""7""
              }
            ],
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1762711200""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1762711200"",
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""21"",
                ""id"": ""JAC"",
                ""passDefenseRank"": ""29"",
                ""spread"": ""1.5"",
                ""rushDefenseRank"": ""3"",
                ""score"": ""29"",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""19"",
                ""inRedZone"": ""0""
              },
              {
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""19"",
                ""id"": ""HOU"",
                ""passDefenseRank"": ""2"",
                ""spread"": ""-1.5"",
                ""rushDefenseRank"": ""4"",
                ""score"": ""36"",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""14"",
                ""inRedZone"": ""0""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""team"": [
              {
                ""passOffenseRank"": ""16"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""18"",
                ""score"": ""22"",
                ""hasPossession"": ""0"",
                ""id"": ""ARI"",
                ""passDefenseRank"": ""22"",
                ""spread"": ""6.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""22""
              },
              {
                ""spread"": ""-6.5"",
                ""passDefenseRank"": ""15"",
                ""id"": ""SEA"",
                ""rushOffenseRank"": ""17"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""4"",
                ""score"": ""44"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""2""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1762722300"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""team"": [
              {
                ""rushOffenseRank"": ""3"",
                ""isHome"": ""0"",
                ""spread"": ""-8.5"",
                ""id"": ""DET"",
                ""passDefenseRank"": ""13"",
                ""rushDefenseRank"": ""8"",
                ""hasPossession"": ""0"",
                ""score"": ""44"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""9""
              },
              {
                ""passOffenseRank"": ""26"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""27"",
                ""hasPossession"": ""0"",
                ""score"": ""22"",
                ""id"": ""WAS"",
                ""passDefenseRank"": ""31"",
                ""spread"": ""8.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""10""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1762723500""
          },
          {
            ""kickoff"": ""1762723500"",
            ""gameSecondsRemaining"": ""0"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""spread"": ""-3.5"",
                ""passDefenseRank"": ""20"",
                ""id"": ""LAR"",
                ""rushOffenseRank"": ""16"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""2"",
                ""hasPossession"": ""0"",
                ""score"": ""42"",
                ""rushDefenseRank"": ""7""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""3"",
                ""rushDefenseRank"": ""17"",
                ""hasPossession"": ""0"",
                ""score"": ""26"",
                ""spread"": ""3.5"",
                ""id"": ""SFO"",
                ""passDefenseRank"": ""25"",
                ""rushOffenseRank"": ""27"",
                ""isHome"": ""1""
              }
            ]
          },
          {
            ""team"": [
              {
                ""rushOffenseRank"": ""30"",
                ""isHome"": ""0"",
                ""spread"": ""3"",
                ""passDefenseRank"": ""32"",
                ""id"": ""PIT"",
                ""score"": ""10"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""9"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""25""
              },
              {
                ""passOffenseRank"": ""10"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""15"",
                ""hasPossession"": ""0"",
                ""score"": ""25"",
                ""id"": ""LAC"",
                ""passDefenseRank"": ""3"",
                ""spread"": ""-3.0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""8""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1762737600""
          },
          {
            ""kickoff"": ""1762823700"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""passOffenseRank"": ""24"",
                ""inRedZone"": ""0"",
                ""score"": ""10"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""19"",
                ""passDefenseRank"": ""16"",
                ""id"": ""PHI"",
                ""spread"": ""2.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""23""
              },
              {
                ""rushDefenseRank"": ""10"",
                ""score"": ""7"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""8"",
                ""rushOffenseRank"": ""18"",
                ""isHome"": ""1"",
                ""spread"": ""-2.5"",
                ""id"": ""GBP"",
                ""passDefenseRank"": ""10""
              }
            ],
            ""status"": ""FINAL""
          }
        ],
        ""lastUpdate"": ""1766140832"",
        ""week"": ""10""
      },
      {
        ""lastUpdate"": ""1766140832"",
        ""week"": ""11"",
        ""matchup"": [
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""spread"": ""11.5"",
                ""id"": ""NYJ"",
                ""passDefenseRank"": ""10"",
                ""rushOffenseRank"": ""5"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""32"",
                ""rushDefenseRank"": ""26"",
                ""hasPossession"": ""0"",
                ""score"": ""14""
              },
              {
                ""id"": ""NEP"",
                ""passDefenseRank"": ""15"",
                ""spread"": ""-11.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""17"",
                ""passOffenseRank"": ""7"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""2"",
                ""hasPossession"": ""0"",
                ""score"": ""27""
              }
            ],
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1763082900""
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushDefenseRank"": ""31"",
                ""hasPossession"": ""0"",
                ""score"": ""13"",
                ""passOffenseRank"": ""26"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""7"",
                ""id"": ""WAS"",
                ""passDefenseRank"": ""29"",
                ""spread"": ""2.5""
              },
              {
                ""id"": ""MIA"",
                ""passDefenseRank"": ""14"",
                ""spread"": ""-2.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""20"",
                ""passOffenseRank"": ""24"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""27"",
                ""hasPossession"": ""0"",
                ""score"": ""16""
              }
            ],
            ""kickoff"": ""1763303400"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""team"": [
              {
                ""passOffenseRank"": ""14"",
                ""inRedZone"": ""0"",
                ""score"": ""32"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""12"",
                ""passDefenseRank"": ""24"",
                ""id"": ""TBB"",
                ""spread"": ""5.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""21""
              },
              {
                ""spread"": ""-5.5"",
                ""id"": ""BUF"",
                ""passDefenseRank"": ""3"",
                ""rushOffenseRank"": ""1"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""16"",
                ""rushDefenseRank"": ""30"",
                ""hasPossession"": ""0"",
                ""score"": ""44""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1763316000"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""kickoff"": ""1763316000"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""score"": ""16"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""3"",
                ""passOffenseRank"": ""13"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""23"",
                ""passDefenseRank"": ""2"",
                ""id"": ""HOU"",
                ""spread"": ""-7.5""
              },
              {
                ""rushOffenseRank"": ""32"",
                ""isHome"": ""1"",
                ""spread"": ""7.5"",
                ""passDefenseRank"": ""21"",
                ""id"": ""TEN"",
                ""hasPossession"": ""0"",
                ""score"": ""13"",
                ""rushDefenseRank"": ""24"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""29""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""kickoff"": ""1763316000"",
            ""gameSecondsRemaining"": ""0"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""passOffenseRank"": ""15"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""6"",
                ""rushDefenseRank"": ""19"",
                ""passDefenseRank"": ""1"",
                ""id"": ""LAC"",
                ""spread"": ""-3"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""16""
              },
              {
                ""rushOffenseRank"": ""13"",
                ""isHome"": ""1"",
                ""spread"": ""3.0"",
                ""id"": ""JAC"",
                ""passDefenseRank"": ""27"",
                ""rushDefenseRank"": ""1"",
                ""hasPossession"": ""0"",
                ""score"": ""35"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""21""
              }
            ]
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""9"",
                ""rushDefenseRank"": ""32"",
                ""score"": ""12"",
                ""hasPossession"": ""0"",
                ""spread"": ""5.5"",
                ""id"": ""CIN"",
                ""passDefenseRank"": ""28"",
                ""rushOffenseRank"": ""30"",
                ""isHome"": ""0""
              },
              {
                ""passDefenseRank"": ""32"",
                ""id"": ""PIT"",
                ""spread"": ""-5.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""28"",
                ""passOffenseRank"": ""23"",
                ""inRedZone"": ""0"",
                ""score"": ""34"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""7""
              }
            ],
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1763316000""
          },
          {
            ""kickoff"": ""1763316000"",
            ""gameSecondsRemaining"": ""0"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""passOffenseRank"": ""11"",
                ""inRedZone"": ""0"",
                ""score"": ""27"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""11"",
                ""passDefenseRank"": ""9"",
                ""id"": ""GBP"",
                ""spread"": ""-7.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""18""
              },
              {
                ""id"": ""NYG"",
                ""passDefenseRank"": ""22"",
                ""spread"": ""7.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""8"",
                ""passOffenseRank"": ""18"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""29"",
                ""hasPossession"": ""0"",
                ""score"": ""20""
              }
            ]
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""2"",
                ""id"": ""CHI"",
                ""passDefenseRank"": ""25"",
                ""spread"": ""3"",
                ""rushDefenseRank"": ""25"",
                ""score"": ""19"",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""12"",
                ""inRedZone"": ""0""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""22"",
                ""rushDefenseRank"": ""22"",
                ""hasPossession"": ""0"",
                ""score"": ""17"",
                ""spread"": ""-3.0"",
                ""id"": ""MIN"",
                ""passDefenseRank"": ""6"",
                ""rushOffenseRank"": ""25"",
                ""isHome"": ""1""
              }
            ],
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1763316000""
          },
          {
            ""kickoff"": ""1763316000"",
            ""gameSecondsRemaining"": ""0"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""25"",
                ""hasPossession"": ""0"",
                ""score"": ""30"",
                ""rushDefenseRank"": ""13"",
                ""spread"": ""3.5"",
                ""passDefenseRank"": ""19"",
                ""id"": ""CAR"",
                ""rushOffenseRank"": ""9"",
                ""isHome"": ""0""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""19"",
                ""hasPossession"": ""0"",
                ""score"": ""27"",
                ""rushDefenseRank"": ""28"",
                ""spread"": ""-3.5"",
                ""passDefenseRank"": ""7"",
                ""id"": ""ATL"",
                ""rushOffenseRank"": ""10"",
                ""isHome"": ""1""
              }
            ]
          },
          {
            ""team"": [
              {
                ""score"": ""41"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""14"",
                ""passOffenseRank"": ""3"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""27"",
                ""passDefenseRank"": ""30"",
                ""id"": ""SFO"",
                ""spread"": ""-2.5""
              },
              {
                ""rushOffenseRank"": ""26"",
                ""isHome"": ""1"",
                ""spread"": ""2.5"",
                ""passDefenseRank"": ""20"",
                ""id"": ""ARI"",
                ""hasPossession"": ""0"",
                ""score"": ""22"",
                ""rushDefenseRank"": ""16"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""10""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1763327100"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1763327100"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""hasPossession"": ""0"",
                ""score"": ""19"",
                ""rushDefenseRank"": ""5"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""2"",
                ""rushOffenseRank"": ""12"",
                ""isHome"": ""0"",
                ""spread"": ""2.5"",
                ""passDefenseRank"": ""13"",
                ""id"": ""SEA""
              },
              {
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""15"",
                ""id"": ""LAR"",
                ""passDefenseRank"": ""23"",
                ""spread"": ""-2.5"",
                ""rushDefenseRank"": ""8"",
                ""score"": ""21"",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""5"",
                ""inRedZone"": ""0""
              }
            ]
          },
          {
            ""team"": [
              {
                ""rushDefenseRank"": ""21"",
                ""score"": ""23"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""28"",
                ""rushOffenseRank"": ""6"",
                ""isHome"": ""0"",
                ""spread"": ""-8.5"",
                ""id"": ""BAL"",
                ""passDefenseRank"": ""17""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""31"",
                ""hasPossession"": ""0"",
                ""score"": ""16"",
                ""rushDefenseRank"": ""17"",
                ""spread"": ""8.5"",
                ""passDefenseRank"": ""4"",
                ""id"": ""CLE"",
                ""rushOffenseRank"": ""24"",
                ""isHome"": ""1""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1763328300"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1763328300"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""6"",
                ""rushDefenseRank"": ""9"",
                ""hasPossession"": ""0"",
                ""score"": ""19"",
                ""spread"": ""-3.5"",
                ""id"": ""KCC"",
                ""passDefenseRank"": ""5"",
                ""rushOffenseRank"": ""19"",
                ""isHome"": ""0""
              },
              {
                ""score"": ""22"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""4"",
                ""passOffenseRank"": ""17"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""14"",
                ""passDefenseRank"": ""11"",
                ""id"": ""DEN"",
                ""spread"": ""3.5""
              }
            ]
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1763342400"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""score"": ""9"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""10"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""8"",
                ""rushOffenseRank"": ""4"",
                ""isHome"": ""0"",
                ""spread"": ""1.5"",
                ""passDefenseRank"": ""8"",
                ""id"": ""DET""
              },
              {
                ""passDefenseRank"": ""18"",
                ""id"": ""PHI"",
                ""spread"": ""-1.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""22"",
                ""passOffenseRank"": ""27"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""16"",
                ""rushDefenseRank"": ""18""
              }
            ]
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1763428500"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""11"",
                ""id"": ""DAL"",
                ""passDefenseRank"": ""31"",
                ""spread"": ""-3.5"",
                ""rushDefenseRank"": ""23"",
                ""hasPossession"": ""0"",
                ""score"": ""33"",
                ""passOffenseRank"": ""1"",
                ""inRedZone"": ""0""
              },
              {
                ""hasPossession"": ""0"",
                ""score"": ""16"",
                ""rushDefenseRank"": ""15"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""30"",
                ""rushOffenseRank"": ""31"",
                ""isHome"": ""1"",
                ""spread"": ""3.5"",
                ""passDefenseRank"": ""16"",
                ""id"": ""LVR""
              }
            ]
          }
        ]
      },
      {
        ""matchup"": [
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushOffenseRank"": ""1"",
                ""isHome"": ""0"",
                ""spread"": ""-5.5"",
                ""id"": ""BUF"",
                ""passDefenseRank"": ""2"",
                ""rushDefenseRank"": ""28"",
                ""score"": ""19"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""16""
              },
              {
                ""passDefenseRank"": ""3"",
                ""id"": ""HOU"",
                ""spread"": ""5.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""20"",
                ""passOffenseRank"": ""15"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""23"",
                ""rushDefenseRank"": ""5""
              }
            ],
            ""kickoff"": ""1763687700"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1763920800"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushOffenseRank"": ""16"",
                ""isHome"": ""0"",
                ""spread"": ""-8.5"",
                ""passDefenseRank"": ""13"",
                ""id"": ""NEP"",
                ""score"": ""26"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""4"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""6""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""10"",
                ""rushDefenseRank"": ""32"",
                ""score"": ""20"",
                ""hasPossession"": ""0"",
                ""spread"": ""8.5"",
                ""id"": ""CIN"",
                ""passDefenseRank"": ""29"",
                ""rushOffenseRank"": ""28"",
                ""isHome"": ""1""
              }
            ]
          },
          {
            ""kickoff"": ""1763920800"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""2"",
                ""score"": ""30"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""2"",
                ""spread"": ""-13.5"",
                ""passDefenseRank"": ""14"",
                ""id"": ""SEA"",
                ""rushOffenseRank"": ""14"",
                ""isHome"": ""0""
              },
              {
                ""rushOffenseRank"": ""30"",
                ""isHome"": ""1"",
                ""spread"": ""13.5"",
                ""passDefenseRank"": ""21"",
                ""id"": ""TEN"",
                ""hasPossession"": ""0"",
                ""score"": ""24"",
                ""rushDefenseRank"": ""24"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""28""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1763920800"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushDefenseRank"": ""8"",
                ""hasPossession"": ""0"",
                ""score"": ""20"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""7"",
                ""rushOffenseRank"": ""4"",
                ""isHome"": ""0"",
                ""spread"": ""3"",
                ""id"": ""IND"",
                ""passDefenseRank"": ""28""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""3"",
                ""rushDefenseRank"": ""7"",
                ""hasPossession"": ""0"",
                ""score"": ""23"",
                ""spread"": ""-3.0"",
                ""id"": ""KCC"",
                ""passDefenseRank"": ""6"",
                ""rushOffenseRank"": ""13"",
                ""isHome"": ""1""
              }
            ]
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""24"",
                ""score"": ""28"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""6"",
                ""spread"": ""3"",
                ""passDefenseRank"": ""32"",
                ""id"": ""PIT"",
                ""rushOffenseRank"": ""22"",
                ""isHome"": ""0""
              },
              {
                ""rushOffenseRank"": ""3"",
                ""isHome"": ""1"",
                ""spread"": ""-3.0"",
                ""id"": ""CHI"",
                ""passDefenseRank"": ""24"",
                ""rushDefenseRank"": ""27"",
                ""hasPossession"": ""0"",
                ""score"": ""31"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""11""
              }
            ],
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1763920800""
          },
          {
            ""kickoff"": ""1763920800"",
            ""gameSecondsRemaining"": ""0"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""passDefenseRank"": ""23"",
                ""id"": ""NYG"",
                ""spread"": ""10.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""7"",
                ""passOffenseRank"": ""12"",
                ""inRedZone"": ""0"",
                ""score"": ""27"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""31""
              },
              {
                ""id"": ""DET"",
                ""passDefenseRank"": ""16"",
                ""spread"": ""-10.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""2"",
                ""passOffenseRank"": ""8"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""13"",
                ""hasPossession"": ""0"",
                ""score"": ""34""
              }
            ]
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1763920800"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushDefenseRank"": ""23"",
                ""score"": ""6"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""27"",
                ""rushOffenseRank"": ""23"",
                ""isHome"": ""0"",
                ""spread"": ""6.5"",
                ""id"": ""MIN"",
                ""passDefenseRank"": ""7""
              },
              {
                ""spread"": ""-6.5"",
                ""passDefenseRank"": ""5"",
                ""id"": ""GBP"",
                ""rushOffenseRank"": ""13"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""13"",
                ""hasPossession"": ""0"",
                ""score"": ""23"",
                ""rushDefenseRank"": ""10""
              }
            ]
          },
          {
            ""kickoff"": ""1763920800"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""rushOffenseRank"": ""5"",
                ""isHome"": ""0"",
                ""spread"": ""13.5"",
                ""id"": ""NYJ"",
                ""passDefenseRank"": ""8"",
                ""rushDefenseRank"": ""25"",
                ""hasPossession"": ""0"",
                ""score"": ""10"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""32""
              },
              {
                ""rushOffenseRank"": ""8"",
                ""isHome"": ""1"",
                ""spread"": ""-13.5"",
                ""passDefenseRank"": ""17"",
                ""id"": ""BAL"",
                ""hasPossession"": ""0"",
                ""score"": ""23"",
                ""rushDefenseRank"": ""20"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""30""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1763931900"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushOffenseRank"": ""24"",
                ""isHome"": ""0"",
                ""spread"": ""3"",
                ""id"": ""CLE"",
                ""passDefenseRank"": ""4"",
                ""rushDefenseRank"": ""15"",
                ""score"": ""24"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""31""
              },
              {
                ""spread"": ""-3.0"",
                ""id"": ""LVR"",
                ""passDefenseRank"": ""15"",
                ""rushOffenseRank"": ""29"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""29"",
                ""rushDefenseRank"": ""14"",
                ""hasPossession"": ""0"",
                ""score"": ""10""
              }
            ]
          },
          {
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""19"",
                ""rushDefenseRank"": ""1"",
                ""score"": ""27"",
                ""hasPossession"": ""0"",
                ""spread"": ""-2.5"",
                ""id"": ""JAC"",
                ""passDefenseRank"": ""26"",
                ""rushOffenseRank"": ""11"",
                ""isHome"": ""0""
              },
              {
                ""hasPossession"": ""0"",
                ""score"": ""24"",
                ""rushDefenseRank"": ""18"",
                ""passOffenseRank"": ""9"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""26"",
                ""passDefenseRank"": ""20"",
                ""id"": ""ARI"",
                ""spread"": ""2.5""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1763931900"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""kickoff"": ""1763933100"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""passOffenseRank"": ""22"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""17"",
                ""score"": ""21"",
                ""hasPossession"": ""0"",
                ""id"": ""PHI"",
                ""passDefenseRank"": ""22"",
                ""spread"": ""-3.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""21""
              },
              {
                ""passDefenseRank"": ""31"",
                ""id"": ""DAL"",
                ""spread"": ""3.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""12"",
                ""passOffenseRank"": ""1"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""24"",
                ""rushDefenseRank"": ""22""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""21"",
                ""hasPossession"": ""0"",
                ""score"": ""24"",
                ""rushDefenseRank"": ""26"",
                ""spread"": ""1.5"",
                ""passDefenseRank"": ""9"",
                ""id"": ""ATL"",
                ""rushOffenseRank"": ""9"",
                ""isHome"": ""0""
              },
              {
                ""passDefenseRank"": ""11"",
                ""id"": ""NOS"",
                ""spread"": ""-1.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""27"",
                ""passOffenseRank"": ""20"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""10"",
                ""rushDefenseRank"": ""21""
              }
            ],
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1763933100""
          },
          {
            ""team"": [
              {
                ""passDefenseRank"": ""25"",
                ""id"": ""TBB"",
                ""spread"": ""6.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""19"",
                ""passOffenseRank"": ""18"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""7"",
                ""rushDefenseRank"": ""9""
              },
              {
                ""rushOffenseRank"": ""18"",
                ""isHome"": ""1"",
                ""spread"": ""-6.5"",
                ""passDefenseRank"": ""19"",
                ""id"": ""LAR"",
                ""hasPossession"": ""0"",
                ""score"": ""34"",
                ""rushDefenseRank"": ""11"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""4""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1763947200"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""kickoff"": ""1764033300"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""spread"": ""7"",
                ""passDefenseRank"": ""18"",
                ""id"": ""CAR"",
                ""rushOffenseRank"": ""10"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""26"",
                ""hasPossession"": ""0"",
                ""score"": ""9"",
                ""rushDefenseRank"": ""16""
              },
              {
                ""rushDefenseRank"": ""12"",
                ""score"": ""20"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""5"",
                ""rushOffenseRank"": ""25"",
                ""isHome"": ""1"",
                ""spread"": ""-7.0"",
                ""id"": ""SFO"",
                ""passDefenseRank"": ""27""
              }
            ],
            ""status"": ""FINAL""
          }
        ],
        ""lastUpdate"": ""1766140832"",
        ""week"": ""12""
      },
      {
        ""matchup"": [
          {
            ""team"": [
              {
                ""rushOffenseRank"": ""13"",
                ""isHome"": ""0"",
                ""spread"": ""2.5"",
                ""id"": ""GBP"",
                ""passDefenseRank"": ""6"",
                ""rushDefenseRank"": ""9"",
                ""hasPossession"": ""0"",
                ""score"": ""31"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""11""
              },
              {
                ""rushOffenseRank"": ""3"",
                ""isHome"": ""1"",
                ""spread"": ""-2.5"",
                ""passDefenseRank"": ""17"",
                ""id"": ""DET"",
                ""score"": ""24"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""11"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""7""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1764266400""
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""2"",
                ""score"": ""28"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""8"",
                ""spread"": ""-3.5"",
                ""passDefenseRank"": ""12"",
                ""id"": ""KCC"",
                ""rushOffenseRank"": ""15"",
                ""isHome"": ""0""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""1"",
                ""score"": ""31"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""20"",
                ""spread"": ""3.5"",
                ""passDefenseRank"": ""31"",
                ""id"": ""DAL"",
                ""rushOffenseRank"": ""12"",
                ""isHome"": ""1""
              }
            ],
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1764279000""
          },
          {
            ""team"": [
              {
                ""passDefenseRank"": ""29"",
                ""id"": ""CIN"",
                ""spread"": ""7"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""28"",
                ""passOffenseRank"": ""10"",
                ""inRedZone"": ""0"",
                ""score"": ""32"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""32""
              },
              {
                ""passOffenseRank"": ""27"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""14"",
                ""rushDefenseRank"": ""19"",
                ""passDefenseRank"": ""19"",
                ""id"": ""BAL"",
                ""spread"": ""-7.0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""9""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1764292800""
          },
          {
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""14"",
                ""score"": ""24"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""27"",
                ""spread"": ""7"",
                ""passDefenseRank"": ""24"",
                ""id"": ""CHI"",
                ""rushOffenseRank"": ""2"",
                ""isHome"": ""0""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""22"",
                ""rushDefenseRank"": ""24"",
                ""hasPossession"": ""0"",
                ""score"": ""15"",
                ""spread"": ""-7.0"",
                ""id"": ""PHI"",
                ""passDefenseRank"": ""21"",
                ""rushOffenseRank"": ""23"",
                ""isHome"": ""1""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1764360000"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""22"",
                ""id"": ""HOU"",
                ""passDefenseRank"": ""3"",
                ""spread"": ""4.5"",
                ""rushDefenseRank"": ""4"",
                ""score"": ""20"",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""13"",
                ""inRedZone"": ""0""
              },
              {
                ""rushOffenseRank"": ""4"",
                ""isHome"": ""1"",
                ""spread"": ""-4.5"",
                ""id"": ""IND"",
                ""passDefenseRank"": ""30"",
                ""rushDefenseRank"": ""7"",
                ""score"": ""16"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""9""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1764525600"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""passDefenseRank"": ""8"",
                ""id"": ""NOS"",
                ""spread"": ""6"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""29"",
                ""passOffenseRank"": ""19"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""17"",
                ""rushDefenseRank"": ""21""
              },
              {
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""14"",
                ""passDefenseRank"": ""13"",
                ""id"": ""MIA"",
                ""spread"": ""-6.0"",
                ""score"": ""21"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""28"",
                ""passOffenseRank"": ""25"",
                ""inRedZone"": ""0""
              }
            ],
            ""kickoff"": ""1764525600"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""team"": [
              {
                ""rushOffenseRank"": ""7"",
                ""isHome"": ""0"",
                ""spread"": ""-2.5"",
                ""id"": ""ATL"",
                ""passDefenseRank"": ""7"",
                ""rushDefenseRank"": ""26"",
                ""score"": ""24"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""21""
              },
              {
                ""rushDefenseRank"": ""29"",
                ""score"": ""27"",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""32"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""6"",
                ""id"": ""NYJ"",
                ""passDefenseRank"": ""9"",
                ""spread"": ""2.5""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1764525600""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1764525600"",
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""8"",
                ""hasPossession"": ""0"",
                ""score"": ""26"",
                ""rushDefenseRank"": ""10"",
                ""spread"": ""-6"",
                ""passDefenseRank"": ""26"",
                ""id"": ""SFO"",
                ""rushOffenseRank"": ""26"",
                ""isHome"": ""0""
              },
              {
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""24"",
                ""passDefenseRank"": ""5"",
                ""id"": ""CLE"",
                ""spread"": ""6.0"",
                ""hasPossession"": ""0"",
                ""score"": ""8"",
                ""rushDefenseRank"": ""12"",
                ""passOffenseRank"": ""31"",
                ""inRedZone"": ""0""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1764525600"",
            ""team"": [
              {
                ""hasPossession"": ""0"",
                ""score"": ""25"",
                ""rushDefenseRank"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""20"",
                ""rushOffenseRank"": ""20"",
                ""isHome"": ""0"",
                ""spread"": ""-6.5"",
                ""passDefenseRank"": ""25"",
                ""id"": ""JAC""
              },
              {
                ""id"": ""TEN"",
                ""passDefenseRank"": ""22"",
                ""spread"": ""6.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""30"",
                ""passOffenseRank"": ""29"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""22"",
                ""score"": ""3"",
                ""hasPossession"": ""0""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""team"": [
              {
                ""spread"": ""3"",
                ""id"": ""ARI"",
                ""passDefenseRank"": ""20"",
                ""rushOffenseRank"": ""27"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""5"",
                ""rushDefenseRank"": ""17"",
                ""hasPossession"": ""0"",
                ""score"": ""17""
              },
              {
                ""spread"": ""-3.0"",
                ""id"": ""TBB"",
                ""passDefenseRank"": ""27"",
                ""rushOffenseRank"": ""21"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""17"",
                ""rushDefenseRank"": ""6"",
                ""hasPossession"": ""0"",
                ""score"": ""20""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1764525600""
          },
          {
            ""kickoff"": ""1764525600"",
            ""gameSecondsRemaining"": ""0"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""hasPossession"": ""0"",
                ""score"": ""28"",
                ""rushDefenseRank"": ""13"",
                ""passOffenseRank"": ""3"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""18"",
                ""passDefenseRank"": ""16"",
                ""id"": ""LAR"",
                ""spread"": ""-10.5""
              },
              {
                ""spread"": ""10.5"",
                ""id"": ""CAR"",
                ""passDefenseRank"": ""18"",
                ""rushOffenseRank"": ""10"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""24"",
                ""rushDefenseRank"": ""16"",
                ""score"": ""31"",
                ""hasPossession"": ""0""
              }
            ]
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushDefenseRank"": ""23"",
                ""score"": ""0"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""28"",
                ""rushOffenseRank"": ""25"",
                ""isHome"": ""0"",
                ""spread"": ""10.5"",
                ""id"": ""MIN"",
                ""passDefenseRank"": ""4""
              },
              {
                ""rushOffenseRank"": ""16"",
                ""isHome"": ""1"",
                ""spread"": ""-10.5"",
                ""passDefenseRank"": ""10"",
                ""id"": ""SEA"",
                ""score"": ""26"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""2"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""6""
              }
            ],
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1764536700""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1764537900"",
            ""team"": [
              {
                ""spread"": ""-3.5"",
                ""id"": ""BUF"",
                ""passDefenseRank"": ""1"",
                ""rushOffenseRank"": ""1"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""18"",
                ""rushDefenseRank"": ""25"",
                ""hasPossession"": ""0"",
                ""score"": ""26""
              },
              {
                ""hasPossession"": ""0"",
                ""score"": ""7"",
                ""rushDefenseRank"": ""15"",
                ""passOffenseRank"": ""26"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""25"",
                ""passDefenseRank"": ""28"",
                ""id"": ""PIT"",
                ""spread"": ""3.5""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""team"": [
              {
                ""passOffenseRank"": ""30"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""18"",
                ""hasPossession"": ""0"",
                ""score"": ""14"",
                ""id"": ""LVR"",
                ""passDefenseRank"": ""15"",
                ""spread"": ""10"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""30""
              },
              {
                ""spread"": ""-10.0"",
                ""id"": ""LAC"",
                ""passDefenseRank"": ""2"",
                ""rushOffenseRank"": ""11"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""16"",
                ""rushDefenseRank"": ""14"",
                ""score"": ""31"",
                ""hasPossession"": ""0""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1764537900"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1764552000"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""spread"": ""-6.5"",
                ""id"": ""DEN"",
                ""passDefenseRank"": ""14"",
                ""rushOffenseRank"": ""19"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""12"",
                ""rushDefenseRank"": ""5"",
                ""hasPossession"": ""0"",
                ""score"": ""27""
              },
              {
                ""rushOffenseRank"": ""5"",
                ""isHome"": ""1"",
                ""spread"": ""6.5"",
                ""passDefenseRank"": ""32"",
                ""id"": ""WAS"",
                ""score"": ""26"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""30"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""23""
              }
            ]
          },
          {
            ""kickoff"": ""1764638100"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""hasPossession"": ""0"",
                ""score"": ""15"",
                ""rushDefenseRank"": ""31"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""15"",
                ""rushOffenseRank"": ""8"",
                ""isHome"": ""0"",
                ""spread"": ""7.5"",
                ""passDefenseRank"": ""23"",
                ""id"": ""NYG""
              },
              {
                ""passOffenseRank"": ""4"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""3"",
                ""score"": ""33"",
                ""hasPossession"": ""0"",
                ""id"": ""NEP"",
                ""passDefenseRank"": ""11"",
                ""spread"": ""-7.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""17""
              }
            ],
            ""status"": ""FINAL""
          }
        ],
        ""lastUpdate"": ""1766140832"",
        ""week"": ""13""
      },
      {
        ""week"": ""14"",
        ""lastUpdate"": ""1766140832"",
        ""matchup"": [
          {
            ""kickoff"": ""1764897300"",
            ""gameSecondsRemaining"": ""0"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""hasPossession"": ""0"",
                ""score"": ""30"",
                ""rushDefenseRank"": ""19"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""1"",
                ""rushOffenseRank"": ""16"",
                ""isHome"": ""0"",
                ""spread"": ""3"",
                ""passDefenseRank"": ""32"",
                ""id"": ""DAL""
              },
              {
                ""score"": ""44"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""10"",
                ""passOffenseRank"": ""6"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""3"",
                ""passDefenseRank"": ""20"",
                ""id"": ""DET"",
                ""spread"": ""-3.0""
              }
            ]
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushOffenseRank"": ""29"",
                ""isHome"": ""0"",
                ""spread"": ""6"",
                ""passDefenseRank"": ""29"",
                ""id"": ""CIN"",
                ""hasPossession"": ""0"",
                ""score"": ""34"",
                ""rushDefenseRank"": ""31"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""9""
              },
              {
                ""passOffenseRank"": ""16"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""39"",
                ""rushDefenseRank"": ""21"",
                ""passDefenseRank"": ""3"",
                ""id"": ""BUF"",
                ""spread"": ""-6.0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""1""
              }
            ],
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1765130400""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1765130400"",
            ""team"": [
              {
                ""rushOffenseRank"": ""5"",
                ""isHome"": ""0"",
                ""spread"": ""-2.5"",
                ""passDefenseRank"": ""13"",
                ""id"": ""MIA"",
                ""hasPossession"": ""0"",
                ""score"": ""34"",
                ""rushDefenseRank"": ""24"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""26""
              },
              {
                ""rushOffenseRank"": ""13"",
                ""isHome"": ""1"",
                ""spread"": ""2.5"",
                ""passDefenseRank"": ""8"",
                ""id"": ""NYJ"",
                ""hasPossession"": ""0"",
                ""score"": ""10"",
                ""rushDefenseRank"": ""29"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""32""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushOffenseRank"": ""30"",
                ""isHome"": ""0"",
                ""spread"": ""4.5"",
                ""passDefenseRank"": ""25"",
                ""id"": ""TEN"",
                ""hasPossession"": ""0"",
                ""score"": ""31"",
                ""rushDefenseRank"": ""18"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""30""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""31"",
                ""rushDefenseRank"": ""16"",
                ""hasPossession"": ""0"",
                ""score"": ""29"",
                ""spread"": ""-4.5"",
                ""id"": ""CLE"",
                ""passDefenseRank"": ""5"",
                ""rushOffenseRank"": ""24"",
                ""isHome"": ""1""
              }
            ],
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1765130400""
          },
          {
            ""kickoff"": ""1765130400"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""rushDefenseRank"": ""7"",
                ""hasPossession"": ""0"",
                ""score"": ""19"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""10"",
                ""rushOffenseRank"": ""7"",
                ""isHome"": ""0"",
                ""spread"": ""-1.5"",
                ""id"": ""IND"",
                ""passDefenseRank"": ""31""
              },
              {
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""20"",
                ""id"": ""JAC"",
                ""passDefenseRank"": ""26"",
                ""spread"": ""1.5"",
                ""rushDefenseRank"": ""1"",
                ""hasPossession"": ""0"",
                ""score"": ""36"",
                ""passOffenseRank"": ""17"",
                ""inRedZone"": ""0""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""kickoff"": ""1765130400"",
            ""gameSecondsRemaining"": ""0"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushOffenseRank"": ""6"",
                ""isHome"": ""0"",
                ""spread"": ""-1.5"",
                ""passDefenseRank"": ""30"",
                ""id"": ""WAS"",
                ""score"": ""0"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""28"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""25""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""28"",
                ""hasPossession"": ""0"",
                ""score"": ""31"",
                ""rushDefenseRank"": ""22"",
                ""spread"": ""1.5"",
                ""passDefenseRank"": ""4"",
                ""id"": ""MIN"",
                ""rushOffenseRank"": ""23"",
                ""isHome"": ""1""
              }
            ]
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1765130400"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""26"",
                ""id"": ""NOS"",
                ""passDefenseRank"": ""7"",
                ""spread"": ""8.5"",
                ""rushDefenseRank"": ""23"",
                ""score"": ""24"",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""22"",
                ""inRedZone"": ""0""
              },
              {
                ""rushDefenseRank"": ""9"",
                ""score"": ""20"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""20"",
                ""rushOffenseRank"": ""19"",
                ""isHome"": ""1"",
                ""spread"": ""-8.5"",
                ""id"": ""TBB"",
                ""passDefenseRank"": ""24""
              }
            ]
          },
          {
            ""kickoff"": ""1765130400"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""14"",
                ""id"": ""SEA"",
                ""passDefenseRank"": ""9"",
                ""spread"": ""-7.5"",
                ""rushDefenseRank"": ""2"",
                ""hasPossession"": ""0"",
                ""score"": ""37"",
                ""passOffenseRank"": ""7"",
                ""inRedZone"": ""0""
              },
              {
                ""rushDefenseRank"": ""26"",
                ""score"": ""9"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""21"",
                ""rushOffenseRank"": ""10"",
                ""isHome"": ""1"",
                ""spread"": ""7.5"",
                ""id"": ""ATL"",
                ""passDefenseRank"": ""10""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""kickoff"": ""1765130400"",
            ""gameSecondsRemaining"": ""0"",
            ""team"": [
              {
                ""passOffenseRank"": ""23"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""19"",
                ""score"": ""27"",
                ""hasPossession"": ""0"",
                ""id"": ""PIT"",
                ""passDefenseRank"": ""28"",
                ""spread"": ""5.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""28""
              },
              {
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""4"",
                ""passDefenseRank"": ""19"",
                ""id"": ""BAL"",
                ""spread"": ""-5.5"",
                ""hasPossession"": ""0"",
                ""score"": ""22"",
                ""rushDefenseRank"": ""15"",
                ""passOffenseRank"": ""27"",
                ""inRedZone"": ""0""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""12"",
                ""rushDefenseRank"": ""3"",
                ""score"": ""24"",
                ""hasPossession"": ""0"",
                ""spread"": ""-7.5"",
                ""id"": ""DEN"",
                ""passDefenseRank"": ""14"",
                ""rushOffenseRank"": ""17"",
                ""isHome"": ""0""
              },
              {
                ""spread"": ""7.5"",
                ""passDefenseRank"": ""15"",
                ""id"": ""LVR"",
                ""rushOffenseRank"": ""31"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""29"",
                ""score"": ""17"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""17""
              }
            ],
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1765141500""
          },
          {
            ""team"": [
              {
                ""score"": ""45"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""8"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""2"",
                ""rushOffenseRank"": ""9"",
                ""isHome"": ""0"",
                ""spread"": ""-8.5"",
                ""passDefenseRank"": ""18"",
                ""id"": ""LAR""
              },
              {
                ""passOffenseRank"": ""4"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""17"",
                ""rushDefenseRank"": ""20"",
                ""passDefenseRank"": ""21"",
                ""id"": ""ARI"",
                ""spread"": ""8.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""27""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1765142700"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1765142700"",
            ""team"": [
              {
                ""passOffenseRank"": ""15"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""27"",
                ""hasPossession"": ""0"",
                ""score"": ""21"",
                ""id"": ""CHI"",
                ""passDefenseRank"": ""22"",
                ""spread"": ""6.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""2""
              },
              {
                ""spread"": ""-6.5"",
                ""passDefenseRank"": ""6"",
                ""id"": ""GBP"",
                ""rushOffenseRank"": ""15"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""11"",
                ""hasPossession"": ""0"",
                ""score"": ""28"",
                ""rushDefenseRank"": ""12""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""team"": [
              {
                ""rushOffenseRank"": ""22"",
                ""isHome"": ""0"",
                ""spread"": ""3.5"",
                ""passDefenseRank"": ""2"",
                ""id"": ""HOU"",
                ""hasPossession"": ""0"",
                ""score"": ""20"",
                ""rushDefenseRank"": ""5"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""13""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""3"",
                ""hasPossession"": ""0"",
                ""score"": ""10"",
                ""rushDefenseRank"": ""6"",
                ""spread"": ""-3.5"",
                ""passDefenseRank"": ""11"",
                ""id"": ""KCC"",
                ""rushOffenseRank"": ""14"",
                ""isHome"": ""1""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1765156800""
          },
          {
            ""team"": [
              {
                ""hasPossession"": ""0"",
                ""score"": ""19"",
                ""rushDefenseRank"": ""25"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""19"",
                ""rushOffenseRank"": ""21"",
                ""isHome"": ""0"",
                ""spread"": ""-2.5"",
                ""passDefenseRank"": ""16"",
                ""id"": ""PHI""
              },
              {
                ""passOffenseRank"": ""18"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""13"",
                ""hasPossession"": ""0"",
                ""score"": ""22"",
                ""id"": ""LAC"",
                ""passDefenseRank"": ""1"",
                ""spread"": ""2.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""8""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1765242900""
          }
        ]
      },
      {
        ""matchup"": [
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1765502100"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""9"",
                ""passDefenseRank"": ""13"",
                ""id"": ""ATL"",
                ""spread"": ""4.5"",
                ""hasPossession"": ""0"",
                ""score"": ""29"",
                ""rushDefenseRank"": ""26"",
                ""passOffenseRank"": ""16"",
                ""inRedZone"": ""0""
              },
              {
                ""spread"": ""-4.5"",
                ""passDefenseRank"": ""28"",
                ""id"": ""TBB"",
                ""rushOffenseRank"": ""21"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""19"",
                ""score"": ""28"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""9""
              }
            ]
          },
          {
            ""team"": [
              {
                ""score"": ""35"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""28"",
                ""passOffenseRank"": ""17"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""1"",
                ""passDefenseRank"": ""1"",
                ""id"": ""BUF"",
                ""spread"": ""-1.5""
              },
              {
                ""rushOffenseRank"": ""8"",
                ""isHome"": ""1"",
                ""spread"": ""1.5"",
                ""id"": ""NEP"",
                ""passDefenseRank"": ""9"",
                ""rushDefenseRank"": ""6"",
                ""hasPossession"": ""0"",
                ""score"": ""31"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""7""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1765735200"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""team"": [
              {
                ""spread"": ""-2.5"",
                ""passDefenseRank"": ""18"",
                ""id"": ""BAL"",
                ""rushOffenseRank"": ""3"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""27"",
                ""hasPossession"": ""0"",
                ""score"": ""24"",
                ""rushDefenseRank"": ""15""
              },
              {
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""30"",
                ""passDefenseRank"": ""27"",
                ""id"": ""CIN"",
                ""spread"": ""2.5"",
                ""score"": ""0"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""32"",
                ""passOffenseRank"": ""8"",
                ""inRedZone"": ""0""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1765735200""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1765735200"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushDefenseRank"": ""30"",
                ""hasPossession"": ""0"",
                ""score"": ""20"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""31"",
                ""rushOffenseRank"": ""14"",
                ""isHome"": ""0"",
                ""spread"": ""12.5"",
                ""id"": ""NYJ"",
                ""passDefenseRank"": ""14""
              },
              {
                ""passDefenseRank"": ""22"",
                ""id"": ""JAC"",
                ""spread"": ""-12.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""20"",
                ""passOffenseRank"": ""15"",
                ""inRedZone"": ""0"",
                ""score"": ""48"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""1""
              }
            ]
          },
          {
            ""team"": [
              {
                ""spread"": ""4.5"",
                ""id"": ""LAC"",
                ""passDefenseRank"": ""2"",
                ""rushOffenseRank"": ""12"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""18"",
                ""rushDefenseRank"": ""11"",
                ""score"": ""16"",
                ""hasPossession"": ""0""
              },
              {
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""19"",
                ""passDefenseRank"": ""10"",
                ""id"": ""KCC"",
                ""spread"": ""-4.5"",
                ""score"": ""13"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""7"",
                ""passOffenseRank"": ""6"",
                ""inRedZone"": ""0""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1765735200""
          },
          {
            ""kickoff"": ""1765735200"",
            ""gameSecondsRemaining"": ""0"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""id"": ""WAS"",
                ""passDefenseRank"": ""30"",
                ""spread"": ""2.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""5"",
                ""passOffenseRank"": ""23"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""29"",
                ""hasPossession"": ""0"",
                ""score"": ""29""
              },
              {
                ""id"": ""NYG"",
                ""passDefenseRank"": ""23"",
                ""spread"": ""-2.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""7"",
                ""passOffenseRank"": ""13"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""31"",
                ""hasPossession"": ""0"",
                ""score"": ""21""
              }
            ]
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushDefenseRank"": ""20"",
                ""score"": ""0"",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""30"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""32"",
                ""id"": ""LVR"",
                ""passDefenseRank"": ""15"",
                ""spread"": ""12.5""
              },
              {
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""22"",
                ""passDefenseRank"": ""11"",
                ""id"": ""PHI"",
                ""spread"": ""-12.5"",
                ""score"": ""31"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""22"",
                ""passOffenseRank"": ""20"",
                ""inRedZone"": ""0""
              }
            ],
            ""kickoff"": ""1765735200"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""passOffenseRank"": ""29"",
                ""inRedZone"": ""0"",
                ""score"": ""3"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""16"",
                ""passDefenseRank"": ""4"",
                ""id"": ""CLE"",
                ""spread"": ""7.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""26""
              },
              {
                ""id"": ""CHI"",
                ""passDefenseRank"": ""20"",
                ""spread"": ""-7.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""2"",
                ""passOffenseRank"": ""14"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""23"",
                ""hasPossession"": ""0"",
                ""score"": ""31""
              }
            ],
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1765735200""
          },
          {
            ""team"": [
              {
                ""score"": ""20"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""21"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""4"",
                ""rushOffenseRank"": ""29"",
                ""isHome"": ""0"",
                ""spread"": ""9.5"",
                ""passDefenseRank"": ""21"",
                ""id"": ""ARI""
              },
              {
                ""passOffenseRank"": ""12"",
                ""inRedZone"": ""0"",
                ""score"": ""40"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""4"",
                ""passDefenseRank"": ""3"",
                ""id"": ""HOU"",
                ""spread"": ""-9.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""23""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1765735200""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1765747500"",
            ""team"": [
              {
                ""id"": ""GBP"",
                ""passDefenseRank"": ""8"",
                ""spread"": ""-2.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""16"",
                ""passOffenseRank"": ""10"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""10"",
                ""hasPossession"": ""0"",
                ""score"": ""26""
              },
              {
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""17"",
                ""id"": ""DEN"",
                ""passDefenseRank"": ""16"",
                ""spread"": ""2.5"",
                ""rushDefenseRank"": ""3"",
                ""hasPossession"": ""0"",
                ""score"": ""34"",
                ""passOffenseRank"": ""9"",
                ""inRedZone"": ""0""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushOffenseRank"": ""11"",
                ""isHome"": ""0"",
                ""spread"": ""13.5"",
                ""passDefenseRank"": ""31"",
                ""id"": ""IND"",
                ""hasPossession"": ""0"",
                ""score"": ""16"",
                ""rushDefenseRank"": ""5"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""11""
              },
              {
                ""passOffenseRank"": ""5"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": ""18"",
                ""rushDefenseRank"": ""2"",
                ""passDefenseRank"": ""7"",
                ""id"": ""SEA"",
                ""spread"": ""-13.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""18""
              }
            ],
            ""kickoff"": ""1765747500"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""team"": [
              {
                ""rushDefenseRank"": ""13"",
                ""hasPossession"": ""0"",
                ""score"": ""34"",
                ""passOffenseRank"": ""3"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""4"",
                ""id"": ""DET"",
                ""passDefenseRank"": ""25"",
                ""spread"": ""5.5""
              },
              {
                ""passDefenseRank"": ""19"",
                ""id"": ""LAR"",
                ""spread"": ""-5.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""6"",
                ""passOffenseRank"": ""2"",
                ""inRedZone"": ""0"",
                ""score"": ""41"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""8""
              }
            ],
            ""status"": ""FINAL"",
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1765747500""
          },
          {
            ""team"": [
              {
                ""spread"": ""-2.5"",
                ""passDefenseRank"": ""17"",
                ""id"": ""CAR"",
                ""rushOffenseRank"": ""10"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""24"",
                ""score"": ""17"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""14""
              },
              {
                ""rushOffenseRank"": ""28"",
                ""isHome"": ""1"",
                ""spread"": ""2.5"",
                ""id"": ""NOS"",
                ""passDefenseRank"": ""6"",
                ""rushDefenseRank"": ""25"",
                ""score"": ""20"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""21""
              }
            ],
            ""status"": ""FINAL"",
            ""kickoff"": ""1765747500"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1765747500"",
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""31"",
                ""id"": ""TEN"",
                ""passDefenseRank"": ""26"",
                ""spread"": ""12.5"",
                ""rushDefenseRank"": ""19"",
                ""hasPossession"": ""0"",
                ""score"": ""24"",
                ""passOffenseRank"": ""28"",
                ""inRedZone"": ""0""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""5"",
                ""rushDefenseRank"": ""12"",
                ""hasPossession"": ""0"",
                ""score"": ""37"",
                ""spread"": ""-12.5"",
                ""id"": ""SFO"",
                ""passDefenseRank"": ""24"",
                ""rushOffenseRank"": ""25"",
                ""isHome"": ""1""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1765761600"",
            ""team"": [
              {
                ""score"": ""34"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""24"",
                ""passOffenseRank"": ""26"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""24"",
                ""passDefenseRank"": ""5"",
                ""id"": ""MIN"",
                ""spread"": ""6""
              },
              {
                ""rushDefenseRank"": ""18"",
                ""score"": ""26"",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""1"",
                ""rushOffenseRank"": ""15"",
                ""isHome"": ""1"",
                ""spread"": ""-6.0"",
                ""id"": ""DAL"",
                ""passDefenseRank"": ""32""
              }
            ],
            ""status"": ""FINAL""
          },
          {
            ""gameSecondsRemaining"": ""0"",
            ""kickoff"": ""1765847700"",
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""rushDefenseRank"": ""27"",
                ""hasPossession"": ""0"",
                ""score"": ""15"",
                ""passOffenseRank"": ""25"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""13"",
                ""id"": ""MIA"",
                ""passDefenseRank"": ""12"",
                ""spread"": ""3""
              },
              {
                ""rushOffenseRank"": ""27"",
                ""isHome"": ""1"",
                ""spread"": ""-3.0"",
                ""passDefenseRank"": ""29"",
                ""id"": ""PIT"",
                ""score"": ""28"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""17"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""22""
              }
            ]
          }
        ],
        ""lastUpdate"": ""1766140832"",
        ""week"": ""15""
      },
      {
        ""matchup"": [
          {
            ""status"": ""FINAL"",
            ""team"": [
              {
                ""hasPossession"": ""0"",
                ""score"": ""37"",
                ""rushDefenseRank"": ""10"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""2"",
                ""rushOffenseRank"": ""6"",
                ""isHome"": ""0"",
                ""spread"": ""-1.5"",
                ""passDefenseRank"": ""20"",
                ""id"": ""LAR""
              },
              {
                ""score"": ""38"",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""2"",
                ""passOffenseRank"": ""6"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""17"",
                ""passDefenseRank"": ""14"",
                ""id"": ""SEA"",
                ""spread"": ""1.5""
              }
            ],
            ""kickoff"": ""1766106900"",
            ""gameSecondsRemaining"": ""0""
          },
          {
            ""gameSecondsRemaining"": ""3600"",
            ""kickoff"": ""1766268000"",
            ""status"": ""SCHED"",
            ""team"": [
              {
                ""passOffenseRank"": ""20"",
                ""inRedZone"": ""0"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""22"",
                ""passDefenseRank"": ""11"",
                ""id"": ""PHI"",
                ""spread"": ""-6.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""22""
              },
              {
                ""rushDefenseRank"": ""29"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""passOffenseRank"": ""23"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""5"",
                ""id"": ""WAS"",
                ""passDefenseRank"": ""30"",
                ""spread"": ""6.5""
              }
            ]
          },
          {
            ""gameSecondsRemaining"": ""3600"",
            ""kickoff"": ""1766280000"",
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""16"",
                ""id"": ""GBP"",
                ""passDefenseRank"": ""8"",
                ""spread"": ""-1.5"",
                ""rushDefenseRank"": ""10"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""10"",
                ""inRedZone"": ""0""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""14"",
                ""rushDefenseRank"": ""23"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""spread"": ""1.5"",
                ""id"": ""CHI"",
                ""passDefenseRank"": ""20"",
                ""rushOffenseRank"": ""2"",
                ""isHome"": ""1""
              }
            ],
            ""status"": ""SCHED""
          },
          {
            ""team"": [
              {
                ""id"": ""CIN"",
                ""passDefenseRank"": ""27"",
                ""spread"": ""-1.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""30"",
                ""passOffenseRank"": ""8"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""32"",
                ""hasPossession"": ""0"",
                ""score"": """"
              },
              {
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""13"",
                ""id"": ""MIA"",
                ""passDefenseRank"": ""12"",
                ""spread"": ""1.5"",
                ""rushDefenseRank"": ""27"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""25"",
                ""inRedZone"": ""0""
              }
            ],
            ""status"": ""SCHED"",
            ""kickoff"": ""1766340000"",
            ""gameSecondsRemaining"": ""3600""
          },
          {
            ""team"": [
              {
                ""rushOffenseRank"": ""1"",
                ""isHome"": ""0"",
                ""spread"": ""-10"",
                ""passDefenseRank"": ""1"",
                ""id"": ""BUF"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""rushDefenseRank"": ""28"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""17""
              },
              {
                ""passDefenseRank"": ""4"",
                ""id"": ""CLE"",
                ""spread"": ""10.0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""26"",
                ""passOffenseRank"": ""29"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""rushDefenseRank"": ""16""
              }
            ],
            ""status"": ""SCHED"",
            ""kickoff"": ""1766340000"",
            ""gameSecondsRemaining"": ""3600""
          },
          {
            ""status"": ""SCHED"",
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""19"",
                ""passDefenseRank"": ""10"",
                ""id"": ""KCC"",
                ""spread"": ""-3.5"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""7"",
                ""passOffenseRank"": ""6"",
                ""inRedZone"": ""0""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""28"",
                ""rushDefenseRank"": ""19"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""spread"": ""3.5"",
                ""id"": ""TEN"",
                ""passDefenseRank"": ""26"",
                ""rushOffenseRank"": ""31"",
                ""isHome"": ""1""
              }
            ],
            ""gameSecondsRemaining"": ""3600"",
            ""kickoff"": ""1766340000""
          },
          {
            ""status"": ""SCHED"",
            ""team"": [
              {
                ""spread"": ""1.5"",
                ""id"": ""LAC"",
                ""passDefenseRank"": ""2"",
                ""rushOffenseRank"": ""12"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""18"",
                ""rushDefenseRank"": ""11"",
                ""hasPossession"": ""0"",
                ""score"": """"
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""1"",
                ""rushDefenseRank"": ""18"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""spread"": ""-1.5"",
                ""id"": ""DAL"",
                ""passDefenseRank"": ""32"",
                ""rushOffenseRank"": ""15"",
                ""isHome"": ""1""
              }
            ],
            ""gameSecondsRemaining"": ""3600"",
            ""kickoff"": ""1766340000""
          },
          {
            ""kickoff"": ""1766340000"",
            ""gameSecondsRemaining"": ""3600"",
            ""status"": ""SCHED"",
            ""team"": [
              {
                ""hasPossession"": ""0"",
                ""score"": """",
                ""rushDefenseRank"": ""24"",
                ""passOffenseRank"": ""26"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""24"",
                ""passDefenseRank"": ""5"",
                ""id"": ""MIN"",
                ""spread"": ""-3""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""13"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""31"",
                ""spread"": ""3.0"",
                ""passDefenseRank"": ""23"",
                ""id"": ""NYG"",
                ""rushOffenseRank"": ""7"",
                ""isHome"": ""1""
              }
            ]
          },
          {
            ""kickoff"": ""1766340000"",
            ""gameSecondsRemaining"": ""3600"",
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""21"",
                ""passDefenseRank"": ""28"",
                ""id"": ""TBB"",
                ""spread"": ""-3"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""rushDefenseRank"": ""9"",
                ""passOffenseRank"": ""19"",
                ""inRedZone"": ""0""
              },
              {
                ""rushOffenseRank"": ""10"",
                ""isHome"": ""1"",
                ""spread"": ""3.0"",
                ""passDefenseRank"": ""17"",
                ""id"": ""CAR"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""rushDefenseRank"": ""14"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""24""
              }
            ],
            ""status"": ""SCHED""
          },
          {
            ""status"": ""SCHED"",
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""31"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""30"",
                ""spread"": ""4.5"",
                ""passDefenseRank"": ""14"",
                ""id"": ""NYJ"",
                ""rushOffenseRank"": ""14"",
                ""isHome"": ""0""
              },
              {
                ""rushDefenseRank"": ""25"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""21"",
                ""rushOffenseRank"": ""28"",
                ""isHome"": ""1"",
                ""spread"": ""-4.5"",
                ""id"": ""NOS"",
                ""passDefenseRank"": ""6""
              }
            ],
            ""gameSecondsRemaining"": ""3600"",
            ""kickoff"": ""1766340000""
          },
          {
            ""kickoff"": ""1766351100"",
            ""gameSecondsRemaining"": ""3600"",
            ""status"": ""SCHED"",
            ""team"": [
              {
                ""passDefenseRank"": ""22"",
                ""id"": ""JAC"",
                ""spread"": ""3"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""20"",
                ""passOffenseRank"": ""15"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""rushDefenseRank"": ""1""
              },
              {
                ""spread"": ""-3.0"",
                ""id"": ""DEN"",
                ""passDefenseRank"": ""16"",
                ""rushOffenseRank"": ""17"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""9"",
                ""rushDefenseRank"": ""3"",
                ""hasPossession"": ""0"",
                ""score"": """"
              }
            ]
          },
          {
            ""gameSecondsRemaining"": ""3600"",
            ""kickoff"": ""1766351100"",
            ""status"": ""SCHED"",
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""16"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""26"",
                ""spread"": ""-2.5"",
                ""passDefenseRank"": ""13"",
                ""id"": ""ATL"",
                ""rushOffenseRank"": ""9"",
                ""isHome"": ""0""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""4"",
                ""rushDefenseRank"": ""21"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""spread"": ""2.5"",
                ""id"": ""ARI"",
                ""passDefenseRank"": ""21"",
                ""rushOffenseRank"": ""29"",
                ""isHome"": ""1""
              }
            ]
          },
          {
            ""kickoff"": ""1766352300"",
            ""gameSecondsRemaining"": ""3600"",
            ""status"": ""SCHED"",
            ""team"": [
              {
                ""passDefenseRank"": ""29"",
                ""id"": ""PIT"",
                ""spread"": ""7"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""27"",
                ""passOffenseRank"": ""22"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""rushDefenseRank"": ""17""
              },
              {
                ""passOffenseRank"": ""3"",
                ""inRedZone"": ""0"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""13"",
                ""passDefenseRank"": ""25"",
                ""id"": ""DET"",
                ""spread"": ""-7.0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""4""
              }
            ]
          },
          {
            ""gameSecondsRemaining"": ""3600"",
            ""kickoff"": ""1766352300"",
            ""team"": [
              {
                ""rushDefenseRank"": ""20"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""30"",
                ""rushOffenseRank"": ""32"",
                ""isHome"": ""0"",
                ""spread"": ""14.5"",
                ""id"": ""LVR"",
                ""passDefenseRank"": ""15""
              },
              {
                ""rushOffenseRank"": ""23"",
                ""isHome"": ""1"",
                ""spread"": ""-14.5"",
                ""id"": ""HOU"",
                ""passDefenseRank"": ""3"",
                ""rushDefenseRank"": ""4"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""12""
              }
            ],
            ""status"": ""SCHED""
          },
          {
            ""team"": [
              {
                ""spread"": ""3"",
                ""id"": ""NEP"",
                ""passDefenseRank"": ""9"",
                ""rushOffenseRank"": ""8"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""7"",
                ""rushDefenseRank"": ""6"",
                ""score"": """",
                ""hasPossession"": ""0""
              },
              {
                ""score"": """",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""15"",
                ""passOffenseRank"": ""27"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""3"",
                ""passDefenseRank"": ""18"",
                ""id"": ""BAL"",
                ""spread"": ""-3.0""
              }
            ],
            ""status"": ""SCHED"",
            ""gameSecondsRemaining"": ""3600"",
            ""kickoff"": ""1766366400""
          },
          {
            ""kickoff"": ""1766452500"",
            ""gameSecondsRemaining"": ""3600"",
            ""team"": [
              {
                ""hasPossession"": ""0"",
                ""score"": """",
                ""rushDefenseRank"": ""12"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""5"",
                ""rushOffenseRank"": ""25"",
                ""isHome"": ""0"",
                ""spread"": ""-5.5"",
                ""passDefenseRank"": ""24"",
                ""id"": ""SFO""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""11"",
                ""rushDefenseRank"": ""5"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""spread"": ""5.5"",
                ""id"": ""IND"",
                ""passDefenseRank"": ""31"",
                ""rushOffenseRank"": ""11"",
                ""isHome"": ""1""
              }
            ],
            ""status"": ""SCHED""
          }
        ],
        ""lastUpdate"": ""1766140832"",
        ""week"": ""16""
      },
      {
        ""week"": ""17"",
        ""lastUpdate"": ""1766140832"",
        ""matchup"": [
          {
            ""kickoff"": ""1766685600"",
            ""gameSecondsRemaining"": ""3600"",
            ""status"": ""SCHED"",
            ""team"": [
              {
                ""hasPossession"": ""0"",
                ""score"": """",
                ""rushDefenseRank"": ""18"",
                ""passOffenseRank"": ""1"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""15"",
                ""passDefenseRank"": ""32"",
                ""id"": ""DAL"",
                ""spread"": ""0""
              },
              {
                ""passOffenseRank"": ""23"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""rushDefenseRank"": ""29"",
                ""passDefenseRank"": ""30"",
                ""id"": ""WAS"",
                ""spread"": ""0.0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""5""
              }
            ]
          },
          {
            ""team"": [
              {
                ""passDefenseRank"": ""25"",
                ""id"": ""DET"",
                ""spread"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""4"",
                ""passOffenseRank"": ""3"",
                ""inRedZone"": ""0"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""13""
              },
              {
                ""hasPossession"": ""0"",
                ""score"": """",
                ""rushDefenseRank"": ""24"",
                ""passOffenseRank"": ""26"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""24"",
                ""passDefenseRank"": ""5"",
                ""id"": ""MIN"",
                ""spread"": ""0.0""
              }
            ],
            ""status"": ""SCHED"",
            ""kickoff"": ""1766698200"",
            ""gameSecondsRemaining"": ""3600""
          },
          {
            ""gameSecondsRemaining"": ""3600"",
            ""kickoff"": ""1766711700"",
            ""team"": [
              {
                ""passOffenseRank"": ""9"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""3"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""id"": ""DEN"",
                ""passDefenseRank"": ""16"",
                ""spread"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""17""
              },
              {
                ""spread"": ""0.0"",
                ""id"": ""KCC"",
                ""passDefenseRank"": ""10"",
                ""rushOffenseRank"": ""19"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""6"",
                ""rushDefenseRank"": ""7"",
                ""hasPossession"": ""0"",
                ""score"": """"
              }
            ],
            ""status"": ""SCHED""
          },
          {
            ""status"": ""SCHED"",
            ""team"": [
              {
                ""spread"": ""0"",
                ""passDefenseRank"": ""22"",
                ""id"": ""JAC"",
                ""rushOffenseRank"": ""20"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""15"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""rushDefenseRank"": ""1""
              },
              {
                ""rushDefenseRank"": ""5"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""passOffenseRank"": ""11"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""11"",
                ""id"": ""IND"",
                ""passDefenseRank"": ""31"",
                ""spread"": ""0.0""
              }
            ],
            ""kickoff"": ""1766944800"",
            ""gameSecondsRemaining"": ""3600""
          },
          {
            ""status"": ""SCHED"",
            ""team"": [
              {
                ""rushOffenseRank"": ""21"",
                ""isHome"": ""0"",
                ""spread"": ""0"",
                ""passDefenseRank"": ""28"",
                ""id"": ""TBB"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""9"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""19""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""25"",
                ""rushDefenseRank"": ""27"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""spread"": ""0.0"",
                ""id"": ""MIA"",
                ""passDefenseRank"": ""12"",
                ""rushOffenseRank"": ""13"",
                ""isHome"": ""1""
              }
            ],
            ""kickoff"": ""1766944800"",
            ""gameSecondsRemaining"": ""3600""
          },
          {
            ""team"": [
              {
                ""rushDefenseRank"": ""6"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""7"",
                ""rushOffenseRank"": ""8"",
                ""isHome"": ""0"",
                ""spread"": ""0"",
                ""id"": ""NEP"",
                ""passDefenseRank"": ""9""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""31"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""rushDefenseRank"": ""30"",
                ""spread"": ""0.0"",
                ""passDefenseRank"": ""14"",
                ""id"": ""NYJ"",
                ""rushOffenseRank"": ""14"",
                ""isHome"": ""1""
              }
            ],
            ""status"": ""SCHED"",
            ""kickoff"": ""1766944800"",
            ""gameSecondsRemaining"": ""3600""
          },
          {
            ""gameSecondsRemaining"": ""3600"",
            ""kickoff"": ""1766944800"",
            ""team"": [
              {
                ""score"": """",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""21"",
                ""passOffenseRank"": ""4"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""29"",
                ""passDefenseRank"": ""21"",
                ""id"": ""ARI"",
                ""spread"": ""0""
              },
              {
                ""passOffenseRank"": ""8"",
                ""inRedZone"": ""0"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""32"",
                ""passDefenseRank"": ""27"",
                ""id"": ""CIN"",
                ""spread"": ""0.0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""30""
              }
            ],
            ""status"": ""SCHED""
          },
          {
            ""kickoff"": ""1766944800"",
            ""gameSecondsRemaining"": ""3600"",
            ""team"": [
              {
                ""spread"": ""0"",
                ""passDefenseRank"": ""29"",
                ""id"": ""PIT"",
                ""rushOffenseRank"": ""27"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""22"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""17""
              },
              {
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""26"",
                ""id"": ""CLE"",
                ""passDefenseRank"": ""4"",
                ""spread"": ""0.0"",
                ""rushDefenseRank"": ""16"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""passOffenseRank"": ""29"",
                ""inRedZone"": ""0""
              }
            ],
            ""status"": ""SCHED""
          },
          {
            ""team"": [
              {
                ""rushDefenseRank"": ""25"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""21"",
                ""rushOffenseRank"": ""28"",
                ""isHome"": ""0"",
                ""spread"": ""0"",
                ""id"": ""NOS"",
                ""passDefenseRank"": ""6""
              },
              {
                ""passOffenseRank"": ""28"",
                ""inRedZone"": ""0"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""19"",
                ""passDefenseRank"": ""26"",
                ""id"": ""TEN"",
                ""spread"": ""0.0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""31""
              }
            ],
            ""status"": ""SCHED"",
            ""gameSecondsRemaining"": ""3600"",
            ""kickoff"": ""1766944800""
          },
          {
            ""team"": [
              {
                ""rushOffenseRank"": ""7"",
                ""isHome"": ""0"",
                ""spread"": ""0"",
                ""id"": ""NYG"",
                ""passDefenseRank"": ""23"",
                ""rushDefenseRank"": ""31"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""13""
              },
              {
                ""passDefenseRank"": ""15"",
                ""id"": ""LVR"",
                ""spread"": ""0.0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""32"",
                ""passOffenseRank"": ""30"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""rushDefenseRank"": ""20""
              }
            ],
            ""status"": ""SCHED"",
            ""kickoff"": ""1766944800"",
            ""gameSecondsRemaining"": ""3600""
          },
          {
            ""gameSecondsRemaining"": ""3600"",
            ""kickoff"": ""1766944800"",
            ""team"": [
              {
                ""rushDefenseRank"": ""2"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""6"",
                ""rushOffenseRank"": ""17"",
                ""isHome"": ""0"",
                ""spread"": ""0"",
                ""id"": ""SEA"",
                ""passDefenseRank"": ""14""
              },
              {
                ""passDefenseRank"": ""17"",
                ""id"": ""CAR"",
                ""spread"": ""0.0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""10"",
                ""passOffenseRank"": ""24"",
                ""inRedZone"": ""0"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""14""
              }
            ],
            ""status"": ""SCHED""
          },
          {
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""22"",
                ""id"": ""PHI"",
                ""passDefenseRank"": ""11"",
                ""spread"": ""0"",
                ""rushDefenseRank"": ""22"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""passOffenseRank"": ""20"",
                ""inRedZone"": ""0""
              },
              {
                ""spread"": ""0.0"",
                ""passDefenseRank"": ""1"",
                ""id"": ""BUF"",
                ""rushOffenseRank"": ""1"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""17"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""28""
              }
            ],
            ""status"": ""SCHED"",
            ""kickoff"": ""1766957100"",
            ""gameSecondsRemaining"": ""3600""
          },
          {
            ""kickoff"": ""1766957400"",
            ""gameSecondsRemaining"": ""3600"",
            ""status"": ""SCHED"",
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""23"",
                ""id"": ""HOU"",
                ""passDefenseRank"": ""3"",
                ""spread"": ""0"",
                ""rushDefenseRank"": ""4"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""12"",
                ""inRedZone"": ""0""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""18"",
                ""rushDefenseRank"": ""11"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""spread"": ""0.0"",
                ""id"": ""LAC"",
                ""passDefenseRank"": ""2"",
                ""rushOffenseRank"": ""12"",
                ""isHome"": ""1""
              }
            ]
          },
          {
            ""kickoff"": ""1766970000"",
            ""gameSecondsRemaining"": ""3600"",
            ""team"": [
              {
                ""score"": """",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""15"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""27"",
                ""rushOffenseRank"": ""3"",
                ""isHome"": ""0"",
                ""spread"": ""0"",
                ""passDefenseRank"": ""18"",
                ""id"": ""BAL""
              },
              {
                ""rushDefenseRank"": ""10"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""10"",
                ""rushOffenseRank"": ""16"",
                ""isHome"": ""1"",
                ""spread"": ""0.0"",
                ""id"": ""GBP"",
                ""passDefenseRank"": ""8""
              }
            ],
            ""status"": ""SCHED""
          },
          {
            ""kickoff"": ""1766971200"",
            ""gameSecondsRemaining"": ""3600"",
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""2"",
                ""passDefenseRank"": ""20"",
                ""id"": ""CHI"",
                ""spread"": ""0"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""23"",
                ""passOffenseRank"": ""14"",
                ""inRedZone"": ""0""
              },
              {
                ""spread"": ""0.0"",
                ""id"": ""SFO"",
                ""passDefenseRank"": ""24"",
                ""rushOffenseRank"": ""25"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""5"",
                ""rushDefenseRank"": ""12"",
                ""hasPossession"": ""0"",
                ""score"": """"
              }
            ],
            ""status"": ""SCHED""
          },
          {
            ""status"": ""SCHED"",
            ""team"": [
              {
                ""spread"": ""0"",
                ""id"": ""LAR"",
                ""passDefenseRank"": ""20"",
                ""rushOffenseRank"": ""6"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""2"",
                ""rushDefenseRank"": ""10"",
                ""hasPossession"": ""0"",
                ""score"": """"
              },
              {
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""9"",
                ""id"": ""ATL"",
                ""passDefenseRank"": ""13"",
                ""spread"": ""0.0"",
                ""rushDefenseRank"": ""26"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""16"",
                ""inRedZone"": ""0""
              }
            ],
            ""gameSecondsRemaining"": ""3600"",
            ""kickoff"": ""1767057300""
          }
        ]
      },
      {
        ""lastUpdate"": ""1766140832"",
        ""week"": ""18"",
        ""matchup"": [
          {
            ""status"": ""SCHED"",
            ""team"": [
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""31"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""rushDefenseRank"": ""30"",
                ""spread"": ""1.0"",
                ""passDefenseRank"": ""14"",
                ""id"": ""NYJ"",
                ""rushOffenseRank"": ""14"",
                ""isHome"": ""0""
              },
              {
                ""rushOffenseRank"": ""1"",
                ""isHome"": ""1"",
                ""spread"": ""-3"",
                ""id"": ""BUF"",
                ""passDefenseRank"": ""1"",
                ""rushDefenseRank"": ""28"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""17""
              }
            ],
            ""gameSecondsRemaining"": ""3600"",
            ""kickoff"": ""1767549600""
          },
          {
            ""kickoff"": ""1767549600"",
            ""gameSecondsRemaining"": ""3600"",
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""13"",
                ""id"": ""MIA"",
                ""passDefenseRank"": ""12"",
                ""spread"": ""-1"",
                ""rushDefenseRank"": ""27"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""passOffenseRank"": ""25"",
                ""inRedZone"": ""0""
              },
              {
                ""passDefenseRank"": ""9"",
                ""id"": ""NEP"",
                ""spread"": ""3.0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""8"",
                ""passOffenseRank"": ""7"",
                ""inRedZone"": ""0"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""rushDefenseRank"": ""6""
              }
            ],
            ""status"": ""SCHED""
          },
          {
            ""status"": ""SCHED"",
            ""team"": [
              {
                ""passOffenseRank"": ""29"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""16"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""id"": ""CLE"",
                ""passDefenseRank"": ""4"",
                ""spread"": ""17.5"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""26""
              },
              {
                ""rushDefenseRank"": ""32"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""8"",
                ""rushOffenseRank"": ""30"",
                ""isHome"": ""1"",
                ""spread"": ""-1.5"",
                ""id"": ""CIN"",
                ""passDefenseRank"": ""27""
              }
            ],
            ""kickoff"": ""1767549600"",
            ""gameSecondsRemaining"": ""3600""
          },
          {
            ""status"": ""SCHED"",
            ""team"": [
              {
                ""id"": ""TEN"",
                ""passDefenseRank"": ""26"",
                ""spread"": ""1.0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""31"",
                ""passOffenseRank"": ""28"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""19"",
                ""hasPossession"": ""0"",
                ""score"": """"
              },
              {
                ""id"": ""JAC"",
                ""passDefenseRank"": ""22"",
                ""spread"": ""4.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""20"",
                ""passOffenseRank"": ""15"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""1"",
                ""hasPossession"": ""0"",
                ""score"": """"
              }
            ],
            ""kickoff"": ""1767549600"",
            ""gameSecondsRemaining"": ""3600""
          },
          {
            ""team"": [
              {
                ""rushDefenseRank"": ""15"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""27"",
                ""rushOffenseRank"": ""3"",
                ""isHome"": ""0"",
                ""spread"": ""-17.5"",
                ""id"": ""BAL"",
                ""passDefenseRank"": ""18""
              },
              {
                ""id"": ""PIT"",
                ""passDefenseRank"": ""29"",
                ""spread"": ""1.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""27"",
                ""passOffenseRank"": ""22"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""17"",
                ""score"": """",
                ""hasPossession"": ""0""
              }
            ],
            ""status"": ""SCHED"",
            ""gameSecondsRemaining"": ""3600"",
            ""kickoff"": ""1767549600""
          },
          {
            ""gameSecondsRemaining"": ""3600"",
            ""kickoff"": ""1767549600"",
            ""team"": [
              {
                ""rushDefenseRank"": ""11"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""18"",
                ""rushOffenseRank"": ""12"",
                ""isHome"": ""0"",
                ""spread"": ""-5"",
                ""id"": ""LAC"",
                ""passDefenseRank"": ""2""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""9"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""3"",
                ""spread"": ""-10.5"",
                ""passDefenseRank"": ""16"",
                ""id"": ""DEN"",
                ""rushOffenseRank"": ""17"",
                ""isHome"": ""1""
              }
            ],
            ""status"": ""SCHED""
          },
          {
            ""status"": ""SCHED"",
            ""team"": [
              {
                ""rushDefenseRank"": ""7"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""6"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""19"",
                ""id"": ""KCC"",
                ""passDefenseRank"": ""10"",
                ""spread"": ""10.5""
              },
              {
                ""rushDefenseRank"": ""20"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""passOffenseRank"": ""30"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""32"",
                ""id"": ""LVR"",
                ""passDefenseRank"": ""15"",
                ""spread"": ""5.0""
              }
            ],
            ""gameSecondsRemaining"": ""3600"",
            ""kickoff"": ""1767549600""
          },
          {
            ""gameSecondsRemaining"": ""3600"",
            ""kickoff"": ""1767549600"",
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""15"",
                ""id"": ""DAL"",
                ""passDefenseRank"": ""32"",
                ""spread"": ""4.5"",
                ""rushDefenseRank"": ""18"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""passOffenseRank"": ""1"",
                ""inRedZone"": ""0""
              },
              {
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""13"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""31"",
                ""spread"": ""2.5"",
                ""passDefenseRank"": ""23"",
                ""id"": ""NYG"",
                ""rushOffenseRank"": ""7"",
                ""isHome"": ""1""
              }
            ],
            ""status"": ""SCHED""
          },
          {
            ""gameSecondsRemaining"": ""3600"",
            ""kickoff"": ""1767549600"",
            ""team"": [
              {
                ""spread"": ""-4.5"",
                ""passDefenseRank"": ""30"",
                ""id"": ""WAS"",
                ""rushOffenseRank"": ""5"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""23"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""rushDefenseRank"": ""29""
              },
              {
                ""id"": ""PHI"",
                ""passDefenseRank"": ""11"",
                ""spread"": ""-2.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""22"",
                ""passOffenseRank"": ""20"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""22"",
                ""hasPossession"": ""0"",
                ""score"": """"
              }
            ],
            ""status"": ""SCHED""
          },
          {
            ""kickoff"": ""1767549600"",
            ""gameSecondsRemaining"": ""3600"",
            ""status"": ""SCHED"",
            ""team"": [
              {
                ""rushDefenseRank"": ""13"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""3"",
                ""rushOffenseRank"": ""4"",
                ""isHome"": ""0"",
                ""spread"": ""-2.5"",
                ""id"": ""DET"",
                ""passDefenseRank"": ""25""
              },
              {
                ""rushOffenseRank"": ""2"",
                ""isHome"": ""1"",
                ""spread"": ""10"",
                ""passDefenseRank"": ""20"",
                ""id"": ""CHI"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""rushDefenseRank"": ""23"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""14""
              }
            ]
          },
          {
            ""gameSecondsRemaining"": ""3600"",
            ""kickoff"": ""1767549600"",
            ""team"": [
              {
                ""hasPossession"": ""0"",
                ""score"": """",
                ""rushDefenseRank"": ""10"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""10"",
                ""rushOffenseRank"": ""16"",
                ""isHome"": ""0"",
                ""spread"": ""-10.0"",
                ""passDefenseRank"": ""8"",
                ""id"": ""GBP""
              },
              {
                ""rushDefenseRank"": ""24"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""passOffenseRank"": ""26"",
                ""inRedZone"": ""0"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""24"",
                ""id"": ""MIN"",
                ""passDefenseRank"": ""5"",
                ""spread"": ""2.5""
              }
            ],
            ""status"": ""SCHED""
          },
          {
            ""team"": [
              {
                ""rushOffenseRank"": ""10"",
                ""isHome"": ""0"",
                ""spread"": ""8"",
                ""id"": ""CAR"",
                ""passDefenseRank"": ""17"",
                ""rushDefenseRank"": ""14"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""24""
              },
              {
                ""passOffenseRank"": ""19"",
                ""inRedZone"": ""0"",
                ""rushDefenseRank"": ""9"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""id"": ""TBB"",
                ""passDefenseRank"": ""28"",
                ""spread"": ""-13.5"",
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""21""
              }
            ],
            ""status"": ""SCHED"",
            ""kickoff"": ""1767549600"",
            ""gameSecondsRemaining"": ""3600""
          },
          {
            ""gameSecondsRemaining"": ""3600"",
            ""kickoff"": ""1767549600"",
            ""team"": [
              {
                ""spread"": ""13.5"",
                ""passDefenseRank"": ""6"",
                ""id"": ""NOS"",
                ""rushOffenseRank"": ""28"",
                ""isHome"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""21"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""rushDefenseRank"": ""25""
              },
              {
                ""spread"": ""-8.0"",
                ""id"": ""ATL"",
                ""passDefenseRank"": ""13"",
                ""rushOffenseRank"": ""9"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""16"",
                ""rushDefenseRank"": ""26"",
                ""hasPossession"": ""0"",
                ""score"": """"
              }
            ],
            ""status"": ""SCHED""
          },
          {
            ""team"": [
              {
                ""rushDefenseRank"": ""21"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""4"",
                ""rushOffenseRank"": ""29"",
                ""isHome"": ""0"",
                ""spread"": ""-4.0"",
                ""id"": ""ARI"",
                ""passDefenseRank"": ""21""
              },
              {
                ""spread"": ""6.5"",
                ""id"": ""LAR"",
                ""passDefenseRank"": ""20"",
                ""rushOffenseRank"": ""6"",
                ""isHome"": ""1"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""2"",
                ""rushDefenseRank"": ""10"",
                ""score"": """",
                ""hasPossession"": ""0""
              }
            ],
            ""status"": ""SCHED"",
            ""kickoff"": ""1767549600"",
            ""gameSecondsRemaining"": ""3600""
          },
          {
            ""team"": [
              {
                ""hasPossession"": ""0"",
                ""score"": """",
                ""rushDefenseRank"": ""2"",
                ""passOffenseRank"": ""6"",
                ""inRedZone"": ""0"",
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""17"",
                ""passDefenseRank"": ""14"",
                ""id"": ""SEA"",
                ""spread"": ""-6.5""
              },
              {
                ""rushOffenseRank"": ""25"",
                ""isHome"": ""1"",
                ""spread"": ""4"",
                ""passDefenseRank"": ""24"",
                ""id"": ""SFO"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""rushDefenseRank"": ""12"",
                ""inRedZone"": ""0"",
                ""passOffenseRank"": ""5""
              }
            ],
            ""status"": ""SCHED"",
            ""gameSecondsRemaining"": ""3600"",
            ""kickoff"": ""1767549600""
          },
          {
            ""kickoff"": ""1767549600"",
            ""gameSecondsRemaining"": ""3600"",
            ""team"": [
              {
                ""isHome"": ""0"",
                ""rushOffenseRank"": ""11"",
                ""passDefenseRank"": ""31"",
                ""id"": ""IND"",
                ""spread"": ""-4.5"",
                ""hasPossession"": ""0"",
                ""score"": """",
                ""rushDefenseRank"": ""5"",
                ""passOffenseRank"": ""11"",
                ""inRedZone"": ""0""
              },
              {
                ""isHome"": ""1"",
                ""rushOffenseRank"": ""23"",
                ""id"": ""HOU"",
                ""passDefenseRank"": ""3"",
                ""spread"": ""-1"",
                ""rushDefenseRank"": ""4"",
                ""score"": """",
                ""hasPossession"": ""0"",
                ""passOffenseRank"": ""12"",
                ""inRedZone"": ""0""
              }
            ],
            ""status"": ""SCHED""
          }
        ]
      },
      {
        ""week"": ""19"",
        ""lastUpdate"": ""1766140832""
      },
      {
        ""lastUpdate"": ""1766140832"",
        ""week"": ""20""
      },
      {
        ""lastUpdate"": ""1766140832"",
        ""week"": ""21""
      },
      {
        ""week"": ""22"",
        ""lastUpdate"": ""1766140832""
      }
    ]
  },
  ""version"": ""1.0""
}";

    private const string oneWeekJson = @"{
  ""version"": ""1.0"",
  ""nflSchedule"": {
    ""week"": ""2"",
    ""matchup"": [
      {
        ""kickoff"": ""1757636100"",
        ""team"": [
          {
            ""rushDefenseRank"": ""21"",
            ""spread"": ""3.5"",
            ""inRedZone"": ""0"",
            ""id"": ""WAS"",
            ""isHome"": ""0"",
            ""rushOffenseRank"": ""25"",
            ""passOffenseRank"": ""23"",
            ""passDefenseRank"": ""21"",
            ""score"": ""18"",
            ""hasPossession"": ""0""
          },
          {
            ""rushDefenseRank"": ""4"",
            ""spread"": ""-3.5"",
            ""isHome"": ""1"",
            ""id"": ""GBP"",
            ""rushOffenseRank"": ""8"",
            ""inRedZone"": ""0"",
            ""passOffenseRank"": ""10"",
            ""score"": ""27"",
            ""hasPossession"": ""0"",
            ""passDefenseRank"": ""8""
          }
        ],
        ""gameSecondsRemaining"": ""0""
      },
      {
        ""gameSecondsRemaining"": ""0"",
        ""team"": [
          {
            ""spread"": ""1.5"",
            ""rushDefenseRank"": ""5"",
            ""inRedZone"": ""0"",
            ""rushOffenseRank"": ""10"",
            ""id"": ""NEP"",
            ""isHome"": ""0"",
            ""passOffenseRank"": ""14"",
            ""passDefenseRank"": ""24"",
            ""hasPossession"": ""0"",
            ""score"": ""33""
          },
          {
            ""rushOffenseRank"": ""24"",
            ""id"": ""MIA"",
            ""isHome"": ""1"",
            ""inRedZone"": ""0"",
            ""spread"": ""-1.5"",
            ""rushDefenseRank"": ""19"",
            ""hasPossession"": ""0"",
            ""score"": ""27"",
            ""passDefenseRank"": ""17"",
            ""passOffenseRank"": ""7""
          }
        ],
        ""kickoff"": ""1757869200""
      },
      {
        ""team"": [
          {
            ""hasPossession"": ""0"",
            ""score"": ""30"",
            ""passDefenseRank"": ""1"",
            ""passOffenseRank"": ""23"",
            ""rushOffenseRank"": ""1"",
            ""isHome"": ""0"",
            ""id"": ""BUF"",
            ""inRedZone"": ""0"",
            ""spread"": ""-7"",
            ""rushDefenseRank"": ""13""
          },
          {
            ""isHome"": ""1"",
            ""id"": ""NYJ"",
            ""rushOffenseRank"": ""16"",
            ""inRedZone"": ""0"",
            ""rushDefenseRank"": ""28"",
            ""spread"": ""7.0"",
            ""score"": ""10"",
            ""hasPossession"": ""0"",
            ""passDefenseRank"": ""8"",
            ""passOffenseRank"": ""30""
          }
        ],
        ""kickoff"": ""1757869200"",
        ""gameSecondsRemaining"": ""0""
      },
      {
        ""team"": [
          {
            ""passOffenseRank"": ""12"",
            ""hasPossession"": ""0"",
            ""score"": ""27"",
            ""passDefenseRank"": ""25"",
            ""spread"": ""3.5"",
            ""rushDefenseRank"": ""2"",
            ""rushOffenseRank"": ""7"",
            ""isHome"": ""0"",
            ""id"": ""JAC"",
            ""inRedZone"": ""0""
          },
          {
            ""inRedZone"": ""0"",
            ""rushOffenseRank"": ""27"",
            ""isHome"": ""1"",
            ""id"": ""CIN"",
            ""spread"": ""-3.5"",
            ""rushDefenseRank"": ""22"",
            ""passDefenseRank"": ""19"",
            ""hasPossession"": ""0"",
            ""score"": ""31"",
            ""passOffenseRank"": ""6""
          }
        ],
        ""kickoff"": ""1757869200"",
        ""gameSecondsRemaining"": ""0""
      },
      {
        ""team"": [
          {
            ""passDefenseRank"": ""5"",
            ""hasPossession"": ""0"",
            ""score"": ""33"",
            ""passOffenseRank"": ""8"",
            ""inRedZone"": ""0"",
            ""rushOffenseRank"": ""6"",
            ""isHome"": ""0"",
            ""id"": ""LAR"",
            ""spread"": ""-5.5"",
            ""rushDefenseRank"": ""14""
          },
          {
            ""passOffenseRank"": ""26"",
            ""passDefenseRank"": ""23"",
            ""hasPossession"": ""0"",
            ""score"": ""19"",
            ""spread"": ""5.5"",
            ""rushDefenseRank"": ""23"",
            ""inRedZone"": ""0"",
            ""rushOffenseRank"": ""15"",
            ""isHome"": ""1"",
            ""id"": ""TEN""
          }
        ],
        ""kickoff"": ""1757869200"",
        ""gameSecondsRemaining"": ""0""
      },
      {
        ""gameSecondsRemaining"": ""0"",
        ""team"": [
          {
            ""spread"": ""3"",
            ""rushDefenseRank"": ""7"",
            ""rushOffenseRank"": ""13"",
            ""isHome"": ""0"",
            ""id"": ""SEA"",
            ""inRedZone"": ""0"",
            ""passOffenseRank"": ""9"",
            ""hasPossession"": ""0"",
            ""score"": ""31"",
            ""passDefenseRank"": ""12""
          },
          {
            ""passDefenseRank"": ""22"",
            ""score"": ""17"",
            ""hasPossession"": ""0"",
            ""passOffenseRank"": ""19"",
            ""inRedZone"": ""0"",
            ""id"": ""PIT"",
            ""isHome"": ""1"",
            ""rushOffenseRank"": ""22"",
            ""rushDefenseRank"": ""16"",
            ""spread"": ""-3.0""
          }
        ],
        ""kickoff"": ""1757869200""
      },
      {
        ""gameSecondsRemaining"": ""0"",
        ""kickoff"": ""1757869200"",
        ""team"": [
          {
            ""passDefenseRank"": ""29"",
            ""score"": ""37"",
            ""hasPossession"": ""0"",
            ""passOffenseRank"": ""1"",
            ""inRedZone"": ""0"",
            ""isHome"": ""0"",
            ""id"": ""NYG"",
            ""rushOffenseRank"": ""17"",
            ""rushDefenseRank"": ""21"",
            ""spread"": ""6""
          },
          {
            ""passOffenseRank"": ""2"",
            ""passDefenseRank"": ""30"",
            ""score"": ""40"",
            ""hasPossession"": ""0"",
            ""rushDefenseRank"": ""12"",
            ""spread"": ""-6.0"",
            ""inRedZone"": ""0"",
            ""isHome"": ""1"",
            ""id"": ""DAL"",
            ""rushOffenseRank"": ""8""
          }
        ]
      },
      {
        ""gameSecondsRemaining"": ""0"",
        ""kickoff"": ""1757869200"",
        ""team"": [
          {
            ""score"": ""21"",
            ""hasPossession"": ""0"",
            ""passDefenseRank"": ""28"",
            ""passOffenseRank"": ""17"",
            ""id"": ""CHI"",
            ""isHome"": ""0"",
            ""rushOffenseRank"": ""9"",
            ""inRedZone"": ""0"",
            ""rushDefenseRank"": ""26"",
            ""spread"": ""4.5""
          },
          {
            ""rushOffenseRank"": ""3"",
            ""id"": ""DET"",
            ""isHome"": ""1"",
            ""inRedZone"": ""0"",
            ""spread"": ""-4.5"",
            ""rushDefenseRank"": ""20"",
            ""hasPossession"": ""0"",
            ""score"": ""52"",
            ""passDefenseRank"": ""14"",
            ""passOffenseRank"": ""3""
          }
        ]
      },
      {
        ""gameSecondsRemaining"": ""0"",
        ""team"": [
          {
            ""spread"": ""-4.5"",
            ""rushDefenseRank"": ""18"",
            ""rushOffenseRank"": ""21"",
            ""id"": ""SFO"",
            ""isHome"": ""0"",
            ""inRedZone"": ""0"",
            ""passOffenseRank"": ""11"",
            ""hasPossession"": ""0"",
            ""score"": ""26"",
            ""passDefenseRank"": ""10""
          },
          {
            ""spread"": ""4.5"",
            ""rushDefenseRank"": ""8"",
            ""inRedZone"": ""0"",
            ""rushOffenseRank"": ""11"",
            ""isHome"": ""1"",
            ""id"": ""NOS"",
            ""passOffenseRank"": ""21"",
            ""passDefenseRank"": ""20"",
            ""hasPossession"": ""0"",
            ""score"": ""21""
          }
        ],
        ""kickoff"": ""1757869200""
      },
      {
        ""gameSecondsRemaining"": ""0"",
        ""kickoff"": ""1757869200"",
        ""team"": [
          {
            ""passDefenseRank"": ""13"",
            ""hasPossession"": ""0"",
            ""score"": ""17"",
            ""passOffenseRank"": ""15"",
            ""inRedZone"": ""0"",
            ""rushOffenseRank"": ""14"",
            ""isHome"": ""0"",
            ""id"": ""CLE"",
            ""spread"": ""10.5"",
            ""rushDefenseRank"": ""1""
          },
          {
            ""passOffenseRank"": ""18"",
            ""hasPossession"": ""0"",
            ""score"": ""41"",
            ""passDefenseRank"": ""16"",
            ""spread"": ""-10.5"",
            ""rushDefenseRank"": ""15"",
            ""rushOffenseRank"": ""28"",
            ""id"": ""BAL"",
            ""isHome"": ""1"",
            ""inRedZone"": ""0""
          }
        ]
      },
      {
        ""team"": [
          {
            ""passDefenseRank"": ""27"",
            ""hasPossession"": ""0"",
            ""score"": ""28"",
            ""passOffenseRank"": ""16"",
            ""inRedZone"": ""0"",
            ""rushOffenseRank"": ""12"",
            ""isHome"": ""0"",
            ""id"": ""DEN"",
            ""spread"": ""-2.5"",
            ""rushDefenseRank"": ""24""
          },
          {
            ""passOffenseRank"": ""4"",
            ""passDefenseRank"": ""15"",
            ""score"": ""29"",
            ""hasPossession"": ""0"",
            ""rushDefenseRank"": ""17"",
            ""spread"": ""2.5"",
            ""inRedZone"": ""0"",
            ""isHome"": ""1"",
            ""id"": ""IND"",
            ""rushOffenseRank"": ""5""
          }
        ],
        ""kickoff"": ""1757880300"",
        ""gameSecondsRemaining"": ""0""
      },
      {
        ""kickoff"": ""1757880300"",
        ""team"": [
          {
            ""passOffenseRank"": ""5"",
            ""passDefenseRank"": ""17"",
            ""score"": ""22"",
            ""hasPossession"": ""0"",
            ""rushDefenseRank"": ""11"",
            ""spread"": ""6.5"",
            ""inRedZone"": ""0"",
            ""id"": ""CAR"",
            ""isHome"": ""0"",
            ""rushOffenseRank"": ""26""
          },
          {
            ""inRedZone"": ""0"",
            ""rushOffenseRank"": ""18"",
            ""id"": ""ARI"",
            ""isHome"": ""1"",
            ""spread"": ""-6.5"",
            ""rushDefenseRank"": ""3"",
            ""passDefenseRank"": ""26"",
            ""hasPossession"": ""0"",
            ""score"": ""27"",
            ""passOffenseRank"": ""14""
          }
        ],
        ""gameSecondsRemaining"": ""0""
      },
      {
        ""team"": [
          {
            ""passOffenseRank"": ""29"",
            ""hasPossession"": ""0"",
            ""score"": ""20"",
            ""passDefenseRank"": ""7"",
            ""spread"": ""-1.5"",
            ""rushDefenseRank"": ""18"",
            ""rushOffenseRank"": ""10"",
            ""isHome"": ""0"",
            ""id"": ""PHI"",
            ""inRedZone"": ""0""
          },
          {
            ""passOffenseRank"": ""24"",
            ""passDefenseRank"": ""2"",
            ""score"": ""17"",
            ""hasPossession"": ""0"",
            ""rushDefenseRank"": ""19"",
            ""spread"": ""1.5"",
            ""inRedZone"": ""0"",
            ""isHome"": ""1"",
            ""id"": ""KCC"",
            ""rushOffenseRank"": ""11""
          }
        ],
        ""kickoff"": ""1757881500"",
        ""gameSecondsRemaining"": ""0""
      },
      {
        ""gameSecondsRemaining"": ""0"",
        ""team"": [
          {
            ""rushDefenseRank"": ""9"",
            ""spread"": ""5.5"",
            ""inRedZone"": ""0"",
            ""id"": ""ATL"",
            ""isHome"": ""0"",
            ""rushOffenseRank"": ""2"",
            ""passOffenseRank"": ""28"",
            ""passDefenseRank"": ""4"",
            ""score"": ""22"",
            ""hasPossession"": ""0""
          },
          {
            ""passOffenseRank"": ""27"",
            ""score"": ""6"",
            ""hasPossession"": ""0"",
            ""passDefenseRank"": ""3"",
            ""rushDefenseRank"": ""27"",
            ""spread"": ""-5.5"",
            ""id"": ""MIN"",
            ""isHome"": ""1"",
            ""rushOffenseRank"": ""20"",
            ""inRedZone"": ""0""
          }
        ],
        ""kickoff"": ""1757895600""
      },
      {
        ""gameSecondsRemaining"": ""0"",
        ""kickoff"": ""1757977200"",
        ""team"": [
          {
            ""spread"": ""3"",
            ""rushDefenseRank"": ""12"",
            ""inRedZone"": ""0"",
            ""rushOffenseRank"": ""4"",
            ""id"": ""TBB"",
            ""isHome"": ""0"",
            ""passOffenseRank"": ""20"",
            ""passDefenseRank"": ""9"",
            ""hasPossession"": ""0"",
            ""score"": ""20""
          },
          {
            ""inRedZone"": ""0"",
            ""rushOffenseRank"": ""17"",
            ""id"": ""HOU"",
            ""isHome"": ""1"",
            ""spread"": ""-3.0"",
            ""rushDefenseRank"": ""25"",
            ""passDefenseRank"": ""11"",
            ""hasPossession"": ""0"",
            ""score"": ""19"",
            ""passOffenseRank"": ""22""
          }
        ]
      },
      {
        ""kickoff"": ""1757988000"",
        ""team"": [
          {
            ""passOffenseRank"": ""13"",
            ""hasPossession"": ""0"",
            ""score"": ""20"",
            ""passDefenseRank"": ""6"",
            ""spread"": ""-3.5"",
            ""rushDefenseRank"": ""6"",
            ""rushOffenseRank"": ""19"",
            ""isHome"": ""0"",
            ""id"": ""LAC"",
            ""inRedZone"": ""0""
          },
          {
            ""rushDefenseRank"": ""10"",
            ""spread"": ""3.5"",
            ""inRedZone"": ""0"",
            ""id"": ""LVR"",
            ""isHome"": ""1"",
            ""rushOffenseRank"": ""23"",
            ""passOffenseRank"": ""25"",
            ""passDefenseRank"": ""18"",
            ""score"": ""9"",
            ""hasPossession"": ""0""
          }
        ],
        ""gameSecondsRemaining"": ""0""
      }
    ]
  },
  ""encoding"": ""utf-8""
}";

    [Fact]
    public void DeserializeStaticFullSeasonNFLData()
    {

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        var root = JsonSerializer.Deserialize<theNfl.NFLAllWeeksRoot>(fullSeasonJson, options);

        Assert.NotNull(root);
        Assert.True(root.FullNflSchedule.NflScheduleWeeks.Count >= 18);
    }

    [Fact]
    public void DeserializeStaticSingleWeekNFLData()
    {

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        var root = JsonSerializer.Deserialize<theNfl.NFLOneWeekRoot>(oneWeekJson, options);

        Assert.NotNull(root);
        Assert.True(root.NflSchedule.Matchups.Count >= 16);
    }

}
