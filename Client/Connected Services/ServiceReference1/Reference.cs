﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/SOAPWebservice")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClassNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RoomField;
        
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
        public string ClassName {
            get {
                return this.ClassNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ClassNameField, value) != true)) {
                    this.ClassNameField = value;
                    this.RaisePropertyChanged("ClassName");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Room {
            get {
                return this.RoomField;
            }
            set {
                if ((this.RoomField.Equals(value) != true)) {
                    this.RoomField = value;
                    this.RaisePropertyChanged("Room");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddStudent", ReplyAction="http://tempuri.org/IService1/AddStudentResponse")]
        Client.ServiceReference1.Student AddStudent(string name, string classRoom, int rooom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddStudent", ReplyAction="http://tempuri.org/IService1/AddStudentResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Student> AddStudentAsync(string name, string classRoom, int rooom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FindStudent", ReplyAction="http://tempuri.org/IService1/FindStudentResponse")]
        Client.ServiceReference1.Student FindStudent(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FindStudent", ReplyAction="http://tempuri.org/IService1/FindStudentResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Student> FindStudentAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllStudents", ReplyAction="http://tempuri.org/IService1/GetAllStudentsResponse")]
        Client.ServiceReference1.Student[] GetAllStudents(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllStudents", ReplyAction="http://tempuri.org/IService1/GetAllStudentsResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Student[]> GetAllStudentsAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RemoveStudent", ReplyAction="http://tempuri.org/IService1/RemoveStudentResponse")]
        void RemoveStudent(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RemoveStudent", ReplyAction="http://tempuri.org/IService1/RemoveStudentResponse")]
        System.Threading.Tasks.Task RemoveStudentAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditStudent", ReplyAction="http://tempuri.org/IService1/EditStudentResponse")]
        void EditStudent(string name, string className, int rooom, string newName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditStudent", ReplyAction="http://tempuri.org/IService1/EditStudentResponse")]
        System.Threading.Tasks.Task EditStudentAsync(string name, string className, int rooom, string newName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Client.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Client.ServiceReference1.IService1>, Client.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client.ServiceReference1.Student AddStudent(string name, string classRoom, int rooom) {
            return base.Channel.AddStudent(name, classRoom, rooom);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Student> AddStudentAsync(string name, string classRoom, int rooom) {
            return base.Channel.AddStudentAsync(name, classRoom, rooom);
        }
        
        public Client.ServiceReference1.Student FindStudent(string name) {
            return base.Channel.FindStudent(name);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Student> FindStudentAsync(string name) {
            return base.Channel.FindStudentAsync(name);
        }
        
        public Client.ServiceReference1.Student[] GetAllStudents(string name) {
            return base.Channel.GetAllStudents(name);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Student[]> GetAllStudentsAsync(string name) {
            return base.Channel.GetAllStudentsAsync(name);
        }
        
        public void RemoveStudent(string name) {
            base.Channel.RemoveStudent(name);
        }
        
        public System.Threading.Tasks.Task RemoveStudentAsync(string name) {
            return base.Channel.RemoveStudentAsync(name);
        }
        
        public void EditStudent(string name, string className, int rooom, string newName) {
            base.Channel.EditStudent(name, className, rooom, newName);
        }
        
        public System.Threading.Tasks.Task EditStudentAsync(string name, string className, int rooom, string newName) {
            return base.Channel.EditStudentAsync(name, className, rooom, newName);
        }
    }
}
