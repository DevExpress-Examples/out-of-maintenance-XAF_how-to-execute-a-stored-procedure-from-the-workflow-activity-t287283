using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Workflow.Activities;
using System;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteSprocWorkflowExample.Module {
    public class CustomNativeActivity2 : NativeActivity {
        protected override void Execute(NativeActivityContext context) {
            XPObjectSpace xpObjectSpace = this.XPObjectSpace.Get(context);
            xpObjectSpace.Session.ExecuteSproc("StoredProcName");
        }
        [DefaultValue(null)]
        public InArgument<XPObjectSpace> XPObjectSpace { get; set; }
    }
}
