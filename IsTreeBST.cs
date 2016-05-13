using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree
{
    /* https://www.youtube.com/watch?v=MILxfAbIhrE
     * 1. Traverse DFS
     * 2. When you traverse left, each cur node's min=root's min, max = root.data
     *    When you traverse right, each cur node's min = root.data, max = max 
     */
    public class IsTreeBST
    {
        public bool IsBST(Node root)
        {
            return IsBST(root, int.MinValue, int.MaxValue);
        }

        private bool IsBST(Node cur, int min, int max)
        {
            if (cur == null)
                return true;
            if (cur.Data > max || cur.Data < min)
                return false;

            return IsBST(cur.Left, min, cur.Data) && IsBST(cur.Right, cur.Data, max);
        }
    }
}
