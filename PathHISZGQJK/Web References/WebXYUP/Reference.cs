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

namespace PathHISZGQJK.WebXYUP {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="ExamFillerWSSoap", Namespace="http://www.supcon.com/ExamFillerWS")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Ens_Messagebody))]
    public partial class ExamFillerWS : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ExamImagesSubmitOperationCompleted;
        
        private System.Threading.SendOrPostCallback ExamReportsSubmitOperationCompleted;
        
        private System.Threading.SendOrPostCallback ExamUpdateStatusOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ExamFillerWS() {
            this.Url = global::PathHISZGQJK.Properties.Settings.Default.PathHISZGQJK_WebXYUP_ExamFillerWS;
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
        public event ExamImagesSubmitCompletedEventHandler ExamImagesSubmitCompleted;
        
        /// <remarks/>
        public event ExamReportsSubmitCompletedEventHandler ExamReportsSubmitCompleted;
        
        /// <remarks/>
        public event ExamUpdateStatusCompletedEventHandler ExamUpdateStatusCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.supcon.com/ExamFillerWS/BS.WS.ExamFillerWS.ExamImagesSubmit", RequestNamespace="http://www.supcon.com/ExamFillerWS", ResponseNamespace="http://www.supcon.com/ExamFillerWS", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ExamImagesSubmit(FillerImages fillerImages) {
            object[] results = this.Invoke("ExamImagesSubmit", new object[] {
                        fillerImages});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ExamImagesSubmitAsync(FillerImages fillerImages) {
            this.ExamImagesSubmitAsync(fillerImages, null);
        }
        
        /// <remarks/>
        public void ExamImagesSubmitAsync(FillerImages fillerImages, object userState) {
            if ((this.ExamImagesSubmitOperationCompleted == null)) {
                this.ExamImagesSubmitOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExamImagesSubmitOperationCompleted);
            }
            this.InvokeAsync("ExamImagesSubmit", new object[] {
                        fillerImages}, this.ExamImagesSubmitOperationCompleted, userState);
        }
        
        private void OnExamImagesSubmitOperationCompleted(object arg) {
            if ((this.ExamImagesSubmitCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExamImagesSubmitCompleted(this, new ExamImagesSubmitCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.supcon.com/ExamFillerWS/BS.WS.ExamFillerWS.ExamReportsSubmit", RequestNamespace="http://www.supcon.com/ExamFillerWS", ResponseNamespace="http://www.supcon.com/ExamFillerWS", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ExamReportsSubmit(FillerReports fillerReports) {
            object[] results = this.Invoke("ExamReportsSubmit", new object[] {
                        fillerReports});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ExamReportsSubmitAsync(FillerReports fillerReports) {
            this.ExamReportsSubmitAsync(fillerReports, null);
        }
        
        /// <remarks/>
        public void ExamReportsSubmitAsync(FillerReports fillerReports, object userState) {
            if ((this.ExamReportsSubmitOperationCompleted == null)) {
                this.ExamReportsSubmitOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExamReportsSubmitOperationCompleted);
            }
            this.InvokeAsync("ExamReportsSubmit", new object[] {
                        fillerReports}, this.ExamReportsSubmitOperationCompleted, userState);
        }
        
        private void OnExamReportsSubmitOperationCompleted(object arg) {
            if ((this.ExamReportsSubmitCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExamReportsSubmitCompleted(this, new ExamReportsSubmitCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.supcon.com/ExamFillerWS/BS.WS.ExamFillerWS.ExamUpdateStatus", RequestNamespace="http://www.supcon.com/ExamFillerWS", ResponseNamespace="http://www.supcon.com/ExamFillerWS", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ExamUpdateStatus(UpdateStatus updateinfo) {
            object[] results = this.Invoke("ExamUpdateStatus", new object[] {
                        updateinfo});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ExamUpdateStatusAsync(UpdateStatus updateinfo) {
            this.ExamUpdateStatusAsync(updateinfo, null);
        }
        
        /// <remarks/>
        public void ExamUpdateStatusAsync(UpdateStatus updateinfo, object userState) {
            if ((this.ExamUpdateStatusOperationCompleted == null)) {
                this.ExamUpdateStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExamUpdateStatusOperationCompleted);
            }
            this.InvokeAsync("ExamUpdateStatus", new object[] {
                        updateinfo}, this.ExamUpdateStatusOperationCompleted, userState);
        }
        
        private void OnExamUpdateStatusOperationCompleted(object arg) {
            if ((this.ExamUpdateStatusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExamUpdateStatusCompleted(this, new ExamUpdateStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.supcon.com/ExamFillerWS")]
    public partial class FillerImages : reqBase {
        
        private string examNoField;
        
        private string patientIDField;
        
        private string patientNameField;
        
        private string patientTypeField;
        
        private string visitNoField;
        
        private string technicianField;
        
        private string examDateTimeField;
        
        private ImageInfo[] imageInfoField;
        
        /// <remarks/>
        public string ExamNo {
            get {
                return this.examNoField;
            }
            set {
                this.examNoField = value;
            }
        }
        
        /// <remarks/>
        public string PatientID {
            get {
                return this.patientIDField;
            }
            set {
                this.patientIDField = value;
            }
        }
        
        /// <remarks/>
        public string PatientName {
            get {
                return this.patientNameField;
            }
            set {
                this.patientNameField = value;
            }
        }
        
        /// <remarks/>
        public string PatientType {
            get {
                return this.patientTypeField;
            }
            set {
                this.patientTypeField = value;
            }
        }
        
        /// <remarks/>
        public string VisitNo {
            get {
                return this.visitNoField;
            }
            set {
                this.visitNoField = value;
            }
        }
        
        /// <remarks/>
        public string Technician {
            get {
                return this.technicianField;
            }
            set {
                this.technicianField = value;
            }
        }
        
        /// <remarks/>
        public string ExamDateTime {
            get {
                return this.examDateTimeField;
            }
            set {
                this.examDateTimeField = value;
            }
        }
        
        /// <remarks/>
        public ImageInfo[] ImageInfo {
            get {
                return this.imageInfoField;
            }
            set {
                this.imageInfoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.supcon.com/ExamFillerWS")]
    public partial class ImageInfo {
        
        private string dicomMoDalityField;
        
        private string patientLocalIDField;
        
        private string firstMediaField;
        
        private string firstPathField;
        
        private string dataTypeField;
        
        /// <remarks/>
        public string DicomMoDality {
            get {
                return this.dicomMoDalityField;
            }
            set {
                this.dicomMoDalityField = value;
            }
        }
        
        /// <remarks/>
        public string PatientLocalID {
            get {
                return this.patientLocalIDField;
            }
            set {
                this.patientLocalIDField = value;
            }
        }
        
        /// <remarks/>
        public string FirstMedia {
            get {
                return this.firstMediaField;
            }
            set {
                this.firstMediaField = value;
            }
        }
        
        /// <remarks/>
        public string FirstPath {
            get {
                return this.firstPathField;
            }
            set {
                this.firstPathField = value;
            }
        }
        
        /// <remarks/>
        public string DataType {
            get {
                return this.dataTypeField;
            }
            set {
                this.dataTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.supcon.com/ExamFillerWS")]
    public partial class ReportInfo {
        
        private string reportNoField;
        
        private string examParaField;
        
        private string impressionField;
        
        private string descriptionField;
        
        private string recommendationField;
        
        private string isAbnormalField;
        
        private string firstMediaField;
        
        private string firstPathField;
        
        private string dataTypeField;
        
        private string reportMemoField;
        
        /// <remarks/>
        public string ReportNo {
            get {
                return this.reportNoField;
            }
            set {
                this.reportNoField = value;
            }
        }
        
        /// <remarks/>
        public string ExamPara {
            get {
                return this.examParaField;
            }
            set {
                this.examParaField = value;
            }
        }
        
        /// <remarks/>
        public string Impression {
            get {
                return this.impressionField;
            }
            set {
                this.impressionField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string Recommendation {
            get {
                return this.recommendationField;
            }
            set {
                this.recommendationField = value;
            }
        }
        
        /// <remarks/>
        public string IsAbnormal {
            get {
                return this.isAbnormalField;
            }
            set {
                this.isAbnormalField = value;
            }
        }
        
        /// <remarks/>
        public string FirstMedia {
            get {
                return this.firstMediaField;
            }
            set {
                this.firstMediaField = value;
            }
        }
        
        /// <remarks/>
        public string FirstPath {
            get {
                return this.firstPathField;
            }
            set {
                this.firstPathField = value;
            }
        }
        
        /// <remarks/>
        public string DataType {
            get {
                return this.dataTypeField;
            }
            set {
                this.dataTypeField = value;
            }
        }
        
        /// <remarks/>
        public string ReportMemo {
            get {
                return this.reportMemoField;
            }
            set {
                this.reportMemoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Ens_Request))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(reqBase))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UpdateStatus))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FillerReports))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FillerImages))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.supcon.com/ExamFillerWS")]
    public partial class Ens_Messagebody {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(reqBase))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UpdateStatus))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FillerReports))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FillerImages))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.supcon.com/ExamFillerWS")]
    public partial class Ens_Request : Ens_Messagebody {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UpdateStatus))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FillerReports))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FillerImages))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.supcon.com/ExamFillerWS")]
    public partial class reqBase : Ens_Request {
        
        private string msgIDField;
        
        private string msgOrderControlField;
        
        private string msgSenderField;
        
        private string msgReceiverField;
        
        private string msgEventField;
        
        /// <remarks/>
        public string MsgID {
            get {
                return this.msgIDField;
            }
            set {
                this.msgIDField = value;
            }
        }
        
        /// <remarks/>
        public string MsgOrderControl {
            get {
                return this.msgOrderControlField;
            }
            set {
                this.msgOrderControlField = value;
            }
        }
        
        /// <remarks/>
        public string MsgSender {
            get {
                return this.msgSenderField;
            }
            set {
                this.msgSenderField = value;
            }
        }
        
        /// <remarks/>
        public string MsgReceiver {
            get {
                return this.msgReceiverField;
            }
            set {
                this.msgReceiverField = value;
            }
        }
        
        /// <remarks/>
        public string MsgEvent {
            get {
                return this.msgEventField;
            }
            set {
                this.msgEventField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.supcon.com/ExamFillerWS")]
    public partial class UpdateStatus : reqBase {
        
        private string patientIDField;
        
        private string orderNoField;
        
        private string statusField;
        
        private string operIDField;
        
        private string operNameField;
        
        private string operDateTimeField;
        
        private string patientTypeField;
        
        private string memoField;
        
        /// <remarks/>
        public string PatientID {
            get {
                return this.patientIDField;
            }
            set {
                this.patientIDField = value;
            }
        }
        
        /// <remarks/>
        public string OrderNo {
            get {
                return this.orderNoField;
            }
            set {
                this.orderNoField = value;
            }
        }
        
        /// <remarks/>
        public string Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        public string OperID {
            get {
                return this.operIDField;
            }
            set {
                this.operIDField = value;
            }
        }
        
        /// <remarks/>
        public string OperName {
            get {
                return this.operNameField;
            }
            set {
                this.operNameField = value;
            }
        }
        
        /// <remarks/>
        public string OperDateTime {
            get {
                return this.operDateTimeField;
            }
            set {
                this.operDateTimeField = value;
            }
        }
        
        /// <remarks/>
        public string PatientType {
            get {
                return this.patientTypeField;
            }
            set {
                this.patientTypeField = value;
            }
        }
        
        /// <remarks/>
        public string Memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.supcon.com/ExamFillerWS")]
    public partial class FillerReports : reqBase {
        
        private string examNoField;
        
        private string patientIDField;
        
        private string patientNameField;
        
        private string patientTypeField;
        
        private string visitNoField;
        
        private string reportDocNameField;
        
        private string verifierDocNameField;
        
        private string statusField;
        
        private string reportDateTimeField;
        
        private ReportInfo[] reportInfoField;
        
        /// <remarks/>
        public string ExamNo {
            get {
                return this.examNoField;
            }
            set {
                this.examNoField = value;
            }
        }
        
        /// <remarks/>
        public string PatientID {
            get {
                return this.patientIDField;
            }
            set {
                this.patientIDField = value;
            }
        }
        
        /// <remarks/>
        public string PatientName {
            get {
                return this.patientNameField;
            }
            set {
                this.patientNameField = value;
            }
        }
        
        /// <remarks/>
        public string PatientType {
            get {
                return this.patientTypeField;
            }
            set {
                this.patientTypeField = value;
            }
        }
        
        /// <remarks/>
        public string VisitNo {
            get {
                return this.visitNoField;
            }
            set {
                this.visitNoField = value;
            }
        }
        
        /// <remarks/>
        public string ReportDocName {
            get {
                return this.reportDocNameField;
            }
            set {
                this.reportDocNameField = value;
            }
        }
        
        /// <remarks/>
        public string VerifierDocName {
            get {
                return this.verifierDocNameField;
            }
            set {
                this.verifierDocNameField = value;
            }
        }
        
        /// <remarks/>
        public string Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        public string ReportDateTime {
            get {
                return this.reportDateTimeField;
            }
            set {
                this.reportDateTimeField = value;
            }
        }
        
        /// <remarks/>
        public ReportInfo[] ReportInfo {
            get {
                return this.reportInfoField;
            }
            set {
                this.reportInfoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void ExamImagesSubmitCompletedEventHandler(object sender, ExamImagesSubmitCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ExamImagesSubmitCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ExamImagesSubmitCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void ExamReportsSubmitCompletedEventHandler(object sender, ExamReportsSubmitCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ExamReportsSubmitCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ExamReportsSubmitCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void ExamUpdateStatusCompletedEventHandler(object sender, ExamUpdateStatusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ExamUpdateStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ExamUpdateStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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