using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxGridView;
using DevExpress.Web.ASPxEditors;

namespace WebApplication3
{
    
    public partial class _Default : System.Web.UI.Page
    {
        SelectAllCheckbox check = new SelectAllCheckbox();
        protected void Page_Init(object sender, EventArgs e)
        {
            ASPxGridView1.DataSource = AccessDataSource1;
            ASPxGridView1.DataBind();
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (ASPxGridView1.Columns["Command"] == null)
            {
                AddColumn(ASPxGridView1, 0);
            }
            else
            {
                ASPxGridView1.Columns["Command"].HeaderCaptionTemplate = check;
            }
        }

        private void AddColumn(ASPxGridView grid, int index)
        {
            GridViewCommandColumn col = new GridViewCommandColumn();
            col.Name = "Command";
            col.ShowSelectCheckbox = true;
            col.HeaderCaptionTemplate = check;
            col.VisibleIndex = index;
           
            grid.Columns.Insert(index,col);
            
        }

        protected void ASPxGridView1_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            bool isSelected = Convert.ToBoolean(e.Parameters);
            if (isSelected)
            {
                ((ASPxGridView)sender).Selection.SelectAll();
            }
            else
            {
                ((ASPxGridView)sender).Selection.UnselectAll();
            }
            check.IsSelected = isSelected;
        }

       

    }

    class SelectAllCheckbox : ITemplate
    {
        private bool _isSelected;
        public bool IsSelected
        {
            get
            {
                return _isSelected;
            }
            set
            {
                _isSelected = value;
            }
        }
        public void InstantiateIn(Control container)
        {
            ASPxCheckBox box = new ASPxCheckBox();
            box.ID = "ASPxCheckBox1";
            box.Checked = _isSelected;
            box.ClientSideEvents.CheckedChanged = "function(s,e){grid.PerformCallback(s.GetChecked());}";
            container.Controls.Add(box);
        }
    }

      

   
}



