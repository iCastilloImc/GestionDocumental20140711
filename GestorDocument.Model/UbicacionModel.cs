﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace GestorDocument.Model
{
    public class UbicacionModel : ModelBase
    {

        // **************************** **************************** ****************************

        public long IdUbicacion
        {
            get { return _IdUbicacion; }
            set
            {
                if (_IdUbicacion != value)
                {
                    _IdUbicacion = value;
                    OnPropertyChanged(IdUbicacionPropertyName);
                }
            }
        }
        private long _IdUbicacion;
        public const string IdUbicacionPropertyName = "IdUbicacion";

        // **************************** **************************** ****************************

        public string UbicacionName
        {
            get { return _UbicacionName; }
            set
            {
                if (_UbicacionName != value)
                {
                    _UbicacionName = value;
                    OnPropertyChanged(UbicacionNamePropertyName);
                }
            }
        }
        private string _UbicacionName;
        public const string UbicacionNamePropertyName = "UbicacionName";

        // **************************** **************************** ****************************

        public bool IsActive
        {
            get { return _IsActive; }
            set
            {
                if (_IsActive != value)
                {
                    _IsActive = value;
                    OnPropertyChanged(IsActivePropertyName);
                }
            }
        }
        private bool _IsActive;
        public const string IsActivePropertyName = "IsActive";

        // **************************** **************************** ****************************

        public long LastModifiedDate
        {
            get { return _LastModifiedDate; }
            set
            {
                if (_LastModifiedDate != value)
                {
                    _LastModifiedDate = value;
                    OnPropertyChanged(LastModifiedDatePropertyName);
                }
            }
        }
        private long _LastModifiedDate;
        public const string LastModifiedDatePropertyName = "LastModifiedDate";

        // **************************** **************************** ****************************

        public bool IsModified
        {
            get { return _IsModified; }
            set
            {
                if (_IsModified != value)
                {
                    _IsModified = value;
                    OnPropertyChanged(IsModifiedPropertyName);
                }
            }
        }
        private bool _IsModified;
        public const string IsModifiedPropertyName = "IsModified";

        // **************************** **************************** ****************************

        public long ServerLastModifiedDate
        {
            get { return _ServerLastModifiedDate; }
            set
            {
                if (_ServerLastModifiedDate != value)
                {
                    _ServerLastModifiedDate = value;
                    OnPropertyChanged(ServerLastModifiedDatePropertyName);
                }
            }
        }
        private long _ServerLastModifiedDate;
        public const string ServerLastModifiedDatePropertyName = "ServerLastModifiedDate";

        // **************************** **************************** ****************************

        public bool IsChecked
        {
            get { return _IsChecked; }
            set
            {
                if (_IsChecked != value)
                {
                    _IsChecked = value;
                    OnPropertyChanged(IsCheckedPropertyName);
                }
            }
        }
        private bool _IsChecked;
        public const string IsCheckedPropertyName = "IsChecked";

        // **************************** **************************** ****************************

    }
}
