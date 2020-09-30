using System.Threading;
using System.Threading.Tasks;

namespace JobsCatalog.Infrastructure
{
    public interface IWorker
    {
        Task DoWork(CancellationToken cancellationToken);
    }
}