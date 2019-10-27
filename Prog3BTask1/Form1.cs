using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Text;

//Grant Verheul 12001640
//Task 1
//Dynamically loads a .NET assembly
//Displays an aplphabetical list of all the external references that the assembly specifies.
//Displays a list of all the classes in the assembly, ordered by number of methods in the class
//Displays a list of all the classes in the assembly, ordred by average number of lines per method - changed to byte size
//Visually distinguishes all the classes that have an average number of lines per method higher than a user configurable number as non-compliant to company standards
//Task 2
//Display all the interfaces in the assemby in aplabetical order.
//Visually distinguishes any interfaces with no implementations as non-compliant to company standards.
//Visually distinguishes any interfaces with names that do not match a user configurable regular expression as non-compliant to company standards.
//Display all the classes that implement a user selected interface.
//Task 3
//Uses a tree data structure to represent the inheritance hierachy of each of the classes in the assembly.
//Display the inheritance hierarchy of any selected class to the user.
//Uses recursion to export a text file that shows the classes and hierachy of each one.
//Uses a graph data structure to represent the association and composition relationships between classes.
//Displays the relationships of any selected class to the user.
//Visually distinguishes any class with more than a user configurable number of relationships as non-complaint with company standards.
namespace Prog3BTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //create gridviews
            gvClasses.Columns.Add("a", "Class");
            gvClasses.Columns.Add("b", "Number Methods");
            gvLines.Columns.Add("a", "Class");
            gvLines.Columns.Add("b", "Method");
            gvLines.Columns.Add("c", "Byte Size");
            gvLinesUser.Columns.Add("a", "Class");
            gvLinesUser.Columns.Add("b", "Method");
            gvLinesUser.Columns.Add("c", "Byte Size");
            gvExtRef.Columns.Add("a", "Name");
            gvInterfaces.Columns.Add("a", "Class");
            gvInterfaces.Columns.Add("b", "Interface");
            gvInterfaces.Columns.Add("c", "Compliant");
            gvGraph.Columns.Add("a", "Class");
            gvGraph.Columns.Add("b", "Number of Relationships");
            gvGraph.Columns.Add("c", "Company Standards");
        }
        //main method is Info() *
        public void Info()
        {
            using (OpenFileDialog opf = new OpenFileDialog())
            {
                opf.ShowDialog();//dynamically load. Opens file browser
                Assembly a = Assembly.LoadFile(opf.FileName);
                var tree = new Tree<string>();//tree define
                String treeDisplay = "";//tree data recived from tree.txt
                string logTxtPath = @"logTxt.txt";
                //write to log file
                using (StreamWriter writetext = new StreamWriter(logTxtPath))//for log file
                {
                    writetext.WriteLine("LOG FILE " + DateTime.Now);//log file
                    int countMethods = 0, countClass = 0;//for sorting out class and method relations
                    gvExtRef.Rows.Clear();
                    gvClasses.Rows.Clear();
                    gvLines.Rows.Clear();
                    gvLinesUser.Rows.Clear();
                    gvInterfaces.Rows.Clear();
                    gvGraph.Rows.Clear();
                    treeViewInterface.Nodes.Clear();
                    List<String> classList = new List<String>();//storing classes
                    List<String> methodList = new List<String>();//storing methods
                    List<String> InterfaceList = new List<String>();//for tree interface
                    List<String> NotInterfaceList = new List<String>();//for tree interface
                    List<String> AllReferencedInterfaces = new List<String>();//for tree interface
                    List<String> AllReferencedInterfacesClass = new List<String>();//for tree interface
                    List<String> NotAllReferencedInterfaces = new List<String>();//for tree interface
                    List<String> NotAllReferencedInterfacesClass = new List<String>();//for tree interface
                    List<String> ReferencedInterfaces = new List<String>();//for tree interface
                    List<String> NotReferencedInterfaces = new List<String>();//for tree interface
                    List<String> RefList = new List<String>();//for tree interface
                    HashSet<String> NonRefList = new HashSet<String>();//for tree interface
                    int refClass = 0;//for tree interface
                    Type[] Types = a.GetTypes();//classes and methods from assembly file
                    List<AssemblyName> ExRef = a.GetReferencedAssemblies().ToList();//ref assembly
                    //START External Reference
                    foreach (var exRef in ExRef)
                    {
                        gvExtRef.Rows.Add(exRef.FullName);
                        writetext.WriteLine("External Refrence: " + exRef.FullName);//write to log file
                    }
                    // Console.WriteLine("");
                    gvExtRef.Sort(gvExtRef.Columns["a"], ListSortDirection.Ascending);
                    gvExtRef.AutoResizeColumns();
                    gvExtRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    //END External Reference
                    //loading bar
                    int loadbarClassCount = 0;
                    foreach (Type classesCount in Types)//load bar
                    {
                        loadbarClassCount++;
                    }
                    pbLoad.Visible = true;
                    pbLoad.Minimum = 0;
                    pbLoad.Maximum = loadbarClassCount;
                    pbLoad.Value = 1;
                    pbLoad.Step = 1;
                    foreach (Type classes in Types)//get classes
                    {
                        pbLoad.Step = 1;
                        pbLoad.PerformStep();//load bar
                        lblFile.Text = classes.Assembly.ToString();//display dll name
                        writetext.WriteLine("File Name: " + classes.Assembly.ToString());//write to log file
                        //START Interfaces
                        try
                        {
                            Type[] interfaces = classes.GetInterfaces();//new/
                            foreach (Type type in interfaces)//new. load from main dll file and create object type to compare interface Type type in Assembly.LoadFile(opf.FileName).GetTypes()
                            {
                                //if (type.IsInterface)
                                //{
                                //    gvInterfaces.Rows.Add(classes.Name.ToString(), type.Name.ToString(), "compliant!");
                                //}
                                //else
                                //{
                                //    gvInterfaces.Rows.Add(classes.Name.ToString(), type.Name.ToString(), "non-compliant!");
                                //}
                                if (!type.IsImport)//new. Makes sure the class is an interface.
                                {

                                    gvInterfaces.Rows.Add(classes.Name.ToString(), type.Name.ToString(), "compliant");
                                    //write to log file
                                    writetext.WriteLine("Has interface: Class: " + classes.Name.ToString() + " Interface Name: " + type.Name.ToString() + " is compliant");
                                }
                                else
                                {
                                    gvInterfaces.Rows.Add(classes.Name.ToString(), type.Name.ToString(), "non-compliant");
                                    //write to log file
                                    writetext.WriteLine("Has no interface: Class: " + classes.Name.ToString() + " Interface Name: " + type.Name.ToString() + " is non-compliant");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Interface error \n" + ex);
                        }
                        //END Interfaces
                        classList.Add(classes.Name);//store public classes
                        //get methods
                        MethodInfo[] methods = classes.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Public);
                        foreach (MethodInfo method in methods)//get methods. Note: still in the classes foreach loop
                        {
                            try
                            {
                                MethodBody mb = method.GetMethodBody();//for byte size
                                if (mb != null)
                                {
                                    countMethods++;
                                    //show in grid views
                                    gvLines.Rows.Add(classes.Name, method.Name, mb.GetILAsByteArray().Length);
                                    gvLinesUser.Rows.Add(classes.Name, method.Name, mb.GetILAsByteArray().Length);
                                    writetext.WriteLine("Class Name: " + classes.Name + " Method Name: " + method.Name + " Method Size: " + mb.GetILAsByteArray().Length);//write to log file
                                }
                                else //mb has 0 bytes
                                {
                                    countMethods++;
                                    //show in grid views
                                    gvLines.Rows.Add(classes.Name, method.Name, 0);
                                    gvLinesUser.Rows.Add(classes.Name, method.Name, 0);
                                    writetext.WriteLine("Class Name: " + classes.Name + " Method Name: " + method.Name + " Method Size: " + 0);//write to log file
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("MethofInfo Error \n" + ex);
                            }
                        }
                        methodList.Add(countMethods.ToString());//store number of methods in class
                        countMethods = 0;
                        countClass++;
                        //sorting grid views
                        gvLines.Sort(gvLines.Columns["c"], ListSortDirection.Descending);
                        gvLines.AutoResizeColumns();
                        gvLines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        
                        //tree stuff interfaces
                        Type[] ifaces = classes.GetInterfaces();
                        foreach (Type i in ifaces)
                        {
                            AllReferencedInterfaces.Add(i.Name);
                            AllReferencedInterfacesClass.Add(classes.Name);
                            NotAllReferencedInterfaces.Add(i.Name);
                            NotAllReferencedInterfacesClass.Add(classes.Name);
                        }
                        //all interfaces
                        if (classes.IsInterface)
                        {
                            InterfaceList.Add(classes.Name);
                        }
                        else
                        {
                            NotInterfaceList.Add(classes.Name);
                        }

                        for (int i = 0; i < InterfaceList.Count; i++)
                        {

                            for (int j = 0; j < AllReferencedInterfaces.Count; j++)
                            {
                                if (InterfaceList[i] == AllReferencedInterfaces[j])
                                {
                                    ReferencedInterfaces.Add(InterfaceList[i]);
                                }
                            }
                        }
                        for (int i = 0; i < NotInterfaceList.Count; i++)
                        {

                            for (int j = 0; j < NotAllReferencedInterfaces.Count; j++)
                            {
                                if (NotInterfaceList[i] == NotAllReferencedInterfaces[j])
                                {
                                    NotReferencedInterfaces.Add(NotInterfaceList[i]);
                                }
                            }
                        }

                    }
                    //display classes and number of methods
                    int numClasses = classList.Count;
                    int numMethods = methodList.Count;
                    string[,] classes2d = new string[numClasses, numMethods];
                    for (int i = 0; i < classList.Count; i++)
                    {
                        gvClasses.Rows.Add(classList[i], Int64.Parse(methodList[i]));
                        writetext.WriteLine("Class Name: " + classList[i] + " Method Name: " + Int64.Parse(methodList[i]));//write to log file
                    }
                    //sorted classes gridview
                    gvClasses.Sort(gvClasses.Columns["b"], ListSortDirection.Descending);
                    gvClasses.AutoResizeColumns();
                    gvClasses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    //sorting interfaces grid views
                    gvInterfaces.Sort(gvInterfaces.Columns["b"], ListSortDirection.Ascending);
                    gvInterfaces.Sort(gvInterfaces.Columns["c"], ListSortDirection.Ascending);//testing sort complaint first
                    gvInterfaces.AutoResizeColumns();
                    gvInterfaces.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    //sorting linesuser grid views
                    gvLinesUser.Sort(gvLinesUser.Columns["c"], ListSortDirection.Descending);
                    gvLinesUser.AutoResizeColumns();
                    gvLinesUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    //colour Interfaces gridviews
                    int rowscount = gvInterfaces.RowCount - 2;//stop over count
                    try
                    {
                        for (int i = 0; i <= rowscount; i++)
                        {
                            if (!(gvInterfaces.Rows[i].Cells[2].Value.ToString() == "compliant"))
                            {
                                gvInterfaces.Rows[i].Cells[1].Style.BackColor = Color.LightBlue;
                                gvInterfaces.Rows[i].Cells[0].Style.BackColor = Color.LightBlue;
                                gvInterfaces.Rows[i].Cells[2].Style.BackColor = Color.LightBlue;
                            }
                            if (gvInterfaces.Rows[i].Cells[2].Value.ToString() == "compliant")
                            {
                                gvInterfaces.Rows[i].Cells[1].Style.BackColor = Color.Green;
                                gvInterfaces.Rows[i].Cells[0].Style.BackColor = Color.Green;
                                gvInterfaces.Rows[i].Cells[2].Style.BackColor = Color.Green;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Colour Lines Error" + ex);
                    }
                    //tree stuff Interfaces
                    TreeNode[] array1 = null;
                    for (int i = 0; i < InterfaceList.Count; i++)
                    {
                        // TreeNode treeNode = new TreeNode(InterfaceList[i]);
                        Console.WriteLine("The following interface is Implemented:  " + InterfaceList[i]);
                        TreeNode treeNodes = new TreeNode(InterfaceList[i]);
                        treeViewInterface.Nodes.Add(treeNodes);

                        for (int j = 0; j < AllReferencedInterfaces.Count; j++)
                        {
                            if (InterfaceList[i] == AllReferencedInterfaces[j])
                            {
                                refClass++;
                            }

                            array1 = new TreeNode[refClass];
                            if (InterfaceList[i] == AllReferencedInterfaces[j])
                            {
                                //gvInterfaces.Rows.Add(AllReferencedInterfacesClass[j].ToString(), InterfaceList[i].ToString(), "compliant");
                                treeViewInterface.Nodes[i].Nodes.Add(AllReferencedInterfacesClass[j]);

                                TreeNode nodeb = new TreeNode(AllReferencedInterfacesClass[j]);

                                RefList.Add(InterfaceList[i]);
                            }
                        }
                    }
                }
                
                richTextBoxTree.Clear();
                treeAdd(opf.FileName, treeViewClasses);//tree classes, add to treeView
                SaveTreeViewIntoFile(treeViewClasses);//tree write to file
                //tree read from file
                using (StreamReader readtext = new StreamReader(@"tree.txt"))
                {
                    String s = "";
                    while ((s = readtext.ReadLine()) != null)
                    {
                        treeDisplay += s + "\n";
                    }
                }
                richTextBoxTree.AppendText(treeDisplay);//tree add to richTextBox
                //starts the graph data structure from GraphDataStructures class
                rtxtbGraph.Clear();
                GraphDataStructures.startGraph(opf.FileName, rtxtbGraph, gvGraph);

            }
        }

        //user search method
        public void InfoLinesUser()
        {
            try
            {
                int gvLinesUserRowCount = gvLinesUser.RowCount;//get size of gridview
                //loading bar
                pbSearch.Minimum = 0;
                pbSearch.Maximum = gvLinesUserRowCount;
                pbSearch.Value = 1;
                pbSearch.Step = 1;
                //search and remove 
                for (int i = 0; i <= gvLinesUserRowCount; i++)//cycles through all of gridview
                {
                    while (Int32.Parse(gvLinesUser.Rows[i].Cells[2].Value.ToString()) <= Int32.Parse(txtbLines.Text))//removes user specified amount (including duplicates)
                    {
                        gvLinesUser.Rows.Remove(gvLinesUser.Rows[i]);//removes at found variable less than user specified
                        gvLinesUserRowCount--;//reduces overall gridview count size
                        gvLinesUser.Refresh();//can be deleted and leave refresh on line 170, just looks good seeing lines disappear one by one
                        pbSearch.PerformStep();//increase progress bar
                    }
                    pbSearch.PerformStep();//increase progress bar
                }
                //sort and update gridview
                gvLinesUser.Refresh();//update gridview to new values
                gvLinesUser.AutoResizeColumns();
                gvLinesUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                gvLinesUser.Sort(gvLinesUser.Columns["c"], ListSortDirection.Descending);
            }
            catch (Exception ex)
            {
                Console.WriteLine("InfoLinesUser Error on Remove \n" + ex);
            }
        }
        //user search interfaces
        public void InterfaceUser()
        {
            try
            {
                int gvInterfacesRowCount = gvInterfaces.RowCount;//get size of gridview
                //loading bar
                pbInterfaces.Minimum = 0;
                pbInterfaces.Maximum = gvInterfacesRowCount;
                pbInterfaces.Value = 1;
                pbInterfaces.Step = 1;
                //Regrex
                Regex regex = new Regex(txtbInterfaces.Text.ToString());
                if (txtbInterfaces.Text != "")
                {
                    //search
                    for (int i = 0; i <= gvInterfacesRowCount; i++)//cycles through all of gridview
                    {
                        Match match = regex.Match(gvInterfaces.Rows[i].Cells[1].Value.ToString());//regrex match and compare
                        if (match.Success)
                        {
                            gvInterfaces.Rows[i].Cells[1].Style.BackColor = Color.Green;
                            gvInterfaces.Rows[i].Cells[2].Style.BackColor = Color.Green;
                            gvInterfaces.Rows[i].Cells[2].Value = "COMPLIANT";//optional
                        }
                        else
                        {
                            gvInterfaces.Rows[i].Cells[1].Style.BackColor = Color.Red;
                            gvInterfaces.Rows[i].Cells[2].Style.BackColor = Color.Red;
                            gvInterfaces.Rows[i].Cells[2].Value = "NON-COMPLIANT";//optional
                        }
                        pbInterfaces.PerformStep();//increase progress bar
                    }
                    gvInterfaces.Sort(gvInterfaces.Columns["b"], ListSortDirection.Ascending);
                    gvInterfaces.Refresh();//not needed
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("InterfaceUser Method Error \n" + ex);
            }
        }
        //Searches tree for user defined class
        public void userSearchTree()
        {
            if (richTextBoxTree.Text.Contains(txtbTreeSearch.Text))
            {
                var matchString = Regex.Escape(txtbTreeSearch.Text);
                foreach (Match match in Regex.Matches(richTextBoxTree.Text, matchString))
                {
                    richTextBoxTree.Select(match.Index, txtbTreeSearch.Text.Length);
                    richTextBoxTree.SelectionColor = Color.Green;
                    richTextBoxTree.Select(richTextBoxTree.TextLength, 0);
                    richTextBoxTree.SelectionColor = richTextBoxTree.ForeColor;
                }
            }
        }
        //user search graph
        public void GraphUser()
        {
            try
            {
                int gvGraphRowCount = gvGraph.RowCount;//get size of gridview

                if (txtbGraph.Text != "")
                {
                    //search
                    for (int i = 0; i <= gvGraphRowCount; i++)//cycles through all of gridview
                    {
                        if (Int32.Parse(txtbGraph.Text.ToString()) >= Int32.Parse(gvGraph.Rows[i].Cells[1].Value.ToString()))
                        {
                            gvGraph.Rows[i].Cells[0].Style.BackColor = Color.Green;
                            gvGraph.Rows[i].Cells[1].Style.BackColor = Color.Green;
                            gvGraph.Rows[i].Cells[2].Style.BackColor = Color.Green;
                            gvGraph.Rows[i].Cells[2].Value = "COMPLIANT";
                        }
                        else
                        {
                            gvGraph.Rows[i].Cells[0].Style.BackColor = Color.Red;
                            gvGraph.Rows[i].Cells[1].Style.BackColor = Color.Red;
                            gvGraph.Rows[i].Cells[2].Style.BackColor = Color.Red;
                            gvGraph.Rows[i].Cells[2].Value = "NON-COMPLIANT";
                        }

                    }
                    gvGraph.Refresh();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("InterfaceUser Method Error \n" + ex);
            }
        }
        private void btnFile_Click(object sender, EventArgs e)
        {
            try
            {
                Info();
            }
            catch (Exception ex)
            {
                MessageBox.Show("NOT A SUPPORTED FILE \n btnFile_Click \n" + ex.ToString());
            }
        }
        private void btnLinesUser_Click(object sender, EventArgs e)
        {
            try
            {
                InfoLinesUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SELECT ASSEMBLY FILE \n" + ex);
            }
        }
        private void btnInterfaces_Click(object sender, EventArgs e)
        {
            try
            {
                InterfaceUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Interfaces btn Error \n" + ex);
            }
        }
        private void BtnSearchTree_Click(object sender, EventArgs e)
        {
            userSearchTree();
        }
        private void btnSearchGraph_Click(object sender, EventArgs e)
        {
            GraphUser();
        }
        private void txtbGraph_KeyPress(object sender, KeyPressEventArgs e)//allow only numbers in the graph text box search
        {
            //allows backspace key
            if (e.KeyChar != '\b')
            {
                //allows just number keys
                e.Handled = !char.IsNumber(e.KeyChar);
            }
        }

        //tree methods 
        public static void treeAdd(string OPF, TreeView treeViewClasses)
        {
            try
            {
                treeViewClasses.Nodes.Clear();
                //var tree = new Tree<string>();//
                List<infoClass> classList = new List<infoClass>();
                Type[] Types = Assembly.LoadFile(OPF).GetTypes();
                foreach (Type classes in Types)
                {
                    //Gets the number of levels of the class
                    Type type = classes;
                    int iCount = 0;
                    while (type != null)
                    {
                        type = type.BaseType;
                        ++iCount;
                    }
                    //add each Class to list
                    infoClass obj = new infoClass(classes.Name.ToString());
                    obj.level = iCount;

                    if (obj.level > 1)
                    {
                        Type typee = classes;
                        obj.parentName = typee.BaseType.Name.ToString();
                    }
                    if (obj.level == 4)
                    {
                        Type typee = classes;
                        obj.grandparentName = typee.BaseType.BaseType.Name.ToString();
                    }
                    classList.Add(obj);
                }
                //1st level
                foreach (infoClass cls in classList)
                {
                    if (cls.level == 2)
                    {
                        treeViewClasses.Nodes.Add(cls.name);

                    }
                }
                foreach (infoClass cls in classList)
                {
                    if (cls.level == 3)
                    {
                        int parentNum = 0;
                        foreach (TreeNode node in treeViewClasses.Nodes)
                        {
                            if (node.Text.ToString() == cls.parentName)
                            {
                                parentNum = node.Index;
                            }
                        }
                        treeViewClasses.Nodes[parentNum].Nodes.Add(cls.name);
                    }
                }
                foreach (infoClass cls in classList)
                {
                    if (cls.level == 4)
                    {
                        int parentNum = 0;
                        int grandparentNum = 0;
                        foreach (TreeNode node in treeViewClasses.Nodes)
                        {
                            if (node.Text.ToString() == cls.grandparentName)
                            {
                                grandparentNum = node.Index;
                            }
                        }

                        foreach (TreeNode node in treeViewClasses.Nodes[grandparentNum].Nodes)
                        {
                            if (node.Text.ToString() == cls.parentName)
                            {
                                parentNum = node.Index;
                            }
                        }
                        treeViewClasses.Nodes[grandparentNum].Nodes[parentNum].Nodes.Add(cls.name);
                    }
                }
                //SaveTreeViewIntoFile(treeViewClasses);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAdd classes to tree :\n" + ex);
            }
        }
        //Class Info
        public class infoClass
        {
            public infoClass(string nam)
            {
                name = nam;
            }

            public string name { get; set; }
            public string parentName { get; set; }
            public string grandparentName { get; set; }

            public int level { get; set; }
        }

        // Write the TreeView's values into a file that uses tabs using recursion
        // to show indentation.
        private static void SaveTreeViewIntoFile(TreeView trv)
        {
            // Build a string containing the TreeView's contents.
            StringBuilder sb = new StringBuilder();
            foreach (TreeNode node in trv.Nodes)
                WriteNodeIntoString(0, node, sb);

            // Write the result into the file.
            File.WriteAllText(@"tree.txt", sb.ToString());
        }
        // Write this node's subtree into the StringBuilder.
        private static void WriteNodeIntoString(int level, TreeNode node, StringBuilder sb)
        {
            // Append the correct number of tabs and the node's text.
            sb.AppendLine(new string('\t', level) + node.Text);

            // Recursively add children with one greater level of tabs.
            foreach (TreeNode child in node.Nodes)
                WriteNodeIntoString(level + 1, child, sb);
        }
    }
    /// <summary>
    /// TODO
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Tree<T>
    {
        private Stack<TreeNode<T>> m_Stack = new Stack<TreeNode<T>>();
        public List<TreeNode<T>> Nodes { get; } = new List<TreeNode<T>>();
        public Tree<T> Begin(T val)
        {
            if (m_Stack.Count == 0)
            {
                var node = new TreeNode<T>(val, null);
                Nodes.Add(node);
                m_Stack.Push(node);
            }
            else
            {
                var node = m_Stack.Peek().Add(val);
                m_Stack.Push(node);
            }
            return this;
        }
        public Tree<T> Add(T val)
        {
            m_Stack.Peek().Add(val);
            return this;
        }
        public Tree<T> End()
        {
            m_Stack.Pop();
            return this;
        }
    }
    public class TreeNode<T>
    {
        public T Value { get; }
        public TreeNode<T> Parent { get; }
        public List<TreeNode<T>> Children { get; }
        public TreeNode(T val, TreeNode<T> parent)
        {
            Value = val;
            Parent = parent;
            Children = new List<TreeNode<T>>();
        }
        public TreeNode<T> Add(T val)
        {
            var node = new TreeNode<T>(val, this);
            Children.Add(node);
            return node;
        }


    }

}
