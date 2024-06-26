﻿using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.Agent;
using HouseRentingSystem.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Controllers;


public class AgentController : BaseController
{
    private readonly IAgentService agentService;

    public AgentController(IAgentService agentService)
    {
        this.agentService = agentService;
    }

    [HttpGet]
    public async Task<IActionResult> Become()
    {
        if ( await agentService.ExistsByIdAsync(User.Id()))
        {
            return BadRequest();
        }
        var model = new BecomeAgentFormModel();
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Become(BecomeAgentFormModel model)
    {
        return RedirectToAction(nameof(HouseController.All),"House");
    }
}
