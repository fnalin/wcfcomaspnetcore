﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceDeGestaoDeCredito
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Proposta", Namespace="http://schemas.datacontract.org/2004/07/WCFVideos.Contratos")]
    public partial class Proposta : object
    {
        
        private ServiceDeGestaoDeCredito.Cliente ClienteField;
        
        private System.DateTime DataField;
        
        private ServiceDeGestaoDeCredito.Emprestimo EmprestimoField;
        
        private int NumeroField;
        
        private ServiceDeGestaoDeCredito.Status StatusField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceDeGestaoDeCredito.Cliente Cliente
        {
            get
            {
                return this.ClienteField;
            }
            set
            {
                this.ClienteField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Data
        {
            get
            {
                return this.DataField;
            }
            set
            {
                this.DataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceDeGestaoDeCredito.Emprestimo Emprestimo
        {
            get
            {
                return this.EmprestimoField;
            }
            set
            {
                this.EmprestimoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Numero
        {
            get
            {
                return this.NumeroField;
            }
            set
            {
                this.NumeroField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceDeGestaoDeCredito.Status Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/WCFVideos.Contratos")]
    public partial class Cliente : object
    {
        
        private string EmpresaField;
        
        private int IdadeField;
        
        private string NomeField;
        
        private decimal SalarioField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Empresa
        {
            get
            {
                return this.EmpresaField;
            }
            set
            {
                this.EmpresaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Idade
        {
            get
            {
                return this.IdadeField;
            }
            set
            {
                this.IdadeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome
        {
            get
            {
                return this.NomeField;
            }
            set
            {
                this.NomeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Salario
        {
            get
            {
                return this.SalarioField;
            }
            set
            {
                this.SalarioField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Emprestimo", Namespace="http://schemas.datacontract.org/2004/07/WCFVideos.Contratos")]
    public partial class Emprestimo : object
    {
        
        private int QuantidadeDeParcelasField;
        
        private decimal TaxaDeJurosField;
        
        private decimal ValorField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int QuantidadeDeParcelas
        {
            get
            {
                return this.QuantidadeDeParcelasField;
            }
            set
            {
                this.QuantidadeDeParcelasField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal TaxaDeJuros
        {
            get
            {
                return this.TaxaDeJurosField;
            }
            set
            {
                this.TaxaDeJurosField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Valor
        {
            get
            {
                return this.ValorField;
            }
            set
            {
                this.ValorField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Status", Namespace="http://schemas.datacontract.org/2004/07/WCFVideos.Contratos")]
    public enum Status : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Aprovada = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Rejeitada = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        EmAnalise = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceDeGestaoDeCredito.IGestorDeCredito")]
    public interface IGestorDeCredito
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestorDeCredito/RecuperarQuantidadeDeRecursoDisponivel", ReplyAction="http://tempuri.org/IGestorDeCredito/RecuperarQuantidadeDeRecursoDisponivelRespons" +
            "e")]
        System.Threading.Tasks.Task<decimal> RecuperarQuantidadeDeRecursoDisponivelAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestorDeCredito/AnalisarProposta", ReplyAction="http://tempuri.org/IGestorDeCredito/AnalisarPropostaResponse")]
        System.Threading.Tasks.Task AnalisarPropostaAsync(ServiceDeGestaoDeCredito.Proposta proposta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestorDeCredito/EfetivarProposta", ReplyAction="http://tempuri.org/IGestorDeCredito/EfetivarPropostaResponse")]
        System.Threading.Tasks.Task EfetivarPropostaAsync(ServiceDeGestaoDeCredito.Proposta proposta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestorDeCredito/RecuperarPropostas", ReplyAction="http://tempuri.org/IGestorDeCredito/RecuperarPropostasResponse")]
        System.Threading.Tasks.Task<ServiceDeGestaoDeCredito.Proposta[]> RecuperarPropostasAsync(ServiceDeGestaoDeCredito.Status status);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IGestorDeCreditoChannel : ServiceDeGestaoDeCredito.IGestorDeCredito, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class GestorDeCreditoClient : System.ServiceModel.ClientBase<ServiceDeGestaoDeCredito.IGestorDeCredito>, ServiceDeGestaoDeCredito.IGestorDeCredito
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public GestorDeCreditoClient(EndpointConfiguration endpointConfiguration) : 
                base(GestorDeCreditoClient.GetBindingForEndpoint(endpointConfiguration), GestorDeCreditoClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public GestorDeCreditoClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(GestorDeCreditoClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public GestorDeCreditoClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(GestorDeCreditoClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public GestorDeCreditoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<decimal> RecuperarQuantidadeDeRecursoDisponivelAsync()
        {
            return base.Channel.RecuperarQuantidadeDeRecursoDisponivelAsync();
        }
        
        public System.Threading.Tasks.Task AnalisarPropostaAsync(ServiceDeGestaoDeCredito.Proposta proposta)
        {
            return base.Channel.AnalisarPropostaAsync(proposta);
        }
        
        public System.Threading.Tasks.Task EfetivarPropostaAsync(ServiceDeGestaoDeCredito.Proposta proposta)
        {
            return base.Channel.EfetivarPropostaAsync(proposta);
        }
        
        public System.Threading.Tasks.Task<ServiceDeGestaoDeCredito.Proposta[]> RecuperarPropostasAsync(ServiceDeGestaoDeCredito.Status status)
        {
            return base.Channel.RecuperarPropostasAsync(status);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_IGestorDeCredito))
            {
                System.ServiceModel.NetTcpBinding result = new System.ServiceModel.NetTcpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IGestorDeCredito))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_IGestorDeCredito))
            {
                return new System.ServiceModel.EndpointAddress("net.tcp://localhost:9876/srv");
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IGestorDeCredito))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:9877/srv");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            NetTcpBinding_IGestorDeCredito,
            
            BasicHttpBinding_IGestorDeCredito,
        }
    }
}
