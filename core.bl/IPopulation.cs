using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace core.bl
{
    public interface IPopulation
    {
        void init();
        void nextGeneration();
        ContainerResult bestChromosome();
    }
}
