namespace AddInReloader
{
    partial class AddInReloaderRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public AddInReloaderRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.reloaderGroup = this.Factory.CreateRibbonGroup();
            this.addinDropdown = this.Factory.CreateRibbonDropDown();
            this.statusLabel = this.Factory.CreateRibbonLabel();
            this.buttonGroup1 = this.Factory.CreateRibbonButtonGroup();
            this.reloadButton = this.Factory.CreateRibbonButton();
            this.unloadButton = this.Factory.CreateRibbonButton();
            this.loadButton = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.reloaderGroup.SuspendLayout();
            this.buttonGroup1.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.reloaderGroup);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // reloaderGroup
            // 
            this.reloaderGroup.Items.Add(this.addinDropdown);
            this.reloaderGroup.Items.Add(this.statusLabel);
            this.reloaderGroup.Items.Add(this.buttonGroup1);
            this.reloaderGroup.Label = "Reloader";
            this.reloaderGroup.Name = "reloaderGroup";
            // 
            // addinDropdown
            // 
            this.addinDropdown.Label = "Add-In";
            this.addinDropdown.Name = "addinDropdown";
            this.addinDropdown.SelectionChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.addinDropdown_SelectionChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.Label = "Status: ";
            this.statusLabel.Name = "statusLabel";
            // 
            // buttonGroup1
            // 
            this.buttonGroup1.Items.Add(this.reloadButton);
            this.buttonGroup1.Items.Add(this.unloadButton);
            this.buttonGroup1.Items.Add(this.loadButton);
            this.buttonGroup1.Name = "buttonGroup1";
            // 
            // reloadButton
            // 
            this.reloadButton.Image = global::AddInReloader.Properties.Resources.refresh;
            this.reloadButton.Label = "Reload";
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.ShowImage = true;
            this.reloadButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.reloadButton_Click);
            // 
            // unloadButton
            // 
            this.unloadButton.Image = global::AddInReloader.Properties.Resources.unload;
            this.unloadButton.Label = "Unload";
            this.unloadButton.Name = "unloadButton";
            this.unloadButton.ShowImage = true;
            this.unloadButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.unloadButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Image = global::AddInReloader.Properties.Resources.load;
            this.loadButton.Label = "Load";
            this.loadButton.Name = "loadButton";
            this.loadButton.ShowImage = true;
            this.loadButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.loadButton_Click);
            // 
            // AddInReloaderRibbon
            // 
            this.Name = "AddInReloaderRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.AddInReloaderRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.reloaderGroup.ResumeLayout(false);
            this.reloaderGroup.PerformLayout();
            this.buttonGroup1.ResumeLayout(false);
            this.buttonGroup1.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup reloaderGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton reloadButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown addinDropdown;
        internal Microsoft.Office.Tools.Ribbon.RibbonButtonGroup buttonGroup1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton unloadButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton loadButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel statusLabel;
    }

    partial class ThisRibbonCollection
    {
        internal AddInReloaderRibbon AddInReloaderRibbon
        {
            get { return this.GetRibbon<AddInReloaderRibbon>(); }
        }
    }
}
