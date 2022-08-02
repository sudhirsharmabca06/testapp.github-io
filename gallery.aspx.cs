using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class gallery : System.Web.UI.Page
{
    int fileNo = 0;
    DataTable dtable = new DataTable(); 
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            GetAllImagesFromDirctory();
        }
    }
    private void GetAllImagesFromDirctory()
    {

        dtable.Clear();
        dtable.Columns.Add("ThumbUrl");
        dtable.Columns.Add("ImageUrl");
        dtable.Columns.Add("DateTime");

        DirectoryInfo d = new DirectoryInfo(Server.MapPath("~/images/UploadImages"));//Assuming Test is your Folder
        FileInfo[] Files = d.GetFiles("*.jpg"); //Getting Text files
        foreach (FileInfo file in Files)
        {
            DataRow _row = dtable.NewRow();
            if (file.Name.Contains("__l"))
            {
                _row["ImageUrl"] = "images/UploadImages/" + file.Name;
                string substring = file.Name.Substring(0, file.Name.IndexOf("__"));
                var thumb = from i in Files where i.Name.Equals(substring + ".jpg") select i;
                _row["ThumbUrl"] = "images/UploadImages/" + thumb.FirstOrDefault();
                _row["DateTime"] = file.CreationTime;
                dtable.Rows.Add(_row);
            }
        }

        DataView dv = new DataView(dtable);
        dv.Sort = "DateTime Desc";
        lvImagecollection.DataSource = dv;
        lvImagecollection.DataBind();

    }
}