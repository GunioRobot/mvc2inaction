using AutoMapper;

namespace WithAutomapper.Models
{
	public class AutoMapperConfiguration
	{
		public static void Configure()
		{
			Mapper.Initialize(x => x.AddProfile<ExampleProfile>());
		}
	}
}