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
    public partial class CAT_STATUS_TURNO
    {
        #region Primitive Properties
    
        public virtual long IdStatusTurno
        {
            get;
            set;
        }
    
        public virtual string StatusName
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
    
        public virtual ICollection<GET_TURNO> GET_TURNO
        {
            get
            {
                if (_gET_TURNO == null)
                {
                    var newCollection = new FixupCollection<GET_TURNO>();
                    newCollection.CollectionChanged += FixupGET_TURNO;
                    _gET_TURNO = newCollection;
                }
                return _gET_TURNO;
            }
            set
            {
                if (!ReferenceEquals(_gET_TURNO, value))
                {
                    var previousValue = _gET_TURNO as FixupCollection<GET_TURNO>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupGET_TURNO;
                    }
                    _gET_TURNO = value;
                    var newValue = value as FixupCollection<GET_TURNO>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupGET_TURNO;
                    }
                }
            }
        }
        private ICollection<GET_TURNO> _gET_TURNO;

        #endregion
        #region Association Fixup
    
        private void FixupGET_TURNO(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (GET_TURNO item in e.NewItems)
                {
                    item.CAT_STATUS_TURNO = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (GET_TURNO item in e.OldItems)
                {
                    if (ReferenceEquals(item.CAT_STATUS_TURNO, this))
                    {
                        item.CAT_STATUS_TURNO = null;
                    }
                }
            }
        }

        #endregion
    }
}
