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
            this.reloadButton = this.Factory.CreateRibbonButton();
            this.addinDropdown = this.Factory.CreateRibbonDropDown();
            this.tab1.SuspendLayout();
            this.reloaderGroup.SuspendLayout();
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
            this.reloaderGroup.Items.Add(this.reloadButton);
            this.reloaderGroup.Label = "Reloader";
            this.reloaderGroup.Name = "reloaderGroup";
            // 
            // reloadButton
            // 
            this.reloadButton.Label = "Reload";
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.reloadButton_Click);
            // 
            // addinDropdown
            // 
            this.addinDropdown.Label = "Add-In";
            this.addinDropdown.Name = "addinDropdown";
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

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup reloaderGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton reloadButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown addinDropdown;
    }

    partial class ThisRibbonCollection
    {
        internal AddInReloaderRibbon AddInReloaderRibbon
        {
            get { return this.GetRibbon<AddInReloaderRibbon>(); }
        }
    }
}
