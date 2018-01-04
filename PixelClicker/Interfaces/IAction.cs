using System;
using PixelClicker.Model;

namespace PixelClicker.Interfaces
{
    public interface IAction
    {
        ActionResult DoAction(IActionProperty actionProperty);
        ActionResult DoAction();
    }
}