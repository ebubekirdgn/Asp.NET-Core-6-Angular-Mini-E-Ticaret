﻿namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ETicaretAPIDbContext>(options =>
            {
                options.UseNpgsql("User ID=postgres;Password=12345;Host=localhost;Port=5432;Database=ETicaretAPIDb;");
            });
        }
    }
}