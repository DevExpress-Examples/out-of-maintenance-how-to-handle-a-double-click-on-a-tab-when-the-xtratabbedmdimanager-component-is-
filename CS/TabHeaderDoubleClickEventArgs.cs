using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTab;

namespace TabbedMDI
{
    public class TabHeaderDoubleClickEventArgs : EventArgs
    {
        public TabHeaderDoubleClickEventArgs(IXtraTabPage tabPage)
        {
            _TabPage = tabPage;
        }

        // Fields...
        private IXtraTabPage _TabPage;

        public IXtraTabPage TabPage
        {
            get { return _TabPage; }
        }
    }
}