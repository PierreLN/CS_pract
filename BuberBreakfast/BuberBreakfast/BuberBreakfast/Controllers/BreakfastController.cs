namespace BuberBreakfast.Controllers;

[ApiController]
public class BreakfastController: ControllerBase {
    [HttpPost("/breakfast")]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request) {
        return Ok();
    }
}