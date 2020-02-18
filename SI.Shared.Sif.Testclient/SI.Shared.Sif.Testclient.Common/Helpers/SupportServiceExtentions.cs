using Microsoft.Rest;
using SI.Shared.Sif.Testclient.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SI.Shared.Sif.Testclient.Common.Helpers
{
    public static class SupportServiceExtentions
    {
        /// <summary>
        /// 
        /// Check which build of SIF you have
        /// 
        /// </summary>
        /// <returns>String</returns>
        public static string GetSIFVersion(this ServiceHelper serviceHelper)
        {
            try
            {
                return serviceHelper.SupportService.GetSIFVersion();
            }
            catch (Exception e)
            {
                //Adding explaination and throwing again, shoud be catched in application that is using the helper
                throw new Exception("Error geting SIF version, se inner exception", e);
            }

        }
    }
}
