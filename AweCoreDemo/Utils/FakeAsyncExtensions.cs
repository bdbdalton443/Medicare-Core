using System.Linq;
using System.Threading.Tasks;

namespace AweCoreDemo.Utils
{
    public static class FakeAsyncExtensions
    {
        public static Task<T[]> ToArrayAsync<T>(this IQueryable<T> items)
        {
            return Task.Run(() => items.ToArray());
        }

        public static Task<int> CountAsync<T>(this IQueryable<T> items)
        {
            return Task.Run(() => items.Count());
        }
    }
}