using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace core.bl
{
    /*
     * Контейнер результата 
     * vector - вектор решения
     * matrix - матрица функции
     * fitness - фитнесс функция
     * realResult - реальный результат
     * realRestrict - значение реальных ограничений
     * time - время алгоритма
     */
    public class ContainerResult
    {

        public List<double> vector;
        public List<MatrixItem> matrix;
        public double fitness;
        public double realResult ;
        public List<double> realRestrict;
        public int time;
    
    }
}
