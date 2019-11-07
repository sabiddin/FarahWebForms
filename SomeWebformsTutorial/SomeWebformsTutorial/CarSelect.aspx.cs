using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SomeWebformsTutorial.App_Code;

namespace SomeWebformsTutorial
{
    public partial class CarSelect : System.Web.UI.Page
    {        
        List<MakeOption> makes = new List<MakeOption>() {
            new MakeOption(){ MakeId = 1, MakeName ="Nissan"},
            new MakeOption(){ MakeId = 2, MakeName ="Honda"},
            new MakeOption(){ MakeId = 3, MakeName ="Toyota"}
        };
        List<ModelOption> models = new List<ModelOption>() {
            new ModelOption() { MakeId =1, ModelId =1, ModelName ="Altima"},
            new ModelOption() { MakeId =1, ModelId =2, ModelName ="Maxima"},
            new ModelOption() { MakeId =1, ModelId =3, ModelName ="Rogue"},
            new ModelOption() { MakeId =2, ModelId =4, ModelName ="Accord"},
            new ModelOption() { MakeId =2, ModelId =5, ModelName ="Civic"},
            new ModelOption() { MakeId =3, ModelId =6, ModelName ="Corolla"},
        };
        protected void Page_Init(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadMake();
            }
        }

        private void LoadMake()
        {            
            ddlMake.DataSource = makes;
            ddlMake.DataValueField = "MakeId";
            ddlMake.DataTextField = "MakeName";
            ddlMake.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void ddlMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadModels(ddlMake.SelectedValue);
        }

        private void LoadModels(string selectedValue)
        {
            int makeid = Convert.ToInt32(selectedValue);
            ddlModels.DataSource = models.Where(m => m.MakeId == makeid);
            ddlModels.DataTextField = "ModelName";
            ddlModels.DataValueField = "ModelId";
            ddlModels.DataBind();
        }
    }
}