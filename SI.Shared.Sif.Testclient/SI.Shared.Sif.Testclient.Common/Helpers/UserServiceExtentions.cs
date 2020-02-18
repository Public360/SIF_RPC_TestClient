using SI.Shared.Sif.Testclient.Common.Entities;
using SI.Shared.Sif.Testclient.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SI.Shared.Sif.Testclient.Common.Helpers
{
    public static class UserServiceExtentions
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
        public static SynchronizeUserOKResponse SynchronizeUser(this ServiceHelper serviceHelper, SynchronizeUserArgsParameter synchronizeUserArgsParameter)
        {
            try
            {
                SynchronizeUserArgs synchronizeUserArgs = new SynchronizeUserArgs(synchronizeUserArgsParameter);

                SynchronizeUserOKResponse synchronizeUserOKResponse = serviceHelper.UserService.SynchronizeUser(synchronizeUserArgs);

                return synchronizeUserOKResponse;
            }
            catch(Exception e)
            {
                //Adding explaination and throwing again, shoud be catched in application that is using the helper
                throw new Exception("Syncronizeing of User failed, se inner exception", e);
            }

        }
    }
}
