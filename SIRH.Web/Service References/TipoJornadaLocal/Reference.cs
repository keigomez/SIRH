//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIRH.Web.TipoJornadaLocal {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TipoJornadaLocal.ICTipoJornadaService")]
    public interface ICTipoJornadaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICTipoJornadaService/RegistrarJornadaFuncionario", ReplyAction="http://tempuri.org/ICTipoJornadaService/RegistrarJornadaFuncionarioResponse")]
        SIRH.DTO.CBaseDTO[] RegistrarJornadaFuncionario(SIRH.DTO.CFuncionarioDTO funcionario, SIRH.DTO.CNombramientoDTO nombramiento, SIRH.DTO.CTipoJornadaDTO jornada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICTipoJornadaService/RegistrarJornadaFuncionario", ReplyAction="http://tempuri.org/ICTipoJornadaService/RegistrarJornadaFuncionarioResponse")]
        System.Threading.Tasks.Task<SIRH.DTO.CBaseDTO[]> RegistrarJornadaFuncionarioAsync(SIRH.DTO.CFuncionarioDTO funcionario, SIRH.DTO.CNombramientoDTO nombramiento, SIRH.DTO.CTipoJornadaDTO jornada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICTipoJornadaService/EditarJornadaFuncionario", ReplyAction="http://tempuri.org/ICTipoJornadaService/EditarJornadaFuncionarioResponse")]
        SIRH.DTO.CBaseDTO[] EditarJornadaFuncionario(SIRH.DTO.CTipoJornadaDTO jornada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICTipoJornadaService/EditarJornadaFuncionario", ReplyAction="http://tempuri.org/ICTipoJornadaService/EditarJornadaFuncionarioResponse")]
        System.Threading.Tasks.Task<SIRH.DTO.CBaseDTO[]> EditarJornadaFuncionarioAsync(SIRH.DTO.CTipoJornadaDTO jornada);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICTipoJornadaServiceChannel : SIRH.Web.TipoJornadaLocal.ICTipoJornadaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CTipoJornadaServiceClient : System.ServiceModel.ClientBase<SIRH.Web.TipoJornadaLocal.ICTipoJornadaService>, SIRH.Web.TipoJornadaLocal.ICTipoJornadaService {
        
        public CTipoJornadaServiceClient() {
        }
        
        public CTipoJornadaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CTipoJornadaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CTipoJornadaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CTipoJornadaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SIRH.DTO.CBaseDTO[] RegistrarJornadaFuncionario(SIRH.DTO.CFuncionarioDTO funcionario, SIRH.DTO.CNombramientoDTO nombramiento, SIRH.DTO.CTipoJornadaDTO jornada) {
            return base.Channel.RegistrarJornadaFuncionario(funcionario, nombramiento, jornada);
        }
        
        public System.Threading.Tasks.Task<SIRH.DTO.CBaseDTO[]> RegistrarJornadaFuncionarioAsync(SIRH.DTO.CFuncionarioDTO funcionario, SIRH.DTO.CNombramientoDTO nombramiento, SIRH.DTO.CTipoJornadaDTO jornada) {
            return base.Channel.RegistrarJornadaFuncionarioAsync(funcionario, nombramiento, jornada);
        }
        
        public SIRH.DTO.CBaseDTO[] EditarJornadaFuncionario(SIRH.DTO.CTipoJornadaDTO jornada) {
            return base.Channel.EditarJornadaFuncionario(jornada);
        }
        
        public System.Threading.Tasks.Task<SIRH.DTO.CBaseDTO[]> EditarJornadaFuncionarioAsync(SIRH.DTO.CTipoJornadaDTO jornada) {
            return base.Channel.EditarJornadaFuncionarioAsync(jornada);
        }
    }
}
