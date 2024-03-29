﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region Metadatos de relaciones en EDM

[assembly: EdmRelationshipAttribute("WBTaskModel", "FK_Messsage_Account", "Account", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(DataAccesLayer.Account), "Messsage", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(DataAccesLayer.Messsage), true)]

#endregion

namespace DataAccesLayer
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class WBTaskEntities1 : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto WBTaskEntities1 usando la cadena de conexión encontrada en la sección 'WBTaskEntities1' del archivo de configuración de la aplicación.
        /// </summary>
        public WBTaskEntities1() : base("name=WBTaskEntities1", "WBTaskEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto WBTaskEntities1.
        /// </summary>
        public WBTaskEntities1(string connectionString) : base(connectionString, "WBTaskEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto WBTaskEntities1.
        /// </summary>
        public WBTaskEntities1(EntityConnection connection) : base(connection, "WBTaskEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos parciales
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propiedades de ObjectSet
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Account> Account
        {
            get
            {
                if ((_Account == null))
                {
                    _Account = base.CreateObjectSet<Account>("Account");
                }
                return _Account;
            }
        }
        private ObjectSet<Account> _Account;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Messsage> Messsage
        {
            get
            {
                if ((_Messsage == null))
                {
                    _Messsage = base.CreateObjectSet<Messsage>("Messsage");
                }
                return _Messsage;
            }
        }
        private ObjectSet<Messsage> _Messsage;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<sysdiagrams> sysdiagrams
        {
            get
            {
                if ((_sysdiagrams == null))
                {
                    _sysdiagrams = base.CreateObjectSet<sysdiagrams>("sysdiagrams");
                }
                return _sysdiagrams;
            }
        }
        private ObjectSet<sysdiagrams> _sysdiagrams;

        #endregion
        #region Métodos AddTo
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Account. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToAccount(Account account)
        {
            base.AddObject("Account", account);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Messsage. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToMesssage(Messsage messsage)
        {
            base.AddObject("Messsage", messsage);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet sysdiagrams. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddTosysdiagrams(sysdiagrams sysdiagrams)
        {
            base.AddObject("sysdiagrams", sysdiagrams);
        }

        #endregion
    }
    

    #endregion
    
    #region Entidades
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="WBTaskModel", Name="Account")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Account : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Account.
        /// </summary>
        /// <param name="idAccount">Valor inicial de la propiedad IdAccount.</param>
        /// <param name="nombre">Valor inicial de la propiedad Nombre.</param>
        /// <param name="email">Valor inicial de la propiedad Email.</param>
        /// <param name="passWord">Valor inicial de la propiedad PassWord.</param>
        public static Account CreateAccount(global::System.Int32 idAccount, global::System.String nombre, global::System.String email, global::System.String passWord)
        {
            Account account = new Account();
            account.IdAccount = idAccount;
            account.Nombre = nombre;
            account.Email = email;
            account.PassWord = passWord;
            return account;
        }

        #endregion
        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdAccount
        {
            get
            {
                return _IdAccount;
            }
            set
            {
                if (_IdAccount != value)
                {
                    OnIdAccountChanging(value);
                    ReportPropertyChanging("IdAccount");
                    _IdAccount = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("IdAccount");
                    OnIdAccountChanged();
                }
            }
        }
        private global::System.Int32 _IdAccount;
        partial void OnIdAccountChanging(global::System.Int32 value);
        partial void OnIdAccountChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                OnNombreChanging(value);
                ReportPropertyChanging("Nombre");
                _Nombre = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Nombre");
                OnNombreChanged();
            }
        }
        private global::System.String _Nombre;
        partial void OnNombreChanging(global::System.String value);
        partial void OnNombreChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                OnEmailChanging(value);
                ReportPropertyChanging("Email");
                _Email = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Email");
                OnEmailChanged();
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PassWord
        {
            get
            {
                return _PassWord;
            }
            set
            {
                OnPassWordChanging(value);
                ReportPropertyChanging("PassWord");
                _PassWord = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PassWord");
                OnPassWordChanged();
            }
        }
        private global::System.String _PassWord;
        partial void OnPassWordChanging(global::System.String value);
        partial void OnPassWordChanged();

        #endregion
    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("WBTaskModel", "FK_Messsage_Account", "Messsage")]
        public EntityCollection<Messsage> Messsage
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Messsage>("WBTaskModel.FK_Messsage_Account", "Messsage");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Messsage>("WBTaskModel.FK_Messsage_Account", "Messsage", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="WBTaskModel", Name="Messsage")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Messsage : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Messsage.
        /// </summary>
        /// <param name="idMessage">Valor inicial de la propiedad IdMessage.</param>
        /// <param name="text">Valor inicial de la propiedad Text.</param>
        /// <param name="date">Valor inicial de la propiedad Date.</param>
        /// <param name="idAccount">Valor inicial de la propiedad IdAccount.</param>
        public static Messsage CreateMesssage(global::System.Int32 idMessage, global::System.String text, global::System.DateTime date, global::System.Int32 idAccount)
        {
            Messsage messsage = new Messsage();
            messsage.IdMessage = idMessage;
            messsage.Text = text;
            messsage.Date = date;
            messsage.IdAccount = idAccount;
            return messsage;
        }

        #endregion
        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdMessage
        {
            get
            {
                return _IdMessage;
            }
            set
            {
                if (_IdMessage != value)
                {
                    OnIdMessageChanging(value);
                    ReportPropertyChanging("IdMessage");
                    _IdMessage = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("IdMessage");
                    OnIdMessageChanged();
                }
            }
        }
        private global::System.Int32 _IdMessage;
        partial void OnIdMessageChanging(global::System.Int32 value);
        partial void OnIdMessageChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Text
        {
            get
            {
                return _Text;
            }
            set
            {
                OnTextChanging(value);
                ReportPropertyChanging("Text");
                _Text = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Text");
                OnTextChanged();
            }
        }
        private global::System.String _Text;
        partial void OnTextChanging(global::System.String value);
        partial void OnTextChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime Date
        {
            get
            {
                return _Date;
            }
            set
            {
                OnDateChanging(value);
                ReportPropertyChanging("Date");
                _Date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Date");
                OnDateChanged();
            }
        }
        private global::System.DateTime _Date;
        partial void OnDateChanging(global::System.DateTime value);
        partial void OnDateChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdAccount
        {
            get
            {
                return _IdAccount;
            }
            set
            {
                OnIdAccountChanging(value);
                ReportPropertyChanging("IdAccount");
                _IdAccount = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IdAccount");
                OnIdAccountChanged();
            }
        }
        private global::System.Int32 _IdAccount;
        partial void OnIdAccountChanging(global::System.Int32 value);
        partial void OnIdAccountChanged();

        #endregion
    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("WBTaskModel", "FK_Messsage_Account", "Account")]
        public Account Account
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Account>("WBTaskModel.FK_Messsage_Account", "Account").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Account>("WBTaskModel.FK_Messsage_Account", "Account").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Account> AccountReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Account>("WBTaskModel.FK_Messsage_Account", "Account");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Account>("WBTaskModel.FK_Messsage_Account", "Account", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="WBTaskModel", Name="sysdiagrams")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class sysdiagrams : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto sysdiagrams.
        /// </summary>
        /// <param name="name">Valor inicial de la propiedad name.</param>
        /// <param name="principal_id">Valor inicial de la propiedad principal_id.</param>
        /// <param name="diagram_id">Valor inicial de la propiedad diagram_id.</param>
        public static sysdiagrams Createsysdiagrams(global::System.String name, global::System.Int32 principal_id, global::System.Int32 diagram_id)
        {
            sysdiagrams sysdiagrams = new sysdiagrams();
            sysdiagrams.name = name;
            sysdiagrams.principal_id = principal_id;
            sysdiagrams.diagram_id = diagram_id;
            return sysdiagrams;
        }

        #endregion
        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 principal_id
        {
            get
            {
                return _principal_id;
            }
            set
            {
                Onprincipal_idChanging(value);
                ReportPropertyChanging("principal_id");
                _principal_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("principal_id");
                Onprincipal_idChanged();
            }
        }
        private global::System.Int32 _principal_id;
        partial void Onprincipal_idChanging(global::System.Int32 value);
        partial void Onprincipal_idChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 diagram_id
        {
            get
            {
                return _diagram_id;
            }
            set
            {
                if (_diagram_id != value)
                {
                    Ondiagram_idChanging(value);
                    ReportPropertyChanging("diagram_id");
                    _diagram_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("diagram_id");
                    Ondiagram_idChanged();
                }
            }
        }
        private global::System.Int32 _diagram_id;
        partial void Ondiagram_idChanging(global::System.Int32 value);
        partial void Ondiagram_idChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> version
        {
            get
            {
                return _version;
            }
            set
            {
                OnversionChanging(value);
                ReportPropertyChanging("version");
                _version = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("version");
                OnversionChanged();
            }
        }
        private Nullable<global::System.Int32> _version;
        partial void OnversionChanging(Nullable<global::System.Int32> value);
        partial void OnversionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.Byte[] definition
        {
            get
            {
                return StructuralObject.GetValidValue(_definition);
            }
            set
            {
                OndefinitionChanging(value);
                ReportPropertyChanging("definition");
                _definition = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("definition");
                OndefinitionChanged();
            }
        }
        private global::System.Byte[] _definition;
        partial void OndefinitionChanging(global::System.Byte[] value);
        partial void OndefinitionChanged();

        #endregion
    
    }

    #endregion
    
}
