﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.1
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.1 版自动生成。
// 
#pragma warning disable 1591

namespace PathHISZGQJK.gds2websvr {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="PacsWSSoap", Namespace="http://tempuri.org")]
    public partial class PacsWS : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback PacsApplyServiceOperationCompleted;
        
        private System.Threading.SendOrPostCallback PacsReportBackOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public PacsWS() {
            this.Url = global::PathHISZGQJK.Properties.Settings.Default.PathHISZGQJK_gds2websvr_PacsWS;
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
        public event PacsApplyServiceCompletedEventHandler PacsApplyServiceCompleted;
        
        /// <remarks/>
        public event PacsReportBackCompletedEventHandler PacsReportBackCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/JHIP.PACS.BS.PacsWS.PacsApplyService", RequestNamespace="http://tempuri.org", ResponseNamespace="http://tempuri.org", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string PacsApplyService(string pInput) {
            object[] results = this.Invoke("PacsApplyService", new object[] {
                        pInput});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void PacsApplyServiceAsync(string pInput) {
            this.PacsApplyServiceAsync(pInput, null);
        }
        
        /// <remarks/>
        public void PacsApplyServiceAsync(string pInput, object userState) {
            if ((this.PacsApplyServiceOperationCompleted == null)) {
                this.PacsApplyServiceOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPacsApplyServiceOperationCompleted);
            }
            this.InvokeAsync("PacsApplyService", new object[] {
                        pInput}, this.PacsApplyServiceOperationCompleted, userState);
        }
        
        private void OnPacsApplyServiceOperationCompleted(object arg) {
            if ((this.PacsApplyServiceCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PacsApplyServiceCompleted(this, new PacsApplyServiceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/JHIP.PACS.BS.PacsWS.PacsReportBack", RequestNamespace="http://tempuri.org", ResponseNamespace="http://tempuri.org", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string PacsReportBack(string pInput) {
            object[] results = this.Invoke("PacsReportBack", new object[] {
                        pInput});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void PacsReportBackAsync(string pInput) {
            this.PacsReportBackAsync(pInput, null);
        }
        
        /// <remarks/>
        public void PacsReportBackAsync(string pInput, object userState) {
            if ((this.PacsReportBackOperationCompleted == null)) {
                this.PacsReportBackOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPacsReportBackOperationCompleted);
            }
            this.InvokeAsync("PacsReportBack", new object[] {
                        pInput}, this.PacsReportBackOperationCompleted, userState);
        }
        
        private void OnPacsReportBackOperationCompleted(object arg) {
            if ((this.PacsReportBackCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PacsReportBackCompleted(this, new PacsReportBackCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void PacsApplyServiceCompletedEventHandler(object sender, PacsApplyServiceCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PacsApplyServiceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal PacsApplyServiceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void PacsReportBackCompletedEventHandler(object sender, PacsReportBackCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PacsReportBackCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal PacsReportBackCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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