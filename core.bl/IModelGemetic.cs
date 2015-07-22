using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace core.bl
{
    public interface IModelGemetic
    {
        event EventHandler showProgress;

        ContainerFunction container
        {
            set;
        }


     

        ContainerResult result
        {
            get;
        }

      

        Parametrs option
        {
            set;
        }

        ContainerResult intermediateResult
        {
            get;
        }


        void calculatePopulate(); 
    }
}
