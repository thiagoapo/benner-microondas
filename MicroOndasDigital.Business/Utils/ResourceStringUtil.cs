using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOndasDigital.Business.Utils
{
    public static class ResourceStringUtil
    {
        public const string BandejaNula = "Informe o que vai na bandeja.";
        public const string ArquivoNaoEncontrado = "Arquivo não encontrado no caminho informado.";
        public const string ArquivoBandejaNula = "Informe dentro do [conteúdo do arquivo de texto] o que vai na bandeja.";
        public const string TempoCozimentoNulo = "Informe o tempo de cozimento (1 seg a 2 min).";
        public const string TempoCozimentoFracionado = "O tempo de cozimento informado não pode ser fracionado.";
        public const string TempoCozimentoForaIntervalo = "O tempo de cozimento está fora do intervalo permitido (1 seg a 2 min)";
        public const string PotenciaForaIntervalo = "A potência está fora do intervalo permitido (1 a 10).";
        public const string PotenciaFracionada = "A potência informada não pode ser fracionada.";

        public const string ProgramaNomeNulo = "Informe o nome do programa.";
        public const string ProgramaTagListaNula = "Informe pelo menos uma tag de compatibilidade.";
        public const string ProgramaPontuacaoNula = "Informe a pontuação a ser usada pelo programa.";
        public const string ProgramaAlimentoNaoCompativel = "O alimento informado na bandeja não é compatível com o programa escolhido.";

        public const string SelecionePrograma = "Selecione um programa na lista abaixo.";
        public const string SelecioneProgramaCustomizado = "Selecione um programa customizado na lista abaixo.";
    }
}
