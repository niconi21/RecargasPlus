﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Controller.webService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ConsultasSoap", Namespace="http://tempuri.org/webServiceRecargasPlus")]
    public partial class Consultas : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback loginOperationCompleted;
        
        private System.Threading.SendOrPostCallback getMontosOperationCompleted;
        
        private System.Threading.SendOrPostCallback getCompaniasOperationCompleted;
        
        private System.Threading.SendOrPostCallback getBonificacoinesOperationCompleted;
        
        private System.Threading.SendOrPostCallback getColaboradoresOperationCompleted;
        
        private System.Threading.SendOrPostCallback getRecargasOperationCompleted;
        
        private System.Threading.SendOrPostCallback setMontoOperationCompleted;
        
        private System.Threading.SendOrPostCallback setCompaniaOperationCompleted;
        
        private System.Threading.SendOrPostCallback setColaboradorOperationCompleted;
        
        private System.Threading.SendOrPostCallback setBonificacionOperationCompleted;
        
        private System.Threading.SendOrPostCallback updateColaboradorOperationCompleted;
        
        private System.Threading.SendOrPostCallback updateBonificacionOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Consultas() {
            this.Url = global::Controller.Properties.Settings.Default.Controller_webService_Consultas;
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
        public event loginCompletedEventHandler loginCompleted;
        
        /// <remarks/>
        public event getMontosCompletedEventHandler getMontosCompleted;
        
        /// <remarks/>
        public event getCompaniasCompletedEventHandler getCompaniasCompleted;
        
        /// <remarks/>
        public event getBonificacoinesCompletedEventHandler getBonificacoinesCompleted;
        
        /// <remarks/>
        public event getColaboradoresCompletedEventHandler getColaboradoresCompleted;
        
        /// <remarks/>
        public event getRecargasCompletedEventHandler getRecargasCompleted;
        
        /// <remarks/>
        public event setMontoCompletedEventHandler setMontoCompleted;
        
        /// <remarks/>
        public event setCompaniaCompletedEventHandler setCompaniaCompleted;
        
        /// <remarks/>
        public event setColaboradorCompletedEventHandler setColaboradorCompleted;
        
        /// <remarks/>
        public event setBonificacionCompletedEventHandler setBonificacionCompleted;
        
        /// <remarks/>
        public event updateColaboradorCompletedEventHandler updateColaboradorCompleted;
        
        /// <remarks/>
        public event updateBonificacionCompletedEventHandler updateBonificacionCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/webServiceRecargasPlus/login", RequestNamespace="http://tempuri.org/webServiceRecargasPlus", ResponseNamespace="http://tempuri.org/webServiceRecargasPlus", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string login(string usuario, string clave) {
            object[] results = this.Invoke("login", new object[] {
                        usuario,
                        clave});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void loginAsync(string usuario, string clave) {
            this.loginAsync(usuario, clave, null);
        }
        
        /// <remarks/>
        public void loginAsync(string usuario, string clave, object userState) {
            if ((this.loginOperationCompleted == null)) {
                this.loginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnloginOperationCompleted);
            }
            this.InvokeAsync("login", new object[] {
                        usuario,
                        clave}, this.loginOperationCompleted, userState);
        }
        
        private void OnloginOperationCompleted(object arg) {
            if ((this.loginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.loginCompleted(this, new loginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/webServiceRecargasPlus/getMontos", RequestNamespace="http://tempuri.org/webServiceRecargasPlus", ResponseNamespace="http://tempuri.org/webServiceRecargasPlus", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getMontos() {
            object[] results = this.Invoke("getMontos", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getMontosAsync() {
            this.getMontosAsync(null);
        }
        
        /// <remarks/>
        public void getMontosAsync(object userState) {
            if ((this.getMontosOperationCompleted == null)) {
                this.getMontosOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetMontosOperationCompleted);
            }
            this.InvokeAsync("getMontos", new object[0], this.getMontosOperationCompleted, userState);
        }
        
        private void OngetMontosOperationCompleted(object arg) {
            if ((this.getMontosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getMontosCompleted(this, new getMontosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/webServiceRecargasPlus/getCompanias", RequestNamespace="http://tempuri.org/webServiceRecargasPlus", ResponseNamespace="http://tempuri.org/webServiceRecargasPlus", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getCompanias() {
            object[] results = this.Invoke("getCompanias", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getCompaniasAsync() {
            this.getCompaniasAsync(null);
        }
        
        /// <remarks/>
        public void getCompaniasAsync(object userState) {
            if ((this.getCompaniasOperationCompleted == null)) {
                this.getCompaniasOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetCompaniasOperationCompleted);
            }
            this.InvokeAsync("getCompanias", new object[0], this.getCompaniasOperationCompleted, userState);
        }
        
        private void OngetCompaniasOperationCompleted(object arg) {
            if ((this.getCompaniasCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getCompaniasCompleted(this, new getCompaniasCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/webServiceRecargasPlus/getBonificacoines", RequestNamespace="http://tempuri.org/webServiceRecargasPlus", ResponseNamespace="http://tempuri.org/webServiceRecargasPlus", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getBonificacoines() {
            object[] results = this.Invoke("getBonificacoines", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getBonificacoinesAsync() {
            this.getBonificacoinesAsync(null);
        }
        
        /// <remarks/>
        public void getBonificacoinesAsync(object userState) {
            if ((this.getBonificacoinesOperationCompleted == null)) {
                this.getBonificacoinesOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetBonificacoinesOperationCompleted);
            }
            this.InvokeAsync("getBonificacoines", new object[0], this.getBonificacoinesOperationCompleted, userState);
        }
        
        private void OngetBonificacoinesOperationCompleted(object arg) {
            if ((this.getBonificacoinesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getBonificacoinesCompleted(this, new getBonificacoinesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/webServiceRecargasPlus/getColaboradores", RequestNamespace="http://tempuri.org/webServiceRecargasPlus", ResponseNamespace="http://tempuri.org/webServiceRecargasPlus", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getColaboradores() {
            object[] results = this.Invoke("getColaboradores", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getColaboradoresAsync() {
            this.getColaboradoresAsync(null);
        }
        
        /// <remarks/>
        public void getColaboradoresAsync(object userState) {
            if ((this.getColaboradoresOperationCompleted == null)) {
                this.getColaboradoresOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetColaboradoresOperationCompleted);
            }
            this.InvokeAsync("getColaboradores", new object[0], this.getColaboradoresOperationCompleted, userState);
        }
        
        private void OngetColaboradoresOperationCompleted(object arg) {
            if ((this.getColaboradoresCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getColaboradoresCompleted(this, new getColaboradoresCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/webServiceRecargasPlus/getRecargas", RequestNamespace="http://tempuri.org/webServiceRecargasPlus", ResponseNamespace="http://tempuri.org/webServiceRecargasPlus", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getRecargas() {
            object[] results = this.Invoke("getRecargas", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getRecargasAsync() {
            this.getRecargasAsync(null);
        }
        
        /// <remarks/>
        public void getRecargasAsync(object userState) {
            if ((this.getRecargasOperationCompleted == null)) {
                this.getRecargasOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetRecargasOperationCompleted);
            }
            this.InvokeAsync("getRecargas", new object[0], this.getRecargasOperationCompleted, userState);
        }
        
        private void OngetRecargasOperationCompleted(object arg) {
            if ((this.getRecargasCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getRecargasCompleted(this, new getRecargasCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/webServiceRecargasPlus/setMonto", RequestNamespace="http://tempuri.org/webServiceRecargasPlus", ResponseNamespace="http://tempuri.org/webServiceRecargasPlus", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool setMonto(double monto) {
            object[] results = this.Invoke("setMonto", new object[] {
                        monto});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void setMontoAsync(double monto) {
            this.setMontoAsync(monto, null);
        }
        
        /// <remarks/>
        public void setMontoAsync(double monto, object userState) {
            if ((this.setMontoOperationCompleted == null)) {
                this.setMontoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsetMontoOperationCompleted);
            }
            this.InvokeAsync("setMonto", new object[] {
                        monto}, this.setMontoOperationCompleted, userState);
        }
        
        private void OnsetMontoOperationCompleted(object arg) {
            if ((this.setMontoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.setMontoCompleted(this, new setMontoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/webServiceRecargasPlus/setCompania", RequestNamespace="http://tempuri.org/webServiceRecargasPlus", ResponseNamespace="http://tempuri.org/webServiceRecargasPlus", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool setCompania(string compania) {
            object[] results = this.Invoke("setCompania", new object[] {
                        compania});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void setCompaniaAsync(string compania) {
            this.setCompaniaAsync(compania, null);
        }
        
        /// <remarks/>
        public void setCompaniaAsync(string compania, object userState) {
            if ((this.setCompaniaOperationCompleted == null)) {
                this.setCompaniaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsetCompaniaOperationCompleted);
            }
            this.InvokeAsync("setCompania", new object[] {
                        compania}, this.setCompaniaOperationCompleted, userState);
        }
        
        private void OnsetCompaniaOperationCompleted(object arg) {
            if ((this.setCompaniaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.setCompaniaCompleted(this, new setCompaniaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/webServiceRecargasPlus/setColaborador", RequestNamespace="http://tempuri.org/webServiceRecargasPlus", ResponseNamespace="http://tempuri.org/webServiceRecargasPlus", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool setColaborador(string nombre, string apepat, string apemat, string usuario, string clave, double saldo) {
            object[] results = this.Invoke("setColaborador", new object[] {
                        nombre,
                        apepat,
                        apemat,
                        usuario,
                        clave,
                        saldo});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void setColaboradorAsync(string nombre, string apepat, string apemat, string usuario, string clave, double saldo) {
            this.setColaboradorAsync(nombre, apepat, apemat, usuario, clave, saldo, null);
        }
        
        /// <remarks/>
        public void setColaboradorAsync(string nombre, string apepat, string apemat, string usuario, string clave, double saldo, object userState) {
            if ((this.setColaboradorOperationCompleted == null)) {
                this.setColaboradorOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsetColaboradorOperationCompleted);
            }
            this.InvokeAsync("setColaborador", new object[] {
                        nombre,
                        apepat,
                        apemat,
                        usuario,
                        clave,
                        saldo}, this.setColaboradorOperationCompleted, userState);
        }
        
        private void OnsetColaboradorOperationCompleted(object arg) {
            if ((this.setColaboradorCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.setColaboradorCompleted(this, new setColaboradorCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/webServiceRecargasPlus/setBonificacion", RequestNamespace="http://tempuri.org/webServiceRecargasPlus", ResponseNamespace="http://tempuri.org/webServiceRecargasPlus", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool setBonificacion(double bonificacion, int idMonto, int idCompania) {
            object[] results = this.Invoke("setBonificacion", new object[] {
                        bonificacion,
                        idMonto,
                        idCompania});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void setBonificacionAsync(double bonificacion, int idMonto, int idCompania) {
            this.setBonificacionAsync(bonificacion, idMonto, idCompania, null);
        }
        
        /// <remarks/>
        public void setBonificacionAsync(double bonificacion, int idMonto, int idCompania, object userState) {
            if ((this.setBonificacionOperationCompleted == null)) {
                this.setBonificacionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsetBonificacionOperationCompleted);
            }
            this.InvokeAsync("setBonificacion", new object[] {
                        bonificacion,
                        idMonto,
                        idCompania}, this.setBonificacionOperationCompleted, userState);
        }
        
        private void OnsetBonificacionOperationCompleted(object arg) {
            if ((this.setBonificacionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.setBonificacionCompleted(this, new setBonificacionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/webServiceRecargasPlus/updateColaborador", RequestNamespace="http://tempuri.org/webServiceRecargasPlus", ResponseNamespace="http://tempuri.org/webServiceRecargasPlus", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void updateColaborador(int idColaborador, string nombre, string apepat, string apemat, string usuario, string clave, double saldo) {
            this.Invoke("updateColaborador", new object[] {
                        idColaborador,
                        nombre,
                        apepat,
                        apemat,
                        usuario,
                        clave,
                        saldo});
        }
        
        /// <remarks/>
        public void updateColaboradorAsync(int idColaborador, string nombre, string apepat, string apemat, string usuario, string clave, double saldo) {
            this.updateColaboradorAsync(idColaborador, nombre, apepat, apemat, usuario, clave, saldo, null);
        }
        
        /// <remarks/>
        public void updateColaboradorAsync(int idColaborador, string nombre, string apepat, string apemat, string usuario, string clave, double saldo, object userState) {
            if ((this.updateColaboradorOperationCompleted == null)) {
                this.updateColaboradorOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupdateColaboradorOperationCompleted);
            }
            this.InvokeAsync("updateColaborador", new object[] {
                        idColaborador,
                        nombre,
                        apepat,
                        apemat,
                        usuario,
                        clave,
                        saldo}, this.updateColaboradorOperationCompleted, userState);
        }
        
        private void OnupdateColaboradorOperationCompleted(object arg) {
            if ((this.updateColaboradorCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.updateColaboradorCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/webServiceRecargasPlus/updateBonificacion", RequestNamespace="http://tempuri.org/webServiceRecargasPlus", ResponseNamespace="http://tempuri.org/webServiceRecargasPlus", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool updateBonificacion(int idBonificacion, double bonificacion, int idMonto, int idCompania) {
            object[] results = this.Invoke("updateBonificacion", new object[] {
                        idBonificacion,
                        bonificacion,
                        idMonto,
                        idCompania});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void updateBonificacionAsync(int idBonificacion, double bonificacion, int idMonto, int idCompania) {
            this.updateBonificacionAsync(idBonificacion, bonificacion, idMonto, idCompania, null);
        }
        
        /// <remarks/>
        public void updateBonificacionAsync(int idBonificacion, double bonificacion, int idMonto, int idCompania, object userState) {
            if ((this.updateBonificacionOperationCompleted == null)) {
                this.updateBonificacionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupdateBonificacionOperationCompleted);
            }
            this.InvokeAsync("updateBonificacion", new object[] {
                        idBonificacion,
                        bonificacion,
                        idMonto,
                        idCompania}, this.updateBonificacionOperationCompleted, userState);
        }
        
        private void OnupdateBonificacionOperationCompleted(object arg) {
            if ((this.updateBonificacionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.updateBonificacionCompleted(this, new updateBonificacionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void loginCompletedEventHandler(object sender, loginCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class loginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal loginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void getMontosCompletedEventHandler(object sender, getMontosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getMontosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getMontosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void getCompaniasCompletedEventHandler(object sender, getCompaniasCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getCompaniasCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getCompaniasCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void getBonificacoinesCompletedEventHandler(object sender, getBonificacoinesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getBonificacoinesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getBonificacoinesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void getColaboradoresCompletedEventHandler(object sender, getColaboradoresCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getColaboradoresCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getColaboradoresCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void getRecargasCompletedEventHandler(object sender, getRecargasCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getRecargasCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getRecargasCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void setMontoCompletedEventHandler(object sender, setMontoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class setMontoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal setMontoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void setCompaniaCompletedEventHandler(object sender, setCompaniaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class setCompaniaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal setCompaniaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void setColaboradorCompletedEventHandler(object sender, setColaboradorCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class setColaboradorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal setColaboradorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void setBonificacionCompletedEventHandler(object sender, setBonificacionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class setBonificacionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal setBonificacionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void updateColaboradorCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void updateBonificacionCompletedEventHandler(object sender, updateBonificacionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class updateBonificacionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal updateBonificacionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591