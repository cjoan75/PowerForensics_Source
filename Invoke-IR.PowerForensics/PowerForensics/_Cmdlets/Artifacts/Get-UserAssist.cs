﻿using System;
using System.Management.Automation;
using PowerForensics.Artifacts;
using PowerForensics.Registry;
using PowerForensics.Utilities;

namespace PowerForensics.Cmdlets
{
    #region GetUserAssistCommand
    
    /// <summary> 
    /// This class implements the Get-UserAssist cmdlet. 
    /// </summary> 
    [Cmdlet(VerbsCommon.Get, "UserAssist")]
    public class GetUserAssistCommand : PSCmdlet
    {
        #region Parameters

        /// <summary> 
        /// This parameter provides the the path of the Registry Hive to parse.
        /// </summary> 
        [Alias("HivePath")]
        [Parameter(Mandatory = true, Position = 0)]
        public string Path
        {
            get { return hivePath; }
            set { hivePath = value; }
        }
        private string hivePath;

        #endregion Parameters

        #region Cmdlet Overrides

        /// <summary> 
        /// 
        /// </summary>  
        protected override void ProcessRecord()
        {
            WriteObject(UserAssist.GetInstances(hivePath), true);
        } 

        #endregion Cmdlet Overrides
    }

    #endregion GetUserAssistCommand
}
