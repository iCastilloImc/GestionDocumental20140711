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

namespace GestorDocument.DAL
{
    public partial class INF_ACCION
    {
        #region Primitive Properties
    
        public virtual long IdAccion
        {
            get;
            set;
        }
    
        public virtual string AccionName
        {
            get;
            set;
        }
    
        public virtual bool IsActive
        {
            get;
            set;
        }
    
        public virtual bool IsModified
        {
            get;
            set;
        }
    
        public virtual long LastModifiedDate
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual ICollection<INF_INFODOC> INF_INFODOC
        {
            get
            {
                if (_iNF_INFODOC == null)
                {
                    var newCollection = new FixupCollection<INF_INFODOC>();
                    newCollection.CollectionChanged += FixupINF_INFODOC;
                    _iNF_INFODOC = newCollection;
                }
                return _iNF_INFODOC;
            }
            set
            {
                if (!ReferenceEquals(_iNF_INFODOC, value))
                {
                    var previousValue = _iNF_INFODOC as FixupCollection<INF_INFODOC>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupINF_INFODOC;
                    }
                    _iNF_INFODOC = value;
                    var newValue = value as FixupCollection<INF_INFODOC>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupINF_INFODOC;
                    }
                }
            }
        }
        private ICollection<INF_INFODOC> _iNF_INFODOC;

        #endregion
        #region Association Fixup
    
        private void FixupINF_INFODOC(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (INF_INFODOC item in e.NewItems)
                {
                    item.INF_ACCION = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (INF_INFODOC item in e.OldItems)
                {
                    if (ReferenceEquals(item.INF_ACCION, this))
                    {
                        item.INF_ACCION = null;
                    }
                }
            }
        }

        #endregion
    }
}
