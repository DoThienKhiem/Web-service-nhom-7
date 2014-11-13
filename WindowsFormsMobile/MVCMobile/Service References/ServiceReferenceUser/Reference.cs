﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCMobile.ServiceReferenceUser {
    using System.Runtime.Serialization;
    using System;
    
    
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceUser.IServiceUser")]
    public interface IServiceUser {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/findAll", ReplyAction="http://tempuri.org/IServiceUser/findAllResponse")]
        MVCMobile.ServiceReferenceUser.NguoiDung[] findAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/findAll", ReplyAction="http://tempuri.org/IServiceUser/findAllResponse")]
        System.Threading.Tasks.Task<MVCMobile.ServiceReferenceUser.NguoiDung[]> findAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/AddUser", ReplyAction="http://tempuri.org/IServiceUser/AddUserResponse")]
        bool AddUser(string username, string password, int quyen, string diachi, string hotennd, string NgaySinh, string email, string SoDienThoai);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/AddUser", ReplyAction="http://tempuri.org/IServiceUser/AddUserResponse")]
        System.Threading.Tasks.Task<bool> AddUserAsync(string username, string password, int quyen, string diachi, string hotennd, string NgaySinh, string email, string SoDienThoai);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/Login", ReplyAction="http://tempuri.org/IServiceUser/LoginResponse")]
        bool Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/Login", ReplyAction="http://tempuri.org/IServiceUser/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/EditUser", ReplyAction="http://tempuri.org/IServiceUser/EditUserResponse")]
        bool EditUser(string username, string password, int quyen, string diachi, string hotennd, string NgaySinh, string email, string SoDienThoai);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/EditUser", ReplyAction="http://tempuri.org/IServiceUser/EditUserResponse")]
        System.Threading.Tasks.Task<bool> EditUserAsync(string username, string password, int quyen, string diachi, string hotennd, string NgaySinh, string email, string SoDienThoai);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/XoaUser", ReplyAction="http://tempuri.org/IServiceUser/XoaUserResponse")]
        bool XoaUser(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/XoaUser", ReplyAction="http://tempuri.org/IServiceUser/XoaUserResponse")]
        System.Threading.Tasks.Task<bool> XoaUserAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/GetById", ReplyAction="http://tempuri.org/IServiceUser/GetByIdResponse")]
        MVCMobile.ServiceReferenceUser.NguoiDung[] GetById(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/GetById", ReplyAction="http://tempuri.org/IServiceUser/GetByIdResponse")]
        System.Threading.Tasks.Task<MVCMobile.ServiceReferenceUser.NguoiDung[]> GetByIdAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/GetByName", ReplyAction="http://tempuri.org/IServiceUser/GetByNameResponse")]
        MVCMobile.ServiceReferenceUser.NguoiDung[] GetByName(string hotennd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/GetByName", ReplyAction="http://tempuri.org/IServiceUser/GetByNameResponse")]
        System.Threading.Tasks.Task<MVCMobile.ServiceReferenceUser.NguoiDung[]> GetByNameAsync(string hotennd);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceUserChannel : MVCMobile.ServiceReferenceUser.IServiceUser, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceUserClient : System.ServiceModel.ClientBase<MVCMobile.ServiceReferenceUser.IServiceUser>, MVCMobile.ServiceReferenceUser.IServiceUser {
        
        public ServiceUserClient() {
        }
        
        public ServiceUserClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceUserClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceUserClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceUserClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MVCMobile.ServiceReferenceUser.NguoiDung[] findAll() {
            return base.Channel.findAll();
        }
        
        public System.Threading.Tasks.Task<MVCMobile.ServiceReferenceUser.NguoiDung[]> findAllAsync() {
            return base.Channel.findAllAsync();
        }
        
        public bool AddUser(string username, string password, int quyen, string diachi, string hotennd, string NgaySinh, string email, string SoDienThoai) {
            return base.Channel.AddUser(username, password, quyen, diachi, hotennd, NgaySinh, email, SoDienThoai);
        }
        
        public System.Threading.Tasks.Task<bool> AddUserAsync(string username, string password, int quyen, string diachi, string hotennd, string NgaySinh, string email, string SoDienThoai) {
            return base.Channel.AddUserAsync(username, password, quyen, diachi, hotennd, NgaySinh, email, SoDienThoai);
        }
        
        public bool Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        public bool EditUser(string username, string password, int quyen, string diachi, string hotennd, string NgaySinh, string email, string SoDienThoai) {
            return base.Channel.EditUser(username, password, quyen, diachi, hotennd, NgaySinh, email, SoDienThoai);
        }
        
        public System.Threading.Tasks.Task<bool> EditUserAsync(string username, string password, int quyen, string diachi, string hotennd, string NgaySinh, string email, string SoDienThoai) {
            return base.Channel.EditUserAsync(username, password, quyen, diachi, hotennd, NgaySinh, email, SoDienThoai);
        }
        
        public bool XoaUser(string username) {
            return base.Channel.XoaUser(username);
        }
        
        public System.Threading.Tasks.Task<bool> XoaUserAsync(string username) {
            return base.Channel.XoaUserAsync(username);
        }
        
        public MVCMobile.ServiceReferenceUser.NguoiDung[] GetById(string username) {
            return base.Channel.GetById(username);
        }
        
        public System.Threading.Tasks.Task<MVCMobile.ServiceReferenceUser.NguoiDung[]> GetByIdAsync(string username) {
            return base.Channel.GetByIdAsync(username);
        }
        
        public MVCMobile.ServiceReferenceUser.NguoiDung[] GetByName(string hotennd) {
            return base.Channel.GetByName(hotennd);
        }
        
        public System.Threading.Tasks.Task<MVCMobile.ServiceReferenceUser.NguoiDung[]> GetByNameAsync(string hotennd) {
            return base.Channel.GetByNameAsync(hotennd);
        }

        internal NguoiDung EditUser(string p)
        {
            throw new NotImplementedException();
        }

        internal void EditUser(string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8)
        {
            throw new NotImplementedException();
        }

        internal void AddUser(string p1, string p2, string p3, string p4, string p5, string p6, string p7)
        {
            throw new NotImplementedException();
        }
    }
}
