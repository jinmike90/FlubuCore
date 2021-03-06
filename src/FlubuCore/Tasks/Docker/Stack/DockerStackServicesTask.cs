
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

namespace FlubuCore.Tasks.Docker.Stack
{
     public partial class DockerStackServicesTask : ExternalProcessTaskBase<int, DockerStackServicesTask>
     {
        private string _stack;

        
        public DockerStackServicesTask(string stack)
        {
            ExecutablePath = "docker";
            WithArguments("stack services");
_stack = stack;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Filter output based on conditions provided
        /// </summary>
        [ArgKey("--filter")]
        public DockerStackServicesTask Filter(string filter)
        {
            WithArgumentsKeyFromAttribute(filter.ToString());
            return this;
        }

        /// <summary>
        /// Pretty-print services using a Go template
        /// </summary>
        [ArgKey("--format")]
        public DockerStackServicesTask Format(string format)
        {
            WithArgumentsKeyFromAttribute(format.ToString());
            return this;
        }

        /// <summary>
        /// Kubernetes namespace to use
        /// </summary>
        [ArgKey("--namespace")]
        public DockerStackServicesTask Namespace(string @namespace)
        {
            WithArgumentsKeyFromAttribute(@namespace.ToString());
            return this;
        }

        /// <summary>
        /// Only display IDs
        /// </summary>
        [ArgKey("--quiet")]
        public DockerStackServicesTask Quiet()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_stack);

            return base.DoExecute(context);
        }

     }
}
