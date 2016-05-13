using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree
{
    public class SpiralLevelOrderTraversal
    {
        /* https://www.youtube.com/watch?v=vjt5Y6-1KsQ&list=PLrmLmBdmIlpv_jNDXtJGYTPNQ2L1gdHxu&index=10&nohtml5=False
        1. take 2 stacks S1 and S2
        2. Loop until S1.Count != 0 OR S2.Count != 0
        3.    loop while S1.Count !=0 
                    cur = S1.Pop
                    S2.Push => Cur.Right, Cur.Left 
         4.     Loop while S1.Count != 0
                    cur = S2.Pop
                    S2.Push => cur.Left, cur.Right 
         */

    }
}
