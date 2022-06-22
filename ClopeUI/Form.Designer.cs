
namespace ClusteringUI
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pMenu = new System.Windows.Forms.Panel();
            this.pSaveResult = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.pSeparator3 = new System.Windows.Forms.Panel();
            this.pCalculation = new System.Windows.Forms.Panel();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.gbRepulsion = new System.Windows.Forms.GroupBox();
            this.nudRepulsion = new System.Windows.Forms.NumericUpDown();
            this.pSeparator2 = new System.Windows.Forms.Panel();
            this.pLoadData = new System.Windows.Forms.Panel();
            this.cbHeader = new System.Windows.Forms.CheckBox();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.gbLoadData = new System.Windows.Forms.GroupBox();
            this.tbSeparator = new System.Windows.Forms.TextBox();
            this.rbSeparator = new System.Windows.Forms.RadioButton();
            this.rbSpace = new System.Windows.Forms.RadioButton();
            this.rbComma = new System.Windows.Forms.RadioButton();
            this.rbDot = new System.Windows.Forms.RadioButton();
            this.rbTab = new System.Windows.Forms.RadioButton();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pResult = new System.Windows.Forms.Panel();
            this.pClusters = new System.Windows.Forms.Panel();
            this.gbClusters = new System.Windows.Forms.GroupBox();
            this.pClustersData = new System.Windows.Forms.Panel();
            this.tlpClusterData = new System.Windows.Forms.TableLayoutPanel();
            this.pClusterData = new System.Windows.Forms.Panel();
            this.lClusterSizeValue = new System.Windows.Forms.Label();
            this.lClusterWidthValue = new System.Windows.Forms.Label();
            this.lClusterTransactionsCount = new System.Windows.Forms.Label();
            this.lClusterSize = new System.Windows.Forms.Label();
            this.lClusterWidth = new System.Windows.Forms.Label();
            this.lClusterTransactions = new System.Windows.Forms.Label();
            this.lClusterName = new System.Windows.Forms.Label();
            this.pClusterTransactions = new System.Windows.Forms.Panel();
            this.tVClusterTransactions = new System.Windows.Forms.TreeView();
            this.trackBarClusters = new System.Windows.Forms.TrackBar();
            this.pCalculateData = new System.Windows.Forms.Panel();
            this.lProfitValue = new System.Windows.Forms.Label();
            this.lProfit = new System.Windows.Forms.Label();
            this.lIterationsCount = new System.Windows.Forms.Label();
            this.lClustersCount = new System.Windows.Forms.Label();
            this.lIterations = new System.Windows.Forms.Label();
            this.lClusters = new System.Windows.Forms.Label();
            this.pData = new System.Windows.Forms.Panel();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.lRowsCount = new System.Windows.Forms.Label();
            this.lTransactionsCount = new System.Windows.Forms.Label();
            this.ltransactions = new System.Windows.Forms.Label();
            this.lRows = new System.Windows.Forms.Label();
            this.pSeparator1 = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pMenu.SuspendLayout();
            this.pSaveResult.SuspendLayout();
            this.pCalculation.SuspendLayout();
            this.gbRepulsion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepulsion)).BeginInit();
            this.pLoadData.SuspendLayout();
            this.gbLoadData.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.pResult.SuspendLayout();
            this.pClusters.SuspendLayout();
            this.gbClusters.SuspendLayout();
            this.pClustersData.SuspendLayout();
            this.tlpClusterData.SuspendLayout();
            this.pClusterData.SuspendLayout();
            this.pClusterTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarClusters)).BeginInit();
            this.pCalculateData.SuspendLayout();
            this.pData.SuspendLayout();
            this.gbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.SystemColors.Control;
            this.pMenu.Controls.Add(this.pSaveResult);
            this.pMenu.Controls.Add(this.pSeparator3);
            this.pMenu.Controls.Add(this.pCalculation);
            this.pMenu.Controls.Add(this.pSeparator2);
            this.pMenu.Controls.Add(this.pLoadData);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(200, 455);
            this.pMenu.TabIndex = 0;
            // 
            // pSaveResult
            // 
            this.pSaveResult.BackColor = System.Drawing.SystemColors.Control;
            this.pSaveResult.Controls.Add(this.btnSave);
            this.pSaveResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSaveResult.Location = new System.Drawing.Point(0, 277);
            this.pSaveResult.Name = "pSaveResult";
            this.pSaveResult.Size = new System.Drawing.Size(200, 178);
            this.pSaveResult.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGray;
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(5, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(190, 25);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить распределение";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pSeparator3
            // 
            this.pSeparator3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pSeparator3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSeparator3.Location = new System.Drawing.Point(0, 272);
            this.pSeparator3.Name = "pSeparator3";
            this.pSeparator3.Size = new System.Drawing.Size(200, 5);
            this.pSeparator3.TabIndex = 5;
            // 
            // pCalculation
            // 
            this.pCalculation.BackColor = System.Drawing.SystemColors.Control;
            this.pCalculation.Controls.Add(this.btnCalculate);
            this.pCalculation.Controls.Add(this.gbRepulsion);
            this.pCalculation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCalculation.Location = new System.Drawing.Point(0, 175);
            this.pCalculation.Margin = new System.Windows.Forms.Padding(0);
            this.pCalculation.Name = "pCalculation";
            this.pCalculation.Padding = new System.Windows.Forms.Padding(5);
            this.pCalculation.Size = new System.Drawing.Size(200, 97);
            this.pCalculation.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.LightGray;
            this.btnCalculate.Enabled = false;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Location = new System.Drawing.Point(5, 62);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(190, 25);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Выполнить кластеризацию";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // gbRepulsion
            // 
            this.gbRepulsion.Controls.Add(this.nudRepulsion);
            this.gbRepulsion.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbRepulsion.Location = new System.Drawing.Point(5, 5);
            this.gbRepulsion.Name = "gbRepulsion";
            this.gbRepulsion.Size = new System.Drawing.Size(190, 51);
            this.gbRepulsion.TabIndex = 0;
            this.gbRepulsion.TabStop = false;
            this.gbRepulsion.Text = "Коэффициент отталкивания:";
            // 
            // nudRepulsion
            // 
            this.nudRepulsion.DecimalPlaces = 1;
            this.nudRepulsion.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudRepulsion.Location = new System.Drawing.Point(6, 22);
            this.nudRepulsion.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            65536});
            this.nudRepulsion.Name = "nudRepulsion";
            this.nudRepulsion.Size = new System.Drawing.Size(40, 23);
            this.nudRepulsion.TabIndex = 0;
            this.nudRepulsion.Value = new decimal(new int[] {
            26,
            0,
            0,
            65536});
            // 
            // pSeparator2
            // 
            this.pSeparator2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pSeparator2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSeparator2.Location = new System.Drawing.Point(0, 170);
            this.pSeparator2.Name = "pSeparator2";
            this.pSeparator2.Size = new System.Drawing.Size(200, 5);
            this.pSeparator2.TabIndex = 3;
            // 
            // pLoadData
            // 
            this.pLoadData.Controls.Add(this.cbHeader);
            this.pLoadData.Controls.Add(this.btnLoadData);
            this.pLoadData.Controls.Add(this.gbLoadData);
            this.pLoadData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLoadData.Location = new System.Drawing.Point(0, 0);
            this.pLoadData.Margin = new System.Windows.Forms.Padding(0);
            this.pLoadData.Name = "pLoadData";
            this.pLoadData.Padding = new System.Windows.Forms.Padding(5);
            this.pLoadData.Size = new System.Drawing.Size(200, 170);
            this.pLoadData.TabIndex = 2;
            // 
            // cbHeader
            // 
            this.cbHeader.AutoSize = true;
            this.cbHeader.Checked = true;
            this.cbHeader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHeader.Location = new System.Drawing.Point(11, 111);
            this.cbHeader.Name = "cbHeader";
            this.cbHeader.Size = new System.Drawing.Size(173, 19);
            this.cbHeader.TabIndex = 4;
            this.cbHeader.Text = "Первая строка - заголовок";
            this.cbHeader.UseVisualStyleBackColor = true;
            // 
            // btnLoadData
            // 
            this.btnLoadData.BackColor = System.Drawing.Color.LightGray;
            this.btnLoadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadData.Location = new System.Drawing.Point(5, 136);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(190, 25);
            this.btnLoadData.TabIndex = 3;
            this.btnLoadData.Text = "Загрузить транзакции";
            this.btnLoadData.UseVisualStyleBackColor = false;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // gbLoadData
            // 
            this.gbLoadData.Controls.Add(this.tbSeparator);
            this.gbLoadData.Controls.Add(this.rbSeparator);
            this.gbLoadData.Controls.Add(this.rbSpace);
            this.gbLoadData.Controls.Add(this.rbComma);
            this.gbLoadData.Controls.Add(this.rbDot);
            this.gbLoadData.Controls.Add(this.rbTab);
            this.gbLoadData.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbLoadData.Location = new System.Drawing.Point(5, 5);
            this.gbLoadData.Name = "gbLoadData";
            this.gbLoadData.Size = new System.Drawing.Size(190, 100);
            this.gbLoadData.TabIndex = 2;
            this.gbLoadData.TabStop = false;
            this.gbLoadData.Text = "Символ-разделитель:";
            // 
            // tbSeparator
            // 
            this.tbSeparator.Location = new System.Drawing.Point(77, 71);
            this.tbSeparator.MaxLength = 1;
            this.tbSeparator.Name = "tbSeparator";
            this.tbSeparator.Size = new System.Drawing.Size(27, 23);
            this.tbSeparator.TabIndex = 13;
            this.tbSeparator.TextChanged += new System.EventHandler(this.tbSeparator_TextChanged);
            // 
            // rbSeparator
            // 
            this.rbSeparator.AutoSize = true;
            this.rbSeparator.Location = new System.Drawing.Point(6, 72);
            this.rbSeparator.Name = "rbSeparator";
            this.rbSeparator.Size = new System.Drawing.Size(65, 19);
            this.rbSeparator.TabIndex = 12;
            this.rbSeparator.TabStop = true;
            this.rbSeparator.Text = "Другой";
            this.rbSeparator.UseVisualStyleBackColor = true;
            this.rbSeparator.CheckedChanged += new System.EventHandler(this.rbSeparator_CheckedChanged);
            // 
            // rbSpace
            // 
            this.rbSpace.AutoSize = true;
            this.rbSpace.Location = new System.Drawing.Point(95, 22);
            this.rbSpace.Name = "rbSpace";
            this.rbSpace.Size = new System.Drawing.Size(68, 19);
            this.rbSpace.TabIndex = 11;
            this.rbSpace.TabStop = true;
            this.rbSpace.Text = "Пробел";
            this.rbSpace.UseVisualStyleBackColor = true;
            // 
            // rbComma
            // 
            this.rbComma.AutoSize = true;
            this.rbComma.Location = new System.Drawing.Point(95, 47);
            this.rbComma.Name = "rbComma";
            this.rbComma.Size = new System.Drawing.Size(68, 19);
            this.rbComma.TabIndex = 10;
            this.rbComma.TabStop = true;
            this.rbComma.Text = "Запятая";
            this.rbComma.UseVisualStyleBackColor = true;
            // 
            // rbDot
            // 
            this.rbDot.AutoSize = true;
            this.rbDot.Location = new System.Drawing.Point(6, 47);
            this.rbDot.Name = "rbDot";
            this.rbDot.Size = new System.Drawing.Size(57, 19);
            this.rbDot.TabIndex = 9;
            this.rbDot.TabStop = true;
            this.rbDot.Text = "Точка";
            this.rbDot.UseVisualStyleBackColor = true;
            // 
            // rbTab
            // 
            this.rbTab.AutoSize = true;
            this.rbTab.Checked = true;
            this.rbTab.Location = new System.Drawing.Point(6, 22);
            this.rbTab.Name = "rbTab";
            this.rbTab.Size = new System.Drawing.Size(83, 19);
            this.rbTab.TabIndex = 8;
            this.rbTab.TabStop = true;
            this.rbTab.Text = "Табуляция";
            this.rbTab.UseVisualStyleBackColor = true;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pResult, 2, 0);
            this.tlpMain.Controls.Add(this.pMenu, 0, 0);
            this.tlpMain.Controls.Add(this.pSeparator1, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(3, 3);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(778, 455);
            this.tlpMain.TabIndex = 0;
            // 
            // pResult
            // 
            this.pResult.BackColor = System.Drawing.SystemColors.Control;
            this.pResult.Controls.Add(this.pClusters);
            this.pResult.Controls.Add(this.pData);
            this.pResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pResult.Location = new System.Drawing.Point(205, 0);
            this.pResult.Margin = new System.Windows.Forms.Padding(0);
            this.pResult.Name = "pResult";
            this.pResult.Size = new System.Drawing.Size(573, 455);
            this.pResult.TabIndex = 2;
            // 
            // pClusters
            // 
            this.pClusters.Controls.Add(this.gbClusters);
            this.pClusters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pClusters.Location = new System.Drawing.Point(0, 90);
            this.pClusters.Margin = new System.Windows.Forms.Padding(0);
            this.pClusters.Name = "pClusters";
            this.pClusters.Padding = new System.Windows.Forms.Padding(5);
            this.pClusters.Size = new System.Drawing.Size(573, 365);
            this.pClusters.TabIndex = 1;
            this.pClusters.Visible = false;
            // 
            // gbClusters
            // 
            this.gbClusters.Controls.Add(this.pClustersData);
            this.gbClusters.Controls.Add(this.trackBarClusters);
            this.gbClusters.Controls.Add(this.pCalculateData);
            this.gbClusters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbClusters.Location = new System.Drawing.Point(5, 5);
            this.gbClusters.Name = "gbClusters";
            this.gbClusters.Size = new System.Drawing.Size(563, 355);
            this.gbClusters.TabIndex = 0;
            this.gbClusters.TabStop = false;
            this.gbClusters.Text = "Распределение транзакций";
            // 
            // pClustersData
            // 
            this.pClustersData.Controls.Add(this.tlpClusterData);
            this.pClustersData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pClustersData.Location = new System.Drawing.Point(3, 144);
            this.pClustersData.Margin = new System.Windows.Forms.Padding(0);
            this.pClustersData.Name = "pClustersData";
            this.pClustersData.Size = new System.Drawing.Size(557, 208);
            this.pClustersData.TabIndex = 3;
            // 
            // tlpClusterData
            // 
            this.tlpClusterData.ColumnCount = 1;
            this.tlpClusterData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpClusterData.Controls.Add(this.pClusterData, 0, 0);
            this.tlpClusterData.Controls.Add(this.pClusterTransactions, 0, 1);
            this.tlpClusterData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpClusterData.Location = new System.Drawing.Point(0, 0);
            this.tlpClusterData.Margin = new System.Windows.Forms.Padding(0);
            this.tlpClusterData.Name = "tlpClusterData";
            this.tlpClusterData.RowCount = 2;
            this.tlpClusterData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpClusterData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpClusterData.Size = new System.Drawing.Size(557, 208);
            this.tlpClusterData.TabIndex = 0;
            // 
            // pClusterData
            // 
            this.pClusterData.Controls.Add(this.lClusterSizeValue);
            this.pClusterData.Controls.Add(this.lClusterWidthValue);
            this.pClusterData.Controls.Add(this.lClusterTransactionsCount);
            this.pClusterData.Controls.Add(this.lClusterSize);
            this.pClusterData.Controls.Add(this.lClusterWidth);
            this.pClusterData.Controls.Add(this.lClusterTransactions);
            this.pClusterData.Controls.Add(this.lClusterName);
            this.pClusterData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pClusterData.Location = new System.Drawing.Point(0, 0);
            this.pClusterData.Margin = new System.Windows.Forms.Padding(0);
            this.pClusterData.Name = "pClusterData";
            this.pClusterData.Size = new System.Drawing.Size(557, 100);
            this.pClusterData.TabIndex = 0;
            // 
            // lClusterSizeValue
            // 
            this.lClusterSizeValue.AutoSize = true;
            this.lClusterSizeValue.Location = new System.Drawing.Point(82, 70);
            this.lClusterSizeValue.Name = "lClusterSizeValue";
            this.lClusterSizeValue.Size = new System.Drawing.Size(13, 15);
            this.lClusterSizeValue.TabIndex = 6;
            this.lClusterSizeValue.Text = "0";
            // 
            // lClusterWidthValue
            // 
            this.lClusterWidthValue.AutoSize = true;
            this.lClusterWidthValue.Location = new System.Drawing.Point(119, 51);
            this.lClusterWidthValue.Name = "lClusterWidthValue";
            this.lClusterWidthValue.Size = new System.Drawing.Size(13, 15);
            this.lClusterWidthValue.TabIndex = 5;
            this.lClusterWidthValue.Text = "0";
            // 
            // lClusterTransactionsCount
            // 
            this.lClusterTransactionsCount.AutoSize = true;
            this.lClusterTransactionsCount.Location = new System.Drawing.Point(153, 30);
            this.lClusterTransactionsCount.Name = "lClusterTransactionsCount";
            this.lClusterTransactionsCount.Size = new System.Drawing.Size(13, 15);
            this.lClusterTransactionsCount.TabIndex = 4;
            this.lClusterTransactionsCount.Text = "0";
            // 
            // lClusterSize
            // 
            this.lClusterSize.AutoSize = true;
            this.lClusterSize.Location = new System.Drawing.Point(6, 70);
            this.lClusterSize.Name = "lClusterSize";
            this.lClusterSize.Size = new System.Drawing.Size(70, 15);
            this.lClusterSize.TabIndex = 3;
            this.lClusterSize.Text = "Мощность:";
            // 
            // lClusterWidth
            // 
            this.lClusterWidth.AutoSize = true;
            this.lClusterWidth.Location = new System.Drawing.Point(6, 50);
            this.lClusterWidth.Name = "lClusterWidth";
            this.lClusterWidth.Size = new System.Drawing.Size(107, 15);
            this.lClusterWidth.TabIndex = 2;
            this.lClusterWidth.Text = "Ширина кластера:";
            // 
            // lClusterTransactions
            // 
            this.lClusterTransactions.AutoSize = true;
            this.lClusterTransactions.Location = new System.Drawing.Point(6, 30);
            this.lClusterTransactions.Name = "lClusterTransactions";
            this.lClusterTransactions.Size = new System.Drawing.Size(141, 15);
            this.lClusterTransactions.TabIndex = 1;
            this.lClusterTransactions.Text = "Количество транзакций:";
            // 
            // lClusterName
            // 
            this.lClusterName.AutoSize = true;
            this.lClusterName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lClusterName.Location = new System.Drawing.Point(6, 6);
            this.lClusterName.Name = "lClusterName";
            this.lClusterName.Size = new System.Drawing.Size(71, 20);
            this.lClusterName.TabIndex = 0;
            this.lClusterName.Text = "Cluster #";
            // 
            // pClusterTransactions
            // 
            this.pClusterTransactions.AutoScroll = true;
            this.pClusterTransactions.Controls.Add(this.tVClusterTransactions);
            this.pClusterTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pClusterTransactions.Location = new System.Drawing.Point(0, 100);
            this.pClusterTransactions.Margin = new System.Windows.Forms.Padding(0);
            this.pClusterTransactions.Name = "pClusterTransactions";
            this.pClusterTransactions.Size = new System.Drawing.Size(557, 108);
            this.pClusterTransactions.TabIndex = 1;
            // 
            // tVClusterTransactions
            // 
            this.tVClusterTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tVClusterTransactions.Location = new System.Drawing.Point(0, 0);
            this.tVClusterTransactions.Name = "tVClusterTransactions";
            this.tVClusterTransactions.Size = new System.Drawing.Size(557, 108);
            this.tVClusterTransactions.TabIndex = 0;
            // 
            // trackBarClusters
            // 
            this.trackBarClusters.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBarClusters.Location = new System.Drawing.Point(3, 99);
            this.trackBarClusters.Maximum = 100;
            this.trackBarClusters.Name = "trackBarClusters";
            this.trackBarClusters.Size = new System.Drawing.Size(557, 45);
            this.trackBarClusters.TabIndex = 2;
            this.trackBarClusters.TabStop = false;
            this.trackBarClusters.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarClusters.Scroll += new System.EventHandler(this.trackBarClusters_Scroll);
            // 
            // pCalculateData
            // 
            this.pCalculateData.Controls.Add(this.lProfitValue);
            this.pCalculateData.Controls.Add(this.lProfit);
            this.pCalculateData.Controls.Add(this.lIterationsCount);
            this.pCalculateData.Controls.Add(this.lClustersCount);
            this.pCalculateData.Controls.Add(this.lIterations);
            this.pCalculateData.Controls.Add(this.lClusters);
            this.pCalculateData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCalculateData.Location = new System.Drawing.Point(3, 19);
            this.pCalculateData.Margin = new System.Windows.Forms.Padding(0);
            this.pCalculateData.Name = "pCalculateData";
            this.pCalculateData.Size = new System.Drawing.Size(557, 80);
            this.pCalculateData.TabIndex = 0;
            // 
            // lProfitValue
            // 
            this.lProfitValue.AutoSize = true;
            this.lProfitValue.Location = new System.Drawing.Point(176, 50);
            this.lProfitValue.Name = "lProfitValue";
            this.lProfitValue.Size = new System.Drawing.Size(13, 15);
            this.lProfitValue.TabIndex = 7;
            this.lProfitValue.Text = "0";
            // 
            // lProfit
            // 
            this.lProfit.AutoSize = true;
            this.lProfit.Location = new System.Drawing.Point(6, 50);
            this.lProfit.Name = "lProfit";
            this.lProfit.Size = new System.Drawing.Size(164, 15);
            this.lProfit.TabIndex = 6;
            this.lProfit.Text = "Значение целевой функции:";
            // 
            // lIterationsCount
            // 
            this.lIterationsCount.AutoSize = true;
            this.lIterationsCount.Location = new System.Drawing.Point(142, 30);
            this.lIterationsCount.Name = "lIterationsCount";
            this.lIterationsCount.Size = new System.Drawing.Size(13, 15);
            this.lIterationsCount.TabIndex = 5;
            this.lIterationsCount.Text = "0";
            // 
            // lClustersCount
            // 
            this.lClustersCount.AutoSize = true;
            this.lClustersCount.Location = new System.Drawing.Point(146, 10);
            this.lClustersCount.Name = "lClustersCount";
            this.lClustersCount.Size = new System.Drawing.Size(13, 15);
            this.lClustersCount.TabIndex = 4;
            this.lClustersCount.Text = "0";
            // 
            // lIterations
            // 
            this.lIterations.AutoSize = true;
            this.lIterations.Location = new System.Drawing.Point(6, 30);
            this.lIterations.Name = "lIterations";
            this.lIterations.Size = new System.Drawing.Size(130, 15);
            this.lIterations.TabIndex = 3;
            this.lIterations.Text = "Количество итераций:";
            // 
            // lClusters
            // 
            this.lClusters.AutoSize = true;
            this.lClusters.Location = new System.Drawing.Point(6, 10);
            this.lClusters.Name = "lClusters";
            this.lClusters.Size = new System.Drawing.Size(134, 15);
            this.lClusters.TabIndex = 2;
            this.lClusters.Text = "Количество кластеров:";
            // 
            // pData
            // 
            this.pData.Controls.Add(this.gbData);
            this.pData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pData.Location = new System.Drawing.Point(0, 0);
            this.pData.Margin = new System.Windows.Forms.Padding(0);
            this.pData.Name = "pData";
            this.pData.Padding = new System.Windows.Forms.Padding(5);
            this.pData.Size = new System.Drawing.Size(573, 90);
            this.pData.TabIndex = 0;
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.lRowsCount);
            this.gbData.Controls.Add(this.lTransactionsCount);
            this.gbData.Controls.Add(this.ltransactions);
            this.gbData.Controls.Add(this.lRows);
            this.gbData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbData.Location = new System.Drawing.Point(5, 5);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(563, 80);
            this.gbData.TabIndex = 0;
            this.gbData.TabStop = false;
            this.gbData.Text = "Данные";
            // 
            // lRowsCount
            // 
            this.lRowsCount.AutoSize = true;
            this.lRowsCount.Location = new System.Drawing.Point(121, 24);
            this.lRowsCount.Name = "lRowsCount";
            this.lRowsCount.Size = new System.Drawing.Size(13, 15);
            this.lRowsCount.TabIndex = 3;
            this.lRowsCount.Text = "0";
            // 
            // lTransactionsCount
            // 
            this.lTransactionsCount.AutoSize = true;
            this.lTransactionsCount.Location = new System.Drawing.Point(153, 49);
            this.lTransactionsCount.Name = "lTransactionsCount";
            this.lTransactionsCount.Size = new System.Drawing.Size(13, 15);
            this.lTransactionsCount.TabIndex = 2;
            this.lTransactionsCount.Text = "0";
            // 
            // ltransactions
            // 
            this.ltransactions.AutoSize = true;
            this.ltransactions.Location = new System.Drawing.Point(6, 49);
            this.ltransactions.Name = "ltransactions";
            this.ltransactions.Size = new System.Drawing.Size(141, 15);
            this.ltransactions.TabIndex = 1;
            this.ltransactions.Text = "Количество транзакций:";
            // 
            // lRows
            // 
            this.lRows.AutoSize = true;
            this.lRows.Location = new System.Drawing.Point(6, 24);
            this.lRows.Name = "lRows";
            this.lRows.Size = new System.Drawing.Size(109, 15);
            this.lRows.TabIndex = 0;
            this.lRows.Text = "Количество строк:";
            // 
            // pSeparator1
            // 
            this.pSeparator1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pSeparator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSeparator1.Location = new System.Drawing.Point(200, 0);
            this.pSeparator1.Margin = new System.Windows.Forms.Padding(0);
            this.pSeparator1.Name = "pSeparator1";
            this.pSeparator1.Size = new System.Drawing.Size(5, 455);
            this.pSeparator1.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tlpMain);
            this.Name = "Form";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLOPE";
            this.pMenu.ResumeLayout(false);
            this.pSaveResult.ResumeLayout(false);
            this.pCalculation.ResumeLayout(false);
            this.gbRepulsion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudRepulsion)).EndInit();
            this.pLoadData.ResumeLayout(false);
            this.pLoadData.PerformLayout();
            this.gbLoadData.ResumeLayout(false);
            this.gbLoadData.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.pResult.ResumeLayout(false);
            this.pClusters.ResumeLayout(false);
            this.gbClusters.ResumeLayout(false);
            this.gbClusters.PerformLayout();
            this.pClustersData.ResumeLayout(false);
            this.tlpClusterData.ResumeLayout(false);
            this.pClusterData.ResumeLayout(false);
            this.pClusterData.PerformLayout();
            this.pClusterTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarClusters)).EndInit();
            this.pCalculateData.ResumeLayout(false);
            this.pCalculateData.PerformLayout();
            this.pData.ResumeLayout(false);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel pLoadData;
        private System.Windows.Forms.GroupBox gbLoadData;
        private System.Windows.Forms.TextBox tbSeparator;
        private System.Windows.Forms.RadioButton rbSeparator;
        private System.Windows.Forms.RadioButton rbSpace;
        private System.Windows.Forms.RadioButton rbComma;
        private System.Windows.Forms.RadioButton rbDot;
        private System.Windows.Forms.RadioButton rbTab;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel pResult;
        private System.Windows.Forms.Panel pSeparator1;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Panel pSeparator2;
        private System.Windows.Forms.Panel pCalculation;
        private System.Windows.Forms.Panel pSeparator3;
        private System.Windows.Forms.Panel pSaveResult;
        private System.Windows.Forms.GroupBox gbRepulsion;
        private System.Windows.Forms.NumericUpDown nudRepulsion;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox cbHeader;
        private System.Windows.Forms.Panel pData;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Label lRows;
        private System.Windows.Forms.Label ltransactions;
        private System.Windows.Forms.Label lRowsCount;
        private System.Windows.Forms.Label lTransactionsCount;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel pClusters;
        private System.Windows.Forms.GroupBox gbClusters;
        private System.Windows.Forms.Panel pClustersData;
        private System.Windows.Forms.TableLayoutPanel tlpClusterData;
        private System.Windows.Forms.Panel pClusterData;
        private System.Windows.Forms.Label lClusterSizeValue;
        private System.Windows.Forms.Label lClusterWidthValue;
        private System.Windows.Forms.Label lClusterTransactionsCount;
        private System.Windows.Forms.Label lClusterSize;
        private System.Windows.Forms.Label lClusterWidth;
        private System.Windows.Forms.Label lClusterTransactions;
        private System.Windows.Forms.Label lClusterName;
        private System.Windows.Forms.Panel pClusterTransactions;
        private System.Windows.Forms.TreeView tVClusterTransactions;
        private System.Windows.Forms.TrackBar trackBarClusters;
        private System.Windows.Forms.Panel pCalculateData;
        private System.Windows.Forms.Label lIterations;
        private System.Windows.Forms.Label lClusters;
        private System.Windows.Forms.Label lIterationsCount;
        private System.Windows.Forms.Label lClustersCount;
        private System.Windows.Forms.Label lProfitValue;
        private System.Windows.Forms.Label lProfit;
    }
}

