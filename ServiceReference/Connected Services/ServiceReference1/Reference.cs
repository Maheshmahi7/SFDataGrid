﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ISampleService1")]
    public interface ISampleService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService1/GetData", ReplyAction="http://tempuri.org/ISampleService1/GetDataResponse")]
        string GetData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService1/GetData", ReplyAction="http://tempuri.org/ISampleService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService1/GetStudents", ReplyAction="http://tempuri.org/ISampleService1/GetStudentsResponse")]
        SampleDataContract.DataContract.Student[] GetStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService1/GetStudents", ReplyAction="http://tempuri.org/ISampleService1/GetStudentsResponse")]
        System.Threading.Tasks.Task<SampleDataContract.DataContract.Student[]> GetStudentsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISampleService1Channel : ServiceReference.ServiceReference1.ISampleService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SampleService1Client : System.ServiceModel.ClientBase<ServiceReference.ServiceReference1.ISampleService1>, ServiceReference.ServiceReference1.ISampleService1 {
        
        public SampleService1Client() {
        }
        
        public SampleService1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SampleService1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SampleService1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SampleService1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData() {
            return base.Channel.GetData();
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync() {
            return base.Channel.GetDataAsync();
        }
        
        public SampleDataContract.DataContract.Student[] GetStudents() {
            return base.Channel.GetStudents();
        }
        
        public System.Threading.Tasks.Task<SampleDataContract.DataContract.Student[]> GetStudentsAsync() {
            return base.Channel.GetStudentsAsync();
        }
    }
}