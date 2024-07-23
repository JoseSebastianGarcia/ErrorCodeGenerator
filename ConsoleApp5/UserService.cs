using AutoFixture;
using AutoMapper;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    [SimpleJob(RuntimeMoniker.Net80)]
    [RPlotExporter]
    public class UserService
    {
        [Benchmark]
        public void ExecuteMapperly() 
        {
            var fixture = new Fixture();

            IEnumerable<User> users = fixture.CreateMany<User>(10);

            UserMapper mapper = new UserMapper();
            var userDtos = mapper.Map(users);
        }
        [Benchmark]
        public void ExecuteAutomapper()
        {
            var fixture = new Fixture();

            IEnumerable<User> users = fixture.CreateMany<User>(10);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddMaps(typeof(UserService).Assembly);
            });

            var mapper = config.CreateMapper();
            
            var userDtos = mapper.Map<List<UserDto>>(users); 
        }
    }
    [Mapper]
    public partial class UserMapper
    {
        public partial UserDto Map(User user);
        public partial List<UserDto> Map(IEnumerable<User> user);
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Fluxero { set; get; } = null!;
    }
    public class UserDto
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Manjaro { set; get; } = null!;

        public void Print() => Console.WriteLine($"{LastName}, {FirstName}, {Manjaro}");
    }
}
