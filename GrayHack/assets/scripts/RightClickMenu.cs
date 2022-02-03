using System.Windows.Forms;

namespace GrayHack.assets.scripts
{
    enum TypeMenu
    {
        File,
        FreeSpace,
        ProgramBar
    }
    internal static class RightClickMenu
    {
        public static ContextMenu SetContextMenu(TypeMenu typeMenu, Form form, IconDesktop icon)
        {
            ContextMenu menu = new ContextMenu();
            if (typeMenu == TypeMenu.File)
                menu.FileMenu(form, icon);

            return menu;
        }


        private static ContextMenu FileMenu(this ContextMenu menu, Form form, IconDesktop icon)
        {
            menu.MenuItems.Add("Open", (s, a) => { form.Show(); });
            menu.MenuItems.Add("Delete", (s, a) => {});
            return menu;
        }

    }
}
