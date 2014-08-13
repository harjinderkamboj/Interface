using Dal;

namespace ClassLibrary1
{
    public class RService : IRService	
    {
		private IPersonRepository _personRepository;

		//public RService()
		//{
		//	_personRepository = new PersonRepository();
		//}
		public RService(IPersonRepository personRepository)
		{
			_personRepository = personRepository;
		}

		string IRService.GetResponse(string req)
		{
			return string.Format("hello {0}", req);
		}


		public int AddOne(int p)
		{
			return p + 1;
		}

		public Person GetDataFromPR(int id)
		{
			return _personRepository.GetById(id);
		}

	}
}
