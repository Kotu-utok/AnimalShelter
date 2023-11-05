using CDA.Model;
using CDA.Services.Implementation;
using Commun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDA.Services.Interface
{
    public class RegisterAnimalServices : IRegisterAnimalsServices
    {
        public RegisterAnimalServices() 
        { 
            
        }

        public OperationResult RegisterAnimals(DomainAnimalModel animal)
        {

            return new OperationResult();
        }
    }
}
