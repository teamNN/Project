﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ungdungdoctintuc.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="WebsiteTinTuc")]
	public partial class DbTinTucDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAdmin(Admin instance);
    partial void UpdateAdmin(Admin instance);
    partial void DeleteAdmin(Admin instance);
    partial void InsertBinhLuan(BinhLuan instance);
    partial void UpdateBinhLuan(BinhLuan instance);
    partial void DeleteBinhLuan(BinhLuan instance);
    partial void InsertChuyenMuc(ChuyenMuc instance);
    partial void UpdateChuyenMuc(ChuyenMuc instance);
    partial void DeleteChuyenMuc(ChuyenMuc instance);
    partial void InsertDocGia(DocGia instance);
    partial void UpdateDocGia(DocGia instance);
    partial void DeleteDocGia(DocGia instance);
    partial void InsertTheLoai(TheLoai instance);
    partial void UpdateTheLoai(TheLoai instance);
    partial void DeleteTheLoai(TheLoai instance);
    partial void InsertVote(Vote instance);
    partial void UpdateVote(Vote instance);
    partial void DeleteVote(Vote instance);
    partial void InsertTin(Tin instance);
    partial void UpdateTin(Tin instance);
    partial void DeleteTin(Tin instance);
    #endregion
		
		public DbTinTucDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["WebsiteTinTucConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DbTinTucDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbTinTucDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbTinTucDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbTinTucDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Admin> Admins
		{
			get
			{
				return this.GetTable<Admin>();
			}
		}
		
		public System.Data.Linq.Table<BinhLuan> BinhLuans
		{
			get
			{
				return this.GetTable<BinhLuan>();
			}
		}
		
		public System.Data.Linq.Table<ChuyenMuc> ChuyenMucs
		{
			get
			{
				return this.GetTable<ChuyenMuc>();
			}
		}
		
		public System.Data.Linq.Table<DocGia> DocGias
		{
			get
			{
				return this.GetTable<DocGia>();
			}
		}
		
		public System.Data.Linq.Table<TheLoai> TheLoais
		{
			get
			{
				return this.GetTable<TheLoai>();
			}
		}
		
		public System.Data.Linq.Table<Vote> Votes
		{
			get
			{
				return this.GetTable<Vote>();
			}
		}
		
		public System.Data.Linq.Table<Tin> Tins
		{
			get
			{
				return this.GetTable<Tin>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admin")]
	public partial class Admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdAdmin;
		
		private string _Username;
		
		private string _Password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdAdminChanging(int value);
    partial void OnIdAdminChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public Admin()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdAdmin", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdAdmin
		{
			get
			{
				return this._IdAdmin;
			}
			set
			{
				if ((this._IdAdmin != value))
				{
					this.OnIdAdminChanging(value);
					this.SendPropertyChanging();
					this._IdAdmin = value;
					this.SendPropertyChanged("IdAdmin");
					this.OnIdAdminChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BinhLuan")]
	public partial class BinhLuan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdBinhLuan;
		
		private System.Nullable<int> _IdTin;
		
		private System.Nullable<int> _IdDocGia;
		
		private string _NoiDung;
		
		private EntityRef<DocGia> _DocGia;
		
		private EntityRef<Tin> _Tin;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdBinhLuanChanging(int value);
    partial void OnIdBinhLuanChanged();
    partial void OnIdTinChanging(System.Nullable<int> value);
    partial void OnIdTinChanged();
    partial void OnIdDocGiaChanging(System.Nullable<int> value);
    partial void OnIdDocGiaChanged();
    partial void OnNoiDungChanging(string value);
    partial void OnNoiDungChanged();
    #endregion
		
		public BinhLuan()
		{
			this._DocGia = default(EntityRef<DocGia>);
			this._Tin = default(EntityRef<Tin>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdBinhLuan", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdBinhLuan
		{
			get
			{
				return this._IdBinhLuan;
			}
			set
			{
				if ((this._IdBinhLuan != value))
				{
					this.OnIdBinhLuanChanging(value);
					this.SendPropertyChanging();
					this._IdBinhLuan = value;
					this.SendPropertyChanged("IdBinhLuan");
					this.OnIdBinhLuanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTin", DbType="Int")]
		public System.Nullable<int> IdTin
		{
			get
			{
				return this._IdTin;
			}
			set
			{
				if ((this._IdTin != value))
				{
					if (this._Tin.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdTinChanging(value);
					this.SendPropertyChanging();
					this._IdTin = value;
					this.SendPropertyChanged("IdTin");
					this.OnIdTinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdDocGia", DbType="Int")]
		public System.Nullable<int> IdDocGia
		{
			get
			{
				return this._IdDocGia;
			}
			set
			{
				if ((this._IdDocGia != value))
				{
					if (this._DocGia.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdDocGiaChanging(value);
					this.SendPropertyChanging();
					this._IdDocGia = value;
					this.SendPropertyChanged("IdDocGia");
					this.OnIdDocGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoiDung", DbType="NText NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string NoiDung
		{
			get
			{
				return this._NoiDung;
			}
			set
			{
				if ((this._NoiDung != value))
				{
					this.OnNoiDungChanging(value);
					this.SendPropertyChanging();
					this._NoiDung = value;
					this.SendPropertyChanged("NoiDung");
					this.OnNoiDungChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DocGia_BinhLuan", Storage="_DocGia", ThisKey="IdDocGia", OtherKey="IdDocGia", IsForeignKey=true)]
		public DocGia DocGia
		{
			get
			{
				return this._DocGia.Entity;
			}
			set
			{
				DocGia previousValue = this._DocGia.Entity;
				if (((previousValue != value) 
							|| (this._DocGia.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DocGia.Entity = null;
						previousValue.BinhLuans.Remove(this);
					}
					this._DocGia.Entity = value;
					if ((value != null))
					{
						value.BinhLuans.Add(this);
						this._IdDocGia = value.IdDocGia;
					}
					else
					{
						this._IdDocGia = default(Nullable<int>);
					}
					this.SendPropertyChanged("DocGia");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tin_BinhLuan", Storage="_Tin", ThisKey="IdTin", OtherKey="IdTin", IsForeignKey=true)]
		public Tin Tin
		{
			get
			{
				return this._Tin.Entity;
			}
			set
			{
				Tin previousValue = this._Tin.Entity;
				if (((previousValue != value) 
							|| (this._Tin.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Tin.Entity = null;
						previousValue.BinhLuans.Remove(this);
					}
					this._Tin.Entity = value;
					if ((value != null))
					{
						value.BinhLuans.Add(this);
						this._IdTin = value.IdTin;
					}
					else
					{
						this._IdTin = default(Nullable<int>);
					}
					this.SendPropertyChanged("Tin");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChuyenMuc")]
	public partial class ChuyenMuc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdChuyenMuc;
		
		private string _TenChuyenMuc;
		
		private System.Nullable<int> _IdTheLoai;
		
		private EntitySet<Tin> _Tins;
		
		private EntityRef<TheLoai> _TheLoai;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChuyenMucChanging(int value);
    partial void OnIdChuyenMucChanged();
    partial void OnTenChuyenMucChanging(string value);
    partial void OnTenChuyenMucChanged();
    partial void OnIdTheLoaiChanging(System.Nullable<int> value);
    partial void OnIdTheLoaiChanged();
    #endregion
		
		public ChuyenMuc()
		{
			this._Tins = new EntitySet<Tin>(new Action<Tin>(this.attach_Tins), new Action<Tin>(this.detach_Tins));
			this._TheLoai = default(EntityRef<TheLoai>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdChuyenMuc", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdChuyenMuc
		{
			get
			{
				return this._IdChuyenMuc;
			}
			set
			{
				if ((this._IdChuyenMuc != value))
				{
					this.OnIdChuyenMucChanging(value);
					this.SendPropertyChanging();
					this._IdChuyenMuc = value;
					this.SendPropertyChanged("IdChuyenMuc");
					this.OnIdChuyenMucChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenChuyenMuc", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string TenChuyenMuc
		{
			get
			{
				return this._TenChuyenMuc;
			}
			set
			{
				if ((this._TenChuyenMuc != value))
				{
					this.OnTenChuyenMucChanging(value);
					this.SendPropertyChanging();
					this._TenChuyenMuc = value;
					this.SendPropertyChanged("TenChuyenMuc");
					this.OnTenChuyenMucChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTheLoai", DbType="Int")]
		public System.Nullable<int> IdTheLoai
		{
			get
			{
				return this._IdTheLoai;
			}
			set
			{
				if ((this._IdTheLoai != value))
				{
					if (this._TheLoai.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdTheLoaiChanging(value);
					this.SendPropertyChanging();
					this._IdTheLoai = value;
					this.SendPropertyChanged("IdTheLoai");
					this.OnIdTheLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ChuyenMuc_Tin", Storage="_Tins", ThisKey="IdChuyenMuc", OtherKey="IdChuyenMuc")]
		public EntitySet<Tin> Tins
		{
			get
			{
				return this._Tins;
			}
			set
			{
				this._Tins.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TheLoai_ChuyenMuc", Storage="_TheLoai", ThisKey="IdTheLoai", OtherKey="IdTheLoai", IsForeignKey=true)]
		public TheLoai TheLoai
		{
			get
			{
				return this._TheLoai.Entity;
			}
			set
			{
				TheLoai previousValue = this._TheLoai.Entity;
				if (((previousValue != value) 
							|| (this._TheLoai.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TheLoai.Entity = null;
						previousValue.ChuyenMucs.Remove(this);
					}
					this._TheLoai.Entity = value;
					if ((value != null))
					{
						value.ChuyenMucs.Add(this);
						this._IdTheLoai = value.IdTheLoai;
					}
					else
					{
						this._IdTheLoai = default(Nullable<int>);
					}
					this.SendPropertyChanged("TheLoai");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Tins(Tin entity)
		{
			this.SendPropertyChanging();
			entity.ChuyenMuc = this;
		}
		
		private void detach_Tins(Tin entity)
		{
			this.SendPropertyChanging();
			entity.ChuyenMuc = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DocGia")]
	public partial class DocGia : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdDocGia;
		
		private string _Username;
		
		private string _Password;
		
		private EntitySet<BinhLuan> _BinhLuans;
		
		private EntitySet<Vote> _Votes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdDocGiaChanging(int value);
    partial void OnIdDocGiaChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public DocGia()
		{
			this._BinhLuans = new EntitySet<BinhLuan>(new Action<BinhLuan>(this.attach_BinhLuans), new Action<BinhLuan>(this.detach_BinhLuans));
			this._Votes = new EntitySet<Vote>(new Action<Vote>(this.attach_Votes), new Action<Vote>(this.detach_Votes));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdDocGia", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdDocGia
		{
			get
			{
				return this._IdDocGia;
			}
			set
			{
				if ((this._IdDocGia != value))
				{
					this.OnIdDocGiaChanging(value);
					this.SendPropertyChanging();
					this._IdDocGia = value;
					this.SendPropertyChanged("IdDocGia");
					this.OnIdDocGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DocGia_BinhLuan", Storage="_BinhLuans", ThisKey="IdDocGia", OtherKey="IdDocGia")]
		public EntitySet<BinhLuan> BinhLuans
		{
			get
			{
				return this._BinhLuans;
			}
			set
			{
				this._BinhLuans.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DocGia_Vote", Storage="_Votes", ThisKey="IdDocGia", OtherKey="IdDocGia")]
		public EntitySet<Vote> Votes
		{
			get
			{
				return this._Votes;
			}
			set
			{
				this._Votes.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_BinhLuans(BinhLuan entity)
		{
			this.SendPropertyChanging();
			entity.DocGia = this;
		}
		
		private void detach_BinhLuans(BinhLuan entity)
		{
			this.SendPropertyChanging();
			entity.DocGia = null;
		}
		
		private void attach_Votes(Vote entity)
		{
			this.SendPropertyChanging();
			entity.DocGia = this;
		}
		
		private void detach_Votes(Vote entity)
		{
			this.SendPropertyChanging();
			entity.DocGia = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TheLoai")]
	public partial class TheLoai : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdTheLoai;
		
		private string _TenLoai;
		
		private EntitySet<ChuyenMuc> _ChuyenMucs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdTheLoaiChanging(int value);
    partial void OnIdTheLoaiChanged();
    partial void OnTenLoaiChanging(string value);
    partial void OnTenLoaiChanged();
    #endregion
		
		public TheLoai()
		{
			this._ChuyenMucs = new EntitySet<ChuyenMuc>(new Action<ChuyenMuc>(this.attach_ChuyenMucs), new Action<ChuyenMuc>(this.detach_ChuyenMucs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTheLoai", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdTheLoai
		{
			get
			{
				return this._IdTheLoai;
			}
			set
			{
				if ((this._IdTheLoai != value))
				{
					this.OnIdTheLoaiChanging(value);
					this.SendPropertyChanging();
					this._IdTheLoai = value;
					this.SendPropertyChanged("IdTheLoai");
					this.OnIdTheLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenLoai", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string TenLoai
		{
			get
			{
				return this._TenLoai;
			}
			set
			{
				if ((this._TenLoai != value))
				{
					this.OnTenLoaiChanging(value);
					this.SendPropertyChanging();
					this._TenLoai = value;
					this.SendPropertyChanged("TenLoai");
					this.OnTenLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TheLoai_ChuyenMuc", Storage="_ChuyenMucs", ThisKey="IdTheLoai", OtherKey="IdTheLoai")]
		public EntitySet<ChuyenMuc> ChuyenMucs
		{
			get
			{
				return this._ChuyenMucs;
			}
			set
			{
				this._ChuyenMucs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_ChuyenMucs(ChuyenMuc entity)
		{
			this.SendPropertyChanging();
			entity.TheLoai = this;
		}
		
		private void detach_ChuyenMucs(ChuyenMuc entity)
		{
			this.SendPropertyChanging();
			entity.TheLoai = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Vote")]
	public partial class Vote : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdVote;
		
		private System.Nullable<int> _IdTin;
		
		private System.Nullable<int> _IdDocGia;
		
		private System.Nullable<bool> _Likee;
		
		private System.Nullable<bool> _DisLike;
		
		private EntityRef<DocGia> _DocGia;
		
		private EntityRef<Tin> _Tin;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdVoteChanging(int value);
    partial void OnIdVoteChanged();
    partial void OnIdTinChanging(System.Nullable<int> value);
    partial void OnIdTinChanged();
    partial void OnIdDocGiaChanging(System.Nullable<int> value);
    partial void OnIdDocGiaChanged();
    partial void OnLikeeChanging(System.Nullable<bool> value);
    partial void OnLikeeChanged();
    partial void OnDisLikeChanging(System.Nullable<bool> value);
    partial void OnDisLikeChanged();
    #endregion
		
		public Vote()
		{
			this._DocGia = default(EntityRef<DocGia>);
			this._Tin = default(EntityRef<Tin>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdVote", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdVote
		{
			get
			{
				return this._IdVote;
			}
			set
			{
				if ((this._IdVote != value))
				{
					this.OnIdVoteChanging(value);
					this.SendPropertyChanging();
					this._IdVote = value;
					this.SendPropertyChanged("IdVote");
					this.OnIdVoteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTin", DbType="Int")]
		public System.Nullable<int> IdTin
		{
			get
			{
				return this._IdTin;
			}
			set
			{
				if ((this._IdTin != value))
				{
					if (this._Tin.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdTinChanging(value);
					this.SendPropertyChanging();
					this._IdTin = value;
					this.SendPropertyChanged("IdTin");
					this.OnIdTinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdDocGia", DbType="Int")]
		public System.Nullable<int> IdDocGia
		{
			get
			{
				return this._IdDocGia;
			}
			set
			{
				if ((this._IdDocGia != value))
				{
					if (this._DocGia.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdDocGiaChanging(value);
					this.SendPropertyChanging();
					this._IdDocGia = value;
					this.SendPropertyChanged("IdDocGia");
					this.OnIdDocGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Likee", DbType="Bit")]
		public System.Nullable<bool> Likee
		{
			get
			{
				return this._Likee;
			}
			set
			{
				if ((this._Likee != value))
				{
					this.OnLikeeChanging(value);
					this.SendPropertyChanging();
					this._Likee = value;
					this.SendPropertyChanged("Likee");
					this.OnLikeeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DisLike", DbType="Bit")]
		public System.Nullable<bool> DisLike
		{
			get
			{
				return this._DisLike;
			}
			set
			{
				if ((this._DisLike != value))
				{
					this.OnDisLikeChanging(value);
					this.SendPropertyChanging();
					this._DisLike = value;
					this.SendPropertyChanged("DisLike");
					this.OnDisLikeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DocGia_Vote", Storage="_DocGia", ThisKey="IdDocGia", OtherKey="IdDocGia", IsForeignKey=true)]
		public DocGia DocGia
		{
			get
			{
				return this._DocGia.Entity;
			}
			set
			{
				DocGia previousValue = this._DocGia.Entity;
				if (((previousValue != value) 
							|| (this._DocGia.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DocGia.Entity = null;
						previousValue.Votes.Remove(this);
					}
					this._DocGia.Entity = value;
					if ((value != null))
					{
						value.Votes.Add(this);
						this._IdDocGia = value.IdDocGia;
					}
					else
					{
						this._IdDocGia = default(Nullable<int>);
					}
					this.SendPropertyChanged("DocGia");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tin_Vote", Storage="_Tin", ThisKey="IdTin", OtherKey="IdTin", IsForeignKey=true)]
		public Tin Tin
		{
			get
			{
				return this._Tin.Entity;
			}
			set
			{
				Tin previousValue = this._Tin.Entity;
				if (((previousValue != value) 
							|| (this._Tin.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Tin.Entity = null;
						previousValue.Votes.Remove(this);
					}
					this._Tin.Entity = value;
					if ((value != null))
					{
						value.Votes.Add(this);
						this._IdTin = value.IdTin;
					}
					else
					{
						this._IdTin = default(Nullable<int>);
					}
					this.SendPropertyChanged("Tin");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tin")]
	public partial class Tin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdTin;
		
		private System.Nullable<int> _IdChuyenMuc;
		
		private string _UrlAnhBia;
		
		private string _TieuDe;
		
		private string _TomTat;
		
		private string _NoiDung;
		
		private System.DateTime _NgayDang;
		
		private string _TacGia;
		
		private EntitySet<BinhLuan> _BinhLuans;
		
		private EntitySet<Vote> _Votes;
		
		private EntityRef<ChuyenMuc> _ChuyenMuc;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdTinChanging(int value);
    partial void OnIdTinChanged();
    partial void OnIdChuyenMucChanging(System.Nullable<int> value);
    partial void OnIdChuyenMucChanged();
    partial void OnUrlAnhBiaChanging(string value);
    partial void OnUrlAnhBiaChanged();
    partial void OnTieuDeChanging(string value);
    partial void OnTieuDeChanged();
    partial void OnTomTatChanging(string value);
    partial void OnTomTatChanged();
    partial void OnNoiDungChanging(string value);
    partial void OnNoiDungChanged();
    partial void OnNgayDangChanging(System.DateTime value);
    partial void OnNgayDangChanged();
    partial void OnTacGiaChanging(string value);
    partial void OnTacGiaChanged();
    #endregion
		
		public Tin()
		{
			this._BinhLuans = new EntitySet<BinhLuan>(new Action<BinhLuan>(this.attach_BinhLuans), new Action<BinhLuan>(this.detach_BinhLuans));
			this._Votes = new EntitySet<Vote>(new Action<Vote>(this.attach_Votes), new Action<Vote>(this.detach_Votes));
			this._ChuyenMuc = default(EntityRef<ChuyenMuc>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTin", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdTin
		{
			get
			{
				return this._IdTin;
			}
			set
			{
				if ((this._IdTin != value))
				{
					this.OnIdTinChanging(value);
					this.SendPropertyChanging();
					this._IdTin = value;
					this.SendPropertyChanged("IdTin");
					this.OnIdTinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdChuyenMuc", DbType="Int")]
		public System.Nullable<int> IdChuyenMuc
		{
			get
			{
				return this._IdChuyenMuc;
			}
			set
			{
				if ((this._IdChuyenMuc != value))
				{
					if (this._ChuyenMuc.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdChuyenMucChanging(value);
					this.SendPropertyChanging();
					this._IdChuyenMuc = value;
					this.SendPropertyChanged("IdChuyenMuc");
					this.OnIdChuyenMucChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UrlAnhBia", DbType="NVarChar(400)")]
		public string UrlAnhBia
		{
			get
			{
				return this._UrlAnhBia;
			}
			set
			{
				if ((this._UrlAnhBia != value))
				{
					this.OnUrlAnhBiaChanging(value);
					this.SendPropertyChanging();
					this._UrlAnhBia = value;
					this.SendPropertyChanged("UrlAnhBia");
					this.OnUrlAnhBiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TieuDe", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string TieuDe
		{
			get
			{
				return this._TieuDe;
			}
			set
			{
				if ((this._TieuDe != value))
				{
					this.OnTieuDeChanging(value);
					this.SendPropertyChanging();
					this._TieuDe = value;
					this.SendPropertyChanged("TieuDe");
					this.OnTieuDeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TomTat", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string TomTat
		{
			get
			{
				return this._TomTat;
			}
			set
			{
				if ((this._TomTat != value))
				{
					this.OnTomTatChanging(value);
					this.SendPropertyChanging();
					this._TomTat = value;
					this.SendPropertyChanged("TomTat");
					this.OnTomTatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoiDung", DbType="NText NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string NoiDung
		{
			get
			{
				return this._NoiDung;
			}
			set
			{
				if ((this._NoiDung != value))
				{
					this.OnNoiDungChanging(value);
					this.SendPropertyChanging();
					this._NoiDung = value;
					this.SendPropertyChanged("NoiDung");
					this.OnNoiDungChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayDang", DbType="DateTime NOT NULL")]
		public System.DateTime NgayDang
		{
			get
			{
				return this._NgayDang;
			}
			set
			{
				if ((this._NgayDang != value))
				{
					this.OnNgayDangChanging(value);
					this.SendPropertyChanging();
					this._NgayDang = value;
					this.SendPropertyChanged("NgayDang");
					this.OnNgayDangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TacGia", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string TacGia
		{
			get
			{
				return this._TacGia;
			}
			set
			{
				if ((this._TacGia != value))
				{
					this.OnTacGiaChanging(value);
					this.SendPropertyChanging();
					this._TacGia = value;
					this.SendPropertyChanged("TacGia");
					this.OnTacGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tin_BinhLuan", Storage="_BinhLuans", ThisKey="IdTin", OtherKey="IdTin")]
		public EntitySet<BinhLuan> BinhLuans
		{
			get
			{
				return this._BinhLuans;
			}
			set
			{
				this._BinhLuans.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tin_Vote", Storage="_Votes", ThisKey="IdTin", OtherKey="IdTin")]
		public EntitySet<Vote> Votes
		{
			get
			{
				return this._Votes;
			}
			set
			{
				this._Votes.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ChuyenMuc_Tin", Storage="_ChuyenMuc", ThisKey="IdChuyenMuc", OtherKey="IdChuyenMuc", IsForeignKey=true)]
		public ChuyenMuc ChuyenMuc
		{
			get
			{
				return this._ChuyenMuc.Entity;
			}
			set
			{
				ChuyenMuc previousValue = this._ChuyenMuc.Entity;
				if (((previousValue != value) 
							|| (this._ChuyenMuc.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ChuyenMuc.Entity = null;
						previousValue.Tins.Remove(this);
					}
					this._ChuyenMuc.Entity = value;
					if ((value != null))
					{
						value.Tins.Add(this);
						this._IdChuyenMuc = value.IdChuyenMuc;
					}
					else
					{
						this._IdChuyenMuc = default(Nullable<int>);
					}
					this.SendPropertyChanged("ChuyenMuc");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_BinhLuans(BinhLuan entity)
		{
			this.SendPropertyChanging();
			entity.Tin = this;
		}
		
		private void detach_BinhLuans(BinhLuan entity)
		{
			this.SendPropertyChanging();
			entity.Tin = null;
		}
		
		private void attach_Votes(Vote entity)
		{
			this.SendPropertyChanging();
			entity.Tin = this;
		}
		
		private void detach_Votes(Vote entity)
		{
			this.SendPropertyChanging();
			entity.Tin = null;
		}
	}
}
#pragma warning restore 1591
