using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Collections;

namespace 红黑树
{
    public class Program
    {
        public static void Main()
        {
            int[] a = { 11, 2, 14, 1, 7, 15, 5, 8 };

            RBTree<int> rbTree = new RBTree<int>();
            foreach (var item in a)
            {
                rbTree.Insert(item);
            }
            rbTree.PreOrder();
            Console.WriteLine();
            rbTree.Insert(98);
            Console.WriteLine();
            rbTree.PreOrder();

            Console.Read();
        }
    }

    public enum NodeColor
    {
        Black,
        Red
    }

    public class RBTreeNode<T> where T : IComparable
    {
        public T Key { get; set; }
        public NodeColor Color { get; set; }
        public RBTreeNode<T> Parent { get; set; }
        public RBTreeNode<T> LeftNode { get; set; }
        public RBTreeNode<T> RightNode { get; set; }


        public RBTreeNode(T key, NodeColor color, RBTreeNode<T> parent, RBTreeNode<T> leftNode, RBTreeNode<T> rightNode)
        {
            this.Key = key;
            this.Color = color;
            this.Parent = parent;
            this.LeftNode = leftNode;
            this.RightNode = rightNode;
        }

        public override string ToString()
        {
            return this.Key + "(" + Color.ToString() + ")";
        }
    }


    public class RBTree<T> where T : IComparable
    {
        public RBTreeNode<T> RootNode { get; set; }

        public void Insert(T key)
        {
            if (RootNode == null)
            {
                RootNode = new RBTreeNode<T>(key, NodeColor.Black, null, null, null);
            }
            else
            {
                var newNode = Inserts(key);
                InsertFixUp(newNode);
            }
        }


        private RBTreeNode<T> Inserts(T key)
        {
            var node = RootNode;

            var newNode = new RBTreeNode<T>(key, NodeColor.Red, null, null, null);
            while (true)
            {
                if (key.CompareTo(node.Key) > 0)
                {
                    if (node.RightNode == null)
                    {
                        newNode.Parent = node;
                        node.RightNode = newNode;
                        break;
                    }
                    node = node.RightNode;
                }
                else if (key.CompareTo(node.Key) < 0)
                {
                    if (node.LeftNode == null)
                    {
                        newNode.Parent = node;
                        node.LeftNode = newNode;
                        break;
                    }
                    node = node.LeftNode;
                }
            }
            return newNode;
        }


        private void InsertFixUp(RBTreeNode<T> node)
        {
            var parentNode = node.Parent;
            if (parentNode != null && NodeColor.Red == parentNode.Color)
            {
                var gparentNode = parentNode.Parent;
                if (parentNode == gparentNode.LeftNode)
                {
                    var uncleNode = gparentNode.RightNode;
                    if (uncleNode != null && NodeColor.Red == uncleNode.Color)//case1
                    {
                        SetBlack(parentNode);
                        SetBlack(uncleNode);
                        SetRed(gparentNode);
                        InsertFixUp(gparentNode);
                    }
                    else
                    {
                        if (parentNode.RightNode == node)//case2
                        {
                            LeftRotation(parentNode);
                            InsertFixUp(parentNode);
                        }
                        else if (parentNode.LeftNode == node)//case3
                        {
                            SetBlack(parentNode);
                            SetRed(gparentNode);
                            RightRotion(gparentNode);
                        }
                    }
                }
                else
                {
                    var uncleNode = gparentNode.LeftNode;
                    if (uncleNode != null && NodeColor.Red == uncleNode.Color)//case1
                    {
                        SetBlack(parentNode);
                        SetBlack(uncleNode);
                        SetRed(gparentNode);
                        InsertFixUp(gparentNode);
                    }
                    else
                    {
                        if (parentNode.LeftNode == node)//case2
                        {
                            RightRotion(parentNode);
                            InsertFixUp(parentNode);
                        }
                        else if (parentNode.RightNode == node)//case3
                        {
                            SetBlack(parentNode);
                            SetRed(gparentNode);
                            LeftRotation(gparentNode);
                        }
                    }
                }
            }
            SetBlack(RootNode);//根节点设置为黑色
        }


        private void LeftRotation(RBTreeNode<T> node)
        {
            RBTreeNode<T> temp = node.RightNode;

            node.RightNode = temp.LeftNode;
            if (temp.LeftNode != null)
            {
                temp.LeftNode.Parent = node;
            }

            temp.Parent = node.Parent;

            if (node.Parent == null)
            {
                RootNode = temp;
            }
            else
            {
                if (node.Parent.LeftNode == node)
                {
                    node.Parent.LeftNode = temp;
                }
                else
                {
                    node.Parent.RightNode = temp;
                }
            }
            temp.LeftNode = node;
            node.Parent = temp;
        }

        private void RightRotion(RBTreeNode<T> node)
        {
            RBTreeNode<T> temp = node.LeftNode;

            node.LeftNode = temp.RightNode;
            if (temp.RightNode != null)
            {
                temp.RightNode.Parent = node;
            }

            temp.Parent = node.Parent;

            if (node.Parent == null)
            {
                RootNode = temp;
            }
            else
            {
                if (node == node.Parent.RightNode)
                {
                    node.Parent.RightNode = temp;
                }
                else
                {
                    node.Parent.LeftNode = temp;
                }
            }
            temp.RightNode = node;
            node.Parent = temp;
        }


        private void SetBlack(RBTreeNode<T> node)
        {
            node.Color = NodeColor.Black;
        }

        private void SetRed(RBTreeNode<T> node)
        {
            node.Color = NodeColor.Red;
        }

      

        public void PreOrder()
        {
            PreOrder(RootNode);
        }

        private void PreOrder(RBTreeNode<T> node)
        {
            Console.Write(node + " ");

            if (node.LeftNode != null)
            {
                PreOrder(node.LeftNode);
            }

            if (node.RightNode != null)
            {
                PreOrder(node.RightNode);
            }
        }
    }
}