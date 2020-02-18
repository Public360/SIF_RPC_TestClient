using SI.Shared.Sif.Testclient.Common.Entities;
using SI.Shared.Sif.Testclient.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SI.Shared.Sif.Testclient.Common.Helpers
{
    public static class ContactServiceExtentions
    {
        /// <summary>
        /// 
        /// Creates or updates a user in 360, identified by its login name. If
        /// the user does not exist, it is created. If it exists, it is updated to
        /// match the input.
        /// A user must be connected to an existing 360° contact person, so
        /// always call SynchronizeContactPerson in the contact service first.
        /// 
        /// </summary>
        /// <returns>SynchronizeUserOKResponse</returns>
        public static SynchronizeContactPersonOKResponse SynchronizeContact(this ServiceHelper servicehelper, SynchronizeContactPersonArgsParameter synchronizeContactArgsParameter)
        {
            try
            {
                SynchronizeContactPersonArgs synchronizeContactArgs = new SynchronizeContactPersonArgs(synchronizeContactArgsParameter);

                SynchronizeContactPersonOKResponse synchronizeContactOKResponse = servicehelper.ContactService.SynchronizeContactPerson(synchronizeContactArgs);

                return synchronizeContactOKResponse;
            }
            catch (Exception e)
            {
                //Adding explaination and throwing again, shoud be catched in application that is using the helper
                throw new Exception("Syncronizeing of Contact failed, se inner exception", e);
            }

        }
    }
}
