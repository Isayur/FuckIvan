namespace OOD2_project
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
            this.workPanel = new System.Windows.Forms.Panel();
            this.btSet = new System.Windows.Forms.Button();
            this.toolBox = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbPump = new System.Windows.Forms.PictureBox();
            this.pbSink = new System.Windows.Forms.PictureBox();
            this.pbAdjustableSpliter = new System.Windows.Forms.PictureBox();
            this.pbSpliter = new System.Windows.Forms.PictureBox();
            this.pbMerger = new System.Windows.Forms.PictureBox();
            this.pbPipe = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaxFlow = new System.Windows.Forms.TextBox();
            this.tbCurrentFlow = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            this.workPanel.SuspendLayout();
            this.toolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPump)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdjustableSpliter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpliter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMerger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // workPanel
            // 
            this.workPanel.BackColor = System.Drawing.Color.White;
            this.workPanel.Controls.Add(this.label10);
            this.workPanel.Location = new System.Drawing.Point(164, 29);
            this.workPanel.Name = "workPanel";
            this.workPanel.Size = new System.Drawing.Size(815, 588);
            this.workPanel.TabIndex = 0;
            this.workPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.workPanel_DragDrop);
            this.workPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.workPanel_DragEnter);
            this.workPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.workPanel_Paint);
            this.workPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.workPanel_MouseClick);
            this.workPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.workPanel_MouseDown);
            // 
            // btSet
            // 
            this.btSet.Location = new System.Drawing.Point(35, 549);
            this.btSet.Name = "btSet";
            this.btSet.Size = new System.Drawing.Size(93, 23);
            this.btSet.TabIndex = 1;
            this.btSet.Text = "Set Percentage";
            this.btSet.UseVisualStyleBackColor = true;
            this.btSet.Visible = false;
            this.btSet.Click += new System.EventHandler(this.btSet_Click);
            // 
            // toolBox
            // 
            this.toolBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolBox.Controls.Add(this.label9);
            this.toolBox.Controls.Add(this.numericUpDown1);
            this.toolBox.Controls.Add(this.label8);
            this.toolBox.Controls.Add(this.btSet);
            this.toolBox.Controls.Add(this.label7);
            this.toolBox.Controls.Add(this.label6);
            this.toolBox.Controls.Add(this.label5);
            this.toolBox.Controls.Add(this.label4);
            this.toolBox.Controls.Add(this.label3);
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
            this.toolBox.Location = new System.Drawing.Point(0, 27);
            this.toolBox.Name = "toolBox";
            this.toolBox.Size = new System.Drawing.Size(158, 603);
            this.toolBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 507);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Adjustable Splitter";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(23, 523);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Pipe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Splitter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Merger";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Adjustable \r\nSplitter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sink";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pump";
            // 
            // pbPump
            // 
            this.pbPump.ErrorImage = null;
            this.pbPump.Image = global::OOD2_project.Properties.Resources.pump;
            this.pbPump.Location = new System.Drawing.Point(23, 24);
            this.pbPump.Name = "pbPump";
            this.pbPump.Size = new System.Drawing.Size(55, 38);
            this.pbPump.TabIndex = 0;
            this.pbPump.TabStop = false;
            this.pbPump.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPump_MouseDown);
            this.pbPump.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPump_MouseUp);
            // 
            // pbSink
            // 
            this.pbSink.Image = global::OOD2_project.Properties.Resources.sink;
            this.pbSink.Location = new System.Drawing.Point(23, 90);
            this.pbSink.Name = "pbSink";
            this.pbSink.Size = new System.Drawing.Size(58, 43);
            this.pbSink.TabIndex = 1;
            this.pbSink.TabStop = false;
            this.pbSink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbSink_MouseDown);
            this.pbSink.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbSink_MouseUp);
            // 
            // pbAdjustableSpliter
            // 
            this.pbAdjustableSpliter.ErrorImage = null;
            this.pbAdjustableSpliter.Image = global::OOD2_project.Properties.Resources.adjustable_spliter;
            this.pbAdjustableSpliter.Location = new System.Drawing.Point(23, 157);
            this.pbAdjustableSpliter.Name = "pbAdjustableSpliter";
            this.pbAdjustableSpliter.Size = new System.Drawing.Size(55, 46);
            this.pbAdjustableSpliter.TabIndex = 2;
            this.pbAdjustableSpliter.TabStop = false;
            this.pbAdjustableSpliter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbAdjustableSpliter_MouseDown);
            this.pbAdjustableSpliter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbAdjustableSpliter_MouseUp);
            // 
            // pbSpliter
            // 
            this.pbSpliter.Image = global::OOD2_project.Properties.Resources.spliter;
            this.pbSpliter.Location = new System.Drawing.Point(23, 223);
            this.pbSpliter.Name = "pbSpliter";
            this.pbSpliter.Size = new System.Drawing.Size(55, 45);
            this.pbSpliter.TabIndex = 3;
            this.pbSpliter.TabStop = false;
            this.pbSpliter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbSpliter_MouseDown);
            this.pbSpliter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbSpliter_MouseUp);
            // 
            // pbMerger
            // 
            this.pbMerger.Image = global::OOD2_project.Properties.Resources.merger;
            this.pbMerger.Location = new System.Drawing.Point(23, 285);
            this.pbMerger.Name = "pbMerger";
            this.pbMerger.Size = new System.Drawing.Size(55, 44);
            this.pbMerger.TabIndex = 4;
            this.pbMerger.TabStop = false;
            this.pbMerger.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMerger_MouseDown);
            this.pbMerger.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbMerger_MouseUp);
            // 
            // pbPipe
            // 
            this.pbPipe.Image = global::OOD2_project.Properties.Resources.pipe;
            this.pbPipe.Location = new System.Drawing.Point(23, 347);
            this.pbPipe.Name = "pbPipe";
            this.pbPipe.Size = new System.Drawing.Size(55, 42);
            this.pbPipe.TabIndex = 5;
            this.pbPipe.TabStop = false;
            this.pbPipe.Click += new System.EventHandler(this.pbPipe_Click);
            this.pbPipe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbPipe_MouseClick);
            this.pbPipe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPipe_MouseDown);
            this.pbPipe.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPipe_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max Flow";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 428);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(990, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click_1);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem1.Text = "Save As";
            this.saveAsToolStripMenuItem1.Click += new System.EventHandler(this.saveAsToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Enabled = false;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(152, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(578, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Drag a component here to begin constructing your pipeline.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 629);
            this.Controls.Add(this.toolBox);
            this.Controls.Add(this.workPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.workPanel.ResumeLayout(false);
            this.workPanel.PerformLayout();
            this.toolBox.ResumeLayout(false);
            this.toolBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPump)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdjustableSpliter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpliter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMerger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel workPanel;
        private System.Windows.Forms.Panel toolBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaxFlow;
        private System.Windows.Forms.TextBox tbCurrentFlow;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbPump;
        private System.Windows.Forms.PictureBox pbSink;
        private System.Windows.Forms.PictureBox pbAdjustableSpliter;
        private System.Windows.Forms.PictureBox pbSpliter;
        private System.Windows.Forms.PictureBox pbMerger;
        private System.Windows.Forms.PictureBox pbPipe;
        private System.Windows.Forms.Button btSet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

