using CDA.Model;
using Commun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDA.Services.Implementation
{
    public interface IRegisterAnimalsServices
    {
        public OperationResult RegisterAnimals(DomainAnimalModel animal);
    }
}
