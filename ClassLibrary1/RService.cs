namespace ClassLibrary1
{
    public class RService : IRService	
    {
		string IRService.getResponse(string req)
		{
			return string.Format("hello {0}", req);
		}


		public int AddOne(int p)
		{
			return p + 1;
		}
	}
}
