using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio2_aspx
{
	public partial class New1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btn_Confir_Click(object sender, EventArgs e)
        {
			Response.Redirect(
				"New2.aspx" +
				"?ddlCategory=" + ddlCategory.SelectedValue +
				"&ddlSupplier=" + ddlSupplier.SelectedValue +
				"&txtProduct=" + txtProduct.Text +
				"&txtDescription=" + txtDescription.Text +
				"&txtImage=" + txtImage.Text +
				"&txtPrice=" + txtPrice.Text +
				"&txtNumberInStock=" + txtNumberInStock.Text +
				"&txtNumberOnOrder=" + txtNumberOnOrder.Text +
				"&txtReorderLevel=" + txtReorderLevel.Text
				);
		}
    }
}