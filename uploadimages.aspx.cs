using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Data;

public partial class uploadimages : System.Web.UI.Page
{
  
    Guid fileuniqueid = Guid.Empty;
    DataTable dtable = new DataTable(); 
    protected string ThumbUrlPath="";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] == null)
        {
            Response.Redirect("bharatlogin.aspx");

        }
        HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.NoCache);
        HttpContext.Current.Response.Cache.SetNoStore();

        if (!Page.IsPostBack)
        {
            GetAllImagesFromDirctory();
        }
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        LinkButton btn = sender as LinkButton;
        string thumbFilePath = btn.CommandName.ToString();
        string largeFilePath = thumbFilePath.Insert(thumbFilePath.LastIndexOf("."), "__l");
        if (File.Exists(Server.MapPath(thumbFilePath)))
        {
            File.Delete(Server.MapPath(thumbFilePath));
        }
        if (File.Exists(Server.MapPath(largeFilePath)))
        {
            File.Delete(Server.MapPath(largeFilePath));
        }
        GetAllImagesFromDirctory();

      
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
       
            if (FileUpload1.HasFile)
            {              
                fileuniqueid =Guid.NewGuid();
                string fileName = fileuniqueid + "__l";
                FileUpload1.SaveAs(Server.MapPath("~/images/UploadImages") + "\\" + fileName + ".jpg");             
                string thumbimagespath = "~/images/UploadImages" + "\\" + fileuniqueid + ".jpg";
                string uploadFile=Server.MapPath(("~/images/UploadImages") + "\\" + fileName + ".jpg");
                Stream strm = FileUpload1.PostedFile.InputStream;
                GenerateThumbnails(0.2, strm, thumbimagespath);
                Page.ClientScript.RegisterClientScriptBlock(GetType(), "", "alert('File uploaded successfully.')", true);

            }

      
        else
        {

            //if (FileUpload1.HasFile)
            //{
            //    FileUpload1.SaveAs(Server.MapPath("~/ProductImage/Img1") + "\\" + 1 + ".jpg");
            //    string thumbimagespath = "~/ProductImage/Thmb1" + "\\" + 1 + ".jpg";

            //    Stream strm = FileUpload1.PostedFile.InputStream;
            //    GenerateThumbnails(0.2, strm, thumbimagespath);
            //}
        }

        //btnSave.Text = "Save";
        GetAllImagesFromDirctory();
        
    }
    public void WriteImage(string path, int width, int height)
    {
        Bitmap srcBmp = new Bitmap(path);
        float ratio = srcBmp.Width / srcBmp.Height;
        SizeF newSize = new SizeF(width, height * ratio);
        Bitmap target = new Bitmap((int)newSize.Width, (int)newSize.Height);
        Response.Clear();
        Response.ContentType = "image/jpeg";
        using (Graphics graphics = Graphics.FromImage(target))
        {
            graphics.CompositingQuality = CompositingQuality.HighSpeed;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.CompositingMode = CompositingMode.SourceCopy;
            graphics.DrawImage(srcBmp, 0, 0, newSize.Width, newSize.Height);
            using (MemoryStream memoryStream = new MemoryStream())
            {
                target.Save(memoryStream, ImageFormat.Jpeg);
                memoryStream.WriteTo(Response.OutputStream);
            }
        }
        Response.End();


    }

    private void GenerateThumbnails(double scaleFactor, Stream sourcePath, string targetPath)
    {
        System.Drawing.Image imageToBeResized = System.Drawing.Image.FromStream(sourcePath);

        int imageHeight = imageToBeResized.Height;
        int imageWidth = imageToBeResized.Width;
        Bitmap bitmap = new Bitmap(imageToBeResized,203, 108);
        System.IO.MemoryStream stream = new MemoryStream();
        bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
        bitmap.Dispose();
        stream.Position = 0;
        byte[] image = new byte[stream.Length + 1];
        stream.Read(image, 0, image.Length);
        System.IO.FileStream fs1 = new System.IO.FileStream(Server.MapPath(targetPath), System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite);
        fs1.Write(image, 0, image.Length);


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
      

    protected void btnlogout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        Response.Redirect("bharatlogin.aspx");
        HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.NoCache);
        HttpContext.Current.Response.Cache.SetNoStore();
    }
    protected void hlViwGallery_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        Response.Redirect("gallery.aspx");
        HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.NoCache);
        HttpContext.Current.Response.Cache.SetNoStore();
    }

    
}