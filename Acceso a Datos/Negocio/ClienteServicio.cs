using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.IO.MemoryMappedFiles;

namespace Negocio
{
    public class ClienteServicio
    {
        private ClienteMapper mapper;
        public ClienteServicio()
        {
            mapper = new ClienteMapper();
        }
        public List<Cliente> TraerClientes()
        {
            List<Cliente> result = mapper.TraerTodos();
            return result;
        }
        public List<Cliente> TraerClientesPropios()
        {
            List<Cliente> result = mapper.TraerPropios();
            return result;
        }
        public List<Cliente> TraerClientesMayoresA(int edad)
        {
            List<Cliente> clienteEdad = new List<Cliente>();
            int edadCliente;
            foreach (Cliente c in this.TraerClientes())
            {
                edadCliente = DateTime.Now.Year - c.FechaNacimiento.Year;
                if (edadCliente >= edad)
                {
                    clienteEdad.Add(c);
                }
            }
            return clienteEdad;
        }
        public List<Cliente> TraerClientesPorApellido(string apellido)
        {
            List<Cliente> clienteApellido = new List<Cliente>();
            foreach(Cliente c in this.TraerClientes())
            {
                if (c.Apellido == apellido)
                {
                    clienteApellido.Add(c);
                }
            }
            return clienteApellido;
        }
        public int InsertarCliente(string nombre,string apellido,string direccion,string email,string telefono,DateTime fechaNacimiento)
        {
            Cliente cliente = new Cliente();
            cliente.Apellido = apellido;
            cliente.Nombre = nombre;
            cliente.Direccion = direccion;
            cliente.Email = email;
            cliente.Telefono = telefono;
            cliente.FechaNacimiento = fechaNacimiento;
            cliente.Activo = true;
            TransactionResult resultante = mapper.Insert(cliente);
            if (resultante.IsOk)
            {
                return resultante.Id;
            }
            else
            {
                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultante.Error);
            }
        }
        internal bool Existe(int idCliente)
        {
            List<Cliente> lst = TraerClientes();
            foreach(Cliente c in lst)
            {
                if (c.Id == c.Id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
