using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLStudioBrowserColorizer
{
    public static class MetroExtension
    {
        public static void SetStyle(this IContainer container, MetroForm ownerForm)
        {
            var query = Enum.GetValues(typeof(MetroColorStyle))
            .Cast<MetroColorStyle>()
            .Except(new MetroColorStyle[] { MetroColorStyle.White }).ToArray();

            Random random = new Random();
            MetroColorStyle rcolor = (MetroColorStyle)query.GetValue(random.Next(query.Length));

            var manager = new MetroStyleManager(container ?? (container = new Container()));
            manager.Owner = ownerForm;
            container.SetDefaultStyle(ownerForm, rcolor);
        }
        public static void SetDefaultStyle(this IContainer contr, MetroForm owner, MetroColorStyle style)
        {
            MetroStyleManager manager = FindManager(contr, owner);
            manager.Style = style;
            owner.Style = style;
        }
        public static void SetDefaultTheme(this IContainer contr, MetroForm owner, MetroThemeStyle thme)
        {
            Array values = Enum.GetValues(typeof(MetroThemeStyle));
            Random random = new Random();
            MetroThemeStyle rcolor = (MetroThemeStyle)values.GetValue(random.Next(values.Length));

            MetroStyleManager manager = FindManager(contr, owner);
            manager.Theme = thme;
        }
        private static MetroStyleManager FindManager(IContainer contr, MetroForm owner)
        {
            MetroStyleManager manager = null;
            foreach (IComponent item in contr.Components)
                if (item is MetroStyleManager)
                    manager = item as MetroStyleManager;
            return manager;
        }
    }
}