using Observer.Class;
using Oserver.Observer;

using static System.Console;

namespace Oserver.Class.NotaGeradaServices
{
    class BackupNota : IAposCriacaoNotaFiscal
    {
        public void Executa(Nota nota)
        {
            WriteLine("Foi feito o backup dessa nota");
        }
    }
}
