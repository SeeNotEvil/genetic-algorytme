using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace core.bl
{


    public class ProgressBarEventArgs : EventArgs
    {

        private int _length;
        private int _step;


        public ProgressBarEventArgs(int length)
        {
            _length = length;
 
        }

        public int step
        {
            get
            {
                return _step;
            }
            set
            {
                _step = value;
            }
        }



        public int length
        {
            get 
            { 
                return _length; 
            }
        }
    }

    public class ModelGemetic : IModelGemetic
    {
        //Контейнер хранящий значение функции
        private ContainerFunction _containerFunction;
        private ContainerResult _result;
        private IPopulation populate;
        private ContainerResult _intermediateResult;

        //Контейнер хранящий настройки алгоримта
        private Parametrs _option;

        public event EventHandler showProgress;

        public ContainerResult result
        {
            get
            {
                return _result;
            }         
                
        }

    

        public ContainerResult intermediateResult
        {
            get
            {
                return _intermediateResult;
            }

        }

       
        public ContainerFunction container
        {
            set
            {
                _containerFunction = value ;
            }
                
        }

       
        public Parametrs option
        {
            set
            {
                _option = value;
            }


        }

  

        public void calculatePopulate()
        {
            DateTime startDate = DateTime.Now;

            if (_option.typeAlgoritme == staticConst.DIFFERENCIAL_GENETIC_ALGORITME)
            {
                populate = new DEGenetic(_option.countPopulate, _option.countValueVariable, _option.turnInteger, _containerFunction, _option.сhanceMutation, _option.valueMutation);
            }
            else if (_option.typeAlgoritme == staticConst.CLASSIC_ALGORITME)
            {
                populate = new ClassicGenetic(_option.countPopulate, _option.countValueVariable, _option.turnInteger, _containerFunction, _option.сhanceMutation, _option.valueMutation);
            }
            else if (_option.typeAlgoritme == staticConst.CLASSIC_ALGORITME2)
            {
                populate = new ClassicGenetic2(_option.countPopulate, _option.countValueVariable, _option.turnInteger, _containerFunction, _option.сhanceMutation, _option.valueMutation, _option.B);
            }
            else if (_option.typeAlgoritme == staticConst.DOUBLE_ALGORITM)
            {
                populate = new DoubleGenetic(_option.countPopulate, _option.countValueVariable, _option.turnInteger, _containerFunction, _option.сhanceMutation, _option.valueMutation);
            }

            populate.init();

            _intermediateResult = populate.bestChromosome();


            ProgressBarEventArgs eventsArg = new ProgressBarEventArgs(_option.countGeneration);
            for (int i = 1; i <= _option.countGeneration; i++)
            {
                populate.nextGeneration();

                if (showProgress != null)
                {
                    eventsArg.step = i;
                    showProgress(this, eventsArg);

                }
            }

            DateTime stopDate = DateTime.Now;

            TimeSpan interval =  stopDate - startDate;
          

            _result = populate.bestChromosome();
            _result.time = interval.Milliseconds;
        }

        
    }
}
