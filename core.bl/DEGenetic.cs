using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace core.bl
{
    class DEGenetic : Genetic
    {
        //Величина мутации
        private double _valueMutation;

        //Вероятность мутации у особи
        private double _сhanceMutation;


        public DEGenetic(int countChr, int countGen, string type, ContainerFunction container, double сhance, double value)
            : base(countChr, countGen, type, container)
        {
           
            _сhanceMutation = сhance;
            _valueMutation = value;

        }


        //Инициализируем
        public override void init()
        {
            for (int i = 0; i < _countChromosome; i++)
            {
                if (_typeSolution == staticConst.INTEGER_RESULT)
                {
                    _arrayChromosomes[i] = new Chromosome(_countGenChromosome, _rnd).initIntRandom(5);
                }
                else
                {
                    _arrayChromosomes[i] = new Chromosome(_countGenChromosome, _rnd).initRandom();
                }

                calculateFitness(_arrayChromosomes[i]);
            }

        }

        //Скрещивание
        private Chromosome makeCross(Chromosome Chr1, Chromosome Chr2)
        {
            Chromosome children = new Chromosome(_countGenChromosome, _rnd);


            for (int i = 0; i < _countGenChromosome; i++)
            {
                if (_rnd.NextDouble() <= _сhanceMutation)
                {
                    children.gens[i] = Chr2.gens[i];
                }
                else
                {
                    children.gens[i] = Chr1.gens[i];
                }


            }


            
            return children;
        }

        //Мутация
        private void makeMutation(Chromosome Chr1)
        {
            int num1 = _rnd.Next(_countChromosome - 1); int num2 = _rnd.Next(_countChromosome - 1);
            double delta = 0;

            for (int i = 0; i < _countGenChromosome; i++)
            {
                if (_typeSolution == staticConst.INTEGER_RESULT)
                {
                    delta = Math.Round((_valueMutation * (_arrayChromosomes[num1].gens[i] - _arrayChromosomes[num2].gens[i])), 0);
                }
                else
                {
                    delta = _valueMutation * (_arrayChromosomes[num1].gens[i] - _arrayChromosomes[num2].gens[i]);
                }

                Chr1.gens[i] = Chr1.gens[i] + delta;

                if (Chr1.gens[i] <= 0)
                    Chr1.gens[i] = 0;
            }


        }


        //Сменить поколение
        public override void nextGeneration()
        {

            //Выбираем случайную хромосому
            int num1 = _rnd.Next(_countChromosome - 1);
            int num2 = _rnd.Next(_countChromosome - 1);

            //Клонируем
            Chromosome parent2 = _arrayChromosomes[num2].makeClone();
            Chromosome parent1 = _arrayChromosomes[num1];

            //Выполняем мутацию над ней
            makeMutation(parent2);
            calculateFitness(parent2);

            //Кросовер
            Chromosome children = makeCross(parent1, parent2);
            calculateFitness(children);

            //Сравниваем потомка и родителя
            if (children.fitness > parent1.fitness)
                _arrayChromosomes[num1] = children;



        }
    }
}
