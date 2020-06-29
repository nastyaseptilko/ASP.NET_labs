
using System.Collections.Generic;

namespace AbstractPhoneDataProvider
{
    public interface IPhoneDictionary
    {
        List<Person> GetAll();
        Person InsertOne(Person person);
        Person UpdateOne(Person newPerson);
        Person DeleteOne(int personId);
    }
}
