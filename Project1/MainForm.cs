using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// 최상위 노드 추가버튼 클릭시 Form3를 띄움.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 최상위노드추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int determinant = 1;
            Form3 form3 = new Form3(this, determinant);
            form3.Show();
        }

        /// <summary>
        /// Form3에서 완료 버튼 클릭시 최상위 노드추가.
        /// </summary>
        /// <param name="AddName"></param>
        public void 최상위노드추가(string AddName)
        {
            TreeNode node = new TreeNode(AddName);
            node.Name = AddName;

            try
            {
                if (AddName != "")
                {
                    treeView1.Nodes.Add(node);
                }
                else
                    throw new Exception("생성할 node의 이름을 입력하세요!");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                MessageBox.Show(error.Message);
            }
        }

        /// <summary>
        /// 선택한 Node Text 창에 띄우기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            toolStripTextBox3.Text = treeView1.SelectedNode.Text;
        }

        /// <summary>
        /// 하위노드 추가버튼 클릭시 Form3 띄우기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 하위노드추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int determinant = 2;
            Form3 form3 = new Form3(this, determinant);
            form3.Show();
        }

        /// <summary>
        /// 하위노드 추가하기
        /// </summary>
        /// <param name="AddName"></param>
        public void 하위노드추가(string AddName)
        {
            TreeNode node = new TreeNode(AddName);
            node.Name = AddName;
            try
            {
                if (treeView1.SelectedNode != null)
                {
                    try
                    {
                        if (AddName == "")
                        {
                            throw new Exception("생성할 node의 이름을 입력하세요");
                        }
                        else if (treeView1.SelectedNode.ImageIndex == 1)
                        {
                            throw new Exception("Table은 하위경로를 생성하지 못합니다.");
                        }
                        else
                            treeView1.SelectedNode.Nodes.Add(node);
                    }
                    catch (Exception error2)
                    {
                        Console.WriteLine(error2.Message);
                        MessageBox.Show(error2.Message);
                    }
                }
                else
                    throw new Exception("ParentNode를 선택하지 않았습니다.");
            }
            catch (Exception error1)
            {
                Console.WriteLine(error1.Message);
                MessageBox.Show(error1.Message);
            }
        }

        /// <summary>
        /// Node 수정하기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this, treeView1.SelectedNode.Text);
            form4.Show();
        }

        /// <summary>
        /// Node 수정하기
        /// </summary>
        /// <param name="EditName"></param>
        public void 수정(string EditName)
        {
            try
            {
                if (treeView1.SelectedNode != null)
                {
                    if (treeView1.SelectedNode.ImageIndex != 1)
                    {
                        if (EditName != "")
                        {
                            treeView1.SelectedNode.Name = EditName;
                            treeView1.SelectedNode.Text = EditName;
                        }
                        else
                            throw new Exception("수정할 node의 이름을 입력하세요!");
                    }
                    else
                    {
                        throw new Exception("Table의 명칭은 HTML TABLE의 제목으로 지정됩니다.");
                    }
                }
                else
                    throw new Exception("수정할 Node를 선택하지 않았습니다!");
            }
            catch (Exception error1)
            {
                Console.WriteLine(error1.Message);
                MessageBox.Show(error1.Message);
            }
        }

        /// <summary>
        /// Node 삭제하기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeView1.SelectedNode != null)
                {
                    DeleteNode(treeView1.SelectedNode);
                }
                else
                    throw new Exception("삭제할 Node를 선택하지 않았습니다!");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                MessageBox.Show(error.Message);
            }
        }

        /// <summary>
        /// Table추가 버튼 클릭 시 From1실행.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void table추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                if (treeView1.SelectedNode == null)
                {
                    throw new Exception("ParentNode를 선택하지 않았습니다.");
                }
                else
                {
                    if (treeView1.SelectedNode.ImageIndex == 1)
                        throw new Exception("Table은 하위경로를 생성하지 못합니다.");
                    else
                    {
                        // 0. 중복 창이 띄워져있는지 체크
                        if (Application.OpenForms["Form1"] is Form1 form1)
                        {
                            // Form1이 열려 있을 경우.
                            form1.Focus();
                        }
                        else
                        {
                            // 1. 새로 듸울 Form new 객체생성
                            form1 = new Form1(this);
                            // 2. 폼이름.show()
                            form1.Show();
                        }
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                MessageBox.Show(error.Message);
            }

        }
        
        /// <summary>
        /// Add Node (Table  Node추가)-> Form1에서 저장 버튼을 누르면 작동.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="tablename"></param>
        public void AddNode1(string address, string tablename)
        {
            TreeNode node = new TreeNode(tablename);
            node.ImageIndex = 1;
            node.SelectedImageIndex = 1;
            // node의 키 값 지정.
            node.Name = address;
            
            try
            {
                if (treeView1.SelectedNode != null)
                {
                    treeView1.SelectedNode.Nodes.Add(node);
                }
                else
                    throw new Exception("ParentNode를 선택하지 않았습니다.");
            }
            catch (Exception error1)
            {
                Console.WriteLine(error1.Message);
                MessageBox.Show(error1.Message);
            }
        }

        /// <summary>
        /// Table 수정시, 다른이름으로저장 클릭.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="tablename"></param>
        public void AddNode2(string address, string tablename)
        {
            TreeNode node = new TreeNode(tablename);
            node.ImageIndex = 1;
            node.SelectedImageIndex = 1;
            // node의 키 값 지정.
            node.Name = address;

            treeView1.SelectedNode.Parent.Nodes.Add(node);


        }

        /// <summary>
        /// 수정시, 수정버튼 클릭.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="tablename"></param>
        public void Edit(string address, string tablename)
        {
            TreeNode node = new TreeNode(tablename);
            node.ImageIndex = 1;
            node.SelectedImageIndex = 1;
            // node의 키 값 지정.
            node.Name = address;

            treeView1.SelectedNode.Parent.Nodes.Add(node);
            treeView1.SelectedNode.Remove();
        }

        /// <summary>
        /// treeview에서 Table Click시 Webbrowser에 보이도록 하는 함수.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.ImageIndex==1)
            {
                //File.Copy(e.Node.Name, "Copy.html");
                webBrowser1.Navigate(e.Node.Name);
                textBox1.Text = e.Node.Name;
            }
        }

        /// <summary>
        /// (재귀함수) 하위 경로의 Table과 노드 모두 삭제하도록 하는 함수.
        /// </summary>
        /// <param name="node"></param>
        private void DeleteNode(TreeNode node)
        {
            int num = node.GetNodeCount(false);
            if (num > 0)
            {
                for (int i=0; i<num; i++)
                {
                    DeleteNode(node.Nodes[0]);
                }
            }
            else
            {
                if (node.ImageIndex == 1)
                {
                    File.Delete(node.Name);
                }
            }
            node.Remove();
        }

        /// <summary>
        /// table 수정 버튼 클릭시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void table수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeView1.SelectedNode == null)
                {
                    throw new Exception("선택된 Table이 없습니다.");
                }
                else
                {
                    if (treeView1.SelectedNode.ImageIndex!=1)
                    {
                        throw new Exception("Table이 선택되어야 합니다.");
                    }
                    else
                    {
                        // 수정버튼을 눌렀을때 나타날 현상 구현.
                        Form2 form2 = new Form2(this, treeView1.SelectedNode.Name);
                        form2.Show();
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                MessageBox.Show(error.Message);
            }

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
