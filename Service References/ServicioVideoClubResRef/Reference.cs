﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34014
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideoClub.ServicioVideoClubResRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Log", Namespace="http://schemas.datacontract.org/2004/07/ServicioVideoClubRes")]
    [System.SerializableAttribute()]
    public partial class Log : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int cantidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int codigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string usuarioField;
        
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
        public int cantidad {
            get {
                return this.cantidadField;
            }
            set {
                if ((this.cantidadField.Equals(value) != true)) {
                    this.cantidadField = value;
                    this.RaisePropertyChanged("cantidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int codigo {
            get {
                return this.codigoField;
            }
            set {
                if ((this.codigoField.Equals(value) != true)) {
                    this.codigoField = value;
                    this.RaisePropertyChanged("codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string usuario {
            get {
                return this.usuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.usuarioField, value) != true)) {
                    this.usuarioField = value;
                    this.RaisePropertyChanged("usuario");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="LogFault", Namespace="http://schemas.datacontract.org/2004/07/ServicioVideoClubRes")]
    [System.SerializableAttribute()]
    public partial class LogFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FaultMessageField;
        
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
        public string FaultMessage {
            get {
                return this.FaultMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.FaultMessageField, value) != true)) {
                    this.FaultMessageField = value;
                    this.RaisePropertyChanged("FaultMessage");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioVideoClubResRef.IServicioVideoClubRes")]
    public interface IServicioVideoClubRes {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVideoClubRes/GetRes", ReplyAction="http://tempuri.org/IServicioVideoClubRes/GetResResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(VideoClub.ServicioVideoClubResRef.LogFault), Action="http://tempuri.org/IServicioVideoClubRes/GetResLogFaultFault", Name="LogFault", Namespace="http://schemas.datacontract.org/2004/07/ServicioVideoClubRes")]
        VideoClub.ServicioVideoClubResRef.Log GetRes(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVideoClubRes/GetRes", ReplyAction="http://tempuri.org/IServicioVideoClubRes/GetResResponse")]
        System.Threading.Tasks.Task<VideoClub.ServicioVideoClubResRef.Log> GetResAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVideoClubRes/Reservar", ReplyAction="http://tempuri.org/IServicioVideoClubRes/ReservarResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(VideoClub.ServicioVideoClubResRef.LogFault), Action="http://tempuri.org/IServicioVideoClubRes/ReservarLogFaultFault", Name="LogFault", Namespace="http://schemas.datacontract.org/2004/07/ServicioVideoClubRes")]
        VideoClub.ServicioVideoClubResRef.Log Reservar(string usuario, int codigo, int cantidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVideoClubRes/Reservar", ReplyAction="http://tempuri.org/IServicioVideoClubRes/ReservarResponse")]
        System.Threading.Tasks.Task<VideoClub.ServicioVideoClubResRef.Log> ReservarAsync(string usuario, int codigo, int cantidad);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioVideoClubResChannel : VideoClub.ServicioVideoClubResRef.IServicioVideoClubRes, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioVideoClubResClient : System.ServiceModel.ClientBase<VideoClub.ServicioVideoClubResRef.IServicioVideoClubRes>, VideoClub.ServicioVideoClubResRef.IServicioVideoClubRes {
        
        public ServicioVideoClubResClient() {
        }
        
        public ServicioVideoClubResClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioVideoClubResClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioVideoClubResClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioVideoClubResClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public VideoClub.ServicioVideoClubResRef.Log GetRes(int id) {
            return base.Channel.GetRes(id);
        }
        
        public System.Threading.Tasks.Task<VideoClub.ServicioVideoClubResRef.Log> GetResAsync(int id) {
            return base.Channel.GetResAsync(id);
        }
        
        public VideoClub.ServicioVideoClubResRef.Log Reservar(string usuario, int codigo, int cantidad) {
            return base.Channel.Reservar(usuario, codigo, cantidad);
        }
        
        public System.Threading.Tasks.Task<VideoClub.ServicioVideoClubResRef.Log> ReservarAsync(string usuario, int codigo, int cantidad) {
            return base.Channel.ReservarAsync(usuario, codigo, cantidad);
        }
    }
}
