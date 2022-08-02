using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class XYZ : System.Web.UI.Page
{
    static string url = "~/ExpImages/";
    int imageCount = 1;
    int timeButtonClick = 0;
    public static Stopwatch sw;
    int timerCount = 0;
    DateTime dt;
    static int timerRightCount = 0;
    static int timerWrongCount = 0;
    public int time_second;
    public int time_min;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Timer1.Enabled = true;
            Panel1.BackColor = Color.Black;
            img.ImageUrl = url + "1.jpg";
            timerRightCount = 0;
            timerWrongCount = 0;
        }
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        Session["min"] = time_min.ToString();
        Session["sec"] = time_second.ToString();
        time_second = int.Parse(lblsec1.Text);
        time_second = time_second + 1;
        lblsec1.Text = time_second.ToString();
        if (lblsec1.Text == "10")
        {
            lblsec2.Visible = false;
        }
        if (lblmin1.Text == "10")
        {
            lblmin2.Visible = true;
        }

        if (lblsec1.Text == "60")
        {
            lblsec2.Visible = true;
            time_min = int.Parse(lblmin1.Text);
            lblsec1.Text = "0";
            time_min = time_min + 1;
            lblmin1.Text = time_min.ToString();
        }


    }

    protected void btnTimeStop_Click(object sender, EventArgs e)
    {
        int totalTimeMin = 0;
        int totalTimeSec = 0;
        if (lblmin1.Text != "0")
        {
            totalTimeMin = Convert.ToInt32(lblmin1.Text.ToString()) * 60;
        }
        if (lblsec1.Text != "0")
        {
            totalTimeSec = Convert.ToInt32(lblsec1.Text.ToString());
        }
        if (((totalTimeMin + totalTimeSec) % 30) == 0)
        {
            lblTimerPressResult.Visible = true;
            lblTimerPressResult.ForeColor = System.Drawing.Color.Green;
            lblTimerPressResult.Text = "Right";
            timerRightCount = timerRightCount + 1;

            lblisRightCount.Visible = true;
            lblisRightCount.ForeColor = System.Drawing.Color.Green;
            lblisRightCount.Text = "Button press on right time: " + timerRightCount;
        }
        else
        {
            lblTimerPressResult.Visible = true;
            lblTimerPressResult.ForeColor = System.Drawing.Color.Red;
            lblTimerPressResult.Text = "Wrong";
            timerWrongCount = timerWrongCount + 1;


            lblisWrongCount.Visible = true;
            lblisWrongCount.ForeColor = System.Drawing.Color.Red;
            lblisWrongCount.Text = "Button press on wrong time: " + timerWrongCount;


        }
    }

    //protected void btnC_Click(object sender, EventArgs e)
    //{
    // if(lbl1.Text=="0") 
    //    lbl1.Text = "1";


    //}

    //protected void btnA_Click(object sender, EventArgs e)
    //{
    //    if (lbl2.Text == "0")
    //        lbl2.Text = "2";

    //}

    //protected void btnB_Click(object sender, EventArgs e)
    //{
    //    if(lbl4.Text=="0") 
    //    lbl4.Text = "4";
    //}

    //protected void btnD_Click(object sender, EventArgs e)
    //{
    //    if(lbl3.Text=="0") 
    //    lbl3.Text = "3";
    //}

    //protected void btnABCDFinal_Click(object sender, EventArgs e)
    //{
    //    if (lbl1.Text == "1" && lbl2.Text == "2" && lbl4.Text == "4" && lbl3.Text == "3")
    //    {
    //        lblABCDStatus.Visible = true;
    //        lblABCDStatus.ForeColor = System.Drawing.Color.Green;
    //        lblABCDStatus.Text = "Right";
    //    }
    //    else
    //    {
    //        lblABCDStatus.Visible = true;
    //        lblABCDStatus.ForeColor = System.Drawing.Color.Red;
    //        lblABCDStatus.Text = "Wrong";
    //    }
    //}

    public enum ImageData
    {

        Tree = 1,
        Bird = 2,
        House = 3,
        Car = 4


    }

    protected void btnTree_Click(object sender, EventArgs e)
    {
        // string img=img.ima
        string fileName = Path.GetFileName(img.ImageUrl);
        int fileNo = Convert.ToInt32(fileName.Substring(0, fileName.IndexOf(".")));
        if (fileNo >= 40)
        {
            Timer1.Enabled = false;
            btnTimeStop.Enabled = false;
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Thank You!! Task Completed Successfully.');", true);
            // Response.Redirect(Request.RawUrl);

        }
        if (fileNo == 1 || fileNo == 5 || fileNo == 9 || fileNo == 13 || fileNo == 17 || fileNo == 21 || fileNo == 25 || fileNo == 29 || fileNo == 33 || fileNo == 37)
        {
            img.ImageUrl = url + (fileNo + 1) + ".jpg";
            imageCount = imageCount + 1;
            if (fileNo == 5 || fileNo == 10 || fileNo == 15 || fileNo == 20 || fileNo == 25 || fileNo == 30 || fileNo == 35 || fileNo == 40 || fileNo == 45 || fileNo == 50)
            {
                if (Panel1.BackColor == Color.Black || Panel1.BackColor == Color.Red || Panel1.BackColor == Color.Green)
                    Panel1.BackColor = Color.Yellow;


            }
        }
    }

    protected void btnBird_Click(object sender, EventArgs e)
    {
        // string img=img.ima
        string fileName = Path.GetFileName(img.ImageUrl);
        int fileNo = Convert.ToInt32(fileName.Substring(0, fileName.IndexOf(".")));
        if (fileNo >= 40)
        {
            Timer1.Enabled = false;
            btnTimeStop.Enabled = false;
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Thank You!! Task Completed Successfully.');", true);
            // Response.Redirect(Request.RawUrl);

        }
        if (fileNo == 2 || fileNo == 6 || fileNo == 10 || fileNo == 14 || fileNo == 18 || fileNo == 22 || fileNo == 26 || fileNo == 30 || fileNo == 34 || fileNo == 38)
        {
            img.ImageUrl = url + (fileNo + 1) + ".jpg";
            imageCount = imageCount + 1;
            if (fileNo == 5 || fileNo == 10 || fileNo == 15 || fileNo == 20 || fileNo == 25 || fileNo == 30 || fileNo == 35 || fileNo == 40 || fileNo == 45 || fileNo == 50)
            {
                if (Panel1.BackColor == Color.Black || Panel1.BackColor == Color.Yellow || Panel1.BackColor == Color.Green)
                    Panel1.BackColor = Color.Red;


            }
        }
    }

    protected void btnHouse_Click(object sender, EventArgs e)
    {
        // string img=img.ima
        string fileName = Path.GetFileName(img.ImageUrl);
        int fileNo = Convert.ToInt32(fileName.Substring(0, fileName.IndexOf(".")));
        if (fileNo >= 40)
        {
            Timer1.Enabled = false;
            btnTimeStop.Enabled = false;
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Thank You!! Task Completed Successfully.');", true);
            //Response.Redirect(Request.RawUrl);

        }
        if (fileNo == 3 || fileNo == 7 || fileNo == 11 || fileNo == 15 || fileNo == 19 || fileNo == 23 || fileNo == 27 || fileNo == 31 || fileNo == 35 || fileNo == 39)
        {
            img.ImageUrl = url + (fileNo + 1) + ".jpg";
            imageCount = imageCount + 1;
            if (fileNo == 5 || fileNo == 10 || fileNo == 15 || fileNo == 20 || fileNo == 25 || fileNo == 30 || fileNo == 35 || fileNo == 40 || fileNo == 45 || fileNo == 50)
            {
                if (Panel1.BackColor == Color.Black || Panel1.BackColor == Color.Yellow || Panel1.BackColor == Color.Red)
                    Panel1.BackColor = Color.Green;


            }
        }
    }

    protected void btnCar_Click(object sender, EventArgs e)
    {
        // string img=img.ima
        string fileName = Path.GetFileName(img.ImageUrl);
        int fileNo = Convert.ToInt32(fileName.Substring(0, fileName.IndexOf(".")));
        if (fileNo >= 40)
        {
            Timer1.Enabled = false;
            btnTimeStop.Enabled = false;
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Thank You!! Task Completed Successfully.');", true);
            //Response.Redirect(Request.RawUrl);

        }
        if (fileNo == 4 || fileNo == 8 || fileNo == 12 || fileNo == 16 || fileNo == 20 || fileNo == 24 || fileNo == 28 || fileNo == 32 || fileNo == 36 || fileNo == 40)
        {
            img.ImageUrl = url + (fileNo + 1) + ".jpg";
            imageCount = imageCount + 1;
            if (fileNo == 5 || fileNo == 10 || fileNo == 15 || fileNo == 20 || fileNo == 25 || fileNo == 30 || fileNo == 35 || fileNo == 40 || fileNo == 45 || fileNo == 50)
            {
                if (Panel1.BackColor == Color.Green || Panel1.BackColor == Color.Yellow || Panel1.BackColor == Color.Red)
                    Panel1.BackColor = Color.Black;


            }

        }
    }
}

