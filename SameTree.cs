using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree
{
    public class SameTree
    {
        /* https://www.youtube.com/watch?v=ySDDslG8wws&list=PLrmLmBdmIlpv_jNDXtJGYTPNQ2L1gdHxu&index=16&nohtml5=False
         bool SameTree(Node root1, Node root2)
         {
            if(root1 == null && root2 == null)
                return true;
            if(root1 == null || root2 == null)
                return false;

            return root1.data == root2.data 
                &&  SameTree(root1.Left, root2.Left)
                &&  SameTree(root1.Right, root2.Right); 
         }
         */
    }
}
