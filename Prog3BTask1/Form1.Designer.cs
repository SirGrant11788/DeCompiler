namespace Prog3BTask1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFile = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.gvExtRef = new System.Windows.Forms.DataGridView();
            this.gvClasses = new System.Windows.Forms.DataGridView();
            this.gvLines = new System.Windows.Forms.DataGridView();
            this.gvLinesUser = new System.Windows.Forms.DataGridView();
            this.txtbLines = new System.Windows.Forms.TextBox();
            this.btnLinesUser = new System.Windows.Forms.Button();
            this.lblExtRef = new System.Windows.Forms.Label();
            this.lblClasses = new System.Windows.Forms.Label();
            this.lblMethodLines = new System.Windows.Forms.Label();
            this.pbSearch = new System.Windows.Forms.ProgressBar();
            this.pbLoad = new System.Windows.Forms.ProgressBar();
            this.gvInterfaces = new System.Windows.Forms.DataGridView();
            this.pbInterfaces = new System.Windows.Forms.ProgressBar();
            this.txtbInterfaces = new System.Windows.Forms.TextBox();
            this.btnInterfaces = new System.Windows.Forms.Button();
            this.richTextBoxTree = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbTreeSearch = new System.Windows.Forms.TextBox();
            this.btnSearchTree = new System.Windows.Forms.Button();
            this.treeViewInterface = new System.Windows.Forms.TreeView();
            this.treeViewClasses = new System.Windows.Forms.TreeView();
            this.btnSearchGraph = new System.Windows.Forms.Button();
            this.txtbGraph = new System.Windows.Forms.TextBox();
            this.gvGraph = new System.Windows.Forms.DataGridView();
            this.rtxtbGraph = new System.Windows.Forms.RichTextBox();
            this.lblGraph = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvExtRef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLinesUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInterfaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(14, 12);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(118, 58);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "Select Assembly File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(140, 29);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(125, 20);
            this.lblFile.TabIndex = 1;
            this.lblFile.Text = "No File Selected";
            // 
            // gvExtRef
            // 
            this.gvExtRef.AllowUserToOrderColumns = true;
            this.gvExtRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExtRef.Location = new System.Drawing.Point(14, 131);
            this.gvExtRef.Name = "gvExtRef";
            this.gvExtRef.RowTemplate.Height = 28;
            this.gvExtRef.Size = new System.Drawing.Size(680, 371);
            this.gvExtRef.TabIndex = 2;
            // 
            // gvClasses
            // 
            this.gvClasses.AllowUserToOrderColumns = true;
            this.gvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvClasses.Location = new System.Drawing.Point(756, 131);
            this.gvClasses.Name = "gvClasses";
            this.gvClasses.RowTemplate.Height = 28;
            this.gvClasses.Size = new System.Drawing.Size(680, 371);
            this.gvClasses.TabIndex = 3;
            // 
            // gvLines
            // 
            this.gvLines.AllowUserToOrderColumns = true;
            this.gvLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLines.Location = new System.Drawing.Point(14, 578);
            this.gvLines.Name = "gvLines";
            this.gvLines.RowTemplate.Height = 28;
            this.gvLines.Size = new System.Drawing.Size(680, 371);
            this.gvLines.TabIndex = 4;
            // 
            // gvLinesUser
            // 
            this.gvLinesUser.AllowUserToOrderColumns = true;
            this.gvLinesUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLinesUser.Location = new System.Drawing.Point(756, 578);
            this.gvLinesUser.Name = "gvLinesUser";
            this.gvLinesUser.RowTemplate.Height = 28;
            this.gvLinesUser.Size = new System.Drawing.Size(680, 371);
            this.gvLinesUser.TabIndex = 5;
            // 
            // txtbLines
            // 
            this.txtbLines.Location = new System.Drawing.Point(758, 538);
            this.txtbLines.Name = "txtbLines";
            this.txtbLines.Size = new System.Drawing.Size(244, 26);
            this.txtbLines.TabIndex = 6;
            this.txtbLines.Text = "Enter Number of Min Lines (Byte)";
            // 
            // btnLinesUser
            // 
            this.btnLinesUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinesUser.Location = new System.Drawing.Point(1010, 534);
            this.btnLinesUser.Name = "btnLinesUser";
            this.btnLinesUser.Size = new System.Drawing.Size(94, 40);
            this.btnLinesUser.TabIndex = 7;
            this.btnLinesUser.Text = "SEARCH";
            this.btnLinesUser.UseVisualStyleBackColor = true;
            this.btnLinesUser.Click += new System.EventHandler(this.btnLinesUser_Click);
            // 
            // lblExtRef
            // 
            this.lblExtRef.AutoSize = true;
            this.lblExtRef.Location = new System.Drawing.Point(14, 105);
            this.lblExtRef.Name = "lblExtRef";
            this.lblExtRef.Size = new System.Drawing.Size(154, 20);
            this.lblExtRef.TabIndex = 8;
            this.lblExtRef.Text = "External References";
            // 
            // lblClasses
            // 
            this.lblClasses.AutoSize = true;
            this.lblClasses.Location = new System.Drawing.Point(756, 105);
            this.lblClasses.Name = "lblClasses";
            this.lblClasses.Size = new System.Drawing.Size(299, 20);
            this.lblClasses.TabIndex = 9;
            this.lblClasses.Text = "Classes and Number of Methods in Class";
            // 
            // lblMethodLines
            // 
            this.lblMethodLines.AutoSize = true;
            this.lblMethodLines.Location = new System.Drawing.Point(14, 552);
            this.lblMethodLines.Name = "lblMethodLines";
            this.lblMethodLines.Size = new System.Drawing.Size(253, 20);
            this.lblMethodLines.TabIndex = 10;
            this.lblMethodLines.Text = "Number of Lines (Byte) in Methods";
            // 
            // pbSearch
            // 
            this.pbSearch.Location = new System.Drawing.Point(1134, 535);
            this.pbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(238, 35);
            this.pbSearch.TabIndex = 11;
            // 
            // pbLoad
            // 
            this.pbLoad.Location = new System.Drawing.Point(20, 78);
            this.pbLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbLoad.Name = "pbLoad";
            this.pbLoad.Size = new System.Drawing.Size(1416, 22);
            this.pbLoad.TabIndex = 12;
            this.pbLoad.Visible = false;
            // 
            // gvInterfaces
            // 
            this.gvInterfaces.AllowUserToOrderColumns = true;
            this.gvInterfaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvInterfaces.Location = new System.Drawing.Point(20, 1002);
            this.gvInterfaces.Name = "gvInterfaces";
            this.gvInterfaces.RowTemplate.Height = 28;
            this.gvInterfaces.Size = new System.Drawing.Size(1194, 505);
            this.gvInterfaces.TabIndex = 13;
            // 
            // pbInterfaces
            // 
            this.pbInterfaces.Location = new System.Drawing.Point(700, 957);
            this.pbInterfaces.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbInterfaces.Name = "pbInterfaces";
            this.pbInterfaces.Size = new System.Drawing.Size(735, 35);
            this.pbInterfaces.TabIndex = 14;
            // 
            // txtbInterfaces
            // 
            this.txtbInterfaces.Location = new System.Drawing.Point(20, 962);
            this.txtbInterfaces.Name = "txtbInterfaces";
            this.txtbInterfaces.Size = new System.Drawing.Size(574, 26);
            this.txtbInterfaces.TabIndex = 15;
            this.txtbInterfaces.Text = "Enter regular expression or interface name";
            // 
            // btnInterfaces
            // 
            this.btnInterfaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterfaces.Location = new System.Drawing.Point(600, 955);
            this.btnInterfaces.Name = "btnInterfaces";
            this.btnInterfaces.Size = new System.Drawing.Size(94, 40);
            this.btnInterfaces.TabIndex = 16;
            this.btnInterfaces.Text = "SEARCH";
            this.btnInterfaces.UseVisualStyleBackColor = true;
            this.btnInterfaces.Click += new System.EventHandler(this.btnInterfaces_Click);
            // 
            // richTextBoxTree
            // 
            this.richTextBoxTree.Location = new System.Drawing.Point(1478, 131);
            this.richTextBoxTree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxTree.Name = "richTextBoxTree";
            this.richTextBoxTree.Size = new System.Drawing.Size(208, 369);
            this.richTextBoxTree.TabIndex = 18;
            this.richTextBoxTree.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1478, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tree Data Structure";
            // 
            // txtbTreeSearch
            // 
            this.txtbTreeSearch.Location = new System.Drawing.Point(1478, 71);
            this.txtbTreeSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbTreeSearch.Name = "txtbTreeSearch";
            this.txtbTreeSearch.Size = new System.Drawing.Size(394, 26);
            this.txtbTreeSearch.TabIndex = 20;
            this.txtbTreeSearch.Text = "Search Class";
            // 
            // btnSearchTree
            // 
            this.btnSearchTree.Location = new System.Drawing.Point(1886, 67);
            this.btnSearchTree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchTree.Name = "btnSearchTree";
            this.btnSearchTree.Size = new System.Drawing.Size(112, 35);
            this.btnSearchTree.TabIndex = 21;
            this.btnSearchTree.Text = "SEARCH";
            this.btnSearchTree.UseVisualStyleBackColor = true;
            this.btnSearchTree.Click += new System.EventHandler(this.BtnSearchTree_Click);
            // 
            // treeViewInterface
            // 
            this.treeViewInterface.Location = new System.Drawing.Point(1221, 1002);
            this.treeViewInterface.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeViewInterface.Name = "treeViewInterface";
            this.treeViewInterface.Size = new System.Drawing.Size(214, 505);
            this.treeViewInterface.TabIndex = 22;
            // 
            // treeViewClasses
            // 
            this.treeViewClasses.Location = new System.Drawing.Point(1694, 131);
            this.treeViewClasses.Name = "treeViewClasses";
            this.treeViewClasses.Size = new System.Drawing.Size(304, 369);
            this.treeViewClasses.TabIndex = 23;
            // 
            // btnSearchGraph
            // 
            this.btnSearchGraph.Location = new System.Drawing.Point(1886, 519);
            this.btnSearchGraph.Name = "btnSearchGraph";
            this.btnSearchGraph.Size = new System.Drawing.Size(112, 35);
            this.btnSearchGraph.TabIndex = 24;
            this.btnSearchGraph.Text = "SEARCH";
            this.btnSearchGraph.UseVisualStyleBackColor = true;
            this.btnSearchGraph.Click += new System.EventHandler(this.btnSearchGraph_Click);
            // 
            // txtbGraph
            // 
            this.txtbGraph.Location = new System.Drawing.Point(1478, 523);
            this.txtbGraph.Name = "txtbGraph";
            this.txtbGraph.Size = new System.Drawing.Size(394, 26);
            this.txtbGraph.TabIndex = 25;
            this.txtbGraph.Text = "Number of Relationships";
            // 
            // gvGraph
            // 
            this.gvGraph.AllowUserToOrderColumns = true;
            this.gvGraph.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGraph.Location = new System.Drawing.Point(1478, 580);
            this.gvGraph.Name = "gvGraph";
            this.gvGraph.RowTemplate.Height = 28;
            this.gvGraph.Size = new System.Drawing.Size(680, 371);
            this.gvGraph.TabIndex = 26;
            // 
            // rtxtbGraph
            // 
            this.rtxtbGraph.Location = new System.Drawing.Point(1478, 1002);
            this.rtxtbGraph.Name = "rtxtbGraph";
            this.rtxtbGraph.Size = new System.Drawing.Size(680, 505);
            this.rtxtbGraph.TabIndex = 27;
            this.rtxtbGraph.Text = "";
            // 
            // lblGraph
            // 
            this.lblGraph.AutoSize = true;
            this.lblGraph.Location = new System.Drawing.Point(1478, 552);
            this.lblGraph.Name = "lblGraph";
            this.lblGraph.Size = new System.Drawing.Size(163, 20);
            this.lblGraph.TabIndex = 28;
            this.lblGraph.Text = "Graph Data Structure";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(2400, 1593);
            this.Controls.Add(this.lblGraph);
            this.Controls.Add(this.rtxtbGraph);
            this.Controls.Add(this.gvGraph);
            this.Controls.Add(this.txtbGraph);
            this.Controls.Add(this.btnSearchGraph);
            this.Controls.Add(this.treeViewClasses);
            this.Controls.Add(this.treeViewInterface);
            this.Controls.Add(this.btnSearchTree);
            this.Controls.Add(this.txtbTreeSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxTree);
            this.Controls.Add(this.btnInterfaces);
            this.Controls.Add(this.txtbInterfaces);
            this.Controls.Add(this.pbInterfaces);
            this.Controls.Add(this.gvInterfaces);
            this.Controls.Add(this.pbLoad);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.lblMethodLines);
            this.Controls.Add(this.lblClasses);
            this.Controls.Add(this.lblExtRef);
            this.Controls.Add(this.btnLinesUser);
            this.Controls.Add(this.txtbLines);
            this.Controls.Add(this.gvLinesUser);
            this.Controls.Add(this.gvLines);
            this.Controls.Add(this.gvClasses);
            this.Controls.Add(this.gvExtRef);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.btnFile);
            this.Name = "Form1";
            this.Text = "Assembly Info";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gvExtRef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLinesUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInterfaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.DataGridView gvExtRef;
        private System.Windows.Forms.DataGridView gvClasses;
        private System.Windows.Forms.DataGridView gvLines;
        private System.Windows.Forms.DataGridView gvLinesUser;
        private System.Windows.Forms.TextBox txtbLines;
        private System.Windows.Forms.Button btnLinesUser;
        private System.Windows.Forms.Label lblExtRef;
        private System.Windows.Forms.Label lblClasses;
        private System.Windows.Forms.Label lblMethodLines;
        private System.Windows.Forms.ProgressBar pbSearch;
        private System.Windows.Forms.ProgressBar pbLoad;
        private System.Windows.Forms.DataGridView gvInterfaces;
        private System.Windows.Forms.ProgressBar pbInterfaces;
        private System.Windows.Forms.TextBox txtbInterfaces;
        private System.Windows.Forms.Button btnInterfaces;
        private System.Windows.Forms.RichTextBox richTextBoxTree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbTreeSearch;
        private System.Windows.Forms.Button btnSearchTree;
        private System.Windows.Forms.TreeView treeViewInterface;
        private System.Windows.Forms.TreeView treeViewClasses;
        private System.Windows.Forms.Button btnSearchGraph;
        private System.Windows.Forms.TextBox txtbGraph;
        private System.Windows.Forms.Label lblGraph;
        public System.Windows.Forms.RichTextBox rtxtbGraph;
        public System.Windows.Forms.DataGridView gvGraph;
    }
}

