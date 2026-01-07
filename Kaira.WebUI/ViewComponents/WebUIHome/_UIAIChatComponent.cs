using Kaira.WebUI.DTOs.AIDtos;
using Microsoft.AspNetCore.Mvc;

public class _UIAIChatComponent : ViewComponent
{
    public IViewComponentResult Invoke(AIStyleResponseDto model)
    {
        return View(model);
    }
}
