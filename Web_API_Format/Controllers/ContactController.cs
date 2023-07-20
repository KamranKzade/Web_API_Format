using Web_API_Format.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Web_API_Format.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContactController : ControllerBase
{
	[HttpGet("")]
	public List<ContactDto> GetContacts()
	{
		return new List<ContactDto>()
		{
			new ContactDto
			{
				Id = 1,
				Firstname = "Tural",
				Lastname="Novruzov",
				PAN="4169711122526996"
			},
			new ContactDto
			{
				Id = 2,
				Firstname = "Kamran",
				Lastname="Karimzada",
				PAN="4169717152527996"
			},
		};
	}
}
