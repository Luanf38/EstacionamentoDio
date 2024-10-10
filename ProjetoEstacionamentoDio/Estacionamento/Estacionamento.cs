
using ProjetoEstacionamentoDio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstacionamentoDio.Estacionamento
{
    internal class Estacionamento
    {
        List<CarroModel> carroModels = [];
        
        public void adicionarCarro(CarroModel carro)
        {
            carroModels.Add(carro);
            Console.WriteLine("Carro Adicionado Com Sucesso");
        }

        public void removerCarro(CarroModel carro)
        {
            carroModels.Remove(carro);
            Console.WriteLine("Carro Removido");
        }
    }
}
