﻿using Abp.Application.Navigation;
using Abp.Localization;

namespace SimpleTaskSystem0726.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See .cshtml and .js files under App/Main/views/layout/header to know how to render menu.
    /// </summary>
    public class SimpleTaskSystem0726NavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        new LocalizableString("HomePage", SimpleTaskSystem0726Consts.LocalizationSourceName),
                        url: "#/",
                        icon: "fa fa-home"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "About",
                        new LocalizableString("About", SimpleTaskSystem0726Consts.LocalizationSourceName),
                        url: "#/about",
                        icon: "fa fa-info"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "TaskList",
                        new LocalizableString("TaskList", SimpleTaskSystem0726Consts.LocalizationSourceName),
                        url: "#/tasklist",
                        icon: "fa fa-info"
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        "NewTask",
                        new LocalizableString("NewTask", SimpleTaskSystem0726Consts.LocalizationSourceName),
                        url: "#/task/new",
                        icon: "fa fa-info"
                    )
                );
        }
    }
}
