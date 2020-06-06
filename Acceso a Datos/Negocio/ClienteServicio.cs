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
    }
}
