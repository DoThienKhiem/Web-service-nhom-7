﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCMobile.ServiceReferenceSanPham {
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
        private MVCMobile.ServiceReferenceSanPham.DanhMucSP DanhMucSPField;
        
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
        public MVCMobile.ServiceReferenceSanPham.DanhMucSP DanhMucSP {
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
        MVCMobile.ServiceReferenceSanPham.SanPham[] findAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/findAll", ReplyAction="http://tempuri.org/IServiceSanPham/findAllResponse")]
        System.Threading.Tasks.Task<MVCMobile.ServiceReferenceSanPham.SanPham[]> findAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/SanPhamTheoLoai", ReplyAction="http://tempuri.org/IServiceSanPham/SanPhamTheoLoaiResponse")]
        MVCMobile.ServiceReferenceSanPham.SanPham[] SanPhamTheoLoai(string loai);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/SanPhamTheoLoai", ReplyAction="http://tempuri.org/IServiceSanPham/SanPhamTheoLoaiResponse")]
        System.Threading.Tasks.Task<MVCMobile.ServiceReferenceSanPham.SanPham[]> SanPhamTheoLoaiAsync(string loai);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/TimKiem", ReplyAction="http://tempuri.org/IServiceSanPham/TimKiemResponse")]
        MVCMobile.ServiceReferenceSanPham.SanPham[] TimKiem(string loai);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/TimKiem", ReplyAction="http://tempuri.org/IServiceSanPham/TimKiemResponse")]
        System.Threading.Tasks.Task<MVCMobile.ServiceReferenceSanPham.SanPham[]> TimKiemAsync(string loai);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/insert", ReplyAction="http://tempuri.org/IServiceSanPham/insertResponse")]
        bool insert(int masp, string tensp, string mota, int gia, int soluong, string hinhanh, string ghichu, string madm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/insert", ReplyAction="http://tempuri.org/IServiceSanPham/insertResponse")]
        System.Threading.Tasks.Task<bool> insertAsync(int masp, string tensp, string mota, int gia, int soluong, string hinhanh, string ghichu, string madm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/delete", ReplyAction="http://tempuri.org/IServiceSanPham/deleteResponse")]
        bool delete(int masp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/delete", ReplyAction="http://tempuri.org/IServiceSanPham/deleteResponse")]
        System.Threading.Tasks.Task<bool> deleteAsync(int masp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/ChiTietSP", ReplyAction="http://tempuri.org/IServiceSanPham/ChiTietSPResponse")]
        MVCMobile.ServiceReferenceSanPham.SanPham ChiTietSP(int masp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/ChiTietSP", ReplyAction="http://tempuri.org/IServiceSanPham/ChiTietSPResponse")]
        System.Threading.Tasks.Task<MVCMobile.ServiceReferenceSanPham.SanPham> ChiTietSPAsync(int masp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/Update", ReplyAction="http://tempuri.org/IServiceSanPham/UpdateResponse")]
        bool Update(int masp, string tensp, string mota, int gia, int soluong, string hinhanh, string ghichu, string madm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/Update", ReplyAction="http://tempuri.org/IServiceSanPham/UpdateResponse")]
        System.Threading.Tasks.Task<bool> UpdateAsync(int masp, string tensp, string mota, int gia, int soluong, string hinhanh, string ghichu, string madm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/GetById", ReplyAction="http://tempuri.org/IServiceSanPham/GetByIdResponse")]
        MVCMobile.ServiceReferenceSanPham.SanPham[] GetById(int masp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/GetById", ReplyAction="http://tempuri.org/IServiceSanPham/GetByIdResponse")]
        System.Threading.Tasks.Task<MVCMobile.ServiceReferenceSanPham.SanPham[]> GetByIdAsync(int masp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/GetByName", ReplyAction="http://tempuri.org/IServiceSanPham/GetByNameResponse")]
        MVCMobile.ServiceReferenceSanPham.SanPham[] GetByName(string tensp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/GetByName", ReplyAction="http://tempuri.org/IServiceSanPham/GetByNameResponse")]
        System.Threading.Tasks.Task<MVCMobile.ServiceReferenceSanPham.SanPham[]> GetByNameAsync(string tensp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/GetByDanhMuc", ReplyAction="http://tempuri.org/IServiceSanPham/GetByDanhMucResponse")]
        MVCMobile.ServiceReferenceSanPham.SanPham[] GetByDanhMuc(int madm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPham/GetByDanhMuc", ReplyAction="http://tempuri.org/IServiceSanPham/GetByDanhMucResponse")]
        System.Threading.Tasks.Task<MVCMobile.ServiceReferenceSanPham.SanPham[]> GetByDanhMucAsync(int madm);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceSanPhamChannel : MVCMobile.ServiceReferenceSanPham.IServiceSanPham, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceSanPhamClient : System.ServiceModel.ClientBase<MVCMobile.ServiceReferenceSanPham.IServiceSanPham>, MVCMobile.ServiceReferenceSanPham.IServiceSanPham {
        
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
        
        public MVCMobile.ServiceReferenceSanPham.SanPham[] findAll() {
            return base.Channel.findAll();
        }
        
        public System.Threading.Tasks.Task<MVCMobile.ServiceReferenceSanPham.SanPham[]> findAllAsync() {
            return base.Channel.findAllAsync();
        }
        
        public MVCMobile.ServiceReferenceSanPham.SanPham[] SanPhamTheoLoai(string loai) {
            return base.Channel.SanPhamTheoLoai(loai);
        }
        
        public System.Threading.Tasks.Task<MVCMobile.ServiceReferenceSanPham.SanPham[]> SanPhamTheoLoaiAsync(string loai) {
            return base.Channel.SanPhamTheoLoaiAsync(loai);
        }
        
        public MVCMobile.ServiceReferenceSanPham.SanPham[] TimKiem(string loai) {
            return base.Channel.TimKiem(loai);
        }
        
        public System.Threading.Tasks.Task<MVCMobile.ServiceReferenceSanPham.SanPham[]> TimKiemAsync(string loai) {
            return base.Channel.TimKiemAsync(loai);
        }
        
        public bool insert(int masp, string tensp, string mota, int gia, int soluong, string hinhanh, string ghichu, string madm) {
            return base.Channel.insert(masp, tensp, mota, gia, soluong, hinhanh, ghichu, madm);
        }
        
        public System.Threading.Tasks.Task<bool> insertAsync(int masp, string tensp, string mota, int gia, int soluong, string hinhanh, string ghichu, string madm) {
            return base.Channel.insertAsync(masp, tensp, mota, gia, soluong, hinhanh, ghichu, madm);
        }
        
        public bool delete(int masp) {
            return base.Channel.delete(masp);
        }
        
        public System.Threading.Tasks.Task<bool> deleteAsync(int masp) {
            return base.Channel.deleteAsync(masp);
        }
        
        public MVCMobile.ServiceReferenceSanPham.SanPham ChiTietSP(int masp) {
            return base.Channel.ChiTietSP(masp);
        }
        
        public System.Threading.Tasks.Task<MVCMobile.ServiceReferenceSanPham.SanPham> ChiTietSPAsync(int masp) {
            return base.Channel.ChiTietSPAsync(masp);
        }
        
        public bool Update(int masp, string tensp, string mota, int gia, int soluong, string hinhanh, string ghichu, string madm) {
            return base.Channel.Update(masp, tensp, mota, gia, soluong, hinhanh, ghichu, madm);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateAsync(int masp, string tensp, string mota, int gia, int soluong, string hinhanh, string ghichu, string madm) {
            return base.Channel.UpdateAsync(masp, tensp, mota, gia, soluong, hinhanh, ghichu, madm);
        }
        
        public MVCMobile.ServiceReferenceSanPham.SanPham[] GetById(int masp) {
            return base.Channel.GetById(masp);
        }
        
        public System.Threading.Tasks.Task<MVCMobile.ServiceReferenceSanPham.SanPham[]> GetByIdAsync(int masp) {
            return base.Channel.GetByIdAsync(masp);
        }
        
        public MVCMobile.ServiceReferenceSanPham.SanPham[] GetByName(string tensp) {
            return base.Channel.GetByName(tensp);
        }
        
        public System.Threading.Tasks.Task<MVCMobile.ServiceReferenceSanPham.SanPham[]> GetByNameAsync(string tensp) {
            return base.Channel.GetByNameAsync(tensp);
        }
        
        public MVCMobile.ServiceReferenceSanPham.SanPham[] GetByDanhMuc(int madm) {
            return base.Channel.GetByDanhMuc(madm);
        }
        
        public System.Threading.Tasks.Task<MVCMobile.ServiceReferenceSanPham.SanPham[]> GetByDanhMucAsync(int madm) {
            return base.Channel.GetByDanhMucAsync(madm);
        }
    }
}