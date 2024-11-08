﻿using System.Linq.Expressions;

namespace Datos.Datos.Repositorio.IRepositorio
{
    public interface IRepositorio<T> where T : class
    {
        T Obtener(int id);

        IEnumerable<T> ObtenerTodos(
            Expression<Func<T, bool>> filtro,
            Func<IQueryable<T>, IOrderedQueryable<T>> ordenarPor,
            string propiedadesAIncluir,
            bool seguirCambios = true
        );

        T ObtenerPrimero(
            Expression<Func<T, bool>> filtro,
            string propiedadesAIncluir,
            bool seguirCambios = true
        );

        void Agregar(T entidad);

        void Remover (T entidad);

        void RemoverRango(IEnumerable<T> entidades);

        void GuardarCambios();
    }
}
