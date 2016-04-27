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
        }

        private void reloadButton_Click(object sender, RibbonControlEventArgs e)
        {

            var selectedAddIn = (COMAddIn)addinDropdown.SelectedItem.Tag;

            if (selectedAddIn != null)
            {
                selectedAddIn.Connect = false;
                Thread.Sleep(100);
                selectedAddIn.Connect = true;
            }
        }
    }
}
