using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_002_Assignment05
{
    public enum FormName
    {
        SPLASHSCREEN_FORM,
        START_FORM,
        SELECT_FORM,
        PRODUCTINFO_FORM,
        ORDER_FORM
    }

    static class Program
    {

        public static Dictionary<FormName, Form> Forms;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Forms = new Dictionary<FormName, Form>();

            Forms.Add(FormName.SPLASHSCREEN_FORM, new SplashScreen());
            Forms.Add(FormName.START_FORM, new StartForm());
            Forms.Add(FormName.SELECT_FORM, new SelectForm());
            Forms.Add(FormName.PRODUCTINFO_FORM, new ProductInfoForm());
            Forms.Add(FormName.ORDER_FORM, new OrderForm());

            Application.Run(Forms[FormName.SPLASHSCREEN_FORM]);
        }
    }
}
