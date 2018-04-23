using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTab;
using DevExpress.XtraTabbedMdi;
using System.Drawing;
using System.Collections;

namespace TabbedMDI
{
    public class TabbedMdiManagerHelper
    {
        XtraTabbedMdiManager manager;
        int clickTick = -1;
        IXtraTabPage previousPage;

        public delegate void TabHeaderDoubleClickEventHandler(object sender, TabHeaderDoubleClickEventArgs e);
        public event TabHeaderDoubleClickEventHandler TabHeaderDoubleClick;

        public TabbedMdiManagerHelper(XtraTabbedMdiManager manager)
        {
            this.manager = manager;
            manager.MouseDown += OnXtraTabbedMdiManagerMouseDown;
        }

        private void OnXtraTabbedMdiManagerMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            DevExpress.XtraTab.ViewInfo.BaseTabHitInfo hi = manager.CalcHitInfo(new Point(e.X, e.Y));
            if (hi.HitTest == DevExpress.XtraTab.ViewInfo.XtraTabHitTest.PageHeader)
            {
                if (clickTick == -1)
                {
                    clickTick = System.Environment.TickCount;
                    previousPage = hi.Page;
                }
                else
                {
                    if (System.Environment.TickCount - clickTick < SystemInformation.DoubleClickTime && hi.Page == previousPage)
                    {
                        TabHeaderDoubleClickEventArgs args = new TabHeaderDoubleClickEventArgs(hi.Page);
                        RaiseTabHeaderDoubleClick(args);
                    }
                    clickTick = -1;
                }
            }
        }

        private void RaiseTabHeaderDoubleClick(TabHeaderDoubleClickEventArgs e)
        {
            if (TabHeaderDoubleClick != null)
                TabHeaderDoubleClick(manager, e);
        }
    }
}
