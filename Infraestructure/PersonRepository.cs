using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using QueryApi.Domain;
using System.Threading.Tasks;

namespace QueryApi.Repositories
{
    public class PersonRepository
    {
        List<Person> _persons;

        public PersonRepository()
        {
            var fileName = "dummy.data.queries.json";
            if(File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                _persons = JsonSerializer.Deserialize<IEnumerable<Person>>(json).ToList();
            }
        }

        // retornar todos los valores
        public IEnumerable<Person> GetAll()
        {
            // origen, Método, iterador
            var query = _persons.Select(person => person);
            return query;
        }

        // retornar campos especificos

        public IEnumerable<Object> GetFields()
        {
            var query = _persons.Select(person=>new{
                NombreCompleto = $"{person.FirstName}{person.LastName}",
                AnioNacimiento = DateTime.Now.AddYears(person.Age * -1).Year,
                CorreoElectronico=person.Email
            });
            return query;
        }

        // retornar elementos que sean iguales
        public IEnumerable<Person> GetByGender()
        {
            var gender = 'F';
            var query = _persons.Where(person => person.Gender == gender); 
            return query;
        }

        public IEnumerable<Person> GetMinusAge()
        {
            var age = 30;
            var query = _persons.Where(person => person.Age <= age); 
            return query;
        }
        // Retornar elementos que sean diferentes
        public IEnumerable<Person> GetDiference()
        {
            var age = 30;
            var gender ='M';
            var query = _persons.Where(person => person.Age <= age && person.Gender != gender); 
            return query;
        }

        public IEnumerable<string> GetJobs()
        {
            //from(origen) join(inersecciones) where (consultas) select (seleccion))
            var age = 30;
            var gender ='M';
            var query = _persons.Where(person=>person.Age<=age && person.Gender
            != gender).Select(person=>person.Job).Distinct();
            return query;
        }

        // retornar valores que contengan
        
        public IEnumerable<Person> GetStartWith()
        {
            var start = "Mar";
            var query = _persons.Where(x => x.Job.StartsWith(start));
            return query;
        }

        public IEnumerable<Person> GetContains()
        {
            var word = "er";
            var query = _persons.Where(x => x.FirstName.Contains(word));
            return query;
        }

        public IEnumerable<Person> GetByList()
        {
           var ages = new List<int>{15,25,35};
           var query = _persons.Where(person=>ages.Contains(person.Age));
           return query; 
        }
        // retornar valores entre un rango
        
        // retornar elementos ordenados

        public IEnumerable<Person> GetOrdered()
        {
            var age = 47;
            var query = _persons.Where(person=>person.Age>age).
            OrderBy(person=>person.Age);
            return query;
        }

        public IEnumerable<Person> GetOrderedDesc()
        {
            var minAge = 20;
            var maxAge = 30;
            var query = _persons.Where(person=>person.Age>=minAge && person.Age < maxAge).
            OrderByDescending(person=>person.Age);
            return query;
        }

        //
        // Tarea: Averiguar como ordenar por más de una columna
        
        // retorno cantidad de elementos

        public int CountPerson()
        {
            var gender = 'F';
            var query= _persons.Count(person => person.Gender == gender);
            return query;
        }
        
        // Evalua si un elemento existe

        public bool ExistPerson()
        {
            var lastName="Shemelt";
            //Aleksandr
            var query = _persons.Exists(p=>p.LastName==lastName);
            return query;
        }

        public bool AnyPerson()
        {
            //var lastName="Shemelt";
            var firstName="Aleksandr";
            var query = _persons.Any(p=>p.FirstName==firstName);
            return query;
        }
        
        // retornar solo un elemento

        public Person GetFirst()
        {
            var age = 26;
            var job = "Software Consultant";

            var query = _persons.FirstOrDefault(p=> p.Age == age && p.Job==job);

            return query; 
        }
        
        // retornar solamente unos elementos

        public IEnumerable<Person> TakePerson()
        {
            var job = "Software Consultant";
            var take = 3;
            //var skip = 3;

            var query = _persons.Where(p=>p.Job==job).Take(take);

            return query;
        }

        public IEnumerable<Person> SkipPerson()
        {
            var job = "Software Consultant";
            var take = 3;
            var skip = 3;

            var query = _persons.Where(p=>p.Job==job).Skip(skip).Take(take);

            return query;
        }
        
        // retornar elementos saltando posición
        
    }
}