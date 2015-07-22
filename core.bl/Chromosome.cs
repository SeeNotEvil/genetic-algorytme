using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace core.bl
{
    /*
     * Хромосома 
     */
    class Chromosome
    {
        //Кол - во генов
        public int countGen;
        //Массив генов
        public double[] gens;
        //Фитнесс функция
        public double fitness;
        //Рандомайзер 
        Random rnd;

        //Конструктор хромосомы
        public Chromosome(int count, Random random)
        {
            rnd = random;
            countGen = count;
            gens = new double[countGen];
        }

        //Инициализация случайными числами генов (целые числа)
        public Chromosome initIntRandom(int limit)
        {
            for (int i = 0; i < countGen; i++)
            {
                gens[i] = rnd.Next(limit);
            }
            return this;
        }

        //Инициализация случайными числами генов (дробные числа)
        public Chromosome initRandom()
        {
            for (int i = 0; i < countGen; i++)
            {
                gens[i] = rnd.NextDouble();
            }
            return this;
        }

        //Создать клон хромососы
        public Chromosome makeClone()
        {

            Chromosome clone = new Chromosome(countGen, rnd);
            for (int i = 0; i < countGen; i++)
            {
                clone.gens[i] = gens[i];
            }
            clone.fitness = fitness;
            return clone;
        }
    }
}
