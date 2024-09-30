using Tarefa3.Domain.Interfaces.Service;
using Tarefa3.Domain.Models;

namespace Tarefa3.Application.Services
{
    public class PersonService : IPersonService
    {
        public async Task<List<Person>> GetAll()
        {
            List<Person> listPerson = new List<Person>
            {
                new Person
                {
                    Name = "Paulo Okimoto",
                    Age = 30,
                    Address = new PersonAddress
                    {
                        Street = "Teste rua",
                        Number = 123,
                        City = "Campinas",
                        State = "SP"
                    },
                    Gender = "??"
                },
                new Person
                {
                    Name = "John Doe",
                    Age = 40,
                    Address = new PersonAddress
                    {
                        Street = "Teste rua",
                        Number = 123,
                        City = "Bragança Paulista",
                        State = "SP"
                    },
                    Gender = "M" 
                }
            };
            return listPerson;
        }
    }
}
