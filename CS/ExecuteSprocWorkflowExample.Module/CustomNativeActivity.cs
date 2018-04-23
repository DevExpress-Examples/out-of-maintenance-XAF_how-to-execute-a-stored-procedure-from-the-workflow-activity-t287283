using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Workflow.Activities;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteSprocWorkflowExample.Module {
    public class CustomNativeActivity : NativeActivity {
        protected virtual IObjectSpace GetObjectSpace(NativeActivityContext context) {
            return (IObjectSpace)context.Properties.Find(ObjectSpaceTransactionScope.ObjectSpacePropertyName);
        }
        protected override void Execute(NativeActivityContext context) {
            XPObjectSpace xpObjectSpace = (XPObjectSpace)GetObjectSpace(context);
            xpObjectSpace.Session.ExecuteSproc("StoredProcName");
        }
    }
}
