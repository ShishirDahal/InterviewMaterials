using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class CompareTwoTrees
    {
        //Node root=null;
        
        public bool AreSimilarTrees(Tree T1, Tree T2)
        {
            Node Root1 = T1.GetRoot();
            Node Root2 = T2.GetRoot();
            if (T1 == null || T2 == null)
                return false;
            return CompareTrees(Root1, Root2);
        }

        private bool CompareTrees(Node Root1, Node Root2)
        {
            if (Root1 == null || Root2 == null)
                return true;
            if (Root1.Data != Root2.Data)
                return false;
            return CompareTrees(Root1.Left, Root2.Left) || CompareTrees(Root1.Right, Root2.Right);
        }
        
    }
}
