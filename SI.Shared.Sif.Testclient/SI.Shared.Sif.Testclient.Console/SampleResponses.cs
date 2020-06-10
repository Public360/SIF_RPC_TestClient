using SI.Shared.Sif.Testclient.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SI.Shared.Sif.Testclient.Common.Entities
{
    public class CreateOrUpdateUserAndContactResponse
    {
        public SynchronizeContactPersonOKResponse synchronizeContactPersonOKResponse { get; set; }
        public SynchronizeUserOKResponse synchronizeUserOKResponset { get; set; }
    }

    public class CreateDocumentWithFileUploadResponse
    {
        public UploadOKResponse uploadOKResponse { get; set; }
        public CreateDocumentOKResponse createDocumentOKResponse { get; set; }
    }
}
