﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _002_WebForms.Wcf {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StructuralObject", Namespace="http://schemas.datacontract.org/2004/07/System.Data.Objects.DataClasses", IsReference=true)]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(_002_WebForms.Wcf.EntityObject))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(_002_WebForms.Wcf.Customer))]
    public partial class StructuralObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityObject", Namespace="http://schemas.datacontract.org/2004/07/System.Data.Objects.DataClasses", IsReference=true)]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(_002_WebForms.Wcf.Customer))]
    public partial class EntityObject : _002_WebForms.Wcf.StructuralObject {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private _002_WebForms.Wcf.EntityKey EntityKeyField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public _002_WebForms.Wcf.EntityKey EntityKey {
            get {
                return this.EntityKeyField;
            }
            set {
                if ((object.ReferenceEquals(this.EntityKeyField, value) != true)) {
                    this.EntityKeyField = value;
                    this.RaisePropertyChanged("EntityKey");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/_001_WCFService.Model", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Customer : _002_WebForms.Wcf.EntityObject {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MiddleNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ModifiedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool NameStyleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordHashField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordSaltField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SalesPersonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SuffixField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid rowguidField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CompanyName {
            get {
                return this.CompanyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyNameField, value) != true)) {
                    this.CompanyNameField = value;
                    this.RaisePropertyChanged("CompanyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerID {
            get {
                return this.CustomerIDField;
            }
            set {
                if ((this.CustomerIDField.Equals(value) != true)) {
                    this.CustomerIDField = value;
                    this.RaisePropertyChanged("CustomerID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmailAddress {
            get {
                return this.EmailAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailAddressField, value) != true)) {
                    this.EmailAddressField = value;
                    this.RaisePropertyChanged("EmailAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MiddleName {
            get {
                return this.MiddleNameField;
            }
            set {
                if ((object.ReferenceEquals(this.MiddleNameField, value) != true)) {
                    this.MiddleNameField = value;
                    this.RaisePropertyChanged("MiddleName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ModifiedDate {
            get {
                return this.ModifiedDateField;
            }
            set {
                if ((this.ModifiedDateField.Equals(value) != true)) {
                    this.ModifiedDateField = value;
                    this.RaisePropertyChanged("ModifiedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool NameStyle {
            get {
                return this.NameStyleField;
            }
            set {
                if ((this.NameStyleField.Equals(value) != true)) {
                    this.NameStyleField = value;
                    this.RaisePropertyChanged("NameStyle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PasswordHash {
            get {
                return this.PasswordHashField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordHashField, value) != true)) {
                    this.PasswordHashField = value;
                    this.RaisePropertyChanged("PasswordHash");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PasswordSalt {
            get {
                return this.PasswordSaltField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordSaltField, value) != true)) {
                    this.PasswordSaltField = value;
                    this.RaisePropertyChanged("PasswordSalt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SalesPerson {
            get {
                return this.SalesPersonField;
            }
            set {
                if ((object.ReferenceEquals(this.SalesPersonField, value) != true)) {
                    this.SalesPersonField = value;
                    this.RaisePropertyChanged("SalesPerson");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Suffix {
            get {
                return this.SuffixField;
            }
            set {
                if ((object.ReferenceEquals(this.SuffixField, value) != true)) {
                    this.SuffixField = value;
                    this.RaisePropertyChanged("Suffix");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid rowguid {
            get {
                return this.rowguidField;
            }
            set {
                if ((this.rowguidField.Equals(value) != true)) {
                    this.rowguidField = value;
                    this.RaisePropertyChanged("rowguid");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityKey", Namespace="http://schemas.datacontract.org/2004/07/System.Data", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class EntityKey : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EntityContainerNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private _002_WebForms.Wcf.EntityKeyMember[] EntityKeyValuesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EntitySetNameField;
        
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
        public string EntityContainerName {
            get {
                return this.EntityContainerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EntityContainerNameField, value) != true)) {
                    this.EntityContainerNameField = value;
                    this.RaisePropertyChanged("EntityContainerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public _002_WebForms.Wcf.EntityKeyMember[] EntityKeyValues {
            get {
                return this.EntityKeyValuesField;
            }
            set {
                if ((object.ReferenceEquals(this.EntityKeyValuesField, value) != true)) {
                    this.EntityKeyValuesField = value;
                    this.RaisePropertyChanged("EntityKeyValues");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EntitySetName {
            get {
                return this.EntitySetNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EntitySetNameField, value) != true)) {
                    this.EntitySetNameField = value;
                    this.RaisePropertyChanged("EntitySetName");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityKeyMember", Namespace="http://schemas.datacontract.org/2004/07/System.Data")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(_002_WebForms.Wcf.Customer))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(_002_WebForms.Wcf.Customer[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(_002_WebForms.Wcf.EntityObject))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(_002_WebForms.Wcf.StructuralObject))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(_002_WebForms.Wcf.EntityKey))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(_002_WebForms.Wcf.EntityKeyMember[]))]
    public partial class EntityKeyMember : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object ValueField;
        
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
        public string Key {
            get {
                return this.KeyField;
            }
            set {
                if ((object.ReferenceEquals(this.KeyField, value) != true)) {
                    this.KeyField = value;
                    this.RaisePropertyChanged("Key");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Wcf.ICustomer")]
    public interface ICustomer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/Get", ReplyAction="http://tempuri.org/ICustomer/GetResponse")]
        _002_WebForms.Wcf.Customer Get(int customerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/Get10", ReplyAction="http://tempuri.org/ICustomer/Get10Response")]
        _002_WebForms.Wcf.Customer[] Get10();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICustomerChannel : _002_WebForms.Wcf.ICustomer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerClient : System.ServiceModel.ClientBase<_002_WebForms.Wcf.ICustomer>, _002_WebForms.Wcf.ICustomer {
        
        public CustomerClient() {
        }
        
        public CustomerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public _002_WebForms.Wcf.Customer Get(int customerID) {
            return base.Channel.Get(customerID);
        }
        
        public _002_WebForms.Wcf.Customer[] Get10() {
            return base.Channel.Get10();
        }
    }
}
