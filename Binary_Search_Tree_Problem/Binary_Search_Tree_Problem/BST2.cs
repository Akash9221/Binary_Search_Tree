using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree_Problem
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public T NodeData
        {
            get; set;
        }
        public BinarySearchTree<T> LeftTree { get; set; }   
        public BinarySearchTree<T> RightTree { get; set; }

        public BinarySearchTree(T nodedata)
        {
            this.NodeData = nodedata;
            this.LeftTree = null;
            this.RightTree = null;  
        }
        static int lcnt = 0;
        static int rcnt = 0;

        public void Insert(T data)
        {
            T CurrentNodeValue = this.NodeData;
            if((CurrentNodeValue.CompareTo(data))>0)
            {
                if(this.LeftTree==null)
                {
                    this.LeftTree = new BinarySearchTree<T>(data);
                }
                else
                {
                    this.LeftTree.Insert(data); 
                }
            }
            else
            {
                if(this.RightTree==null)
                {
                    this.RightTree=new BinarySearchTree<T>(data);   
                }
                else
                {
                    this.RightTree.Insert(data);    
                }
            }
        }
        public void Display()
        {
            if (this.LeftTree != null)
            {
                lcnt++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                rcnt++;
                this.RightTree.Display();
            }
        }
        public int size()
        {
            return (1 + lcnt + rcnt);
        }
    }
}
