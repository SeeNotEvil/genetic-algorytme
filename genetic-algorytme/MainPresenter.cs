using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using core.bl ;

namespace genetic_algorytme

{
    public class MainPresenter
    {
        private readonly IView _view;
        private readonly IModelGemetic _model;
        private readonly IFabricFileDocument _modelSave;
        private readonly IMessageModel _modelMessage;

        public MainPresenter(IView view, IModelGemetic model, IFabricFileDocument modelSave, IMessageModel modelMessage)
        {
            _view = view ;
            _model = model ;
            _modelSave = modelSave;
            _modelMessage = modelMessage;
            _view.calculateEvent +=new EventHandler(_view_calculateEvent);
            _view.saveFileDocument +=new EventHandler(_view_saveFileDocument);
            _model.showProgress += new EventHandler(_model_showProgress);
        }


        private void _model_showProgress(object sender, EventArgs e)
        {

            ProgressBarEventArgs progress = (ProgressBarEventArgs)e;
            _view.showProgress(progress.length, progress.step);
        }


        private void _view_saveFileDocument(object sender, EventArgs e)
        {
            ISaveDocument document = _modelSave.getDocument(_view.saveFileExtension);
            document.saveFile(_view.saveFile, _model.result, _view.containerFunction, _view.option);
            _modelMessage.showSavedFile();

        }


        private void _view_calculateEvent(object sender, EventArgs e)
        {

            if ((_model.container = _view.containerFunction) == null)
                return;

            if ((_model.option = _view.option) == null)
                return;
            
            _model.calculatePopulate();
            
            _view.intermediateResult = _model.intermediateResult;
            _view.result = _model.result;

        }


    }

   
}
