﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsMobile.ServiceReferenceSanPham {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SanPham", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceMobile")]
    [System.SerializableAttribute()]
    public partial class SanPham : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsFormsMobile.ServiceReferenceSanPham.DanhMucSP DanhMucSPField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GhiChuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> GiaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HinhAnhField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaDMField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaSPField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MoTaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> SoLuongField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenSPField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> TrangThaiField;
        
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
        public WindowsFormsMobile.ServiceReferenceSanPham.DanhMucSP DanhMucSP {
            get {
                return this.DanhMucSPField;
            }
            set {
                if ((object.ReferenceEquals(this.DanhMucSPField, value) != true)) {
                    this.DanhMucSPField = value;
                    this.RaisePropertyChanged("DanhMucSP");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GhiChu {
            get {
                return this.GhiChuField;
            }
            set {
                if ((object.ReferenceEquals(this.GhiChuField, value) != true)) {
                    this.GhiChuField = value;
                    this.RaisePropertyChanged("GhiChu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Gia {
            get {
                return this.GiaField;
            }
            set {
                if ((this.GiaField.Equals(value) != true)) {
                    this.GiaField = value;
                    this.RaisePropertyChanged("Gia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HinhAnh {
            get {
                return this.HinhAnhField;
            }
            set {
                if ((object.ReferenceEquals(this.HinhAnhField, value) != true)) {
                    this.HinhAnhField = value;
                    this.RaisePropertyChanged("HinhAnh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MaDM {
            get {
                return this.MaDMField;
            }
            set {
                if ((object.ReferenceEquals(this.MaDMField, value) != true)) {
                    this.MaDMField = value;
                    this.RaisePropertyChanged("MaDM");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaSP {
            get {
                return this.MaSPField;
            }
            set {
                if ((this.MaSPField.Equals(value) != true)) {
                    this.MaSPField = value;
                    this.RaisePropertyChanged("MaSP");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MoTa {
            get {
                return this.MoTaField;
            }
            set {
                if ((object.ReferenceEquals(this.MoTaField, value) != true)) {
                    this.MoTaField = value;
                    this.RaisePropertyChanged("MoTa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> SoLuong {
            get {
                return this.SoLuongField;
            }
            set {
                if ((this.SoLuongField.Equals(value) != true)) {
                    this.SoLuongField = value;
                    this.RaisePropertyChanged("SoLuong");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TenSP {
            get {
                return this.TenSPField;
            }
            set {
                if ((object.ReferenceEquals(this.TenSPField, value) != true)) {
                    this.TenSPField = value;
                    this.RaisePropertyChanged("TenSP");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> TrangThai {
            get {
                return this.TrangThaiField;
            }
            set {
                if ((this.TrangThaiField.Equals(value) != true)) {
                    this.TrangThaiField = value;
                    this.RaisePropertyChanged("TrangThai");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DanhMucSP", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceMobile")]
    [System.SerializableAttribute()]
    public partial class DanhMucSP : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaDMField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenDMField;
        
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
        public string MaDM {
            get {
                return this.MaDMField;
            }
            set {
                if ((object.ReferenceEquals(this.MaDMField, value) != true)) {
                    this.MaDMField = value;
                    this.RaisePropertyChanged("MaDM");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TenDM {
            get {
                return this.TenDMField;
            }
            set {
                if ((object.ReferenceEquals(this.TenDMField, value) != true)) {
                    this.TenDMField = value;
                    this.RaisePropertyChanged("TenDM");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceSanPham.IServiceSanPham")]
    public interface IServiceSanPham {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/findAll", ReplyAction="http://tempuri.org/IServiceSanPham/findAllResponse")]
        WindowsFormsMobile.ServiceReferenceSanPham.SanPham[] findAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/findAll", ReplyAction="http://tempuri.org/IServiceSanPham/findAllResponse")]
        System.Threading.Tasks.Task<WindowsFormsMobile.ServiceReferenceSanPham.SanPham[]> findAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/insert", ReplyAction="http://tempuri.org/IServiceSanPham/insertResponse")]
        bool insert(string tensp, string mota, int gia, int soluong, string hinhanh, string ghichu, string madm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/insert", ReplyAction="http://tempuri.org/IServiceSanPham/insertResponse")]
        System.Threading.Tasks.Task<bool> insertAsync(string tensp, string mota, int gia, int soluong, string hinhanh, string ghichu, string madm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/delete", ReplyAction="http://tempuri.org/IServiceSanPham/deleteResponse")]
        bool delete(int masp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/delete", ReplyAction="http://tempuri.org/IServiceSanPham/deleteResponse")]
        System.Threading.Tasks.Task<bool> deleteAsync(int masp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/Update", ReplyAction="http://tempuri.org/IServiceSanPham/UpdateResponse")]
        bool Update(int masp, string tensp, string mota, int gia, int soluong, string hinhanh, string ghichu, string madm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/Update", ReplyAction="http://tempuri.org/IServiceSanPham/UpdateResponse")]
        System.Threading.Tasks.Task<bool> UpdateAsync(int masp, string tensp, string mota, int gia, int soluong, string hinhanh, string ghichu, string madm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/GetByIdsp", ReplyAction="http://tempuri.org/IServiceSanPham/GetByIdspResponse")]
        WindowsFormsMobile.ServiceReferenceSanPham.SanPham[] GetByIdsp(int masp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/GetByIdsp", ReplyAction="http://tempuri.org/IServiceSanPham/GetByIdspResponse")]
        System.Threading.Tasks.Task<WindowsFormsMobile.ServiceReferenceSanPham.SanPham[]> GetByIdspAsync(int masp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/GetByNamesp", ReplyAction="http://tempuri.org/IServiceSanPham/GetByNamespResponse")]
        WindowsFormsMobile.ServiceReferenceSanPham.SanPham[] GetByNamesp(string tensp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/GetByNamesp", ReplyAction="http://tempuri.org/IServiceSanPham/GetByNamespResponse")]
        System.Threading.Tasks.Task<WindowsFormsMobile.ServiceReferenceSanPham.SanPham[]> GetByNamespAsync(string tensp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/GetByDanhMucsp", ReplyAction="http://tempuri.org/IServiceSanPham/GetByDanhMucspResponse")]
        WindowsFormsMobile.ServiceReferenceSanPham.SanPham[] GetByDanhMucsp(string madm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/GetByDanhMucsp", ReplyAction="http://tempuri.org/IServiceSanPham/GetByDanhMucspResponse")]
        System.Threading.Tasks.Task<WindowsFormsMobile.ServiceReferenceSanPham.SanPham[]> GetByDanhMucspAsync(string madm);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceSanPhamChannel : WindowsFormsMobile.ServiceReferenceSanPham.IServiceSanPham, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceSanPhamClient : System.ServiceModel.ClientBase<WindowsFormsMobile.ServiceReferenceSanPham.IServiceSanPham>, WindowsFormsMobile.ServiceReferenceSanPham.IServiceSanPham {
        
        public ServiceSanPhamClient() {
        }
        
        public ServiceSanPhamClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceSanPhamClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSanPhamClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSanPhamClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WindowsFormsMobile.ServiceReferenceSanPham.SanPham[] findAll() {
            return base.Channel.findAll();
        }
        
        public System.Threading.Tasks.Task<WindowsFormsMobile.ServiceReferenceSanPham.SanPham[]> findAllAsync() {
            return base.Channel.findAllAsync();
        }
        
        public bool insert(string tensp, string mota, int gia, int soluong, string hinhanh, string ghichu, string madm) {
            return base.Channel.insert(tensp, mota, gia, soluong, hinhanh, ghichu, madm);
        }
        
        public System.Threading.Tasks.Task<bool> insertAsync(string tensp, string mota, int gia, int soluong, string hinhanh, string ghichu, string madm) {
            return base.Channel.insertAsync(tensp, mota, gia, soluong, hinhanh, ghichu, madm);
        }
        
        public bool delete(int masp) {
            return base.Channel.delete(masp);
        }
        
        public System.Threading.Tasks.Task<bool> deleteAsync(int masp) {
            return base.Channel.deleteAsync(masp);
        }
        
        public bool Update(int masp, string tensp, string mota, int gia, int soluong, string hinhanh, string ghichu, string madm) {
            return base.Channel.Update(masp, tensp, mota, gia, soluong, hinhanh, ghichu, madm);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateAsync(int masp, string tensp, string mota, int gia, int soluong, string hinhanh, string ghichu, string madm) {
            return base.Channel.UpdateAsync(masp, tensp, mota, gia, soluong, hinhanh, ghichu, madm);
        }
        
        public WindowsFormsMobile.ServiceReferenceSanPham.SanPham[] GetByIdsp(int masp) {
            return base.Channel.GetByIdsp(masp);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsMobile.ServiceReferenceSanPham.SanPham[]> GetByIdspAsync(int masp) {
            return base.Channel.GetByIdspAsync(masp);
        }
        
        public WindowsFormsMobile.ServiceReferenceSanPham.SanPham[] GetByNamesp(string tensp) {
            return base.Channel.GetByNamesp(tensp);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsMobile.ServiceReferenceSanPham.SanPham[]> GetByNamespAsync(string tensp) {
            return base.Channel.GetByNamespAsync(tensp);
        }
        
        public WindowsFormsMobile.ServiceReferenceSanPham.SanPham[] GetByDanhMucsp(string madm) {
            return base.Channel.GetByDanhMucsp(madm);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsMobile.ServiceReferenceSanPham.SanPham[]> GetByDanhMucspAsync(string madm) {
            return base.Channel.GetByDanhMucspAsync(madm);
        }
    }
}
