using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smitten.Api.Entities
{
    public static class SmittenContextExtentions
    {
        public static void EnsureSeedDataForDevelopment(this SmittenContext context)
        {
            //Clear database...
            context.People.RemoveRange(context.People);
            context.SaveChanges();

            // seed data
            var people = new List<Person>
            {
                new Person
                {
                    Id = new Guid("81ab9ae5-dc77-4259-9f05-c1efd2a7028a"),
                    FirstName = "Walter",
                    LastName = "Jonasson",
                    ImageUri = "http://www.randalolson.com/wp-content/uploads/blank.jpg",
                    Smites = new List<Smite>
                    {
                        new Smite
                        {
                            Id = new Guid("9cca0fb8-14a4-4c04-a4aa-50cab6a0a4e5"),
                            TimeOfSmite = new DateTimeOffset(new DateTime(2017, 4, 10, 10,02,00))
                        },
                        new Smite
                        {
                            Id = new Guid("6b82d930-ada9-4878-940e-234108006d27"),
                            TimeOfSmite = new DateTimeOffset(new DateTime(2017, 4, 11, 10,02,00))
                        },
                        new Smite
                        {
                            Id = new Guid("7099d57b-69de-4120-ad1c-54eabb529d3c"),
                            TimeOfSmite = new DateTimeOffset(new DateTime(2017, 4, 11, 15,02,00))
                        },
                        new Smite
                        {
                            Id = new Guid("46d8896d-0aa4-4421-8eed-a4f55e3d587c"),
                            TimeOfSmite = new DateTimeOffset(new DateTime(2017, 5, 2, 10,02,00))
                        }
                    }
                },
                new Person
                {
                    Id = new Guid("b7dffcf9-f4d3-434a-8712-36b135796d25"),
                    FirstName = "Osman",
                    LastName = "Lindgren",
                    ImageUri = "http://www.randalolson.com/wp-content/uploads/blank.jpg",
                    Smites = new List<Smite>
                    {
                        new Smite
                        {
                            Id = new Guid("ac71d38e-a275-4eb0-a31a-88f616408d98"),
                            TimeOfSmite = new DateTimeOffset(new DateTime(2017, 4, 10, 14,02,00))
                        },
                        new Smite
                        {
                            Id = new Guid("e0c480e8-eaba-4348-87b4-b55f14dd7d0e"),
                            TimeOfSmite = new DateTimeOffset(new DateTime(2017, 4, 11, 14,02,00))
                        },
                        new Smite
                        {
                            Id = new Guid("2220a744-70ec-43bf-8daa-d932fcfa4d75"),
                            TimeOfSmite = new DateTimeOffset(new DateTime(2017, 5, 2, 15,02,00))
                        },
                        new Smite
                        {
                            Id = new Guid("aeef7772-602a-4f57-b0e8-8448fa9858ae"),
                            TimeOfSmite = new DateTimeOffset(new DateTime(2017, 5, 2, 10,02,00))
                        }
                    }
                },
                new Person
                {
                    Id = new Guid("a1b5d421-fc7e-40df-a903-3f2cfa379725"),
                    FirstName = "Zakaria",
                    LastName = "Lindberg",
                    ImageUri = "http://www.randalolson.com/wp-content/uploads/blank.jpg",
                    Smites = new List<Smite>
                    {
                        new Smite
                        {
                            Id = new Guid("b67dfd22-088e-49e3-a089-7e5cb89b09ac"),
                            TimeOfSmite = new DateTimeOffset(new DateTime(2017, 5, 10, 10,02,00))
                        },
                        new Smite
                        {
                            Id = new Guid("b1182242-7357-40ef-b64d-3e8100a1f1ad"),
                            TimeOfSmite = new DateTimeOffset(new DateTime(2017, 5, 11, 10,02,00))
                        },
                        new Smite
                        {
                            Id = new Guid("bb2af2a0-45ce-4731-bd3d-aa8afa406203"),
                            TimeOfSmite = new DateTimeOffset(new DateTime(2017, 5, 3, 15,02,00))
                        },
                        new Smite
                        {
                            Id = new Guid("65bf9be9-d8e1-401b-8355-709bf1bac60b"),
                            TimeOfSmite = new DateTimeOffset(new DateTime(2017, 5, 2, 10,02,00))
                        }
                    }
                },
                new Person
                {
                    Id = new Guid("d59ec18b-235c-41a7-a6f6-f9fe074592b5"),
                    FirstName = "Hector",
                    LastName = "Lind",
                    ImageUri = "http://www.randalolson.com/wp-content/uploads/blank.jpg",
                    Smites = new List<Smite>
                    {
                        new Smite
                        {
                            Id = new Guid("f6d530ad-aa8c-4955-82cc-ed0fae810acd"),
                            TimeOfSmite = new DateTimeOffset(new DateTime(2017, 4, 9, 10,02,00))
                        },
                        new Smite
                        {
                            Id = new Guid("11752ae9-253b-4bd0-93ce-9d8512e506ff"),
                            TimeOfSmite = new DateTimeOffset(new DateTime(2017, 4, 9, 10,02,00))
                        },
                        new Smite
                        {
                            Id = new Guid("3649e5e0-5864-4bc9-9ee7-bfd0bece1b0a"),
                            TimeOfSmite = new DateTimeOffset(new DateTime(2017, 4, 7, 15,02,00))
                        },
                        new Smite
                        {
                            Id = new Guid("1116941d-7afc-4418-92e7-f180db9ddc5c"),
                            TimeOfSmite = new DateTimeOffset(new DateTime(2017, 4, 2, 10,02,00))
                        }
                    }
                },
                new Person
                {
                    Id = new Guid("3c0074bd-312a-4d38-b598-39eaef41cb92"),
                    FirstName = "Lia",
                    LastName = "Eliasson",
                    ImageUri = "http://www.randalolson.com/wp-content/uploads/blank.jpg",
                    Smites = new List<Smite>
                    {
                        new Smite
                        {
                            Id = new Guid( "c31849d5-16e1-4fe0-85f4-6d18445ef67c"),
                            TimeOfSmite = new DateTimeOffset(new DateTime(2017, 4, 20, 10,02,00))
                        },
                        new Smite
                        {
                            Id = new Guid("ef38d977-6669-4a17-bb39-d21542f3ea72"),
                            TimeOfSmite = new DateTimeOffset(new DateTime(2017, 4, 21, 10,02,00))
                        }
                    }
                },
                new Person
                {
                    Id = new Guid("6dabf8f1-0888-4bb2-9d75-0133bc995e94"),
                    FirstName = "Anders",
                    LastName = "Nyström",
                    ImageUri = "http://www.randalolson.com/wp-content/uploads/blank.jpg",
                    Smites = new List<Smite>
                    {
                        new Smite
                        {
                            Id = new Guid("478a4201-f267-409a-9cb3-57b3d5080b25"),
                            TimeOfSmite = new DateTimeOffset(new DateTime(2017, 4, 12, 10,02,00))
                        },
                        new Smite
                        {
                            Id = new Guid("50e4bcf0-b54f-4ba4-8e23-f1e81211cf44"),
                            TimeOfSmite = new DateTimeOffset(new DateTime(2017, 4, 24, 10,02,00))
                        },
                        new Smite
                        {
                            Id = new Guid("c556d1d8-6fb0-405e-b9d2-580bd30ad4e8"),
                            TimeOfSmite = new DateTimeOffset(new DateTime(2017, 4, 24, 15,02,00))
                        },
                        new Smite
                        {
                            Id = new Guid("5ec59731-9804-4965-8da4-d4975c7a0c33"),
                            TimeOfSmite = new DateTimeOffset(new DateTime(2017, 4, 24, 16,02,00))
                        }
                    }
                }
            };
            context.People.AddRange(people);
            context.SaveChanges();
        }
    }
}
