using System;
using System.Diagnostics;

namespace BinarySearchTree {
    public class TreeNode {
        //property to store the nodes data could be a key and object pair
        private KeyValuePair<int, NodeData> data;
        public KeyValuePair<int, NodeData> Data {
            get { return data; }
        }

        private TreeNode rightNode;
        public TreeNode RightNode {
            get { return rightNode; }
            set { rightNode = value; }
        }//Right Child

        private TreeNode leftNode;
        public TreeNode LeftNode {
            get { return leftNode; }
            set { leftNode = value; }
        }//left Child

        private bool isDeleted;//soft delete variable
        public bool IsDeleted {
            get { return isDeleted; }
        }

        //Node constructor
        public TreeNode(int value, NodeData nodeData) {
            data = new KeyValuePair<int, NodeData>(value, nodeData);
        }

        //Method to set soft delete
        public void Delete() {
            isDeleted = true;
        }

        //recursively calls insert down the tree until it find an open spot
        public void Insert(int value, NodeData nodeData) {
            //if the value passed in is greater or equal to the data then insert to right node
            if(value >= data.Key) { //if right child node is null create one
                if(rightNode == null) {
                    rightNode = new TreeNode(value, nodeData);
                }
                else { //if right node is not null recursivly call insert on the right node
                    rightNode.Insert(value, nodeData);
                }
            }
            else { //if the value passed in is less than the data then insert to left node
                if(leftNode == null) { //if the leftnode is null then create a new node
                    leftNode = new TreeNode(value, nodeData);
                }
                else { //if the left node is not null then recursively call insert on the left node
                    leftNode.Insert(value, nodeData);
                }
            }
        }

        public TreeNode FindRecursive(int value) {
            //value passed in matches nodes data return the node
            if(value == data.Key && isDeleted == false) {
                return this;
            }
            //if the value passed in is less than the current data then go to the left child
            else if(value < data.Key && leftNode != null) {
                return leftNode.FindRecursive(value);
            }
            //if its great then go to the right child node
            else if(rightNode != null) {
                return rightNode.FindRecursive(value);
            }
            else {
                return null;
            }
        }
    }
}
