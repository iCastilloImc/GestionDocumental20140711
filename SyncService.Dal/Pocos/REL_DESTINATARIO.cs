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

namespace SyncService.Dal.Pocos
{
    public partial class REL_DESTINATARIO
    {
        #region Primitive Properties
    
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
    
        public virtual long IdTurno
        {
            get { return _idTurno; }
            set
            {
                if (_idTurno != value)
                {
                    if (GET_TURNO != null && GET_TURNO.IdTurno != value)
                    {
                        GET_TURNO = null;
                    }
                    _idTurno = value;
                }
            }
        }
        private long _idTurno;
    
        public virtual long IdDestinatario
        {
            get;
            set;
        }
    
        public virtual bool IsPrincipal
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
    
        public virtual GET_TURNO GET_TURNO
        {
            get { return _gET_TURNO; }
            set
            {
                if (!ReferenceEquals(_gET_TURNO, value))
                {
                    var previousValue = _gET_TURNO;
                    _gET_TURNO = value;
                    FixupGET_TURNO(previousValue);
                }
            }
        }
        private GET_TURNO _gET_TURNO;

        #endregion
        #region Association Fixup
    
        private void FixupAPP_ROL(APP_ROL previousValue)
        {
            if (previousValue != null && previousValue.REL_DESTINATARIO.Contains(this))
            {
                previousValue.REL_DESTINATARIO.Remove(this);
            }
    
            if (APP_ROL != null)
            {
                if (!APP_ROL.REL_DESTINATARIO.Contains(this))
                {
                    APP_ROL.REL_DESTINATARIO.Add(this);
                }
                if (IdRol != APP_ROL.IdRol)
                {
                    IdRol = APP_ROL.IdRol;
                }
            }
        }
    
        private void FixupGET_TURNO(GET_TURNO previousValue)
        {
            if (previousValue != null && previousValue.REL_DESTINATARIO.Contains(this))
            {
                previousValue.REL_DESTINATARIO.Remove(this);
            }
    
            if (GET_TURNO != null)
            {
                if (!GET_TURNO.REL_DESTINATARIO.Contains(this))
                {
                    GET_TURNO.REL_DESTINATARIO.Add(this);
                }
                if (IdTurno != GET_TURNO.IdTurno)
                {
                    IdTurno = GET_TURNO.IdTurno;
                }
            }
        }

        #endregion
    }
}
