using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clope;

namespace ClusteringUI
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Dictionary<string, string[]> data = null;
        Dictionary<string[], int> distribution = null;
        List<Cluster> clusters = null;

        public Form()
        {
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, EventArgs e) => LoadData();
        private void btnCalculate_Click(object sender, EventArgs e) => Calculate();
        private void btnSave_Click(object sender, EventArgs e) => SaveResult();
        private void rbSeparator_CheckedChanged(object sender, EventArgs e) => SeparatorChangeHandling();
        private void tbSeparator_TextChanged(object sender, EventArgs e) => SeparatorChangeHandling();
        private void trackBarClusters_Scroll(object sender, EventArgs e) => ClusterChangeHandling();

        private void LoadData()
        {
            char separator = GetSeparator();
            bool hasHeader = cbHeader.Checked;

            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string filePath = openFileDialog.FileName;
            try
            {
                data = FileProcessor.ReadTransactions(filePath, separator, out int linesCount, hasHeader);

                lRowsCount.Text = linesCount.ToString();
                lTransactionsCount.Text = data.Count.ToString();

                pClusters.Visible = false;
                btnCalculate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Calculate()
        {
            double repulsion = (double)nudRepulsion.Value;

            ClopeProcessor processor = new(data.Values.ToArray());
            distribution = processor.ClusterData(repulsion, ref clusters, out int iterationsCount, out double profit);

            lClustersCount.Text = clusters.Count.ToString();
            lIterationsCount.Text = iterationsCount.ToString();
            lProfitValue.Text = profit.ToString();

            trackBarClusters.Maximum = clusters.Count - 1;
            trackBarClusters.Value = 0;

            ShowCluster(0);
            pClusters.Visible = true;

            btnSave.Enabled = true;
        }

        private char GetSeparator()
        {
            char separator;
            if (rbTab.Checked)
            {
                separator = '\t';
            }
            else if(rbSpace.Checked)
            {
                separator = ' ';
            }
            else if (rbDot.Checked)
            {
                separator = '.';
            }
            else if (rbComma.Checked)
            {
                separator = ',';
            }
            else
            {
                separator = tbSeparator.Text[0];
            }

            return separator;
        }

        private void SeparatorChangeHandling()
        {
            if (rbSeparator.Checked)
            {
                if (string.IsNullOrEmpty(tbSeparator.Text))
                {
                    btnLoadData.Enabled = false;
                    return;
                }
            }

            btnLoadData.Enabled = true;
        }

        private void ShowCluster(int index)
        {
            const string clusterNamePattern = "Кластер #{0}";

            lClusterName.Text = string.Format(clusterNamePattern, index + 1);
            lClusterTransactionsCount.Text = clusters[index].TransactionsCount.ToString();
            lClusterWidthValue.Text = clusters[index].Width.ToString();
            lClusterSizeValue.Text = clusters[index].Size.ToString();

            ShowClusterTransactions(index);
        }

        private void ShowClusterTransactions(int index)
        {
            tVClusterTransactions.Nodes.Clear();

            var items = distribution.Select((n, i) => new { Item = n, index = i }).Where(n => n.Item.Value == index);
            foreach(var item in items)
            {
                var transaction = data.ElementAt(item.index);

                TreeNode node = new TreeNode(transaction.Key.ToString());
                foreach(string obj in transaction.Value)
                {
                    node.Nodes.Add(new TreeNode(obj));
                }

                tVClusterTransactions.Nodes.Add(node);
            }
        }

        private void ClusterChangeHandling()
        {
            int index = trackBarClusters.Value;
            ShowCluster(index);
        }

        private void SaveResult()
        {
            string result = GetDistributionString();

            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string filePath = saveFileDialog.FileName;
            FileProcessor.WriteResult(filePath, result);
        }

        private string GetDistributionString()
        {
            const string clusterNamePattern = "Кластер #{0}";
            const string transactionsCountPattern = "Количество транзакций: {0}";
            const string clusterWidthPattern = "Ширина кластера: {0}";
            const string clusterSizePattern = "Мощность: {0}";

            StringBuilder sb = new();
            for (int i = 0; i < clusters.Count; i++)
            {
                sb.AppendLine(string.Format(clusterNamePattern, i + 1));
                sb.AppendLine(string.Format(transactionsCountPattern, clusters[i].TransactionsCount));
                sb.AppendLine(string.Format(clusterWidthPattern, clusters[i].Width));
                sb.AppendLine(string.Format(clusterSizePattern, clusters[i].Size));
                sb.AppendLine("Входящие транзакции:");
                var items = distribution.Select((n, i) => new { Item = n, index = i }).Where(n => n.Item.Value == i);
                foreach (var item in items)
                {
                    var transaction = data.ElementAt(item.index);
                    sb.AppendLine(transaction.Key.ToString());
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
