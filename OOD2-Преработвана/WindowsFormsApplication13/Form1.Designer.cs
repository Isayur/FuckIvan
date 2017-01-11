namespace WindowsFormsApplication13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbPump = new System.Windows.Forms.PictureBox();
            this.pbSink = new System.Windows.Forms.PictureBox();
            this.pbAdjustableSpliter = new System.Windows.Forms.PictureBox();
            this.pbSpliter = new System.Windows.Forms.PictureBox();
            this.pbMerger = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pbPipe = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaxFlow = new System.Windows.Forms.TextBox();
            this.tbCurrentFlow = new System.Windows.Forms.TextBox();
            this.toolBox = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCompPrc = new System.Windows.Forms.Label();
            this.lbPrc = new System.Windows.Forms.Label();
            this.btSet = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.workPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbPump)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdjustableSpliter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpliter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMerger)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe)).BeginInit();
            this.toolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.workPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem1.Text = "Save As";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.OpenToolStripMenuItem.Text = "Open";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.saveAsToolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            // 
            // pbPump
            // 
            this.pbPump.ErrorImage = null;
            this.pbPump.Image = ((System.Drawing.Image)(resources.GetObject("pbPump.Image")));
            this.pbPump.Location = new System.Drawing.Point(39, 17);
            this.pbPump.Name = "pbPump";
            this.pbPump.Size = new System.Drawing.Size(55, 38);
            this.pbPump.TabIndex = 0;
            this.pbPump.TabStop = false;
            // 
            // pbSink
            // 
            this.pbSink.Image = ((System.Drawing.Image)(resources.GetObject("pbSink.Image")));
            this.pbSink.Location = new System.Drawing.Point(39, 83);
            this.pbSink.Name = "pbSink";
            this.pbSink.Size = new System.Drawing.Size(58, 43);
            this.pbSink.TabIndex = 1;
            this.pbSink.TabStop = false;
            // 
            // pbAdjustableSpliter
            // 
            this.pbAdjustableSpliter.Image = ((System.Drawing.Image)(resources.GetObject("pbAdjustableSpliter.Image")));
            this.pbAdjustableSpliter.Location = new System.Drawing.Point(39, 150);
            this.pbAdjustableSpliter.Name = "pbAdjustableSpliter";
            this.pbAdjustableSpliter.Size = new System.Drawing.Size(55, 41);
            this.pbAdjustableSpliter.TabIndex = 2;
            this.pbAdjustableSpliter.TabStop = false;
            // 
            // pbSpliter
            // 
            this.pbSpliter.Image = ((System.Drawing.Image)(resources.GetObject("pbSpliter.Image")));
            this.pbSpliter.Location = new System.Drawing.Point(39, 216);
            this.pbSpliter.Name = "pbSpliter";
            this.pbSpliter.Size = new System.Drawing.Size(58, 39);
            this.pbSpliter.TabIndex = 3;
            this.pbSpliter.TabStop = false;
            // 
            // pbMerger
            // 
            this.pbMerger.Image = ((System.Drawing.Image)(resources.GetObject("pbMerger.Image")));
            this.pbMerger.Location = new System.Drawing.Point(39, 278);
            this.pbMerger.Name = "pbMerger";
            this.pbMerger.Size = new System.Drawing.Size(55, 40);
            this.pbMerger.TabIndex = 4;
            this.pbMerger.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1153, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pbPipe
            // 
            this.pbPipe.Image = ((System.Drawing.Image)(resources.GetObject("pbPipe.Image")));
            this.pbPipe.Location = new System.Drawing.Point(39, 340);
            this.pbPipe.Name = "pbPipe";
            this.pbPipe.Size = new System.Drawing.Size(55, 42);
            this.pbPipe.TabIndex = 5;
            this.pbPipe.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Flow";
            // 
            // tbMaxFlow
            // 
            this.tbMaxFlow.Location = new System.Drawing.Point(90, 447);
            this.tbMaxFlow.Name = "tbMaxFlow";
            this.tbMaxFlow.Size = new System.Drawing.Size(53, 20);
            this.tbMaxFlow.TabIndex = 1;
            // 
            // tbCurrentFlow
            // 
            this.tbCurrentFlow.Location = new System.Drawing.Point(90, 421);
            this.tbCurrentFlow.Name = "tbCurrentFlow";
            this.tbCurrentFlow.Size = new System.Drawing.Size(53, 20);
            this.tbCurrentFlow.TabIndex = 0;
            // 
            // toolBox
            // 
            this.toolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolBox.Controls.Add(this.pbPump);
            this.toolBox.Controls.Add(this.pbSink);
            this.toolBox.Controls.Add(this.pbAdjustableSpliter);
            this.toolBox.Controls.Add(this.pbSpliter);
            this.toolBox.Controls.Add(this.pbMerger);
            this.toolBox.Controls.Add(this.pbPipe);
            this.toolBox.Controls.Add(this.label2);
            this.toolBox.Controls.Add(this.label1);
            this.toolBox.Controls.Add(this.tbMaxFlow);
            this.toolBox.Controls.Add(this.tbCurrentFlow);
            this.toolBox.Location = new System.Drawing.Point(8, 38);
            this.toolBox.Name = "toolBox";
            this.toolBox.Size = new System.Drawing.Size(158, 490);
            this.toolBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max Flow";
            // 
            // lbCompPrc
            // 
            this.lbCompPrc.AutoSize = true;
            this.lbCompPrc.Location = new System.Drawing.Point(60, 24);
            this.lbCompPrc.Name = "lbCompPrc";
            this.lbCompPrc.Size = new System.Drawing.Size(35, 13);
            this.lbCompPrc.TabIndex = 3;
            this.lbCompPrc.Text = "label3";
            this.lbCompPrc.Visible = false;
            // 
            // lbPrc
            // 
            this.lbPrc.AutoSize = true;
            this.lbPrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrc.Location = new System.Drawing.Point(1054, 329);
            this.lbPrc.Name = "lbPrc";
            this.lbPrc.Size = new System.Drawing.Size(25, 143);
            this.lbPrc.TabIndex = 2;
            this.lbPrc.Text = "100\r\n90\r\n80\r\n70\r\n60\r\n50\r\n40\r\n30\r\n20\r\n10\r\n0";
            this.lbPrc.Visible = false;
            // 
            // btSet
            // 
            this.btSet.Location = new System.Drawing.Point(1033, 504);
            this.btSet.Name = "btSet";
            this.btSet.Size = new System.Drawing.Size(93, 23);
            this.btSet.TabIndex = 1;
            this.btSet.Text = "Set Percentage";
            this.btSet.UseVisualStyleBackColor = true;
            this.btSet.Visible = false;
            this.btSet.Click += new System.EventHandler(this.btSet_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(1016, 300);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 198);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 50;
            this.trackBar1.Visible = false;
            // 
            // workPanel
            // 
            this.workPanel.BackColor = System.Drawing.Color.White;
            this.workPanel.Controls.Add(this.lbCompPrc);
            this.workPanel.Location = new System.Drawing.Point(172, 40);
            this.workPanel.Name = "workPanel";
            this.workPanel.Size = new System.Drawing.Size(815, 488);
            this.workPanel.TabIndex = 3;
            this.workPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.workPanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 539);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbPrc);
            this.Controls.Add(this.toolBox);
            this.Controls.Add(this.btSet);
            this.Controls.Add(this.workPanel);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbPump)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdjustableSpliter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpliter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMerger)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe)).EndInit();
            this.toolBox.ResumeLayout(false);
            this.toolBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.workPanel.ResumeLayout(false);
            this.workPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbPump;
        private System.Windows.Forms.PictureBox pbSink;
        private System.Windows.Forms.PictureBox pbAdjustableSpliter;
        private System.Windows.Forms.PictureBox pbSpliter;
        private System.Windows.Forms.PictureBox pbMerger;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pbPipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaxFlow;
        private System.Windows.Forms.TextBox tbCurrentFlow;
        private System.Windows.Forms.Panel toolBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCompPrc;
        private System.Windows.Forms.Label lbPrc;
        private System.Windows.Forms.Button btSet;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel workPanel;

    }
}

