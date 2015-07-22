using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using core.bl;

namespace genetic_algorytme
{
    public interface IView
    {
        event EventHandler calculateEvent;
        event EventHandler saveFileDocument;

        ContainerResult result
        {
            set;
            get;
        }

        String saveFile
        {
            get;
        }


        void showProgress(int length, int step);


        Parametrs option
        {
            get;
        }


        ContainerFunction containerFunction
        {
            get;
        }

      
        ContainerResult intermediateResult
        {
            set;
        }

        String saveFileExtension
        {
            get;
        }


    }
}
