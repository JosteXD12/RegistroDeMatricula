﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MatriculaWeb
{
    public partial class prueba : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEstudiante_Click(object sender, EventArgs e)
        {
            Response.Redirect("frwEstudiante.aspx");
        }
    }
}