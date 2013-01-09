﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
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
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("Model", "SexoPessoa", "Sexo", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(_004_PartialView.Models.Sexo), "Pessoa", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(_004_PartialView.Models.Pessoa), true)]

#endregion

namespace _004_PartialView.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ModelContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ModelContainer object using the connection string found in the 'ModelContainer' section of the application configuration file.
        /// </summary>
        public ModelContainer() : base("name=ModelContainer", "ModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ModelContainer object.
        /// </summary>
        public ModelContainer(string connectionString) : base(connectionString, "ModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ModelContainer object.
        /// </summary>
        public ModelContainer(EntityConnection connection) : base(connection, "ModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Sexo> Sexos
        {
            get
            {
                if ((_Sexos == null))
                {
                    _Sexos = base.CreateObjectSet<Sexo>("Sexos");
                }
                return _Sexos;
            }
        }
        private ObjectSet<Sexo> _Sexos;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Pessoa> Pessoas
        {
            get
            {
                if ((_Pessoas == null))
                {
                    _Pessoas = base.CreateObjectSet<Pessoa>("Pessoas");
                }
                return _Pessoas;
            }
        }
        private ObjectSet<Pessoa> _Pessoas;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Sexos EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToSexos(Sexo sexo)
        {
            base.AddObject("Sexos", sexo);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Pessoas EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPessoas(Pessoa pessoa)
        {
            base.AddObject("Pessoas", pessoa);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Pessoa")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Pessoa : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Pessoa object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="nome">Initial value of the Nome property.</param>
        /// <param name="sexoId">Initial value of the SexoId property.</param>
        public static Pessoa CreatePessoa(global::System.Int32 id, global::System.String nome, global::System.String sexoId)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Id = id;
            pessoa.Nome = nome;
            pessoa.SexoId = sexoId;
            return pessoa;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Nome
        {
            get
            {
                return _Nome;
            }
            set
            {
                OnNomeChanging(value);
                ReportPropertyChanging("Nome");
                _Nome = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Nome");
                OnNomeChanged();
            }
        }
        private global::System.String _Nome;
        partial void OnNomeChanging(global::System.String value);
        partial void OnNomeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String SexoId
        {
            get
            {
                return _SexoId;
            }
            set
            {
                OnSexoIdChanging(value);
                ReportPropertyChanging("SexoId");
                _SexoId = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("SexoId");
                OnSexoIdChanged();
            }
        }
        private global::System.String _SexoId;
        partial void OnSexoIdChanging(global::System.String value);
        partial void OnSexoIdChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "SexoPessoa", "Sexo")]
        public Sexo Sexo
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Sexo>("Model.SexoPessoa", "Sexo").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Sexo>("Model.SexoPessoa", "Sexo").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Sexo> SexoReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Sexo>("Model.SexoPessoa", "Sexo");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Sexo>("Model.SexoPessoa", "Sexo", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Sexo")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Sexo : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Sexo object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="nome">Initial value of the Nome property.</param>
        public static Sexo CreateSexo(global::System.String id, global::System.String nome)
        {
            Sexo sexo = new Sexo();
            sexo.Id = id;
            sexo.Nome = nome;
            return sexo;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.String _Id;
        partial void OnIdChanging(global::System.String value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Nome
        {
            get
            {
                return _Nome;
            }
            set
            {
                OnNomeChanging(value);
                ReportPropertyChanging("Nome");
                _Nome = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Nome");
                OnNomeChanged();
            }
        }
        private global::System.String _Nome;
        partial void OnNomeChanging(global::System.String value);
        partial void OnNomeChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "SexoPessoa", "Pessoa")]
        public EntityCollection<Pessoa> Pessoas
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Pessoa>("Model.SexoPessoa", "Pessoa");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Pessoa>("Model.SexoPessoa", "Pessoa", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
