namespace RepeatingC.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope()) 
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //cinema
                if(!context.Cinemas.Any()) 
                {

                }
                //actors
                if (!context.Actors.Any())
                {

                }
                //producer
                if (!context.Producers.Any())
                {

                }
                //movies
                if (!context.Movies.Any())
                {

                }
                //actor & movies
                if (!context.Actors_Movies.Any())
                {

                }
            }
        }
    }
}
