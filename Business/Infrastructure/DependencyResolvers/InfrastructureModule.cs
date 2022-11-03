using Application.Repository;
using FluentNHibernate.Cfg;
using Infrastructure.ModelMappings;
using Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NHibernate;

namespace Infrastructure.DependencyResolvers
{
    public static class InfrastructureModule
    {
        public static void Load(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IPersonRepository, PersonRepository>();
            services.AddSingleton<IDepartmentRepository, DepartmentRepository>();
            services.AddSingleton<IPositionRepository, PositionRepository>();

            services.AddSingleton<NHibernate.ISessionFactory>(factory =>
            {
                return Fluently.Configure()
                .Database(
                    () =>
                    {
                        return FluentNHibernate.Cfg.Db.MsSqlConfiguration.MsSql2008
                        .ShowSql()
                        .ConnectionString(configuration.GetConnectionString("DefaultConnection"));
                    }
                )
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<PersonMapping>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<DepartmentMapping>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<PositionMapping>())
                .BuildSessionFactory();
            }
            );

            services.AddSingleton<ISession>(factory => factory.GetServices<ISessionFactory>().First().OpenSession());
        }
    }
}
