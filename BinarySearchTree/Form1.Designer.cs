namespace BinarySearchTree {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.NodeListDataGrid = new System.Windows.Forms.DataGridView();
            this.GenerateNodesBtn = new System.Windows.Forms.Button();
            this.NodeNumberTxt = new System.Windows.Forms.TextBox();
            this.NodeNumberLbl = new System.Windows.Forms.Label();
            this.NodeTextLbl = new System.Windows.Forms.Label();
            this.DecimalNumberLbl = new System.Windows.Forms.Label();
            this.NodeTextTxt = new System.Windows.Forms.TextBox();
            this.DecimalNumberTxt = new System.Windows.Forms.TextBox();
            this.AddNodeBtn = new System.Windows.Forms.Button();
            this.FindNodeBtn = new System.Windows.Forms.Button();
            this.FindNodeTxt = new System.Windows.Forms.TextBox();
            this.SearchLbl = new System.Windows.Forms.Label();
            this.RemoveNodeBtn = new System.Windows.Forms.Button();
            this.DrawTreeBtn = new System.Windows.Forms.Button();
            this.ParentNodesGrid = new System.Windows.Forms.DataGridView();
            this.ReturnParentNodesbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NodeListDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParentNodesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // NodeListDataGrid
            // 
            this.NodeListDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NodeListDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.NodeListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NodeListDataGrid.Location = new System.Drawing.Point(12, 82);
            this.NodeListDataGrid.Name = "NodeListDataGrid";
            this.NodeListDataGrid.RowTemplate.Height = 25;
            this.NodeListDataGrid.Size = new System.Drawing.Size(776, 150);
            this.NodeListDataGrid.TabIndex = 0;
            // 
            // GenerateNodesBtn
            // 
            this.GenerateNodesBtn.Location = new System.Drawing.Point(598, 53);
            this.GenerateNodesBtn.Name = "GenerateNodesBtn";
            this.GenerateNodesBtn.Size = new System.Drawing.Size(170, 23);
            this.GenerateNodesBtn.TabIndex = 1;
            this.GenerateNodesBtn.Text = "Generate Random Nodes";
            this.GenerateNodesBtn.UseVisualStyleBackColor = true;
            this.GenerateNodesBtn.Click += new System.EventHandler(this.GenerateNodesBtn_Click);
            // 
            // NodeNumberTxt
            // 
            this.NodeNumberTxt.Location = new System.Drawing.Point(12, 54);
            this.NodeNumberTxt.Name = "NodeNumberTxt";
            this.NodeNumberTxt.Size = new System.Drawing.Size(127, 23);
            this.NodeNumberTxt.TabIndex = 2;
            // 
            // NodeNumberLbl
            // 
            this.NodeNumberLbl.AutoSize = true;
            this.NodeNumberLbl.Location = new System.Drawing.Point(12, 36);
            this.NodeNumberLbl.Name = "NodeNumberLbl";
            this.NodeNumberLbl.Size = new System.Drawing.Size(83, 15);
            this.NodeNumberLbl.TabIndex = 3;
            this.NodeNumberLbl.Text = "Node Number";
            // 
            // NodeTextLbl
            // 
            this.NodeTextLbl.AutoSize = true;
            this.NodeTextLbl.Location = new System.Drawing.Point(158, 35);
            this.NodeTextLbl.Name = "NodeTextLbl";
            this.NodeTextLbl.Size = new System.Drawing.Size(60, 15);
            this.NodeTextLbl.TabIndex = 4;
            this.NodeTextLbl.Text = "Node Text";
            // 
            // DecimalNumberLbl
            // 
            this.DecimalNumberLbl.AutoSize = true;
            this.DecimalNumberLbl.Location = new System.Drawing.Point(322, 36);
            this.DecimalNumberLbl.Name = "DecimalNumberLbl";
            this.DecimalNumberLbl.Size = new System.Drawing.Size(97, 15);
            this.DecimalNumberLbl.TabIndex = 5;
            this.DecimalNumberLbl.Text = "Decimal Number";
            // 
            // NodeTextTxt
            // 
            this.NodeTextTxt.Location = new System.Drawing.Point(158, 54);
            this.NodeTextTxt.Name = "NodeTextTxt";
            this.NodeTextTxt.Size = new System.Drawing.Size(140, 23);
            this.NodeTextTxt.TabIndex = 6;
            // 
            // DecimalNumberTxt
            // 
            this.DecimalNumberTxt.Location = new System.Drawing.Point(322, 54);
            this.DecimalNumberTxt.Name = "DecimalNumberTxt";
            this.DecimalNumberTxt.Size = new System.Drawing.Size(145, 23);
            this.DecimalNumberTxt.TabIndex = 7;
            // 
            // AddNodeBtn
            // 
            this.AddNodeBtn.Location = new System.Drawing.Point(485, 53);
            this.AddNodeBtn.Name = "AddNodeBtn";
            this.AddNodeBtn.Size = new System.Drawing.Size(89, 23);
            this.AddNodeBtn.TabIndex = 8;
            this.AddNodeBtn.Text = "Add Node";
            this.AddNodeBtn.UseVisualStyleBackColor = true;
            this.AddNodeBtn.Click += new System.EventHandler(this.AddNodeBtn_Click);
            // 
            // FindNodeBtn
            // 
            this.FindNodeBtn.Location = new System.Drawing.Point(163, 264);
            this.FindNodeBtn.Name = "FindNodeBtn";
            this.FindNodeBtn.Size = new System.Drawing.Size(87, 23);
            this.FindNodeBtn.TabIndex = 9;
            this.FindNodeBtn.Text = "Find Node";
            this.FindNodeBtn.UseVisualStyleBackColor = true;
            this.FindNodeBtn.Click += new System.EventHandler(this.SearchNodeBtn_Click);
            // 
            // FindNodeTxt
            // 
            this.FindNodeTxt.Location = new System.Drawing.Point(16, 264);
            this.FindNodeTxt.Name = "FindNodeTxt";
            this.FindNodeTxt.Size = new System.Drawing.Size(141, 23);
            this.FindNodeTxt.TabIndex = 10;
            // 
            // SearchLbl
            // 
            this.SearchLbl.AutoSize = true;
            this.SearchLbl.Location = new System.Drawing.Point(16, 246);
            this.SearchLbl.Name = "SearchLbl";
            this.SearchLbl.Size = new System.Drawing.Size(141, 15);
            this.SearchLbl.TabIndex = 11;
            this.SearchLbl.Text = "Node Number For Action";
            // 
            // RemoveNodeBtn
            // 
            this.RemoveNodeBtn.Location = new System.Drawing.Point(256, 264);
            this.RemoveNodeBtn.Name = "RemoveNodeBtn";
            this.RemoveNodeBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveNodeBtn.TabIndex = 12;
            this.RemoveNodeBtn.Text = "Remove Node";
            this.RemoveNodeBtn.UseVisualStyleBackColor = true;
            this.RemoveNodeBtn.Click += new System.EventHandler(this.RemoveNodeBtn_Click);
            // 
            // DrawTreeBtn
            // 
            this.DrawTreeBtn.Location = new System.Drawing.Point(713, 238);
            this.DrawTreeBtn.Name = "DrawTreeBtn";
            this.DrawTreeBtn.Size = new System.Drawing.Size(75, 23);
            this.DrawTreeBtn.TabIndex = 13;
            this.DrawTreeBtn.Text = "Draw Tree";
            this.DrawTreeBtn.UseVisualStyleBackColor = true;
            this.DrawTreeBtn.Click += new System.EventHandler(this.DrawTreeBtn_Click);
            // 
            // ParentNodesGrid
            // 
            this.ParentNodesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ParentNodesGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ParentNodesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParentNodesGrid.Location = new System.Drawing.Point(16, 348);
            this.ParentNodesGrid.Name = "ParentNodesGrid";
            this.ParentNodesGrid.RowTemplate.Height = 25;
            this.ParentNodesGrid.Size = new System.Drawing.Size(772, 150);
            this.ParentNodesGrid.TabIndex = 14;
            // 
            // ReturnParentNodesbtn
            // 
            this.ReturnParentNodesbtn.Location = new System.Drawing.Point(16, 319);
            this.ReturnParentNodesbtn.Name = "ReturnParentNodesbtn";
            this.ReturnParentNodesbtn.Size = new System.Drawing.Size(130, 23);
            this.ReturnParentNodesbtn.TabIndex = 15;
            this.ReturnParentNodesbtn.Text = "Return Parent Nodes";
            this.ReturnParentNodesbtn.UseVisualStyleBackColor = true;
            this.ReturnParentNodesbtn.Click += new System.EventHandler(this.ReturnParentNodesbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 521);
            this.Controls.Add(this.ReturnParentNodesbtn);
            this.Controls.Add(this.ParentNodesGrid);
            this.Controls.Add(this.DrawTreeBtn);
            this.Controls.Add(this.RemoveNodeBtn);
            this.Controls.Add(this.SearchLbl);
            this.Controls.Add(this.FindNodeTxt);
            this.Controls.Add(this.FindNodeBtn);
            this.Controls.Add(this.AddNodeBtn);
            this.Controls.Add(this.DecimalNumberTxt);
            this.Controls.Add(this.NodeTextTxt);
            this.Controls.Add(this.DecimalNumberLbl);
            this.Controls.Add(this.NodeTextLbl);
            this.Controls.Add(this.NodeNumberLbl);
            this.Controls.Add(this.NodeNumberTxt);
            this.Controls.Add(this.GenerateNodesBtn);
            this.Controls.Add(this.NodeListDataGrid);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NodeListDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParentNodesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn RootNumber;
        private DataGridViewTextBoxColumn DecimalNumber;
        private DataGridView NodeListDataGrid;
        private Button GenerateNodesBtn;
        private TextBox NodeNumberTxt;
        private Label NodeNumberLbl;
        private Label NodeTextLbl;
        private Label DecimalNumberLbl;
        private TextBox NodeTextTxt;
        private TextBox DecimalNumberTxt;
        private Button AddNodeBtn;
        private Button FindNodeBtn;
        private TextBox FindNodeTxt;
        private Label SearchLbl;
        private Button RemoveNodeBtn;
        private Button DrawTreeBtn;
        private DataGridView ParentNodesGrid;
        private Button ReturnParentNodesbtn;
    }
}