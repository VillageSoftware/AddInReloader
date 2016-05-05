using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading;

namespace AddInReloader
{
    public partial class AddInReloaderRibbon
    {
        private Excel.Application application;

        private COMAddIn SelectedAddIn
        {
            get
            {
                return (COMAddIn)addinDropdown.SelectedItem.Tag;
            }
        }

        private void AddInReloaderRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            application = Globals.ThisAddIn.Application;

            foreach (COMAddIn addin in application.COMAddIns)
            {
                RibbonDropDownItem item = Globals
                    .Factory
                    .GetRibbonFactory()
                    .CreateRibbonDropDownItem();

                item.Label = addin.ProgId;
                item.Tag = addin;

                addinDropdown.Items.Add(item);

            }

            SetStatus();
        }

        private void SetStatus()
        {
            string statusWord = SelectedAddIn.Connect 
                ? "Enabled" 
                : "Disabled";

            statusLabel.Label = String.Format("{0}: {1}", SelectedAddIn.ProgId, statusWord);
        }

        private void Disconnect()
        {
            SelectedAddIn.Connect = false;
            SetStatus();
        }

        private void Connect()
        {
            SelectedAddIn.Connect = true;
            SetStatus();
        }

        private void reloadButton_Click(object sender, RibbonControlEventArgs e)
        {
            if (SelectedAddIn != null)
            {
                Disconnect();
                Thread.Sleep(100);
                Connect();
            }
        }

        private void unloadButton_Click(object sender, RibbonControlEventArgs e)
        {
            if (SelectedAddIn != null)
            {
                Disconnect();
            }
        }

        private void loadButton_Click(object sender, RibbonControlEventArgs e)
        {
            if (SelectedAddIn != null)
            {
                Connect();
            }
        }

        private void addinDropdown_SelectionChanged(object sender, RibbonControlEventArgs e)
        {
            SetStatus();
        }

    }
}
