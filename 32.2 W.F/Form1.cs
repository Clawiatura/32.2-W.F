namespace _32._2_W.F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rootPath = "C:\\Program Files\\Microsoft Visual Studio";
            DirectoryInfo root = new DirectoryInfo(rootPath);
            TreeNode child = new TreeNode(rootPath);
            PrintTree(child, root, 0);
            void PrintTree(TreeNode parent, DirectoryInfo directory, int level)
            {
                DirectoryInfo[] directories = directory.GetDirectories();
                for (int i = 0; i < directories.Length; i++)
                {
                    TreeNode child = new TreeNode(directories[i].Name);
                    parent.Nodes.Add(child);
                    PrintTree(child, directories[i], level+1);
                }
                if(level== 0)
                {
                    treeView1.Nodes.Add(parent);
                }
            }
        }
    }

}
