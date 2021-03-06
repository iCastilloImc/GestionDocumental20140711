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
    public partial class CAT_ORGANIGRAMA
    {
        #region Primitive Properties
    
        public virtual long IdJerarquia
        {
            get;
            set;
        }
    
        public virtual Nullable<long> IdJerarquiaParent
        {
            get;
            set;
        }
    
        public virtual string JerarquiaName
        {
            get;
            set;
        }
    
        public virtual Nullable<bool> IsActive
        {
            get;
            set;
        }
    
        public virtual Nullable<long> LastModifiedDate
        {
            get;
            set;
        }
    
        public virtual Nullable<bool> IsModified
        {
            get;
            set;
        }
    
        public virtual long IdRol
        {
            get { return _idRol; }
            set
            {
                if (_idRol != value)
                {
                    if (APP_ROL != null && APP_ROL.IdRol != value)
                    {
                        APP_ROL = null;
                    }
                    _idRol = value;
                }
            }
        }
        private long _idRol;
    
        public virtual Nullable<long> ServerLastModifiedDate
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual APP_ROL APP_ROL
        {
            get { return _aPP_ROL; }
            set
            {
                if (!ReferenceEquals(_aPP_ROL, value))
                {
                    var previousValue = _aPP_ROL;
                    _aPP_ROL = value;
                    FixupAPP_ROL(previousValue);
                }
            }
        }
        private APP_ROL _aPP_ROL;

        #endregion
        #region Association Fixup
    
        private void FixupAPP_ROL(APP_ROL previousValue)
        {
            if (previousValue != null && previousValue.CAT_ORGANIGRAMA.Contains(this))
            {
                previousValue.CAT_ORGANIGRAMA.Remove(this);
            }
    
            if (APP_ROL != null)
            {
                if (!APP_ROL.CAT_ORGANIGRAMA.Contains(this))
                {
                    APP_ROL.CAT_ORGANIGRAMA.Add(this);
                }
                if (IdRol != APP_ROL.IdRol)
                {
                    IdRol = APP_ROL.IdRol;
                }
            }
        }

        #endregion
    }
}
