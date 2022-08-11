﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace crud.ws {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ws.grud_wsSoap")]
    public interface grud_wsSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Insertar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool Insertar(string rut, string nombre, string apellido, int edad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Insertar", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> InsertarAsync(string rut, string nombre, string apellido, int edad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/listar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/listar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> listarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet buscar(string rut);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> buscarAsync(string rut);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool Eliminar(string rut);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> EliminarAsync(string rut);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/update", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool update(string rut, string nombre, string apellido, string edad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/update", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> updateAsync(string rut, string nombre, string apellido, string edad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExistePersona", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool ExistePersona(string rutCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExistePersona", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> ExistePersonaAsync(string rutCliente);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface grud_wsSoapChannel : crud.ws.grud_wsSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class grud_wsSoapClient : System.ServiceModel.ClientBase<crud.ws.grud_wsSoap>, crud.ws.grud_wsSoap {
        
        public grud_wsSoapClient() {
        }
        
        public grud_wsSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public grud_wsSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public grud_wsSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public grud_wsSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Insertar(string rut, string nombre, string apellido, int edad) {
            return base.Channel.Insertar(rut, nombre, apellido, edad);
        }
        
        public System.Threading.Tasks.Task<bool> InsertarAsync(string rut, string nombre, string apellido, int edad) {
            return base.Channel.InsertarAsync(rut, nombre, apellido, edad);
        }
        
        public System.Data.DataSet listar() {
            return base.Channel.listar();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> listarAsync() {
            return base.Channel.listarAsync();
        }
        
        public System.Data.DataSet buscar(string rut) {
            return base.Channel.buscar(rut);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> buscarAsync(string rut) {
            return base.Channel.buscarAsync(rut);
        }
        
        public bool Eliminar(string rut) {
            return base.Channel.Eliminar(rut);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarAsync(string rut) {
            return base.Channel.EliminarAsync(rut);
        }
        
        public bool update(string rut, string nombre, string apellido, string edad) {
            return base.Channel.update(rut, nombre, apellido, edad);
        }
        
        public System.Threading.Tasks.Task<bool> updateAsync(string rut, string nombre, string apellido, string edad) {
            return base.Channel.updateAsync(rut, nombre, apellido, edad);
        }
        
        public bool ExistePersona(string rutCliente) {
            return base.Channel.ExistePersona(rutCliente);
        }
        
        public System.Threading.Tasks.Task<bool> ExistePersonaAsync(string rutCliente) {
            return base.Channel.ExistePersonaAsync(rutCliente);
        }
    }
}