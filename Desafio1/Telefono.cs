using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Telefono
    {
        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }

        private string modelo;
        private string marca;
        public int numeroTelefonico { get; set; }
        public int codigoOperador { get; set; }

        public void setModelo(string Modelo)
        {
            modelo = Modelo;
        }

        public void setMarca(string Marca)
        {
            marca = Marca;
        }

        public string getModelo()
        {
            return modelo;
        }

        public string getMarca()
        {
            return marca;
        }

        public void setCodigoOperador(int CodigoOperador)
        {
            codigoOperador = CodigoOperador;
        }

        public int getCodigoOperador()
        {
            if (codigoOperador == 1 || codigoOperador == 2 || codigoOperador == 3)
                return codigoOperador;
            else
                return 0;
        }

        public string llamar()
        {
            return "realizando llamada";
        }
        public string llamar( string contacto)
        {
            return "llamando a " + contacto;
        }
    }
}
