﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsMobile.ServiceReferenceDonHang {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DonHang", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceMobile")]
    [System.SerializableAttribute()]
    public partial class DonHang : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaDHField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> NgayDatHangField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsFormsMobile.ServiceReferenceDonHang.NguoiDung NguoiDungField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> TongTienField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TrangThaiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsFormsMobile.ServiceReferenceDonHang.TrangThai TrangThai1Field;
        
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
        public string IDUser {
            get {
                return this.IDUserField;
            }
            set {
                if ((object.ReferenceEquals(this.IDUserField, value) != true)) {
                    this.IDUserField = value;
                    this.RaisePropertyChanged("IDUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaDH {
            get {
                return this.MaDHField;
            }
            set {
                if ((this.MaDHField.Equals(value) != true)) {
                    this.MaDHField = value;
                    this.RaisePropertyChanged("MaDH");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> NgayDatHang {
            get {
                return this.NgayDatHangField;
            }
            set {
                if ((this.NgayDatHangField.Equals(value) != true)) {
                    this.NgayDatHangField = value;
                    this.RaisePropertyChanged("NgayDatHang");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WindowsFormsMobile.ServiceReferenceDonHang.NguoiDung NguoiDung {
            get {
                return this.NguoiDungField;
            }
            set {
                if ((object.ReferenceEquals(this.NguoiDungField, value) != true)) {
                    this.NguoiDungField = value;
                    this.RaisePropertyChanged("NguoiDung");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> TongTien {
            get {
                return this.TongTienField;
            }
            set {
                if ((this.TongTienField.Equals(value) != true)) {
                    this.TongTienField = value;
                    this.RaisePropertyChanged("TongTien");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TrangThai {
            get {
                return this.TrangThaiField;
            }
            set {
                if ((object.ReferenceEquals(this.TrangThaiField, value) != true)) {
                    this.TrangThaiField = value;
                    this.RaisePropertyChanged("TrangThai");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WindowsFormsMobile.ServiceReferenceDonHang.TrangThai TrangThai1 {
            get {
                return this.TrangThai1Field;
            }
            set {
                if ((object.ReferenceEquals(this.TrangThai1Field, value) != true)) {
                    this.TrangThai1Field = value;
                    this.RaisePropertyChanged("TrangThai1");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="NguoiDung", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceMobile")]
    [System.SerializableAttribute()]
    public partial class NguoiDung : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DiaChiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HoTenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NgaySinhField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PassField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsFormsMobile.ServiceReferenceDonHang.PhanQuyen PhanQuyenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> QuyenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SDTField;
        
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
        public string DiaChi {
            get {
                return this.DiaChiField;
            }
            set {
                if ((object.ReferenceEquals(this.DiaChiField, value) != true)) {
                    this.DiaChiField = value;
                    this.RaisePropertyChanged("DiaChi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HoTen {
            get {
                return this.HoTenField;
            }
            set {
                if ((object.ReferenceEquals(this.HoTenField, value) != true)) {
                    this.HoTenField = value;
                    this.RaisePropertyChanged("HoTen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IDUser {
            get {
                return this.IDUserField;
            }
            set {
                if ((object.ReferenceEquals(this.IDUserField, value) != true)) {
                    this.IDUserField = value;
                    this.RaisePropertyChanged("IDUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NgaySinh {
            get {
                return this.NgaySinhField;
            }
            set {
                if ((object.ReferenceEquals(this.NgaySinhField, value) != true)) {
                    this.NgaySinhField = value;
                    this.RaisePropertyChanged("NgaySinh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Pass {
            get {
                return this.PassField;
            }
            set {
                if ((object.ReferenceEquals(this.PassField, value) != true)) {
                    this.PassField = value;
                    this.RaisePropertyChanged("Pass");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WindowsFormsMobile.ServiceReferenceDonHang.PhanQuyen PhanQuyen {
            get {
                return this.PhanQuyenField;
            }
            set {
                if ((object.ReferenceEquals(this.PhanQuyenField, value) != true)) {
                    this.PhanQuyenField = value;
                    this.RaisePropertyChanged("PhanQuyen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Quyen {
            get {
                return this.QuyenField;
            }
            set {
                if ((this.QuyenField.Equals(value) != true)) {
                    this.QuyenField = value;
                    this.RaisePropertyChanged("Quyen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SDT {
            get {
                return this.SDTField;
            }
            set {
                if ((object.ReferenceEquals(this.SDTField, value) != true)) {
                    this.SDTField = value;
                    this.RaisePropertyChanged("SDT");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TrangThai", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceMobile")]
    [System.SerializableAttribute()]
    public partial class TrangThai : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaTTField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenTTField;
        
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
        public string MaTT {
            get {
                return this.MaTTField;
            }
            set {
                if ((object.ReferenceEquals(this.MaTTField, value) != true)) {
                    this.MaTTField = value;
                    this.RaisePropertyChanged("MaTT");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TenTT {
            get {
                return this.TenTTField;
            }
            set {
                if ((object.ReferenceEquals(this.TenTTField, value) != true)) {
                    this.TenTTField = value;
                    this.RaisePropertyChanged("TenTT");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PhanQuyen", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceMobile")]
    [System.SerializableAttribute()]
    public partial class PhanQuyen : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaQuyenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenQuyenField;
        
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
        public int MaQuyen {
            get {
                return this.MaQuyenField;
            }
            set {
                if ((this.MaQuyenField.Equals(value) != true)) {
                    this.MaQuyenField = value;
                    this.RaisePropertyChanged("MaQuyen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TenQuyen {
            get {
                return this.TenQuyenField;
            }
            set {
                if ((object.ReferenceEquals(this.TenQuyenField, value) != true)) {
                    this.TenQuyenField = value;
                    this.RaisePropertyChanged("TenQuyen");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceDonHang.IServiceDonHang")]
    public interface IServiceDonHang {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDonHang/GetAll", ReplyAction="http://tempuri.org/IServiceDonHang/GetAllResponse")]
        WindowsFormsMobile.ServiceReferenceDonHang.DonHang[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDonHang/GetAll", ReplyAction="http://tempuri.org/IServiceDonHang/GetAllResponse")]
        System.Threading.Tasks.Task<WindowsFormsMobile.ServiceReferenceDonHang.DonHang[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDonHang/GetByID", ReplyAction="http://tempuri.org/IServiceDonHang/GetByIDResponse")]
        WindowsFormsMobile.ServiceReferenceDonHang.DonHang[] GetByID(int madh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDonHang/GetByID", ReplyAction="http://tempuri.org/IServiceDonHang/GetByIDResponse")]
        System.Threading.Tasks.Task<WindowsFormsMobile.ServiceReferenceDonHang.DonHang[]> GetByIDAsync(int madh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDonHang/GetByName", ReplyAction="http://tempuri.org/IServiceDonHang/GetByNameResponse")]
        WindowsFormsMobile.ServiceReferenceDonHang.DonHang[] GetByName(string iduser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDonHang/GetByName", ReplyAction="http://tempuri.org/IServiceDonHang/GetByNameResponse")]
        System.Threading.Tasks.Task<WindowsFormsMobile.ServiceReferenceDonHang.DonHang[]> GetByNameAsync(string iduser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDonHang/Update", ReplyAction="http://tempuri.org/IServiceDonHang/UpdateResponse")]
        bool Update(int madh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDonHang/Update", ReplyAction="http://tempuri.org/IServiceDonHang/UpdateResponse")]
        System.Threading.Tasks.Task<bool> UpdateAsync(int madh);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceDonHangChannel : WindowsFormsMobile.ServiceReferenceDonHang.IServiceDonHang, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceDonHangClient : System.ServiceModel.ClientBase<WindowsFormsMobile.ServiceReferenceDonHang.IServiceDonHang>, WindowsFormsMobile.ServiceReferenceDonHang.IServiceDonHang {
        
        public ServiceDonHangClient() {
        }
        
        public ServiceDonHangClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceDonHangClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceDonHangClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceDonHangClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WindowsFormsMobile.ServiceReferenceDonHang.DonHang[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<WindowsFormsMobile.ServiceReferenceDonHang.DonHang[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public WindowsFormsMobile.ServiceReferenceDonHang.DonHang[] GetByID(int madh) {
            return base.Channel.GetByID(madh);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsMobile.ServiceReferenceDonHang.DonHang[]> GetByIDAsync(int madh) {
            return base.Channel.GetByIDAsync(madh);
        }
        
        public WindowsFormsMobile.ServiceReferenceDonHang.DonHang[] GetByName(string iduser) {
            return base.Channel.GetByName(iduser);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsMobile.ServiceReferenceDonHang.DonHang[]> GetByNameAsync(string iduser) {
            return base.Channel.GetByNameAsync(iduser);
        }
        
        public bool Update(int madh) {
            return base.Channel.Update(madh);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateAsync(int madh) {
            return base.Channel.UpdateAsync(madh);
        }
    }
}