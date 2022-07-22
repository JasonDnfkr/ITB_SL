namespace ITB_SL {
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
            if (disposing && (components != null)) {
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
            this.locText = new System.Windows.Forms.Label();
            this.locLabel = new System.Windows.Forms.Label();
            this.locBtn = new System.Windows.Forms.Button();
            this.saveDataListView = new System.Windows.Forms.ListView();
            this.saveDataCol = new System.Windows.Forms.ColumnHeader();
            this.timeCol = new System.Windows.Forms.ColumnHeader();
            this.undoSaveListView = new System.Windows.Forms.ListView();
            this.undoSaveCol = new System.Windows.Forms.ColumnHeader();
            this.timeCol2 = new System.Windows.Forms.ColumnHeader();
            this.saveDataBtn = new System.Windows.Forms.Button();
            this.undoSaveBtn = new System.Windows.Forms.Button();
            this.restoreBtn = new System.Windows.Forms.Button();
            this.restoreAndDelBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.regretBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // locText
            // 
            this.locText.AutoSize = true;
            this.locText.Font = new System.Drawing.Font("苹方 中等", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.locText.Location = new System.Drawing.Point(28, 16);
            this.locText.Name = "locText";
            this.locText.Size = new System.Drawing.Size(135, 33);
            this.locText.TabIndex = 0;
            this.locText.Text = "当前路径：";
            // 
            // locLabel
            // 
            this.locLabel.AutoEllipsis = true;
            this.locLabel.AutoSize = true;
            this.locLabel.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.locLabel.Location = new System.Drawing.Point(144, 16);
            this.locLabel.Name = "locLabel";
            this.locLabel.Size = new System.Drawing.Size(21, 27);
            this.locLabel.TabIndex = 1;
            this.locLabel.Text = "/";
            // 
            // locBtn
            // 
            this.locBtn.Font = new System.Drawing.Font("苹方 中等", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.locBtn.Location = new System.Drawing.Point(28, 63);
            this.locBtn.Name = "locBtn";
            this.locBtn.Size = new System.Drawing.Size(158, 37);
            this.locBtn.TabIndex = 2;
            this.locBtn.Text = "选择路径";
            this.locBtn.UseVisualStyleBackColor = true;
            this.locBtn.Click += new System.EventHandler(this.locBtn_Click);
            // 
            // saveDataListView
            // 
            this.saveDataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.saveDataCol,
            this.timeCol});
            this.saveDataListView.FullRowSelect = true;
            this.saveDataListView.GridLines = true;
            this.saveDataListView.Location = new System.Drawing.Point(28, 119);
            this.saveDataListView.MultiSelect = false;
            this.saveDataListView.Name = "saveDataListView";
            this.saveDataListView.Size = new System.Drawing.Size(424, 499);
            this.saveDataListView.TabIndex = 5;
            this.saveDataListView.UseCompatibleStateImageBehavior = false;
            this.saveDataListView.View = System.Windows.Forms.View.Details;
            this.saveDataListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.saveDataListView_ItemSelectionChanged);
            this.saveDataListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.saveDataListView_MouseDown);
            // 
            // saveDataCol
            // 
            this.saveDataCol.Text = "文件名";
            this.saveDataCol.Width = 200;
            // 
            // timeCol
            // 
            this.timeCol.Text = "时间";
            this.timeCol.Width = 220;
            // 
            // undoSaveListView
            // 
            this.undoSaveListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.undoSaveCol,
            this.timeCol2});
            this.undoSaveListView.FullRowSelect = true;
            this.undoSaveListView.GridLines = true;
            this.undoSaveListView.Location = new System.Drawing.Point(497, 119);
            this.undoSaveListView.MultiSelect = false;
            this.undoSaveListView.Name = "undoSaveListView";
            this.undoSaveListView.Size = new System.Drawing.Size(427, 499);
            this.undoSaveListView.TabIndex = 6;
            this.undoSaveListView.UseCompatibleStateImageBehavior = false;
            this.undoSaveListView.View = System.Windows.Forms.View.Details;
            this.undoSaveListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.undoSaveListView_ItemSelectionChanged);
            this.undoSaveListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.undoSaveListView_MouseClick);
            // 
            // undoSaveCol
            // 
            this.undoSaveCol.Text = "文件名";
            this.undoSaveCol.Width = 200;
            // 
            // timeCol2
            // 
            this.timeCol2.Text = "时间";
            this.timeCol2.Width = 220;
            // 
            // saveDataBtn
            // 
            this.saveDataBtn.Location = new System.Drawing.Point(46, 666);
            this.saveDataBtn.Name = "saveDataBtn";
            this.saveDataBtn.Size = new System.Drawing.Size(125, 66);
            this.saveDataBtn.TabIndex = 7;
            this.saveDataBtn.Text = "备份saveData";
            this.saveDataBtn.UseVisualStyleBackColor = true;
            this.saveDataBtn.Click += new System.EventHandler(this.saveDataBtn_Click);
            // 
            // undoSaveBtn
            // 
            this.undoSaveBtn.Location = new System.Drawing.Point(224, 666);
            this.undoSaveBtn.Name = "undoSaveBtn";
            this.undoSaveBtn.Size = new System.Drawing.Size(125, 66);
            this.undoSaveBtn.TabIndex = 8;
            this.undoSaveBtn.Text = "备份undoSave";
            this.undoSaveBtn.UseVisualStyleBackColor = true;
            this.undoSaveBtn.Click += new System.EventHandler(this.undoSaveBtn_Click);
            // 
            // restoreBtn
            // 
            this.restoreBtn.Location = new System.Drawing.Point(626, 762);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(125, 66);
            this.restoreBtn.TabIndex = 9;
            this.restoreBtn.Text = "从选择还原";
            this.restoreBtn.UseVisualStyleBackColor = true;
            this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
            // 
            // restoreAndDelBtn
            // 
            this.restoreAndDelBtn.Location = new System.Drawing.Point(799, 762);
            this.restoreAndDelBtn.Name = "restoreAndDelBtn";
            this.restoreAndDelBtn.Size = new System.Drawing.Size(125, 66);
            this.restoreAndDelBtn.TabIndex = 10;
            this.restoreAndDelBtn.Text = "还原并删除";
            this.restoreAndDelBtn.UseVisualStyleBackColor = true;
            this.restoreAndDelBtn.Click += new System.EventHandler(this.restoreAndDelBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(46, 762);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(125, 66);
            this.delBtn.TabIndex = 11;
            this.delBtn.Text = "删除";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // regretBtn
            // 
            this.regretBtn.Location = new System.Drawing.Point(799, 666);
            this.regretBtn.Name = "regretBtn";
            this.regretBtn.Size = new System.Drawing.Size(125, 66);
            this.regretBtn.TabIndex = 12;
            this.regretBtn.Text = "悔棋 (undo)";
            this.regretBtn.UseVisualStyleBackColor = true;
            this.regretBtn.Click += new System.EventHandler(this.regretBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 859);
            this.Controls.Add(this.regretBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.restoreAndDelBtn);
            this.Controls.Add(this.restoreBtn);
            this.Controls.Add(this.undoSaveBtn);
            this.Controls.Add(this.saveDataBtn);
            this.Controls.Add(this.undoSaveListView);
            this.Controls.Add(this.saveDataListView);
            this.Controls.Add(this.locBtn);
            this.Controls.Add(this.locLabel);
            this.Controls.Add(this.locText);
            this.Name = "Form1";
            this.Text = "ITB_SL Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label locText;
        private Label locLabel;
        private Button locBtn;
        private ListView saveDataListView;
        private ColumnHeader saveDataCol;
        private ColumnHeader timeCol;
        private ListView undoSaveListView;
        private ColumnHeader undoSaveCol;
        private ColumnHeader timeCol2;
        private Button saveDataBtn;
        private Button undoSaveBtn;
        private Button restoreBtn;
        private Button restoreAndDelBtn;
        private Button delBtn;
        private Button regretBtn;
    }
}