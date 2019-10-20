using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;

namespace AnalisisWebApp.Utilitarios
{
    public static class Utils
    {
        public static int ToInt(string valor)
        {
            int retorno = 0;
            int.TryParse(valor, out retorno);

            return retorno;
        }

        public static string Descripcion(int IdLista)
        {
            RepositorioBase<TipoAnalisis> repositorio = new RepositorioBase<TipoAnalisis>();
            TipoAnalisis tipoAnalisis = new TipoAnalisis();
            int id = IdLista;
            tipoAnalisis = repositorio.Buscar(id);

            string desc = tipoAnalisis.Descripcion;

            return desc;
        }


        public static int ToIntObjetos(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);

            return retorno;
        }

        public static double ToDouble(string valor)
        {
            double retorno = 0;
            double.TryParse(valor, out retorno);

            return retorno;
        }

        public static double ToDoubleObjetos(object valor)
        {
            double retorno = 0;
            double.TryParse(valor.ToString(), out retorno);

            return Convert.ToDouble(retorno);
        }

        public static decimal ToDecimal(string valor)
        {
            decimal retorno = 0;
            decimal.TryParse(valor, out retorno);

            return retorno;
        }

        public static DateTime ToDateTime(string valor)
        {
            DateTime retorno = DateTime.Now;
            DateTime.TryParse(valor, out retorno);

            return retorno;
        }

        public static void ShowToastr(this Page page, string message, string title, string type = "info")
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "toastr_message",
                  String.Format("toastr.{0}('{1}', '{2}');", type.ToLower(), message, title), addScriptTags: true);
        }

        public static void MostrarMensaje(this Page page, string message, string title, string type = "info")
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "toastr_message",
                 String.Format("toastr.{0}('{1}', '{2}');", type.ToLower(), message, title), addScriptTags: true);
        }

        public static List<Analisis> FiltrarAnalisis(int index, string criterio, DateTime desde, DateTime hasta)
        {
            Expression<Func<Analisis, bool>> filtro = p => true;
            RepositorioBase<Analisis> repositorio = new RepositorioBase<Analisis>();
            List<Analisis> list = new List<Analisis>();

            int id = ToInt(criterio);
            switch (index)
            {
                case 0://Todo
                    break;

                case 1://Todo por fecha
                    filtro = p => p.Fecha >= desde && p.Fecha <= hasta;
                    break;

                case 2://FacturaId
                    filtro = p => p.AnalisisId == id && p.Fecha >= desde && p.Fecha <= hasta;
                    break;

                case 3://ClienteId
                    filtro = p => p.PersonaId == id && p.Fecha >= desde && p.Fecha <= hasta;
                    break;
            }

            list = repositorio.GetList(filtro);

            return list;
        }

        public static List<Persona> FiltrarPersonas(int index, string criterio, DateTime desde, DateTime hasta)
        {
            Expression<Func<Persona, bool>> filtro = p => true;
            RepositorioBase<Persona> repositorio = new RepositorioBase<Persona>();
            List<Persona> list = new List<Persona>();

            int id = ToInt(criterio);
            switch (index)
            {
                case 0://Todo
                    break;

                case 1://FacturaId
                    filtro = p => p.PersonaId == id;
                    break;

                case 2://ClienteId
                    filtro = p => p.Nombres.Contains(criterio);
                    break;
            }

            list = repositorio.GetList(filtro);

            return list;
        }

        public static List<TipoAnalisis> FiltrarTipoAnalisis(int index, string criterio, DateTime desde, DateTime hasta)
        {
            Expression<Func<TipoAnalisis, bool>> filtro = p => true;
            RepositorioBase<TipoAnalisis> repositorio = new RepositorioBase<TipoAnalisis>();
            List<TipoAnalisis> list = new List<TipoAnalisis>();

            int id = ToInt(criterio);
            switch (index)
            {
                case 0://Todo
                    break;

                case 1://FacturaId
                    filtro = p => p.TipoId == id;
                    break;

                case 2://ClienteId
                    filtro = p => p.Descripcion.Contains(criterio);
                    break;
            }

            list = repositorio.GetList(filtro);

            return list;
        }

        public static List<Analisis> FAnalisis()
        {
            Expression<Func<Analisis, bool>> filtro = p => true;
            RepositorioBase<Analisis> repositorio = new RepositorioBase<Analisis>();
            List<Analisis> list = new List<Analisis>();
            list = repositorio.GetList(filtro);

            return list;
        }

        public static List<Pago> FiltrarPagos(int index, string criterio, DateTime desde, DateTime hasta)
        {
            Expression<Func<Pago, bool>> filtro = p => true;
            RepositorioBase<Pago> repositorio = new RepositorioBase<Pago>();
            List<Pago> list = new List<Pago>();

            int id = ToInt(criterio);
            switch (index)
            {
                case 0://Todo
                    break;

                case 1://FacturaId
                    filtro = p => p.PagoId == id;
                    break;

                case 2://ClienteId
                    filtro = p => p.PersonaId == id;
                    break;
            }

            list = repositorio.GetList(filtro);

            return list;
        }

        public static List<Pago> FPagos()
        {
            Expression<Func<Pago, bool>> filtro = p => true;
            RepositorioBase<Pago> repositorio = new RepositorioBase<Pago>();
            List<Pago> list = new List<Pago>();
            list = repositorio.GetList(filtro);

            return list;
        }

    }

}