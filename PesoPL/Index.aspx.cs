using ConvertBLL.BLL;
using ConvertDAL.Models;
using PesoPL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PesoPL
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //protected void btnConvert_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        PesoParametros parametros = new PesoParametros
        //        {
        //            Peso = double.Parse(txtPeso.Text),
        //            FromUnit = ddlFrom.SelectedValue,
        //            ToUnit = ddlTo.SelectedValue,
        //        };
        //        PesoBLL converter = new PesoBLL();
        //        parametros = converter.ConvertPeso(parametros);
        //        lblResult.Text = parametros.OutputMessage;
        //        lblResult.Visible = true;
        //        Session["Resultado"] = converter.ConvertPeso(parametros);
        //    }
        //    catch (FormatException)
        //    {
        //        lblResult.Text = $"Por favor, ingrese un valor valido.";
        //        lblResult.Visible = true;
        //    }
        //    catch (ArgumentException ex)
        //    {
        //        lblResult.Text = ex.Message;
        //        lblResult.Visible = true;
        //    }
        //}
        protected void btnConvert_Click(object sender, EventArgs e)
        {
            double peso;
            if (!double.TryParse(txtPeso.Text, out peso))
            {
                lblResult.Text = "Por favor Ingrese un Valor valido.";
                lblResult.Visible = true;
                return;

            }

            string fromUnit = ddlFrom.SelectedValue;
            string toUnit = ddlTo.SelectedValue;

            PesoParametros parametros = new PesoParametros
            {
                Peso = peso,
                FromUnit = fromUnit,  
                ToUnit = toUnit

            };

            Page.RegisterAsyncTask(new PageAsyncTask(async () =>
            {
                try
                {
                    PesoParametros result = await ConsumeAPI.ConvertWeightAsync(parametros);
                    lblResult.Text = result.OutputMessage;
                    lblResult.Visible = true;
                }
                catch (Exception ex)
                {
                    lblResult.Text = ex.Message;
                    lblResult.Visible = true;
                }

            }));


        }

    }
}