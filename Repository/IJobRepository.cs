namespace JobHub.Repository
{
    public interface IJobRepository
    {
        void Apply(int jobId, string userId);
        void SaveJob(int jobId, string userId);


    }
}