﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WimDemoService.ProxyProductos {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/DemoServiceVentas")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyProductos.IServiceProducto")]
    public interface IServiceProducto {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProducto/GetData", ReplyAction="http://tempuri.org/IServiceProducto/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProducto/GetAllProducto", ReplyAction="http://tempuri.org/IServiceProducto/GetAllProductoResponse")]
        System.Data.DataSet GetAllProducto();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProducto/GetProveedoresProducto", ReplyAction="http://tempuri.org/IServiceProducto/GetProveedoresProductoResponse")]
        System.Data.DataSet GetProveedoresProducto(string strCod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceProducto/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IServiceProducto/GetDataUsingDataContractResponse")]
        WimDemoService.ProxyProductos.CompositeType GetDataUsingDataContract(WimDemoService.ProxyProductos.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceProductoChannel : WimDemoService.ProxyProductos.IServiceProducto, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceProductoClient : System.ServiceModel.ClientBase<WimDemoService.ProxyProductos.IServiceProducto>, WimDemoService.ProxyProductos.IServiceProducto {
        
        public ServiceProductoClient() {
        }
        
        public ServiceProductoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceProductoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceProductoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceProductoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Data.DataSet GetAllProducto() {
            return base.Channel.GetAllProducto();
        }
        
        public System.Data.DataSet GetProveedoresProducto(string strCod) {
            return base.Channel.GetProveedoresProducto(strCod);
        }
        
        public WimDemoService.ProxyProductos.CompositeType GetDataUsingDataContract(WimDemoService.ProxyProductos.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
    }
}
