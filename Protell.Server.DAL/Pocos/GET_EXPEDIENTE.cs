//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Protell.Server.DAL.Pocos
{
    public partial class GET_EXPEDIENTE
    {
        #region Primitive Properties
    
        public virtual long IdExpediente
        {
            get;
            set;
        }
    
        public virtual bool IsActive
        {
            get;
            set;
        }
    
        public virtual long LastModifiedDate
        {
            get;
            set;
        }
    
        public virtual bool IsModified
        {
            get;
            set;
        }
    
        public virtual Nullable<long> IdAsunto
        {
            get { return _idAsunto; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_idAsunto != value)
                    {
                        if (GET_ASUNTO != null && GET_ASUNTO.IdAsunto != value)
                        {
                            GET_ASUNTO = null;
                        }
                        _idAsunto = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<long> _idAsunto;
    
        public virtual long ServerLastModifiedDate
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual GET_ASUNTO GET_ASUNTO
        {
            get { return _gET_ASUNTO; }
            set
            {
                if (!ReferenceEquals(_gET_ASUNTO, value))
                {
                    var previousValue = _gET_ASUNTO;
                    _gET_ASUNTO = value;
                    FixupGET_ASUNTO(previousValue);
                }
            }
        }
        private GET_ASUNTO _gET_ASUNTO;
    
        public virtual ICollection<GET_DOCUMENTOS> GET_DOCUMENTOS
        {
            get
            {
                if (_gET_DOCUMENTOS == null)
                {
                    var newCollection = new FixupCollection<GET_DOCUMENTOS>();
                    newCollection.CollectionChanged += FixupGET_DOCUMENTOS;
                    _gET_DOCUMENTOS = newCollection;
                }
                return _gET_DOCUMENTOS;
            }
            set
            {
                if (!ReferenceEquals(_gET_DOCUMENTOS, value))
                {
                    var previousValue = _gET_DOCUMENTOS as FixupCollection<GET_DOCUMENTOS>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupGET_DOCUMENTOS;
                    }
                    _gET_DOCUMENTOS = value;
                    var newValue = value as FixupCollection<GET_DOCUMENTOS>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupGET_DOCUMENTOS;
                    }
                }
            }
        }
        private ICollection<GET_DOCUMENTOS> _gET_DOCUMENTOS;

        #endregion
        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void FixupGET_ASUNTO(GET_ASUNTO previousValue)
        {
            if (previousValue != null && previousValue.GET_EXPEDIENTE.Contains(this))
            {
                previousValue.GET_EXPEDIENTE.Remove(this);
            }
    
            if (GET_ASUNTO != null)
            {
                if (!GET_ASUNTO.GET_EXPEDIENTE.Contains(this))
                {
                    GET_ASUNTO.GET_EXPEDIENTE.Add(this);
                }
                if (IdAsunto != GET_ASUNTO.IdAsunto)
                {
                    IdAsunto = GET_ASUNTO.IdAsunto;
                }
            }
            else if (!_settingFK)
            {
                IdAsunto = null;
            }
        }
    
        private void FixupGET_DOCUMENTOS(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (GET_DOCUMENTOS item in e.NewItems)
                {
                    item.GET_EXPEDIENTE = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (GET_DOCUMENTOS item in e.OldItems)
                {
                    if (ReferenceEquals(item.GET_EXPEDIENTE, this))
                    {
                        item.GET_EXPEDIENTE = null;
                    }
                }
            }
        }

        #endregion
    }
}
