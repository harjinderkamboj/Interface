using Dal;

namespace RestaurantApplication.Services
{
    public class RestaurantService : IRestaurantService	
    {
		private IRestaurantRepository _personRepository;

		//public RService()
		//{
		//	_personRepository = new PersonRepository();
		//}
		public RestaurantService(IRestaurantRepository personRepository)
		{
			_personRepository = personRepository;
		}

		string IRestaurantService.GetResponse(string req)
		{
			return string.Format("hello {0}", req);
		}


		public int AddOne(int p)
		{
			return p + 1;
		}

		public Restaurant GetDataFromPR(int id)
		{
			return _personRepository.GetById(id);
		}

	}
}
