namespace Digital_Advent_Calendar_Designer
{
    partial class FormMain
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxProperties = new System.Windows.Forms.GroupBox();
            this.propertyGridMain = new System.Windows.Forms.PropertyGrid();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.groupBoxCalendarPreview = new System.Windows.Forms.GroupBox();
            this.panelCalendarPreview = new System.Windows.Forms.Panel();
            this.pictureBoxCalendar = new System.Windows.Forms.PictureBox();
            this.groupBoxHelp = new System.Windows.Forms.GroupBox();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBoxHelp = new System.Windows.Forms.RichTextBox();
            this.menuStripMain.SuspendLayout();
            this.groupBoxProperties.SuspendLayout();
            this.groupBoxCalendarPreview.SuspendLayout();
            this.panelCalendarPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalendar)).BeginInit();
            this.groupBoxHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(918, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "Main Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCalendarToolStripMenuItem,
            this.saveCalendarToolStripMenuItem,
            this.exportCalendarToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newCalendarToolStripMenuItem
            // 
            this.newCalendarToolStripMenuItem.Name = "newCalendarToolStripMenuItem";
            this.newCalendarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newCalendarToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.newCalendarToolStripMenuItem.Text = "&New Calendar";
            this.newCalendarToolStripMenuItem.Click += new System.EventHandler(this.newCalendarToolStripMenuItem_Click);
            // 
            // saveCalendarToolStripMenuItem
            // 
            this.saveCalendarToolStripMenuItem.Name = "saveCalendarToolStripMenuItem";
            this.saveCalendarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveCalendarToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.saveCalendarToolStripMenuItem.Text = "&Save Calendar";
            this.saveCalendarToolStripMenuItem.Click += new System.EventHandler(this.saveCalendarToolStripMenuItem_Click);
            // 
            // exportCalendarToolStripMenuItem
            // 
            this.exportCalendarToolStripMenuItem.Name = "exportCalendarToolStripMenuItem";
            this.exportCalendarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportCalendarToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.exportCalendarToolStripMenuItem.Text = "&Export Calendar";
            this.exportCalendarToolStripMenuItem.Click += new System.EventHandler(this.exportCalendarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBoxProperties
            // 
            this.groupBoxProperties.Controls.Add(this.propertyGridMain);
            this.groupBoxProperties.Controls.Add(this.comboBoxItems);
            this.groupBoxProperties.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxProperties.Location = new System.Drawing.Point(306, 24);
            this.groupBoxProperties.Name = "groupBoxProperties";
            this.groupBoxProperties.Size = new System.Drawing.Size(306, 419);
            this.groupBoxProperties.TabIndex = 0;
            this.groupBoxProperties.TabStop = false;
            this.groupBoxProperties.Text = "Properties";
            // 
            // propertyGridMain
            // 
            this.propertyGridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridMain.Location = new System.Drawing.Point(3, 37);
            this.propertyGridMain.Name = "propertyGridMain";
            this.propertyGridMain.Size = new System.Drawing.Size(300, 379);
            this.propertyGridMain.TabIndex = 0;
            this.propertyGridMain.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGridMain_PropertyValueChanged);
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(3, 16);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(300, 21);
            this.comboBoxItems.TabIndex = 1;
            this.comboBoxItems.SelectedIndexChanged += new System.EventHandler(this.comboBoxItems_SelectedIndexChanged);
            // 
            // groupBoxCalendarPreview
            // 
            this.groupBoxCalendarPreview.Controls.Add(this.panelCalendarPreview);
            this.groupBoxCalendarPreview.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxCalendarPreview.Location = new System.Drawing.Point(0, 24);
            this.groupBoxCalendarPreview.Name = "groupBoxCalendarPreview";
            this.groupBoxCalendarPreview.Size = new System.Drawing.Size(306, 419);
            this.groupBoxCalendarPreview.TabIndex = 2;
            this.groupBoxCalendarPreview.TabStop = false;
            this.groupBoxCalendarPreview.Text = "Calendar Preview";
            // 
            // panelCalendarPreview
            // 
            this.panelCalendarPreview.Controls.Add(this.pictureBoxCalendar);
            this.panelCalendarPreview.Location = new System.Drawing.Point(3, 16);
            this.panelCalendarPreview.Name = "panelCalendarPreview";
            this.panelCalendarPreview.Size = new System.Drawing.Size(300, 400);
            this.panelCalendarPreview.TabIndex = 0;
            // 
            // pictureBoxCalendar
            // 
            this.pictureBoxCalendar.BackColor = System.Drawing.Color.Black;
            this.pictureBoxCalendar.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCalendar.Name = "pictureBoxCalendar";
            this.pictureBoxCalendar.Size = new System.Drawing.Size(300, 400);
            this.pictureBoxCalendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCalendar.TabIndex = 0;
            this.pictureBoxCalendar.TabStop = false;
            // 
            // groupBoxHelp
            // 
            this.groupBoxHelp.Controls.Add(this.richTextBoxHelp);
            this.groupBoxHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxHelp.Location = new System.Drawing.Point(612, 24);
            this.groupBoxHelp.Name = "groupBoxHelp";
            this.groupBoxHelp.Size = new System.Drawing.Size(306, 419);
            this.groupBoxHelp.TabIndex = 3;
            this.groupBoxHelp.TabStop = false;
            this.groupBoxHelp.Text = "Help";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calendarPreviewToolStripMenuItem,
            this.propertiesBoxToolStripMenuItem,
            this.helpBoxToolStripMenuItem});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.displayToolStripMenuItem.Text = "&Display";
            // 
            // helpBoxToolStripMenuItem
            // 
            this.helpBoxToolStripMenuItem.Checked = true;
            this.helpBoxToolStripMenuItem.CheckOnClick = true;
            this.helpBoxToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.helpBoxToolStripMenuItem.Name = "helpBoxToolStripMenuItem";
            this.helpBoxToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.helpBoxToolStripMenuItem.Text = "&Help Box";
            this.helpBoxToolStripMenuItem.CheckedChanged += new System.EventHandler(this.helpBoxToolStripMenuItem_CheckedChanged);
            // 
            // propertiesBoxToolStripMenuItem
            // 
            this.propertiesBoxToolStripMenuItem.Checked = true;
            this.propertiesBoxToolStripMenuItem.CheckOnClick = true;
            this.propertiesBoxToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.propertiesBoxToolStripMenuItem.Name = "propertiesBoxToolStripMenuItem";
            this.propertiesBoxToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.propertiesBoxToolStripMenuItem.Text = "&Properties Box";
            this.propertiesBoxToolStripMenuItem.CheckedChanged += new System.EventHandler(this.propertiesBoxToolStripMenuItem_CheckedChanged);
            // 
            // calendarPreviewToolStripMenuItem
            // 
            this.calendarPreviewToolStripMenuItem.Checked = true;
            this.calendarPreviewToolStripMenuItem.CheckOnClick = true;
            this.calendarPreviewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.calendarPreviewToolStripMenuItem.Enabled = false;
            this.calendarPreviewToolStripMenuItem.Name = "calendarPreviewToolStripMenuItem";
            this.calendarPreviewToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.calendarPreviewToolStripMenuItem.Text = "Calendar Preview";
            // 
            // richTextBoxHelp
            // 
            this.richTextBoxHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxHelp.Location = new System.Drawing.Point(3, 16);
            this.richTextBoxHelp.Name = "richTextBoxHelp";
            this.richTextBoxHelp.ReadOnly = true;
            this.richTextBoxHelp.Size = new System.Drawing.Size(300, 400);
            this.richTextBoxHelp.TabIndex = 0;
            this.richTextBoxHelp.Text = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 443);
            this.Controls.Add(this.groupBoxHelp);
            this.Controls.Add(this.groupBoxProperties);
            this.Controls.Add(this.groupBoxCalendarPreview);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.MaximumSize = new System.Drawing.Size(10000, 482);
            this.MinimumSize = new System.Drawing.Size(0, 482);
            this.Name = "FormMain";
            this.Text = "Digital Advent Calendar Designer";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResizeBegin += new System.EventHandler(this.FormMain_ResizeBegin);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.groupBoxProperties.ResumeLayout(false);
            this.groupBoxCalendarPreview.ResumeLayout(false);
            this.panelCalendarPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalendar)).EndInit();
            this.groupBoxHelp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCalendarToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxProperties;
        private System.Windows.Forms.PropertyGrid propertyGridMain;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCalendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportCalendarToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxCalendarPreview;
        private System.Windows.Forms.Panel panelCalendarPreview;
        private System.Windows.Forms.PictureBox pictureBoxCalendar;
        private System.Windows.Forms.GroupBox groupBoxHelp;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesBoxToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBoxHelp;
    }
}

