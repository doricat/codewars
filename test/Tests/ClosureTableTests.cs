using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using NUnit.Framework;
using Solutions;

namespace Tests
{
    public class ClosureTableTests
    {
        [Test]
        public void Tests()
        {
            var entities = new List<ClosureTable.Entity>
            {
                new ClosureTable.Entity {Name = "�й�"},
                new ClosureTable.Entity {Name = "����"},
                new ClosureTable.Entity {Name = "����"},
                new ClosureTable.Entity {Name = "����"},
                new ClosureTable.Entity {Name = "�Ϻ�"},
                new ClosureTable.Entity {Name = "�ֶ�"},
                new ClosureTable.Entity {Name = "����"},
                new ClosureTable.Entity {Name = "�㶫"},
                new ClosureTable.Entity {Name = "����"},
                new ClosureTable.Entity {Name = "����"}
            };
            var paths = new List<ClosureTable.TreePath>
            {
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "�й�").Id, Descendant = entities.First(x => x.Name == "�й�").Id, Level = 0},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "�й�").Id, Descendant = entities.First(x => x.Name == "����").Id, Level = 1},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "�й�").Id, Descendant = entities.First(x => x.Name == "����").Id, Level = 2},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "�й�").Id, Descendant = entities.First(x => x.Name == "����").Id, Level = 2},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "�й�").Id, Descendant = entities.First(x => x.Name == "�Ϻ�").Id, Level = 1},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "�й�").Id, Descendant = entities.First(x => x.Name == "�ֶ�").Id, Level = 2},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "�й�").Id, Descendant = entities.First(x => x.Name == "����").Id, Level = 2},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "�й�").Id, Descendant = entities.First(x => x.Name == "�㶫").Id, Level = 1},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "�й�").Id, Descendant = entities.First(x => x.Name == "����").Id, Level = 2},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "�й�").Id, Descendant = entities.First(x => x.Name == "����").Id, Level = 2},

                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "����").Id, Descendant = entities.First(x => x.Name == "����").Id, Level = 1},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "����").Id, Descendant = entities.First(x => x.Name == "����").Id, Level = 2},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "����").Id, Descendant = entities.First(x => x.Name == "����").Id, Level = 2},

                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "����").Id, Descendant = entities.First(x => x.Name == "����").Id, Level = 2},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "����").Id, Descendant = entities.First(x => x.Name == "����").Id, Level = 2},

                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "�Ϻ�").Id, Descendant = entities.First(x => x.Name == "�Ϻ�").Id, Level = 1},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "�Ϻ�").Id, Descendant = entities.First(x => x.Name == "�ֶ�").Id, Level = 2},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "�Ϻ�").Id, Descendant = entities.First(x => x.Name == "����").Id, Level = 2},

                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "�ֶ�").Id, Descendant = entities.First(x => x.Name == "�ֶ�").Id, Level = 2},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "����").Id, Descendant = entities.First(x => x.Name == "����").Id, Level = 2},

                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "�㶫").Id, Descendant = entities.First(x => x.Name == "�㶫").Id, Level = 1},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "�㶫").Id, Descendant = entities.First(x => x.Name == "����").Id, Level = 2},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "�㶫").Id, Descendant = entities.First(x => x.Name == "����").Id, Level = 2},

                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "����").Id, Descendant = entities.First(x => x.Name == "����").Id, Level = 2},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "����").Id, Descendant = entities.First(x => x.Name == "����").Id, Level = 2}
            };

            var result = ClosureTable.Parse(entities, paths);
            Console.Write(JsonConvert.SerializeObject(result));
        }
    }
}