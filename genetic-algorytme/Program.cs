using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using core.bl;

namespace genetic_algorytme
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form = new Form1();
            ModelGemetic model = new ModelGemetic();
            IFabricFileDocument modelSave = new FabricFileDocument();
            IMessageModel modelMessage = new MessageModel();
            MainPresenter presenter = new MainPresenter(form, model, modelSave, modelMessage);


            Application.Run(form);
        }
    }
}
