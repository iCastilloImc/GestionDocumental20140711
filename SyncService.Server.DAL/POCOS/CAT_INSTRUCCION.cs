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

namespace SyncService.Server.DAL.POCOS
{
    public partial class CAT_INSTRUCCION
    {
        #region Primitive Properties
    
        public virtual long IdInstruccion
        {
            get;
            set;
        }
    
        public virtual int CveInstruccion
        {
            get;
            set;
        }
    
        public virtual string InstruccionName
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
    
        public virtual long ServerLastModifiedDate
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual ICollection<GET_ASUNTO> GET_ASUNTO
        {
            get
            {
                if (_gET_ASUNTO == null)
                {
                    var newCollection = new FixupCollection<GET_ASUNTO>();
                    newCollection.CollectionChanged += FixupGET_ASUNTO;
                    _gET_ASUNTO = newCollection;
                }
                return _gET_ASUNTO;
            }
            set
            {
                if (!ReferenceEquals(_gET_ASUNTO, value))
                {
                    var previousValue = _gET_ASUNTO as FixupCollection<GET_ASUNTO>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupGET_ASUNTO;
                    }
                    _gET_ASUNTO = value;
                    var newValue = value as FixupCollection<GET_ASUNTO>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupGET_ASUNTO;
                    }
                }
            }
        }
        private ICollection<GET_ASUNTO> _gET_ASUNTO;

        #endregion
        #region Association Fixup
    
        private void FixupGET_ASUNTO(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (GET_ASUNTO item in e.NewItems)
                {
                    item.CAT_INSTRUCCION = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (GET_ASUNTO item in e.OldItems)
                {
                    if (ReferenceEquals(item.CAT_INSTRUCCION, this))
                    {
                        item.CAT_INSTRUCCION = null;
                    }
                }
            }
        }

        #endregion
    }
}
