﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bullshit.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IWcfInterface")]
    public interface IWcfInterface {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfInterface/WriteToDbOneUser", ReplyAction="http://tempuri.org/IWcfInterface/WriteToDbOneUserResponse")]
        void WriteToDbOneUser(object user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfInterface/WriteToDbOneUser", ReplyAction="http://tempuri.org/IWcfInterface/WriteToDbOneUserResponse")]
        System.Threading.Tasks.Task WriteToDbOneUserAsync(object user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfInterface/ReadFromDbOneUser", ReplyAction="http://tempuri.org/IWcfInterface/ReadFromDbOneUserResponse")]
        object ReadFromDbOneUser();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfInterface/ReadFromDbOneUser", ReplyAction="http://tempuri.org/IWcfInterface/ReadFromDbOneUserResponse")]
        System.Threading.Tasks.Task<object> ReadFromDbOneUserAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfInterface/RetrunCurentStateOfProject", ReplyAction="http://tempuri.org/IWcfInterface/RetrunCurentStateOfProjectResponse")]
        object RetrunCurentStateOfProject(int ProjectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfInterface/RetrunCurentStateOfProject", ReplyAction="http://tempuri.org/IWcfInterface/RetrunCurentStateOfProjectResponse")]
        System.Threading.Tasks.Task<object> RetrunCurentStateOfProjectAsync(int ProjectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfInterface/IsLogined", ReplyAction="http://tempuri.org/IWcfInterface/IsLoginedResponse")]
        bool IsLogined(object user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfInterface/IsLogined", ReplyAction="http://tempuri.org/IWcfInterface/IsLoginedResponse")]
        System.Threading.Tasks.Task<bool> IsLoginedAsync(object user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWcfInterfaceChannel : Bullshit.ServiceReference1.IWcfInterface, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WcfInterfaceClient : System.ServiceModel.ClientBase<Bullshit.ServiceReference1.IWcfInterface>, Bullshit.ServiceReference1.IWcfInterface {
        
        public WcfInterfaceClient() {
        }
        
        public WcfInterfaceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WcfInterfaceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfInterfaceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfInterfaceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void WriteToDbOneUser(object user) {
            base.Channel.WriteToDbOneUser(user);
        }
        
        public System.Threading.Tasks.Task WriteToDbOneUserAsync(object user) {
            return base.Channel.WriteToDbOneUserAsync(user);
        }
        
        public object ReadFromDbOneUser() {
            return base.Channel.ReadFromDbOneUser();
        }
        
        public System.Threading.Tasks.Task<object> ReadFromDbOneUserAsync() {
            return base.Channel.ReadFromDbOneUserAsync();
        }
        
        public object RetrunCurentStateOfProject(int ProjectId) {
            return base.Channel.RetrunCurentStateOfProject(ProjectId);
        }
        
        public System.Threading.Tasks.Task<object> RetrunCurentStateOfProjectAsync(int ProjectId) {
            return base.Channel.RetrunCurentStateOfProjectAsync(ProjectId);
        }
        
        public bool IsLogined(object user) {
            return base.Channel.IsLogined(user);
        }
        
        public System.Threading.Tasks.Task<bool> IsLoginedAsync(object user) {
            return base.Channel.IsLoginedAsync(user);
        }
    }
}