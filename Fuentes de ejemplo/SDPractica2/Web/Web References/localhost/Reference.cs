﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18444
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.18444.
// 
#pragma warning disable 1591

namespace Web.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServicioSoap", Namespace="http://tempuri.org/")]
    public partial class Servicio : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GuardarAutomovilOperationCompleted;
        
        private System.Threading.SendOrPostCallback EditarAutomovilOperationCompleted;
        
        private System.Threading.SendOrPostCallback EliminarAutomovilOperationCompleted;
        
        private System.Threading.SendOrPostCallback ObtenerAutomovilOperationCompleted;
        
        private System.Threading.SendOrPostCallback ObtenerListadoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Servicio() {
            this.Url = global::Web.Properties.Settings.Default.Web_localhost_Servicio;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GuardarAutomovilCompletedEventHandler GuardarAutomovilCompleted;
        
        /// <remarks/>
        public event EditarAutomovilCompletedEventHandler EditarAutomovilCompleted;
        
        /// <remarks/>
        public event EliminarAutomovilCompletedEventHandler EliminarAutomovilCompleted;
        
        /// <remarks/>
        public event ObtenerAutomovilCompletedEventHandler ObtenerAutomovilCompleted;
        
        /// <remarks/>
        public event ObtenerListadoCompletedEventHandler ObtenerListadoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GuardarAutomovil", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GuardarAutomovil(string marca, string modelo, string anio, string descripcion) {
            object[] results = this.Invoke("GuardarAutomovil", new object[] {
                        marca,
                        modelo,
                        anio,
                        descripcion});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GuardarAutomovilAsync(string marca, string modelo, string anio, string descripcion) {
            this.GuardarAutomovilAsync(marca, modelo, anio, descripcion, null);
        }
        
        /// <remarks/>
        public void GuardarAutomovilAsync(string marca, string modelo, string anio, string descripcion, object userState) {
            if ((this.GuardarAutomovilOperationCompleted == null)) {
                this.GuardarAutomovilOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGuardarAutomovilOperationCompleted);
            }
            this.InvokeAsync("GuardarAutomovil", new object[] {
                        marca,
                        modelo,
                        anio,
                        descripcion}, this.GuardarAutomovilOperationCompleted, userState);
        }
        
        private void OnGuardarAutomovilOperationCompleted(object arg) {
            if ((this.GuardarAutomovilCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GuardarAutomovilCompleted(this, new GuardarAutomovilCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/EditarAutomovil", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string EditarAutomovil(int id, string marca, string modelo, string anio, string descripcion) {
            object[] results = this.Invoke("EditarAutomovil", new object[] {
                        id,
                        marca,
                        modelo,
                        anio,
                        descripcion});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void EditarAutomovilAsync(int id, string marca, string modelo, string anio, string descripcion) {
            this.EditarAutomovilAsync(id, marca, modelo, anio, descripcion, null);
        }
        
        /// <remarks/>
        public void EditarAutomovilAsync(int id, string marca, string modelo, string anio, string descripcion, object userState) {
            if ((this.EditarAutomovilOperationCompleted == null)) {
                this.EditarAutomovilOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEditarAutomovilOperationCompleted);
            }
            this.InvokeAsync("EditarAutomovil", new object[] {
                        id,
                        marca,
                        modelo,
                        anio,
                        descripcion}, this.EditarAutomovilOperationCompleted, userState);
        }
        
        private void OnEditarAutomovilOperationCompleted(object arg) {
            if ((this.EditarAutomovilCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EditarAutomovilCompleted(this, new EditarAutomovilCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/EliminarAutomovil", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string EliminarAutomovil(int id) {
            object[] results = this.Invoke("EliminarAutomovil", new object[] {
                        id});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void EliminarAutomovilAsync(int id) {
            this.EliminarAutomovilAsync(id, null);
        }
        
        /// <remarks/>
        public void EliminarAutomovilAsync(int id, object userState) {
            if ((this.EliminarAutomovilOperationCompleted == null)) {
                this.EliminarAutomovilOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEliminarAutomovilOperationCompleted);
            }
            this.InvokeAsync("EliminarAutomovil", new object[] {
                        id}, this.EliminarAutomovilOperationCompleted, userState);
        }
        
        private void OnEliminarAutomovilOperationCompleted(object arg) {
            if ((this.EliminarAutomovilCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EliminarAutomovilCompleted(this, new EliminarAutomovilCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ObtenerAutomovil", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ObtenerAutomovil(int id) {
            object[] results = this.Invoke("ObtenerAutomovil", new object[] {
                        id});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ObtenerAutomovilAsync(int id) {
            this.ObtenerAutomovilAsync(id, null);
        }
        
        /// <remarks/>
        public void ObtenerAutomovilAsync(int id, object userState) {
            if ((this.ObtenerAutomovilOperationCompleted == null)) {
                this.ObtenerAutomovilOperationCompleted = new System.Threading.SendOrPostCallback(this.OnObtenerAutomovilOperationCompleted);
            }
            this.InvokeAsync("ObtenerAutomovil", new object[] {
                        id}, this.ObtenerAutomovilOperationCompleted, userState);
        }
        
        private void OnObtenerAutomovilOperationCompleted(object arg) {
            if ((this.ObtenerAutomovilCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ObtenerAutomovilCompleted(this, new ObtenerAutomovilCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ObtenerListado", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ObtenerListado() {
            object[] results = this.Invoke("ObtenerListado", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ObtenerListadoAsync() {
            this.ObtenerListadoAsync(null);
        }
        
        /// <remarks/>
        public void ObtenerListadoAsync(object userState) {
            if ((this.ObtenerListadoOperationCompleted == null)) {
                this.ObtenerListadoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnObtenerListadoOperationCompleted);
            }
            this.InvokeAsync("ObtenerListado", new object[0], this.ObtenerListadoOperationCompleted, userState);
        }
        
        private void OnObtenerListadoOperationCompleted(object arg) {
            if ((this.ObtenerListadoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ObtenerListadoCompleted(this, new ObtenerListadoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GuardarAutomovilCompletedEventHandler(object sender, GuardarAutomovilCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GuardarAutomovilCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GuardarAutomovilCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void EditarAutomovilCompletedEventHandler(object sender, EditarAutomovilCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EditarAutomovilCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal EditarAutomovilCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void EliminarAutomovilCompletedEventHandler(object sender, EliminarAutomovilCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EliminarAutomovilCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal EliminarAutomovilCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void ObtenerAutomovilCompletedEventHandler(object sender, ObtenerAutomovilCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ObtenerAutomovilCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ObtenerAutomovilCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void ObtenerListadoCompletedEventHandler(object sender, ObtenerListadoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ObtenerListadoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ObtenerListadoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591