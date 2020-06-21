using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [DataContract]
    public class Cuenta
    {
        private int _id;
        private int _nroCuenta;
        private string _descripcion;
        private float _saldo;
        private DateTime _fechaApertura;
        private DateTime _fechaModificacion;
        private bool _activo;
        private int _idCliente;

        [DataMember]
        public int Id
        {
            set
            {
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }
        [DataMember]
        public int NroCuenta
        {
            set
            {
                this._nroCuenta = value;
            }
            get
            {
                return this._nroCuenta;
            }
        }
        [DataMember]
        public string Descripcion
        {
            set
            {
                this._descripcion = value;
            }
            get
            {
                return this._descripcion;
            }
        }
        [DataMember]
        public float Saldo
        {
            set
            {
                this._saldo = value;
            }
            get
            {
                return this._saldo;
            }
        }
        [DataMember]
        public DateTime FechaApertura
        {
            set
            {
                this._fechaApertura = value;
            }
            get
            {
                return this._fechaApertura;
            }
        }
        [DataMember]
        public DateTime FechaModificacion
        {
            set
            {
                this._fechaModificacion = value;
            }
            get
            {
                return this._fechaModificacion;
            }
        }
        [DataMember]
        public Boolean Activo
        {
            set
            {
                this._activo = value;
            }
            get
            {
                return this._activo;
            }
        }
        [DataMember]
        public int idCliente
        {
            set
            {
                this._idCliente = value;
            }
            get
            {
                return this._idCliente;
            }
        }
        public override string ToString()
        {
            return string.Format("{3}) Cuenta nro {0} / {1} Saldo $ {2}", this.NroCuenta, this.Descripcion, this.Saldo.ToString("0.00"), this._id);
        }
    }
}
