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
    public partial class GET_TURNO
    {
        #region Primitive Properties
    
        public virtual long IdTurno
        {
            get;
            set;
        }
    
        public virtual Nullable<long> IdTurnoAnt
        {
            get;
            set;
        }
    
        public virtual System.DateTime FechaCreacion
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> FechaEnvio
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
    
        public virtual long IdAsunto
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
        private long _idAsunto;
    
        public virtual long IdStatusTurno
        {
            get { return _idStatusTurno; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_idStatusTurno != value)
                    {
                        if (CAT_STATUS_TURNO != null && CAT_STATUS_TURNO.IdStatusTurno != value)
                        {
                            CAT_STATUS_TURNO = null;
                        }
                        _idStatusTurno = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private long _idStatusTurno;
    
        public virtual Nullable<long> IdRol
        {
            get { return _idRol; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_idRol != value)
                    {
                        if (APP_ROL != null && APP_ROL.IdRol != value)
                        {
                            APP_ROL = null;
                        }
                        _idRol = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<long> _idRol;
    
        public virtual Nullable<long> IdUsuario
        {
            get { return _idUsuario; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_idUsuario != value)
                    {
                        if (APP_USUARIO != null && APP_USUARIO.IdUsuario != value)
                        {
                            APP_USUARIO = null;
                        }
                        _idUsuario = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<long> _idUsuario;
    
        public virtual string Comentario
        {
            get;
            set;
        }
    
        public virtual string Respuesta
        {
            get;
            set;
        }
    
        public virtual Nullable<long> ServerLastModifiedDate
        {
            get;
            set;
        }
    
        public virtual bool IsAtendido
        {
            get;
            set;
        }
    
        public virtual bool IsTurnado
        {
            get;
            set;
        }
    
        public virtual bool IsBorrador
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
    
        public virtual APP_USUARIO APP_USUARIO
        {
            get { return _aPP_USUARIO; }
            set
            {
                if (!ReferenceEquals(_aPP_USUARIO, value))
                {
                    var previousValue = _aPP_USUARIO;
                    _aPP_USUARIO = value;
                    FixupAPP_USUARIO(previousValue);
                }
            }
        }
        private APP_USUARIO _aPP_USUARIO;
    
        public virtual CAT_STATUS_TURNO CAT_STATUS_TURNO
        {
            get { return _cAT_STATUS_TURNO; }
            set
            {
                if (!ReferenceEquals(_cAT_STATUS_TURNO, value))
                {
                    var previousValue = _cAT_STATUS_TURNO;
                    _cAT_STATUS_TURNO = value;
                    FixupCAT_STATUS_TURNO(previousValue);
                }
            }
        }
        private CAT_STATUS_TURNO _cAT_STATUS_TURNO;
    
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
    
        public virtual ICollection<REL_DESTINATARIO> REL_DESTINATARIO
        {
            get
            {
                if (_rEL_DESTINATARIO == null)
                {
                    var newCollection = new FixupCollection<REL_DESTINATARIO>();
                    newCollection.CollectionChanged += FixupREL_DESTINATARIO;
                    _rEL_DESTINATARIO = newCollection;
                }
                return _rEL_DESTINATARIO;
            }
            set
            {
                if (!ReferenceEquals(_rEL_DESTINATARIO, value))
                {
                    var previousValue = _rEL_DESTINATARIO as FixupCollection<REL_DESTINATARIO>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupREL_DESTINATARIO;
                    }
                    _rEL_DESTINATARIO = value;
                    var newValue = value as FixupCollection<REL_DESTINATARIO>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupREL_DESTINATARIO;
                    }
                }
            }
        }
        private ICollection<REL_DESTINATARIO> _rEL_DESTINATARIO;

        #endregion
        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void FixupAPP_ROL(APP_ROL previousValue)
        {
            if (previousValue != null && previousValue.GET_TURNO.Contains(this))
            {
                previousValue.GET_TURNO.Remove(this);
            }
    
            if (APP_ROL != null)
            {
                if (!APP_ROL.GET_TURNO.Contains(this))
                {
                    APP_ROL.GET_TURNO.Add(this);
                }
                if (IdRol != APP_ROL.IdRol)
                {
                    IdRol = APP_ROL.IdRol;
                }
            }
            else if (!_settingFK)
            {
                IdRol = null;
            }
        }
    
        private void FixupAPP_USUARIO(APP_USUARIO previousValue)
        {
            if (previousValue != null && previousValue.GET_TURNO.Contains(this))
            {
                previousValue.GET_TURNO.Remove(this);
            }
    
            if (APP_USUARIO != null)
            {
                if (!APP_USUARIO.GET_TURNO.Contains(this))
                {
                    APP_USUARIO.GET_TURNO.Add(this);
                }
                if (IdUsuario != APP_USUARIO.IdUsuario)
                {
                    IdUsuario = APP_USUARIO.IdUsuario;
                }
            }
            else if (!_settingFK)
            {
                IdUsuario = null;
            }
        }
    
        private void FixupCAT_STATUS_TURNO(CAT_STATUS_TURNO previousValue)
        {
            if (previousValue != null && previousValue.GET_TURNO.Contains(this))
            {
                previousValue.GET_TURNO.Remove(this);
            }
    
            if (CAT_STATUS_TURNO != null)
            {
                if (!CAT_STATUS_TURNO.GET_TURNO.Contains(this))
                {
                    CAT_STATUS_TURNO.GET_TURNO.Add(this);
                }
                if (IdStatusTurno != CAT_STATUS_TURNO.IdStatusTurno)
                {
                    IdStatusTurno = CAT_STATUS_TURNO.IdStatusTurno;
                }
            }
        }
    
        private void FixupGET_ASUNTO(GET_ASUNTO previousValue)
        {
            if (previousValue != null && previousValue.GET_TURNO.Contains(this))
            {
                previousValue.GET_TURNO.Remove(this);
            }
    
            if (GET_ASUNTO != null)
            {
                if (!GET_ASUNTO.GET_TURNO.Contains(this))
                {
                    GET_ASUNTO.GET_TURNO.Add(this);
                }
                if (IdAsunto != GET_ASUNTO.IdAsunto)
                {
                    IdAsunto = GET_ASUNTO.IdAsunto;
                }
            }
        }
    
        private void FixupGET_DOCUMENTOS(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (GET_DOCUMENTOS item in e.NewItems)
                {
                    item.GET_TURNO = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (GET_DOCUMENTOS item in e.OldItems)
                {
                    if (ReferenceEquals(item.GET_TURNO, this))
                    {
                        item.GET_TURNO = null;
                    }
                }
            }
        }
    
        private void FixupREL_DESTINATARIO(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (REL_DESTINATARIO item in e.NewItems)
                {
                    item.GET_TURNO = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (REL_DESTINATARIO item in e.OldItems)
                {
                    if (ReferenceEquals(item.GET_TURNO, this))
                    {
                        item.GET_TURNO = null;
                    }
                }
            }
        }

        #endregion
    }
}
