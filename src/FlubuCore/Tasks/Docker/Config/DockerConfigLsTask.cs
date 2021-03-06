
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Attributes;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker.Config
{
     public partial class DockerConfigLsTask : ExternalProcessTaskBase<int, DockerConfigLsTask>
     {
        
        
        public DockerConfigLsTask()
        {
            ExecutablePath = "docker";
            WithArguments("config ls");

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Filter output based on conditions provided
        /// </summary>
        [ArgKey("--filter")]
        public DockerConfigLsTask Filter(string filter)
        {
            WithArgumentsKeyFromAttribute(filter.ToString());
            return this;
        }

        /// <summary>
        /// Pretty-print configs using a Go template
        /// </summary>
        [ArgKey("--format")]
        public DockerConfigLsTask Format(string format)
        {
            WithArgumentsKeyFromAttribute(format.ToString());
            return this;
        }

        /// <summary>
        /// Only display IDs
        /// </summary>
        [ArgKey("--quiet")]
        public DockerConfigLsTask Quiet()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
            
            return base.DoExecute(context);
        }

     }
}
