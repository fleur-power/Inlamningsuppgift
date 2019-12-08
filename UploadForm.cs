using System;
using System.Collections.Generic;
using System.Text;

namespace Svar_9
{
    public class UploadForm
    {
        // private ImageDatabase db = new ImageDatabase();
        private readonly IImageDatabase db;
        UploadForm(IImageDatabase apa)
        {
            db = apa;
        }
        public void UploadImage(Image im) { db.Upload(im); }
    }
}
