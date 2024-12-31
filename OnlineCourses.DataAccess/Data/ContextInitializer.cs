using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace OnlineCourses.DataAccess.Data
{
    public static class ContextInitializer
    {
        public static void Initialize(Context context)
        {
            if (context.Database.GetPendingMigrations().Count() > 0)
            {
                context.Database.Migrate();
            }
        }
    }
}
