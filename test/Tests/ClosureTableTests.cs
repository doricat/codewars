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
                new ClosureTable.Entity {Name = "中国"},
                new ClosureTable.Entity {Name = "北京"},
                new ClosureTable.Entity {Name = "海淀"},
                new ClosureTable.Entity {Name = "东城"},
                new ClosureTable.Entity {Name = "上海"},
                new ClosureTable.Entity {Name = "浦东"},
                new ClosureTable.Entity {Name = "静安"},
                new ClosureTable.Entity {Name = "广东"},
                new ClosureTable.Entity {Name = "广州"},
                new ClosureTable.Entity {Name = "深圳"}
            };
            var paths = new List<ClosureTable.TreePath>
            {
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "中国").Id, Descendant = entities.First(x => x.Name == "中国").Id, Level = 0},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "中国").Id, Descendant = entities.First(x => x.Name == "北京").Id, Level = 1},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "中国").Id, Descendant = entities.First(x => x.Name == "海淀").Id, Level = 2},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "中国").Id, Descendant = entities.First(x => x.Name == "东城").Id, Level = 2},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "中国").Id, Descendant = entities.First(x => x.Name == "上海").Id, Level = 1},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "中国").Id, Descendant = entities.First(x => x.Name == "浦东").Id, Level = 2},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "中国").Id, Descendant = entities.First(x => x.Name == "静安").Id, Level = 2},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "中国").Id, Descendant = entities.First(x => x.Name == "广东").Id, Level = 1},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "中国").Id, Descendant = entities.First(x => x.Name == "广州").Id, Level = 2},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "中国").Id, Descendant = entities.First(x => x.Name == "深圳").Id, Level = 2},

                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "北京").Id, Descendant = entities.First(x => x.Name == "北京").Id, Level = 1},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "北京").Id, Descendant = entities.First(x => x.Name == "海淀").Id, Level = 2},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "北京").Id, Descendant = entities.First(x => x.Name == "东城").Id, Level = 2},

                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "海淀").Id, Descendant = entities.First(x => x.Name == "海淀").Id, Level = 2},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "东城").Id, Descendant = entities.First(x => x.Name == "东城").Id, Level = 2},

                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "上海").Id, Descendant = entities.First(x => x.Name == "上海").Id, Level = 1},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "上海").Id, Descendant = entities.First(x => x.Name == "浦东").Id, Level = 2},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "上海").Id, Descendant = entities.First(x => x.Name == "静安").Id, Level = 2},

                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "浦东").Id, Descendant = entities.First(x => x.Name == "浦东").Id, Level = 2},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "静安").Id, Descendant = entities.First(x => x.Name == "静安").Id, Level = 2},

                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "广东").Id, Descendant = entities.First(x => x.Name == "广东").Id, Level = 1},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "广东").Id, Descendant = entities.First(x => x.Name == "广州").Id, Level = 2},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "广东").Id, Descendant = entities.First(x => x.Name == "深圳").Id, Level = 2},

                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "广州").Id, Descendant = entities.First(x => x.Name == "广州").Id, Level = 2},
                new ClosureTable.TreePath {Ancestor = entities.First(x => x.Name == "深圳").Id, Descendant = entities.First(x => x.Name == "深圳").Id, Level = 2}
            };

            var result = ClosureTable.Parse(entities, paths);
            Console.Write(JsonConvert.SerializeObject(result));
        }
    }
}