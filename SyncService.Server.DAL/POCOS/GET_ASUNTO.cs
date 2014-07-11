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
    public partial class GET_ASUNTO
    {
        #region Primitive Properties
    
        public virtual long IdAsunto
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> FechaCreacion
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> FechaRecibido
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> FechaDocumento
        {
            get;
            set;
        }
    
        public virtual string ReferenciaDocumento
        {
            get;
            set;
        }
    
        public virtual string Titulo
        {
            get;
            set;
        }
    
        public virtual string Descripcion
        {
            get;
            set;
        }
    
        public virtual string Alcance
        {
            get;
            set;
        }
    
        public virtual Nullable<long> IdUbicacion
        {
            get { return _idUbicacion; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_idUbicacion != value)
                    {
                        if (CAT_UBICACION != null && CAT_UBICACION.IdUbicacion != value)
                        {
                            CAT_UBICACION = null;
                        }
                        _idUbicacion = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<long> _idUbicacion;
    
        public virtual Nullable<long> IdInstruccion
        {
            get { return _idInstruccion; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_idInstruccion != value)
                    {
                        if (CAT_INSTRUCCION != null && CAT_INSTRUCCION.IdInstruccion != value)
                        {
                            CAT_INSTRUCCION = null;
                        }
                        _idInstruccion = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<long> _idInstruccion;
    
        public virtual Nullable<long> IdPrioridad
        {
            get { return _idPrioridad; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_idPrioridad != value)
                    {
                        if (CAT_PRIORIDAD != null && CAT_PRIORIDAD.IdPrioridad != value)
                        {
                            CAT_PRIORIDAD = null;
                        }
                        _idPrioridad = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<long> _idPrioridad;
    
        public virtual Nullable<long> IdStatusAsunto
        {
            get { return _idStatusAsunto; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_idStatusAsunto != value)
                    {
                        if (CAT_STATUS_ASUNTO != null && CAT_STATUS_ASUNTO.IdStatusAsunto != value)
                        {
                            CAT_STATUS_ASUNTO = null;
                        }
                        _idStatusAsunto = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<long> _idStatusAsunto;
    
        public virtual System.DateTime FechaVencimiento
        {
            get;
            set;
        }
    
        public virtual string Folio
        {
            get;
            set;
        }
    
        public virtual Nullable<long> ServerLastModifiedDate
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
    
        public virtual bool IsBorrador
        {
            get;
            set;
        }
    
        public virtual string Contacto
        {
            get;
            set;
        }
    
        public virtual string Anexos
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> FechaAtendido
        {
            get;
            set;
        }
    
        public virtual string Ubicacion
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual CAT_INSTRUCCION CAT_INSTRUCCION
        {
            get { return _cAT_INSTRUCCION; }
            set
            {
                if (!ReferenceEquals(_cAT_INSTRUCCION, value))
                {
                    var previousValue = _cAT_INSTRUCCION;
                    _cAT_INSTRUCCION = value;
                    FixupCAT_INSTRUCCION(previousValue);
                }
            }
        }
        private CAT_INSTRUCCION _cAT_INSTRUCCION;
    
        public virtual CAT_PRIORIDAD CAT_PRIORIDAD
        {
            get { return _cAT_PRIORIDAD; }
            set
            {
                if (!ReferenceEquals(_cAT_PRIORIDAD, value))
                {
                    var previousValue = _cAT_PRIORIDAD;
                    _cAT_PRIORIDAD = value;
                    FixupCAT_PRIORIDAD(previousValue);
                }
            }
        }
        private CAT_PRIORIDAD _cAT_PRIORIDAD;
    
        public virtual CAT_STATUS_ASUNTO CAT_STATUS_ASUNTO
        {
            get { return _cAT_STATUS_ASUNTO; }
            set
            {
                if (!ReferenceEquals(_cAT_STATUS_ASUNTO, value))
                {
                    var previousValue = _cAT_STATUS_ASUNTO;
                    _cAT_STATUS_ASUNTO = value;
                    FixupCAT_STATUS_ASUNTO(previousValue);
                }
            }
        }
        private CAT_STATUS_ASUNTO _cAT_STATUS_ASUNTO;
    
        public virtual CAT_UBICACION CAT_UBICACION
        {
            get { return _cAT_UBICACION; }
            set
            {
                if (!ReferenceEquals(_cAT_UBICACION, value))
                {
                    var previousValue = _cAT_UBICACION;
                    _cAT_UBICACION = value;
                    FixupCAT_UBICACION(previousValue);
                }
            }
        }
        private CAT_UBICACION _cAT_UBICACION;
    
        public virtual ICollection<REL_DESTINATARIO_CCP> REL_DESTINATARIO_CCP
        {
            get
            {
                if (_rEL_DESTINATARIO_CCP == null)
                {
                    var newCollection = new FixupCollection<REL_DESTINATARIO_CCP>();
                    newCollection.CollectionChanged += FixupREL_DESTINATARIO_CCP;
                    _rEL_DESTINATARIO_CCP = newCollection;
                }
                return _rEL_DESTINATARIO_CCP;
            }
            set
            {
                if (!ReferenceEquals(_rEL_DESTINATARIO_CCP, value))
                {
                    var previousValue = _rEL_DESTINATARIO_CCP as FixupCollection<REL_DESTINATARIO_CCP>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupREL_DESTINATARIO_CCP;
                    }
                    _rEL_DESTINATARIO_CCP = value;
                    var newValue = value as FixupCollection<REL_DESTINATARIO_CCP>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupREL_DESTINATARIO_CCP;
                    }
                }
            }
        }
        private ICollection<REL_DESTINATARIO_CCP> _rEL_DESTINATARIO_CCP;
    
        public virtual ICollection<GET_EXPEDIENTE> GET_EXPEDIENTE
        {
            get
            {
                if (_gET_EXPEDIENTE == null)
                {
                    var newCollection = new FixupCollection<GET_EXPEDIENTE>();
                    newCollection.CollectionChanged += FixupGET_EXPEDIENTE;
                    _gET_EXPEDIENTE = newCollection;
                }
                return _gET_EXPEDIENTE;
            }
            set
            {
                if (!ReferenceEquals(_gET_EXPEDIENTE, value))
                {
                    var previousValue = _gET_EXPEDIENTE as FixupCollection<GET_EXPEDIENTE>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupGET_EXPEDIENTE;
                    }
                    _gET_EXPEDIENTE = value;
                    var newValue = value as FixupCollection<GET_EXPEDIENTE>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupGET_EXPEDIENTE;
                    }
                }
            }
        }
        private ICollection<GET_EXPEDIENTE> _gET_EXPEDIENTE;
    
        public virtual ICollection<GET_FECHA_VENCIMIENTO> GET_FECHA_VENCIMIENTO
        {
            get
            {
                if (_gET_FECHA_VENCIMIENTO == null)
                {
                    var newCollection = new FixupCollection<GET_FECHA_VENCIMIENTO>();
                    newCollection.CollectionChanged += FixupGET_FECHA_VENCIMIENTO;
                    _gET_FECHA_VENCIMIENTO = newCollection;
                }
                return _gET_FECHA_VENCIMIENTO;
            }
            set
            {
                if (!ReferenceEquals(_gET_FECHA_VENCIMIENTO, value))
                {
                    var previousValue = _gET_FECHA_VENCIMIENTO as FixupCollection<GET_FECHA_VENCIMIENTO>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupGET_FECHA_VENCIMIENTO;
                    }
                    _gET_FECHA_VENCIMIENTO = value;
                    var newValue = value as FixupCollection<GET_FECHA_VENCIMIENTO>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupGET_FECHA_VENCIMIENTO;
                    }
                }
            }
        }
        private ICollection<GET_FECHA_VENCIMIENTO> _gET_FECHA_VENCIMIENTO;
    
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
    
        public virtual ICollection<REL_SIGNATARIO_EXTERNO> REL_SIGNATARIO_EXTERNO
        {
            get
            {
                if (_rEL_SIGNATARIO_EXTERNO == null)
                {
                    var newCollection = new FixupCollection<REL_SIGNATARIO_EXTERNO>();
                    newCollection.CollectionChanged += FixupREL_SIGNATARIO_EXTERNO;
                    _rEL_SIGNATARIO_EXTERNO = newCollection;
                }
                return _rEL_SIGNATARIO_EXTERNO;
            }
            set
            {
                if (!ReferenceEquals(_rEL_SIGNATARIO_EXTERNO, value))
                {
                    var previousValue = _rEL_SIGNATARIO_EXTERNO as FixupCollection<REL_SIGNATARIO_EXTERNO>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupREL_SIGNATARIO_EXTERNO;
                    }
                    _rEL_SIGNATARIO_EXTERNO = value;
                    var newValue = value as FixupCollection<REL_SIGNATARIO_EXTERNO>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupREL_SIGNATARIO_EXTERNO;
                    }
                }
            }
        }
        private ICollection<REL_SIGNATARIO_EXTERNO> _rEL_SIGNATARIO_EXTERNO;
    
        public virtual ICollection<REL_SIGNATARIO> REL_SIGNATARIO
        {
            get
            {
                if (_rEL_SIGNATARIO == null)
                {
                    var newCollection = new FixupCollection<REL_SIGNATARIO>();
                    newCollection.CollectionChanged += FixupREL_SIGNATARIO;
                    _rEL_SIGNATARIO = newCollection;
                }
                return _rEL_SIGNATARIO;
            }
            set
            {
                if (!ReferenceEquals(_rEL_SIGNATARIO, value))
                {
                    var previousValue = _rEL_SIGNATARIO as FixupCollection<REL_SIGNATARIO>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupREL_SIGNATARIO;
                    }
                    _rEL_SIGNATARIO = value;
                    var newValue = value as FixupCollection<REL_SIGNATARIO>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupREL_SIGNATARIO;
                    }
                }
            }
        }
        private ICollection<REL_SIGNATARIO> _rEL_SIGNATARIO;

        #endregion
        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void FixupCAT_INSTRUCCION(CAT_INSTRUCCION previousValue)
        {
            if (previousValue != null && previousValue.GET_ASUNTO.Contains(this))
            {
                previousValue.GET_ASUNTO.Remove(this);
            }
    
            if (CAT_INSTRUCCION != null)
            {
                if (!CAT_INSTRUCCION.GET_ASUNTO.Contains(this))
                {
                    CAT_INSTRUCCION.GET_ASUNTO.Add(this);
                }
                if (IdInstruccion != CAT_INSTRUCCION.IdInstruccion)
                {
                    IdInstruccion = CAT_INSTRUCCION.IdInstruccion;
                }
            }
            else if (!_settingFK)
            {
                IdInstruccion = null;
            }
        }
    
        private void FixupCAT_PRIORIDAD(CAT_PRIORIDAD previousValue)
        {
            if (previousValue != null && previousValue.GET_ASUNTO.Contains(this))
            {
                previousValue.GET_ASUNTO.Remove(this);
            }
    
            if (CAT_PRIORIDAD != null)
            {
                if (!CAT_PRIORIDAD.GET_ASUNTO.Contains(this))
                {
                    CAT_PRIORIDAD.GET_ASUNTO.Add(this);
                }
                if (IdPrioridad != CAT_PRIORIDAD.IdPrioridad)
                {
                    IdPrioridad = CAT_PRIORIDAD.IdPrioridad;
                }
            }
            else if (!_settingFK)
            {
                IdPrioridad = null;
            }
        }
    
        private void FixupCAT_STATUS_ASUNTO(CAT_STATUS_ASUNTO previousValue)
        {
            if (previousValue != null && previousValue.GET_ASUNTO.Contains(this))
            {
                previousValue.GET_ASUNTO.Remove(this);
            }
    
            if (CAT_STATUS_ASUNTO != null)
            {
                if (!CAT_STATUS_ASUNTO.GET_ASUNTO.Contains(this))
                {
                    CAT_STATUS_ASUNTO.GET_ASUNTO.Add(this);
                }
                if (IdStatusAsunto != CAT_STATUS_ASUNTO.IdStatusAsunto)
                {
                    IdStatusAsunto = CAT_STATUS_ASUNTO.IdStatusAsunto;
                }
            }
            else if (!_settingFK)
            {
                IdStatusAsunto = null;
            }
        }
    
        private void FixupCAT_UBICACION(CAT_UBICACION previousValue)
        {
            if (previousValue != null && previousValue.GET_ASUNTO.Contains(this))
            {
                previousValue.GET_ASUNTO.Remove(this);
            }
    
            if (CAT_UBICACION != null)
            {
                if (!CAT_UBICACION.GET_ASUNTO.Contains(this))
                {
                    CAT_UBICACION.GET_ASUNTO.Add(this);
                }
                if (IdUbicacion != CAT_UBICACION.IdUbicacion)
                {
                    IdUbicacion = CAT_UBICACION.IdUbicacion;
                }
            }
            else if (!_settingFK)
            {
                IdUbicacion = null;
            }
        }
    
        private void FixupREL_DESTINATARIO_CCP(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (REL_DESTINATARIO_CCP item in e.NewItems)
                {
                    item.GET_ASUNTO = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (REL_DESTINATARIO_CCP item in e.OldItems)
                {
                    if (ReferenceEquals(item.GET_ASUNTO, this))
                    {
                        item.GET_ASUNTO = null;
                    }
                }
            }
        }
    
        private void FixupGET_EXPEDIENTE(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (GET_EXPEDIENTE item in e.NewItems)
                {
                    item.GET_ASUNTO = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (GET_EXPEDIENTE item in e.OldItems)
                {
                    if (ReferenceEquals(item.GET_ASUNTO, this))
                    {
                        item.GET_ASUNTO = null;
                    }
                }
            }
        }
    
        private void FixupGET_FECHA_VENCIMIENTO(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (GET_FECHA_VENCIMIENTO item in e.NewItems)
                {
                    item.GET_ASUNTO = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (GET_FECHA_VENCIMIENTO item in e.OldItems)
                {
                    if (ReferenceEquals(item.GET_ASUNTO, this))
                    {
                        item.GET_ASUNTO = null;
                    }
                }
            }
        }
    
        private void FixupGET_TURNO(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (GET_TURNO item in e.NewItems)
                {
                    item.GET_ASUNTO = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (GET_TURNO item in e.OldItems)
                {
                    if (ReferenceEquals(item.GET_ASUNTO, this))
                    {
                        item.GET_ASUNTO = null;
                    }
                }
            }
        }
    
        private void FixupREL_SIGNATARIO_EXTERNO(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (REL_SIGNATARIO_EXTERNO item in e.NewItems)
                {
                    item.GET_ASUNTO = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (REL_SIGNATARIO_EXTERNO item in e.OldItems)
                {
                    if (ReferenceEquals(item.GET_ASUNTO, this))
                    {
                        item.GET_ASUNTO = null;
                    }
                }
            }
        }
    
        private void FixupREL_SIGNATARIO(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (REL_SIGNATARIO item in e.NewItems)
                {
                    item.GET_ASUNTO = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (REL_SIGNATARIO item in e.OldItems)
                {
                    if (ReferenceEquals(item.GET_ASUNTO, this))
                    {
                        item.GET_ASUNTO = null;
                    }
                }
            }
        }

        #endregion
    }
}
