using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lv2_objektno
{
    public partial class Form1 : Form
    {
        #region Properties

        Graphics mGraphicsHelper;
        GrafObj mGrafObjHelper, mPoligonHelper;
        GrafObj mDrawObj;
        Poligon mDrawPoligon; 
        Point mStartPoint, mCurrentPoint, mPoligonPoint;
        Color mColor;
        bool bMouseDown;
        List<GrafObj> ListOfDrawObj = new List<GrafObj> () ;
        int cnt = 0;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mGraphicsHelper = CreateGraphics();
            bMouseDown = false;
            mColor = Color.Green;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (GrafObj item in ListOfDrawObj)
            {
                item.DrawGrafObj(mGraphicsHelper);
            }
            if (bMouseDown)
            {
                if (rbLine.Checked)
                {
                    mDrawObj = new Linija(mGrafObjHelper, mCurrentPoint);
                    mDrawObj.DrawGrafObj(mGraphicsHelper);
                }
                else if (rbRectangle.Checked)
                {
                    mDrawObj = new Pravokutnik(mGrafObjHelper, mCurrentPoint);
                    mDrawObj.DrawGrafObj(mGraphicsHelper);
                }
                else if (rbCircle.Checked)
                {
                    mDrawObj = new Kruznica(mGrafObjHelper, mCurrentPoint);
                    mDrawObj.DrawGrafObj(mGraphicsHelper);
                }
                else if (rbEllipse.Checked)
                {
                    mDrawObj = new Elipsa(mGrafObjHelper, mCurrentPoint);
                    mDrawObj.DrawGrafObj(mGraphicsHelper);
                }




                
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            bMouseDown = true;
            mStartPoint = e.Location;
            if (rbRed.Checked)
            {
                this.mColor = Color.Red;
            }
            else if (rbBlack.Checked)
            {
                this.mColor = Color.Black;
            }
            else if (rbBlue.Checked)
            {
                this.mColor = Color.Blue;
            }
            mGrafObjHelper = new GrafObj();
            mGrafObjHelper.SetColor(this.mColor);
            mGrafObjHelper.SetCoordinate(this.mStartPoint);

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bMouseDown)
            {
                mCurrentPoint = e.Location;
                this.Invalidate();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            bMouseDown = false;
            ListOfDrawObj.Add(mDrawObj);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbPolygon.Checked)
            {
                mPoligonPoint = e.Location;
                mPoligonHelper = new GrafObj(this.mColor, this.mPoligonPoint);
                if (cnt == 0)
                {
                    mDrawPoligon = new Poligon(mPoligonHelper);
                    cnt++;
                }
                else if (cnt < 2)
                {
                    mDrawPoligon.AddPoligonPoints(mPoligonHelper);
                    cnt++;
                }
                else if (cnt <= 3)
                {
                    mDrawPoligon.AddPoligonPoints(mPoligonHelper);
                    mDrawPoligon.DrawGrafObj(mGraphicsHelper);
                    ListOfDrawObj.Add(mDrawPoligon);
                    cnt = 0;
                }
            }
        }
    }
}
