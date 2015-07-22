using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace core.bl
{
    class ClassicGenetic : Genetic
    {
        //Величина мутации
        private double _valueMutation;

        //Вероятность мутации у особи
        private double _сhanceMutation;
        

        public ClassicGenetic(int countChr, int countGen, string type, ContainerFunction container, double сhance, double value)
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
        private Chromosome[] makeLinearCross(Chromosome Chr1, Chromosome Chr2)
        {
            Chromosome[] childrens = new Chromosome[3] ;
            childrens[0] = new Chromosome(_countGenChromosome, _rnd);
            childrens[1] = new Chromosome(_countGenChromosome, _rnd);
            childrens[2] = new Chromosome(_countGenChromosome, _rnd);



            for (int i = 0; i < _countGenChromosome; i++ )
            {
                childrens[0].gens[i] = (Chr1.gens[i] + Chr2.gens[i]) / 2;
                childrens[1].gens[i] = (3 * Chr1.gens[i] + Chr2.gens[i]) / 2;
                childrens[2].gens[i] = (-Chr1.gens[i] + 3 * Chr2.gens[i]) / 2;

                if (childrens[0].gens[i] <= 0)
                    childrens[0].gens[i] = 0;

                if (childrens[1].gens[i] <= 0)
                    childrens[1].gens[i] = 0;

                if (childrens[2].gens[i] <= 0)
                    childrens[2].gens[i] = 0;

                if (_typeSolution == staticConst.INTEGER_RESULT)
                {
                    childrens[0].gens[i] = Math.Round(childrens[0].gens[i], 0);
                    childrens[1].gens[i] = Math.Round(childrens[1].gens[i], 0);
                    childrens[2].gens[i] = Math.Round(childrens[2].gens[i], 0);
                }


            }
            

            calculateFitness(childrens[0]);
            calculateFitness(childrens[1]);
            calculateFitness(childrens[2]);


            childrens = sort(childrens);


            return childrens;
        }

        /*
         * Cортировка хромосом по фитнесс функции
         */
        private Chromosome[] sort(Chromosome[] massive)
        {
            int len = massive.Length ;


            for (int i = 0; i < len - 1; i++)
            {
                int max = i;


                for (int j = i + 1; j < len; j++)
                {
                    if (massive[j].fitness > massive[max].fitness)
                        max = j;
                }

                if (max != i)
                {
                    Chromosome container = massive[i];
                    massive[i] = massive[max];
                    massive[max] = container;
                }

            }

            return massive;

        }




        //Мутация
        private void makeMutation(Chromosome Chr1)
        {
            int num1 = _rnd.Next(_countChromosome - 1); int num2 = _rnd.Next(_countChromosome - 1);
            double delta = 0;

            for (int i = 0; i < _countGenChromosome; i++)
            {
               
                delta = _valueMutation * (_arrayChromosomes[num1].gens[i] - _arrayChromosomes[num2].gens[i]);
               
                if (_typeSolution == staticConst.INTEGER_RESULT)
                {
                   delta = Math.Round(delta, 0);
                }


                Chr1.gens[i] = Chr1.gens[i] + delta;

                if (Chr1.gens[i] <= 0)
                    Chr1.gens[i] = 0;
            }


        }


        //Отбор турниром
        private Chromosome tournament(int k)
        {
            int R1 = _rnd.Next(_countChromosome - 1);
            int R2 = 0;
            Chromosome winner = _arrayChromosomes[R1];


            for (int i = 1; i <= k; i++)
            {
                R2 = _rnd.Next(_countChromosome - 1);

                if (_arrayChromosomes[R2].fitness > winner.fitness)
                {
                    winner = _arrayChromosomes[R2];

                }


            }

            return winner;

        }

        //Сменить поколение
        public override void nextGeneration()
        {

            //Создаем новый массив
            Chromosome[] childChromosomes = new Chromosome[_countChromosome];
            Chromosome[] parentChromosomes = new Chromosome[_countChromosome];
            Chromosome[] childrens;
            int parent1;
            int parent2;

            //Выбираем родителей
            for (int i = 0; i < _countChromosome; i++)
            {
                //Турнирный выбор
                parentChromosomes[i] = tournament(10);

            }

            int count = _countChromosome / 2;
            //Дети
            for (int i = 0; i < count; i++)
            {

                parent1 = _rnd.Next(_countChromosome - 1);
                parent2 = _rnd.Next(_countChromosome - 1);

                childrens = makeLinearCross(parentChromosomes[parent1], parentChromosomes[parent2]);

                childChromosomes[i * 2] = childrens[0];

                if((i*2 + 1) <=  _countChromosome)
                     childChromosomes[i*2 + 1] = childrens[1] ;

                //Мутация в pM процентах
                double num = _rnd.NextDouble();

                if (num <= _сhanceMutation)
                    makeMutation(childChromosomes[i]);


                calculateFitness(childChromosomes[i]);
            }


            //Меняем поколение
            _arrayChromosomes = childChromosomes;

        }

    }
}
