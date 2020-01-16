﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeClient.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/EmployeeService")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MobileField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public string Mobile {
            get {
                return this.MobileField;
            }
            set {
                if ((object.ReferenceEquals(this.MobileField, value) != true)) {
                    this.MobileField = value;
                    this.RaisePropertyChanged("Mobile");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IEmployeeRepository")]
    public interface IEmployeeRepository {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRepository/GetEmployees", ReplyAction="http://tempuri.org/IEmployeeRepository/GetEmployeesResponse")]
        EmployeeClient.ServiceReference.Employee[] GetEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRepository/GetEmployees", ReplyAction="http://tempuri.org/IEmployeeRepository/GetEmployeesResponse")]
        System.Threading.Tasks.Task<EmployeeClient.ServiceReference.Employee[]> GetEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRepository/GetEmployeeId", ReplyAction="http://tempuri.org/IEmployeeRepository/GetEmployeeIdResponse")]
        EmployeeClient.ServiceReference.Employee GetEmployeeId(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRepository/GetEmployeeId", ReplyAction="http://tempuri.org/IEmployeeRepository/GetEmployeeIdResponse")]
        System.Threading.Tasks.Task<EmployeeClient.ServiceReference.Employee> GetEmployeeIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRepository/SaveEmployee", ReplyAction="http://tempuri.org/IEmployeeRepository/SaveEmployeeResponse")]
        EmployeeClient.ServiceReference.Employee SaveEmployee(EmployeeClient.ServiceReference.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRepository/SaveEmployee", ReplyAction="http://tempuri.org/IEmployeeRepository/SaveEmployeeResponse")]
        System.Threading.Tasks.Task<EmployeeClient.ServiceReference.Employee> SaveEmployeeAsync(EmployeeClient.ServiceReference.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRepository/UpdateEmployee", ReplyAction="http://tempuri.org/IEmployeeRepository/UpdateEmployeeResponse")]
        EmployeeClient.ServiceReference.Employee UpdateEmployee(EmployeeClient.ServiceReference.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRepository/UpdateEmployee", ReplyAction="http://tempuri.org/IEmployeeRepository/UpdateEmployeeResponse")]
        System.Threading.Tasks.Task<EmployeeClient.ServiceReference.Employee> UpdateEmployeeAsync(EmployeeClient.ServiceReference.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRepository/DeleteEmployee", ReplyAction="http://tempuri.org/IEmployeeRepository/DeleteEmployeeResponse")]
        EmployeeClient.ServiceReference.Employee DeleteEmployee(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRepository/DeleteEmployee", ReplyAction="http://tempuri.org/IEmployeeRepository/DeleteEmployeeResponse")]
        System.Threading.Tasks.Task<EmployeeClient.ServiceReference.Employee> DeleteEmployeeAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeRepositoryChannel : EmployeeClient.ServiceReference.IEmployeeRepository, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeRepositoryClient : System.ServiceModel.ClientBase<EmployeeClient.ServiceReference.IEmployeeRepository>, EmployeeClient.ServiceReference.IEmployeeRepository {
        
        public EmployeeRepositoryClient() {
        }
        
        public EmployeeRepositoryClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeRepositoryClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeRepositoryClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeRepositoryClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public EmployeeClient.ServiceReference.Employee[] GetEmployees() {
            return base.Channel.GetEmployees();
        }
        
        public System.Threading.Tasks.Task<EmployeeClient.ServiceReference.Employee[]> GetEmployeesAsync() {
            return base.Channel.GetEmployeesAsync();
        }
        
        public EmployeeClient.ServiceReference.Employee GetEmployeeId(int id) {
            return base.Channel.GetEmployeeId(id);
        }
        
        public System.Threading.Tasks.Task<EmployeeClient.ServiceReference.Employee> GetEmployeeIdAsync(int id) {
            return base.Channel.GetEmployeeIdAsync(id);
        }
        
        public EmployeeClient.ServiceReference.Employee SaveEmployee(EmployeeClient.ServiceReference.Employee employee) {
            return base.Channel.SaveEmployee(employee);
        }
        
        public System.Threading.Tasks.Task<EmployeeClient.ServiceReference.Employee> SaveEmployeeAsync(EmployeeClient.ServiceReference.Employee employee) {
            return base.Channel.SaveEmployeeAsync(employee);
        }
        
        public EmployeeClient.ServiceReference.Employee UpdateEmployee(EmployeeClient.ServiceReference.Employee employee) {
            return base.Channel.UpdateEmployee(employee);
        }
        
        public System.Threading.Tasks.Task<EmployeeClient.ServiceReference.Employee> UpdateEmployeeAsync(EmployeeClient.ServiceReference.Employee employee) {
            return base.Channel.UpdateEmployeeAsync(employee);
        }
        
        public EmployeeClient.ServiceReference.Employee DeleteEmployee(int id) {
            return base.Channel.DeleteEmployee(id);
        }
        
        public System.Threading.Tasks.Task<EmployeeClient.ServiceReference.Employee> DeleteEmployeeAsync(int id) {
            return base.Channel.DeleteEmployeeAsync(id);
        }
    }
}
