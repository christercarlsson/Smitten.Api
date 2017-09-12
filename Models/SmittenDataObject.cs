using System.Collections.Generic;
using System;

namespace Smitten.Api.Models
{
    public class SmittenDataObject
    {
        public static SmittenDataObject GetData { get; } = new SmittenDataObject();
        public List<PersonDto> People { get; set; }

        public SmittenDataObject()
        {
            People = new List<PersonDto> {
                new PersonDto {
                    Id = new Guid("ddff3d1b-a0b6-4d93-87dd-f4c46edb59c5"),
                    Name = "Christer Carlsson",
                    ImageUri = new Uri("https://realgymnasiet.se/wp-content/uploads/2014/10/christer-carlsson-laerare-wpcf_147x220.jpg"),
                    Smites = new List<SmiteDto> {
                        new SmiteDto {
                            Id = new Guid("da13099c-06ec-49ed-8ecb-47fb74766033"),
                            Date = new DateTimeOffset( new DateTime(2017, 10, 10, 10, 00, 00, 00))
                        },
                        new SmiteDto {
                            Id = new Guid("6d920fd7-cfbc-4591-854c-93fef5a7aab8"),
                            Date = new DateTimeOffset( new DateTime(2017, 10, 10, 10, 00, 00, 00))
                        },
                        new SmiteDto {
                            Id = new Guid("47e44def-26b7-40bf-ac62-d48c378ace76"),
                            Date = new DateTimeOffset( new DateTime(2017, 10, 10, 10, 00, 00, 00))
                        }
                    }
                },
                new PersonDto {
                    Id = new Guid("3616af39-5ded-4387-8721-d778a1c8b0e3"),
                    Name = "Joakim Nygren",
                    ImageUri = new Uri("https://realgymnasiet.se/wp-content/uploads/2014/10/joakim-nygren-laerare-wpcf_147x220.gif"),
                    Smites = new List<SmiteDto> {
                        new SmiteDto {
                            Id = new Guid("ca6dfd8c-4b18-4f55-b505-4869d42ba723"),
                            Date = new DateTimeOffset( new DateTime(2017, 10, 10, 10, 00, 00, 00))
                        },
                        new SmiteDto {
                            Id = new Guid("ae87ba6e-240c-4d74-8038-009efb03d2bc"),
                            Date = new DateTimeOffset( new DateTime(2017, 10, 10, 10, 00, 00, 00))
                        },
                        new SmiteDto {
                            Id = new Guid("892c234b-1425-444b-bf20-930a52850d91"),
                            Date = new DateTimeOffset( new DateTime(2017, 10, 10, 10, 00, 00, 00))
                        }
                    }
                },
                new PersonDto {
                    Id = new Guid("7bafb0fc-15e6-488b-9a91-7be941a32698"),
                    Name = "Stefan Segerbrand",
                    ImageUri = new Uri("https://realgymnasiet.se/wp-content/uploads/2014/09/IMG_6203-wpcf_147x220.jpg"),
                    Smites = new List<SmiteDto> {
                        new SmiteDto {
                            Id = new Guid("1401b83e-d789-4907-99f2-b2e173b45408"),
                            Date = new DateTimeOffset( new DateTime(2017, 10, 10, 10, 00, 00, 00))
                        },
                        new SmiteDto {
                            Id = new Guid("eafc18fe-9663-4978-859a-de247a6d8509"),
                            Date = new DateTimeOffset( new DateTime(2017, 10, 10, 10, 00, 00, 00))
                        },
                        new SmiteDto {
                            Id = new Guid("c943981a-e8b0-4e8a-b624-096b38e2b331"),
                            Date = new DateTimeOffset( new DateTime(2017, 10, 10, 10, 00, 00, 00))
                        }
                    }
                }

            };
        }
    }
}