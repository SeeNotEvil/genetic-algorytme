using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace core.bl
{
    public interface ISaveDocument
    {

        bool saveFile(String path, ContainerResult result, ContainerFunction containerFunction, Parametrs option);


    }

}
