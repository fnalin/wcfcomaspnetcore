using System.ServiceModel;

namespace WCFVideos.Contratos
{
    [ServiceContract]
    public interface IGestorDeCredito
    {
        [OperationContract]
        decimal RecuperarQuantidadeDeRecursoDisponivel();
        [OperationContract]
        void AnalisarProposta(Proposta proposta);
        [OperationContract]
        void EfetivarProposta(Proposta proposta);
        [OperationContract]
        Proposta[] RecuperarPropostas(Status status);
    }
}
