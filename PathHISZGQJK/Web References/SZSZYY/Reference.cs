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

namespace PathHISZGQJK.SZSZYY {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiceSoap", Namespace="WebService")]
    public partial class Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback InitOperationCompleted;
        
        private System.Threading.SendOrPostCallback SetFlagOperationCompleted;
        
        private System.Threading.SendOrPostCallback SetCompleteWebURLOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetPatiInfoByOrgOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service() {
            this.Url = global::PathHISZGQJK.Properties.Settings.Default.PathHISZGQJK_SZSZYY_Service;
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
        public event InitCompletedEventHandler InitCompleted;
        
        /// <remarks/>
        public event SetFlagCompletedEventHandler SetFlagCompleted;
        
        /// <remarks/>
        public event SetCompleteWebURLCompletedEventHandler SetCompleteWebURLCompleted;
        
        /// <remarks/>
        public event GetPatiInfoByOrgCompletedEventHandler GetPatiInfoByOrgCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("WebService/Init", RequestNamespace="WebService", ResponseNamespace="WebService", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Init() {
            object[] results = this.Invoke("Init", new object[0]);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void InitAsync() {
            this.InitAsync(null);
        }
        
        /// <remarks/>
        public void InitAsync(object userState) {
            if ((this.InitOperationCompleted == null)) {
                this.InitOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInitOperationCompleted);
            }
            this.InvokeAsync("Init", new object[0], this.InitOperationCompleted, userState);
        }
        
        private void OnInitOperationCompleted(object arg) {
            if ((this.InitCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InitCompleted(this, new InitCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("WebService/SetFlag", RequestNamespace="WebService", ResponseNamespace="WebService", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool SetFlag(string OrdID, int InOut, int Flag) {
            object[] results = this.Invoke("SetFlag", new object[] {
                        OrdID,
                        InOut,
                        Flag});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void SetFlagAsync(string OrdID, int InOut, int Flag) {
            this.SetFlagAsync(OrdID, InOut, Flag, null);
        }
        
        /// <remarks/>
        public void SetFlagAsync(string OrdID, int InOut, int Flag, object userState) {
            if ((this.SetFlagOperationCompleted == null)) {
                this.SetFlagOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetFlagOperationCompleted);
            }
            this.InvokeAsync("SetFlag", new object[] {
                        OrdID,
                        InOut,
                        Flag}, this.SetFlagOperationCompleted, userState);
        }
        
        private void OnSetFlagOperationCompleted(object arg) {
            if ((this.SetFlagCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetFlagCompleted(this, new SetFlagCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("WebService/SetCompleteWebURL", RequestNamespace="WebService", ResponseNamespace="WebService", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool SetCompleteWebURL(string OrdID, int InOut, string ResultAddress) {
            object[] results = this.Invoke("SetCompleteWebURL", new object[] {
                        OrdID,
                        InOut,
                        ResultAddress});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void SetCompleteWebURLAsync(string OrdID, int InOut, string ResultAddress) {
            this.SetCompleteWebURLAsync(OrdID, InOut, ResultAddress, null);
        }
        
        /// <remarks/>
        public void SetCompleteWebURLAsync(string OrdID, int InOut, string ResultAddress, object userState) {
            if ((this.SetCompleteWebURLOperationCompleted == null)) {
                this.SetCompleteWebURLOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetCompleteWebURLOperationCompleted);
            }
            this.InvokeAsync("SetCompleteWebURL", new object[] {
                        OrdID,
                        InOut,
                        ResultAddress}, this.SetCompleteWebURLOperationCompleted, userState);
        }
        
        private void OnSetCompleteWebURLOperationCompleted(object arg) {
            if ((this.SetCompleteWebURLCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetCompleteWebURLCompleted(this, new SetCompleteWebURLCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("WebService/GetPatiInfoByOrg", RequestNamespace="WebService", ResponseNamespace="WebService", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetPatiInfoByOrg(string CardID, int Flag, string OrgID) {
            object[] results = this.Invoke("GetPatiInfoByOrg", new object[] {
                        CardID,
                        Flag,
                        OrgID});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetPatiInfoByOrgAsync(string CardID, int Flag, string OrgID) {
            this.GetPatiInfoByOrgAsync(CardID, Flag, OrgID, null);
        }
        
        /// <remarks/>
        public void GetPatiInfoByOrgAsync(string CardID, int Flag, string OrgID, object userState) {
            if ((this.GetPatiInfoByOrgOperationCompleted == null)) {
                this.GetPatiInfoByOrgOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPatiInfoByOrgOperationCompleted);
            }
            this.InvokeAsync("GetPatiInfoByOrg", new object[] {
                        CardID,
                        Flag,
                        OrgID}, this.GetPatiInfoByOrgOperationCompleted, userState);
        }
        
        private void OnGetPatiInfoByOrgOperationCompleted(object arg) {
            if ((this.GetPatiInfoByOrgCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPatiInfoByOrgCompleted(this, new GetPatiInfoByOrgCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void InitCompletedEventHandler(object sender, InitCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InitCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InitCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void SetFlagCompletedEventHandler(object sender, SetFlagCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SetFlagCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SetFlagCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void SetCompleteWebURLCompletedEventHandler(object sender, SetCompleteWebURLCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SetCompleteWebURLCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SetCompleteWebURLCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetPatiInfoByOrgCompletedEventHandler(object sender, GetPatiInfoByOrgCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetPatiInfoByOrgCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetPatiInfoByOrgCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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