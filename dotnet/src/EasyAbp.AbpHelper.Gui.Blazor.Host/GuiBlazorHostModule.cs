﻿using Volo.Abp.Modularity;

namespace EasyAbp.AbpHelper.Gui
{
    [DependsOn(
        typeof(GuiBlazorModule)
    )]
    public class GuiBlazorHostModule : AbpModule
    {
    }
}
