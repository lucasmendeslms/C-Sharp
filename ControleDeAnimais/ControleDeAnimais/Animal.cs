using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais
{
    public class Animal
    {
        public Animal(){}

        private String _name;

        public String Name
        {
            get { return _name; }
            set { _name = value;  }
        }

        private String _species;

        public String Species
        { //valores definidos na descrição do problema: Cachorro, gato, peixe
            get { return _species; }
            set
            {
                if(value == "Cachorro" || value == "Gato" || value == "Peixe")
                {
                    _species = value;
                }
                else
                {
                    _species = "Peixe";
                }
            }
        }
    }
}
