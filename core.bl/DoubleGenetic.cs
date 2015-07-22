using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace core.bl
{
   
    class DoubleGenetic : Genetic
    {
    
        //Вероятность мутации у особи
        private double _сhanceMutation;


        public DoubleGenetic(int countChr, int countGen, string type, ContainerFunction container, double сhance, double value)
            : base(countChr, countGen, type, container)
        {
           
            _сhanceMutation = сhance;

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

                children.gens[i] = Cross(Chr1.gens[i], Chr2.gens[i]) ;

                if (_typeSolution == staticConst.INTEGER_RESULT)
                {
                    children.gens[i] = Math.Round(children.gens[i], 0);
                }

            }

            return children;
        }

        private double Cross(double x, double y)
        {
            Int64 ix = BitConverter.DoubleToInt64Bits(x);
            Int64 iy = BitConverter.DoubleToInt64Bits(y);

            double res = BitConverter.Int64BitsToDouble(BitCross(ix, iy));

            if (_rnd.Next() % 2 == 0)
            {
                if (x * res < 0)
                {
                    res = -res;
                }
            }
            else
            {
                if (y * res < 0)
                {
                    res = -res;
                }
            }

            return res;
        }


        private  Int64 BitCross(Int64 x, Int64 y)
        {
            // Число бит, оставшиеся слева от точки пересечения хромосом
            int Count = _rnd.Next(62) + 1;
            Int64 mask = ~0;

            mask = mask << (64 - Count);

            return (x & mask) | (y & ~mask);
        }


        //Мутация
        private void makeMutation(Chromosome Chr1)
        {

            for (int i = 0; i < _countGenChromosome; i++)
            {
                UInt64 x = BitConverter.ToUInt64(BitConverter.GetBytes(Chr1.gens[i]), 0);

                UInt64 mask = 1;
                mask <<= _rnd.Next(63);
                x ^= mask;

                Chr1.gens[i]  = BitConverter.ToDouble(BitConverter.GetBytes(x), 0);



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
