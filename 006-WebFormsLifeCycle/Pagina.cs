using System;
using System.Diagnostics;
using System.Web.UI;

namespace _006_WebFormsLifeCycle
{
    public class Pagina : Page
    {
        private static void Log()
        {
            Debug.Print(new StackTrace().GetFrame(1).GetMethod().Name);
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            Log();
        }

        protected override void OnInitComplete(EventArgs e)
        {
            base.OnInitComplete(e);
            Log();
        }
    
        protected override void OnAbortTransaction(EventArgs e)
        {
            base.OnAbortTransaction(e);
            Log();
        }

        protected override bool OnBubbleEvent(object source, EventArgs args)
        {
            Log();
            return base.OnBubbleEvent(source, args);
        }

        protected override void OnCommitTransaction(EventArgs e)
        {
            base.OnCommitTransaction(e);
            Log();
        }

        protected override void OnDataBinding(EventArgs e)
        {
            base.OnDataBinding(e);
            Log();
        }

        protected override void OnLoadComplete(EventArgs e)
        {
            base.OnLoadComplete(e);
            Log();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Log();
        }

        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);
            Log();
        }

        protected override void OnPreLoad(EventArgs e)
        {
            base.OnPreLoad(e);
            Log();
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            Log();
        }

        protected override void OnPreRenderComplete(EventArgs e)
        {
            base.OnPreRenderComplete(e);
            Log();
        }

        protected override void OnSaveStateComplete(EventArgs e)
        {
            base.OnSaveStateComplete(e);
            Log();
        }

        protected override void OnUnload(EventArgs e)
        {
            base.OnUnload(e);
            Log();
        }
    }
}