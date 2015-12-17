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
    [System.Web.Services.WebServiceBindingAttribute(Name="ServicioSoap", Namespace="http://iswug.net/")]
    public partial class Servicio : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GuardarContactoOperationCompleted;
        
        private System.Threading.SendOrPostCallback ObtenerContactosOperationCompleted;
        
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
        public event GuardarContactoCompletedEventHandler GuardarContactoCompleted;
        
        /// <remarks/>
        public event ObtenerContactosCompletedEventHandler ObtenerContactosCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://iswug.net/GuardarContacto", RequestNamespace="http://iswug.net/", ResponseNamespace="http://iswug.net/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GuardarContacto(string nombre, string direccion, string telefono, string correo) {
            object[] results = this.Invoke("GuardarContacto", new object[] {
                        nombre,
                        direccion,
                        telefono,
                        correo});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GuardarContactoAsync(string nombre, string direccion, string telefono, string correo) {
            this.GuardarContactoAsync(nombre, direccion, telefono, correo, null);
        }
        
        /// <remarks/>
        public void GuardarContactoAsync(string nombre, string direccion, string telefono, string correo, object userState) {
            if ((this.GuardarContactoOperationCompleted == null)) {
                this.GuardarContactoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGuardarContactoOperationCompleted);
            }
            this.InvokeAsync("GuardarContacto", new object[] {
                        nombre,
                        direccion,
                        telefono,
                        correo}, this.GuardarContactoOperationCompleted, userState);
        }
        
        private void OnGuardarContactoOperationCompleted(object arg) {
            if ((this.GuardarContactoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GuardarContactoCompleted(this, new GuardarContactoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://iswug.net/ObtenerContactos", RequestNamespace="http://iswug.net/", ResponseNamespace="http://iswug.net/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ObtenerContactos() {
            object[] results = this.Invoke("ObtenerContactos", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ObtenerContactosAsync() {
            this.ObtenerContactosAsync(null);
        }
        
        /// <remarks/>
        public void ObtenerContactosAsync(object userState) {
            if ((this.ObtenerContactosOperationCompleted == null)) {
                this.ObtenerContactosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnObtenerContactosOperationCompleted);
            }
            this.InvokeAsync("ObtenerContactos", new object[0], this.ObtenerContactosOperationCompleted, userState);
        }
        
        private void OnObtenerContactosOperationCompleted(object arg) {
            if ((this.ObtenerContactosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ObtenerContactosCompleted(this, new ObtenerContactosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void GuardarContactoCompletedEventHandler(object sender, GuardarContactoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GuardarContactoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GuardarContactoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void ObtenerContactosCompletedEventHandler(object sender, ObtenerContactosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ObtenerContactosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ObtenerContactosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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