using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace core.bl
{

 
    public class FabricFileDocument : IFabricFileDocument
    {
       
        private string DOC = "doc";


        public ISaveDocument getDocument(string type )
        {
            
            ISaveDocument model;

            if (type == DOC)
            {
                model = new SaveDocumentWord();
            
            }
            else
            {
                model = new SaveDocumentWord();
               
            }

            return model;
        }

    }
}
