using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace VendorPage
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .UseBuild();

      host.Run();
    }
  }
}