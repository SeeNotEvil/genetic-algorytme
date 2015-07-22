using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace core.bl
{
    /*
     * Функция
     */
    public class ContainerFunction
    {
        /*
         *   matrix - Матрица функции
         *   fitness - Функция приспособленности
         *   cursor - min - max - значение целевой функции
         */
        public List<MatrixItem> matrix ;
        public List<double> fitness;
        public String cursor;

        public ContainerFunction()
        {
            matrix = new List<MatrixItem>();
            fitness = new List<double>();
            cursor = staticConst.SIGNMAX;
        }

    }
}
