﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Welcome : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bool sqlexec;
            string sqlresult;

            DataTable dt = MySQL.ExecProc("usp_M_Users_GetAll", new string[] { }, out sqlexec, out sqlresult).Tables[0];
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }
    }
}