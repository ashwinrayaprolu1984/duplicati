﻿namespace Duplicati.Scheduler
{
    partial class Scheduler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scheduler));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SettingsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.AddToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.LogToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.FilesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PrevToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SelectToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.NextToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.jobSummary1 = new Duplicati.Scheduler.JobSummary();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.JobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SchedulerDataSet = new Duplicati.Scheduler.Data.SchedulerDataSet();
            this.optionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JobsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchedulerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripButton,
            this.toolStripSeparator3,
            this.AddToolStripButton,
            this.DelToolStripButton,
            this.EditToolStripButton,
            this.helpToolStripButton,
            this.toolStripLabel1,
            this.LogToolStripButton,
            this.FilesToolStripButton,
            this.toolStripSeparator1,
            this.PrevToolStripButton,
            this.SelectToolStripDropDownButton,
            this.NextToolStripButton,
            this.toolStripSeparator2,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(620, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SettingsToolStripButton
            // 
            this.SettingsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SettingsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsToolStripButton.Image")));
            this.SettingsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingsToolStripButton.Name = "SettingsToolStripButton";
            this.SettingsToolStripButton.Size = new System.Drawing.Size(62, 22);
            this.SettingsToolStripButton.Text = "Settings...";
            this.SettingsToolStripButton.ToolTipText = "Change program settings";
            this.SettingsToolStripButton.Click += new System.EventHandler(this.SettingsToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // AddToolStripButton
            // 
            this.AddToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AddToolStripButton.Image")));
            this.AddToolStripButton.Name = "AddToolStripButton";
            this.AddToolStripButton.RightToLeftAutoMirrorImage = true;
            this.AddToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.AddToolStripButton.Text = "Add new";
            this.AddToolStripButton.ToolTipText = "Add a new backup job";
            this.AddToolStripButton.Click += new System.EventHandler(this.AddToolStripButton_Click);
            // 
            // DelToolStripButton
            // 
            this.DelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DelToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DelToolStripButton.Image")));
            this.DelToolStripButton.Name = "DelToolStripButton";
            this.DelToolStripButton.RightToLeftAutoMirrorImage = true;
            this.DelToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.DelToolStripButton.Text = "Delete";
            this.DelToolStripButton.ToolTipText = "Delete this backup job";
            this.DelToolStripButton.Click += new System.EventHandler(this.DelToolStripButton_Click);
            // 
            // EditToolStripButton
            // 
            this.EditToolStripButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditToolStripButton.BackgroundImage")));
            this.EditToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EditToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EditToolStripButton.Image")));
            this.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolStripButton.Name = "EditToolStripButton";
            this.EditToolStripButton.Size = new System.Drawing.Size(41, 22);
            this.EditToolStripButton.Text = " EDIT ";
            this.EditToolStripButton.ToolTipText = "Change this backup job";
            this.EditToolStripButton.Click += new System.EventHandler(this.EditToolStripButton_Click);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(57, 22);
            this.toolStripLabel1.Text = "Schedule";
            // 
            // LogToolStripButton
            // 
            this.LogToolStripButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogToolStripButton.BackgroundImage")));
            this.LogToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LogToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("LogToolStripButton.Image")));
            this.LogToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LogToolStripButton.Name = "LogToolStripButton";
            this.LogToolStripButton.Size = new System.Drawing.Size(43, 22);
            this.LogToolStripButton.Text = "  Log  ";
            this.LogToolStripButton.ToolTipText = "View backup history and logs";
            this.LogToolStripButton.Click += new System.EventHandler(this.LogToolStripButton_Click);
            // 
            // FilesToolStripButton
            // 
            this.FilesToolStripButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FilesToolStripButton.BackgroundImage")));
            this.FilesToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FilesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FilesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FilesToolStripButton.Image")));
            this.FilesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FilesToolStripButton.Name = "FilesToolStripButton";
            this.FilesToolStripButton.Size = new System.Drawing.Size(56, 22);
            this.FilesToolStripButton.Text = " Restore ";
            this.FilesToolStripButton.ToolTipText = "Restore or list backup files";
            this.FilesToolStripButton.Click += new System.EventHandler(this.FilesToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // PrevToolStripButton
            // 
            this.PrevToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrevToolStripButton.Enabled = false;
            this.PrevToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("PrevToolStripButton.Image")));
            this.PrevToolStripButton.Name = "PrevToolStripButton";
            this.PrevToolStripButton.RightToLeftAutoMirrorImage = true;
            this.PrevToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.PrevToolStripButton.Text = "previous";
            this.PrevToolStripButton.Click += new System.EventHandler(this.PositionButtons_Click);
            // 
            // SelectToolStripDropDownButton
            // 
            this.SelectToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SelectToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("SelectToolStripDropDownButton.Image")));
            this.SelectToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelectToolStripDropDownButton.Name = "SelectToolStripDropDownButton";
            this.SelectToolStripDropDownButton.Size = new System.Drawing.Size(51, 22);
            this.SelectToolStripDropDownButton.Text = "Select";
            this.SelectToolStripDropDownButton.ToolTipText = "Select a backup job";
            this.SelectToolStripDropDownButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.SelectToolStripDropDownButton_DropDownItemClicked);
            this.SelectToolStripDropDownButton.DropDownOpening += new System.EventHandler(this.SelectToolStripDropDownButton_DropDownOpening);
            // 
            // NextToolStripButton
            // 
            this.NextToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NextToolStripButton.Image")));
            this.NextToolStripButton.Name = "NextToolStripButton";
            this.NextToolStripButton.RightToLeftAutoMirrorImage = true;
            this.NextToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.NextToolStripButton.Text = "next";
            this.NextToolStripButton.Click += new System.EventHandler(this.PositionButtons_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.CheckOnClick = true;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Visible = false;
            // 
            // serviceController1
            // 
            this.serviceController1.ServiceName = "Duplicati.Service";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 442);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.jobSummary1);
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 442);
            this.panel2.TabIndex = 14;
            // 
            // jobSummary1
            // 
            this.jobSummary1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobSummary1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobSummary1.Location = new System.Drawing.Point(0, 25);
            this.jobSummary1.Margin = new System.Windows.Forms.Padding(4);
            this.jobSummary1.Name = "jobSummary1";
            this.jobSummary1.Size = new System.Drawing.Size(620, 391);
            this.jobSummary1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 416);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(620, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel1.Text = "   ";
            // 
            // JobsBindingSource
            // 
            this.JobsBindingSource.DataMember = "Jobs";
            this.JobsBindingSource.DataSource = this.SchedulerDataSet;
            this.JobsBindingSource.CurrentChanged += new System.EventHandler(this.JobsBindingSource_CurrentChanged);
            // 
            // SchedulerDataSet
            // 
            this.SchedulerDataSet.DataSetName = "SchedulerDataSet";
            this.SchedulerDataSet.LastLoaded = new System.DateTime(((long)(0)));
            this.SchedulerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.SchedulerDataSet.XMLPath = null;
            // 
            // optionsBindingSource
            // 
            this.optionsBindingSource.DataMember = "Options";
            this.optionsBindingSource.DataSource = this.SchedulerDataSet;
            // 
            // Scheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Scheduler";
            this.Text = "Schedule";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JobsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchedulerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource JobsBindingSource;
        private Duplicati.Scheduler.Data.SchedulerDataSet SchedulerDataSet;
        private System.Windows.Forms.BindingSource optionsBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddToolStripButton;
        private System.Windows.Forms.ToolStripButton DelToolStripButton;
        private System.Windows.Forms.ToolStripButton EditToolStripButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton LogToolStripButton;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.ToolStripButton FilesToolStripButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton PrevToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton SelectToolStripDropDownButton;
        private System.Windows.Forms.ToolStripButton NextToolStripButton;
        private JobSummary jobSummary1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton SettingsToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}