using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;


namespace ToDo_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void _countNumberOfNodes()
        {
            lblNumOfNotes.Text = tvNotes.Nodes.Count.ToString();
        }

        private void UpdateNodeFont(TreeNode node, bool isChecked)
        {
            Font originalFont = tvNotes.Font;

            if(isChecked)
            {
                node.NodeFont = new Font(originalFont, FontStyle.Strikeout);
                node.ForeColor = Color.DarkGray;
            }
            else
            {
                node.NodeFont = new Font(originalFont, FontStyle.Regular);
                node.ForeColor = Color.Black;
            }

            tvNotes.Invalidate();
        }

        private int CountCheckedNodes(TreeNodeCollection nodes)
        {
            int count = 0;

            foreach (TreeNode node in nodes)
            {
                if (node.Checked)
                    count++;
                 count += CountCheckedNodes(node.Nodes);
            }

            return count;
        }

        private int CountAllNodes(TreeNodeCollection nodes)
        {
            int count = 0;

            foreach (TreeNode node in nodes)
            {
                count++;
                count += CountAllNodes(node.Nodes);
            }

            return count;
        }
        private void _updateProgressBar()
        {
            progBar.Minimum = 0;
            progBar.Maximum = 100;
            progBar.Value = 0;

            int totalNodes = CountAllNodes(tvNotes.Nodes);
            int countCheckedNodes = CountCheckedNodes(tvNotes.Nodes);

            if (totalNodes == 0)
            {
                progBar.Value = 0;
                return;
            }

            int percentage = (int)((((float)countCheckedNodes / (float)totalNodes) * 100));

            if (percentage > progBar.Maximum)
                percentage = progBar.Maximum;

            if (percentage < progBar.Minimum)
                percentage = progBar.Minimum;

            progBar.Value += percentage;
        }


        private void _decreaseProgressBar()
        {
            progBar.Minimum = 0;
            progBar.Maximum = 100;
            progBar.Value = 0;

            int totalNodes = tvNotes.Nodes.Count;
            int countCheckedNodes = CountCheckedNodes(tvNotes.Nodes);

            if (totalNodes == 0)
            {
                progBar.Value = 0;
                return;
            }

            int percentage = (int)((((float)countCheckedNodes / (float)totalNodes) * 100));

            if (percentage > progBar.Maximum)
                percentage = progBar.Maximum;

            if (percentage < progBar.Minimum)
                percentage = progBar.Minimum;

            progBar.Value = percentage--;
        }
        private void tvNotes_AfterCheck(object sender, TreeViewEventArgs e)
        {

            UpdateNodeFont(e.Node, e.Node.Checked);

           if(e.Node.Checked)
            {
                if (progBar.Value < progBar.Maximum)
                {
                    Thread.Sleep(500);
                   // progBar.Value += 1;
                    _updateProgressBar();
                    lblProgressValue.Text = (((float)progBar.Value / progBar.Maximum) * 100) + "%";
                    progBar.Refresh();
                    lblProgressValue.Refresh();
                }
            }

            else
            {
                if (progBar.Value > 0)
                {
                    _decreaseProgressBar();
                    lblProgressValue.Text = progBar.Value + "%";
                }
            }
        }

        private void removeNote_Click(object sender, EventArgs e)
        {
            if (tvNotes.SelectedNode != null)
            {
                tvNotes.SelectedNode.Remove();
                _countNumberOfNodes();
                if (progBar.Value > 0)
                {
                    _decreaseProgressBar();
                    lblProgressValue.Text = progBar.Value + "%";
                }
            }
            else
                MessageBox.Show("Please select note to delete");
           
        }

        private void removeAllNotes_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to delete all notes ? ", "Delete All Notes", 
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Warning, 
                MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                tvNotes.Nodes.Clear();
                _countNumberOfNodes();
            }

            progBar.Value = 0;
            lblProgressValue.Text = progBar.Value + "%";
        }

        private void addNote_Click(object sender, EventArgs e)
        {
           if(txtBox.Text != "")
            {
                tvNotes.Nodes.Add(txtBox.Text);
                _countNumberOfNodes();
                txtBox.Clear();
                txtBox.Focus();
                _updateProgressBar();
                lblProgressValue.Text = progBar.Value + "%";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
