using Observer.Class;
using Oserver.Observer;

using static System.Console;

namespace Oserver.Class.NotaGeradaServices
{
    class DbNotaService : IAposCriacaoNotaFiscal
    {
        public void Executa(Nota nota)
        {
            WriteLine("Essa nota foi gerada no backend");
        }
    }
}
