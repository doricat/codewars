using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions
{
    public class ClosureTable
    {
        public static IList<TreeNode> Parse(IList<Entity> entities, IList<TreePath> paths)
        {
            var rootIdList = paths.Where(x => x.Level == 0).Select(x => x.Ancestor).Distinct().ToList();
            var result = new List<TreeNode>();
            foreach (var guid in rootIdList)
            {
                var o = entities.First(x => x.Id == guid);
                result.Add(new TreeNode {Id = guid, Name = o.Name, Children = Parse(entities, paths, guid, 0 + 1)});
            }

            return result;
        }

        private static List<TreeNode> Parse(IList<Entity> entities, IList<TreePath> paths, Guid id, int level)
        {
            var children = paths.Where(x => x.Ancestor == id && x.Level == level).ToList();
            var result = new List<TreeNode>();
            foreach (var path in children)
            {
                var o = entities.First(x => x.Id == path.Descendant);
                result.Add(new TreeNode {Id = o.Id, Name = o.Name, Children = Parse(entities, paths, path.Descendant, level + 1)});
            }

            return result;
        }

        public class Entity
        {
            public Guid Id { get; set; } = Guid.NewGuid();

            public string Name { get; set; }
        }

        public class TreePath
        {
            public Guid Ancestor { get; set; }

            public Guid Descendant { get; set; }

            public int Level { get; set; }
        }

        public class TreeNode
        {
            public Guid Id { get; set; }

            public string Name { get; set; }

            public IList<TreeNode> Children { get; set; }
        }
    }
}