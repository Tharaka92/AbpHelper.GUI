﻿using EasyAbp.AbpHelper.Gui.Localization;
using Volo.Abp.AspNetCore.Components;

namespace EasyAbp.AbpHelper.Gui
{
    public abstract class GuiComponentBase : AbpComponentBase
    {
        protected GuiComponentBase()
        {
            LocalizationResource = typeof(GuiResource);
        }
    }
}
