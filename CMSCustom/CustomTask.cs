using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Core;
using CMS.Scheduler;


namespace CMSCustom
{
    public class CustomTask:ITask
    {
        public string Execute(TaskInfo ti)
        {
            var serviceLog = Service.Resolve<IEventLogService>();
            serviceLog.LogInformation("CustomTask", "Execute", "Custom Schedule Task Called");

            return "Executed Successfully";
        }
    }
}
