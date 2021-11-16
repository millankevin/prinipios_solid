using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionDependencia
{
    interface Conexion
    {
        DataTable getDatos();
        void setDatos();
    }
    class AccesoADatos
    {
        private Conexion conexion;

        public AccesoADatos(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public DataTable Datos => conexion.getDatos();
    }
    class DataServices : Conexion
    {
        DataTable datos = new DataTable();
        public DataTable getDatos() { return datos; }
        public void setDatos() { }
    }
    class APIService : Conexion
    {
        DataTable datos = new DataTable();
        public DataTable getDatos() { return datos; }
        public void setDatos() { }
    }
}
