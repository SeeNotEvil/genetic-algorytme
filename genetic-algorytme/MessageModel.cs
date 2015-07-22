using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace genetic_algorytme
{

  


    class MessageModel : IMessageModel
    {

        //private string ERROR = "Файл используется другим процессом!!!" ;
        private string SUCCESS = "Файл успешно сохранен!!!";

        public void showSavedFile()
        {
            MessageBox.Show(SUCCESS);
        }



    }
}
