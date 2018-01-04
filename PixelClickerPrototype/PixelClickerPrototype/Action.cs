using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using PixelClicker.Interfaces;
using PixelClicker.Model;
using PixelClicker.Types;

namespace PixelClickerPrototype
{
    public class Action : IAction
    {
        public ActionResult DoAction(IActionProperty actionProperty)
        {
            ActionResult actionResult = new ActionResult {Success = false};

            if (actionProperty.DoAction)
            {
                var ap = (ActionProperty)actionProperty;
                Settings.Instance().CurrentAimPos = ap.AimPoint;
                Settings.Instance().PointsInfo = ap.PointsInfo;

                if (PixelClicker.Core.Keyboard.IsKeyDown(ap.Settings.Hotkey))
                {
                    var moveX = (int) ((ap.AimPoint.X - ap.Settings.WidthOffset));
                    var heightAdjusted = ap.Settings.SearchMethod != SearchMethod.AnyWhere ? 1.75 : 1;
                    var moveY = (int) (ap.AimPoint.Y - (ap.Settings.HeightOffset*heightAdjusted));
                    var divideby = Math.Ceiling(ap.Settings.Sensitivity*2/7d);


                    PixelClicker.Core.Mouse.Move((int) (moveX/divideby), (int) (moveY/divideby));

                    actionResult.Success = true;
                }
            }
            else
            {
                Settings.Instance().CurrentAimPos = new Point(0,0);
                Settings.Instance().PointsInfo = null;
            }

            return actionResult;
        }


        public ActionResult DoAction()
        {
            throw new NotImplementedException();
        }
    }
}
