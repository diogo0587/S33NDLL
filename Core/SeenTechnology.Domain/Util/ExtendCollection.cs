using System;
using System.Collections.Generic;
using System.Linq;

namespace SeenTechnology.Domain.Util
{
    public static class ExtendCollection
    {
        public static IEnumerable<T> Paginate<T, TResult>(this IEnumerable<T> query, int pageNumber, int limitForPages, Func<T, TResult> orderByQuery,
            bool ascending, out int numberOfRows, out int numberOfPages)
        {
            if (limitForPages <= 0)
                throw new ArgumentException("O limite por página deve ser maior que zero.");

            numberOfRows = query.Count();
            numberOfPages = 1;

            if(pageNumber <= 0)
                throw new ArgumentException("O número da página deve ser maior que zero.");

            if (numberOfRows > limitForPages)
                numberOfPages = (int)Math.Ceiling((numberOfRows / (decimal)limitForPages));

            int rowsToExclude = (pageNumber - 1) * limitForPages;

            query = (ascending)
                ? query.OrderBy(orderByQuery)
                : query.OrderByDescending(orderByQuery);
            
            return query.Skip(rowsToExclude).Take(limitForPages);
        }
    }
}
