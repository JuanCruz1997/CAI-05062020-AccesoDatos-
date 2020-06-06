using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [DataContract]
    public class Cliente
    {
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private DateTime _fechaNacimiento;

        [DataMember]
        public string Nombre
        {
            set
            {
                this._nombre = value;
            }
            get
            {
                return this._nombre;
            }
        }
        [DataMember]
        public string Apellido
        {
            set
            {
                this._apellido = value;
            }
            get
            {
                return this._apellido;
            }
        }
        [DataMember]
        public string Direccion
        {
            set
            {
                this._direccion = value;
            }
            get
            {
                return this._direccion;
            }
        }
        [DataMember]
        public DateTime FechaNacimiento
        {
            set
            {
                this._fechaNacimiento = value;
            }
            get
            {
                return this._fechaNacimiento;
            }
        }
        public override string ToString()
        {
            return string.Format("Cliente {0}, {1}", this._apellido, this._nombre);
        }
    }
}
