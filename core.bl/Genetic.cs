using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace core.bl
{
    abstract class Genetic : IPopulation
    {

        //Кол - во хромосом в популяции
        protected int _countChromosome;
        //Массив текущей популяции хромосом
        protected Chromosome[] _arrayChromosomes;
        //Тип решения
        protected String _typeSolution;
        //Рандомайзер 
        protected Random _rnd = new Random();
        //Кол - во генов в хромосоме
        protected int _countGenChromosome;
        protected ContainerFunction _containerFunction;

        public Genetic(int countChr, int countGen, string type, ContainerFunction container)
        {
            _countChromosome = countChr;
            _countGenChromosome = countGen;
            _arrayChromosomes = new Chromosome[_countChromosome];
            _typeSolution = type;
            _containerFunction = container;

        }

        //Вычислить полную выживаемость популяции
        protected double calculateSumFitness()
        {
            double sum = 0;
            for (int i = 0; i < _countChromosome; i++)
            {
                sum += _arrayChromosomes[i].fitness;
            }
            return sum;
        }

        protected void calculateFitness(Chromosome Chr)
        {
            calculateFitness(Chr, false);
        }



        //Фитнесс функция
        protected void calculateFitness(Chromosome Chr, bool write)
        {

            double M;
            double straf = 0;
            double result = 0;
            result = calculateTargetFunction(Chr);

            foreach (MatrixItem item in _containerFunction.matrix)
            {
                M = 0;
                M = calculateRestrictFunction(item, Chr);

                //ТРИ СИТУАЦИИ 
                if (item.Sign == staticConst.SIGNEQUALLY)
                {
                    double delta = (M - item.restriction);
                    straf += straf + result * (delta / item.restriction);
                }
                else if (item.Sign == staticConst.SIGNLESSEQUALLY)
                {
                    if (M > item.restriction)
                    {
                        straf += straf + result * (M / item.restriction);

                    }
                }
                else if (item.Sign == staticConst.SIGNMOREQUALLY)
                {
                    if (M < item.restriction)
                    {
                        straf += straf + result * (item.restriction / M);

                    }

                }

            }

            Chr.fitness = result - straf;
        }


        //Инициализируем
        public abstract void init();
    

        //Следующее поколение
        public abstract void nextGeneration();

        //Вычисления значения ограничения
        protected double calculateRestrictFunction(MatrixItem item, Chromosome Chr)
        {
            double value = 0;
            for (int i = 0; i < _countGenChromosome; i++)
            {
                value += item.items[i] * Chr.gens[i];
            }

            return value;
        }


        //Целевая функция
        protected double calculateTargetFunction(Chromosome Chr)
        {
            double result = 0;
            double sign = (_containerFunction.cursor == staticConst.SIGNMIN) ? -1 : 1;

            for (int i = 0; i < _countGenChromosome; i++)
            {
                result += sign * _containerFunction.fitness[i] * Chr.gens[i];
            }

            return result;
        }


        //Вывод лучшей хромосомы
        public ContainerResult bestChromosome()
        {
            ContainerResult result = new ContainerResult();
            Chromosome bestChromosome = new Chromosome(_countGenChromosome, _rnd);

            for (int i = 0; i < _countChromosome; i++)
            {
                if (_arrayChromosomes[i].fitness > bestChromosome.fitness)
                {
                    bestChromosome = _arrayChromosomes[i];
                }

            }

            calculateFitness(bestChromosome, true);



            result.vector = new List<double>();

            for (int i = 0; i < _countGenChromosome; i++)
            {

                result.vector.Add(bestChromosome.gens[i]);

            }


            result.fitness = bestChromosome.fitness;
            result.realResult = calculateTargetFunction(bestChromosome);

            double sign = (_containerFunction.cursor == staticConst.SIGNMIN) ? -1 : 1;
            result.realResult = result.realResult * sign;

            result.realRestrict = new List<double>();
            foreach (MatrixItem item in _containerFunction.matrix)
            {

                result.realRestrict.Add(calculateRestrictFunction(item, bestChromosome));
            }

            return result;
        }


    }
}
