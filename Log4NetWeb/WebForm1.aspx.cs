using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Log4NetWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ILog logger = log4net.LogManager.GetLogger("ErrorLog");
                try
                {
                    throw new Exception("Divide By Zero Exception", new DivideByZeroException());
                }
                catch (Exception ex)
                {
                    logger.Error(ex.Message);
                }
            }
        }
    }
}