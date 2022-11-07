using System.ComponentModel;
using System.Diagnostics;

namespace BinarySearchTree {
    public partial class Form1 : Form {
        private static readonly Random random = new();
        private static readonly string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private List<NodeData> NodeDataList;
        private List<NodeData> ParentNodeDataList;
        private BinaryTree BinaryTree;

        public Form1() {
            InitializeComponent();
            NodeDataList = new List<NodeData>();
            ParentNodeDataList = new List<NodeData>();
            BinaryTree = new BinaryTree();
        }

        private void GenerateNodesBtn_Click(object sender, EventArgs e) {
            NodeDataList.AddRange(GenerateRandomNodes());
            BindDataToGrid();
            BinaryTree.Root = null;
            foreach(var node in NodeDataList) {
                BinaryTree.Insert(node.NodeNumber, node);
            }
        }

        private void AddNodeBtn_Click(object sender, EventArgs e) {
            if(!int.TryParse(NodeNumberTxt.Text, out int nodeNumber)) {
                MessageBox.Show("An integer must be written.", "Error..", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrWhiteSpace(NodeTextTxt.Text)) {
                MessageBox.Show("The text must not be empty.", "Error..",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!float.TryParse(DecimalNumberTxt.Text, out float decimalNumber)) {
                MessageBox.Show("A float must be written.", "Error..",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(NodeDataList.Any(n => n.NodeNumber == nodeNumber)) {
                MessageBox.Show("An integer with the same vale already exists.", "Error..",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NodeData node = new() {
                NodeNumber = nodeNumber,
                Text = NodeTextTxt.Text,
                DecimalNumber = decimalNumber
            };

            NodeDataList.Add(node);
            BindDataToGrid();
            BinaryTree.Insert(node.NodeNumber, node);
        }

        private void SearchNodeBtn_Click(object sender, EventArgs e) {
            if(!int.TryParse(FindNodeTxt.Text, out int nodeNumber)) {
                MessageBox.Show("An integer must be written.", "Error..",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var foundNode = BinaryTree.FindRecursive(nodeNumber);
            if(foundNode != null) {
                MessageBox.Show(
                    $"Node Number: {foundNode.Data.Value.NodeNumber}\n" +
                        $"Node Text: {foundNode.Data.Value.Text}\n" +
                        $"Decimal Number: {foundNode.Data.Value.DecimalNumber}",
                    "Found..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("Node not found.", "Warning..",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RemoveNodeBtn_Click(object sender, EventArgs e) {
            if(!int.TryParse(FindNodeTxt.Text, out int nodeNumber)) {
                MessageBox.Show("An integer must be written.", "Error..",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var nodeToRemove = NodeDataList.Find(node => node.NodeNumber == nodeNumber);
            NodeDataList.Remove(nodeToRemove);
            BindDataToGrid();
            BinaryTree.Remove(nodeNumber);
        }

        private void DrawTreeBtn_Click(object sender, EventArgs e) {
            string data = BinaryTree.DrawTree();

            string currentPath = Environment.CurrentDirectory;
            string folderPath = Path.Combine(currentPath, "GraphImage");
            if(!Directory.Exists(folderPath)) {
                Directory.CreateDirectory(Path.Combine(currentPath, "GraphImage"));
            }

            string fileDataPath = Path.Combine(folderPath, "BinaryTreeData.gv");
            StreamWriter swData = new(fileDataPath);
            swData.Write(data);
            swData.Close();

            string fileBatPath = Path.Combine(folderPath, "ExecuteGraphviz.bat");
            StreamWriter swBat = new(fileBatPath);
            // TODO: Subject to change
            swBat.WriteLine("ECHO OFF\ndot -Tpng BinaryTreeData.gv -o BinaryTree.png\nBinaryTree.png");
            swBat.Close();

            if(File.Exists(fileBatPath)) {
                Process proc = new();
                proc.StartInfo.FileName = fileBatPath;
                proc.StartInfo.WorkingDirectory = folderPath;
                proc.Start();
                Process.Start(fileBatPath);
            }
        }

        private void ReturnParentNodesbtn_Click(object sender, EventArgs e) {
            var parentNodeKeys = BinaryTree.GetParentNodes();
            var parentNodes = NodeDataList.Where(node => parentNodeKeys.Contains(node.NodeNumber));
            ParentNodeDataList.AddRange(parentNodes);
            BindDataToGrid();
        }

        private List<NodeData> GenerateRandomNodes() {
            List<NodeData> nodes = new();
            for(int i = 0; i < 10; i++) {
                NodeData node = new NodeData();
                node.NodeNumber = random.Next(100);
                node.Text = new string(Enumerable.Repeat(chars, 8)
                    .Select(s => s[random.Next(s.Length)])
                    .ToArray());
                node.DecimalNumber = random.NextSingle();

                if(NodeDataList.Any(n => n.NodeNumber == node.NodeNumber)) {
                    i--;
                } else {
                    nodes.Add(node);
                }
            }

            return nodes;
        }

        private void BindDataToGrid() {
            if(NodeDataList.Count > 0) {
                var bindingList = new BindingList<NodeData>(NodeDataList);
                var source = new BindingSource(bindingList, null);
                NodeListDataGrid.DataSource = source;
            }

            if(ParentNodeDataList.Count > 0) {
                var bindingParentList = new BindingList<NodeData>(ParentNodeDataList);
                var sourceParent = new BindingSource(bindingParentList, null);
                ParentNodesGrid.DataSource = sourceParent;
            }
        }
    }
}