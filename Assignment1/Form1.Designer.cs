namespace Assignment1
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbxScreen = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbxMyObjects = new Assignment1.CustomListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSortAZ = new System.Windows.Forms.Button();
            this.btnShowStatus = new System.Windows.Forms.Button();
            this.btnRemoveSelectedObj = new System.Windows.Forms.Button();
            this.LoadInitialData = new System.Windows.Forms.Button();
            this.btnSortZA = new System.Windows.Forms.Button();
            this.btnSaveCurrentList = new System.Windows.Forms.Button();
            this.btnSearchByType = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoadPreviousSaving = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxScreen)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.pbxScreen, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1150, 643);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pbxScreen
            // 
            this.pbxScreen.BackColor = System.Drawing.Color.LawnGreen;
            this.pbxScreen.BackgroundImage = global::Assignment1.Properties.Resources.green_grass_background_800;
            this.pbxScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxScreen.Image = global::Assignment1.Properties.Resources.green_grass_background_800;
            this.pbxScreen.Location = new System.Drawing.Point(3, 3);
            this.pbxScreen.Name = "pbxScreen";
            this.pbxScreen.Size = new System.Drawing.Size(856, 617);
            this.pbxScreen.TabIndex = 1;
            this.pbxScreen.TabStop = false;
            this.pbxScreen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxScreen_MouseUp);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lbxMyObjects, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(865, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(282, 617);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lbxMyObjects
            // 
            this.lbxMyObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxMyObjects.FormattingEnabled = true;
            this.lbxMyObjects.Location = new System.Drawing.Point(3, 3);
            this.lbxMyObjects.Name = "lbxMyObjects";
            this.lbxMyObjects.Size = new System.Drawing.Size(276, 286);
            this.lbxMyObjects.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel3.Controls.Add(this.btnSortAZ, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnShowStatus, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnRemoveSelectedObj, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.LoadInitialData, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnSortZA, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnSaveCurrentList, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnSearchByType, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnClear, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnLoadPreviousSaving, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 327);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(276, 287);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnSortAZ
            // 
            this.btnSortAZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSortAZ.Location = new System.Drawing.Point(94, 191);
            this.btnSortAZ.Name = "btnSortAZ";
            this.btnSortAZ.Size = new System.Drawing.Size(85, 93);
            this.btnSortAZ.TabIndex = 8;
            this.btnSortAZ.Text = "Sort by Type AZ";
            this.btnSortAZ.UseVisualStyleBackColor = true;
            this.btnSortAZ.Click += new System.EventHandler(this.btnSortAZ_Click);
            // 
            // btnShowStatus
            // 
            this.btnShowStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowStatus.Location = new System.Drawing.Point(3, 3);
            this.btnShowStatus.Name = "btnShowStatus";
            this.btnShowStatus.Size = new System.Drawing.Size(85, 88);
            this.btnShowStatus.TabIndex = 1;
            this.btnShowStatus.Text = "Show Status";
            this.btnShowStatus.UseVisualStyleBackColor = true;
            this.btnShowStatus.Click += new System.EventHandler(this.btnShowStatus_Click);
            // 
            // btnRemoveSelectedObj
            // 
            this.btnRemoveSelectedObj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveSelectedObj.Location = new System.Drawing.Point(94, 3);
            this.btnRemoveSelectedObj.Name = "btnRemoveSelectedObj";
            this.btnRemoveSelectedObj.Size = new System.Drawing.Size(85, 88);
            this.btnRemoveSelectedObj.TabIndex = 2;
            this.btnRemoveSelectedObj.Text = "Remove Selected Object";
            this.btnRemoveSelectedObj.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedObj.Click += new System.EventHandler(this.btnRemoveSelectedObj_Click);
            // 
            // LoadInitialData
            // 
            this.LoadInitialData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadInitialData.Location = new System.Drawing.Point(3, 97);
            this.LoadInitialData.Name = "LoadInitialData";
            this.LoadInitialData.Size = new System.Drawing.Size(85, 88);
            this.LoadInitialData.TabIndex = 4;
            this.LoadInitialData.Text = "Load Initial Data";
            this.LoadInitialData.UseVisualStyleBackColor = true;
            this.LoadInitialData.Click += new System.EventHandler(this.LoadInitialData_Click);
            // 
            // btnSortZA
            // 
            this.btnSortZA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSortZA.Location = new System.Drawing.Point(94, 97);
            this.btnSortZA.Name = "btnSortZA";
            this.btnSortZA.Size = new System.Drawing.Size(85, 88);
            this.btnSortZA.TabIndex = 5;
            this.btnSortZA.Text = "Sort by Type ZA";
            this.btnSortZA.UseVisualStyleBackColor = true;
            this.btnSortZA.Click += new System.EventHandler(this.btnSortZA_Click);
            // 
            // btnSaveCurrentList
            // 
            this.btnSaveCurrentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveCurrentList.Location = new System.Drawing.Point(185, 97);
            this.btnSaveCurrentList.Name = "btnSaveCurrentList";
            this.btnSaveCurrentList.Size = new System.Drawing.Size(88, 88);
            this.btnSaveCurrentList.TabIndex = 6;
            this.btnSaveCurrentList.Text = "Save Current List";
            this.btnSaveCurrentList.UseVisualStyleBackColor = true;
            this.btnSaveCurrentList.Click += new System.EventHandler(this.btnSaveCurrentList_Click);
            // 
            // btnSearchByType
            // 
            this.btnSearchByType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchByType.Location = new System.Drawing.Point(185, 3);
            this.btnSearchByType.Name = "btnSearchByType";
            this.btnSearchByType.Size = new System.Drawing.Size(88, 88);
            this.btnSearchByType.TabIndex = 3;
            this.btnSearchByType.Text = "Search by Type";
            this.btnSearchByType.UseVisualStyleBackColor = true;
            this.btnSearchByType.Click += new System.EventHandler(this.btnSearchByType_Click);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Location = new System.Drawing.Point(185, 191);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 93);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLoadPreviousSaving
            // 
            this.btnLoadPreviousSaving.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadPreviousSaving.Location = new System.Drawing.Point(3, 191);
            this.btnLoadPreviousSaving.Name = "btnLoadPreviousSaving";
            this.btnLoadPreviousSaving.Size = new System.Drawing.Size(85, 93);
            this.btnLoadPreviousSaving.TabIndex = 7;
            this.btnLoadPreviousSaving.Text = "Load Previous Saving";
            this.btnLoadPreviousSaving.UseVisualStyleBackColor = true;
            this.btnLoadPreviousSaving.Click += new System.EventHandler(this.btnLoadPreviousSaving_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.Controls.Add(this.tbxSearch, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblSearch, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 295);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(276, 26);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxSearch.Location = new System.Drawing.Point(168, 3);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(105, 20);
            this.tbxSearch.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSearch.Location = new System.Drawing.Point(3, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(159, 26);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Enter Sheep Type for Search:";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 619);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1150, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(250, 19);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(550, 19);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSearchByType;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 643);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Click Me";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxScreen)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pbxScreen;
        //private System.Windows.Forms.ListBox lbxMyObjects;
        private CustomListBox lbxMyObjects;//Custom control with autoscroll added
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSortAZ;
        private System.Windows.Forms.Button btnLoadPreviousSaving;
        private System.Windows.Forms.Button btnShowStatus;
        private System.Windows.Forms.Button btnRemoveSelectedObj;
        private System.Windows.Forms.Button btnSearchByType;
        private System.Windows.Forms.Button LoadInitialData;
        private System.Windows.Forms.Button btnSortZA;
        private System.Windows.Forms.Button btnSaveCurrentList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timer1;
    }
}

