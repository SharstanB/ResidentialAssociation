using RA_SqlSever;

namespace RA_Repositories.Base
{
    public class BaseRepository
    {
        public  RAContext Context { get; }

        public BaseRepository(RAContext context)
        {
            Context = context;
        }
    }
}
