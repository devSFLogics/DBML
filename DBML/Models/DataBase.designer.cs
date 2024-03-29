﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.33440
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBML.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MyDataBase")]
	public partial class DataBaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertUserCourse(UserCourse instance);
    partial void UpdateUserCourse(UserCourse instance);
    partial void DeleteUserCourse(UserCourse instance);
    #endregion
		
		public DataBaseDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MyDataBaseConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<UserCourse> UserCourses
		{
			get
			{
				return this.GetTable<UserCourse>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _UserName;
		
		private string _Password;
		
		private string _ConfirmPassword;
		
		private string _Email;
		
		private EntitySet<UserCourse> _UserCourses;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnConfirmPasswordChanging(string value);
    partial void OnConfirmPasswordChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public User()
		{
			this._UserCourses = new EntitySet<UserCourse>(new Action<UserCourse>(this.attach_UserCourses), new Action<UserCourse>(this.detach_UserCourses));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConfirmPassword", DbType="VarChar(50)")]
		public string ConfirmPassword
		{
			get
			{
				return this._ConfirmPassword;
			}
			set
			{
				if ((this._ConfirmPassword != value))
				{
					this.OnConfirmPasswordChanging(value);
					this.SendPropertyChanging();
					this._ConfirmPassword = value;
					this.SendPropertyChanged("ConfirmPassword");
					this.OnConfirmPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(100)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_UserCourse", Storage="_UserCourses", ThisKey="Id", OtherKey="UserId")]
		public EntitySet<UserCourse> UserCourses
		{
			get
			{
				return this._UserCourses;
			}
			set
			{
				this._UserCourses.Assign(value);
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
		
		private void attach_UserCourses(UserCourse entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_UserCourses(UserCourse entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserCourse")]
	public partial class UserCourse : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Course1;
		
		private string _Course2;
		
		private string _Course3;
		
		private string _Course4;
		
		private string _Course5;
		
		private string _Course6;
		
		private int _CourseId;
		
		private System.Nullable<int> _UserId;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCourse1Changing(string value);
    partial void OnCourse1Changed();
    partial void OnCourse2Changing(string value);
    partial void OnCourse2Changed();
    partial void OnCourse3Changing(string value);
    partial void OnCourse3Changed();
    partial void OnCourse4Changing(string value);
    partial void OnCourse4Changed();
    partial void OnCourse5Changing(string value);
    partial void OnCourse5Changed();
    partial void OnCourse6Changing(string value);
    partial void OnCourse6Changed();
    partial void OnCourseIdChanging(int value);
    partial void OnCourseIdChanged();
    partial void OnUserIdChanging(System.Nullable<int> value);
    partial void OnUserIdChanged();
    #endregion
		
		public UserCourse()
		{
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Course1", DbType="VarChar(50)")]
		public string Course1
		{
			get
			{
				return this._Course1;
			}
			set
			{
				if ((this._Course1 != value))
				{
					this.OnCourse1Changing(value);
					this.SendPropertyChanging();
					this._Course1 = value;
					this.SendPropertyChanged("Course1");
					this.OnCourse1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Course2", DbType="VarChar(50)")]
		public string Course2
		{
			get
			{
				return this._Course2;
			}
			set
			{
				if ((this._Course2 != value))
				{
					this.OnCourse2Changing(value);
					this.SendPropertyChanging();
					this._Course2 = value;
					this.SendPropertyChanged("Course2");
					this.OnCourse2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Course3", DbType="VarChar(50)")]
		public string Course3
		{
			get
			{
				return this._Course3;
			}
			set
			{
				if ((this._Course3 != value))
				{
					this.OnCourse3Changing(value);
					this.SendPropertyChanging();
					this._Course3 = value;
					this.SendPropertyChanged("Course3");
					this.OnCourse3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Course4", DbType="VarChar(50)")]
		public string Course4
		{
			get
			{
				return this._Course4;
			}
			set
			{
				if ((this._Course4 != value))
				{
					this.OnCourse4Changing(value);
					this.SendPropertyChanging();
					this._Course4 = value;
					this.SendPropertyChanged("Course4");
					this.OnCourse4Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Course5", DbType="VarChar(50)")]
		public string Course5
		{
			get
			{
				return this._Course5;
			}
			set
			{
				if ((this._Course5 != value))
				{
					this.OnCourse5Changing(value);
					this.SendPropertyChanging();
					this._Course5 = value;
					this.SendPropertyChanged("Course5");
					this.OnCourse5Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Course6", DbType="VarChar(50)")]
		public string Course6
		{
			get
			{
				return this._Course6;
			}
			set
			{
				if ((this._Course6 != value))
				{
					this.OnCourse6Changing(value);
					this.SendPropertyChanging();
					this._Course6 = value;
					this.SendPropertyChanged("Course6");
					this.OnCourse6Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CourseId
		{
			get
			{
				return this._CourseId;
			}
			set
			{
				if ((this._CourseId != value))
				{
					this.OnCourseIdChanging(value);
					this.SendPropertyChanging();
					this._CourseId = value;
					this.SendPropertyChanged("CourseId");
					this.OnCourseIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int")]
		public System.Nullable<int> UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_UserCourse", Storage="_User", ThisKey="UserId", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.UserCourses.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.UserCourses.Add(this);
						this._UserId = value.Id;
					}
					else
					{
						this._UserId = default(Nullable<int>);
					}
					this.SendPropertyChanged("User");
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
}
#pragma warning restore 1591
