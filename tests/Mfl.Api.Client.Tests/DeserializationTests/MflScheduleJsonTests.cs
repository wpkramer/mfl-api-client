
using System.Text.Json;
using mflSched = Mfl.Api.Model.MflSchedule;

namespace Mfl.Api.Client.Tests.DeserializationTests;


public class MflScheduleJsonTests
{
    private readonly JsonSerializerOptions _options = new() { PropertyNameCaseInsensitive = true };

    private readonly string sampleJson = @"{
  ""schedule"": {
    ""weeklySchedule"": [
      {
        ""matchup"": [
          {
            ""franchise"": [
              {
                ""result"": ""W"",
                ""score"": ""67"",
                ""id"": ""0001"",
                ""isHome"": ""0""
              },
              {
                ""isHome"": ""1"",
                ""id"": ""0007"",
                ""score"": ""42"",
                ""result"": ""L""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""id"": ""0003"",
                ""score"": ""65"",
                ""isHome"": ""0"",
                ""result"": ""L""
              },
              {
                ""result"": ""W"",
                ""isHome"": ""1"",
                ""id"": ""0008"",
                ""score"": ""86""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""isHome"": ""0"",
                ""score"": ""69"",
                ""id"": ""0005"",
                ""result"": ""W""
              },
              {
                ""score"": ""46"",
                ""id"": ""0009"",
                ""isHome"": ""1"",
                ""result"": ""L""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""L"",
                ""id"": ""0006"",
                ""score"": ""37"",
                ""isHome"": ""0""
              },
              {
                ""id"": ""0010"",
                ""score"": ""65"",
                ""isHome"": ""1"",
                ""result"": ""W""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""L"",
                ""isHome"": ""0"",
                ""id"": ""0004"",
                ""score"": ""58""
              },
              {
                ""result"": ""W"",
                ""isHome"": ""1"",
                ""id"": ""0002"",
                ""score"": ""59""
              }
            ]
          }
        ],
        ""week"": ""1""
      },
      {
        ""week"": ""2"",
        ""matchup"": [
          {
            ""franchise"": [
              {
                ""id"": ""0009"",
                ""score"": ""45"",
                ""isHome"": ""0"",
                ""result"": ""L""
              },
              {
                ""isHome"": ""1"",
                ""id"": ""0001"",
                ""score"": ""123"",
                ""result"": ""W""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""id"": ""0007"",
                ""score"": ""91"",
                ""isHome"": ""0"",
                ""result"": ""W""
              },
              {
                ""result"": ""L"",
                ""isHome"": ""1"",
                ""id"": ""0008"",
                ""score"": ""50""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""isHome"": ""0"",
                ""score"": ""62"",
                ""id"": ""0004"",
                ""result"": ""L""
              },
              {
                ""isHome"": ""1"",
                ""id"": ""0003"",
                ""score"": ""79"",
                ""result"": ""W""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""L"",
                ""score"": ""57"",
                ""id"": ""0005"",
                ""isHome"": ""0""
              },
              {
                ""result"": ""W"",
                ""score"": ""85"",
                ""id"": ""0006"",
                ""isHome"": ""1""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""isHome"": ""0"",
                ""score"": ""40"",
                ""id"": ""0010"",
                ""result"": ""L""
              },
              {
                ""result"": ""W"",
                ""id"": ""0002"",
                ""score"": ""67"",
                ""isHome"": ""1""
              }
            ]
          }
        ]
      },
      {
        ""matchup"": [
          {
            ""franchise"": [
              {
                ""result"": ""L"",
                ""id"": ""0003"",
                ""score"": ""56"",
                ""isHome"": ""0""
              },
              {
                ""id"": ""0007"",
                ""score"": ""68"",
                ""isHome"": ""1"",
                ""result"": ""W""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""isHome"": ""0"",
                ""id"": ""0008"",
                ""score"": ""65"",
                ""result"": ""W""
              },
              {
                ""result"": ""L"",
                ""isHome"": ""1"",
                ""id"": ""0009"",
                ""score"": ""63""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""W"",
                ""isHome"": ""0"",
                ""score"": ""44"",
                ""id"": ""0004""
              },
              {
                ""result"": ""L"",
                ""isHome"": ""1"",
                ""score"": ""42"",
                ""id"": ""0010""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""L"",
                ""isHome"": ""0"",
                ""score"": ""57"",
                ""id"": ""0001""
              },
              {
                ""result"": ""W"",
                ""id"": ""0006"",
                ""score"": ""70"",
                ""isHome"": ""1""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""W"",
                ""isHome"": ""0"",
                ""score"": ""62"",
                ""id"": ""0002""
              },
              {
                ""isHome"": ""1"",
                ""id"": ""0005"",
                ""score"": ""54"",
                ""result"": ""L""
              }
            ]
          }
        ],
        ""week"": ""3""
      },
      {
        ""week"": ""4"",
        ""matchup"": [
          {
            ""franchise"": [
              {
                ""isHome"": ""0"",
                ""score"": ""57"",
                ""id"": ""0002"",
                ""result"": ""L""
              },
              {
                ""result"": ""W"",
                ""score"": ""84"",
                ""id"": ""0008"",
                ""isHome"": ""1""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""isHome"": ""0"",
                ""score"": ""79"",
                ""id"": ""0001"",
                ""result"": ""W""
              },
              {
                ""result"": ""L"",
                ""isHome"": ""1"",
                ""id"": ""0003"",
                ""score"": ""78""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""score"": ""65"",
                ""id"": ""0007"",
                ""isHome"": ""0"",
                ""result"": ""W""
              },
              {
                ""result"": ""L"",
                ""isHome"": ""1"",
                ""id"": ""0009"",
                ""score"": ""58""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""id"": ""0006"",
                ""score"": ""83"",
                ""isHome"": ""0"",
                ""result"": ""L""
              },
              {
                ""isHome"": ""1"",
                ""score"": ""84"",
                ""id"": ""0004"",
                ""result"": ""W""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""W"",
                ""isHome"": ""0"",
                ""score"": ""110"",
                ""id"": ""0010""
              },
              {
                ""id"": ""0005"",
                ""score"": ""86"",
                ""isHome"": ""1"",
                ""result"": ""L""
              }
            ]
          }
        ]
      },
      {
        ""matchup"": [
          {
            ""franchise"": [
              {
                ""score"": ""74"",
                ""id"": ""0010"",
                ""isHome"": ""0"",
                ""result"": ""L""
              },
              {
                ""result"": ""W"",
                ""isHome"": ""1"",
                ""score"": ""109"",
                ""id"": ""0007""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""L"",
                ""id"": ""0008"",
                ""score"": ""58"",
                ""isHome"": ""0""
              },
              {
                ""isHome"": ""1"",
                ""id"": ""0001"",
                ""score"": ""81"",
                ""result"": ""W""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""id"": ""0009"",
                ""score"": ""68"",
                ""isHome"": ""0"",
                ""result"": ""L""
              },
              {
                ""isHome"": ""1"",
                ""score"": ""84"",
                ""id"": ""0003"",
                ""result"": ""W""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""W"",
                ""id"": ""0002"",
                ""score"": ""90"",
                ""isHome"": ""0""
              },
              {
                ""result"": ""L"",
                ""isHome"": ""1"",
                ""id"": ""0006"",
                ""score"": ""63""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""W"",
                ""score"": ""91"",
                ""id"": ""0005"",
                ""isHome"": ""0""
              },
              {
                ""result"": ""L"",
                ""id"": ""0004"",
                ""score"": ""47"",
                ""isHome"": ""1""
              }
            ]
          }
        ],
        ""week"": ""5""
      },
      {
        ""matchup"": [
          {
            ""franchise"": [
              {
                ""isHome"": ""0"",
                ""score"": ""88"",
                ""id"": ""0006"",
                ""result"": ""L""
              },
              {
                ""result"": ""W"",
                ""isHome"": ""1"",
                ""id"": ""0007"",
                ""score"": ""91""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""W"",
                ""id"": ""0002"",
                ""score"": ""81"",
                ""isHome"": ""0""
              },
              {
                ""result"": ""L"",
                ""isHome"": ""1"",
                ""score"": ""70"",
                ""id"": ""0001""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""T"",
                ""id"": ""0004"",
                ""score"": ""56"",
                ""isHome"": ""0""
              },
              {
                ""result"": ""T"",
                ""score"": ""56"",
                ""id"": ""0008"",
                ""isHome"": ""1""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""W"",
                ""isHome"": ""0"",
                ""score"": ""77"",
                ""id"": ""0005""
              },
              {
                ""isHome"": ""1"",
                ""score"": ""50"",
                ""id"": ""0003"",
                ""result"": ""L""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""L"",
                ""score"": ""47"",
                ""id"": ""0010"",
                ""isHome"": ""0""
              },
              {
                ""result"": ""W"",
                ""id"": ""0009"",
                ""score"": ""52"",
                ""isHome"": ""1""
              }
            ]
          }
        ],
        ""week"": ""6""
      },
      {
        ""week"": ""7"",
        ""matchup"": [
          {
            ""franchise"": [
              {
                ""result"": ""W"",
                ""isHome"": ""0"",
                ""score"": ""70"",
                ""id"": ""0003""
              },
              {
                ""result"": ""L"",
                ""isHome"": ""1"",
                ""id"": ""0010"",
                ""score"": ""45""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""L"",
                ""isHome"": ""0"",
                ""score"": ""79"",
                ""id"": ""0009""
              },
              {
                ""result"": ""W"",
                ""isHome"": ""1"",
                ""id"": ""0006"",
                ""score"": ""96""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""L"",
                ""score"": ""95"",
                ""id"": ""0007"",
                ""isHome"": ""0""
              },
              {
                ""result"": ""W"",
                ""id"": ""0002"",
                ""score"": ""119"",
                ""isHome"": ""1""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""L"",
                ""isHome"": ""0"",
                ""id"": ""0001"",
                ""score"": ""65""
              },
              {
                ""result"": ""W"",
                ""isHome"": ""1"",
                ""id"": ""0004"",
                ""score"": ""80""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""score"": ""78"",
                ""id"": ""0008"",
                ""isHome"": ""0"",
                ""result"": ""W""
              },
              {
                ""isHome"": ""1"",
                ""score"": ""40"",
                ""id"": ""0005"",
                ""result"": ""L""
              }
            ]
          }
        ]
      },
      {
        ""matchup"": [
          {
            ""franchise"": [
              {
                ""result"": ""W"",
                ""isHome"": ""0"",
                ""id"": ""0008"",
                ""score"": ""88""
              },
              {
                ""isHome"": ""1"",
                ""id"": ""0010"",
                ""score"": ""74"",
                ""result"": ""L""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""id"": ""0003"",
                ""score"": ""70"",
                ""isHome"": ""0"",
                ""result"": ""L""
              },
              {
                ""result"": ""W"",
                ""id"": ""0006"",
                ""score"": ""110"",
                ""isHome"": ""1""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""isHome"": ""0"",
                ""id"": ""0009"",
                ""score"": ""52"",
                ""result"": ""L""
              },
              {
                ""result"": ""W"",
                ""id"": ""0002"",
                ""score"": ""58"",
                ""isHome"": ""1""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""L"",
                ""id"": ""0007"",
                ""score"": ""59"",
                ""isHome"": ""0""
              },
              {
                ""result"": ""W"",
                ""isHome"": ""1"",
                ""id"": ""0004"",
                ""score"": ""69""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""isHome"": ""0"",
                ""score"": ""61"",
                ""id"": ""0001"",
                ""result"": ""L""
              },
              {
                ""id"": ""0005"",
                ""score"": ""92"",
                ""isHome"": ""1"",
                ""result"": ""W""
              }
            ]
          }
        ],
        ""week"": ""8""
      },
      {
        ""week"": ""9"",
        ""matchup"": [
          {
            ""franchise"": [
              {
                ""result"": ""W"",
                ""isHome"": ""0"",
                ""score"": ""64"",
                ""id"": ""0005""
              },
              {
                ""isHome"": ""1"",
                ""score"": ""49"",
                ""id"": ""0007"",
                ""result"": ""L""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""isHome"": ""0"",
                ""score"": ""55"",
                ""id"": ""0010"",
                ""result"": ""L""
              },
              {
                ""id"": ""0001"",
                ""score"": ""63"",
                ""isHome"": ""1"",
                ""result"": ""W""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""W"",
                ""id"": ""0006"",
                ""score"": ""84"",
                ""isHome"": ""0""
              },
              {
                ""id"": ""0008"",
                ""score"": ""58"",
                ""isHome"": ""1"",
                ""result"": ""L""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""isHome"": ""0"",
                ""id"": ""0002"",
                ""score"": ""78"",
                ""result"": ""L""
              },
              {
                ""isHome"": ""1"",
                ""id"": ""0003"",
                ""score"": ""124"",
                ""result"": ""W""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""isHome"": ""0"",
                ""score"": ""99"",
                ""id"": ""0004"",
                ""result"": ""W""
              },
              {
                ""score"": ""50"",
                ""id"": ""0009"",
                ""isHome"": ""1"",
                ""result"": ""L""
              }
            ]
          }
        ]
      },
      {
        ""week"": ""10"",
        ""matchup"": [
          {
            ""franchise"": [
              {
                ""isHome"": ""0"",
                ""score"": ""77"",
                ""id"": ""0009"",
                ""result"": ""W""
              },
              {
                ""result"": ""L"",
                ""id"": ""0010"",
                ""score"": ""58"",
                ""isHome"": ""1""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""W"",
                ""score"": ""56"",
                ""id"": ""0007"",
                ""isHome"": ""0""
              },
              {
                ""id"": ""0006"",
                ""score"": ""49"",
                ""isHome"": ""1"",
                ""result"": ""L""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""L"",
                ""isHome"": ""0"",
                ""score"": ""76"",
                ""id"": ""0001""
              },
              {
                ""result"": ""W"",
                ""score"": ""94"",
                ""id"": ""0002"",
                ""isHome"": ""1""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""isHome"": ""0"",
                ""score"": ""43"",
                ""id"": ""0008"",
                ""result"": ""L""
              },
              {
                ""isHome"": ""1"",
                ""id"": ""0004"",
                ""score"": ""59"",
                ""result"": ""W""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""isHome"": ""0"",
                ""score"": ""61"",
                ""id"": ""0003"",
                ""result"": ""L""
              },
              {
                ""result"": ""W"",
                ""isHome"": ""1"",
                ""id"": ""0005"",
                ""score"": ""86""
              }
            ]
          }
        ]
      },
      {
        ""week"": ""11"",
        ""matchup"": [
          {
            ""franchise"": [
              {
                ""id"": ""0002"",
                ""score"": ""73"",
                ""isHome"": ""0"",
                ""result"": ""W""
              },
              {
                ""isHome"": ""1"",
                ""score"": ""52"",
                ""id"": ""0007"",
                ""result"": ""L""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""L"",
                ""isHome"": ""0"",
                ""score"": ""75"",
                ""id"": ""0004""
              },
              {
                ""result"": ""W"",
                ""id"": ""0001"",
                ""score"": ""90"",
                ""isHome"": ""1""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""isHome"": ""0"",
                ""score"": ""87"",
                ""id"": ""0005"",
                ""result"": ""W""
              },
              {
                ""isHome"": ""1"",
                ""score"": ""59"",
                ""id"": ""0008"",
                ""result"": ""L""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""L"",
                ""id"": ""0010"",
                ""score"": ""35"",
                ""isHome"": ""0""
              },
              {
                ""isHome"": ""1"",
                ""id"": ""0003"",
                ""score"": ""62"",
                ""result"": ""W""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""W"",
                ""isHome"": ""0"",
                ""id"": ""0006"",
                ""score"": ""49""
              },
              {
                ""result"": ""L"",
                ""isHome"": ""1"",
                ""score"": ""39"",
                ""id"": ""0009""
              }
            ]
          }
        ]
      },
      {
        ""matchup"": [
          {
            ""franchise"": [
              {
                ""id"": ""0008"",
                ""score"": ""47"",
                ""isHome"": ""0"",
                ""result"": ""L""
              },
              {
                ""result"": ""W"",
                ""isHome"": ""1"",
                ""id"": ""0007"",
                ""score"": ""71""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""score"": ""69"",
                ""id"": ""0001"",
                ""isHome"": ""0"",
                ""result"": ""L""
              },
              {
                ""isHome"": ""1"",
                ""id"": ""0009"",
                ""score"": ""113"",
                ""result"": ""W""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""W"",
                ""isHome"": ""0"",
                ""score"": ""65"",
                ""id"": ""0002""
              },
              {
                ""isHome"": ""1"",
                ""id"": ""0010"",
                ""score"": ""35"",
                ""result"": ""L""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""W"",
                ""id"": ""0003"",
                ""score"": ""65"",
                ""isHome"": ""0""
              },
              {
                ""result"": ""L"",
                ""isHome"": ""1"",
                ""score"": ""41"",
                ""id"": ""0004""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""isHome"": ""0"",
                ""id"": ""0006"",
                ""score"": ""75"",
                ""result"": ""W""
              },
              {
                ""isHome"": ""1"",
                ""score"": ""40"",
                ""id"": ""0005"",
                ""result"": ""L""
              }
            ]
          }
        ],
        ""week"": ""12""
      },
      {
        ""week"": ""13"",
        ""matchup"": [
          {
            ""franchise"": [
              {
                ""isHome"": ""0"",
                ""score"": ""94"",
                ""id"": ""0007"",
                ""result"": ""W""
              },
              {
                ""isHome"": ""1"",
                ""score"": ""56"",
                ""id"": ""0001"",
                ""result"": ""L""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""W"",
                ""isHome"": ""0"",
                ""score"": ""65"",
                ""id"": ""0003""
              },
              {
                ""result"": ""L"",
                ""isHome"": ""1"",
                ""id"": ""0009"",
                ""score"": ""58""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""L"",
                ""score"": ""39"",
                ""id"": ""0010"",
                ""isHome"": ""0""
              },
              {
                ""result"": ""W"",
                ""id"": ""0006"",
                ""score"": ""44"",
                ""isHome"": ""1""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""L"",
                ""score"": ""74"",
                ""id"": ""0008"",
                ""isHome"": ""0""
              },
              {
                ""result"": ""W"",
                ""id"": ""0002"",
                ""score"": ""78"",
                ""isHome"": ""1""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""score"": ""56"",
                ""id"": ""0004"",
                ""isHome"": ""0"",
                ""result"": ""L""
              },
              {
                ""id"": ""0005"",
                ""score"": ""71"",
                ""isHome"": ""1"",
                ""result"": ""W""
              }
            ]
          }
        ]
      },
      {
        ""week"": ""14"",
        ""matchup"": [
          {
            ""franchise"": [
              {
                ""id"": ""0009"",
                ""score"": ""73"",
                ""isHome"": ""0"",
                ""result"": ""W""
              },
              {
                ""result"": ""L"",
                ""id"": ""0007"",
                ""score"": ""44"",
                ""isHome"": ""1""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""score"": ""98"",
                ""id"": ""0006"",
                ""isHome"": ""0"",
                ""result"": ""L""
              },
              {
                ""result"": ""W"",
                ""score"": ""109"",
                ""id"": ""0001"",
                ""isHome"": ""1""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""L"",
                ""isHome"": ""0"",
                ""id"": ""0008"",
                ""score"": ""79""
              },
              {
                ""isHome"": ""1"",
                ""id"": ""0003"",
                ""score"": ""88"",
                ""result"": ""W""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""W"",
                ""isHome"": ""0"",
                ""id"": ""0005"",
                ""score"": ""68""
              },
              {
                ""isHome"": ""1"",
                ""id"": ""0010"",
                ""score"": ""30"",
                ""result"": ""L""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""L"",
                ""isHome"": ""0"",
                ""id"": ""0002"",
                ""score"": ""90""
              },
              {
                ""result"": ""W"",
                ""isHome"": ""1"",
                ""id"": ""0004"",
                ""score"": ""94""
              }
            ]
          }
        ]
      },
      {
        ""matchup"": [
          {
            ""franchise"": [
              {
                ""id"": ""0001"",
                ""spread"": ""8"",
                ""isHome"": ""0"",
                ""result"": ""T""
              },
              {
                ""result"": ""T"",
                ""isHome"": ""1"",
                ""spread"": ""-8"",
                ""id"": ""0008""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""result"": ""T"",
                ""isHome"": ""0"",
                ""spread"": ""7"",
                ""id"": ""0007""
              },
              {
                ""isHome"": ""1"",
                ""id"": ""0003"",
                ""spread"": ""-7"",
                ""result"": ""T""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""spread"": ""3"",
                ""id"": ""0006"",
                ""isHome"": ""0"",
                ""result"": ""T""
              },
              {
                ""result"": ""T"",
                ""isHome"": ""1"",
                ""spread"": ""-3"",
                ""id"": ""0002""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""isHome"": ""0"",
                ""spread"": ""-17"",
                ""id"": ""0010"",
                ""result"": ""T""
              },
              {
                ""result"": ""T"",
                ""spread"": ""17"",
                ""id"": ""0004"",
                ""isHome"": ""1""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""spread"": ""4"",
                ""id"": ""0009"",
                ""isHome"": ""0"",
                ""result"": ""T""
              },
              {
                ""id"": ""0005"",
                ""spread"": ""-4"",
                ""isHome"": ""1"",
                ""result"": ""T""
              }
            ]
          }
        ],
        ""week"": ""15""
      },
      {
        ""week"": ""16"",
        ""matchup"": [
          {
            ""franchise"": [
              {
                ""result"": ""T"",
                ""isHome"": ""0"",
                ""spread"": ""3.5"",
                ""id"": ""0003""
              },
              {
                ""isHome"": ""1"",
                ""id"": ""0001"",
                ""spread"": ""-3.5"",
                ""result"": ""T""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""isHome"": ""0"",
                ""id"": ""0009"",
                ""spread"": ""3.7"",
                ""result"": ""T""
              },
              {
                ""result"": ""T"",
                ""isHome"": ""1"",
                ""id"": ""0008"",
                ""spread"": ""-3.7""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""id"": ""0007"",
                ""spread"": ""-16.9"",
                ""isHome"": ""0"",
                ""result"": ""T""
              },
              {
                ""spread"": ""16.9"",
                ""id"": ""0010"",
                ""isHome"": ""1"",
                ""result"": ""T""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""isHome"": ""0"",
                ""spread"": ""7.6"",
                ""id"": ""0004"",
                ""result"": ""T""
              },
              {
                ""result"": ""T"",
                ""isHome"": ""1"",
                ""spread"": ""-7.6"",
                ""id"": ""0006""
              }
            ]
          },
          {
            ""franchise"": [
              {
                ""spread"": ""6.4"",
                ""id"": ""0005"",
                ""isHome"": ""0"",
                ""result"": ""T""
              },
              {
                ""result"": ""T"",
                ""isHome"": ""1"",
                ""id"": ""0002"",
                ""spread"": ""-6.4""
              }
            ]
          }
        ]
      },
      {
        ""week"": ""17""
      }
    ]
  },
  ""version"": ""1.0"",
  ""encoding"": ""utf-8""
}";
    
    
    [Fact]
    public void DeserializeSampleData()
    {

        var root = JsonSerializer.Deserialize<mflSched.MflScheduleRoot>(sampleJson, _options);
        Assert.NotNull(root);
        var schedule = root.Schedule;
        // Week 1, first matchup
       

        {
            var week = schedule.WeeklySchedules.First(w => w.Week == "1");
            var matchup = week.Matchups[0];

            var (away, home) = matchup.Teams; // Deconstructor magic

            Assert.Equal("0001", away.Id);
            Assert.Equal("0007", home.Id);
            Assert.Equal(67.0, away.ScoreValue);
            Assert.Equal(42.0, home.ScoreValue);
        }

        {
            var week = schedule.WeeklySchedules.First(w => w.Week == "15");
            var matchup = week.Matchups[0];

            var (away, home) = matchup.Teams; // Deconstructor magic

            Assert.Equal("0001", away.Id);
            Assert.Equal("0008", home.Id);
            Assert.Equal(8, int.Parse(away.Spread));
            Assert.Equal(-8, int.Parse(home.Spread));
        }


    }
}
