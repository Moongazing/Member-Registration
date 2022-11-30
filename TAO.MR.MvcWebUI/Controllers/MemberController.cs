using Microsoft.AspNetCore.Mvc;
using TAO.MR.Business.Abstract;
using TAO.MR.Entities.Concrete;
using TAO.MR.MvcWebUI.Models;

namespace TAO.MR.MvcWebUI.Controllers
{
  public class MemberController : Controller
  {
    private IMemberService _memberService;
    public MemberController(IMemberService memberService)
    {
      _memberService = memberService;
    }
    public IActionResult Add()
    {
      return View(new MemberAddViewModel());
    }
    [HttpPost]
    public IActionResult Add(Member member)
    {
      _memberService.Add(member);
      return View(new MemberAddViewModel());
    }
  }
}
