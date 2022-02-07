using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsATree
{
    public class CheckTree
    {
        //===============================================================================
        //Your Code is Here:
        /// <summary>
        /// Develop an efficient algorithm to determine whether the given graph is a tree or not
        /// </summary>
        /// <param name="vertices">The vertices array (1 ≤ size ≤ 1000) of the given graph </param>
        /// <param name="edges">The edges of the given graph as a list of KeyValuePair</param>
        /// <returns>If Contains: return true if tree, else, return false</returns>
        public static bool IsTree(string[] vertices, List<KeyValuePair<string, string>> edges)
        {
            //throw new NotImplementedException();
            
            List<string> ls=new List<string>();
            int n = edges.Count;
            if (n > vertices.Length * 2 - 2)
                return false;

            int index=0;
            int[] checked_list = new int[n];
            checked_list[0] = 1;
            bool found = false;
            bool start = true;
            for (int i=0; i<n; i++)
            {
                if(ls.Contains(edges.ElementAt(index).Key) && start!=true)
                {
                    found = false;
                    for(int j=0; j<n; j++)
                    {
                        if(edges.ElementAt(index).Key.Equals(edges.ElementAt(j).Value)&& edges.ElementAt(index).Value.Equals(edges.ElementAt(j).Key))
                        {
                            found = true;
                            break;
                        }
                    }
                    if(!found)
                        return false;
                    else
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (checked_list[j] != 1)
                            {
                                index = j;
                                checked_list[j] = 1;
                            }
                        }
                        start = true;
                    }
                }
                else
                {
                    ls.Add(edges.ElementAt(index).Key);
                    found = false;
                    for(int j=0; j<n; j++)
                    {
                        if(edges.ElementAt(index).Value.Equals(edges.ElementAt(j).Key) && checked_list[j]!=1)
                        {
                            checked_list[j] = 1;
                            index = j;
                            found = true;
                            start = false;
                        }
                    }
                    if(!found)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (checked_list[j] != 1)
                            {
                                index = j;
                                checked_list[j] = 1;
                            }
                        }
                    }
                }
            }




            //for (int i=0; i<n; i++)
            //{
            //    ls.Add(edges.ElementAt(i).Key);
            //}
            //for(int i=0; i<n; i++)
            //{
            //    if(ls.Contains(edges.ElementAt(i).Value))
            //    {
            //        ls.RemoveAt(ls.IndexOf(edges.ElementAt(i).Value));
            //    }
            //}
            //if (ls.Count == 0)
            //    return true;
            //else
            //    return false;


            //Boolean b = true;
            //int edg_num = -1;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (edges.ElementAt(i).Key.Equals(edges.ElementAt(j).Value))
            //        {
            //            if (!edges.ElementAt(i).Value.Equals(edges.ElementAt(j).Key))
            //            {
            //                b = false;
            //                edg_num = i;
            //            }
            //            if (edg_num > 0)
            //            {
            //                for (int k = 0; k < n; k++)
            //                    if (edges.ElementAt(edg_num).Key.Equals(edges.ElementAt(k).Value) && edges.ElementAt(edg_num).Value.Equals(edges.ElementAt(k).Key))
            //                        b = true;
            //            }
            //        }
            //    }
            //}
            //return b;
        }
        //===============================================================================
    }
}
