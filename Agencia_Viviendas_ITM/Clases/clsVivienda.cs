using Agencia_Viviendas_ITM.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Agencia_Viviendas_ITM.Clases
{
    public class clsVivienda
    {
        private DBAgenciaITMEntities dbAgenciaITM = new DBAgenciaITMEntities(); //Objeto para gestionar los datos de las viviendas con la base de datos
        public Vivienda vivienda { get; set; } //Objeto tipo Vivienda para gestionar el CRUD en la base de datos


        public string Insertar()
        {
            try
            {
                dbAgenciaITM.Viviendas.Add(vivienda);
                dbAgenciaITM.SaveChanges();
                return "Se grabó la vivienda en la base de datos.";
            }
            catch (Exception ex)
            {
                return "Error al registrar la vivienda: " + ex.Message;
            }
        }


        //Método para consultar una vivienda por su ID
        public Vivienda Consultar(int id)
        {
            return dbAgenciaITM.Viviendas.FirstOrDefault(e => e.Id == id);
        }

        //Método para consultar todas las viviendas
        public List<Vivienda> ConsultarTodos()
        {
            return dbAgenciaITM.Viviendas
                .OrderBy(e => e.Valor)
                .ToList();
        }

        public string Actualizar()
        {
            try
            {
                Vivienda vivien = Consultar(vivienda.Id);
                if (vivien == null)
                {
                    return "La vivienda no está definida en la base de datos.";
                }
                dbAgenciaITM.Viviendas.AddOrUpdate(vivienda);
                dbAgenciaITM.SaveChanges();
                return "Se actualizó la vivienda en la base de datos.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar la vivienda: " + ex.Message;
            }
        }


        public string Eliminar(int id)
        {
            try
            {
                Vivienda vivien = Consultar(id);
                if (vivien == null)
                {
                    return "La vivienda no está definida en la base de datos.";
                }
                dbAgenciaITM.Viviendas.Remove(vivien);
                dbAgenciaITM.SaveChanges();
                return "Se eliminó la vivienda en la base de datos.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar la vivienda: " + ex.Message;
            }
        }

        public string ModificarActivo(int Id, bool Activo)
        {
            try
            {
                //Consultar si la vivienda existe
                Vivienda vivien = Consultar(Id);
                if (vivien == null)
                {
                    return "La vivienda que intenta modificar no existe";
                }
                //Modificar el estado de la vivienda
                vivien.Activo = Activo;
                dbAgenciaITM.SaveChanges();
                if (Activo)
                {
                    return "Vivienda activada correctamente";
                }
                else
                {
                    return "Vivienda desactivada correctamente";
                }

            }
            catch (Exception ex)
            {
                return "Error al modificar el estado de la vivienda: " + ex.Message;

            }
        }

    }
}