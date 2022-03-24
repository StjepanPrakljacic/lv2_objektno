using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lv2_objektno
{
    class Poligon: GrafObj
    {
        #region Properties
        public List<Point> mPoligonPoints = new List<Point>();
        #endregion

        #region Constructors
        public Poligon() { }
        public Poligon(GrafObj GrafObjHelper) : base(GrafObjHelper)
        {
            mPoligonPoints.Add(GrafObjHelper.GetCoordinate());
        }
        #endregion

        #region Methods
        public void AddPoligonPoints(GrafObj GrafObjHelper)
        {
            mPoligonPoints.Add(GrafObjHelper.GetCoordinate());
        }
        public override void DrawGrafObj(Graphics GraphicsHelper)
        {
            Point[] mPoints = mPoligonPoints.ToArray();
            GraphicsHelper.DrawPolygon(new Pen(this.GetColor()), mPoints);
        }
        #endregion

    }
}
