using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二叉排序树_链式存储结构
{
    class BSTree
    {
        BSNode root = null;

        public void Add(int item)
        {
            BSNode newNode = new BSNode(item);

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                BSNode temp = root;

                while (true)
                {
                    if (item >= temp.Data)
                    {
                        if (temp.RightChild == null)
                        {
                            temp.RightChild = newNode;

                            newNode.Parent = temp;

                            break;
                        }
                        else
                        {
                            temp = temp.RightChild;
                        }
                    }
                    else
                    {
                        if (temp.LeftChild == null)
                        {
                            temp.LeftChild = newNode;

                            newNode.Parent = temp;

                            break;
                        }
                        else
                        {
                            temp = temp.LeftChild;
                        }
                    }
                }
            }
        }

        public void MiddleTraversal()
        {
            MiddleTraversal(root);
        }

        private void MiddleTraversal(BSNode node)
        {
            if (node == null) return;

            MiddleTraversal(node.LeftChild);

            Console.Write(node.Data + " ");

            MiddleTraversal(node.RightChild);
        }

        public bool Find(int item)
        {
            //return Find(item, root);

            BSNode temp = root;

            while (true)
            {
                if (temp == null) return false;

                if (temp.Data == item) return true;

                if (item > temp.Data)
                    temp = temp.RightChild;
                else
                    temp = temp.LeftChild;
            }
        }

        private bool Find(int item, BSNode node)
        {
            if (node == null) return false;

            if (node.Data == item)
            {
                return true;
            }
            else
            {
                if (Find(item, node.LeftChild))
                {
                    return true;
                }

                if (Find(item, node.RightChild))
                {
                    return true;
                }
            }

            return false;
        }

        public bool Delete(int item)
        {
            BSNode temp = root;

            while (true)
            {
                if (temp == null) return false;

                if (temp.Data == item)
                {
                    Delete(temp);
                    return true;
                }

                if (item > temp.Data)
                    temp = temp.RightChild;
                else
                    temp = temp.LeftChild;
            }
        }

        public void Delete(BSNode node)
        {
            if (node.LeftChild == null && node.RightChild == null)
            {
                if (node.Parent == null)
                {
                    root = null;
                }
                else if (node.Parent.LeftChild == node)
                {
                    node.Parent.LeftChild = null;
                }
                else if (node.Parent.RightChild == node)
                {
                    node.Parent.RightChild = null;
                }

                return;
            }

            if (node.LeftChild == null && node.RightChild != null)
            {
                node.Data = node.RightChild.Data;

                node.RightChild = null;

                return;
            }

            if (node.LeftChild != null && node.RightChild == null)
            {
                node.Data = node.LeftChild.Data;

                node.LeftChild = null;

                return;
            }

            BSNode temp = node.RightChild;

            while (true)
            {
                if (temp.LeftChild != null)
                {
                    temp = temp.LeftChild;
                }
                else
                {
                    break;
                }
            }

            node.Data = temp.Data;

            Delete(temp);
        }
    }
}
