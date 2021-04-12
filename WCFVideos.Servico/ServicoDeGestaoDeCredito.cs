using WCFVideos.Contratos;

namespace WCFVideos.Servico
{
    public class ServicoDeGestaoDeCredito : IGestorDeCredito
    {
        public void AnalisarProposta(Proposta proposta)
        {
        }

        public void EfetivarProposta(Proposta proposta)
        {
        }

        public Proposta[] RecuperarPropostas(Status status)
        {
            return null;
        }

        public decimal RecuperarQuantidadeDeRecursoDisponivel()
        {
            return 1000.0M;
        }
    }
}
