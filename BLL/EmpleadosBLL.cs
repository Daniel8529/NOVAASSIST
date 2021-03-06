using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using NOVAASSIST.DAL;
using NOVAASSIST.Entidades;

namespace NOVAASSIST.BLL
{
    public class EmpleadosBLL
    {
        public static bool Guardar(Empleados empleados)
        {
            if(!Existe(empleados.EmpleadoId))
                return Insertar(empleados);
            else
                return Modificar(empleados);
        }

        public static bool Insertar(Empleados empleados)
        {
            bool confirmar = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Empleados.Add(empleados);
                confirmar = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally { contexto.Dispose(); }

            return confirmar;
        }

        public static bool Modificar(Empleados empleados)
        {
            bool confirmar = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(empleados).State = EntityState.Modified;
                confirmar = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return confirmar;
        }

        public static bool Eliminar(int id)
        {
            bool confirmar = false;
            Contexto contexto = new Contexto();

            try
            {
                var empleados = contexto.Empleados.Find(id);
                if(empleados != null)
                {
                    contexto.Empleados.Remove(empleados);
                    confirmar = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { contexto.Dispose(); }

            return confirmar;
        }

        public static Empleados Buscar(string id)
        {
            Contexto contexto = new Contexto();
            Empleados? empleados;

            try
            {
                empleados = contexto.Empleados.Where(A => A.ClaveAcceso==id).SingleOrDefault();
                 
            }
            catch (Exception)
            {
                throw;
            }
            finally { contexto.Dispose(); }

            return empleados;
        }

        public static Empleados Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Empleados? empleados;

            try
            {
                empleados = contexto.Empleados.Where(e => e.EmpleadoId == id).SingleOrDefault();
                 
            }
            catch (Exception)
            {
                throw;
            }
            finally { contexto.Dispose(); }

            return empleados;
        }

        public static bool Existe(string id, string id2)
        {
            bool confirmars = false;
            Contexto contexto = new Contexto();

            try
            {
                var confirmar = from Empleados in contexto.Empleados
                    where Empleados.ClaveUsuarios == id && Empleados.ClaveAcceso == id2
                    select Empleados;

               if(confirmar.Count() > 0)
                    confirmars = true;
               else
                    confirmars = false;
            }
            catch (Exception)
            {
                throw;
            }
            finally { contexto.Dispose(); }

            return confirmars;
        }

        private static bool Existe(int id)
        {
            bool confirmar = false;
            Contexto contexto = new Contexto();

            try
            {
                confirmar = contexto.Empleados.Any(e => e.EmpleadoId == id);
            }
            catch (Exception)
            {
                throw;
            }

            return confirmar;
        }

        public static List<Empleados> GetEmpleados()
        {
            List<Empleados> lista = new List<Empleados>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Empleados.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally { contexto.Dispose(); }

            return lista;
        }

        public static List<Empleados> GetList(Expression<Func<Empleados, bool>> criterio)
        {
            List<Empleados> lista = new List<Empleados>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Empleados?.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally { contexto.Dispose(); }

            return lista;
        }

        public static List<Areas> GetAreas()
        {
            List<Areas> lista = new List<Areas>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Areas.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }

        public static List<Vacaciones> GetVacaciones()
        {
            List<Vacaciones> lista = new List<Vacaciones>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Vacaciones.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
    }
}