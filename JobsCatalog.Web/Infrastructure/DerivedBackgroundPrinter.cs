// using System.Threading;
// using System.Threading.Tasks;
// using Microsoft.Extensions.Hosting;

// namespace JobsCatalog.Infrastructure
// {
   
//         public class DerivedBackgroundPrinter : BackgroundService
//     {
//         private readonly IWorker worker;

//         public DerivedBackgroundPrinter(IWorker worker)
//         {
//             this.worker = worker;
//         }

//         protected override async Task ExecuteAsync(CancellationToken stoppingToken)
//         {
//             await worker.DoWork(stoppingToken);    
//         }

       
//     }
    
// }